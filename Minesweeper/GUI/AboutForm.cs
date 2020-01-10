using System;
using System.Windows.Forms;

namespace Minesweeper
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
