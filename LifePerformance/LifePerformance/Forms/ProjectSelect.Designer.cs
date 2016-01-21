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
            this.cbKaarten = new System.Windows.Forms.ComboBox();
            this.tbGebiedNaam = new System.Windows.Forms.TextBox();
            this.lbProjecten = new System.Windows.Forms.ListBox();
            this.btnOpenen = new System.Windows.Forms.Button();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.gbWaarneming = new System.Windows.Forms.GroupBox();
            this.btnWaarnemingToevoegen = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbVogelSoorten = new System.Windows.Forms.ComboBox();
            this.gbKaart = new System.Windows.Forms.GroupBox();
            this.pbKaart = new System.Windows.Forms.PictureBox();
            this.gbBezoek = new System.Windows.Forms.GroupBox();
            this.btnEindBezoek = new System.Windows.Forms.Button();
            this.btnNieuwBezoek = new System.Windows.Forms.Button();
            this.lbBezoeken = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbProjectSelect.SuspendLayout();
            this.gbWaarneming.SuspendLayout();
            this.gbKaart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaart)).BeginInit();
            this.gbBezoek.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProjectSelect
            // 
            this.gbProjectSelect.Controls.Add(this.cbKaarten);
            this.gbProjectSelect.Controls.Add(this.tbGebiedNaam);
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
            // cbKaarten
            // 
            this.cbKaarten.FormattingEnabled = true;
            this.cbKaarten.Location = new System.Drawing.Point(7, 98);
            this.cbKaarten.Name = "cbKaarten";
            this.cbKaarten.Size = new System.Drawing.Size(187, 21);
            this.cbKaarten.TabIndex = 5;
            // 
            // tbGebiedNaam
            // 
            this.tbGebiedNaam.Location = new System.Drawing.Point(7, 125);
            this.tbGebiedNaam.Name = "tbGebiedNaam";
            this.tbGebiedNaam.Size = new System.Drawing.Size(187, 20);
            this.tbGebiedNaam.TabIndex = 4;
            // 
            // lbProjecten
            // 
            this.lbProjecten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProjecten.FormattingEnabled = true;
            this.lbProjecten.Location = new System.Drawing.Point(6, 19);
            this.lbProjecten.Name = "lbProjecten";
            this.lbProjecten.Size = new System.Drawing.Size(188, 69);
            this.lbProjecten.TabIndex = 3;
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
            // gbWaarneming
            // 
            this.gbWaarneming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbWaarneming.Controls.Add(this.btnWaarnemingToevoegen);
            this.gbWaarneming.Controls.Add(this.cbType);
            this.gbWaarneming.Controls.Add(this.cbVogelSoorten);
            this.gbWaarneming.Location = new System.Drawing.Point(12, 374);
            this.gbWaarneming.Name = "gbWaarneming";
            this.gbWaarneming.Size = new System.Drawing.Size(200, 143);
            this.gbWaarneming.TabIndex = 1;
            this.gbWaarneming.TabStop = false;
            this.gbWaarneming.Text = "Waarneming";
            // 
            // btnWaarnemingToevoegen
            // 
            this.btnWaarnemingToevoegen.Location = new System.Drawing.Point(6, 74);
            this.btnWaarnemingToevoegen.Name = "btnWaarnemingToevoegen";
            this.btnWaarnemingToevoegen.Size = new System.Drawing.Size(188, 23);
            this.btnWaarnemingToevoegen.TabIndex = 2;
            this.btnWaarnemingToevoegen.Text = "Toevoegen";
            this.btnWaarnemingToevoegen.UseVisualStyleBackColor = true;
            this.btnWaarnemingToevoegen.Click += new System.EventHandler(this.btnWaarnemingToevoegen_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(6, 47);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(188, 21);
            this.cbType.TabIndex = 1;
            // 
            // cbVogelSoorten
            // 
            this.cbVogelSoorten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVogelSoorten.FormattingEnabled = true;
            this.cbVogelSoorten.Location = new System.Drawing.Point(7, 20);
            this.cbVogelSoorten.Name = "cbVogelSoorten";
            this.cbVogelSoorten.Size = new System.Drawing.Size(187, 21);
            this.cbVogelSoorten.TabIndex = 0;
            // 
            // gbKaart
            // 
            this.gbKaart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbKaart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbKaart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbKaart.Controls.Add(this.pbKaart);
            this.gbKaart.Location = new System.Drawing.Point(218, 12);
            this.gbKaart.Name = "gbKaart";
            this.gbKaart.Size = new System.Drawing.Size(920, 684);
            this.gbKaart.TabIndex = 2;
            this.gbKaart.TabStop = false;
            this.gbKaart.Text = "Project - Kaart";
            // 
            // pbKaart
            // 
            this.pbKaart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKaart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbKaart.Location = new System.Drawing.Point(3, 16);
            this.pbKaart.Name = "pbKaart";
            this.pbKaart.Size = new System.Drawing.Size(914, 665);
            this.pbKaart.TabIndex = 0;
            this.pbKaart.TabStop = false;
            this.pbKaart.Click += new System.EventHandler(this.pbKaart_Click);
            // 
            // gbBezoek
            // 
            this.gbBezoek.Controls.Add(this.btnUpdate);
            this.gbBezoek.Controls.Add(this.btnEindBezoek);
            this.gbBezoek.Controls.Add(this.btnNieuwBezoek);
            this.gbBezoek.Controls.Add(this.lbBezoeken);
            this.gbBezoek.Location = new System.Drawing.Point(13, 199);
            this.gbBezoek.Name = "gbBezoek";
            this.gbBezoek.Size = new System.Drawing.Size(199, 169);
            this.gbBezoek.TabIndex = 3;
            this.gbBezoek.TabStop = false;
            this.gbBezoek.Text = "Bezoeken";
            // 
            // btnEindBezoek
            // 
            this.btnEindBezoek.Location = new System.Drawing.Point(108, 111);
            this.btnEindBezoek.Name = "btnEindBezoek";
            this.btnEindBezoek.Size = new System.Drawing.Size(85, 23);
            this.btnEindBezoek.TabIndex = 2;
            this.btnEindBezoek.Text = "Eind Bezoek";
            this.btnEindBezoek.UseVisualStyleBackColor = true;
            this.btnEindBezoek.Click += new System.EventHandler(this.btnEindBezoek_Click);
            // 
            // btnNieuwBezoek
            // 
            this.btnNieuwBezoek.Location = new System.Drawing.Point(6, 111);
            this.btnNieuwBezoek.Name = "btnNieuwBezoek";
            this.btnNieuwBezoek.Size = new System.Drawing.Size(85, 23);
            this.btnNieuwBezoek.TabIndex = 1;
            this.btnNieuwBezoek.Text = "Nieuw Bezoek";
            this.btnNieuwBezoek.UseVisualStyleBackColor = true;
            this.btnNieuwBezoek.Click += new System.EventHandler(this.btnNieuwBezoek_Click);
            // 
            // lbBezoeken
            // 
            this.lbBezoeken.FormattingEnabled = true;
            this.lbBezoeken.Location = new System.Drawing.Point(6, 19);
            this.lbBezoeken.Name = "lbBezoeken";
            this.lbBezoeken.Size = new System.Drawing.Size(187, 82);
            this.lbBezoeken.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(5, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Ververs";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ProjectSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1148, 699);
            this.Controls.Add(this.gbBezoek);
            this.Controls.Add(this.gbKaart);
            this.Controls.Add(this.gbWaarneming);
            this.Controls.Add(this.gbProjectSelect);
            this.MaximumSize = new System.Drawing.Size(1164, 738);
            this.MinimumSize = new System.Drawing.Size(1164, 738);
            this.Name = "ProjectSelect";
            this.Text = "ProjectSelect";
            this.gbProjectSelect.ResumeLayout(false);
            this.gbProjectSelect.PerformLayout();
            this.gbWaarneming.ResumeLayout(false);
            this.gbKaart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKaart)).EndInit();
            this.gbBezoek.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbKaart;
        private System.Windows.Forms.GroupBox gbBezoek;
        private System.Windows.Forms.ListBox lbBezoeken;
        private System.Windows.Forms.TextBox tbGebiedNaam;
        private System.Windows.Forms.PictureBox pbKaart;
        private System.Windows.Forms.ComboBox cbKaarten;
        private System.Windows.Forms.Button btnEindBezoek;
        private System.Windows.Forms.Button btnNieuwBezoek;
        private System.Windows.Forms.Button btnWaarnemingToevoegen;
        private System.Windows.Forms.Button btnUpdate;
    }
}