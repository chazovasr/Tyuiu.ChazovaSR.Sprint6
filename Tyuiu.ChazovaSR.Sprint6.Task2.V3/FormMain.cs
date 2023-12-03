using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChazovaSR.Sprint6.Task2.V3.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonResult_CSR_Click(object sender, EventArgs e)
        {

            try
            {

                int startStep = Convert.ToInt32(textBoxVarStart_CSR.Text);
                int stopStep = Convert.ToInt32(textBoxVarStop_CSR.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_CSR.Titles.Add("График функции F(x) = Sin(x) / x + 1.2 + Cos(x) * 7x - 2 ");
                this.chartFunction_CSR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_CSR.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_CSR.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_CSR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИСТНб-23-1 Чазова Софья Романовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_CSR_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_CSR.BackColor = Color.Red;
        }

        private void buttonResult_CSR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_CSR.BackColor = Color.Blue;
        }

        private void buttonResult_CSR_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_CSR.BackColor = Color.Green;
        }
    }
}

