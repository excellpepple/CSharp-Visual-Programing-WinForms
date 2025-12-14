namespace GPA_Calculator
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnLoadSemester = new Button();
            btnStartSemester = new Button();
            btnExit = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newSemesterToolStripMenuItem = new ToolStripMenuItem();
            loadSemesterToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            startNewSemesterToolStripMenuItem = new ToolStripMenuItem();
            loadSemesterToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 42F);
            label1.Location = new Point(142, 133);
            label1.Name = "label1";
            label1.Size = new Size(496, 93);
            label1.TabIndex = 0;
            label1.Text = "GPA Calculator";
            // 
            // btnLoadSemester
            // 
            btnLoadSemester.Location = new Point(26, 397);
            btnLoadSemester.Name = "btnLoadSemester";
            btnLoadSemester.Size = new Size(142, 40);
            btnLoadSemester.TabIndex = 1;
            btnLoadSemester.Text = "Load Semester";
            btnLoadSemester.UseVisualStyleBackColor = true;
            btnLoadSemester.Click += btnLoadSemester_Click;
            // 
            // btnStartSemester
            // 
            btnStartSemester.Location = new Point(259, 265);
            btnStartSemester.Name = "btnStartSemester";
            btnStartSemester.Size = new Size(234, 55);
            btnStartSemester.TabIndex = 2;
            btnStartSemester.Text = "Start New Semester";
            btnStartSemester.UseVisualStyleBackColor = true;
            btnStartSemester.Click += btnStartSemester_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(571, 365);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newSemesterToolStripMenuItem, loadSemesterToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newSemesterToolStripMenuItem
            // 
            newSemesterToolStripMenuItem.Name = "newSemesterToolStripMenuItem";
            newSemesterToolStripMenuItem.Size = new Size(224, 26);
            newSemesterToolStripMenuItem.Text = "New Semester";
            newSemesterToolStripMenuItem.Click += btnStartSemester_Click;
            // 
            // loadSemesterToolStripMenuItem
            // 
            loadSemesterToolStripMenuItem.Name = "loadSemesterToolStripMenuItem";
            loadSemesterToolStripMenuItem.Size = new Size(224, 26);
            loadSemesterToolStripMenuItem.Text = "Load Semester";
            loadSemesterToolStripMenuItem.Click += btnLoadSemester_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += btnExit_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(52, 24);
            helpToolStripMenuItem.Text = "help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(131, 26);
            aboutToolStripMenuItem.Text = "about";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, helpToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { startNewSemesterToolStripMenuItem, loadSemesterToolStripMenuItem1, exitToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(210, 24);
            fileToolStripMenuItem1.Text = "File";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(210, 24);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // startNewSemesterToolStripMenuItem
            // 
            startNewSemesterToolStripMenuItem.Name = "startNewSemesterToolStripMenuItem";
            startNewSemesterToolStripMenuItem.Size = new Size(224, 26);
            startNewSemesterToolStripMenuItem.Text = "Start New Semester";
            startNewSemesterToolStripMenuItem.Click += btnStartSemester_Click;
            // 
            // loadSemesterToolStripMenuItem1
            // 
            loadSemesterToolStripMenuItem1.Name = "loadSemesterToolStripMenuItem1";
            loadSemesterToolStripMenuItem1.Size = new Size(224, 26);
            loadSemesterToolStripMenuItem1.Text = "Load Semester";
            loadSemesterToolStripMenuItem1.Click += btnLoadSemester_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(224, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += btnExit_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(224, 26);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnExit);
            Controls.Add(btnStartSemester);
            Controls.Add(btnLoadSemester);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLoadSemester;
        private Button btnStartSemester;
        private Button btnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newSemesterToolStripMenuItem;
        private ToolStripMenuItem loadSemesterToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem startNewSemesterToolStripMenuItem;
        private ToolStripMenuItem loadSemesterToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}
