namespace GPA_Calculator
{
    partial class SemesterCreationForm
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
            components = new System.ComponentModel.Container();
            textName = new TextBox();
            label1 = new Label();
            textYear = new TextBox();
            label2 = new Label();
            label3 = new Label();
            listBoxCoursePreview = new ListBox();
            btnAddCourse = new Button();
            label4 = new Label();
            btnSave = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newSemesterToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            addCourseToolStripMenuItem = new ToolStripMenuItem();
            editCourseToolStripMenuItem = new ToolStripMenuItem();
            deleteCourseToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            btnEditCourse = new Button();
            btnDeleteCourse = new Button();
            btnExit = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(41, 156);
            textName.Name = "textName";
            textName.Size = new Size(221, 27);
            textName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 124);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textYear
            // 
            textYear.Location = new Point(290, 156);
            textYear.Name = "textYear";
            textYear.Size = new Size(213, 27);
            textYear.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 133);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 224);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Courses";
            // 
            // listBoxCoursePreview
            // 
            listBoxCoursePreview.FormattingEnabled = true;
            listBoxCoursePreview.Location = new Point(51, 257);
            listBoxCoursePreview.Name = "listBoxCoursePreview";
            listBoxCoursePreview.ScrollAlwaysVisible = true;
            listBoxCoursePreview.Size = new Size(422, 244);
            listBoxCoursePreview.TabIndex = 5;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(127, 223);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(95, 28);
            btnAddCourse.TabIndex = 6;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(109, 53);
            label4.Name = "label4";
            label4.Size = new Size(269, 46);
            label4.TabIndex = 7;
            label4.Text = "Semester Details";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(43, 551);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 51);
            btnSave.TabIndex = 8;
            btnSave.Text = "View Semester";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newSemesterToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(174, 100);
            // 
            // newSemesterToolStripMenuItem
            // 
            newSemesterToolStripMenuItem.Name = "newSemesterToolStripMenuItem";
            newSemesterToolStripMenuItem.Size = new Size(173, 24);
            newSemesterToolStripMenuItem.Text = "New Semester";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(173, 24);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCourseToolStripMenuItem, editCourseToolStripMenuItem, deleteCourseToolStripMenuItem });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(173, 24);
            exitToolStripMenuItem.Text = "Courses";
            // 
            // addCourseToolStripMenuItem
            // 
            addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            addCourseToolStripMenuItem.Size = new Size(185, 26);
            addCourseToolStripMenuItem.Text = "Add Course";
            // 
            // editCourseToolStripMenuItem
            // 
            editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            editCourseToolStripMenuItem.Size = new Size(185, 26);
            editCourseToolStripMenuItem.Text = "Edit Course";
            // 
            // deleteCourseToolStripMenuItem
            // 
            deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            deleteCourseToolStripMenuItem.Size = new Size(185, 26);
            deleteCourseToolStripMenuItem.Text = "Delete Course";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(173, 24);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // btnEditCourse
            // 
            btnEditCourse.Location = new Point(229, 223);
            btnEditCourse.Name = "btnEditCourse";
            btnEditCourse.Size = new Size(107, 28);
            btnEditCourse.TabIndex = 10;
            btnEditCourse.Text = "Edit Course";
            btnEditCourse.UseVisualStyleBackColor = true;
            btnEditCourse.Click += btnEditCourse_Click;
            // 
            // btnDeleteCourse
            // 
            btnDeleteCourse.Location = new Point(286, 519);
            btnDeleteCourse.Name = "btnDeleteCourse";
            btnDeleteCourse.Size = new Size(121, 27);
            btnDeleteCourse.TabIndex = 11;
            btnDeleteCourse.Text = "Delete Course";
            btnDeleteCourse.UseVisualStyleBackColor = true;
            btnDeleteCourse.Click += btnDeleteCourse_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(405, 572);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // SemesterCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 616);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnExit);
            Controls.Add(btnDeleteCourse);
            Controls.Add(btnEditCourse);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(btnAddCourse);
            Controls.Add(listBoxCoursePreview);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textYear);
            Controls.Add(label1);
            Controls.Add(textName);
            Name = "SemesterCreationForm";
            Text = "SemesterCreationForm";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private Label label1;
        private TextBox textYear;
        private Label label2;
        private Label label3;
        private ListBox listBoxCoursePreview;
        private Button btnAddCourse;
        private Label label4;
        private Button btnSave;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newSemesterToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnEditCourse;
        private Button btnDeleteCourse;
        private Button btnExit;
        private ToolStripMenuItem addCourseToolStripMenuItem;
        private ToolStripMenuItem editCourseToolStripMenuItem;
        private ToolStripMenuItem deleteCourseToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}