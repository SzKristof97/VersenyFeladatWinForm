using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersenyFeladat2.Codes;
using VersenyFeladat2.Codes.Forms;
using VersenyFeladat2.Codes.Templates;

namespace VersenyFeladat2
{
    public partial class MainForm : Form
    {
        #region Variables
        public Dictionary<int, Competition> Competitions { get; private set; }
        #endregion

        #region Entry point

        public MainForm()
        {
            BeforeInit();
            InitializeComponent();
            AfterInit();
        }

        #endregion

        #region Before and After init

        /// <summary>
        /// Things that need to be perform before initializing components
        /// </summary>
        private void BeforeInit()
        {
            Competitions = new Dictionary<int, Competition>();
        }

        /// <summary>
        /// Things that need to be perform after initializing components
        /// </summary>
        private void AfterInit()
        {
            RefreshButtons();
        }

        #endregion

        private void RefreshButtons()
        {
            //Clear all button
            panelside.Controls.Clear();

            //Place competition buttons to the flow panel
            foreach (KeyValuePair<int, Competition> kvp in Competitions)
            {
                ButtonTemplate button = kvp.Value.CreateButton();
                button.Click += CompetitionButton_Click;

                panelside.Controls.Add(button);
            }

            //Place the create competition button to the flow panel
            ButtonTemplate newCompetitionBtn = new ButtonTemplate() 
            { 
                Text = "+ Új Verseny"
            };
            newCompetitionBtn.Click += NewCompetitionButton_Click;

            panelside.Controls.Add(newCompetitionBtn);
        }

        private void NewCompetitionButton_Click(object sender, System.EventArgs e)
        {
            //Calculate a new unique id
            int newId = Competitions.Count == 0 ? 0 : Competitions.Last().Key + 1;

            //Create the new competition
            Competition competition = new Competition(newId);

            //Add the button to the list and order the dictionary
            Competitions.Add(newId, competition);
            Competitions = Competitions.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            //Refresh the buttons
            RefreshButtons();
        }

        private void CompetitionButton_Click(object sender, System.EventArgs e)
        {
            //Get the caller button
            ButtonTemplate caller = ((ButtonTemplate)sender);

            Debug.WriteLine(caller.Text + " click performed!");

            //Create a new competition form with the id
            CompetitionForm competitionForm = new CompetitionForm(caller.Id, this);
            competitionForm.TopLevel = false;
            competitionForm.Dock = DockStyle.Fill;

            //Set the new competitionForm in the mainpanel
            if(mainpanel.Controls.Count > 0)
            {
                mainpanel.Controls[0].Dispose();
            }
            
            mainpanel.Controls.Add(competitionForm);
            mainpanel.Tag = competitionForm;

            //Show it on the screen
            competitionForm.Show();
            competitionForm.BringToFront();
        }

        public void RemoveCompetition(int id)
        {
            Competitions.Remove(id);

            mainpanel.Controls.Clear();
            mainpanel.Tag = this;

            RefreshButtons();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
