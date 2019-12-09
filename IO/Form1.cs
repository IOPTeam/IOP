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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpenLoginWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            TextBoxInsertNumber_Leave(sender, e);
            labelStatus.Text = "";
        }

        private void TextBoxInsertNumber_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxInsertNumber.Text))
            {
                textBoxInsertNumber.ForeColor = Color.Gray;
                textBoxInsertNumber.Text = "Wpisz numer przesyłki";
            }
            else
            {
                textBoxInsertNumber.ForeColor = Color.Black;
            }
        }

        private void TextBoxInsertNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxInsertNumber.Text == "Wpisz numer przesyłki")
            {
                textBoxInsertNumber.Text = "";
                textBoxInsertNumber.ForeColor = Color.Black;
            }
        }

        private void ButtonCheckStatus_Click(object sender, EventArgs e) // TO DO
        {
            try
            {
                if (!(textBoxInsertNumber.Text == "") && !(textBoxInsertNumber.Text == "Wpisz numer przesyłki"))
                {
                    //labelStatus.Text = PackageController::GetPackageStatusByID(textBoxInsertNumber.Text);
                    
                    // for testing
                    labelStatus.Text = textBoxInsertNumber.Text;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }        
        }  
    }     
}
