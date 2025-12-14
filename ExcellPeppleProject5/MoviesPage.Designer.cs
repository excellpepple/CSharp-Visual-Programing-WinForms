namespace ExcellPeppleProject5
{
    partial class MoviesPage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.picRotla = new System.Windows.Forms.PictureBox();
            this.picBC = new System.Windows.Forms.PictureBox();
            this.picBttf = new System.Windows.Forms.PictureBox();
            this.picCbml = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.picRotla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBttf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picCbml)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(190, 405);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picRotla
            // 
            this.picRotla.Location = new System.Drawing.Point(41, 38);
            this.picRotla.Margin = new System.Windows.Forms.Padding(4);
            this.picRotla.Name = "picRotla";
            this.picRotla.Size = new System.Drawing.Size(163, 140);
            this.picRotla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRotla.TabIndex = 22;
            this.picRotla.TabStop = false;
            this.picRotla.Click += new System.EventHandler(this.picRotla_Click);
            // 
            // picBC
            // 
            this.picBC.Location = new System.Drawing.Point(284, 38);
            this.picBC.Margin = new System.Windows.Forms.Padding(4);
            this.picBC.Name = "picBC";
            this.picBC.Size = new System.Drawing.Size(163, 140);
            this.picBC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBC.TabIndex = 23;
            this.picBC.TabStop = false;
            this.picBC.Click += new System.EventHandler(this.picBC_Click);
            // 
            // picBttf
            // 
            this.picBttf.Location = new System.Drawing.Point(41, 222);
            this.picBttf.Margin = new System.Windows.Forms.Padding(4);
            this.picBttf.Name = "picBttf";
            this.picBttf.Size = new System.Drawing.Size(163, 140);
            this.picBttf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBttf.TabIndex = 24;
            this.picBttf.TabStop = false;
            this.picBttf.Click += new System.EventHandler(this.picBttf_Click);
            // 
            // picCbml
            // 
            this.picCbml.Location = new System.Drawing.Point(284, 222);
            this.picCbml.Margin = new System.Windows.Forms.Padding(4);
            this.picCbml.Name = "picCbml";
            this.picCbml.Size = new System.Drawing.Size(163, 140);
            this.picCbml.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCbml.TabIndex = 25;
            this.picCbml.TabStop = false;
            this.picCbml.Click += new System.EventHandler(this.picCbml_Click);
            // 
            // MoviesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 446);
            this.Controls.Add(this.picCbml);
            this.Controls.Add(this.picBttf);
            this.Controls.Add(this.picBC);
            this.Controls.Add(this.picRotla);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MoviesPage";
            this.Text = "movies";
            this.Load += new System.EventHandler(this.MoviesPage_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picRotla)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBttf)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picCbml)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picRotla;
        private System.Windows.Forms.PictureBox picBC;
        private System.Windows.Forms.PictureBox picBttf;
        private System.Windows.Forms.PictureBox picCbml;
    }
}