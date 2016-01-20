namespace LifePerformance.Forms
{
    partial class ProjectSelect
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
            this.gbProjectSelect = new System.Windows.Forms.GroupBox();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnOpenen = new System.Windows.Forms.Button();
            this.lbProjecten = new System.Windows.Forms.ListBox();
            this.gbWaarneming = new System.Windows.Forms.GroupBox();
            this.cbVogelSoorten = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.gbProjectSelect.SuspendLayout();
            this.gbWaarneming.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProjectSelect
            // 
            this.gbProjectSelect.Controls.Add(this.lbProjecten);
            this.gbProjectSelect.Controls.Add(this.btnOpenen);
            this.gbProjectSelect.Controls.Add(this.btnNieuw);
            this.gbProjectSelect.Location = new System.Drawing.Point(12, 12);
            this.gbProjectSelect.Name = "gbProjectSelect";
            this.gbProjectSelect.Size = new System.Drawing.Size(200, 180);
            this.gbProjectSelect.TabIndex = 0;
            this.gbProjectSelect.TabStop = false;
            this.gbProjectSelect.Text = "Selecteer Project";
            // 
            // btnNieuw
            // 
            this.btnNieuw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNieuw.Location = new System.Drawing.Point(6, 151);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(75, 23);
            this.btnNieuw.TabIndex = 1;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnOpenen
            // 
            this.btnOpenen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenen.Location = new System.Drawing.Point(119, 151);
            this.btnOpenen.Name = "btnOpenen";
            this.btnOpenen.Size = new System.Drawing.Size(75, 23);
            this.btnOpenen.TabIndex = 2;
            this.btnOpenen.Text = "Openen";
            this.btnOpenen.UseVisualStyleBackColor = true;
            this.btnOpenen.Click += new System.EventHandler(this.btnOpenen_Click);
            // 
            // lbProjecten
            // 
            this.lbProjecten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProjecten.FormattingEnabled = true;
            this.lbProjecten.Location = new System.Drawing.Point(6, 19);
            this.lbProjecten.Name = "lbProjecten";
            this.lbProjecten.Size = new System.Drawing.Size(188, 121);
            this.lbProjecten.TabIndex = 3;
            // 
            // gbWaarneming
            // 
            this.gbWaarneming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbWaarneming.Controls.Add(this.cbType);
            this.gbWaarneming.Controls.Add(this.cbVogelSoorten);
            this.gbWaarneming.Location = new System.Drawing.Point(12, 198);
            this.gbWaarneming.Name = "gbWaarneming";
            this.gbWaarneming.Size = new System.Drawing.Size(200, 389);
            this.gbWaarneming.TabIndex = 1;
            this.gbWaarneming.TabStop = false;
            this.gbWaarneming.Text = "Waarneming";
            // 
            // cbVogelSoorten
            // 
            this.cbVogelSoorten.FormattingEnabled = true;
            this.cbVogelSoorten.Location = new System.Drawing.Point(7, 20);
            this.cbVogelSoorten.Name = "cbVogelSoorten";
            this.cbVogelSoorten.Size = new System.Drawing.Size(187, 21);
            this.cbVogelSoorten.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(6, 47);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(188, 21);
            this.cbType.TabIndex = 1;
            // 
            // ProjectSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 599);
            this.Controls.Add(this.gbWaarneming);
            this.Controls.Add(this.gbProjectSelect);
            this.Name = "ProjectSelect";
            this.Text = "ProjectSelect";
            this.gbProjectSelect.ResumeLayout(false);
            this.gbWaarneming.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProjectSelect;
        private System.Windows.Forms.Button btnOpenen;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.ListBox lbProjecten;
        private System.Windows.Forms.GroupBox gbWaarneming;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbVogelSoorten;
    }
}