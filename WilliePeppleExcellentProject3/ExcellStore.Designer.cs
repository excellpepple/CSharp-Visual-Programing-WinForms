namespace WilliePeppleExcellentProject3
{
    partial class ExcellStore
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
            this.picBurger = new System.Windows.Forms.PictureBox();
            this.picCoke = new System.Windows.Forms.PictureBox();
            this.picFries = new System.Windows.Forms.PictureBox();
            this.lblBurgerCount = new System.Windows.Forms.Label();
            this.lblCokeCount = new System.Windows.Forms.Label();
            this.lblFriesCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TxtBoxTip = new System.Windows.Forms.TextBox();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTipMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).BeginInit();
            this.SuspendLayout();
            // 
            // picBurger
            // 
            this.picBurger.Image = global::WilliePeppleExcellentProject3.Properties.Resources.burger;
            this.picBurger.Location = new System.Drawing.Point(32, 23);
            this.picBurger.Name = "picBurger";
            this.picBurger.Size = new System.Drawing.Size(162, 148);
            this.picBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBurger.TabIndex = 0;
            this.picBurger.TabStop = false;
            this.picBurger.Click += new System.EventHandler(this.picBurger_Click);
            // 
            // picCoke
            // 
            this.picCoke.Image = global::WilliePeppleExcellentProject3.Properties.Resources.coke;
            this.picCoke.Location = new System.Drawing.Point(320, 23);
            this.picCoke.Name = "picCoke";
            this.picCoke.Size = new System.Drawing.Size(156, 148);
            this.picCoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoke.TabIndex = 1;
            this.picCoke.TabStop = false;
            this.picCoke.Click += new System.EventHandler(this.picCoke_Click);
            // 
            // picFries
            // 
            this.picFries.Image = global::WilliePeppleExcellentProject3.Properties.Resources.fries;
            this.picFries.Location = new System.Drawing.Point(603, 23);
            this.picFries.Name = "picFries";
            this.picFries.Size = new System.Drawing.Size(168, 148);
            this.picFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFries.TabIndex = 2;
            this.picFries.TabStop = false;
            this.picFries.Click += new System.EventHandler(this.picFries_Click);
            // 
            // lblBurgerCount
            // 
            this.lblBurgerCount.AutoSize = true;
            this.lblBurgerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurgerCount.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblBurgerCount.Location = new System.Drawing.Point(92, 202);
            this.lblBurgerCount.Name = "lblBurgerCount";
            this.lblBurgerCount.Size = new System.Drawing.Size(35, 37);
            this.lblBurgerCount.TabIndex = 3;
            this.lblBurgerCount.Text = "0";
            // 
            // lblCokeCount
            // 
            this.lblCokeCount.AutoSize = true;
            this.lblCokeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCokeCount.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCokeCount.Location = new System.Drawing.Point(388, 202);
            this.lblCokeCount.Name = "lblCokeCount";
            this.lblCokeCount.Size = new System.Drawing.Size(35, 37);
            this.lblCokeCount.TabIndex = 4;
            this.lblCokeCount.Text = "0";
            // 
            // lblFriesCount
            // 
            this.lblFriesCount.AutoSize = true;
            this.lblFriesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriesCount.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFriesCount.Location = new System.Drawing.Point(680, 202);
            this.lblFriesCount.Name = "lblFriesCount";
            this.lblFriesCount.Size = new System.Drawing.Size(35, 37);
            this.lblFriesCount.TabIndex = 5;
            this.lblFriesCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(300, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sub-total";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSubTotal.Location = new System.Drawing.Point(511, 274);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(26, 29);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(300, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tax";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTax.Location = new System.Drawing.Point(511, 322);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(26, 29);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(300, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTotal.Location = new System.Drawing.Point(511, 371);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 29);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0";
            // 
            // TxtBoxTip
            // 
            this.TxtBoxTip.Location = new System.Drawing.Point(227, 485);
            this.TxtBoxTip.Name = "TxtBoxTip";
            this.TxtBoxTip.Size = new System.Drawing.Size(173, 20);
            this.TxtBoxTip.TabIndex = 12;
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(452, 475);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(154, 38);
            this.btnAddTip.TabIndex = 13;
            this.btnAddTip.Text = "Add Tip and Update Total";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(52, 556);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(587, 556);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 38);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTipMessage
            // 
            this.lblTipMessage.AutoSize = true;
            this.lblTipMessage.Location = new System.Drawing.Point(401, 440);
            this.lblTipMessage.Name = "lblTipMessage";
            this.lblTipMessage.Size = new System.Drawing.Size(35, 13);
            this.lblTipMessage.TabIndex = 16;
            this.lblTipMessage.Text = "label1";
            this.lblTipMessage.Visible = false;
            // 
            // ExcellStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 606);
            this.Controls.Add(this.lblTipMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.TxtBoxTip);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFriesCount);
            this.Controls.Add(this.lblCokeCount);
            this.Controls.Add(this.lblBurgerCount);
            this.Controls.Add(this.picFries);
            this.Controls.Add(this.picCoke);
            this.Controls.Add(this.picBurger);
            this.Name = "ExcellStore";
            this.Text = "Excell\'s Store";
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBurger;
        private System.Windows.Forms.PictureBox picCoke;
        private System.Windows.Forms.PictureBox picFries;
        private System.Windows.Forms.Label lblBurgerCount;
        private System.Windows.Forms.Label lblCokeCount;
        private System.Windows.Forms.Label lblFriesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox TxtBoxTip;
        private System.Windows.Forms.Button btnAddTip;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTipMessage;
    }
}

