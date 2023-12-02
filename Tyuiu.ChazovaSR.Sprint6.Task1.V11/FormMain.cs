using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChazovaSR.Sprint6.Task1.V11.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task1.V11
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
                int startValue = Convert.ToInt32(textBoxVarStart_CSR.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_CSR.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_CSR.Text = "";

                textBoxResult_CSR.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_CSR.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_CSR.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5}    |  {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_CSR.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_CSR.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИСТНб-23-1 Чазова Софья Романовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void textBoxVarA_CSR_KeyPress(object sender, KeyPressEventArgs e)
        //{

       // }
    }
}
