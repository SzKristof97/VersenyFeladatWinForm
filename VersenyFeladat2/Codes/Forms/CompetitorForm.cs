using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VersenyFeladat2.Codes.Exceptions;

namespace VersenyFeladat2.Codes.Forms
{
    public partial class CompetitorForm : Form
    {
        public int Id { get; private set; }
        public Competitor competitor { get; private set; }

        private MainForm Core { get; set; }

        public CompetitorForm(int id, Competitor comp, MainForm mainForm)
        {
            Id = id;
            competitor = comp;
            Core = mainForm;

            InitializeComponent();
        }

        private void CompetitorForm_Shown(object sender, EventArgs e)
        {
            if (competitor == null) return;

            competitorYear.Maximum = DateTime.Now.Year + 4;

            competitorName.Text = competitor.Name;
            competitorClubName.Text = competitor.ClubName;
            competitorStartNumber.Text = competitor.StartNumber;
            competitorYear.Value = competitor.BirthYear;
            competitorResult.Text = competitor.Result;

            eventName.Text = competitor.GetEvent().EventName;
            eventId.Text = competitor.GetEvent().EventID;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            Core.Competitions[Id].RemoveCompetitor(competitor);

            BackToCompetition();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            BackToCompetition();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            competitor.SetName(competitorName.Text);
            competitor.SetClubName(competitorClubName.Text);
            competitor.SetStartNumber(competitorStartNumber.Text);
            competitor.SetBirthYear((int)competitorYear.Value);
            competitor.SetResult(competitorResult.Text);

            try
            {
                competitor.GetEvent().SetEventName(eventName.Text);
                competitor.GetEvent().SetEventID(eventId.Text);
            }
            catch (InvalidEventNameException ex )
            {
                MessageBox.Show(ex.Message,"Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEventIDException ex)
            {
                MessageBox.Show(ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackToCompetition()
        {
            CompetitionForm competitionForm = new CompetitionForm(Id, Core);
            competitionForm.TopLevel = false;
            competitionForm.Dock = DockStyle.Fill;

            Panel parentPanel = ((Panel)this.Parent);
            parentPanel.Controls.Add(competitionForm);
            parentPanel.Tag = competitionForm;

            competitionForm.Show();
            parentPanel.Controls[0].Dispose();
        }

        private void FilterKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar.Equals('-');
        }
    }
}
