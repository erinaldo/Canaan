using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;
using Filtro = Canaan.Lib.Filtro;

namespace Canaan.Telas.Base
{
    public partial class FormFilterBase : XtraForm
    {
        #region PROPRIEDADES

        private Type entityType;

        public FilterExpressionCollection FilterExpression { get; set; }

        public Filtro objLibFiltro { get; set; }

        public List<Propriedade> Propriedades { get; set; }

        public Control ControlParametro { get; set; }

        #endregion

        #region CONSTRUTOR

        /// <summary>
        /// Contrutor
        /// </summary>
        /// <param name="type"></param>
        public FormFilterBase(Type type)
        {
            InitializeComponent();

            //Incializa campos
            entityType = type;
            FilterExpression = new FilterExpressionCollection();
            objLibFiltro = new Filtro();
        }

        public FormFilterBase()
        {

        }


        #endregion

        #region EVENTOS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFilterBase_Load(object sender, EventArgs e)
        {
            gridExpression.AutoGenerateColumns = false;

            //Verifica se o grid de parametros possui algum item
            if (gridExpression.Rows.Count == 0)
                cbLogicos.Enabled = false;


            Propriedades = new List<Propriedade>();

            //Carrega Propriedades do tipo atual
            LoadProperties(entityType, Propriedades);

            //Carrega Propriedades das subclasses
            LoadPropertiesSubClass(entityType);

            //Carrega Lista
            CarregaLista();


            //Carrega Operadores Logicos
            LoadOperadoresLogicos();

            //Carrega Operadores Relacionais
            LoadOperadoresRelacionais();
        }

        /// <summary>
        /// Adiciona Paramentro no Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            //Pega operado relaciona
            var Relacional = (EnumOperadorRelacional)Enum.Parse(typeof(EnumOperadorRelacional), cbRelacionais.SelectedItem.ToString());

            //Pega operador logico
            var Logico = (EnumOperadorLogico)Enum.Parse(typeof(EnumOperadorLogico), cbLogicos.SelectedItem.ToString());

            //Pega Propriedade
            var propriedade = lbProperties.SelectedItem as Propriedade;


            if (propriedade == null)
                return;

            //Cria uma expressao
            var expression = new FilterExpression
            {
                Property = propriedade.Nome,
                Relacional = Relacional,
                Logico = Logico,
                Type = propriedade.Type,
                Valor = ControlParametro.Text,
                Classe = propriedade.Classe

            };

            //Aciciona expressão na lista
            FilterExpression.AddFilterExpression(expression);

            //Carrega Grid Com lista de expressoes
            gridExpression.DataSource = FilterExpression;
        }

        /// <summary>
        /// Remove Parametro do Filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRemover_Click(object sender, EventArgs e)
        {
            if (gridExpression.Rows.Count > 0)
            {
                var indexSelected = gridExpression.SelectedRows[0].Index;
                FilterExpression.RemoveAt(indexSelected);
            }
        }

        /// <summary>
        /// Executa Filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExecutar_Click(object sender, EventArgs e)
        {
            if (FilterExpression.Count > 0)
            {
                Close();
            }
        }

        /// <summary>
        /// Salva Filtro No Banco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria Filtro
                var Filtro = new Dados.Filtro
                {
                    Nome = txtNomeFiltro.Text,
                    idUsuario = (ckGlobal.Checked == true) ? new Nullable<int>() : Session.Instance.Usuario.IdUsuario,
                    EntidadeName = entityType.FullName,
                    Padrao = ckPadrao.Checked
                };

                //Carrega os Paramentros
                foreach (var item in FilterExpression)
                {
                    Filtro.Parametro.Add(
                        new Parametro
                        {
                            Propriedade = item.Property,
                            Type = item.Type,
                            OperadorLogico = item.Logico,
                            OperadorRelacional = item.Relacional,
                            Valor = string.IsNullOrEmpty(item.Valor) ? null : item.Valor,
                            Classe = item.Classe
                        }
                    );
                }

                Filtro = objLibFiltro.Insert(Filtro);

