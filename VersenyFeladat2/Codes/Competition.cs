using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using VersenyFeladat2.Codes.Templates;

namespace VersenyFeladat2.Codes
{
    public class Competition
    {
        #region Variables

        private List<Competitor> competitors;
        
        public int Id { get; private set; }

        #endregion

        #region Constructors

        public Competition(int id) {
            competitors = new List<Competitor>();
            Id = id;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add a competitor to the list
        /// 
        /// if the competitor is already added it does nothing
        /// </summary>
        /// <param name="name">string type input - name of the competitor</param>
        /// <param name="clubname">string type input - club name of the competitor</param>
        public void AddCompetitor(string name, string clubname)
        {
            Competitor competitor = new Competitor();
            competitor.SetName(name);
            competitor.SetClubName(clubname);

            if (ContainsCompetitor(competitor)) return;
            competitors.Add(competitor);
        }

        /// <summary>
        /// Remove a competitor from the list
        /// 
        /// if the competitor is already added it does nothing
        /// </summary>
        /// <param name="name">string type input - name of the competitor</param>
        /// <param name="clubname">string type input - club name of the competitor</param>
        public void RemoveCompetitor(string name, string clubname)
        {
            Competitor competitor = GetCompetitor(name, clubname);
            RemoveCompetitor(competitor);
        }

        /// <summary>
        /// Remove a competitor from the list
        /// 
        /// if the competitor is already added it does nothing
        /// </summary>
        /// <param name="competitor">Competitor type input</param>
        public void RemoveCompetitor(Competitor competitor)
        {
            if (!ContainsCompetitor(competitor)) return;

            competitors.Remove(competitor);
        }

        /// <summary>
        /// Get the competitor from the list by his/her name and club name
        /// </summary>
        /// <param name="name">string type input - name of the competitor</param>
        /// <param name="clubname">string type input - club name of the competitor</param>
        /// <returns>if it found the competitor return with it, otherwise it return null</returns>
        public Competitor GetCompetitor(string name, string clubname)
        {
            foreach (Competitor c in competitors)
            {
                if (c.Name.Equals(name) && c.ClubName.Equals(clubname))
                    return c;
            }
            return null;
        }

        /// <summary>
        /// Collect every competitor who does the event 
        /// </summary>
        /// <returns></returns>
        public List<Competitor> GetResultList()
        {
            List<Competitor> result = new List<Competitor>();

            foreach (Competitor competitor in competitors)
            {
                if (competitor.Result != "ND" &&
                    competitor.GetEvent().EventID != "ND" &&
                    competitor.StartNumber != "ND")
                {
                    result.Add(competitor);
                }
            }

            return result;
        }

        /// <summary>
        /// Collect every competitor who entered but not does the event
        /// </summary>
        /// <returns></returns>
        public List<Competitor> GetEnteredButNotStarted()
        {
            List<Competitor> result = new List<Competitor>();
            List<Competitor> mainResult = GetResultList();

            foreach (Competitor competitor in competitors)
            {
                if (competitor.GetEvent().EventID != "ND" &&
                    competitor.StartNumber != "ND")
                {
                    if (!mainResult.Contains(competitor))
                    {
                        result.Add(competitor);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Collect every competitor who entered but not does the event
        /// </summary>
        /// <returns></returns>
        public List<Competitor> GetNotEnteredButStarted()
        {
            List<Competitor> result = new List<Competitor>();
            List<Competitor> mainResult = GetResultList();

            foreach (Competitor competitor in competitors)
            {
                if (competitor.GetEvent().EventID != "ND" &&
                    competitor.Result != "ND")
                {
                    if (!mainResult.Contains(competitor))
                    {
                        result.Add(competitor);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Return with the whole list of competitors
        /// </summary>
        /// <returns>return with the whole list of competitorsc</returns>
        public List<Competitor> GetCompetitors()
        {
            return this.competitors;
        }

        /// <summary>
        /// Searching for the given competitor
        /// </summary>
        /// <param name="competitor">Competitor type input</param>
        /// <returns>return true if the competitor in the list, otherwhise it return with false</returns>
        public bool ContainsCompetitor(Competitor competitor)
        {
            foreach(Competitor c in competitors)
            {
                if (c.Name.Equals(competitor.Name) &&
                    c.ClubName.Equals(competitor.ClubName))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Load the competitors from the selected file and
        /// add them to the list
        /// </summary>
        /// <returns>return true if can load and read the file, otherwise false</returns>
        public bool LoadCompetitorsFromFile()
        {
            string lineData = "";

            bool isDone = false;

            using (FileManager fileManager = new FileManager())
            {
                isDone = fileManager.Load(ref lineData);
            }

            if(!isDone)
            { // if we can't open or load the file stop here!
                return isDone;
            }

            string[] separateLineData = lineData.Split('\n');

            foreach (string line in separateLineData)
            {
                if (string.IsNullOrEmpty(line.Trim())) continue; // if we read an empty line, skip it

                string[] separateData = line.Split(CultureInfo.CurrentCulture.TextInfo.ListSeparator);

                string name;
                string clubname;

                try
                {
                    name = separateData[0].Trim();
                    clubname = separateData[1].Trim();
                }
                catch (IndexOutOfRangeException ex)
                { // if somehow we read an unexpected line, tell it to the console then skip it
                    Debug.WriteLine("Error at this line: " + line);
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                    continue;
                }

                if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(clubname))
                { // if somehow we don't get error but the name or clubname is still empty or null skip it
                    Debug.WriteLine("Error at this line: " + line);
                    continue;
                }

                //Add the competitor to the list
                AddCompetitor(name, clubname);

                //Get back the competitor as a class
                Competitor currentCompatetitor = GetCompetitor(name, clubname);

                if (currentCompatetitor == null)
                { // if the return class is null tell it to the console and skip it
                    Debug.WriteLine("Fatal error - The newly created competitor is not set!");
                    continue;
                }

                //searching for additional data in the line
                if(int.TryParse(separateData[2], out int birthyear))
                { // if it can parse the separatedata into a number it is a birth year
                    currentCompatetitor.SetBirthYear(birthyear);

                    try
                    {
                        if (!string.IsNullOrEmpty(separateData[3]))
                        { // if the separatedata[3] is not empty or null it is the startnumber
                            currentCompatetitor.SetStartNumber(separateData[3]);
                        }
                    }catch(IndexOutOfRangeException)
                    {//We dont need to handle this just catch the error and leave it
                    }
                }
                else{ // otherwise it is the name of the event
                    currentCompatetitor.GetEvent().SetEventName(separateData[2]);

                    if (int.TryParse(separateData[3], out int result))
                    { // if it can parse the separatedata into a number it is the result of the competition
                        currentCompatetitor.SetResult(result.ToString());
                    }else{// otherwise it is the event ID
                        currentCompatetitor.GetEvent().SetEventID(separateData[3]);
                    }
                }
            }

            return isDone;
        }

        /// <summary>
        /// Create a Button Template
        /// </summary>
        /// <returns></returns>
        public ButtonTemplate CreateButton()
        {
            return new ButtonTemplate() { Text = "Verseny #" + this.Id, Id = this.Id };
        }

        #endregion
    }
}
