
namespace VersenyFeladat2.Codes.Forms
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new VersenyFeladat2.Codes.Templates.ButtonTemplate();
            this.btnSave = new VersenyFeladat2.Codes.Templates.ButtonTemplate();
            this.cbSaveOptions = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eredmény lista mentése";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Id = 0;
            this.btnCancel.Location = new System.Drawing.Point(12, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Id = 0;
            this.btnSave.Location = new System.Drawing.Point(408, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSaveOptions
            // 
            this.cbSaveOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbSaveOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSaveOptions.FormattingEnabled = true;
            this.cbSaveOptions.Items.AddRange(new object[] {
            "Eredmény lista",
            "Nevezett, de nem indultak listája",
            "Nem nevezett indulók listája"});
            this.cbSaveOptions.Location = new System.Drawing.Point(154, 175);
            this.cbSaveOptions.Name = "cbSaveOptions";
            this.cbSaveOptions.Size = new System.Drawing.Size(229, 63);
            this.cbSaveOptions.TabIndex = 5;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 464);
            this.Controls.Add(this.cbSaveOptions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Templates.ButtonTemplate btnCancel;
        private Templates.ButtonTemplate btnSave;
        private System.Windows.Forms.CheckedListBox cbSaveOptions;
    }
}