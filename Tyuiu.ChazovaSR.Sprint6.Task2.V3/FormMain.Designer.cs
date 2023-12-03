
namespace Tyuiu.ChazovaSR.Sprint6.Task2.V3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonResult_CSR = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult_CSR = new System.Windows.Forms.Label();
            this.groupBoxVar_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxVarStop_CSR = new System.Windows.Forms.TextBox();
            this.labelVarStop_CSR = new System.Windows.Forms.Label();
            this.textBoxVarStart_CSR = new System.Windows.Forms.TextBox();
            this.labelVarStart_CSR = new System.Windows.Forms.Label();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.dataGridViewFunction_CSR = new System.Windows.Forms.DataGridView();
            this.chartFunction_CSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxVar_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_CSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult_CSR
            // 
            this.buttonResult_CSR.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonResult_CSR.Location = new System.Drawing.Point(18, 292);
            this.buttonResult_CSR.Name = "buttonResult_CSR";
            this.buttonResult_CSR.Size = new System.Drawing.Size(84, 35);
            this.buttonResult_CSR.TabIndex = 14;
            this.buttonResult_CSR.Text = "Выполнить";
            this.buttonResult_CSR.UseVisualStyleBackColor = false;
            this.buttonResult_CSR.Click += new System.EventHandler(this.buttonResult_CSR_Click);
            this.buttonResult_CSR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_CSR_MouseDown);
            this.buttonResult_CSR.MouseEnter += new System.EventHandler(this.buttonResult_CSR_MouseEnter);
            this.buttonResult_CSR.MouseLeave += new System.EventHandler(this.buttonResult_CSR_MouseLeave);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.chartFunction_CSR);
            this.groupBoxResult.Controls.Add(this.dataGridViewFunction_CSR);
            this.groupBoxResult.Controls.Add(this.labelResult_CSR);
            this.groupBoxResult.Location = new System.Drawing.Point(357, 17);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(510, 319);
            this.groupBoxResult.TabIndex = 13;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // labelResult_CSR
            // 
            this.labelResult_CSR.AutoSize = true;
            this.labelResult_CSR.Location = new System.Drawing.Point(13, 20);
            this.labelResult_CSR.Name = "labelResult_CSR";
            this.labelResult_CSR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_CSR.TabIndex = 0;
            this.labelResult_CSR.Text = "Результат:";
            // 
            // groupBoxVar_CSR
            // 
            this.groupBoxVar_CSR.Controls.Add(this.textBoxVarStop_CSR);
            this.groupBoxVar_CSR.Controls.Add(this.labelVarStop_CSR);
            this.groupBoxVar_CSR.Controls.Add(this.textBoxVarStart_CSR);
            this.groupBoxVar_CSR.Controls.Add(this.labelVarStart_CSR);
            this.groupBoxVar_CSR.Location = new System.Drawing.Point(12, 184);
            this.groupBoxVar_CSR.Name = "groupBoxVar_CSR";
            this.groupBoxVar_CSR.Size = new System.Drawing.Size(323, 102);
            this.groupBoxVar_CSR.TabIndex = 12;
            this.groupBoxVar_CSR.TabStop = false;
            this.groupBoxVar_CSR.Text = "Ввод данных";
            // 
            // textBoxVarStop_CSR
            // 
            this.textBoxVarStop_CSR.Location = new System.Drawing.Point(125, 74);
            this.textBoxVarStop_CSR.Name = "textBoxVarStop_CSR";
            this.textBoxVarStop_CSR.Size = new System.Drawing.Size(81, 20);
            this.textBoxVarStop_CSR.TabIndex = 5;
            // 
            // labelVarStop_CSR
            // 
            this.labelVarStop_CSR.AutoSize = true;
            this.labelVarStop_CSR.Location = new System.Drawing.Point(125, 41);
            this.labelVarStop_CSR.Name = "labelVarStop_CSR";
            this.labelVarStop_CSR.Size = new System.Drawing.Size(69, 13);
            this.labelVarStop_CSR.TabIndex = 4;
            this.labelVarStop_CSR.Text = "Конец шага:";
            // 
            // textBoxVarStart_CSR
            // 
            this.textBoxVarStart_CSR.Location = new System.Drawing.Point(6, 74);
            this.textBoxVarStart_CSR.Name = "textBoxVarStart_CSR";
            this.textBoxVarStart_CSR.Size = new System.Drawing.Size(81, 20);
            this.textBoxVarStart_CSR.TabIndex = 3;
            // 
            // labelVarStart_CSR
            // 
            this.labelVarStart_CSR.AutoSize = true;
            this.labelVarStart_CSR.Location = new System.Drawing.Point(6, 41);
            this.labelVarStart_CSR.Name = "labelVarStart_CSR";
            this.labelVarStart_CSR.Size = new System.Drawing.Size(67, 13);
            this.labelVarStart_CSR.TabIndex = 0;
            this.labelVarStart_CSR.Text = "Старт шага:";
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_CSR.Location = new System.Drawing.Point(134, 292);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(84, 34);
            this.buttonHelp_CSR.TabIndex = 11;
            this.buttonHelp_CSR.Text = "Справка";
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(323, 150);
            this.groupBoxTask_CSR.TabIndex = 10;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            // 
            // textBoxTask_CSR
            // 
            this.textBoxTask_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_CSR.Multiline = true;
            this.textBoxTask_CSR.Name = "textBoxTask_CSR";
            this.textBoxTask_CSR.ReadOnly = true;
            this.textBoxTask_CSR.Size = new System.Drawing.Size(298, 101);
            this.textBoxTask_CSR.TabIndex = 0;
            this.textBoxTask_CSR.Text = "Протабулировать функцию sin(x) / x +1.2 + cos(x) * 7*x - 2 на заданном диапазоне." +
    "\r\nРезультат вывести в виде DataGridView и построить график функции.";
            // 
            // dataGridViewFunction_CSR
            // 
            this.dataGridViewFunction_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_CSR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_CSR.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewFunction_CSR.Name = "dataGridViewFunction_CSR";
            this.dataGridViewFunction_CSR.RowHeadersVisible = false;
            this.dataGridViewFunction_CSR.Size = new System.Drawing.Size(105, 267);
            this.dataGridViewFunction_CSR.TabIndex = 1;
            // 
            // chartFunction_CSR
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_CSR.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction_CSR.Legends.Add(legend4);
            this.chartFunction_CSR.Location = new System.Drawing.Point(134, 65);
            this.chartFunction_CSR.Name = "chartFunction_CSR";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_CSR.Series.Add(series4);
            this.chartFunction_CSR.Size = new System.Drawing.Size(370, 204);
            this.chartFunction_CSR.TabIndex = 2;
            this.chartFunction_CSR.Text = "chart1";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 360);
            this.Controls.Add(this.buttonResult_CSR);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxVar_CSR);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Чазова С. Р.";
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxVar_CSR.ResumeLayout(false);
            this.groupBoxVar_CSR.PerformLayout();
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_CSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelResult_CSR;
        private System.Windows.Forms.GroupBox groupBoxVar_CSR;
        private System.Windows.Forms.TextBox textBoxVarStop_CSR;
        private System.Windows.Forms.Label labelVarStop_CSR;
        private System.Windows.Forms.TextBox textBoxVarStart_CSR;
        private System.Windows.Forms.Label labelVarStart_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CSR;
        private System.Windows.Forms.DataGridView dataGridViewFunction_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

