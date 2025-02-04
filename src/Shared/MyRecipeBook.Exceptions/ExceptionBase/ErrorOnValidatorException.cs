using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeBook.Exceptions.ExceptionBase
{
    public class ErrorOnValidatorException : MyRecipeBookException
    {
        public IList<string> ErrorsMessages { get; set; }

        public ErrorOnValidatorException(IList<string> errors) 
        { 
            ErrorsMessages = errors;    
        }

    }
}
