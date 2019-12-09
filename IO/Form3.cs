using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO
{
    public partial class ModuleChoiceWindow : Form
    {
        public ModuleChoiceWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpenPostingWindow_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpenWarehouseWindow_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpenLogisticsWindow_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpenCourierWindow_Click(object sender, EventArgs e)
        {
            CourierWindow courierWindow = new CourierWindow();
            courierWindow.ShowDialog();
        }

        private void ModuleChoiceWindow_Load(object sender, EventArgs e)
        {
            // enable buttons
        }
    }
}
