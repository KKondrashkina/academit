namespace Minesweeper.GUI
{
    partial class HighScoresForm
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
            this.amateur = new System.Windows.Forms.RadioButton();
            this.professional = new System.Windows.Forms.RadioButton();
            this.beginner = new System.Windows.Forms.RadioButton();
            this.levels = new System.Windows.Forms.TableLayoutPanel();
            this.allElements = new System.Windows.Forms.TableLayoutPanel();
            this.highScoresTable = new System.Windows.Forms.TableLayoutPanel();
            this.date9 = new System.Windows.Forms.Label();
            this.gameTime6 = new System.Windows.Forms.Label();
            this.gameTime5 = new System.Windows.Forms.Label();
            this.gameTime9 = new System.Windows.Forms.Label();
            this.gameTime4 = new System.Windows.Forms.Label();
            this.gameTime8 = new System.Windows.Forms.Label();
            this.gameTime3 = new System.Windows.Forms.Label();
            this.gameTime7 = new System.Windows.Forms.Label();
            this.gameTime2 = new System.Windows.Forms.Label();
            this.gameTime1 = new System.Windows.Forms.Label();
            this.gameTime0 = new System.Windows.Forms.Label();
            this.third = new System.Windows.Forms.PictureBox();
            this.second = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.PictureBox();
            this.name0 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.name4 = new System.Windows.Forms.Label();
            this.name5 = new System.Windows.Forms.Label();
            this.name6 = new System.Windows.Forms.Label();
            this.name7 = new System.Windows.Forms.Label();
            this.name8 = new System.Windows.Forms.Label();
            this.name9 = new System.Windows.Forms.Label();
            this.date7 = new System.Windows.Forms.Label();
            this.date6 = new System.Windows.Forms.Label();
            this.date5 = new System.Windows.Forms.Label();
            this.date8 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date0 = new System.Windows.Forms.Label();
            this.levels.SuspendLayout();
            this.allElements.SuspendLayout();
            this.highScoresTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.third)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first)).BeginInit();
            this.SuspendLayout();
            // 
            // amateur
            // 
            this.amateur.Appearance = System.Windows.Forms.Appearance.Button;
            this.amateur.AutoSize = true;
            this.amateur.BackColor = System.Drawing.Color.Transparent;
            this.amateur.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.amateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amateur.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amateur.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.amateur.Location = new System.Drawing.Point(101, 0);
            this.amateur.Margin = new System.Windows.Forms.Padding(0);
            this.amateur.Name = "amateur";
            this.amateur.Size = new System.Drawing.Size(101, 32);
            this.amateur.TabIndex = 2;
            this.amateur.TabStop = true;
            this.amateur.Text = "Amateur";
            this.amateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.amateur.UseVisualStyleBackColor = true;
            this.amateur.CheckedChanged += new System.EventHandler(this.Amateur_CheckedChanged);
            // 
            // professional
            // 
            this.professional.Appearance = System.Windows.Forms.Appearance.Button;
            this.professional.AutoSize = true;
            this.professional.BackColor = System.Drawing.Color.Transparent;
            this.professional.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.professional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professional.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.professional.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.professional.Location = new System.Drawing.Point(202, 0);
            this.professional.Margin = new System.Windows.Forms.Padding(0);
            this.professional.Name = "professional";
            this.professional.Size = new System.Drawing.Size(102, 32);
            this.professional.TabIndex = 3;
            this.professional.TabStop = true;
            this.professional.Text = "Professional";
            this.professional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.professional.UseVisualStyleBackColor = true;
            this.professional.CheckedChanged += new System.EventHandler(this.Professional_CheckedChanged);
            // 
            // beginner
            // 
            this.beginner.Appearance = System.Windows.Forms.Appearance.Button;
            this.beginner.AutoSize = true;
            this.beginner.BackColor = System.Drawing.Color.Transparent;
            this.beginner.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.beginner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beginner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginner.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.beginner.Location = new System.Drawing.Point(0, 0);
            this.beginner.Margin = new System.Windows.Forms.Padding(0);
            this.beginner.Name = "beginner";
            this.beginner.Size = new System.Drawing.Size(101, 32);
            this.beginner.TabIndex = 4;
            this.beginner.TabStop = true;
            this.beginner.Text = "Beginner";
            this.beginner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.beginner.UseVisualStyleBackColor = false;
            this.beginner.CheckedChanged += new System.EventHandler(this.Beginner_CheckedChanged);
            // 
            // levels
            // 
            this.levels.BackColor = System.Drawing.Color.Transparent;
            this.levels.ColumnCount = 3;
            this.levels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.levels.Controls.Add(this.beginner, 0, 0);
            this.levels.Controls.Add(this.professional, 2, 0);
            this.levels.Controls.Add(this.amateur, 1, 0);
            this.levels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levels.Location = new System.Drawing.Point(0, 0);
            this.levels.Margin = new System.Windows.Forms.Padding(0);
            this.levels.Name = "levels";
            this.levels.RowCount = 1;
            this.levels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.levels.Size = new System.Drawing.Size(304, 32);
            this.levels.TabIndex = 5;
            // 
            // allElements
            // 
            this.allElements.BackColor = System.Drawing.Color.Transparent;
            this.allElements.ColumnCount = 1;
            this.allElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allElements.Controls.Add(this.levels, 0, 0);
            this.allElements.Controls.Add(this.highScoresTable, 0, 1);
            this.allElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allElements.Location = new System.Drawing.Point(0, 0);
            this.allElements.Margin = new System.Windows.Forms.Padding(0);
            this.allElements.Name = "allElements";
            this.allElements.RowCount = 2;
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.allElements.Size = new System.Drawing.Size(304, 322);
            this.allElements.TabIndex = 6;
            // 
            // highScoresTable
            // 
            this.highScoresTable.ColumnCount = 5;
            this.highScoresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.highScoresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.highScoresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.highScoresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.highScoresTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.highScoresTable.Controls.Add(this.date9, 4, 9);
            this.highScoresTable.Controls.Add(this.gameTime6, 3, 6);
            this.highScoresTable.Controls.Add(this.gameTime5, 3, 5);
            this.highScoresTable.Controls.Add(this.gameTime9, 3, 9);
            this.highScoresTable.Controls.Add(this.gameTime4, 3, 4);
            this.highScoresTable.Controls.Add(this.gameTime8, 3, 8);
            this.highScoresTable.Controls.Add(this.gameTime3, 3, 3);
            this.highScoresTable.Controls.Add(this.gameTime7, 3, 7);
            this.highScoresTable.Controls.Add(this.gameTime2, 3, 2);
            this.highScoresTable.Controls.Add(this.gameTime1, 3, 1);
            this.highScoresTable.Controls.Add(this.gameTime0, 3, 0);
            this.highScoresTable.Controls.Add(this.third, 0, 2);
            this.highScoresTable.Controls.Add(this.second, 0, 1);
            this.highScoresTable.Controls.Add(this.label10, 1, 3);
            this.highScoresTable.Controls.Add(this.label9, 1, 8);
            this.highScoresTable.Controls.Add(this.label8, 1, 7);
            this.highScoresTable.Controls.Add(this.label7, 1, 6);
            this.highScoresTable.Controls.Add(this.label6, 1, 9);
            this.highScoresTable.Controls.Add(this.label5, 1, 4);
            this.highScoresTable.Controls.Add(this.label4, 1, 5);
            this.highScoresTable.Controls.Add(this.label3, 1, 2);
            this.highScoresTable.Controls.Add(this.label2, 1, 1);
            this.highScoresTable.Controls.Add(this.label1, 1, 0);
            this.highScoresTable.Controls.Add(this.first, 0, 0);
            this.highScoresTable.Controls.Add(this.name0, 2, 0);
            this.highScoresTable.Controls.Add(this.name1, 2, 1);
            this.highScoresTable.Controls.Add(this.name2, 2, 2);
            this.highScoresTable.Controls.Add(this.name3, 2, 3);
            this.highScoresTable.Controls.Add(this.name4, 2, 4);
            this.highScoresTable.Controls.Add(this.name5, 2, 5);
            this.highScoresTable.Controls.Add(this.name6, 2, 6);
            this.highScoresTable.Controls.Add(this.name7, 2, 7);
            this.highScoresTable.Controls.Add(this.name8, 2, 8);
            this.highScoresTable.Controls.Add(this.name9, 2, 9);
            this.highScoresTable.Controls.Add(this.date7, 4, 7);
            this.highScoresTable.Controls.Add(this.date6, 4, 6);
            this.highScoresTable.Controls.Add(this.date5, 4, 5);
            this.highScoresTable.Controls.Add(this.date8, 4, 8);
            this.highScoresTable.Controls.Add(this.date4, 4, 4);
            this.highScoresTable.Controls.Add(this.date3, 4, 3);
            this.highScoresTable.Controls.Add(this.date2, 4, 2);
            this.highScoresTable.Controls.Add(this.date1, 4, 1);
            this.highScoresTable.Controls.Add(this.date0, 4, 0);
            this.highScoresTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highScoresTable.Location = new System.Drawing.Point(15, 32);
            this.highScoresTable.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.highScoresTable.Name = "highScoresTable";
            this.highScoresTable.RowCount = 10;
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.highScoresTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.highScoresTable.Size = new System.Drawing.Size(274, 294);
            this.highScoresTable.TabIndex = 6;
            // 
            // date9
            // 
            this.date9.AutoSize = true;
            this.date9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date9.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date9.ForeColor = System.Drawing.SystemColors.Menu;
            this.date9.Location = new System.Drawing.Point(202, 261);
            this.date9.Name = "date9";
            this.date9.Size = new System.Drawing.Size(69, 33);
            this.date9.TabIndex = 33;
            this.date9.Text = "—";
            this.date9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime6
            // 
            this.gameTime6.AutoSize = true;
            this.gameTime6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime6.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime6.Location = new System.Drawing.Point(133, 174);
            this.gameTime6.Name = "gameTime6";
            this.gameTime6.Size = new System.Drawing.Size(63, 29);
            this.gameTime6.TabIndex = 32;
            this.gameTime6.Text = "—";
            this.gameTime6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime5
            // 
            this.gameTime5.AutoSize = true;
            this.gameTime5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime5.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime5.Location = new System.Drawing.Point(133, 145);
            this.gameTime5.Name = "gameTime5";
            this.gameTime5.Size = new System.Drawing.Size(63, 29);
            this.gameTime5.TabIndex = 31;
            this.gameTime5.Text = "—";
            this.gameTime5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime9
            // 
            this.gameTime9.AutoSize = true;
            this.gameTime9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime9.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime9.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime9.Location = new System.Drawing.Point(133, 261);
            this.gameTime9.Name = "gameTime9";
            this.gameTime9.Size = new System.Drawing.Size(63, 33);
            this.gameTime9.TabIndex = 30;
            this.gameTime9.Text = "—";
            this.gameTime9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime4
            // 
            this.gameTime4.AutoSize = true;
            this.gameTime4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime4.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime4.Location = new System.Drawing.Point(133, 116);
            this.gameTime4.Name = "gameTime4";
            this.gameTime4.Size = new System.Drawing.Size(63, 29);
            this.gameTime4.TabIndex = 29;
            this.gameTime4.Text = "—";
            this.gameTime4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime8
            // 
            this.gameTime8.AutoSize = true;
            this.gameTime8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime8.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime8.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime8.Location = new System.Drawing.Point(133, 232);
            this.gameTime8.Name = "gameTime8";
            this.gameTime8.Size = new System.Drawing.Size(63, 29);
            this.gameTime8.TabIndex = 28;
            this.gameTime8.Text = "—";
            this.gameTime8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime3
            // 
            this.gameTime3.AutoSize = true;
            this.gameTime3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime3.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime3.Location = new System.Drawing.Point(133, 87);
            this.gameTime3.Name = "gameTime3";
            this.gameTime3.Size = new System.Drawing.Size(63, 29);
            this.gameTime3.TabIndex = 27;
            this.gameTime3.Text = "—";
            this.gameTime3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime7
            // 
            this.gameTime7.AutoSize = true;
            this.gameTime7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime7.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime7.Location = new System.Drawing.Point(133, 203);
            this.gameTime7.Name = "gameTime7";
            this.gameTime7.Size = new System.Drawing.Size(63, 29);
            this.gameTime7.TabIndex = 26;
            this.gameTime7.Text = "—";
            this.gameTime7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime2
            // 
            this.gameTime2.AutoSize = true;
            this.gameTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime2.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime2.Location = new System.Drawing.Point(133, 58);
            this.gameTime2.Name = "gameTime2";
            this.gameTime2.Size = new System.Drawing.Size(63, 29);
            this.gameTime2.TabIndex = 25;
            this.gameTime2.Text = "—";
            this.gameTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime1
            // 
            this.gameTime1.AutoSize = true;
            this.gameTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime1.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime1.Location = new System.Drawing.Point(133, 29);
            this.gameTime1.Name = "gameTime1";
            this.gameTime1.Size = new System.Drawing.Size(63, 29);
            this.gameTime1.TabIndex = 24;
            this.gameTime1.Text = "—";
            this.gameTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTime0
            // 
            this.gameTime0.AutoSize = true;
            this.gameTime0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime0.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime0.ForeColor = System.Drawing.SystemColors.Menu;
            this.gameTime0.Location = new System.Drawing.Point(133, 0);
            this.gameTime0.Name = "gameTime0";
            this.gameTime0.Size = new System.Drawing.Size(63, 29);
            this.gameTime0.TabIndex = 23;
            this.gameTime0.Text = "—";
            this.gameTime0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // third
            // 
            this.third.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.third.Dock = System.Windows.Forms.DockStyle.Fill;
            this.third.Image = global::Minesweeper.Properties.Resources.Bronze;
            this.third.Location = new System.Drawing.Point(4, 62);
            this.third.Margin = new System.Windows.Forms.Padding(4);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(18, 21);
            this.third.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.third.TabIndex = 12;
            this.third.TabStop = false;
            // 
            // second
            // 
            this.second.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.second.Dock = System.Windows.Forms.DockStyle.Fill;
            this.second.Image = global::Minesweeper.Properties.Resources.Silver;
            this.second.Location = new System.Drawing.Point(4, 33);
            this.second.Margin = new System.Windows.Forms.Padding(4);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(18, 21);
            this.second.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.second.TabIndex = 11;
            this.second.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Menu;
            this.label10.Location = new System.Drawing.Point(26, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Menu;
            this.label9.Location = new System.Drawing.Point(26, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(26, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(26, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(26, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "10";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(26, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(26, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "6";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // first
            // 
            this.first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.first.Dock = System.Windows.Forms.DockStyle.Fill;
            this.first.Image = global::Minesweeper.Properties.Resources.Gold;
            this.first.Location = new System.Drawing.Point(4, 4);
            this.first.Margin = new System.Windows.Forms.Padding(4);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(18, 21);
            this.first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.first.TabIndex = 10;
            this.first.TabStop = false;
            // 
            // name0
            // 
            this.name0.AutoSize = true;
            this.name0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name0.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name0.ForeColor = System.Drawing.SystemColors.Menu;
            this.name0.Location = new System.Drawing.Point(53, 0);
            this.name0.Name = "name0";
            this.name0.Size = new System.Drawing.Size(74, 29);
            this.name0.TabIndex = 13;
            this.name0.Text = "—";
            this.name0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name1.ForeColor = System.Drawing.SystemColors.Menu;
            this.name1.Location = new System.Drawing.Point(53, 29);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(74, 29);
            this.name1.TabIndex = 14;
            this.name1.Text = "—";
            this.name1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name2.ForeColor = System.Drawing.SystemColors.Menu;
            this.name2.Location = new System.Drawing.Point(53, 58);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(74, 29);
            this.name2.TabIndex = 15;
            this.name2.Text = "—";
            this.name2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name3.ForeColor = System.Drawing.SystemColors.Menu;
            this.name3.Location = new System.Drawing.Point(53, 87);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(74, 29);
            this.name3.TabIndex = 16;
            this.name3.Text = "—";
            this.name3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name4
            // 
            this.name4.AutoSize = true;
            this.name4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name4.ForeColor = System.Drawing.SystemColors.Menu;
            this.name4.Location = new System.Drawing.Point(53, 116);
            this.name4.Name = "name4";
            this.name4.Size = new System.Drawing.Size(74, 29);
            this.name4.TabIndex = 17;
            this.name4.Text = "—";
            this.name4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name5
            // 
            this.name5.AutoSize = true;
            this.name5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name5.ForeColor = System.Drawing.SystemColors.Menu;
            this.name5.Location = new System.Drawing.Point(53, 145);
            this.name5.Name = "name5";
            this.name5.Size = new System.Drawing.Size(74, 29);
            this.name5.TabIndex = 18;
            this.name5.Text = "—";
            this.name5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name6
            // 
            this.name6.AutoSize = true;
            this.name6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name6.ForeColor = System.Drawing.SystemColors.Menu;
            this.name6.Location = new System.Drawing.Point(53, 174);
            this.name6.Name = "name6";
            this.name6.Size = new System.Drawing.Size(74, 29);
            this.name6.TabIndex = 19;
            this.name6.Text = "—";
            this.name6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name7
            // 
            this.name7.AutoSize = true;
            this.name7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name7.ForeColor = System.Drawing.SystemColors.Menu;
            this.name7.Location = new System.Drawing.Point(53, 203);
            this.name7.Name = "name7";
            this.name7.Size = new System.Drawing.Size(74, 29);
            this.name7.TabIndex = 20;
            this.name7.Text = "—";
            this.name7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name8
            // 
            this.name8.AutoSize = true;
            this.name8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name8.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name8.ForeColor = System.Drawing.SystemColors.Menu;
            this.name8.Location = new System.Drawing.Point(53, 232);
            this.name8.Name = "name8";
            this.name8.Size = new System.Drawing.Size(74, 29);
            this.name8.TabIndex = 21;
            this.name8.Text = "—";
            this.name8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name9
            // 
            this.name9.AutoSize = true;
            this.name9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name9.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name9.ForeColor = System.Drawing.SystemColors.Menu;
            this.name9.Location = new System.Drawing.Point(53, 261);
            this.name9.Name = "name9";
            this.name9.Size = new System.Drawing.Size(74, 33);
            this.name9.TabIndex = 22;
            this.name9.Text = "—";
            this.name9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date7
            // 
            this.date7.AutoSize = true;
            this.date7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date7.ForeColor = System.Drawing.SystemColors.Menu;
            this.date7.Location = new System.Drawing.Point(202, 203);
            this.date7.Name = "date7";
            this.date7.Size = new System.Drawing.Size(69, 29);
            this.date7.TabIndex = 34;
            this.date7.Text = "—";
            this.date7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date6
            // 
            this.date6.AutoSize = true;
            this.date6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date6.ForeColor = System.Drawing.SystemColors.Menu;
            this.date6.Location = new System.Drawing.Point(202, 174);
            this.date6.Name = "date6";
            this.date6.Size = new System.Drawing.Size(69, 29);
            this.date6.TabIndex = 35;
            this.date6.Text = "—";
            this.date6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date5
            // 
            this.date5.AutoSize = true;
            this.date5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date5.ForeColor = System.Drawing.SystemColors.Menu;
            this.date5.Location = new System.Drawing.Point(202, 145);
            this.date5.Name = "date5";
            this.date5.Size = new System.Drawing.Size(69, 29);
            this.date5.TabIndex = 36;
            this.date5.Text = "—";
            this.date5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date8
            // 
            this.date8.AutoSize = true;
            this.date8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date8.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date8.ForeColor = System.Drawing.SystemColors.Menu;
            this.date8.Location = new System.Drawing.Point(202, 232);
            this.date8.Name = "date8";
            this.date8.Size = new System.Drawing.Size(69, 29);
            this.date8.TabIndex = 37;
            this.date8.Text = "—";
            this.date8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date4
            // 
            this.date4.AutoSize = true;
            this.date4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date4.ForeColor = System.Drawing.SystemColors.Menu;
            this.date4.Location = new System.Drawing.Point(202, 116);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(69, 29);
            this.date4.TabIndex = 38;
            this.date4.Text = "—";
            this.date4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date3.ForeColor = System.Drawing.SystemColors.Menu;
            this.date3.Location = new System.Drawing.Point(202, 87);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(69, 29);
            this.date3.TabIndex = 39;
            this.date3.Text = "—";
            this.date3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date2.ForeColor = System.Drawing.SystemColors.Menu;
            this.date2.Location = new System.Drawing.Point(202, 58);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(69, 29);
            this.date2.TabIndex = 40;
            this.date2.Text = "—";
            this.date2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date1.ForeColor = System.Drawing.SystemColors.Menu;
            this.date1.Location = new System.Drawing.Point(202, 29);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(69, 29);
            this.date1.TabIndex = 41;
            this.date1.Text = "—";
            this.date1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date0
            // 
            this.date0.AutoSize = true;
            this.date0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date0.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date0.ForeColor = System.Drawing.SystemColors.Menu;
            this.date0.Location = new System.Drawing.Point(202, 0);
            this.date0.Name = "date0";
            this.date0.Size = new System.Drawing.Size(69, 29);
            this.date0.TabIndex = 42;
            this.date0.Text = "—";
            this.date0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(304, 322);
            this.Controls.Add(this.allElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScoresForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistics";
            this.levels.ResumeLayout(false);
            this.levels.PerformLayout();
            this.allElements.ResumeLayout(false);
            this.highScoresTable.ResumeLayout(false);
            this.highScoresTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.third)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton amateur;
        private System.Windows.Forms.RadioButton professional;
        private System.Windows.Forms.RadioButton beginner;
        private System.Windows.Forms.TableLayoutPanel levels;
        private System.Windows.Forms.TableLayoutPanel allElements;
        private System.Windows.Forms.TableLayoutPanel highScoresTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox first;
        private System.Windows.Forms.PictureBox third;
        private System.Windows.Forms.PictureBox second;
        private System.Windows.Forms.Label name0;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.Label name4;
        private System.Windows.Forms.Label name5;
        private System.Windows.Forms.Label name6;
        private System.Windows.Forms.Label name7;
        private System.Windows.Forms.Label name8;
        private System.Windows.Forms.Label name9;
        private System.Windows.Forms.Label gameTime6;
        private System.Windows.Forms.Label gameTime5;
        private System.Windows.Forms.Label gameTime9;
        private System.Windows.Forms.Label gameTime4;
        private System.Windows.Forms.Label gameTime8;
        private System.Windows.Forms.Label gameTime3;
        private System.Windows.Forms.Label gameTime7;
        private System.Windows.Forms.Label gameTime2;
        private System.Windows.Forms.Label gameTime1;
        private System.Windows.Forms.Label gameTime0;
        private System.Windows.Forms.Label date9;
        private System.Windows.Forms.Label date7;
        private System.Windows.Forms.Label date6;
        private System.Windows.Forms.Label date5;
        private System.Windows.Forms.Label date8;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date0;
    }
}