
namespace Tyuiu.ChazovaSR.Sprint6.Task6.V20
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_CSR));
            this.panelUp_CSR = new System.Windows.Forms.Panel();
            this.buttonInfo_CSR = new System.Windows.Forms.Button();
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.buttonOpenFile_CSR = new System.Windows.Forms.Button();
            this.openFileDialogTask_CSR = new System.Windows.Forms.OpenFileDialog();
            this.toolTipFile_CSR = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxInput_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxResult_CSR = new System.Windows.Forms.TextBox();
            this.panelTask_CSR = new System.Windows.Forms.Panel();
            this.panelLeft_CSR = new System.Windows.Forms.Panel();
            this.panelFill_CSR = new System.Windows.Forms.Panel();
            this.splitterLeft_CSR = new System.Windows.Forms.Splitter();
            this.panelUp_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            this.groupBoxInPut_CSR.SuspendLayout();
            this.groupBoxOutPut_CSR.SuspendLayout();
            this.panelTask_CSR.SuspendLayout();
            this.panelLeft_CSR.SuspendLayout();
            this.panelFill_CSR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp_CSR
            // 
            this.panelUp_CSR.Controls.Add(this.buttonInfo_CSR);
            this.panelUp_CSR.Controls.Add(this.buttonDone_CSR);
            this.panelUp_CSR.Controls.Add(this.buttonOpenFile_CSR);
            this.panelUp_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_CSR.Location = new System.Drawing.Point(0, 0);
            this.panelUp_CSR.Name = "panelUp_CSR";
            this.panelUp_CSR.Size = new System.Drawing.Size(800, 85);
            this.panelUp_CSR.TabIndex = 0;
            // 
            // buttonInfo_CSR
            // 
            this.buttonInfo_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_CSR.Image")));
            this.buttonInfo_CSR.Location = new System.Drawing.Point(696, 12);
            this.buttonInfo_CSR.Name = "buttonInfo_CSR";
            this.buttonInfo_CSR.Size = new System.Drawing.Size(81, 63);
            this.buttonInfo_CSR.TabIndex = 2;
            this.toolTipFile_CSR.SetToolTip(this.buttonInfo_CSR, "Сведения о программе");
            this.buttonInfo_CSR.UseVisualStyleBackColor = true;
            this.buttonInfo_CSR.Click += new System.EventHandler(this.buttonInfo_CSR_Click);
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_CSR.Image")));
            this.buttonDone_CSR.Location = new System.Drawing.Point(110, 12);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(81, 63);
            this.buttonDone_CSR.TabIndex = 1;
            this.toolTipFile_CSR.SetToolTip(this.buttonDone_CSR, "Производит поиск в файле второго слова\r\nв каждой строке и выводит их в результиру" +
        "ющую строку");
            this.buttonDone_CSR.UseVisualStyleBackColor = true;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_CSR_Click);
            // 
            // buttonOpenFile_CSR
            // 
            this.buttonOpenFile_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_CSR.Image")));
            this.buttonOpenFile_CSR.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_CSR.Name = "buttonOpenFile_CSR";
            this.buttonOpenFile_CSR.Size = new System.Drawing.Size(81, 63);
            this.buttonOpenFile_CSR.TabIndex = 0;
            this.toolTipFile_CSR.SetToolTip(this.buttonOpenFile_CSR, "Открыть файл\r\nВыберите нужный файл для обработкт");
            this.buttonOpenFile_CSR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_CSR.Click += new System.EventHandler(this.buttonOpenFile_CSR_Click);
            // 
            // openFileDialogTask_CSR
            // 
            this.openFileDialogTask_CSR.FileName = "openFileDialog1";
            // 
            // toolTipFile_CSR
            // 
            this.toolTipFile_CSR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipFile_CSR.ToolTipTitle = "Подсказка";
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(800, 100);
            this.groupBoxTask_CSR.TabIndex = 1;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            // 
            // textBoxTask_CSR
            // 
            this.textBoxTask_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_CSR.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_CSR.Multiline = true;
            this.textBoxTask_CSR.Name = "textBoxTask_CSR";
            this.textBoxTask_CSR.ReadOnly = true;
            this.textBoxTask_CSR.Size = new System.Drawing.Size(794, 81);
            this.textBoxTask_CSR.TabIndex = 0;
            this.textBoxTask_CSR.Text = resources.GetString("textBoxTask_CSR.Text");
            // 
            // groupBoxInPut_CSR
            // 
            this.groupBoxInPut_CSR.Controls.Add(this.textBoxInput_CSR);
            this.groupBoxInPut_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_CSR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_CSR.Name = "groupBoxInPut_CSR";
            this.groupBoxInPut_CSR.Size = new System.Drawing.Size(376, 265);
            this.groupBoxInPut_CSR.TabIndex = 2;
            this.groupBoxInPut_CSR.TabStop = false;
            this.groupBoxInPut_CSR.Text = "Ввод:";
            // 
            // textBoxInput_CSR
            // 
            this.textBoxInput_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_CSR.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_CSR.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxInput_CSR.Multiline = true;
            this.textBoxInput_CSR.Name = "textBoxInput_CSR";
            this.textBoxInput_CSR.ReadOnly = true;
            this.textBoxInput_CSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_CSR.Size = new System.Drawing.Size(370, 246);
            this.textBoxInput_CSR.TabIndex = 0;
            // 
            // groupBoxOutPut_CSR
            // 
            this.groupBoxOutPut_CSR.Controls.Add(this.textBoxResult_CSR);
            this.groupBoxOutPut_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_CSR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_CSR.Name = "groupBoxOutPut_CSR";
            this.groupBoxOutPut_CSR.Size = new System.Drawing.Size(424, 265);
            this.groupBoxOutPut_CSR.TabIndex = 3;
            this.groupBoxOutPut_CSR.TabStop = false;
            this.groupBoxOutPut_CSR.Text = "Вывод:";
            // 
            // textBoxResult_CSR
            // 
            this.textBoxResult_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_CSR.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_CSR.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxResult_CSR.Multiline = true;
            this.textBoxResult_CSR.Name = "textBoxResult_CSR";
            this.textBoxResult_CSR.ReadOnly = true;
            this.textBoxResult_CSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_CSR.Size = new System.Drawing.Size(418, 246);
            this.textBoxResult_CSR.TabIndex = 0;
            // 
            // panelTask_CSR
            // 
            this.panelTask_CSR.Controls.Add(this.groupBoxTask_CSR);
            this.panelTask_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_CSR.Location = new System.Drawing.Point(0, 85);
            this.panelTask_CSR.Name = "panelTask_CSR";
            this.panelTask_CSR.Size = new System.Drawing.Size(800, 100);
            this.panelTask_CSR.TabIndex = 4;
            // 
            // panelLeft_CSR
            // 
            this.panelLeft_CSR.Controls.Add(this.groupBoxInPut_CSR);
            this.panelLeft_CSR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CSR.Location = new System.Drawing.Point(0, 185);
            this.panelLeft_CSR.Name = "panelLeft_CSR";
            this.panelLeft_CSR.Size = new System.Drawing.Size(376, 265);
            this.panelLeft_CSR.TabIndex = 5;
            // 
            // panelFill_CSR
            // 
            this.panelFill_CSR.Controls.Add(this.groupBoxOutPut_CSR);
            this.panelFill_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_CSR.Location = new System.Drawing.Point(376, 185);
            this.panelFill_CSR.Name = "panelFill_CSR";
            this.panelFill_CSR.Size = new System.Drawing.Size(424, 265);
            this.panelFill_CSR.TabIndex = 6;
            // 
            // splitterLeft_CSR
            // 
            this.splitterLeft_CSR.Location = new System.Drawing.Point(376, 185);
            this.splitterLeft_CSR.Name = "splitterLeft_CSR";
            this.splitterLeft_CSR.Size = new System.Drawing.Size(3, 265);
            this.splitterLeft_CSR.TabIndex = 7;
            this.splitterLeft_CSR.TabStop = false;
            // 
            // FormMain_CSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitterLeft_CSR);
            this.Controls.Add(this.panelFill_CSR);
            this.Controls.Add(this.panelLeft_CSR);
            this.Controls.Add(this.panelTask_CSR);
            this.Controls.Add(this.panelUp_CSR);
            this.Name = "FormMain_CSR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 20 | Чазова С.Р.";
            this.panelUp_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.groupBoxInPut_CSR.ResumeLayout(false);
            this.groupBoxInPut_CSR.PerformLayout();
            this.groupBoxOutPut_CSR.ResumeLayout(false);
            this.groupBoxOutPut_CSR.PerformLayout();
            this.panelTask_CSR.ResumeLayout(false);
            this.panelLeft_CSR.ResumeLayout(false);
            this.panelFill_CSR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_CSR;
        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.Button buttonOpenFile_CSR;
        private System.Windows.Forms.Button buttonInfo_CSR;
        private System.Windows.Forms.ToolTip toolTipFile_CSR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.GroupBox groupBoxInPut_CSR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_CSR;
        private System.Windows.Forms.Panel panelTask_CSR;
        private System.Windows.Forms.Panel panelLeft_CSR;
        private System.Windows.Forms.Panel panelFill_CSR;
        private System.Windows.Forms.TextBox textBoxInput_CSR;
        private System.Windows.Forms.TextBox textBoxResult_CSR;
        private System.Windows.Forms.Splitter splitterLeft_CSR;
    }
}

