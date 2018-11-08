using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace PresentationLogic
{
    public partial class PrimaryForm : Form
    {
        private BuisnessLogicIF currentBuisnessLogic;

        public PrimaryForm(BuisnessLogicIF buisnessLogic)
        {
            currentBuisnessLogic = buisnessLogic;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
