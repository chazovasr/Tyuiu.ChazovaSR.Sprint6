
namespace Tyuiu.ChazovaSR.Sprint6.Task3.V20
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
            this.buttonResult_CSR = new System.Windows.Forms.Button();
            this.groupBoxResult_CSR = new System.Windows.Forms.GroupBox();
            this.labelResult_CSR = new System.Windows.Forms.Label();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.textBoxResult_CSR = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_CSR = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult_CSR
            // 
            this.buttonResult_CSR.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonResult_CSR.Location = new System.Drawing.Point(704, 326);
            this.buttonResult_CSR.Name = "buttonResult_CSR";
            this.buttonResult_CSR.Size = new System.Drawing.Size(84, 35);
            this.buttonResult_CSR.TabIndex = 19;
            this.buttonResult_CSR.Text = "Выполнить";
            this.buttonResult_CSR.UseVisualStyleBackColor = false;
            this.buttonResult_CSR.Click += new System.EventHandler(this.buttonResult_CSR_Click);
            // 
            // groupBoxResult_CSR
            // 
            this.groupBoxResult_CSR.Controls.Add(this.textBoxResult_CSR);
            this.groupBoxResult_CSR.Controls.Add(this.labelResult_CSR);
            this.groupBoxResult_CSR.Location = new System.Drawing.Point(585, 23);
            this.groupBoxResult_CSR.Name = "groupBoxResult_CSR";
            this.groupBoxResult_CSR.Size = new System.Drawing.Size(203, 90);
            this.groupBoxResult_CSR.TabIndex = 18;
            this.groupBoxResult_CSR.TabStop = false;
            this.groupBoxResult_CSR.Text = "Вывод данных";
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
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_CSR.Location = new System.Drawing.Point(652, 327);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(37, 34);
            this.buttonHelp_CSR.TabIndex = 16;
            this.buttonHelp_CSR.Text = "?";
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.dataGridViewMatrix_CSR);
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 23);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(552, 328);
            this.groupBoxTask_CSR.TabIndex = 15;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            // 
            // textBoxTask_CSR
            // 
            this.textBoxTask_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_CSR.Multiline = true;
            this.textBoxTask_CSR.Name = "textBoxTask_CSR";
            this.textBoxTask_CSR.ReadOnly = true;
            this.textBoxTask_CSR.Size = new System.Drawing.Size(298, 216);
            this.textBoxTask_CSR.TabIndex = 0;
            this.textBoxTask_CSR.Text = resources.GetString("textBoxTask_CSR.Text");
            // 
            // textBoxResult_CSR
            // 
            this.textBoxResult_CSR.Location = new System.Drawing.Point(16, 50);
            this.textBoxResult_CSR.Name = "textBoxResult_CSR";
            this.textBoxResult_CSR.ReadOnly = true;
            this.textBoxResult_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_CSR.TabIndex = 1;
            // 
            // dataGridViewMatrix_CSR
            // 
            this.dataGridViewMatrix_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_CSR.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_CSR.Location = new System.Drawing.Point(320, 19);
            this.dataGridViewMatrix_CSR.Name = "dataGridViewMatrix_CSR";
            this.dataGridViewMatrix_CSR.RowHeadersVisible = false;
            this.dataGridViewMatrix_CSR.Size = new System.Drawing.Size(216, 272);
            this.dataGridViewMatrix_CSR.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.buttonResult_CSR);
            this.Controls.Add(this.groupBoxResult_CSR);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 20 | Чазова С. Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxResult_CSR.ResumeLayout(false);
            this.groupBoxResult_CSR.PerformLayout();
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_CSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult_CSR;
        private System.Windows.Forms.Label labelResult_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxResult_CSR;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_CSR;
    }
}

