using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VersenyFeladat2.Codes;
using VersenyFeladat2.Codes.Templates;

namespace VersenyFeladat2.Codes.Forms
{
    public partial class CompetitionForm : Form
    {

        #region Variables
        private MainForm Core { get; set; }
        
        public int Id { get; private set; }
        #endregion

        #region Constructor
        public CompetitionForm(int id, MainForm mainForm)
        {
            //Set the ID
            Id = id;
            Core = mainForm;

            //
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void CompetitionForm_Shown(object sender, EventArgs e)
        {
            competitionTitle.Text = "Verseny #" + Id;
            DrawCompetitors();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            Core.RemoveCompetition(Id);
        }

        private void buttonTemplate1_Click(object sender, EventArgs e)
        {
            Core.Competitions[Id]?.LoadCompetitorsFromFile();
            DrawCompetitors();
        }

        private void DrawCompetitors()
        {
            competitorspanel.Controls.Clear();

            foreach (Competitor competitor in Core.Competitions[Id]?.GetCompetitors())
            {
                CardTemplate card = new CardTemplate()
                {
                    Text = competitor.Name + " - " + competitor.ClubName
                };
                card.Click += Competitor_Click;
                competitorspanel.Controls.Add(card);
            }

            if (Core.Competitions[Id]?.GetCompetitors().Count == 0)
            {
                btnSaveResults.Enabled = false;
            }
            else
            {
                btnSaveResults.Enabled = true;
            }
        }

        private void Competitor_Click(object sender, System.EventArgs e)
        {
            string[] splitText = ((CardTemplate)sender).Text.Split('-');

            string name = splitText[0].Trim();
            string clubname = splitText[1].Trim();

            Competitor competitor = Core.Competitions[Id]?.GetCompetitor(name, clubname);

            if (competitor == null) return;

            CompetitorForm competitorForm = new CompetitorForm(Id, competitor, Core);
            competitorForm.TopLevel = false;
            competitorForm.Dock = DockStyle.Fill;

            Panel parentPanel = ((Panel)this.Parent);
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(competitorForm);
            parentPanel.Tag = competitorForm;

            competitorForm.Show();
            this.Dispose();
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            ResultForm rf = new ResultForm(Id, Core);
            rf.TopLevel = false;
            rf.Dock = DockStyle.Fill;

            Panel parentPanel = ((Panel)this.Parent);
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rf);
            parentPanel.Tag = rf;

            rf.Show();
            this.Dispose();
        }

        #endregion

    }
}
