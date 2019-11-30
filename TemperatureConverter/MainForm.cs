using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class MainForm : Form
    {
        Controller controller = new Controller();

        public MainForm()
        {
            InitializeComponent();

            UOM1.Items.AddRange(controller.UOMsList);
            UOM2.Items.AddRange(controller.UOMsList);
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            Result.Text = controller.ChangeValue(Value.Text, UOM1.Text, UOM2.Text);
        }

        private void UOM1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = controller.ChangeValue(Value.Text, UOM1.Text, UOM2.Text);
        }

        private void UOM2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = controller.ChangeValue(Value.Text, UOM1.Text, UOM2.Text);
        }
    }
}
