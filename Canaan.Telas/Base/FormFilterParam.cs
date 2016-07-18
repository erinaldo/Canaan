using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Lib.Componentes;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Base
{
    public partial class FormFilterParam : XtraForm
    {
        #region PROPRIEDADES

        private FilterExpressionCollection filterCollection;

        public object[] Parametros { get; set; }

        public string Expressao { get; set; }

        #endregion

        #region CONSTRUTOR

        public FormFilterParam(FilterExpressionCollection filterCollection)
        {
            InitializeComponent();
            this.filterCollection = filterCollection;
            Parametros = new object[filterCollection.Count];

            //Configura form
            Expressao = filterCollection.BuildExpression();
            lbExpressao.Text = Expressao;
        }

        #endregion

        #region EVENTOS

        private void FormFilterParam_Load(object sender, EventArgs e)
        {
            CreatForm();
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {

            //Pega lista de controles exceto os que possuem um valor ParamDefault setado
            var lista = tbLayout.Controls.Cast<Control>().Where(a => a.GetType() != typeof(Label) || a.Name.Contains("ParamDefault"));

            //Percorre lista de controles
            foreach (var item in lista.Select((obj, i) => new { obj, i }))
            {
                //Carrega Info TextBox
                if (item.obj as TextBox != null)
                {
                    int value = 0;
                    bool isInt = int.TryParse(item.obj.Text, out value);

                    if (isInt)
                        Parametros[item.i] = value;
                    else
                        Parametros[item.i] = item.obj.Text;
                }
                //Carrega dados do DateEdit
                else if (item.obj as DateEdit != null)
                {
                    Parametros[item.i] = ((DateEdit)item.obj).EditValue;
                }
                //Carrega dados do Label
                else if (item.obj as Label != null)
                {
                    var value = DateTime.Today;
                    var intvalue = int.MinValue;
                    var boolvalue = false;


                    var @enum = filterCollection.FirstOrDefault(a => a.Type.Contains("Enum") && a.Valor == item.obj.Text);

                    if (@enum != null)
                    {
                        Assembly ass = Assembly.Load("Canaan.Dados");
                        var typeEnum = ass.GetType(@enum.Type);
                        Parametros[item.i] = Enum.Parse(typeEnum, @enum.Valor);
                    }
                    else if (DateTime.TryParse(item.obj.Text, out value))
                    {
                        Parametros[item.i] = value;
                    }
                    else if (int.TryParse(item.obj.Text, out intvalue))
                    {
                        Parametros[item.i] = intvalue;
                    }
                    else if (bool.TryParse(item.obj.Text, out boolvalue))
                    {
                        Parametros[item.i] = boolvalue;
                    }
                    else
                    {
                        Parametros[item.i] = item.obj.Text;
                    }

                }
                else if (item.obj as CComboFilter != null)
                {
                    var cb = item.obj as CComboFilter;

                    var @enum = filterCollection.FirstOrDefault(a => a.Type.Contains("Enum") && a.Type == cb.TypeOfFiltro);

                    if (@enum != null)
                    {
                        Assembly ass = Assembly.Load("Canaan.Dados");
                        var typeEnum = ass.GetType(@enum.Type);
                        Parametros[item.i] = Enum.Parse(typeEnum, cb.Text);
                    }
                    else if (cb.TypeOfFiltro.Contains("Boolean"))
                    {
                        var prop = filterCollection.FirstOrDefault(a => a.Type.Contains("Boolean") && a.Property == cb.Propriedade);
                        Parametros[item.i] = bool.Parse(cb.Text);
                    }
                    else
                    {
                        Parametros[item.i] = cb.Text;
                    }

                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion

        #region METODOS

        private void CreatForm()
        {
            foreach (var item in filterCollection.Select((obj, i) => new { obj, i }))
            {

                if (!string.IsNullOrEmpty(item.obj.Classe) && !item.obj.Type.Contains("DateTime") && !item.obj.Type.Contains("Boolean") && !item.obj.Type.StartsWith("@"))
                {

                    if (string.IsNullOrEmpty(item.obj.Valor))
                    {
                        //Reflection
                        Assembly Ass = Assembly.Load(new AssemblyName("Canaan.Lib"));
                        var typestring = item.obj.Classe.Split('.').LastOrDefault();
                        var ctxType = Ass.GetType(string.Format("Canaan.Lib.{0}", typestring));
                        var instance = Ass.CreateInstance(string.Format("Canaan.Lib.{0}", typestring));
                        var result = ctxType.GetMethod("Get").Invoke(instance, null);

                        var combo = new CComboFilter
                            {
                                Width = tbLayout.Width
                            };

                        combo.DataSource = result;
                        combo.TypeOfFiltro = item.obj.Type;
                        combo.Propriedade = item.obj.Property;
                        combo.DisplayMember = item.obj.Property.Split('.').LastOrDefault();
                        combo.ValueMember = item.obj.Property.Split('.').LastOrDefault();

                        tbLayout.Controls.Add(new Label { Text = item.obj.Property, Width = tbLayout.Width });
                        tbLayout.Controls.Add(combo);
                    }
                    else
                    {
                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(new Label { Width = tbLayout.Width, Text = item.obj.Valor, Name = "ParamDefault" + item.i });
                    }

                }
                else if (item.obj.Type.Contains("Enum"))
                {
                    if (string.IsNullOrEmpty(item.obj.Valor))
                    {

                        Assembly Ass = Assembly.Load(new AssemblyName("Canaan.Dados"));
                        var ctxType = Ass.GetType(item.obj.Type);
                        var result = ctxType.GetMembers(BindingFlags.Public | BindingFlags.Static).Select(a => a.Name).ToList();

                        var combo = new CComboFilter { Width = tbLayout.Width };
                        combo.TypeOfFiltro = item.obj.Type;
                        combo.DataSource = result;

                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(combo);
                    }
                    else
                    {
                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(new Label { Width = tbLayout.Width, Text = item.obj.Valor, Name = "ParamDefault" + item.i });
                    }

                }
                else if (item.obj.Type.ToString().Contains("Date"))
                {

                    if (string.IsNullOrEmpty(item.obj.Valor))
                    {
                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(GetControlForType(item.obj.Type));
                    }
                    else
                    {

                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(new Label { Text = item.obj.Valor, Name = "ParamDefault" + item.i });
                    }
                }
                else if (item.obj.Type.ToString().Contains("Boolean"))
                {
                    if (string.IsNullOrEmpty(item.obj.Valor))
                    {
                        bool[] list = { true, false };
                        var drop = new CComboFilter { Width = tbLayout.Width };
                        drop.TypeOfFiltro = item.obj.Type;
                        drop.DataSource = list;

                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(drop);
                    }
                    else
                    {
                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(new Label { Width = tbLayout.Width, Text = item.obj.Valor, Name = "ParamDefault" + item.i });
                    }
                }
                else if (item.obj.Type.ToString().Contains("Int") && item.obj.Valor != null && !item.obj.Valor.StartsWith("@"))
                {
                    if (string.IsNullOrEmpty(item.obj.Valor))
                    {
                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(new TextBox { Width = tbLayout.Width });
                    }
                    else
                    {
                        tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                        tbLayout.Controls.Add(new Label { Text = item.obj.Valor, Name = "ParamDefault" + item.i });
                    }
                }
                else if (!string.IsNullOrEmpty(item.obj.Valor) && !item.obj.Valor.StartsWith("@"))
                {
                    tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                    tbLayout.Controls.Add(new Label { Width = tbLayout.Width, Text = item.obj.Valor, Name = "ParamDefault" + item.i });
                }
                else if (item.obj.Valor != null && item.obj.Valor.StartsWith("@"))
                {
                    //tableLayoutPanel1.Controls.Add(new Label { Text = item.obj.Property });
                    tbLayout.Controls.Add(new Label { Text = Session.Instance.Contexto.IdFilial.ToString(), Name = "ParamDefault" + item.i, Width = tbLayout.Width, Visible = false });
                }
                else
                {
                    tbLayout.Controls.Add(new Label { Text = item.obj.Property });
                    tbLayout.Controls.Add(GetControlForType(item.obj.Type));
                }
            }
        }

        private Control GetControlForType(string type)
        {
            if (type.Contains("Int") || type.Contains("String"))
            {
                return new TextBox { Width = tbLayout.Width };
            }
            else if (type.Contains("Date"))
            {
                return new DateEdit { Width = tbLayout.Width };
            }

            return null;
        }

        #endregion

    }
}
