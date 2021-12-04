using System;
using VersenyFeladat2.Codes.Exceptions;

namespace VersenyFeladat2.Codes
{
    public class Competitor
    {
        #region Variables

        public string Name { get; private set; }
        public string ClubName { get; private set; }
        public string StartNumber { get; private set; }
        public string Result { get; private set; }
        public int BirthYear { get; private set; }
        private Event AttendedEvent { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor of the competitor class
        /// Set all of the given data for it
        /// </summary>
        /// <param name="name">string type input data - the name of the competitor</param>
        /// <param name="clubname">string type input data - the club name of the competitor</param>
        /// <param name="birthyear">string type input data - the year of the birth date of the competitor</param>
        public Competitor(string name, string clubname, int birthyear, string startNumber, Event attendedEvent, string result)
        {
            if (string.IsNullOrEmpty(name)) name = "ND";
            if (string.IsNullOrEmpty(clubname)) clubname = "ND";
            if (birthyear > DateTime.Now.Year) birthyear = DateTime.Now.Year;
            if (birthyear < DateTime.Now.Year-200) birthyear = -1;
            if (string.IsNullOrEmpty(startNumber)) startNumber = "ND";
            if (string.IsNullOrEmpty(result)) result = "ND";
            if (attendedEvent == null) throw new EventNullPointerException();

            this.Name = name;
            this.ClubName = clubname;
            this.BirthYear = birthyear;
            this.AttendedEvent = attendedEvent;
            this.StartNumber = startNumber;
            this.Result = result;
        }

        /// <summary>
        /// If none of the input data given we can call this to create
        /// a default ND data structure for the competitor class
        /// </summary>
        public Competitor() : this(null, null, -1, null, new Event(), null) { }

        #endregion

        #region Setters

        /// <summary>
        /// Set the name of the competitor
        /// </summary>
        /// <param name="name">string type input data - the name of the competitor</param>
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) name = "ND";

            this.Name = name;
        }
        
        /// <summary>
        /// Set the club name of the competitor
        /// </summary>
        /// <param name="clubname">string type input data - the club name of the competitor</param>
        public void SetClubName(string clubname)
        {
            if (string.IsNullOrEmpty(clubname)) clubname = "ND";

            this.ClubName = clubname;
        }

        /// <summary>
        /// Set the birth year of the competitor
        /// </summary>
        /// <param name="birthyear">int type input data - the year of the birth date of the competitor</param>
        public void SetBirthYear(int birthyear)
        {
            if (birthyear > DateTime.Now.Year) birthyear = DateTime.Now.Year;
            if (birthyear < DateTime.Now.Year - 200) birthyear = -1;

            this.BirthYear = birthyear;
        }

        /// <summary>
        /// Set the start number of the competitor
        /// </summary>
        /// <param name="birthyear">string type input data - the start number of the competitor</param>
        public void SetStartNumber(string startNumber)
        {
            if (string.IsNullOrEmpty(startNumber)) startNumber = "ND";
            this.StartNumber = startNumber;
        }

        /// <summary>
        /// Set the result of the competitor
        /// </summary>
        /// <param name="birthyear">string type input data - the result of the competitor</param>
        public void SetResult(string result)
        {
            if (string.IsNullOrEmpty(result)) result = "ND";
            this.Result = result;
        }

        /// <summary>
        /// Not exactly create, we Specify the event here if it is given from the file
        /// </summary>
        /// <param name="attendedEvent">Event type input - Create a new event class with the given datas</param>
        public void CreateEvent(Event attendedEvent)
        {
            try
            {
                if (attendedEvent == null) throw new EventNullPointerException();

                this.AttendedEvent = attendedEvent;
            }
            catch (Exception)
            { // we don't want to handle the exception right here, so just throw it to caller
                throw;
            }
        }

        /// <summary>
        /// Not exactly create, we Specify the event here if it is given from the file
        /// </summary>
        /// <param name="eventName">string type input - assign the event name to the newly created Event</param>
        /// <param name="eventID">string type input - assign the event id to the newly created Event</param>
        public void CreateEvent(string eventName, string eventID)
        {
            try
            {
                Event attendedEvent = new Event(eventName, eventID);
                this.AttendedEvent = attendedEvent;
            }
            catch (Exception)
            { // we don't want to handle the exception right here, so just throw it to caller
                throw;
            }
        }

        #endregion

        #region Getters

        public Event GetEvent()
        {
            if (this.AttendedEvent == null) CreateEvent(new Event());
            return this.AttendedEvent;
        }

        #endregion

        #region Override methods

        public override string ToString()
        {
            return string.Format
                (
                    "[" +
                    "Name=\"{0}\"," +
                    "ClubName=\"{1}\"," +
                    "BirthYear=\"{2}\"," +
                    "StartNumber=\"{3}\"," +
                    "Result=\"{4}\"," +
                    "AttendedEvent=\"{5}\"" +
                    "]",
                    this.Name,
                    this.ClubName,
                    this.BirthYear,
                    this.StartNumber,
                    this.Result,
                    this.AttendedEvent.ToString()
                );
        }

        #endregion
    }
}
