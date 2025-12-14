namespace GPA_Calculator
{
    partial class ClassCreationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textName = new TextBox();
            comboBxLetterGrade = new ComboBox();
            textHours = new TextBox();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(70, 32);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "Class Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 167);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Letter Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 158);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Credit Hours";
            // 
            // textName
            // 
            textName.Location = new Point(27, 110);
            textName.Margin = new Padding(3, 2, 3, 2);
            textName.Name = "textName";
            textName.Size = new Size(260, 23);
            textName.TabIndex = 4;
            // 
            // comboBxLetterGrade
            // 
            comboBxLetterGrade.FormattingEnabled = true;
            comboBxLetterGrade.Location = new Point(178, 184);
            comboBxLetterGrade.Margin = new Padding(3, 2, 3, 2);
            comboBxLetterGrade.Name = "comboBxLetterGrade";
            comboBxLetterGrade.Size = new Size(133, 23);
            comboBxLetterGrade.TabIndex = 5;
            // 
            // textHours
            // 
            textHours.Location = new Point(27, 184);
            textHours.Margin = new Padding(3, 2, 3, 2);
            textHours.Name = "textHours";
            textHours.Size = new Size(87, 23);
            textHours.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(25, 243);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 28);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Class";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(225, 243);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 28);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ClassCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 296);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(textHours);
            Controls.Add(comboBxLetterGrade);
            Controls.Add(textName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClassCreationForm";
            Text = "ClassCreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textName;
        private ComboBox comboBxLetterGrade;
        private TextBox textHours;
        private Button btnSave;
        private Button btnExit;
    }
}