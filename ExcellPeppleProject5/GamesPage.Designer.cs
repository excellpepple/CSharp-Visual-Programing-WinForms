namespace ExcellPeppleProject5
{
    partial class GamesPage
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbxGamesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(49, 386);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 28);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(276, 386);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbxGamesList
            // 
            this.lbxGamesList.FormattingEnabled = true;
            this.lbxGamesList.ItemHeight = 16;
            this.lbxGamesList.Location = new System.Drawing.Point(41, 39);
            this.lbxGamesList.Margin = new System.Windows.Forms.Padding(4);
            this.lbxGamesList.Name = "lbxGamesList";
            this.lbxGamesList.Size = new System.Drawing.Size(393, 308);
            this.lbxGamesList.TabIndex = 10;
            // 
            // GamesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 426);
            this.Controls.Add(this.lbxGamesList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddItem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GamesPage";
            this.Text = "games";
            this.Load += new System.EventHandler(this.GamesPage_Load_1);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbxGamesList;
    }
}