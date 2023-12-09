
namespace Tyuiu.ChazovaSR.Sprint6.Task5.V18
{
    partial class FormMain_CSR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_CSR));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_CSR = new System.Windows.Forms.Panel();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.buttonOpen_CSR = new System.Windows.Forms.Button();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.panelLeft_CSR = new System.Windows.Forms.Panel();
            this.groupBoxResult_CSR = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_CSR = new System.Windows.Forms.DataGridView();
            this.splitterLeft_CSR = new System.Windows.Forms.Splitter();
            this.panelFill_CSR = new System.Windows.Forms.Panel();
            this.chartResult_CSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonResult_CSR = new System.Windows.Forms.Button();
            this.panelTop_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            this.panelLeft_CSR.SuspendLayout();
            this.groupBoxResult_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_CSR)).BeginInit();
            this.panelFill_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_CSR
            // 
            this.panelTop_CSR.Controls.Add(this.buttonResult_CSR);
            this.panelTop_CSR.Controls.Add(this.groupBoxTask_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonOpen_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonHelp_CSR);
            this.panelTop_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CSR.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CSR.Name = "panelTop_CSR";
            this.panelTop_CSR.Size = new System.Drawing.Size(789, 135);
            this.panelTop_CSR.TabIndex = 26;
            //this.panelTop_CSR.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_CSR_Paint);
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(9, 6);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(404, 123);
            this.groupBoxTask_CSR.TabIndex = 0;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие:";
            // 
            // textBoxTask_CSR
            // 
            this.textBoxTask_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_CSR.Multiline = true;
            this.textBoxTask_CSR.Name = "textBoxTask_CSR";
            this.textBoxTask_CSR.ReadOnly = true;
            this.textBoxTask_CSR.Size = new System.Drawing.Size(389, 98);
            this.textBoxTask_CSR.TabIndex = 0;
            this.textBoxTask_CSR.Text = resources.GetString("textBoxTask_CSR.Text");
            //this.textBoxTask_CSR.TextChanged += new System.EventHandler(this.textBoxTask_CSR_TextChanged);
            // 
            // buttonOpen_CSR
            // 
            this.buttonOpen_CSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonOpen_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_CSR.Location = new System.Drawing.Point(559, 25);
            this.buttonOpen_CSR.Name = "buttonOpen_CSR";
            this.buttonOpen_CSR.Size = new System.Drawing.Size(97, 70);
            this.buttonOpen_CSR.TabIndex = 22;
            this.buttonOpen_CSR.Text = "Открыть файл";
            this.buttonOpen_CSR.UseVisualStyleBackColor = false;
            this.buttonOpen_CSR.Click += new System.EventHandler(this.buttonOpen_CSR_Click);
            this.buttonOpen_CSR.MouseEnter += new System.EventHandler(this.buttonResult_CSR_MouseEnter);
            this.buttonOpen_CSR.MouseLeave += new System.EventHandler(this.buttonResult_CSR_MouseLeave);
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_CSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_CSR.Location = new System.Drawing.Point(680, 25);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(97, 70);
            this.buttonHelp_CSR.TabIndex = 20;
            this.buttonHelp_CSR.Text = "Справка";
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            this.buttonHelp_CSR.MouseEnter += new System.EventHandler(this.buttonResult_CSR_MouseEnter);
            this.buttonHelp_CSR.MouseLeave += new System.EventHandler(this.buttonResult_CSR_MouseLeave);
            // 
            // panelLeft_CSR
            // 
            this.panelLeft_CSR.Controls.Add(this.groupBoxResult_CSR);
            this.panelLeft_CSR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CSR.Location = new System.Drawing.Point(0, 135);
            this.panelLeft_CSR.Name = "panelLeft_CSR";
            this.panelLeft_CSR.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_CSR.Size = new System.Drawing.Size(207, 278);
            this.panelLeft_CSR.TabIndex = 27;
            // 
            // groupBoxResult_CSR
            // 
            this.groupBoxResult_CSR.Controls.Add(this.dataGridViewResult_CSR);
            this.groupBoxResult_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_CSR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_CSR.Name = "groupBoxResult_CSR";
            this.groupBoxResult_CSR.Size = new System.Drawing.Size(197, 268);
            this.groupBoxResult_CSR.TabIndex = 23;
            this.groupBoxResult_CSR.TabStop = false;
            this.groupBoxResult_CSR.Text = "Вывод данных:";
            // 
            // dataGridViewResult_CSR
            // 
            this.dataGridViewResult_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_CSR.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_CSR.Name = "dataGridViewResult_CSR";
            this.dataGridViewResult_CSR.Size = new System.Drawing.Size(191, 249);
            this.dataGridViewResult_CSR.TabIndex = 0;
            // 
            // splitterLeft_CSR
            // 
            this.splitterLeft_CSR.Location = new System.Drawing.Point(207, 135);
            this.splitterLeft_CSR.Name = "splitterLeft_CSR";
            this.splitterLeft_CSR.Size = new System.Drawing.Size(3, 278);
            this.splitterLeft_CSR.TabIndex = 28;
            this.splitterLeft_CSR.TabStop = false;
            // 
            // panelFill_CSR
            // 
            this.panelFill_CSR.Controls.Add(this.chartResult_CSR);
            this.panelFill_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_CSR.Location = new System.Drawing.Point(210, 135);
            this.panelFill_CSR.Name = "panelFill_CSR";
            this.panelFill_CSR.Size = new System.Drawing.Size(579, 278);
            this.panelFill_CSR.TabIndex = 29;
            // 
            // chartResult_CSR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_CSR.ChartAreas.Add(chartArea1);
            this.chartResult_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_CSR.Legends.Add(legend1);
            this.chartResult_CSR.Location = new System.Drawing.Point(0, 0);
            this.chartResult_CSR.Name = "chartResult_CSR";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_CSR.Series.Add(series1);
            this.chartResult_CSR.Size = new System.Drawing.Size(579, 278);
            this.chartResult_CSR.TabIndex = 0;
            this.chartResult_CSR.Text = "chart1";
            // 
            // buttonResult_CSR
            // 
            this.buttonResult_CSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonResult_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_CSR.Location = new System.Drawing.Point(440, 25);
            this.buttonResult_CSR.Name = "buttonResult_CSR";
            this.buttonResult_CSR.Size = new System.Drawing.Size(97, 70);
            this.buttonResult_CSR.TabIndex = 23;
            this.buttonResult_CSR.Text = "Выполнить";
            this.buttonResult_CSR.UseVisualStyleBackColor = false;
            this.buttonResult_CSR.Click += new System.EventHandler(this.buttonResult_CSR_Click_1);
            this.buttonResult_CSR.MouseEnter += new System.EventHandler(this.buttonResult_CSR_MouseEnter);
            this.buttonResult_CSR.MouseLeave += new System.EventHandler(this.buttonResult_CSR_MouseLeave);
            // 
            // FormMain_CSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 413);
            this.Controls.Add(this.panelFill_CSR);
            this.Controls.Add(this.splitterLeft_CSR);
            this.Controls.Add(this.panelLeft_CSR);
            this.Controls.Add(this.panelTop_CSR);
            this.Name = "FormMain_CSR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 18 | Чазова С.Р.";
            this.panelTop_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.panelLeft_CSR.ResumeLayout(false);
            this.groupBoxResult_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_CSR)).EndInit();
            this.panelFill_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_CSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.Button buttonOpen_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.Panel panelLeft_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult_CSR;
        private System.Windows.Forms.Splitter splitterLeft_CSR;
        private System.Windows.Forms.Panel panelFill_CSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_CSR;
        private System.Windows.Forms.DataGridView dataGridViewResult_CSR;
        private System.Windows.Forms.Button buttonResult_CSR;
    }
}

