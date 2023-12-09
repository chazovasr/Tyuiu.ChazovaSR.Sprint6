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
using Tyuiu.ChazovaSR.Sprint6.Task5.V18.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task5.V18
{
    public partial class FormMain_CSR : Form
    {
        public FormMain_CSR()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint6\Tyuiu.ChazovaSR.Sprint6.Task5.V18\bin\Debug\InPutDataFileTask5V18.txt";


        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСТНб-23-1 Чазова Софья Романовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_CSR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonResult_CSR_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonResult_CSR_Click_1(object sender, EventArgs e)
        {
            dataGridViewResult_CSR.ColumnCount = 2;
            dataGridViewResult_CSR.Columns[0].Width = 30;
            dataGridViewResult_CSR.Columns[1].Width = 50;
            this.chartResult_CSR.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_CSR.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_CSR.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_CSR.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_CSR.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonResult_CSR_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonResult_CSR_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

    }
}
