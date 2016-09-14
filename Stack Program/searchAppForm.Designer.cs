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
            this.components = new System.ComponentModel.Container();
            this.tree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.CheckBoxes = true;
            this.tree.HotTracking = true;
            this.tree.Location = new System.Drawing.Point(35, 33);
            this.tree.Name = "tree";
            this.tree.ShowNodeToolTips = true;
            this.tree.Size = new System.Drawing.Size(369, 575);
            this.tree.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Enabled = false;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 657);
            this.Controls.Add(this.tree);
            this.Name = "searchAppForm";
            this.Text = "Sfoglia fra i programmi";
            this.Load += new System.EventHandler(this.searchApp_load);
            this.Shown += new System.EventHandler(this.saerchAppForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}