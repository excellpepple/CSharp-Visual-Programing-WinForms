namespace ExcellPeppleProject5
{
    partial class MusicPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPage));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.radioPoison = new System.Windows.Forms.RadioButton();
            this.radioMotley = new System.Windows.Forms.RadioButton();
            this.radioJovi = new System.Windows.Forms.RadioButton();
            this.radioGNR = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(229, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(59, 314);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // radioPoison
            // 
            this.radioPoison.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioPoison.BackgroundImage")));
            this.radioPoison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioPoison.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioPoison.Location = new System.Drawing.Point(198, 174);
            this.radioPoison.Name = "radioPoison";
            this.radioPoison.Size = new System.Drawing.Size(158, 118);
            this.radioPoison.TabIndex = 13;
            this.radioPoison.TabStop = true;
            this.radioPoison.UseVisualStyleBackColor = true;
            // 
            // radioMotley
            // 
            this.radioMotley.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioMotley.BackgroundImage")));
            this.radioMotley.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioMotley.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioMotley.Location = new System.Drawing.Point(34, 174);
            this.radioMotley.Name = "radioMotley";
            this.radioMotley.Size = new System.Drawing.Size(158, 118);
            this.radioMotley.TabIndex = 12;
            this.radioMotley.TabStop = true;
            this.radioMotley.UseVisualStyleBackColor = true;
            // 
            // radioJovi
            // 
            this.radioJovi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioJovi.BackgroundImage")));
            this.radioJovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioJovi.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioJovi.Location = new System.Drawing.Point(198, 12);
            this.radioJovi.Name = "radioJovi";
            this.radioJovi.Size = new System.Drawing.Size(158, 118);
            this.radioJovi.TabIndex = 11;
            this.radioJovi.TabStop = true;
            this.radioJovi.UseVisualStyleBackColor = true;
            // 
            // radioGNR
            // 
            this.radioGNR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioGNR.BackgroundImage")));
            this.radioGNR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioGNR.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioGNR.Location = new System.Drawing.Point(34, 12);
            this.radioGNR.Name = "radioGNR";
            this.radioGNR.Size = new System.Drawing.Size(158, 118);
            this.radioGNR.TabIndex = 10;
            this.radioGNR.TabStop = true;
            this.radioGNR.UseVisualStyleBackColor = true;
            // 
            // MusicPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 344);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.radioPoison);
            this.Controls.Add(this.radioMotley);
            this.Controls.Add(this.radioJovi);
            this.Controls.Add(this.radioGNR);
            this.Name = "MusicPage";
            this.Text = "music";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.RadioButton radioPoison;
        private System.Windows.Forms.RadioButton radioMotley;
        private System.Windows.Forms.RadioButton radioJovi;
        private System.Windows.Forms.RadioButton radioGNR;
    }
}