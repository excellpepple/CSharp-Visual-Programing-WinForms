namespace ExcellPeppleProject5
{
    partial class frmStartUp
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
            this.components = new System.ComponentModel.Container();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lbxShoppingCart = new System.Windows.Forms.ListBox();
            this.checkShouldShip = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductsMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductsMovies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductsGames = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.picSelectedItem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picSelectedItem)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            //
            // btnRemoveSelected
            //
            this.btnRemoveSelected.Location = new System.Drawing.Point(16, 283);
            this.btnRemoveSelected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(308, 28);
            this.btnRemoveSelected.TabIndex = 0;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            //
            // lbxShoppingCart
            //
            this.lbxShoppingCart.FormattingEnabled = true;
            this.lbxShoppingCart.ItemHeight = 16;
            this.lbxShoppingCart.Location = new System.Drawing.Point(16, 75);
            this.lbxShoppingCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxShoppingCart.Name = "lbxShoppingCart";
            this.lbxShoppingCart.ScrollAlwaysVisible = true;
            this.lbxShoppingCart.Size = new System.Drawing.Size(308, 180);
            this.lbxShoppingCart.TabIndex = 1;
            this.lbxShoppingCart.SelectedIndexChanged += new System.EventHandler(this.lbxShoppingCart_SelectedIndexChanged);
            //
            // checkShouldShip
            //
            this.checkShouldShip.AutoSize = true;
            this.checkShouldShip.Location = new System.Drawing.Point(71, 351);
            this.checkShouldShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkShouldShip.Name = "checkShouldShip";
            this.checkShouldShip.Size = new System.Drawing.Size(108, 20);
            this.checkShouldShip.TabIndex = 2;
            this.checkShouldShip.Text = "Add Shipping";
            this.checkShouldShip.UseVisualStyleBackColor = true;
            this.checkShouldShip.CheckedChanged += new System.EventHandler(this.checkShouldShip_CheckedChanged);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal";
            //
            // lblSubTotal
            //
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(515, 170);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(22, 16);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "$0";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tax:";
            //
            // lblTax
            //
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(515, 199);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(45, 16);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "label4";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Shipping:";
            //
            // lblShipping
            //
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(515, 255);
            this.lblShipping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(45, 16);
            this.lblShipping.TabIndex = 8;
            this.lblShipping.Text = "label6";
            //
            // label
            //
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(415, 382);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 16);
            this.label.TabIndex = 9;
            this.label.Text = "Total";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(509, 382);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "label8";
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.productsToolStripMenuItem, this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            //
            // fileToolStripMenuItem
            //
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuFileClearAll, this.mnuFileRemove, this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            //
            // mnuFileClearAll
            //
            this.mnuFileClearAll.Name = "mnuFileClearAll";
            this.mnuFileClearAll.Size = new System.Drawing.Size(152, 22);
            this.mnuFileClearAll.Text = "Clear All Items";
            this.mnuFileClearAll.ToolTipText = "Clears all items from cart";
            this.mnuFileClearAll.Click += new System.EventHandler(this.mnuFileClearAll_Click);
            //
            // mnuFileRemove
            //
            this.mnuFileRemove.Name = "mnuFileRemove";
            this.mnuFileRemove.Size = new System.Drawing.Size(152, 22);
            this.mnuFileRemove.Text = "Remove Item";
            this.mnuFileRemove.ToolTipText = "Removes selected item from cart";
            this.mnuFileRemove.Click += new System.EventHandler(this.mnuFileRemove_Click);
            //
            // mnuFileExit
            //
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            //
            // productsToolStripMenuItem
            //
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuProductsMusic, this.mnuProductsMovies, this.mnuProductsGames});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            //
            // mnuProductsMusic
            //
            this.mnuProductsMusic.Name = "mnuProductsMusic";
            this.mnuProductsMusic.Size = new System.Drawing.Size(152, 22);
            this.mnuProductsMusic.Text = "Music";
            this.mnuProductsMusic.ToolTipText = "Browse Musicc Library";
            this.mnuProductsMusic.Click += new System.EventHandler(this.mnuProductsMusic_Click);
            //
            // mnuProductsMovies
            //
            this.mnuProductsMovies.Name = "mnuProductsMovies";
            this.mnuProductsMovies.Size = new System.Drawing.Size(152, 22);
            this.mnuProductsMovies.Text = "Movies";
            this.mnuProductsMovies.ToolTipText = "Browse Movies Library";
            this.mnuProductsMovies.Click += new System.EventHandler(this.mnuProductsMovies_Click);
            //
            // mnuProductsGames
            //
            this.mnuProductsGames.Name = "mnuProductsGames";
            this.mnuProductsGames.Size = new System.Drawing.Size(152, 22);
            this.mnuProductsGames.Text = "Video Games";
            this.mnuProductsGames.ToolTipText = "Browse Video Game Library";
            this.mnuProductsGames.Click += new System.EventHandler(this.mnuProductsGames_Click);
            //
            // helpToolStripMenuItem
            //
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            //
            // mnuHelpAbout
            //
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.ToolTipText = "Learn about the author";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            //
            // picSelectedItem
            //
            this.picSelectedItem.Location = new System.Drawing.Point(397, 75);
            this.picSelectedItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSelectedItem.Name = "picSelectedItem";
            this.picSelectedItem.Size = new System.Drawing.Size(159, 76);
            this.picSelectedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelectedItem.TabIndex = 11;
            this.picSelectedItem.TabStop = false;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Items";
            //
            // lblItemCount
            //
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(115, 55);
            this.lblItemCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(45, 16);
            this.lblItemCount.TabIndex = 14;
            this.lblItemCount.Text = "label4";
            //
            // contextMenu
            //
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.productsToolStripMenuItem1, this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip2";
            this.contextMenu.Size = new System.Drawing.Size(122, 48);
            //
            // productsToolStripMenuItem1
            //
            this.productsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.musicToolStripMenuItem, this.moviesToolStripMenuItem, this.gamesToolStripMenuItem});
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.productsToolStripMenuItem1.Text = "Products";
            //
            // musicToolStripMenuItem
            //
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.mnuProductsMusic_Click);
            //
            // moviesToolStripMenuItem
            //
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.mnuProductsMovies_Click);
            //
            // gamesToolStripMenuItem
            //
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gamesToolStripMenuItem.Text = "Games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.mnuProductsGames_Click);
            //
            // exitToolStripMenuItem
            //
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.mnuFileExit_Click);
            //
            // frmStartUp
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 434);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.lblItemCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picSelectedItem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkShouldShip);
            this.Controls.Add(this.lbxShoppingCart);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStartUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStartUp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picSelectedItem)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;

        #endregion

        private System.Windows.Forms.Button btnRemoveSelected;
        public System.Windows.Forms.ListBox lbxShoppingCart;
        private System.Windows.Forms.CheckBox checkShouldShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox picSelectedItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProductsMusic;
        private System.Windows.Forms.ToolStripMenuItem mnuProductsMovies;
        private System.Windows.Forms.ToolStripMenuItem mnuProductsGames;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClearAll;
        private System.Windows.Forms.ToolStripMenuItem mnuFileRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemCount;
    }
}

