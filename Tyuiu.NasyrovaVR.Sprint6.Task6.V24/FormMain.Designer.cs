namespace Tyuiu.NasyrovaVR.Sprint6.Task6.V24
{
    partial class FormMain_NVR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_NVR));
            this.PanelTop_NVR = new System.Windows.Forms.Panel();
            this.ButtonInfo_NVR = new System.Windows.Forms.Button();
            this.ButtonDone_NVR = new System.Windows.Forms.Button();
            this.ButtonOpen_NVR = new System.Windows.Forms.Button();
            this.PanelTask_NVR = new System.Windows.Forms.Panel();
            this.GroupBoxTask_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxTask_NVR = new System.Windows.Forms.TextBox();
            this.PanelLeft_NVR = new System.Windows.Forms.Panel();
            this.GroupBoxInput_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxInput_NVR = new System.Windows.Forms.TextBox();
            this.PanelFill_NVR = new System.Windows.Forms.Panel();
            this.GroupBoxOutput_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxOutput_NVR = new System.Windows.Forms.TextBox();
            this.Splitter_NVR = new System.Windows.Forms.Splitter();
            this.OpenFileDialog_NVR = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip_NVR = new System.Windows.Forms.ToolTip(this.components);
            this.PanelTop_NVR.SuspendLayout();
            this.PanelTask_NVR.SuspendLayout();
            this.GroupBoxTask_NVR.SuspendLayout();
            this.PanelLeft_NVR.SuspendLayout();
            this.GroupBoxInput_NVR.SuspendLayout();
            this.PanelFill_NVR.SuspendLayout();
            this.GroupBoxOutput_NVR.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop_NVR
            // 
            this.PanelTop_NVR.Controls.Add(this.ButtonInfo_NVR);
            this.PanelTop_NVR.Controls.Add(this.ButtonDone_NVR);
            this.PanelTop_NVR.Controls.Add(this.ButtonOpen_NVR);
            this.PanelTop_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop_NVR.Location = new System.Drawing.Point(0, 0);
            this.PanelTop_NVR.Name = "PanelTop_NVR";
            this.PanelTop_NVR.Size = new System.Drawing.Size(834, 94);
            this.PanelTop_NVR.TabIndex = 0;
            // 
            // ButtonInfo_NVR
            // 
            this.ButtonInfo_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInfo_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonInfo_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonInfo_NVR.BackgroundImage")));
            this.ButtonInfo_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonInfo_NVR.Location = new System.Drawing.Point(719, 12);
            this.ButtonInfo_NVR.Name = "ButtonInfo_NVR";
            this.ButtonInfo_NVR.Size = new System.Drawing.Size(103, 76);
            this.ButtonInfo_NVR.TabIndex = 2;
            this.ToolTip_NVR.SetToolTip(this.ButtonInfo_NVR, "Сведения о программе");
            this.ButtonInfo_NVR.UseVisualStyleBackColor = false;
            this.ButtonInfo_NVR.Click += new System.EventHandler(this.ButtonInfo_NVR_Click);
            // 
            // ButtonDone_NVR
            // 
            this.ButtonDone_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDone_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDone_NVR.BackgroundImage")));
            this.ButtonDone_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDone_NVR.Location = new System.Drawing.Point(114, 12);
            this.ButtonDone_NVR.Name = "ButtonDone_NVR";
            this.ButtonDone_NVR.Size = new System.Drawing.Size(99, 76);
            this.ButtonDone_NVR.TabIndex = 1;
            this.ToolTip_NVR.SetToolTip(this.ButtonDone_NVR, "Выводит первое слово каждой строки в результирующею строку");
            this.ButtonDone_NVR.UseVisualStyleBackColor = false;
            this.ButtonDone_NVR.Click += new System.EventHandler(this.ButtonDone_NVR_Click);
            // 
            // ButtonOpen_NVR
            // 
            this.ButtonOpen_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOpen_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpen_NVR.BackgroundImage")));
            this.ButtonOpen_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpen_NVR.Location = new System.Drawing.Point(12, 12);
            this.ButtonOpen_NVR.Name = "ButtonOpen_NVR";
            this.ButtonOpen_NVR.Size = new System.Drawing.Size(96, 76);
            this.ButtonOpen_NVR.TabIndex = 0;
            this.ToolTip_NVR.SetToolTip(this.ButtonOpen_NVR, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.ButtonOpen_NVR.UseVisualStyleBackColor = false;
            this.ButtonOpen_NVR.Click += new System.EventHandler(this.ButtonOpen_NVR_Click);
            // 
            // PanelTask_NVR
            // 
            this.PanelTask_NVR.Controls.Add(this.GroupBoxTask_NVR);
            this.PanelTask_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTask_NVR.Location = new System.Drawing.Point(0, 94);
            this.PanelTask_NVR.Name = "PanelTask_NVR";
            this.PanelTask_NVR.Size = new System.Drawing.Size(834, 100);
            this.PanelTask_NVR.TabIndex = 1;
            // 
            // GroupBoxTask_NVR
            // 
            this.GroupBoxTask_NVR.Controls.Add(this.TextBoxTask_NVR);
            this.GroupBoxTask_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxTask_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTask_NVR.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxTask_NVR.Name = "GroupBoxTask_NVR";
            this.GroupBoxTask_NVR.Size = new System.Drawing.Size(834, 100);
            this.GroupBoxTask_NVR.TabIndex = 0;
            this.GroupBoxTask_NVR.TabStop = false;
            this.GroupBoxTask_NVR.Text = "Условие";
            // 
            // TextBoxTask_NVR
            // 
            this.TextBoxTask_NVR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxTask_NVR.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_NVR.Location = new System.Drawing.Point(3, 22);
            this.TextBoxTask_NVR.Multiline = true;
            this.TextBoxTask_NVR.Name = "TextBoxTask_NVR";
            this.TextBoxTask_NVR.ReadOnly = true;
            this.TextBoxTask_NVR.Size = new System.Drawing.Size(828, 61);
            this.TextBoxTask_NVR.TabIndex = 0;
            this.TextBoxTask_NVR.TabStop = false;
            this.TextBoxTask_NVR.Text = resources.GetString("TextBoxTask_NVR.Text");
            // 
            // PanelLeft_NVR
            // 
            this.PanelLeft_NVR.Controls.Add(this.GroupBoxInput_NVR);
            this.PanelLeft_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft_NVR.Location = new System.Drawing.Point(0, 194);
            this.PanelLeft_NVR.Name = "PanelLeft_NVR";
            this.PanelLeft_NVR.Size = new System.Drawing.Size(399, 217);
            this.PanelLeft_NVR.TabIndex = 2;
            // 
            // GroupBoxInput_NVR
            // 
            this.GroupBoxInput_NVR.Controls.Add(this.TextBoxInput_NVR);
            this.GroupBoxInput_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxInput_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_NVR.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxInput_NVR.Name = "GroupBoxInput_NVR";
            this.GroupBoxInput_NVR.Size = new System.Drawing.Size(399, 217);
            this.GroupBoxInput_NVR.TabIndex = 0;
            this.GroupBoxInput_NVR.TabStop = false;
            this.GroupBoxInput_NVR.Text = "Ввод";
            // 
            // TextBoxInput_NVR
            // 
            this.TextBoxInput_NVR.BackColor = System.Drawing.Color.White;
            this.TextBoxInput_NVR.Location = new System.Drawing.Point(12, 16);
            this.TextBoxInput_NVR.Multiline = true;
            this.TextBoxInput_NVR.Name = "TextBoxInput_NVR";
            this.TextBoxInput_NVR.ReadOnly = true;
            this.TextBoxInput_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxInput_NVR.Size = new System.Drawing.Size(381, 195);
            this.TextBoxInput_NVR.TabIndex = 0;
            // 
            // PanelFill_NVR
            // 
            this.PanelFill_NVR.Controls.Add(this.GroupBoxOutput_NVR);
            this.PanelFill_NVR.Controls.Add(this.Splitter_NVR);
            this.PanelFill_NVR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill_NVR.Location = new System.Drawing.Point(399, 194);
            this.PanelFill_NVR.Name = "PanelFill_NVR";
            this.PanelFill_NVR.Size = new System.Drawing.Size(435, 217);
            this.PanelFill_NVR.TabIndex = 3;
            // 
            // GroupBoxOutput_NVR
            // 
            this.GroupBoxOutput_NVR.Controls.Add(this.TextBoxOutput_NVR);
            this.GroupBoxOutput_NVR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxOutput_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_NVR.Location = new System.Drawing.Point(3, 0);
            this.GroupBoxOutput_NVR.Name = "GroupBoxOutput_NVR";
            this.GroupBoxOutput_NVR.Size = new System.Drawing.Size(432, 217);
            this.GroupBoxOutput_NVR.TabIndex = 1;
            this.GroupBoxOutput_NVR.TabStop = false;
            this.GroupBoxOutput_NVR.Text = "Вывод";
            // 
            // TextBoxOutput_NVR
            // 
            this.TextBoxOutput_NVR.BackColor = System.Drawing.Color.White;
            this.TextBoxOutput_NVR.Location = new System.Drawing.Point(6, 16);
            this.TextBoxOutput_NVR.Multiline = true;
            this.TextBoxOutput_NVR.Name = "TextBoxOutput_NVR";
            this.TextBoxOutput_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxOutput_NVR.Size = new System.Drawing.Size(423, 195);
            this.TextBoxOutput_NVR.TabIndex = 0;
            // 
            // Splitter_NVR
            // 
            this.Splitter_NVR.Location = new System.Drawing.Point(0, 0);
            this.Splitter_NVR.Name = "Splitter_NVR";
            this.Splitter_NVR.Size = new System.Drawing.Size(3, 217);
            this.Splitter_NVR.TabIndex = 0;
            this.Splitter_NVR.TabStop = false;
            // 
            // OpenFileDialog_NVR
            // 
            this.OpenFileDialog_NVR.FileName = "openFileDialog1";
            // 
            // ToolTip_NVR
            // 
            this.ToolTip_NVR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_NVR.ToolTipTitle = "Подсказка";
            // 
            // FormMain_NVR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.PanelFill_NVR);
            this.Controls.Add(this.PanelLeft_NVR);
            this.Controls.Add(this.PanelTask_NVR);
            this.Controls.Add(this.PanelTop_NVR);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "FormMain_NVR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Насырова В.Р.";
            this.PanelTop_NVR.ResumeLayout(false);
            this.PanelTask_NVR.ResumeLayout(false);
            this.GroupBoxTask_NVR.ResumeLayout(false);
            this.GroupBoxTask_NVR.PerformLayout();
            this.PanelLeft_NVR.ResumeLayout(false);
            this.GroupBoxInput_NVR.ResumeLayout(false);
            this.GroupBoxInput_NVR.PerformLayout();
            this.PanelFill_NVR.ResumeLayout(false);
            this.GroupBoxOutput_NVR.ResumeLayout(false);
            this.GroupBoxOutput_NVR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop_NVR;
        private System.Windows.Forms.Panel PanelTask_NVR;
        private System.Windows.Forms.Panel PanelLeft_NVR;
        private System.Windows.Forms.Panel PanelFill_NVR;
        private System.Windows.Forms.Splitter Splitter_NVR;
        private System.Windows.Forms.GroupBox GroupBoxTask_NVR;
        private System.Windows.Forms.GroupBox GroupBoxInput_NVR;
        private System.Windows.Forms.TextBox TextBoxInput_NVR;
        private System.Windows.Forms.GroupBox GroupBoxOutput_NVR;
        private System.Windows.Forms.TextBox TextBoxOutput_NVR;
        private System.Windows.Forms.Button ButtonInfo_NVR;
        private System.Windows.Forms.Button ButtonDone_NVR;
        private System.Windows.Forms.Button ButtonOpen_NVR;
        private System.Windows.Forms.TextBox TextBoxTask_NVR;
        private System.Windows.Forms.ToolTip ToolTip_NVR;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_NVR;
    }
}

