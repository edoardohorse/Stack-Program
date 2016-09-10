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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.runApp = new System.Windows.Forms.Button();
            this.deleteApp = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.runAll = new System.Windows.Forms.Button();
            this.searchApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProgram
            // 
            this.addProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProgram.Location = new System.Drawing.Point(426, 12);
            this.addProgram.Name = "addProgram";
            this.addProgram.Size = new System.Drawing.Size(120, 29);
            this.addProgram.TabIndex = 0;
            this.addProgram.Text = "Aggiungi programma...";
            this.addProgram.UseVisualStyleBackColor = true;
            this.addProgram.Click += new System.EventHandler(this.addProgram_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(408, 557);
            this.dataGridView.TabIndex = 1;
            // 
            // runApp
            // 
            this.runApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runApp.Enabled = false;
            this.runApp.Location = new System.Drawing.Point(426, 45);
            this.runApp.Name = "runApp";
            this.runApp.Size = new System.Drawing.Size(120, 29);
            this.runApp.TabIndex = 2;
            this.runApp.Text = "Avvia singolo...";
            this.runApp.UseVisualStyleBackColor = true;
            this.runApp.Click += new System.EventHandler(this.runApp_Click);
            // 
            // deleteApp
            // 
            this.deleteApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteApp.Enabled = false;
            this.deleteApp.Location = new System.Drawing.Point(426, 111);
            this.deleteApp.Name = "deleteApp";
            this.deleteApp.Size = new System.Drawing.Size(120, 29);
            this.deleteApp.TabIndex = 3;
            this.deleteApp.Text = "Cancella singolo...";
            this.deleteApp.UseVisualStyleBackColor = true;
            this.deleteApp.Click += new System.EventHandler(this.deleteApp_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAll.Enabled = false;
            this.deleteAll.Location = new System.Drawing.Point(426, 144);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(120, 29);
            this.deleteAll.TabIndex = 4;
            this.deleteAll.Text = "Cancella tutti";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // runAll
            // 
            this.runAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runAll.Enabled = false;
            this.runAll.Location = new System.Drawing.Point(426, 78);
            this.runAll.Name = "runAll";
            this.runAll.Size = new System.Drawing.Size(120, 29);
            this.runAll.TabIndex = 5;
            this.runAll.Text = "Avvia tutti";
            this.runAll.UseVisualStyleBackColor = true;
            this.runAll.Click += new System.EventHandler(this.runAll_Click);
            // 
            // searchApp
            // 
            this.searchApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchApp.Location = new System.Drawing.Point(426, 179);
            this.searchApp.Name = "searchApp";
            this.searchApp.Size = new System.Drawing.Size(120, 29);
            this.searchApp.TabIndex = 6;
            this.searchApp.Text = "Sfoglia programmi...";
            this.searchApp.UseVisualStyleBackColor = true;
            this.searchApp.Click += new System.EventHandler(this.searchApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 581);
            this.Controls.Add(this.searchApp);
            this.Controls.Add(this.runAll);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.deleteApp);
            this.Controls.Add(this.runApp);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.addProgram);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack_Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProgram;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button runApp;
        private System.Windows.Forms.Button deleteApp;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button runAll;
        private System.Windows.Forms.Button searchApp;
    }
}

