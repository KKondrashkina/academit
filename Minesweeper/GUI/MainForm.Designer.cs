using System.Windows.Forms;

namespace Minesweeper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.gameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.allElements = new System.Windows.Forms.TableLayoutPanel();
            this.information = new System.Windows.Forms.TableLayoutPanel();
            this.clockPicture = new System.Windows.Forms.PictureBox();
            this.minePicture = new System.Windows.Forms.PictureBox();
            this.minesCount = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.TableLayoutPanel();
            this.menu.SuspendLayout();
            this.allElements.SuspendLayout();
            this.information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuItem,
            this.aboutMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(300, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // gameMenuItem
            // 
            this.gameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuItem,
            this.toolStripSeparator1,
            this.settingsMenuItem,
            this.highScoresMenuItem,
            this.toolStripSeparator2,
            this.exitMenuItem});
            this.gameMenuItem.Name = "gameMenuItem";
            this.gameMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameMenuItem.Text = "Game";
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameMenuItem.Text = "New game";
            this.newGameMenuItem.Click += new System.EventHandler(this.NewGameMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsMenuItem.Text = "Settings";
            this.settingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // highScoresMenuItem
            // 
            this.highScoresMenuItem.Name = "highScoresMenuItem";
            this.highScoresMenuItem.Size = new System.Drawing.Size(180, 22);
            this.highScoresMenuItem.Text = "High Scores";
            this.highScoresMenuItem.Click += new System.EventHandler(this.HighScoresMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // allElements
            // 
            this.allElements.AutoSize = true;
            this.allElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allElements.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.allElements.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allElements.BackgroundImage")));
            this.allElements.ColumnCount = 1;
            this.allElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allElements.Controls.Add(this.information, 0, 0);
            this.allElements.Controls.Add(this.field, 0, 1);
            this.allElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allElements.Location = new System.Drawing.Point(0, 24);
            this.allElements.Margin = new System.Windows.Forms.Padding(14, 7, 14, 7);
            this.allElements.Name = "allElements";
            this.allElements.RowCount = 2;
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allElements.Size = new System.Drawing.Size(300, 330);
            this.allElements.TabIndex = 2;
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.BackColor = System.Drawing.Color.Transparent;
            this.information.ColumnCount = 4;
            this.information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.information.Controls.Add(this.clockPicture, 2, 0);
            this.information.Controls.Add(this.minePicture, 0, 0);
            this.information.Controls.Add(this.minesCount, 1, 0);
            this.information.Controls.Add(this.gameTime, 3, 0);
            this.information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.information.Location = new System.Drawing.Point(0, 0);
            this.information.Margin = new System.Windows.Forms.Padding(0);
            this.information.Name = "information";
            this.information.RowCount = 1;
            this.information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.information.Size = new System.Drawing.Size(300, 30);
            this.information.TabIndex = 1;
            // 
            // clockPicture
            // 
            this.clockPicture.BackColor = System.Drawing.Color.Transparent;
            this.clockPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clockPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.clockPicture.Image = ((System.Drawing.Image)(resources.GetObject("clockPicture.Image")));
            this.clockPicture.Location = new System.Drawing.Point(200, 0);
            this.clockPicture.Margin = new System.Windows.Forms.Padding(0);
            this.clockPicture.Name = "clockPicture";
            this.clockPicture.Size = new System.Drawing.Size(25, 30);
            this.clockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clockPicture.TabIndex = 8;
            this.clockPicture.TabStop = false;
            // 
            // minePicture
            // 
            this.minePicture.BackColor = System.Drawing.Color.Transparent;
            this.minePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minePicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.minePicture.Image = ((System.Drawing.Image)(resources.GetObject("minePicture.Image")));
            this.minePicture.Location = new System.Drawing.Point(50, 0);
            this.minePicture.Margin = new System.Windows.Forms.Padding(0);
            this.minePicture.Name = "minePicture";
            this.minePicture.Size = new System.Drawing.Size(25, 30);
            this.minePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minePicture.TabIndex = 7;
            this.minePicture.TabStop = false;
            // 
            // minesCount
            // 
            this.minesCount.AutoSize = true;
            this.minesCount.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.minesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minesCount.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minesCount.ForeColor = System.Drawing.SystemColors.Menu;
            this.minesCount.Location = new System.Drawing.Point(75, 0);
            this.minesCount.Margin = new System.Windows.Forms.Padding(0);
            this.minesCount.MaximumSize = new System.Drawing.Size(75, 30);
            this.minesCount.Name = "minesCount";
            this.minesCount.Size = new System.Drawing.Size(75, 30);
            this.minesCount.TabIndex = 9;
            this.minesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTime
            // 
            this.gameTime.AutoSize = true;
            this.gameTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gameTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime.Location = new System.Drawing.Point(225, 0);
            this.gameTime.Margin = new System.Windows.Forms.Padding(0);
            this.gameTime.MaximumSize = new System.Drawing.Size(75, 30);
            this.gameTime.Name = "gameTime";
            this.gameTime.Size = new System.Drawing.Size(75, 30);
            this.gameTime.TabIndex = 10;
            this.gameTime.Text = "0";
            this.gameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.Transparent;
            this.field.ColumnCount = 1;
            this.field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.field.Location = new System.Drawing.Point(0, 30);
            this.field.Margin = new System.Windows.Forms.Padding(0);
            this.field.Name = "field";
            this.field.RowCount = 1;
            this.field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.field.Size = new System.Drawing.Size(300, 300);
            this.field.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 354);
            this.Controls.Add(this.allElements);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Minesweeper";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.allElements.ResumeLayout(false);
            this.allElements.PerformLayout();
            this.information.ResumeLayout(false);
            this.information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem gameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private TableLayoutPanel allElements;
        private TableLayoutPanel information;
        private Timer timer;
        private PictureBox minePicture;
        private TableLayoutPanel field;
        private Label minesCount;
        private Label gameTime;
        private PictureBox clockPicture;
    }
}

