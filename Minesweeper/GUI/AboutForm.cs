using System;
using System.Windows.Forms;

namespace Minesweeper.GUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
