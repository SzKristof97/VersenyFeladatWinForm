using System;

namespace VersenyFeladat2.Codes.Exceptions
{
    internal class InvalidEventIDException : Exception
    {

        #region Constructors

        public InvalidEventIDException() { }

        public InvalidEventIDException(string id) :
            base(string.Format("Invalid Event ID: {0}", id))
        {

        }

        #endregion
    }
}
