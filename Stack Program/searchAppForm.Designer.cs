namespace Stack_Program
{
    partial class searchAppForm
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
            this.gridSearch = new System.Windows.Forms.DataGridView();
            this.barSearch = new System.Windows.Forms.ProgressBar();
            this.lbInfo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tree = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSearch
            // 
            this.gridSearch.AllowUserToOrderColumns = true;
            this.gridSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearch.Location = new System.Drawing.Point(12, 12);
            this.gridSearch.Name = "gridSearch";
            this.gridSearch.Size = new System.Drawing.Size(421, 633);
            this.gridSearch.TabIndex = 0;
            // 
            // barSearch
            // 
            this.barSearch.Location = new System.Drawing.Point(61, 320);
            this.barSearch.Name = "barSearch";
            this.barSearch.Size = new System.Drawing.Size(334, 23);
            this.barSearch.Step = 1;
            this.barSearch.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barSearch.TabIndex = 1;
            this.barSearch.Visible = false;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.Black;
            this.lbInfo.Location = new System.Drawing.Point(125, 268);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInfo.Size = new System.Drawing.Size(213, 23);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Attendi...";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInfo.Visible = false;
            // 
            // backgroundWorker1
            // 
            //   this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            //    this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            //    this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tree
            // 
            this.tree.CheckBoxes = true;
            this.tree.FullRowSelect = true;
            this.tree.HotTracking = true;
            this.tree.Location = new System.Drawing.Point(35, 33);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(376, 575);
            this.tree.TabIndex = 3;
            // 
            // searchAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 657);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.barSearch);
            this.Controls.Add(this.gridSearch);
            this.Name = "searchAppForm";
            this.Text = "Sfoglia fra i programmi";
            //  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cancelAsync);
            this.Load += new System.EventHandler(this.searchApp_load);
            this.Shown += new System.EventHandler(this.saerchAppForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSearch;
        private System.Windows.Forms.ProgressBar barSearch;
        private System.Windows.Forms.Label lbInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TreeView tree;
    }
}