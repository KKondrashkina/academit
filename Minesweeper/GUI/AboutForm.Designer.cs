namespace Minesweeper.GUI
{
    partial class AboutForm
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
            this.allElements = new System.Windows.Forms.TableLayoutPanel();
            this.about = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.allElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // allElements
            // 
            this.allElements.BackColor = System.Drawing.Color.Transparent;
            this.allElements.ColumnCount = 1;
            this.allElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allElements.Controls.Add(this.about, 0, 0);
            this.allElements.Controls.Add(this.ok, 0, 1);
            this.allElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allElements.Location = new System.Drawing.Point(0, 0);
            this.allElements.Name = "allElements";
            this.allElements.RowCount = 2;
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.allElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.allElements.Size = new System.Drawing.Size(204, 162);
            this.allElements.TabIndex = 14;
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.about.Location = new System.Drawing.Point(15, 20);
            this.about.Margin = new System.Windows.Forms.Padding(15, 20, 15, 10);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(174, 93);
            this.about.TabIndex = 15;
            this.about.Text = "Minesweeper by Kondrashkina Ekaterina Dmitrievna\r\n\r\nVersion: 1.0";
            // 
            // ok
            // 
            this.ok.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ok.Location = new System.Drawing.Point(114, 127);
            this.ok.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(80, 25);
            this.ok.TabIndex = 14;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(204, 162);
            this.Controls.Add(this.allElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.allElements.ResumeLayout(false);
            this.allElements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel allElements;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label about;
    }
}