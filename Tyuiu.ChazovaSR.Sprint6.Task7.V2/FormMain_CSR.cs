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
using Tyuiu.ChazovaSR.Sprint6.Task7.V2.Lib;

namespace Tyuiu.ChazovaSR.Sprint6.Task7.V2
{
    public partial class FormMain_CSR : Form
    {
        public FormMain_CSR()
        {
            InitializeComponent();

            openFileDialogTask_CSR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.* ";
            saveFileDialogMatrix_CSR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

         public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonInfo_CSR_Click(object sender, EventArgs e)
        {
            FormAbout_CSR formabout = new FormAbout_CSR();
            formabout.ShowDialog();
        }

        private void buttonOpenFile_CSR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CSR.ShowDialog();
            openFilePath = openFileDialogTask_CSR.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_CSR.RowCount = rows;
            dataGridViewInPut_CSR.ColumnCount = columns;
            dataGridViewOutPut_CSR.RowCount = rows;
            dataGridViewOutPut_CSR.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_CSR.Columns[i].Width = 35;
                dataGridViewOutPut_CSR.Columns[i].Width = 35;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_CSR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_CSR.Enabled = true;
        }

        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_CSR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_CSR.Enabled = true;
        }

        private void FormMain_CSR_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_CSR.RowCount = 50;
            dataGridViewOutPut_CSR.RowCount = 50;

            dataGridViewInPut_CSR.ColumnCount = 50;
            dataGridViewOutPut_CSR.ColumnCount = 50;

            panelLeft_CSR.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_CSR.Columns[i].Width = 25;
                dataGridViewOutPut_CSR.Columns[i].Width = 25;
            }
        }

        private void buttonSaveFile_CSR_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_CSR.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_CSR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_CSR.ShowDialog();

            string path = saveFileDialogMatrix_CSR.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_CSR.RowCount;
            int columns = dataGridViewOutPut_CSR.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInPut_CSR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInPut_CSR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_CSR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_CSR.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_CSR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_CSR.ToolTipTitle = " Выполнить";
        }

        private void buttonSaveFile_CSR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_CSR.ToolTipTitle = " Сохранить в файл";
        }

        private void buttonInfo_CSR_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_CSR.ToolTipTitle = " Справка";
        }
    }
}