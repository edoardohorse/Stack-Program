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
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Name = "searchAppForm";
            this.Text = "Sfoglia fra i programmi";
            this.Load += new System.EventHandler(this.searchApp_load);
            this.Shown += new System.EventHandler(this.saerchAppForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tree;
    }
}