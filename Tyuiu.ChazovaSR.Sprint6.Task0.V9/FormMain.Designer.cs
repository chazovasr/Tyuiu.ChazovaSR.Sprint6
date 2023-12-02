
namespace Tyuiu.ChazovaSR.Sprint6.Task0.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_CSR = new System.Windows.Forms.PictureBox();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupBoxVar_CSR = new System.Windows.Forms.GroupBox();
            this.labelVarA_CSR = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult_CSR = new System.Windows.Forms.Label();
            this.textBoxVarA_CSR = new System.Windows.Forms.TextBox();
            this.buttonResult_CSR = new System.Windows.Forms.Button();
            this.textBoxResult_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxTask_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_CSR)).BeginInit();
            this.groupBoxVar_CSR.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.pictureBoxFormula_CSR);
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 24);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(523, 150);
            this.groupBoxTask_CSR.TabIndex = 0;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            //this.groupBoxTask_CSR.Enter += new System.EventHandler(this.groupBoxTask_CSR_Enter);
            // 
            // textBoxTask_CSR
            // 
            this.textBoxTask_CSR.Location = new System.Drawing.Point(16, 33);
            this.textBoxTask_CSR.Multiline = true;
            this.textBoxTask_CSR.Name = "textBoxTask_CSR";
            this.textBoxTask_CSR.ReadOnly = true;
            this.textBoxTask_CSR.Size = new System.Drawing.Size(370, 101);
            this.textBoxTask_CSR.TabIndex = 0;
            this.textBoxTask_CSR.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_CSR
            // 
            this.pictureBoxFormula_CSR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_CSR.Image")));
            this.pictureBoxFormula_CSR.Location = new System.Drawing.Point(401, 33);
            this.pictureBoxFormula_CSR.Name = "pictureBoxFormula_CSR";
            this.pictureBoxFormula_CSR.Size = new System.Drawing.Size(106, 61);
            this.pictureBoxFormula_CSR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_CSR.TabIndex = 1;
            this.pictureBoxFormula_CSR.TabStop = false;
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_CSR.Location = new System.Drawing.Point(413, 307);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(38, 35);
            this.buttonHelp_CSR.TabIndex = 1;
            this.buttonHelp_CSR.Text = "?";
            this.buttonHelp_CSR.UseVisualStyleBackColor = true;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // groupBoxVar_CSR
            // 
            this.groupBoxVar_CSR.Controls.Add(this.textBoxVarA_CSR);
            this.groupBoxVar_CSR.Controls.Add(this.labelVarA_CSR);
            this.groupBoxVar_CSR.Location = new System.Drawing.Point(12, 203);
            this.groupBoxVar_CSR.Name = "groupBoxVar_CSR";
            this.groupBoxVar_CSR.Size = new System.Drawing.Size(386, 100);
            this.groupBoxVar_CSR.TabIndex = 2;
            this.groupBoxVar_CSR.TabStop = false;
            this.groupBoxVar_CSR.Text = "Ввод данных";
            // 
            // labelVarA_CSR
            // 
            this.labelVarA_CSR.AutoSize = true;
            this.labelVarA_CSR.Location = new System.Drawing.Point(6, 41);
            this.labelVarA_CSR.Name = "labelVarA_CSR";
            this.labelVarA_CSR.Size = new System.Drawing.Size(84, 13);
            this.labelVarA_CSR.TabIndex = 0;
            this.labelVarA_CSR.Text = "Переменная А:";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult_CSR);
            this.groupBoxResult.Controls.Add(this.labelResult_CSR);
            this.groupBoxResult.Location = new System.Drawing.Point(413, 203);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(147, 98);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // labelResult_CSR
            // 
            this.labelResult_CSR.AutoSize = true;
            this.labelResult_CSR.Location = new System.Drawing.Point(6, 41);
            this.labelResult_CSR.Name = "labelResult_CSR";
            this.labelResult_CSR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_CSR.TabIndex = 0;
            this.labelResult_CSR.Text = "Результат:";
            // 
            // textBoxVarA_CSR
            // 
            this.textBoxVarA_CSR.Location = new System.Drawing.Point(6, 74);
            this.textBoxVarA_CSR.Name = "textBoxVarA_CSR";
            this.textBoxVarA_CSR.Size = new System.Drawing.Size(81, 20);
            this.textBoxVarA_CSR.TabIndex = 3;
            this.textBoxVarA_CSR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarA_CSR_KeyPress);
            // 
            // buttonResult_CSR
            // 
            this.buttonResult_CSR.Location = new System.Drawing.Point(457, 307);
            this.buttonResult_CSR.Name = "buttonResult_CSR";
            this.buttonResult_CSR.Size = new System.Drawing.Size(103, 35);
            this.buttonResult_CSR.TabIndex = 4;
            this.buttonResult_CSR.Text = "Выполнить";
            this.buttonResult_CSR.UseVisualStyleBackColor = true;
            this.buttonResult_CSR.Click += new System.EventHandler(this.buttonResult_CSR_Click);
            // 
            // textBoxResult_CSR
            // 
            this.textBoxResult_CSR.Location = new System.Drawing.Point(9, 72);
            this.textBoxResult_CSR.Name = "textBoxResult_CSR";
            this.textBoxResult_CSR.ReadOnly = true;
            this.textBoxResult_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_CSR.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 354);
            this.Controls.Add(this.buttonResult_CSR);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxVar_CSR);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 9 | Чазова С. Р.";
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_CSR)).EndInit();
            this.groupBoxVar_CSR.ResumeLayout(false);
            this.groupBoxVar_CSR.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.PictureBox pictureBoxFormula_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.GroupBox groupBoxVar_CSR;
        private System.Windows.Forms.TextBox textBoxVarA_CSR;
        private System.Windows.Forms.Label labelVarA_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult_CSR;
        private System.Windows.Forms.Label labelResult_CSR;
        private System.Windows.Forms.Button buttonResult_CSR;
    }
}

