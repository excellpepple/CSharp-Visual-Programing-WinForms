namespace ExcellPepplePasswordChecker
{
    partial class PasswordChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChecker));
            this.listBoxPasswordResults = new System.Windows.Forms.ListBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textPasswordLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLengthValid = new System.Windows.Forms.PictureBox();
            this.picLengthInvalid = new System.Windows.Forms.PictureBox();
            this.picLowerCaseInvalid = new System.Windows.Forms.PictureBox();
            this.picLowercaseValid = new System.Windows.Forms.PictureBox();
            this.picUppercaseInvalid = new System.Windows.Forms.PictureBox();
            this.picUppercaseValid = new System.Windows.Forms.PictureBox();
            this.picNumberInvalid = new System.Windows.Forms.PictureBox();
            this.picNumberValid = new System.Windows.Forms.PictureBox();
            this.picSpecialCharacterInvalid = new System.Windows.Forms.PictureBox();
            this.picSpecialCharacterValid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthInvalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowerCaseInvalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowercaseValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUppercaseInvalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUppercaseValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumberInvalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumberValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecialCharacterInvalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecialCharacterValid)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPasswordResults
            // 
            this.listBoxPasswordResults.FormattingEnabled = true;
            this.listBoxPasswordResults.Location = new System.Drawing.Point(632, 79);
            this.listBoxPasswordResults.Name = "listBoxPasswordResults";
            this.listBoxPasswordResults.Size = new System.Drawing.Size(315, 342);
            this.listBoxPasswordResults.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(46, 79);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(117, 20);
            this.textPassword.TabIndex = 1;
            // 
            // textPasswordLength
            // 
            this.textPasswordLength.Location = new System.Drawing.Point(297, 79);
            this.textPasswordLength.Name = "textPasswordLength";
            this.textPasswordLength.Size = new System.Drawing.Size(117, 20);
            this.textPasswordLength.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min Password Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Has min character length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Has a lower case character";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(427, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Has a uppercase character";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "Has a number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "Has a special character";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(632, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Password Results";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(46, 461);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(177, 28);
            this.btnValidate.TabIndex = 11;
            this.btnValidate.Text = "Validate Password";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(632, 461);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(872, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLengthValid
            // 
            this.picLengthValid.Image = ((System.Drawing.Image)(resources.GetObject("picLengthValid.Image")));
            this.picLengthValid.Location = new System.Drawing.Point(84, 160);
            this.picLengthValid.Name = "picLengthValid";
            this.picLengthValid.Size = new System.Drawing.Size(79, 37);
            this.picLengthValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLengthValid.TabIndex = 14;
            this.picLengthValid.TabStop = false;
            // 
            // picLengthInvalid
            // 
            this.picLengthInvalid.Image = ((System.Drawing.Image)(resources.GetObject("picLengthInvalid.Image")));
            this.picLengthInvalid.Location = new System.Drawing.Point(72, 160);
            this.picLengthInvalid.Name = "picLengthInvalid";
            this.picLengthInvalid.Size = new System.Drawing.Size(91, 37);
            this.picLengthInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLengthInvalid.TabIndex = 15;
            this.picLengthInvalid.TabStop = false;
            // 
            // picLowerCaseInvalid
            // 
            this.picLowerCaseInvalid.Image = ((System.Drawing.Image)(resources.GetObject("picLowerCaseInvalid.Image")));
            this.picLowerCaseInvalid.Location = new System.Drawing.Point(72, 230);
            this.picLowerCaseInvalid.Name = "picLowerCaseInvalid";
            this.picLowerCaseInvalid.Size = new System.Drawing.Size(91, 37);
            this.picLowerCaseInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLowerCaseInvalid.TabIndex = 17;
            this.picLowerCaseInvalid.TabStop = false;
            // 
            // picLowercaseValid
            // 
            this.picLowercaseValid.Image = ((System.Drawing.Image)(resources.GetObject("picLowercaseValid.Image")));
            this.picLowercaseValid.Location = new System.Drawing.Point(72, 230);
            this.picLowercaseValid.Name = "picLowercaseValid";
            this.picLowercaseValid.Size = new System.Drawing.Size(91, 37);
            this.picLowercaseValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLowercaseValid.TabIndex = 16;
            this.picLowercaseValid.TabStop = false;
            // 
            // picUppercaseInvalid
            // 
            this.picUppercaseInvalid.Image = ((System.Drawing.Image)(resources.GetObject("picUppercaseInvalid.Image")));
            this.picUppercaseInvalid.Location = new System.Drawing.Point(72, 286);
            this.picUppercaseInvalid.Name = "picUppercaseInvalid";
            this.picUppercaseInvalid.Size = new System.Drawing.Size(91, 37);
            this.picUppercaseInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUppercaseInvalid.TabIndex = 19;
            this.picUppercaseInvalid.TabStop = false;
            // 
            // picUppercaseValid
            // 
            this.picUppercaseValid.Image = ((System.Drawing.Image)(resources.GetObject("picUppercaseValid.Image")));
            this.picUppercaseValid.Location = new System.Drawing.Point(72, 286);
            this.picUppercaseValid.Name = "picUppercaseValid";
            this.picUppercaseValid.Size = new System.Drawing.Size(91, 37);
            this.picUppercaseValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUppercaseValid.TabIndex = 18;
            this.picUppercaseValid.TabStop = false;
            // 
            // picNumberInvalid
            // 
            this.picNumberInvalid.Image = ((System.Drawing.Image)(resources.GetObject("picNumberInvalid.Image")));
            this.picNumberInvalid.Location = new System.Drawing.Point(72, 346);
            this.picNumberInvalid.Name = "picNumberInvalid";
            this.picNumberInvalid.Size = new System.Drawing.Size(91, 33);
            this.picNumberInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNumberInvalid.TabIndex = 21;
            this.picNumberInvalid.TabStop = false;
            // 
            // picNumberValid
            // 
            this.picNumberValid.Image = ((System.Drawing.Image)(resources.GetObject("picNumberValid.Image")));
            this.picNumberValid.Location = new System.Drawing.Point(72, 346);
            this.picNumberValid.Name = "picNumberValid";
            this.picNumberValid.Size = new System.Drawing.Size(91, 33);
            this.picNumberValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNumberValid.TabIndex = 20;
            this.picNumberValid.TabStop = false;
            // 
            // picSpecialCharacterInvalid
            // 
            this.picSpecialCharacterInvalid.Image = ((System.Drawing.Image)(resources.GetObject("picSpecialCharacterInvalid.Image")));
            this.picSpecialCharacterInvalid.Location = new System.Drawing.Point(72, 402);
            this.picSpecialCharacterInvalid.Name = "picSpecialCharacterInvalid";
            this.picSpecialCharacterInvalid.Size = new System.Drawing.Size(91, 37);
            this.picSpecialCharacterInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpecialCharacterInvalid.TabIndex = 23;
            this.picSpecialCharacterInvalid.TabStop = false;
            // 
            // picSpecialCharacterValid
            // 
            this.picSpecialCharacterValid.Image = ((System.Drawing.Image)(resources.GetObject("picSpecialCharacterValid.Image")));
            this.picSpecialCharacterValid.Location = new System.Drawing.Point(72, 402);
            this.picSpecialCharacterValid.Name = "picSpecialCharacterValid";
            this.picSpecialCharacterValid.Size = new System.Drawing.Size(91, 33);
            this.picSpecialCharacterValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpecialCharacterValid.TabIndex = 22;
            this.picSpecialCharacterValid.TabStop = false;
            // 
            // PasswordChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 522);
            this.Controls.Add(this.picSpecialCharacterInvalid);
            this.Controls.Add(this.picSpecialCharacterValid);
            this.Controls.Add(this.picNumberInvalid);
            this.Controls.Add(this.picNumberValid);
            this.Controls.Add(this.picUppercaseInvalid);
            this.Controls.Add(this.picUppercaseValid);
            this.Controls.Add(this.picLowerCaseInvalid);
            this.Controls.Add(this.picLowercaseValid);
            this.Controls.Add(this.picLengthInvalid);
            this.Controls.Add(this.picLengthValid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPasswordLength);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.listBoxPasswordResults);
            this.Name = "PasswordChecker";
            this.Text = "Password Checker";
            ((System.ComponentModel.ISupportInitialize)(this.picLengthValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLengthInvalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowerCaseInvalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowercaseValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUppercaseInvalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUppercaseValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumberInvalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumberValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecialCharacterInvalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecialCharacterValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPasswordResults;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textPasswordLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLengthValid;
        private System.Windows.Forms.PictureBox picLengthInvalid;
        private System.Windows.Forms.PictureBox picLowerCaseInvalid;
        private System.Windows.Forms.PictureBox picLowercaseValid;
        private System.Windows.Forms.PictureBox picUppercaseInvalid;
        private System.Windows.Forms.PictureBox picUppercaseValid;
        private System.Windows.Forms.PictureBox picNumberInvalid;
        private System.Windows.Forms.PictureBox picNumberValid;
        private System.Windows.Forms.PictureBox picSpecialCharacterInvalid;
        private System.Windows.Forms.PictureBox picSpecialCharacterValid;
    }
}

