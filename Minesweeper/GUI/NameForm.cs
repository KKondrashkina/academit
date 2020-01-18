using System;
using System.Windows.Forms;

namespace Minesweeper.GUI
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        public string GetName()
        {
            ShowDialog();

            return DialogResult == DialogResult.OK ? name.Text : "";
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                toolTip1.Show("Enter your name!", name, 10000);
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
