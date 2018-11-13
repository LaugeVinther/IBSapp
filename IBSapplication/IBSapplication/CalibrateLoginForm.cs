using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace PresentationLogic
{
    public partial class CalibrateLoginForm : Form
    {
        private CalibrateForm calibrateForm_;
        private CalibrateLogin calibrateLoginRef_;

        public CalibrateLoginForm()
        {
        }

        public CalibrateLoginForm(CalibrateLogin calibrateLoginRef, CalibrateForm calibrateForm)
        {
            InitializeComponent();
            calibrateForm_ = calibrateForm;
            calibrateLoginRef_ = calibrateLoginRef;
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            if (calibrateLoginRef_.CheckLogin(UsernameTB.Text, PasswordTB.Text) == true)
            {
                calibrateForm_.LoginOK_ = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid login entered. Please try again");
                calibrateForm_.Visible = false;
            }
        }
    }
}
