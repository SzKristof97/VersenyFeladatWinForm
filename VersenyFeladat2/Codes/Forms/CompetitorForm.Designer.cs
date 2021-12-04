
namespace VersenyFeladat2.Codes.Forms
{
    partial class CompetitorForm
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
            this.competitorTitle = new System.Windows.Forms.Label();
            this.btnremove = new VersenyFeladat2.Codes.Templates.ButtonTemplate();
            this.btnsave = new VersenyFeladat2.Codes.Templates.ButtonTemplate();
            this.competitorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.competitorClubName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.competitorStartNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.competitorResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.eventId = new System.Windows.Forms.TextBox();
            this.btnreturn = new VersenyFeladat2.Codes.Templates.ButtonTemplate();
            this.competitorYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.competitorYear)).BeginInit();
            this.SuspendLayout();
            // 
            // competitorTitle
            // 
            this.competitorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.competitorTitle.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.competitorTitle.Location = new System.Drawing.Point(0, 0);
            this.competitorTitle.Name = "competitorTitle";
            this.competitorTitle.Size = new System.Drawing.Size(555, 35);
            this.competitorTitle.TabIndex = 0;
            this.competitorTitle.Text = "Versenyző Adatai";
            this.competitorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnremove.Size = new System.Drawing.Size(149, 30);
            this.btnremove.TabIndex = 1;
            this.btnremove.Text = "Versenyző törlése";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Id = 0;
            this.btnsave.Location = new System.Drawing.Point(394, 422);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(149, 30);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Mentés";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // competitorName
            // 
            this.competitorName.Location = new System.Drawing.Point(12, 102);
            this.competitorName.Name = "competitorName";
            this.competitorName.Size = new System.Drawing.Size(149, 26);
            this.competitorName.TabIndex = 3;
            this.competitorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.competitorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterKeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Név:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Klub Név:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // competitorClubName
            // 
            this.competitorClubName.Location = new System.Drawing.Point(12, 216);
            this.competitorClubName.Name = "competitorClubName";
            this.competitorClubName.Size = new System.Drawing.Size(149, 26);
            this.competitorClubName.TabIndex = 5;
            this.competitorClubName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.competitorClubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterKeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Születési Év:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rajtszám:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // competitorStartNumber
            // 
            this.competitorStartNumber.Location = new System.Drawing.Point(12, 273);
            this.competitorStartNumber.Name = "competitorStartNumber";
            this.competitorStartNumber.Size = new System.Drawing.Size(149, 26);
            this.competitorStartNumber.TabIndex = 6;
            this.competitorStartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(394, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Verseny Neve:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(394, 102);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(149, 26);
            this.eventName.TabIndex = 8;
            this.eventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(203, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Eredmény:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // competitorResult
            // 
            this.competitorResult.Location = new System.Drawing.Point(203, 102);
            this.competitorResult.Name = "competitorResult";
            this.competitorResult.Size = new System.Drawing.Size(149, 26);
            this.competitorResult.TabIndex = 7;
            this.competitorResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(394, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Verseny Azonosítója:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventId
            // 
            this.eventId.Location = new System.Drawing.Point(394, 159);
            this.eventId.Name = "eventId";
            this.eventId.Size = new System.Drawing.Size(149, 26);
            this.eventId.TabIndex = 15;
            this.eventId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnreturn.FlatAppearance.BorderSize = 0;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnreturn.ForeColor = System.Drawing.Color.White;
            this.btnreturn.Id = 0;
            this.btnreturn.Location = new System.Drawing.Point(182, 422);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(195, 30);
            this.btnreturn.TabIndex = 17;
            this.btnreturn.Text = "Visszalépés";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // competitorYear
            // 
            this.competitorYear.Location = new System.Drawing.Point(13, 159);
            this.competitorYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.competitorYear.Name = "competitorYear";
            this.competitorYear.Size = new System.Drawing.Size(149, 26);
            this.competitorYear.TabIndex = 4;
            this.competitorYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompetitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 464);
            this.Controls.Add(this.competitorYear);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eventId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.competitorResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.competitorStartNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.competitorClubName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.competitorName);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.competitorTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompetitorForm";
            this.Text = "CompetitorForm";
            this.Shown += new System.EventHandler(this.CompetitorForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.competitorYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label competitorTitle;
        private Templates.ButtonTemplate btnremove;
        private Templates.ButtonTemplate btnsave;
        private System.Windows.Forms.TextBox competitorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox competitorClubName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox competitorStartNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox competitorResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eventId;
        private Templates.ButtonTemplate btnreturn;
        private System.Windows.Forms.NumericUpDown competitorYear;
    }
}