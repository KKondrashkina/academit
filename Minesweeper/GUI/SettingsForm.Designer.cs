namespace Minesweeper.GUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.beginner = new System.Windows.Forms.RadioButton();
            this.amateur = new System.Windows.Forms.RadioButton();
            this.professional = new System.Windows.Forms.RadioButton();
            this.special = new System.Windows.Forms.RadioButton();
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.mines = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.minesLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginner
            // 
            this.beginner.AllowDrop = true;
            this.beginner.AutoSize = true;
            this.beginner.BackColor = System.Drawing.Color.Transparent;
            this.beginner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beginner.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.beginner.FlatAppearance.BorderSize = 6;
            this.beginner.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.beginner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.beginner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.beginner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginner.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginner.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.beginner.Location = new System.Drawing.Point(20, 10);
            this.beginner.Name = "beginner";
            this.beginner.Size = new System.Drawing.Size(74, 52);
            this.beginner.TabIndex = 0;
            this.beginner.TabStop = true;
            this.beginner.Text = "Beginner\r\n9 X 9 \r\n10 mines";
            this.beginner.UseVisualStyleBackColor = true;
            this.beginner.CheckedChanged += new System.EventHandler(this.Beginner_CheckedChanged);
            // 
            // amateur
            // 
            this.amateur.AutoSize = true;
            this.amateur.BackColor = System.Drawing.Color.Transparent;
            this.amateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amateur.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amateur.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.amateur.Location = new System.Drawing.Point(20, 60);
            this.amateur.Name = "amateur";
            this.amateur.Size = new System.Drawing.Size(71, 52);
            this.amateur.TabIndex = 1;
            this.amateur.TabStop = true;
            this.amateur.Text = "Amateur\r\n16 X 16\r\n40 mines";
            this.amateur.UseVisualStyleBackColor = true;
            this.amateur.CheckedChanged += new System.EventHandler(this.Amateur_CheckedChanged);
            // 
            // professional
            // 
            this.professional.AutoSize = true;
            this.professional.BackColor = System.Drawing.Color.Transparent;
            this.professional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professional.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.professional.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.professional.Location = new System.Drawing.Point(20, 110);
            this.professional.Name = "professional";
            this.professional.Size = new System.Drawing.Size(90, 52);
            this.professional.TabIndex = 2;
            this.professional.TabStop = true;
            this.professional.Text = "Professional\r\n16 X 30\r\n99 mines";
            this.professional.UseVisualStyleBackColor = true;
            this.professional.CheckedChanged += new System.EventHandler(this.Professional_CheckedChanged);
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.BackColor = System.Drawing.Color.Transparent;
            this.special.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.special.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.special.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.special.Location = new System.Drawing.Point(20, 170);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(97, 20);
            this.special.TabIndex = 3;
            this.special.TabStop = true;
            this.special.Text = "Special mode";
            this.special.UseVisualStyleBackColor = true;
            this.special.CheckedChanged += new System.EventHandler(this.Special_CheckedChanged);
            // 
            // height
            // 
            this.height.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.height.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.ForeColor = System.Drawing.SystemColors.Menu;
            this.height.Location = new System.Drawing.Point(110, 197);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 21);
            this.height.TabIndex = 4;
            this.height.Visible = false;
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_KeyPress);
            this.height.Leave += new System.EventHandler(this.Height_Leave);
            // 
            // width
            // 
            this.width.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.width.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width.ForeColor = System.Drawing.SystemColors.Menu;
            this.width.Location = new System.Drawing.Point(110, 222);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 21);
            this.width.TabIndex = 5;
            this.width.Visible = false;
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Width_KeyPress);
            this.width.Leave += new System.EventHandler(this.Width_Leave);
            // 
            // mines
            // 
            this.mines.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mines.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mines.ForeColor = System.Drawing.SystemColors.Menu;
            this.mines.Location = new System.Drawing.Point(110, 247);
            this.mines.Name = "mines";
            this.mines.Size = new System.Drawing.Size(100, 21);
            this.mines.TabIndex = 6;
            this.mines.Visible = false;
            this.mines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mines_KeyPress);
            this.mines.Leave += new System.EventHandler(this.Mines_Leave);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.BackColor = System.Drawing.Color.Transparent;
            this.heightLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.heightLabel.Location = new System.Drawing.Point(20, 200);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(80, 16);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height (9–24):";
            this.heightLabel.Visible = false;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.BackColor = System.Drawing.Color.Transparent;
            this.widthLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.widthLabel.Location = new System.Drawing.Point(20, 225);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(80, 16);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "Width (9–30): ";
            this.widthLabel.Visible = false;
            // 
            // minesLabel
            // 
            this.minesLabel.AutoSize = true;
            this.minesLabel.BackColor = System.Drawing.Color.Transparent;
            this.minesLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minesLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.minesLabel.Location = new System.Drawing.Point(20, 250);
            this.minesLabel.Name = "minesLabel";
            this.minesLabel.Size = new System.Drawing.Size(87, 16);
            this.minesLabel.TabIndex = 9;
            this.minesLabel.Text = "Mines (10–668):";
            this.minesLabel.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 999999999;
            this.toolTip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 999999999;
            this.toolTip2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ReshowDelay = 100;
            // 
            // toolTip3
            // 
            this.toolTip3.AutoPopDelay = 999999999;
            this.toolTip3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolTip3.InitialDelay = 500;
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ReshowDelay = 100;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ok.Location = new System.Drawing.Point(140, 280);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(70, 30);
            this.ok.TabIndex = 10;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(234, 322);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.minesLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.mines);
            this.Controls.Add(this.width);
            this.Controls.Add(this.height);
            this.Controls.Add(this.special);
            this.Controls.Add(this.professional);
            this.Controls.Add(this.amateur);
            this.Controls.Add(this.beginner);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 360);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton beginner;
        private System.Windows.Forms.RadioButton amateur;
        private System.Windows.Forms.RadioButton professional;
        private System.Windows.Forms.RadioButton special;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox mines;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label minesLabel;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}