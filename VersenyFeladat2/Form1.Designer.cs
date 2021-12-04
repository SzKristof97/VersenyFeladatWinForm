
namespace VersenyFeladat2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.panelside = new System.Windows.Forms.FlowLayoutPanel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelheader.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelheader.Controls.Add(this.btnexit);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(725, 30);
            this.panelheader.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(686, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(39, 30);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelside.Location = new System.Drawing.Point(0, 30);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(170, 464);
            this.panelside.TabIndex = 2;
            this.panelside.WrapContents = false;
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(170, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(555, 464);
            this.mainpanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 452);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hozzon Létre\r\negy új versenyt\r\naz \"+ Új Verseny\" gombbal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 494);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelheader.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.FlowLayoutPanel panelside;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label1;
    }
}

