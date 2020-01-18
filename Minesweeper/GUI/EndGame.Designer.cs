namespace Minesweeper.GUI
{
    partial class EndGame
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
            this.result = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.allElements = new System.Windows.Forms.TableLayoutPanel();
            this.buttons = new System.Windows.Forms.TableLayoutPanel();
            this.newGame = new System.Windows.Forms.Button();
            this.gameTime = new System.Windows.Forms.Label();
            this.allElements.SuspendLayout();
            this.buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.result.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.result.Location = new System.Drawing.Point(3, 10);
            this.result.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(198, 37);
            this.result.TabIndex = 2;
            this.result.Text = "You lose!\r\n";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit.Location = new System.Drawing.Point(10, 7);
            this.exit.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 31);
            this.exit.TabIndex = 12;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // allElements
            // 
            this.allElements.BackColor = System.Drawing.Color.Transparent;
            this.allElements.ColumnCount = 1;
            this.allElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allElements.Controls.Add(this.result, 0, 0);
            this.allElements.Controls.Add(this.buttons, 0, 2);
            this.allElements.Controls.Add(this.gameTime, 0, 1);
            this.allElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allElements.Location = new System.Drawing.Point(0, 0);
            this.allElements.Name = "allElements";
            this.allElements.RowCount = 3;
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.allElements.Size = new System.Drawing.Size(204, 162);
            this.allElements.TabIndex = 13;
            // 
            // buttons
            // 
            this.buttons.ColumnCount = 2;
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons.Controls.Add(this.exit, 0, 0);
            this.buttons.Controls.Add(this.newGame, 1, 0);
            this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons.Location = new System.Drawing.Point(0, 117);
            this.buttons.Margin = new System.Windows.Forms.Padding(0);
            this.buttons.Name = "buttons";
            this.buttons.RowCount = 1;
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons.Size = new System.Drawing.Size(204, 45);
            this.buttons.TabIndex = 13;
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.newGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGame.FlatAppearance.BorderSize = 0;
            this.newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGame.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newGame.Location = new System.Drawing.Point(112, 7);
            this.newGame.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(82, 31);
            this.newGame.TabIndex = 13;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // gameTime
            // 
            this.gameTime.AutoSize = true;
            this.gameTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gameTime.Location = new System.Drawing.Point(10, 57);
            this.gameTime.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gameTime.Name = "gameTime";
            this.gameTime.Size = new System.Drawing.Size(184, 60);
            this.gameTime.TabIndex = 14;
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(204, 162);
            this.Controls.Add(this.allElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EndGame_FormClosed);
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.allElements.ResumeLayout(false);
            this.allElements.PerformLayout();
            this.buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TableLayoutPanel allElements;
        private System.Windows.Forms.TableLayoutPanel buttons;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Label gameTime;
    }
}