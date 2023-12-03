using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChazovaSR.Sprint6.Task3.V20.Lib;
namespace Tyuiu.ChazovaSR.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {{ -14,17,-19,3,2},
                                           { -4,-14,19,-9,-1},
                                           { 1,0,13,14,8 },
                                           { 13,7,8,-3,-15 },
                                           { 2,-20,12,-14,4 }};

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСТНб-23-1 Чазова Софья Романовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_CSR_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            int [,] res_array = ds.Calculate(mtrx);
            dataGridViewMatrix_CSR.ColumnCount = columns;
            dataGridViewMatrix_CSR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_CSR.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_CSR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_CSR.ColumnCount = columns;
            dataGridViewMatrix_CSR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_CSR.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_CSR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
