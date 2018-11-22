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
        private DataProcessing _dataProcessing;
        public SaveDataForm(DataProcessing dataProcessing)
        {
            InitializeComponent();
            myDTOsaveData = new DTO_SaveData();
            _dataProcessing = dataProcessing;

        }

        private void SaveDataBT_Click(object sender, EventArgs e)
        {
            myDTOsaveData.fullName = fullNameTB.Text;
            myDTOsaveData.CPRnumber = cprTB.Text;
            myDTOsaveData.staffID = staffIDTB.Text;
            myDTOsaveData.date = DateTime.Now;

            _dataProcessing.Safe(myDTOsaveData);
        }
    }
}
