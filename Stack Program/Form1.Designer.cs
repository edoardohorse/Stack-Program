namespace Stack_Program
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.addProgram = new System.Windows.Forms.Button();
            this.runApp = new System.Windows.Forms.Button();
            this.deleteApp = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.runAll = new System.Windows.Forms.Button();
            this.searchApp = new System.Windows.Forms.Button();
            this.listProfiles = new System.Windows.Forms.ListBox();
            this.addProfile = new System.Windows.Forms.Button();
            this.grp = new System.Windows.Forms.GroupBox();
            this.removeProfile = new System.Windows.Forms.Button();
            this.grid1 = new Stack_Program.Grid();
            this.createInk = new System.Windows.Forms.Button();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // addProgram
            // 
            this.addProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProgram.Location = new System.Drawing.Point(442, 12);
            this.addProgram.Name = "addProgram";
            this.addProgram.Size = new System.Drawing.Size(141, 29);
            this.addProgram.TabIndex = 0;
            this.addProgram.Text = "Aggiungi programma...";
            this.addProgram.UseVisualStyleBackColor = true;
            this.addProgram.Click += new System.EventHandler(this.addProgram_Click);
            // 
            // runApp
            // 
            this.runApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runApp.Enabled = false;
            this.runApp.Location = new System.Drawing.Point(442, 80);
            this.runApp.Name = "runApp";
            this.runApp.Size = new System.Drawing.Size(141, 29);
            this.runApp.TabIndex = 2;
            this.runApp.Text = "Avvia singolo...";
            this.runApp.UseVisualStyleBackColor = true;
            this.runApp.Click += new System.EventHandler(this.runApp_Click);
            // 
            // deleteApp
            // 
            this.deleteApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteApp.Enabled = false;
            this.deleteApp.Location = new System.Drawing.Point(442, 148);
            this.deleteApp.Name = "deleteApp";
            this.deleteApp.Size = new System.Drawing.Size(141, 29);
            this.deleteApp.TabIndex = 3;
            this.deleteApp.Text = "Cancella singolo...";
            this.deleteApp.UseVisualStyleBackColor = true;
            this.deleteApp.Click += new System.EventHandler(this.deleteApp_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAll.Enabled = false;
            this.deleteAll.Location = new System.Drawing.Point(442, 182);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(141, 29);
            this.deleteAll.TabIndex = 4;
            this.deleteAll.Text = "Cancella tutti";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // runAll
            // 
            this.runAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runAll.Enabled = false;
            this.runAll.Location = new System.Drawing.Point(442, 114);
            this.runAll.Name = "runAll";
            this.runAll.Size = new System.Drawing.Size(141, 29);
            this.runAll.TabIndex = 5;
            this.runAll.Text = "Avvia tutti";
            this.runAll.UseVisualStyleBackColor = true;
            this.runAll.Click += new System.EventHandler(this.runAll_Click);
            // 
            // searchApp
            // 
            this.searchApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchApp.Location = new System.Drawing.Point(442, 216);
            this.searchApp.Name = "searchApp";
            this.searchApp.Size = new System.Drawing.Size(141, 29);
            this.searchApp.TabIndex = 6;
            this.searchApp.Text = "Sfoglia programmi...";
            this.searchApp.UseVisualStyleBackColor = true;
            this.searchApp.Click += new System.EventHandler(this.searchApp_Click);
            // 
            // listProfiles
            // 
            this.listProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProfiles.FormattingEnabled = true;
            this.listProfiles.Location = new System.Drawing.Point(6, 89);
            this.listProfiles.Name = "listProfiles";
            this.listProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listProfiles.ScrollAlwaysVisible = true;
            this.listProfiles.Size = new System.Drawing.Size(144, 147);
            this.listProfiles.TabIndex = 7;
            this.listProfiles.SelectedIndexChanged += new System.EventHandler(this.listProfiles_SelectedIndexChanged);
            // 
            // addProfile
            // 
            this.addProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProfile.Location = new System.Drawing.Point(17, 19);
            this.addProfile.Name = "addProfile";
            this.addProfile.Size = new System.Drawing.Size(120, 29);
            this.addProfile.TabIndex = 8;
            this.addProfile.Text = "Nuovo profilo";
            this.addProfile.UseVisualStyleBackColor = true;
            this.addProfile.Click += new System.EventHandler(this.addProfile_Click);
            // 
            // grp
            // 
            this.grp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grp.Controls.Add(this.removeProfile);
            this.grp.Controls.Add(this.addProfile);
            this.grp.Controls.Add(this.listProfiles);
            this.grp.Location = new System.Drawing.Point(436, 263);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(156, 251);
            this.grp.TabIndex = 9;
            this.grp.TabStop = false;
            this.grp.Text = "Profili";
            // 
            // removeProfile
            // 
            this.removeProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeProfile.Enabled = false;
            this.removeProfile.Location = new System.Drawing.Point(17, 54);
            this.removeProfile.Name = "removeProfile";
            this.removeProfile.Size = new System.Drawing.Size(120, 29);
            this.removeProfile.TabIndex = 9;
            this.removeProfile.Text = "Rimuovi profilo";
            this.removeProfile.UseVisualStyleBackColor = true;
            this.removeProfile.Click += new System.EventHandler(this.removeProfile_Click);
            // 
            // grid1
            // 
            this.grid1.AllowUserToResizeColumns = false;
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.isSettedGrid = false;
            this.grid1.Location = new System.Drawing.Point(12, 12);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(418, 557);
            this.grid1.TabIndex = 10;
            // 
            // createInk
            // 
            this.createInk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createInk.Location = new System.Drawing.Point(442, 45);
            this.createInk.Name = "createInk";
            this.createInk.Size = new System.Drawing.Size(141, 29);
            this.createInk.TabIndex = 11;
            this.createInk.Text = "Crea collegamento";
            this.createInk.UseVisualStyleBackColor = true;
            this.createInk.Click += new System.EventHandler(this.createInk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 581);
            this.Controls.Add(this.createInk);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.searchApp);
            this.Controls.Add(this.runAll);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.deleteApp);
            this.Controls.Add(this.runApp);
            this.Controls.Add(this.addProgram);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveProfiles);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProgram;
        private System.Windows.Forms.Button runApp;
        private System.Windows.Forms.Button deleteApp;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button runAll;
        private System.Windows.Forms.Button searchApp;
        private System.Windows.Forms.ListBox listProfiles;
        private System.Windows.Forms.Button addProfile;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button removeProfile;
        private Grid grid1;
        private System.Windows.Forms.Button createInk;
    }
}

