using System.Collections.Generic;

namespace SGCondo.Framework.Model
{
    public class Error
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public string Status { get; set; }

        public IEnumerable<ErrorDetails> Errors { get; set; }
    }

    public class ErrorDetails
    {
        public string Message { get; set; }

        public string Domain { get; set; }
    }
}
