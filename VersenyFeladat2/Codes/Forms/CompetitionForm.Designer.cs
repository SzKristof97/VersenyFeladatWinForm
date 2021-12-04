
namespace VersenyFeladat2.Codes.Forms
{
    partial class CompetitionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.competitionTitle = new System.Windows.Forms.Label();
            this.btnremove = new VersenyFeladat2.Codes.Templates.ButtonTemplate();
            this.buttonTemplate1 = new VersenyFeladat2.Codes.Templates.ButtonTemplate();
            this.competitorspanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // competitionTitle
            // 
            this.competitionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.competitionTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.competitionTitle.Location = new System.Drawing.Point(0, 0);
            this.competitionTitle.Name = "competitionTitle";
            this.competitionTitle.Size = new System.Drawing.Size(555, 56);
            this.competitionTitle.TabIndex = 0;
            this.competitionTitle.Text = "Verseny";
            this.competitionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.IndianRed;
            this.btnremove.FlatAppearance.BorderSize = 0;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Id = 0;
            this.btnremove.Location = new System.Drawing.Point(12, 422);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(127, 30);
            this.btnremove.TabIndex = 2;
            this.btnremove.Text = "Verseny Törlése";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // buttonTemplate1
            // 
            this.buttonTemplate1.BackColor = System.Drawing.Color.Green;
            this.buttonTemplate1.FlatAppearance.BorderSize = 0;
            this.buttonTemplate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemplate1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonTemplate1.ForeColor = System.Drawing.Color.White;
            this.buttonTemplate1.Id = 0;
            this.buttonTemplate1.Location = new System.Drawing.Point(408, 422);
            this.buttonTemplate1.Name = "buttonTemplate1";
            this.buttonTemplate1.Size = new System.Drawing.Size(135, 30);
            this.buttonTemplate1.TabIndex = 3;
            this.buttonTemplate1.Text = "Adatok betöltése";
            this.buttonTemplate1.UseVisualStyleBackColor = false;
            this.buttonTemplate1.Click += new System.EventHandler(this.buttonTemplate1_Click);
            // 
            // competitorspanel
            // 
            this.competitorspanel.AutoScroll = true;
            this.competitorspanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.competitorspanel.Location = new System.Drawing.Point(12, 59);
            this.competitorspanel.Name = "competitorspanel";
            this.competitorspanel.Size = new System.Drawing.Size(531, 357);
            this.competitorspanel.TabIndex = 4;
            this.competitorspanel.WrapContents = false;
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 464);
            this.Controls.Add(this.competitorspanel);
            this.Controls.Add(this.buttonTemplate1);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.competitionTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompetitionForm";
            this.Text = "CompetitionForm";
            this.Shown += new System.EventHandler(this.CompetitionForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label competitionTitle;
        private Templates.ButtonTemplate btnremove;
        private Templates.ButtonTemplate buttonTemplate1;
        private System.Windows.Forms.FlowLayoutPanel competitorspanel;
    }
}