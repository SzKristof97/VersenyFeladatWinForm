using VersenyFeladat2.Codes.Exceptions;

namespace VersenyFeladat2.Codes
{
    public class Event
    {
        #region Variables

        public string EventName { get; private set; }
        public string EventID { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor of the Event class
        /// Set the event name and ID if they given
        /// 
        /// if one of the input data is null or empty, it throws back an exception
        /// </summary>
        /// <param name="eventName">string type input - The name of the event</param>
        /// <param name="eventID">string type input - The ID of the event</param>
        public Event(string eventName, string eventID) 
        {
            if (string.IsNullOrEmpty(eventName)) throw new InvalidEventNameException(eventName);
            if (string.IsNullOrEmpty(eventID)) throw new InvalidEventIDException(eventID);

            this.EventName = eventName;
            this.EventID = eventID;
        }

        /// <summary>
        /// Constructor of the Event class
        /// 
        /// If there is no given value, 
        /// gives the default ND (Not Defined) to every variable
        /// </summary>
        public Event() : this("ND", "ND") { }

        #endregion

        #region Setters

        /// <summary>
        /// Set the name of the event
        /// </summary>
        /// <param name="eventName">string type input - The name of the event</param>
        public void SetEventName(string eventName)
        {
            if (string.IsNullOrEmpty(eventName)) throw new InvalidEventNameException(eventName);

            this.EventName = eventName;
        }

        /// <summary>
        /// Set the ID of the event
        /// </summary>
        /// <param name="eventID">string type input - The ID of the event</param>
        public void SetEventID(string eventID)
        {
            if (string.IsNullOrEmpty(eventID)) throw new InvalidEventIDException(eventID);

            this.EventID = eventID;
        }
        #endregion

        #region Override Methods
        public override string ToString()
        {
            return string.Format
                (
                    "[" +
                    "EventName=\"{0}\"," +
                    "EventID=\"{1}\"" +
                    "]",
                    this.EventName,
                    this.EventID
                );
        }
        #endregion
    }
}
