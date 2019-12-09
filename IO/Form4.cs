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
    public partial class CourierWindow : Form
    {
        public CourierWindow()
        {
            InitializeComponent();
        }

        private void CourierWindow_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            // close choice window
            // show main window
        }
    }
}
