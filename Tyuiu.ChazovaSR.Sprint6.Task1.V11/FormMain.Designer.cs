
namespace Tyuiu.ChazovaSR.Sprint6.Task1.V11
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
            this.buttonResult_CSR = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult_CSR = new System.Windows.Forms.TextBox();
            this.labelResult_CSR = new System.Windows.Forms.Label();
            this.groupBoxVar_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxVarStart_CSR = new System.Windows.Forms.TextBox();
            this.labelVarStart_CSR = new System.Windows.Forms.Label();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_CSR = new System.Windows.Forms.TextBox();
            this.labelVarStop_CSR = new System.Windows.Forms.Label();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxVar_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonResult_CSR
            // 
            this.buttonResult_CSR.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonResult_CSR.Location = new System.Drawing.Point(20, 287);
            this.buttonResult_CSR.Name = "buttonResult_CSR";
            this.buttonResult_CSR.Size = new System.Drawing.Size(84, 35);
            this.buttonResult_CSR.TabIndex = 9;
            this.buttonResult_CSR.Text = "Выполнить";
            this.buttonResult_CSR.UseVisualStyleBackColor = false;
            this.buttonResult_CSR.Click += new System.EventHandler(this.buttonResult_CSR_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult_CSR);
            this.groupBoxResult.Controls.Add(this.labelResult_CSR);
            this.groupBoxResult.Location = new System.Drawing.Point(392, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(246, 309);
            this.groupBoxResult.TabIndex = 8;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxResult_CSR
            // 
            this.textBoxResult_CSR.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_CSR.Location = new System.Drawing.Point(9, 36);
            this.textBoxResult_CSR.Multiline = true;
            this.textBoxResult_CSR.Name = "textBoxResult_CSR";
            this.textBoxResult_CSR.ReadOnly = true;
            this.textBoxResult_CSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_CSR.Size = new System.Drawing.Size(231, 267);
            this.textBoxResult_CSR.TabIndex = 1;
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
            this.groupBoxVar_CSR.Location = new System.Drawing.Point(14, 179);
            this.groupBoxVar_CSR.Name = "groupBoxVar_CSR";
            this.groupBoxVar_CSR.Size = new System.Drawing.Size(323, 102);
            this.groupBoxVar_CSR.TabIndex = 7;
            this.groupBoxVar_CSR.TabStop = false;
            this.groupBoxVar_CSR.Text = "Ввод данных";
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
            this.buttonHelp_CSR.Location = new System.Drawing.Point(136, 287);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(84, 34);
            this.buttonHelp_CSR.TabIndex = 6;
            this.buttonHelp_CSR.Text = "Справка";
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(14, 7);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(323, 150);
            this.groupBoxTask_CSR.TabIndex = 5;
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
            this.textBoxTask_CSR.Text = "Протабулировать функцию (5x + 2,5 / sin(x)+3)+ 2x +cos(x) на заданном диапазоне.\r" +
    "\nРезультат вывести в виде таблицы.";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 333);
            this.Controls.Add(this.buttonResult_CSR);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxVar_CSR);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 11 | Чазова С. Р.";
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxVar_CSR.ResumeLayout(false);
            this.groupBoxVar_CSR.PerformLayout();
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult_CSR;
        private System.Windows.Forms.Label labelResult_CSR;
        private System.Windows.Forms.GroupBox groupBoxVar_CSR;
        private System.Windows.Forms.TextBox textBoxVarStop_CSR;
        private System.Windows.Forms.Label labelVarStop_CSR;
        private System.Windows.Forms.TextBox textBoxVarStart_CSR;
        private System.Windows.Forms.Label labelVarStart_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
    }
}

