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
using DTOLogic;
namespace PresentationLogic
{
    public partial class SaveDataForm : Form
    {
        private DTO_SaveData myDTOsaveData;
        private DataCalculation _dataCalculation;

        public SaveDataForm(DataCalculation dataCalculation)
        {
            InitializeComponent();
            myDTOsaveData = new DTO_SaveData();
            _dataCalculation = dataCalculation;

        }

        private void SaveDataBT_Click(object sender, EventArgs e)
        {
            if (fullNameTB.Text == "" || cprTB.Text == "" || staffIDTB.Text == "")
            {
                MessageBox.Show("Please fill out all required fields", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                myDTOsaveData.fullName = fullNameTB.Text;
                myDTOsaveData.CPRnumber = cprTB.Text;
                myDTOsaveData.staffID = staffIDTB.Text;
                myDTOsaveData.date = DateTime.Now;

                _dataCalculation.Safe(myDTOsaveData);

                DialogResult result = MessageBox.Show("Your data has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
            }
        }
    }
}
