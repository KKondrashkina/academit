namespace Minesweeper.GUI
{
    partial class NameForm
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
            this.allElements = new System.Windows.Forms.TableLayoutPanel();
            this.name = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.buttons = new System.Windows.Forms.TableLayoutPanel();
            this.ok = new System.Windows.Forms.Button();
            this.gameTime = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.allElements.SuspendLayout();
            this.buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // allElements
            // 
            this.allElements.BackColor = System.Drawing.Color.Transparent;
            this.allElements.ColumnCount = 1;
            this.allElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allElements.Controls.Add(this.name, 0, 2);
            this.allElements.Controls.Add(this.result, 0, 0);
            this.allElements.Controls.Add(this.buttons, 0, 3);
            this.allElements.Controls.Add(this.gameTime, 0, 1);
            this.allElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allElements.Location = new System.Drawing.Point(0, 0);
            this.allElements.Name = "allElements";
            this.allElements.RowCount = 4;
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.allElements.Size = new System.Drawing.Size(200, 158);
            this.allElements.TabIndex = 14;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.Menu;
            this.name.Location = new System.Drawing.Point(20, 79);
            this.name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(160, 25);
            this.name.TabIndex = 15;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.result.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.result.Location = new System.Drawing.Point(3, 10);
            this.result.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(194, 26);
            this.result.TabIndex = 2;
            this.result.Text = "New high score!\r\n";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttons
            // 
            this.buttons.ColumnCount = 2;
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons.Controls.Add(this.ok, 1, 0);
            this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons.Location = new System.Drawing.Point(0, 121);
            this.buttons.Margin = new System.Windows.Forms.Padding(0);
            this.buttons.Name = "buttons";
            this.buttons.RowCount = 1;
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons.Size = new System.Drawing.Size(200, 37);
            this.buttons.TabIndex = 13;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ok.Location = new System.Drawing.Point(110, 7);
            this.ok.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(80, 23);
            this.ok.TabIndex = 13;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // gameTime
            // 
            this.gameTime.AutoSize = true;
            this.gameTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTime.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTime.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gameTime.Location = new System.Drawing.Point(20, 51);
            this.gameTime.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.gameTime.Name = "gameTime";
            this.gameTime.Size = new System.Drawing.Size(160, 20);
            this.gameTime.TabIndex = 14;
            this.gameTime.Text = "Enter your name:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 999999999;
            this.toolTip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(200, 158);
            this.ControlBox = false;
            this.Controls.Add(this.allElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.allElements.ResumeLayout(false);
            this.allElements.PerformLayout();
            this.buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel allElements;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TableLayoutPanel buttons;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label gameTime;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}