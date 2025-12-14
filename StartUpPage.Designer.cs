namespace ExcellPeppleProject6;

partial class StartUpPage
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        pictureBox1 = new PictureBox();
        btnAddMovies = new Button();
        btnViewMovies = new Button();
        btnExit = new Button();
        openFileDialog = new OpenFileDialog();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.main;
        pictureBox1.Location = new Point(76, 43);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(459, 234);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // btnAddMovies
        // 
        btnAddMovies.Location = new Point(195, 292);
        btnAddMovies.Name = "btnAddMovies";
        btnAddMovies.Size = new Size(244, 50);
        btnAddMovies.TabIndex = 1;
        btnAddMovies.Text = "Add Movies To Collection";
        btnAddMovies.UseVisualStyleBackColor = true;
        btnAddMovies.Click += btnAddMovies_Click;
        // 
        // btnViewMovies
        // 
        btnViewMovies.Location = new Point(195, 357);
        btnViewMovies.Name = "btnViewMovies";
        btnViewMovies.Size = new Size(244, 39);
        btnViewMovies.TabIndex = 2;
        btnViewMovies.Text = "View Movies in Collection";
        btnViewMovies.UseVisualStyleBackColor = true;
        btnViewMovies.Click += btnViewMovies_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(539, 386);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(91, 25);
        btnExit.TabIndex = 3;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // openFileDialog
        // 
        openFileDialog.FileName = "openFileDialog1";
        // 
        // StartUpPage
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(665, 417);
        Controls.Add(btnExit);
        Controls.Add(btnViewMovies);
        Controls.Add(btnAddMovies);
        Controls.Add(pictureBox1);
        Name = "StartUpPage";
        Text = "StartUpPage";
        FormClosed += StartUpPage_FormClosed;
        Load += StartUpPage_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private Button btnAddMovies;
    private Button btnViewMovies;
    private Button btnExit;
    private OpenFileDialog openFileDialog;
}