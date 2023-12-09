
namespace Tyuiu.ChazovaSR.Sprint6.Task4.V23
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxInput_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxStop_CSR = new System.Windows.Forms.TextBox();
            this.textBoxStart_CSR = new System.Windows.Forms.TextBox();
            this.labelStop_CSR = new System.Windows.Forms.Label();
            this.labelStart_CSR = new System.Windows.Forms.Label();
            this.buttonResult_CSR = new System.Windows.Forms.Button();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.buttonSave_CSR = new System.Windows.Forms.Button();
            this.groupBoxResult_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxResult_CSR = new System.Windows.Forms.TextBox();
            this.panelTop_CSR = new System.Windows.Forms.Panel();
            this.panelLeft_CSR = new System.Windows.Forms.Panel();
            this.panelFill_CSR = new System.Windows.Forms.Panel();
            this.chartResult_CSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterLeft_CSR = new System.Windows.Forms.Splitter();
            this.groupBoxTask_CSR.SuspendLayout();
            this.groupBoxInput_CSR.SuspendLayout();
            this.groupBoxResult_CSR.SuspendLayout();
            this.panelTop_CSR.SuspendLayout();
            this.panelLeft_CSR.SuspendLayout();
            this.panelFill_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_CSR)).BeginInit();
            this.SuspendLayout();
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
            // 
            // groupBoxInput_CSR
            // 
            this.groupBoxInput_CSR.Controls.Add(this.textBoxStop_CSR);
            this.groupBoxInput_CSR.Controls.Add(this.textBoxStart_CSR);
            this.groupBoxInput_CSR.Controls.Add(this.labelStop_CSR);
            this.groupBoxInput_CSR.Controls.Add(this.labelStart_CSR);
            this.groupBoxInput_CSR.Location = new System.Drawing.Point(419, 6);
            this.groupBoxInput_CSR.Name = "groupBoxInput_CSR";
            this.groupBoxInput_CSR.Size = new System.Drawing.Size(251, 123);
            this.groupBoxInput_CSR.TabIndex = 1;
            this.groupBoxInput_CSR.TabStop = false;
            this.groupBoxInput_CSR.Text = "Ввод данных";
            // 
            // textBoxStop_CSR
            // 
            this.textBoxStop_CSR.Location = new System.Drawing.Point(138, 55);
            this.textBoxStop_CSR.Name = "textBoxStop_CSR";
            this.textBoxStop_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_CSR.TabIndex = 3;
            // 
            // textBoxStart_CSR
            // 
            this.textBoxStart_CSR.Location = new System.Drawing.Point(9, 55);
            this.textBoxStart_CSR.Name = "textBoxStart_CSR";
            this.textBoxStart_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_CSR.TabIndex = 2;
            // 
            // labelStop_CSR
            // 
            this.labelStop_CSR.AutoSize = true;
            this.labelStop_CSR.Location = new System.Drawing.Point(117, 22);
            this.labelStop_CSR.Name = "labelStop_CSR";
            this.labelStop_CSR.Size = new System.Drawing.Size(69, 13);
            this.labelStop_CSR.TabIndex = 1;
            this.labelStop_CSR.Text = "Конец шага:";
            // 
            // labelStart_CSR
            // 
            this.labelStart_CSR.AutoSize = true;
            this.labelStart_CSR.Location = new System.Drawing.Point(6, 22);
            this.labelStart_CSR.Name = "labelStart_CSR";
            this.labelStart_CSR.Size = new System.Drawing.Size(67, 13);
            this.labelStart_CSR.TabIndex = 0;
            this.labelStart_CSR.Text = "Старт шага:";
            // 
            // buttonResult_CSR
            // 
            this.buttonResult_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResult_CSR.BackColor = System.Drawing.Color.Green;
            this.buttonResult_CSR.Location = new System.Drawing.Point(676, 38);
            this.buttonResult_CSR.Name = "buttonResult_CSR";
            this.buttonResult_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonResult_CSR.TabIndex = 21;
            this.buttonResult_CSR.Text = "Выполнить";
            this.buttonResult_CSR.UseVisualStyleBackColor = false;
            this.buttonResult_CSR.Click += new System.EventHandler(this.buttonResult_CSR_Click);
            this.buttonResult_CSR.MouseEnter += new System.EventHandler(this.buttonResult_CSR_MouseEnter);
            this.buttonResult_CSR.MouseLeave += new System.EventHandler(this.buttonResult_CSR_MouseLeave);
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_CSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_CSR.Location = new System.Drawing.Point(841, 38);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonHelp_CSR.TabIndex = 20;
            this.buttonHelp_CSR.Text = "Справка";
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            this.buttonHelp_CSR.MouseEnter += new System.EventHandler(this.buttonResult_CSR_MouseEnter);
            this.buttonHelp_CSR.MouseLeave += new System.EventHandler(this.buttonResult_CSR_MouseLeave);
            // 
            // buttonSave_CSR
            // 
            this.buttonSave_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_CSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSave_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_CSR.Location = new System.Drawing.Point(760, 38);
            this.buttonSave_CSR.Name = "buttonSave_CSR";
            this.buttonSave_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonSave_CSR.TabIndex = 22;
            this.buttonSave_CSR.Text = "Сохранить";
            this.buttonSave_CSR.UseVisualStyleBackColor = false;
            this.buttonSave_CSR.Click += new System.EventHandler(this.buttonSave_CSR_Click);
            this.buttonSave_CSR.MouseEnter += new System.EventHandler(this.buttonResult_CSR_MouseEnter);
            this.buttonSave_CSR.MouseLeave += new System.EventHandler(this.buttonResult_CSR_MouseLeave);
            // 
            // groupBoxResult_CSR
            // 
            this.groupBoxResult_CSR.Controls.Add(this.textBoxResult_CSR);
            this.groupBoxResult_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_CSR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_CSR.Name = "groupBoxResult_CSR";
            this.groupBoxResult_CSR.Size = new System.Drawing.Size(197, 305);
            this.groupBoxResult_CSR.TabIndex = 23;
            this.groupBoxResult_CSR.TabStop = false;
            this.groupBoxResult_CSR.Text = "Вывод:";
            this.groupBoxResult_CSR.Enter += new System.EventHandler(this.groupBoxResult_CSR_Enter);
            // 
            // textBoxResult_CSR
            // 
            this.textBoxResult_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_CSR.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_CSR.Multiline = true;
            this.textBoxResult_CSR.Name = "textBoxResult_CSR";
            this.textBoxResult_CSR.ReadOnly = true;
            this.textBoxResult_CSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_CSR.Size = new System.Drawing.Size(191, 286);
            this.textBoxResult_CSR.TabIndex = 0;
            // 
            // panelTop_CSR
            // 
            this.panelTop_CSR.Controls.Add(this.groupBoxTask_CSR);
            this.panelTop_CSR.Controls.Add(this.groupBoxInput_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonResult_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonSave_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonHelp_CSR);
            this.panelTop_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CSR.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CSR.Name = "panelTop_CSR";
            this.panelTop_CSR.Size = new System.Drawing.Size(923, 135);
            this.panelTop_CSR.TabIndex = 25;
            // 
            // panelLeft_CSR
            // 
            this.panelLeft_CSR.Controls.Add(this.groupBoxResult_CSR);
            this.panelLeft_CSR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CSR.Location = new System.Drawing.Point(0, 135);
            this.panelLeft_CSR.Name = "panelLeft_CSR";
            this.panelLeft_CSR.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_CSR.Size = new System.Drawing.Size(207, 315);
            this.panelLeft_CSR.TabIndex = 26;
            // 
            // panelFill_CSR
            // 
            this.panelFill_CSR.Controls.Add(this.chartResult_CSR);
            this.panelFill_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_CSR.Location = new System.Drawing.Point(207, 135);
            this.panelFill_CSR.Name = "panelFill_CSR";
            this.panelFill_CSR.Size = new System.Drawing.Size(716, 315);
            this.panelFill_CSR.TabIndex = 27;
            // 
            // chartResult_CSR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_CSR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_CSR.Legends.Add(legend1);
            this.chartResult_CSR.Location = new System.Drawing.Point(53, 17);
            this.chartResult_CSR.Name = "chartResult_CSR";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_CSR.Series.Add(series1);
            this.chartResult_CSR.Size = new System.Drawing.Size(570, 286);
            this.chartResult_CSR.TabIndex = 25;
            this.chartResult_CSR.Text = "График функции";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            title1.Name = "TitleFunction_CSR";
            title1.Text = "График функции  4 - 2x + ((2+ COS(x)) / (2x - 2))";
            this.chartResult_CSR.Titles.Add(title1);
            // 
            // splitterLeft_CSR
            // 
            this.splitterLeft_CSR.Location = new System.Drawing.Point(207, 135);
            this.splitterLeft_CSR.Name = "splitterLeft_CSR";
            this.splitterLeft_CSR.Size = new System.Drawing.Size(3, 315);
            this.splitterLeft_CSR.TabIndex = 28;
            this.splitterLeft_CSR.TabStop = false;
            // 
            // FormMain_CSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.splitterLeft_CSR);
            this.Controls.Add(this.panelFill_CSR);
            this.Controls.Add(this.panelLeft_CSR);
            this.Controls.Add(this.panelTop_CSR);
            this.Name = "FormMain_CSR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 23 | Чазова С.Р.";
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.groupBoxInput_CSR.ResumeLayout(false);
            this.groupBoxInput_CSR.PerformLayout();
            this.groupBoxResult_CSR.ResumeLayout(false);
            this.groupBoxResult_CSR.PerformLayout();
            this.panelTop_CSR.ResumeLayout(false);
            this.panelLeft_CSR.ResumeLayout(false);
            this.panelFill_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_CSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.GroupBox groupBoxInput_CSR;
        private System.Windows.Forms.TextBox textBoxStop_CSR;
        private System.Windows.Forms.TextBox textBoxStart_CSR;
        private System.Windows.Forms.Label labelStop_CSR;
        private System.Windows.Forms.Label labelStart_CSR;
        private System.Windows.Forms.Button buttonResult_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.Button buttonSave_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult_CSR;
        private System.Windows.Forms.TextBox textBoxResult_CSR;
        private System.Windows.Forms.Panel panelTop_CSR;
        private System.Windows.Forms.Panel panelLeft_CSR;
        private System.Windows.Forms.Panel panelFill_CSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_CSR;
        private System.Windows.Forms.Splitter splitterLeft_CSR;
    }
}