                MessageBoxUtilities.MessageInfo(string.Format("Filtro {0} Salvo com Sucesso", Filtro.Nome));
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridExpression_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (gridExpression.Rows.Count > 0)
                cbLogicos.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            var propriedade = lbProperties.SelectedItem as Propriedade;
            CriaControlPadrao(propriedade);
        }

        #endregion

        #region METODOS

        private void LoadProperties(Type entity, List<Propriedade> properties, string className = null, string @class = null)
        {
            //Remove o ponto da 1 iteração
            if (!string.IsNullOrEmpty(className))
                if (className.StartsWith("."))
                    className = className.Remove(0, 1);

            //Pega Metadata relacionado com EntityData
            var metadata = (MetadataTypeAttribute)entity.GetCustomAttributes(typeof(MetadataTypeAttribute), true).FirstOrDefault();

            if (metadata == null)
                return;



            //Pega lista de Properies que possui o attributo FilterAttribute
            var result = new AssociatedMetadataTypeTypeDescriptionProvider(entity, metadata.MetadataClassType).GetTypeDescriptor(entity)
                                                                                                                  .GetProperties().Cast<PropertyDescriptor>()
                                                                                                                  .Where(a => HasMetadataPropertyAttribute(a, a.Name, typeof(FilterAttribute)))
                                                                                                                  .Select(a => a)
                                                                                                                  .ToList();
            if (!string.IsNullOrEmpty(className))
            {
                properties.AddRange(result.Where(a => !a.PropertyType.FullName.Contains("Canaan.Dados") || a.PropertyType.FullName.Contains("Enum")).Select(a => new Propriedade
                                                  {
                                                      Nome = string.Format("{0}.{1}", className, a.Name),
                                                      Type = a.PropertyType.FullName,
                                                      Classe = @class
                                                  })
                                          .ToList());
            }
            else
            {
                properties.AddRange(result.Where(a => !a.PropertyType.FullName.Contains("Canaan.Dados") || a.PropertyType.FullName.Contains("Enum"))
                                          .Select(a => new Propriedade
                                              {
                                                  Nome = a.Name,
                                                  Type = a.PropertyType.FullName,
                                                  Classe = null
                                              }).ToList());
            }

            foreach (var item in result.Where(a => a.PropertyType.FullName.Contains("Canaan.Dados")))
            {
                LoadProperties(item.PropertyType, properties, string.Format("{0}.{1}", className, item.PropertyType.Name), item.PropertyType.FullName);

                LoadPropertiesSubClass(item.PropertyType);

                #region Comentario
                ////if (item.PropertyType.FullName.Contains("Canaan.Dados"))
                //    LoadProperties(item.PropertyType, properties, item.PropertyType.Name);
                ////else
                //    //LoadProperties(item.PropertyType, properties);
                #endregion
            }

        }

        private static bool HasMetadataPropertyAttribute(PropertyDescriptor property, string name, Type attributeType)
        {
            if (property == null)
                return false;

            var hasAttribute = property.Attributes.Cast<object>().Any(a => a.GetType() == attributeType);
            return hasAttribute;
        }

        private void LoadOperadoresRelacionais()
        {
            var result = Enum.GetValues(typeof(EnumOperadorRelacional)).Cast<EnumOperadorRelacional>().Select(a => a.ToString()).ToList();
            cbRelacionais.DataSource = result;
        }

        private void LoadOperadoresLogicos()
        {
            var result = Enum.GetValues(typeof(EnumOperadorLogico))
                             .Cast<EnumOperadorLogico>()
                             .Where(a => a.ToString() != "None")
                             .Select(a => a.ToString())
                             .ToList();

            cbLogicos.DataSource = result;
        }

        /// <summary>
        /// Cria controle para valor padrão
        /// </summary>
        /// <param name="propriedade"></param>
        private void CriaControlPadrao(Propriedade propriedade)
        {
            try
            {

                if (ControlParametro != null)
                {
                    var control = tbPageFiltro.Controls.Cast<Control>().FirstOrDefault(a => a.Name.Contains("DefaultParameter"));
                    tbPageFiltro.Controls.Remove(control);
                }

                if (!string.IsNullOrEmpty(propriedade.Classe) && !propriedade.Type.Contains("DateTime") && !propriedade.Type.Contains("Boolean"))
                {

                    //Reflection
                    Assembly Ass = Assembly.Load(new AssemblyName("Canaan.Lib"));
                    var typestring = propriedade.Classe.Split('.').LastOrDefault();
                    var ctxType = Ass.GetType(string.Format("Canaan.Lib.{0}", typestring));
                    var instance = Ass.CreateInstance(string.Format("Canaan.Lib.{0}", typestring));
                    var result = ctxType.GetMethod("Get").Invoke(instance, null);

                    var combo = new ComboBox();

                    combo.DataSource = result;
                    combo.DisplayMember = propriedade.Nome.Split('.').LastOrDefault();
                    combo.ValueMember = propriedade.Nome.Split('.').LastOrDefault();

                    ControlParametro = combo;

                }
                else if (propriedade.Type.Contains("Enum"))
                {
                    Assembly Ass = Assembly.Load(new AssemblyName("Canaan.Dados"));
                    var ctxType = Ass.GetType(propriedade.Type);
                    var result = ctxType.GetMembers(BindingFlags.Public | BindingFlags.Static).Select(a => a.Name).ToList();

                    var combo = new ComboBox();
                    combo.DataSource = result;

                    ControlParametro = combo;

                }
                else
                {

                    if (propriedade.Type.ToString().Contains("Date"))
                    {
                        ControlParametro = new DateEdit();
                    }
                    else if (propriedade.Type.ToString().Contains("String") || propriedade.Type.ToString().Contains("Int"))
                    {
                        ControlParametro = new TextBox();
                    }
                    else if (propriedade.Type.ToString().Contains("Boolean"))
                    {
                        bool[] list = { true, false };
                        var drop = new ComboBox();
                        drop.DataSource = list;
                        ControlParametro = drop;
                    }
                }


                ControlParametro.Location = txtParametroPadrao.Location;
                ControlParametro.Name = "DefaultParameter";
                ControlParametro.Width = txtParametroPadrao.Width;
                tbPageFiltro.Controls.Add(ControlParametro);

            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }

        }

        private void CarregaLista()
        {
            lbProperties.ValueMember = "Type";
            lbProperties.DisplayMember = "Nome";
            lbProperties.DataSource = Propriedades;
        }

        private void LoadPropertiesSubClass(Type type)
        {
            var assembly = entityType.Assembly;
            var types = assembly.GetTypes().Where(a => a.IsSubclassOf(type));

            foreach (var item in types)
            {
                LoadProperties(item, Propriedades);
            }
        }

        #endregion
    }

    #region CLASSES

    public class Propriedade
    {
        public string Nome { get; set; }
        public string Type { get; set; }
        public string Classe { get; set; }
    }

    #endregion
}

