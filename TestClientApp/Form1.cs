using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using simplefishLib;
namespace TestClientApp
{
    public partial class Form1 : Form
    {
        simplefishLib.simlpcalc objSimpleObj = null;
        int _totalMarks = 0;

        public Form1()
        {
            InitializeComponent();
            objSimpleObj = new simplefishLib.simlpcalc();
            objSimpleObj.TotalMarks += objSimpleObj_TotalMarks;
        }
        void objSimpleObj_TotalMarks(int a_lTotalMarks)
        {
            _totalMarks = a_lTotalMarks;
            string txtMsg = string.Format(" {0} got  {1} Marks", txtboxName.Text, _totalMarks);
            MessageBox.Show(txtMsg);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            objSimpleObj.AtlMarks = int.Parse(textBoxATL.Text);
            objSimpleObj.ComMark = int.Parse(textBoxCOM.Text);

            bool fireEvent = chkFireEvent.Checked;
            _totalMarks = objSimpleObj.Calculate(fireEvent);

            textBoxResultName.Text = txtboxName.Text;
            textBoxResultMarks.Text = _totalMarks.ToString();

        }
    }
}
