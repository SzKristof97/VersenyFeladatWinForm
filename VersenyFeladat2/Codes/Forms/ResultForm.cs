using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VersenyFeladat2.Codes.Forms
{
    public partial class ResultForm : Form
    {
        #region Variables
        private MainForm Core { get; set; }

        public int Id { get; private set; }
        #endregion

        public ResultForm(int id, MainForm mainForm)
        {
            Id = id;
            Core = mainForm;

            InitializeComponent();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BackToCompetition();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV|*.csv";
                sfd.SupportMultiDottedExtensions = false;
                sfd.Title = "Eredmények mentése";
                sfd.ShowDialog();

                if (!string.IsNullOrEmpty(sfd.FileName))
                {
                    StreamWriter sw = new StreamWriter(sfd.OpenFile(), Encoding.UTF8);

                    for (int i = 0; i < cbSaveOptions.Items.Count; i++)
                    {
                        if (cbSaveOptions.GetItemChecked(i))
                        {
                            string separator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;
                            switch (i)
                            {
                                case 0:
                                    {//Eredménylista
                                        sw.WriteLine("#Eredménylista");
                                        sw.WriteLine("#Név, Klub név, rajtszám, versenyszám azonosítója, eredmény");
                                        List<Competitor> competitorList = Core.Competitions[Id]?.GetResultList();

                                        if (competitorList == null) break;
                                        foreach (Competitor competitor in competitorList)
                                        {
                                            StringBuilder sb = new StringBuilder();
                                            sb.Append(competitor.Name + separator);
                                            sb.Append(competitor.ClubName + separator);
                                            sb.Append(competitor.StartNumber + separator);
                                            sb.Append(competitor.GetEvent().EventID + separator);
                                            sb.Append(competitor.Result);

                                            sw.WriteLine(sb.ToString());
                                        }
                                        break;
                                    }
                                case 1:
                                    {//Nevezett, de nem indultak
                                        sw.WriteLine("#Nevezett de nem indultak listája");
                                        sw.WriteLine("#Név, Klub név, rajtszám, versenyszám azonosítója");
                                        List<Competitor> competitorList = Core.Competitions[Id]?.GetEnteredButNotStarted();

                                        if (competitorList == null) break;
                                        foreach (Competitor competitor in competitorList)
                                        {
                                            StringBuilder sb = new StringBuilder();
                                            sb.Append(competitor.Name + separator);
                                            sb.Append(competitor.ClubName + separator);
                                            sb.Append(competitor.StartNumber + separator);
                                            sb.Append(competitor.GetEvent().EventID + separator);

                                            sw.WriteLine(sb.ToString());
                                        }
                                        break;
                                    }
                                case 2:
                                    {//Nem nevezett, de indultak
                                        sw.WriteLine("#Nem nevezett de indultak listája");
                                        sw.WriteLine("#Név, Klub név, versenyszám azonosítója, eredmény");
                                        List<Competitor> competitorList = Core.Competitions[Id]?.GetNotEnteredButStarted();

                                        if (competitorList == null) break;
                                        foreach (Competitor competitor in competitorList)
                                        {
                                            StringBuilder sb = new StringBuilder();
                                            sb.Append(competitor.Name + separator);
                                            sb.Append(competitor.ClubName + separator);
                                            sb.Append(competitor.GetEvent().EventID + separator);
                                            sb.Append(competitor.Result);

                                            sw.WriteLine(sb.ToString());
                                        }
                                        break;
                                    }
                                default: { break; }
                            }
                        }
                    }

                    sw.Close();
                }
            }

            //Then back to competition
            BackToCompetition();
        }

        private void cbSaveOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked) { btnSave.Enabled = true; }
            if(e.NewValue == CheckState.Unchecked)
            {
                if (cbSaveOptions.CheckedItems.Count - 1 <= 0) { btnSave.Enabled = false; }
            }
        }
    }
}
