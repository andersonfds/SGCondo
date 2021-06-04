using SGCondo.Framework.Model;
using SGCondo.Framework.Service;
using System.Collections.Generic;

namespace SGCondo.Data.Service
{
    public class ErrorNotification : IErrorNotification
    {
        private readonly IList<ErrorDetails> Errors;

        public ErrorNotification()
        {
            Errors = new List<ErrorDetails>();
        }

        public void Add(ErrorDetails error)
        {
            Errors.Add(error);
        }

        public void Add(string resourceId, string domain)
        {
            Errors.Add(new ErrorDetails { Domain = domain, Message = "none" });
        }

        public Error Get()
        {
            return new Error();
        }

        public bool Has()
        {
            return Errors.Count > 0;
        }
    }
}
