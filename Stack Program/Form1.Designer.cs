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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            this.components        = new System.ComponentModel.Container();
            this.addProgramBtn     = new System.Windows.Forms.Button();
            this.runAppBtn         = new System.Windows.Forms.Button();
            this.deleteAppBtn      = new System.Windows.Forms.Button();
            this.deleteAllBtn      = new System.Windows.Forms.Button();
            this.runAllBtn         = new System.Windows.Forms.Button();
            this.searchAppBtn      = new System.Windows.Forms.Button();
            this.listProfiles      = new System.Windows.Forms.ListBox();
            this.addProfileBtn     = new System.Windows.Forms.Button();
            this.grp               = new System.Windows.Forms.GroupBox();
            this.exportBtn         = new System.Windows.Forms.Button();
            this.removeProfileBtn  = new System.Windows.Forms.Button();
            this.createInkBtn      = new System.Windows.Forms.Button();
            this.closeAfterCb      = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grid1             = new Stack_Program.Grid();
            this.disableAppBtn     = new System.Windows.Forms.Button();
            this.enableAppBtn      = new System.Windows.Forms.Button();
            this.groupBox1         = new System.Windows.Forms.GroupBox();
            this.groupBox2         = new System.Windows.Forms.GroupBox();
            this.grp.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.grid1 ) ).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProgramBtn
            // 
            this.addProgramBtn.Location                =  new System.Drawing.Point(14, 62);
            this.addProgramBtn.Name                    =  "addProgramBtn";
            this.addProgramBtn.Size                    =  new System.Drawing.Size(135, 33);
            this.addProgramBtn.TabIndex                =  0;
            this.addProgramBtn.Text                    =  "Aggiungi app...";
            this.addProgramBtn.UseVisualStyleBackColor =  true;
            this.addProgramBtn.Click                   += new System.EventHandler(this.addProgram_Click);
            // 
            // runAppBtn
            // 
            this.runAppBtn.Anchor =
                ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Top |
                                                          System.Windows.Forms.AnchorStyles.Right ) ) );
            this.runAppBtn.Enabled                 =  false;
            this.runAppBtn.Location                =  new System.Drawing.Point(14, 22);
            this.runAppBtn.Name                    =  "runAppBtn";
            this.runAppBtn.Size                    =  new System.Drawing.Size(267, 33);
            this.runAppBtn.TabIndex                =  2;
            this.runAppBtn.Text                    =  "Avvia singolo...";
            this.runAppBtn.UseVisualStyleBackColor =  true;
            this.runAppBtn.Click                   += new System.EventHandler(this.runApp_Click);
            // 
            // deleteAppBtn
            // 
            this.deleteAppBtn.Enabled                 =  false;
            this.deleteAppBtn.Location                =  new System.Drawing.Point(14, 106);
            this.deleteAppBtn.Name                    =  "deleteAppBtn";
            this.deleteAppBtn.Size                    =  new System.Drawing.Size(135, 33);
            this.deleteAppBtn.TabIndex                =  3;
            this.deleteAppBtn.Text                    =  "Rimuovi app";
            this.deleteAppBtn.UseVisualStyleBackColor =  true;
            this.deleteAppBtn.Click                   += new System.EventHandler(this.deleteApp_Click);
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.Enabled                 =  false;
            this.deleteAllBtn.Location                =  new System.Drawing.Point(14, 147);
            this.deleteAllBtn.Name                    =  "deleteAllBtn";
            this.deleteAllBtn.Size                    =  new System.Drawing.Size(135, 33);
            this.deleteAllBtn.TabIndex                =  4;
            this.deleteAllBtn.Text                    =  "Rimuovi tutte";
            this.deleteAllBtn.UseVisualStyleBackColor =  true;
            this.deleteAllBtn.Click                   += new System.EventHandler(this.deleteAll_Click);
            // 
            // runAllBtn
            // 
            this.runAllBtn.Anchor =
                ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Top |
                                                          System.Windows.Forms.AnchorStyles.Right ) ) );
            this.runAllBtn.Enabled                 =  false;
            this.runAllBtn.Location                =  new System.Drawing.Point(14, 62);
            this.runAllBtn.Name                    =  "runAllBtn";
            this.runAllBtn.Size                    =  new System.Drawing.Size(267, 33);
            this.runAllBtn.TabIndex                =  5;
            this.runAllBtn.Text                    =  "Avvia tutte le app";
            this.runAllBtn.UseVisualStyleBackColor =  true;
            this.runAllBtn.Click                   += new System.EventHandler(this.runAll_Click);
            // 
            // searchAppBtn
            // 
            this.searchAppBtn.Location                =  new System.Drawing.Point(14, 187);
            this.searchAppBtn.Name                    =  "searchAppBtn";
            this.searchAppBtn.Size                    =  new System.Drawing.Size(135, 33);
            this.searchAppBtn.TabIndex                =  6;
            this.searchAppBtn.Text                    =  "Sfoglia app...";
            this.searchAppBtn.UseVisualStyleBackColor =  true;
            this.searchAppBtn.Click                   += new System.EventHandler(this.searchApp_Click);
            // 
            // listProfiles
            // 
            this.listProfiles.Anchor               =  System.Windows.Forms.AnchorStyles.Bottom;
            this.listProfiles.FormattingEnabled    =  true;
            this.listProfiles.ItemHeight           =  15;
            this.listProfiles.Location             =  new System.Drawing.Point(7, 105);
            this.listProfiles.Name                 =  "listProfiles";
            this.listProfiles.RightToLeft          =  System.Windows.Forms.RightToLeft.No;
            this.listProfiles.ScrollAlwaysVisible  =  true;
            this.listProfiles.Size                 =  new System.Drawing.Size(277, 109);
            this.listProfiles.TabIndex             =  7;
            this.listProfiles.SelectedIndexChanged += new System.EventHandler(this.listProfiles_SelectedIndexChanged);
            // 
            // addProfileBtn
            // 
            this.addProfileBtn.Anchor                  =  System.Windows.Forms.AnchorStyles.Bottom;
            this.addProfileBtn.Location                =  new System.Drawing.Point(7, 24);
            this.addProfileBtn.Name                    =  "addProfileBtn";
            this.addProfileBtn.Size                    =  new System.Drawing.Size(129, 33);
            this.addProfileBtn.TabIndex                =  8;
            this.addProfileBtn.Text                    =  "Nuovo profilo";
            this.addProfileBtn.UseVisualStyleBackColor =  true;
            this.addProfileBtn.Click                   += new System.EventHandler(this.addProfile_Click);
            // 
            // grp
            // 
            this.grp.Anchor =
                ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Top |
                                                          System.Windows.Forms.AnchorStyles.Right ) ) );
            this.grp.Controls.Add(this.exportBtn);
            this.grp.Controls.Add(this.removeProfileBtn);
            this.grp.Controls.Add(this.addProfileBtn);
            this.grp.Controls.Add(this.listProfiles);
            this.grp.Location = new System.Drawing.Point(535, 435);
            this.grp.Name     = "grp";
            this.grp.Size     = new System.Drawing.Size(292, 222);
            this.grp.TabIndex = 9;
            this.grp.TabStop  = false;
            this.grp.Text     = "Profili";
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor                  =  System.Windows.Forms.AnchorStyles.Bottom;
            this.exportBtn.Location                =  new System.Drawing.Point(7, 65);
            this.exportBtn.Name                    =  "exportBtn";
            this.exportBtn.Size                    =  new System.Drawing.Size(274, 33);
            this.exportBtn.TabIndex                =  13;
            this.exportBtn.Text                    =  "Esporta profili";
            this.exportBtn.UseVisualStyleBackColor =  true;
            this.exportBtn.Click                   += new System.EventHandler(this.exportBtn_Click);
            // 
            // removeProfileBtn
            // 
            this.removeProfileBtn.Anchor                  =  System.Windows.Forms.AnchorStyles.Bottom;
            this.removeProfileBtn.Enabled                 =  false;
            this.removeProfileBtn.Location                =  new System.Drawing.Point(150, 24);
            this.removeProfileBtn.Name                    =  "removeProfileBtn";
            this.removeProfileBtn.Size                    =  new System.Drawing.Size(131, 33);
            this.removeProfileBtn.TabIndex                =  9;
            this.removeProfileBtn.Text                    =  "Rimuovi profilo";
            this.removeProfileBtn.UseVisualStyleBackColor =  true;
            this.removeProfileBtn.Click                   += new System.EventHandler(this.removeProfile_Click);
            // 
            // createInkBtn
            // 
            this.createInkBtn.Location                =  new System.Drawing.Point(14, 22);
            this.createInkBtn.Name                    =  "createInkBtn";
            this.createInkBtn.Size                    =  new System.Drawing.Size(135, 33);
            this.createInkBtn.TabIndex                =  11;
            this.createInkBtn.Text                    =  "Crea collegamento";
            this.createInkBtn.UseVisualStyleBackColor =  true;
            this.createInkBtn.Click                   += new System.EventHandler(this.createInk_Click);
            // 
            // closeAfterCb
            // 
            this.closeAfterCb.Anchor =
                ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom |
                                                          System.Windows.Forms.AnchorStyles.Right ) ) );
            this.closeAfterCb.AutoSize                =  true;
            this.closeAfterCb.Location                =  new System.Drawing.Point(139, 137);
            this.closeAfterCb.Name                    =  "closeAfterCb";
            this.closeAfterCb.Size                    =  new System.Drawing.Size(147, 19);
            this.closeAfterCb.TabIndex                =  12;
            this.closeAfterCb.Text                    =  "Chiudi dopo avvia tutti";
            this.closeAfterCb.UseVisualStyleBackColor =  true;
            this.closeAfterCb.CheckedChanged          += new System.EventHandler(this.closeAfterCb_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grid1
            // 
            this.grid1.AllowUserToResizeColumns = false;
            this.grid1.Anchor =
                ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top |
                                                              System.Windows.Forms.AnchorStyles.Bottom ) |
                                                            System.Windows.Forms.AnchorStyles.Left ) |
                                                          System.Windows.Forms.AnchorStyles.Right ) ) );
            this.grid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid1.BorderStyle     = System.Windows.Forms.BorderStyle.None;
            this.grid1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.isSettedGrid     =  false;
            this.grid1.Location         =  new System.Drawing.Point(14, 14);
            this.grid1.Name             =  "grid1";
            this.grid1.Size             =  new System.Drawing.Size(514, 643);
            this.grid1.TabIndex         =  10;
            this.grid1.SelectionChanged += new System.EventHandler(this.grid1_SelectionChanged);
            // 
            // disableAppBtn
            // 
            this.disableAppBtn.Enabled                 =  false;
            this.disableAppBtn.Location                =  new System.Drawing.Point(162, 62);
            this.disableAppBtn.Name                    =  "disableAppBtn";
            this.disableAppBtn.Size                    =  new System.Drawing.Size(119, 33);
            this.disableAppBtn.TabIndex                =  13;
            this.disableAppBtn.Text                    =  "Disabilita app";
            this.disableAppBtn.UseVisualStyleBackColor =  true;
            this.disableAppBtn.Click                   += new System.EventHandler(this.disableRowBtn_Click);
            // 
            // enableAppBtn
            // 
            this.enableAppBtn.Enabled                 =  false;
            this.enableAppBtn.Location                =  new System.Drawing.Point(162, 22);
            this.enableAppBtn.Name                    =  "enableAppBtn";
            this.enableAppBtn.Size                    =  new System.Drawing.Size(119, 33);
            this.enableAppBtn.TabIndex                =  14;
            this.enableAppBtn.Text                    =  "Abilita app";
            this.enableAppBtn.UseVisualStyleBackColor =  true;
            this.enableAppBtn.Click                   += new System.EventHandler(this.enableAppBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor =
                ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Top |
                                                          System.Windows.Forms.AnchorStyles.Right ) ) );
            this.groupBox1.Controls.Add(this.addProgramBtn);
            this.groupBox1.Controls.Add(this.enableAppBtn);
            this.groupBox1.Controls.Add(this.disableAppBtn);
            this.groupBox1.Controls.Add(this.createInkBtn);
            this.groupBox1.Controls.Add(this.deleteAppBtn);
            this.groupBox1.Controls.Add(this.searchAppBtn);
            this.groupBox1.Controls.Add(this.deleteAllBtn);
            this.groupBox1.Location = new System.Drawing.Point(535, 14);
            this.groupBox1.Name     = "groupBox1";
            this.groupBox1.Size     = new System.Drawing.Size(293, 246);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop  = false;
            this.groupBox1.Text     = "Organizza";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor =
                ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Top |
                                                          System.Windows.Forms.AnchorStyles.Right ) ) );
            this.groupBox2.Controls.Add(this.runAllBtn);
            this.groupBox2.Controls.Add(this.runAppBtn);
            this.groupBox2.Controls.Add(this.closeAfterCb);
            this.groupBox2.Location = new System.Drawing.Point(535, 267);
            this.groupBox2.Name     = "groupBox2";
            this.groupBox2.Size     = new System.Drawing.Size(293, 162);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop  = false;
            this.groupBox2.Text     = "Esegui";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(834, 670);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.grp);
            this.MinimumSize   =  new System.Drawing.Size(721, 709);
            this.Name          =  "Form1";
            this.ShowIcon      =  false;
            this.StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          =  "Stack Program";
            this.FormClosing   += new System.Windows.Forms.FormClosingEventHandler(this.saveProfiles_FormClosing);
            this.Load          += new System.EventHandler(this.Form1_Load);
            this.grp.ResumeLayout(false);
            ( (System.ComponentModel.ISupportInitialize) ( this.grid1 ) ).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button addProgramBtn;
        private System.Windows.Forms.Button runAppBtn;
        private System.Windows.Forms.Button deleteAppBtn;
        private System.Windows.Forms.Button deleteAllBtn;
        private System.Windows.Forms.Button runAllBtn;
        private System.Windows.Forms.Button searchAppBtn;
        private System.Windows.Forms.ListBox listProfiles;
        private System.Windows.Forms.Button addProfileBtn;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button removeProfileBtn;
        private System.Windows.Forms.Button createInkBtn;
        private System.Windows.Forms.CheckBox closeAfterCb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button disableAppBtn;
        private System.Windows.Forms.Button enableAppBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Stack_Program.Grid grid1;
    }
}

