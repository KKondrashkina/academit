using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            Result.Text = Controller.ChangeValue(Value.Text, UOM1.Text, UOM2.Text);
        }

        private void UOM1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = Controller.ChangeValue(Value.Text, UOM1.Text, UOM2.Text);
        }

        private void UOM2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = Controller.ChangeValue(Value.Text, UOM1.Text, UOM2.Text);
        }
    }
}
