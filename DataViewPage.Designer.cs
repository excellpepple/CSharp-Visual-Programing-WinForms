namespace ExcellPeppleProject6
{
    partial class DataViewPage
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
            lblTitle = new Label();
            lblDate = new Label();
            lblPageNumber = new Label();
            picPreview = new PictureBox();
            label4 = new Label();
            lblRuntime = new Label();
            lblRatings = new Label();
            label7 = new Label();
            lblGenre = new Label();
            label9 = new Label();
            lblFormat = new Label();
            label11 = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(35, 56);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(35, 92);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(601, 56);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(36, 15);
            lblPageNumber.TabIndex = 2;
            lblPageNumber.Text = "0 of 0";
            // 
            // picPreview
            // 
            picPreview.Location = new Point(212, 138);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(258, 306);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 3;
            picPreview.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 470);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Runtime";
            // 
            // lblRuntime
            // 
            lblRuntime.AutoSize = true;
            lblRuntime.Location = new Point(96, 470);
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Size = new Size(38, 15);
            lblRuntime.TabIndex = 5;
            lblRuntime.Text = "label5";
            // 
            // lblRatings
            // 
            lblRatings.AutoSize = true;
            lblRatings.Location = new Point(444, 496);
            lblRatings.Name = "lblRatings";
            lblRatings.Size = new Size(38, 15);
            lblRatings.TabIndex = 7;
            lblRatings.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 496);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 6;
            label7.Text = "Ratings";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(96, 530);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(38, 15);
            lblGenre.TabIndex = 9;
            lblGenre.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 530);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 8;
            label9.Text = "Genre";
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.Location = new Point(96, 583);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(44, 15);
            lblFormat.TabIndex = 11;
            lblFormat.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 583);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 10;
            label11.Text = "Format";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(59, 631);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 44);
            btnNext.TabIndex = 12;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(262, 629);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(106, 43);
            btnPrevious.TabIndex = 13;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(497, 635);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 37);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // DataViewPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 685);
            Controls.Add(btnExit);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(lblFormat);
            Controls.Add(label11);
            Controls.Add(lblGenre);
            Controls.Add(label9);
            Controls.Add(lblRatings);
            Controls.Add(label7);
            Controls.Add(lblRuntime);
            Controls.Add(label4);
            Controls.Add(picPreview);
            Controls.Add(lblPageNumber);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            Name = "DataViewPage";
            Text = "DataViewPage";
            Load += DataViewPage_Load;
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDate;
        private Label lblPageNumber;
        private PictureBox picPreview;
        private Label label4;
        private Label lblRuntime;
        private Label lblRatings;
        private Label label7;
        private Label lblGenre;
        private Label label9;
        private Label lblFormat;
        private Label label11;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnExit;
    }
}