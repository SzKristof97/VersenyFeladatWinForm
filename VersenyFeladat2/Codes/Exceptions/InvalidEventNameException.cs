using System;

namespace VersenyFeladat2.Codes.Exceptions
{
    internal class InvalidEventNameException : Exception
    {
        #region Constructors

        public InvalidEventNameException() { }

        public InvalidEventNameException(string name) :
            base(string.Format("Invalid Event Name: {0}", name))
        {

        }

        #endregion
    }
}
