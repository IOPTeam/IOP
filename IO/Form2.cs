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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e) // TO DO
        {
            try
            {
                if (!(textBoxUsername.Text == ""))
                {
                    if (!(textBoxPassword.Text == ""))
                    {
                        //if(EmployeeController::Login(textBoxUsername.Text, textBoxPassword.Text))
                        {
                            this.Close();
                            ModuleChoiceWindow choiceWindow = new ModuleChoiceWindow();
                            choiceWindow.ShowDialog();
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Nie podano hasła", "Błąd logowania", 0, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nie podano loginu", "Błąd logowania", 0, MessageBoxIcon.Error);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // show MainWindow
        }
    }
}
