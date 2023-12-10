using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ChazovaSR.Sprint6.Task6.V20.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task6.V20
{
    public partial class FormMain_CSR : Form
    {
        public FormMain_CSR()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            buttonDone_CSR.Enabled = false;
            buttonOpenFile_CSR.Enabled = true;
            textBoxResult_CSR.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFile_CSR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CSR.ShowDialog();
            openFilePath = openFileDialogTask_CSR.FileName;
            textBoxInput_CSR.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_CSR.Text = groupBoxOutPut_CSR.Text + " " + openFileDialogTask_CSR.FileName; ;
            buttonDone_CSR.Enabled = true;
            buttonOpenFile_CSR.Enabled = false;

        }

        private void buttonInfo_CSR_Click(object sender, EventArgs e)
        {
            FormAbout_CSR formabout = new FormAbout_CSR();
            formabout.ShowDialog();
        }

     
    }
}
