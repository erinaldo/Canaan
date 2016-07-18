using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Validacao 
    {
        public static bool IsValid(Dados.CanaanModelContainer contexto) 
        {
            if (contexto.GetValidationErrors().Count() > 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public static string GetErrors(Dados.CanaanModelContainer contexto) 
        {
            string err_msg = "Ocorreram erros ao salvar o registro:\n\n";

            foreach (var err in contexto.GetValidationErrors())
            {
                foreach (var err_item in err.ValidationErrors)
                {
                    err_msg += "- " + err_item.ErrorMessage + "\n";
                }
            }

            return err_msg;
        }
    }
    //[Serializable]
    //public class EntityValidationResult
    //{
    //    public IList<ValidationResult> ValidationErrors { get; private set; }
    //    public bool HasError
    //    {
    //        get { return ValidationErrors.Count > 0; }
    //    }

    //    public EntityValidationResult(IList<ValidationResult> violations = null)
    //    {
    //        ValidationErrors = violations ?? new List<ValidationResult>();
    //    }
    //}

    //public class DataAnnotation
    //{
    //    public static EntityValidationResult ValidateEntity<T>(T entity)
    //    {
    //        return new EntityValidator<T>().Validate(entity);
    //    }

    //    public static string GetErrors(IList<ValidationResult> lista) 
    //    {
    //        if (lista.Count > 0)
    //        {
    //            var erros = "Ocorreram alguns erros ao salvar o registro:\n\n";
    //            foreach (var item in lista)
    //            {
    //                erros += "- " + item.ErrorMessage + "\n";
    //            }

    //            return erros;
    //        }
    //        else 
    //        {
    //            return "Nenhum erro encontrado";
    //        }
    //    }
    //}

    //public class EntityValidator<T>
    //{
    //    public EntityValidationResult Validate(T entity)
    //    {
    //        var validationResults = new List<ValidationResult>();
    //        var vc = new ValidationContext(entity, null, null);
    //        var isValid = Validator.TryValidateObject(entity, vc, validationResults, true);

    //        return new EntityValidationResult(validationResults);
    //    }
    //}
}
