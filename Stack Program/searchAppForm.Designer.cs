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
            this.tree = new System.Windows.Forms.TreeView();
            this.searchDone = new System.Windows.Forms.Button();
            this.collapseAllTree = new System.Windows.Forms.Button();
            this.expandeAllTree = new System.Windows.Forms.Button();
            this.linkFoundLbl = new System.Windows.Forms.Label();
            this.sortByAZBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortByZABtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listFolderCb = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tree.CheckBoxes = true;
            this.tree.HotTracking = true;
            this.tree.Location = new System.Drawing.Point(12, 115);
            this.tree.Name = "tree";
            this.tree.ShowNodeToolTips = true;
            this.tree.Size = new System.Drawing.Size(530, 493);
            this.tree.TabIndex = 3;
            this.tree.Visible = false;
            this.tree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.addProgramToSelection);
            // 
            // searchDone
            // 
            this.searchDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDone.Location = new System.Drawing.Point(467, 25);
            this.searchDone.Name = "searchDone";
            this.searchDone.Size = new System.Drawing.Size(75, 30);
            this.searchDone.TabIndex = 4;
            this.searchDone.Text = "Fatto";
            this.searchDone.UseVisualStyleBackColor = true;
            this.searchDone.Click += new System.EventHandler(this.searchDone_Click);
            // 
            // collapseAllTree
            // 
            this.collapseAllTree.Location = new System.Drawing.Point(20, 59);
            this.collapseAllTree.Name = "collapseAllTree";
            this.collapseAllTree.Size = new System.Drawing.Size(75, 23);
            this.collapseAllTree.TabIndex = 5;
            this.collapseAllTree.Text = "Collassa";
            this.collapseAllTree.UseVisualStyleBackColor = true;
            this.collapseAllTree.Click += new System.EventHandler(this.collapseAllTree_Click);
            // 
            // expandeAllTree
            // 
            this.expandeAllTree.Location = new System.Drawing.Point(101, 59);
            this.expandeAllTree.Name = "expandeAllTree";
            this.expandeAllTree.Size = new System.Drawing.Size(75, 23);
            this.expandeAllTree.TabIndex = 6;
            this.expandeAllTree.Text = "Espandi";
            this.expandeAllTree.UseVisualStyleBackColor = true;
            this.expandeAllTree.Click += new System.EventHandler(this.expandeAllTree_Click);
            // 
            // linkFoundLbl
            // 
            this.linkFoundLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkFoundLbl.Location = new System.Drawing.Point(356, 625);
            this.linkFoundLbl.Name = "linkFoundLbl";
            this.linkFoundLbl.Size = new System.Drawing.Size(186, 13);
            this.linkFoundLbl.TabIndex = 8;
            this.linkFoundLbl.Text = "Link trovati";
            this.linkFoundLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sortByAZBtn
            // 
            this.sortByAZBtn.Location = new System.Drawing.Point(15, 30);
            this.sortByAZBtn.Name = "sortByAZBtn";
            this.sortByAZBtn.Size = new System.Drawing.Size(82, 23);
            this.sortByAZBtn.TabIndex = 10;
            this.sortByAZBtn.Text = "Ordina A → Z";
            this.sortByAZBtn.UseVisualStyleBackColor = true;
            this.sortByAZBtn.Click += new System.EventHandler(this.sortByAZBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortByZABtn);
            this.groupBox1.Controls.Add(this.sortByAZBtn);
            this.groupBox1.Location = new System.Drawing.Point(200, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 97);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordina link";
            // 
            // sortByZABtn
            // 
            this.sortByZABtn.Location = new System.Drawing.Point(15, 59);
            this.sortByZABtn.Name = "sortByZABtn";
            this.sortByZABtn.Size = new System.Drawing.Size(82, 23);
            this.sortByZABtn.TabIndex = 11;
            this.sortByZABtn.Text = "Ordina Z → A";
            this.sortByZABtn.UseVisualStyleBackColor = true;
            this.sortByZABtn.Click += new System.EventHandler(this.sortByZABtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listFolderCb);
            this.groupBox2.Controls.Add(this.expandeAllTree);
            this.groupBox2.Controls.Add(this.collapseAllTree);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 97);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // listFolderCb
            // 
            this.listFolderCb.Appearance = System.Windows.Forms.Appearance.Button;
            this.listFolderCb.Location = new System.Drawing.Point(24, 30);
            this.listFolderCb.Name = "listFolderCb";
            this.listFolderCb.Size = new System.Drawing.Size(152, 24);
            this.listFolderCb.TabIndex = 12;
            this.listFolderCb.Text = "Lista in cartelle";
            this.listFolderCb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.listFolderCb.UseVisualStyleBackColor = true;
            this.listFolderCb.CheckedChanged += new System.EventHandler(this.listFolderCb_CheckedChanged);
            // 
            // searchAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkFoundLbl);
            this.Controls.Add(this.searchDone);
            this.Controls.Add(this.tree);
            this.Name = "searchAppForm";
            this.Text = "Sfoglia fra i programmi";
            this.Load += new System.EventHandler(this.searchApp_load);
            this.Shown += new System.EventHandler(this.searchAppForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Button searchDone;
        private System.Windows.Forms.Button collapseAllTree;
        private System.Windows.Forms.Button expandeAllTree;
        private System.Windows.Forms.Label linkFoundLbl;
        private System.Windows.Forms.Button sortByAZBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sortByZABtn;
        private System.Windows.Forms.CheckBox listFolderCb;
    }
}