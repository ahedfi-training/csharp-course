using System;

namespace FileManager
{
    public class ApplicationException : Exception
    {
        public ApplicationException()
            : base()
        {

        }

        public ApplicationException(string message)
           : base(message)
        {

        }
    }
}
