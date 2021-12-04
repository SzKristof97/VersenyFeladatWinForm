using System;

namespace VersenyFeladat2.Codes.Exceptions
{
    internal class EventNullPointerException : Exception
    {
        #region Constructors

        public EventNullPointerException() : base("Event is not set to an istance!") { }

        #endregion
    }
}
