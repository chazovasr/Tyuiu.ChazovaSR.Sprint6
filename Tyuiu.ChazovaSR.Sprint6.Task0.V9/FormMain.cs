using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChazovaSR.Sprint6.Task0.V9.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

 

        private void buttonResult_CSR_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_CSR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA_CSR.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarA_CSR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <=47 || e.KeyChar >=58) && (e.KeyChar != ',') && (e.KeyChar !=8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСТНб-23-1 Чазова Софья Романовна","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
