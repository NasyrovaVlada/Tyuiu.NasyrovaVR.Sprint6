namespace Tyuiu.NasyrovaVR.Sprint6.Task2.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GroupBoxCond_NVR = new System.Windows.Forms.GroupBox();
            this.PictureBoxFormula_NVR = new System.Windows.Forms.PictureBox();
            this.TextBoxTask_NVR = new System.Windows.Forms.TextBox();
            this.GroupBoxInput_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxStop_NVR = new System.Windows.Forms.TextBox();
            this.TextBoxStart_NVR = new System.Windows.Forms.TextBox();
            this.LabelStop_NVR = new System.Windows.Forms.Label();
            this.LabelStart_NVR = new System.Windows.Forms.Label();
            this.ButtonInfo_NVR = new System.Windows.Forms.Button();
            this.ButtonDone_NVR = new System.Windows.Forms.Button();
            this.GroupBoxOutput_NVR = new System.Windows.Forms.GroupBox();
            this.Chart_NVR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataGridView_NVR = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxResult_NVR = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBoxCond_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFormula_NVR)).BeginInit();
            this.GroupBoxInput_NVR.SuspendLayout();
            this.GroupBoxOutput_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_NVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxCond_NVR
            // 
            this.GroupBoxCond_NVR.Controls.Add(this.PictureBoxFormula_NVR);
            this.GroupBoxCond_NVR.Controls.Add(this.TextBoxTask_NVR);
            this.GroupBoxCond_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxCond_NVR.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxCond_NVR.Name = "GroupBoxCond_NVR";
            this.GroupBoxCond_NVR.Size = new System.Drawing.Size(615, 304);
            this.GroupBoxCond_NVR.TabIndex = 0;
            this.GroupBoxCond_NVR.TabStop = false;
            this.GroupBoxCond_NVR.Text = "Условие";
            // 
            // PictureBoxFormula_NVR
            // 
            this.PictureBoxFormula_NVR.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFormula_NVR.Image")));
            this.PictureBoxFormula_NVR.Location = new System.Drawing.Point(21, 115);
            this.PictureBoxFormula_NVR.Name = "PictureBoxFormula_NVR";
            this.PictureBoxFormula_NVR.Size = new System.Drawing.Size(456, 53);
            this.PictureBoxFormula_NVR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxFormula_NVR.TabIndex = 1;
            this.PictureBoxFormula_NVR.TabStop = false;
            // 
            // TextBoxTask_NVR
            // 
            this.TextBoxTask_NVR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_NVR.Location = new System.Drawing.Point(21, 34);
            this.TextBoxTask_NVR.Multiline = true;
            this.TextBoxTask_NVR.Name = "TextBoxTask_NVR";
            this.TextBoxTask_NVR.ReadOnly = true;
            this.TextBoxTask_NVR.Size = new System.Drawing.Size(576, 253);
            this.TextBoxTask_NVR.TabIndex = 0;
            this.TextBoxTask_NVR.TabStop = false;
            this.TextBoxTask_NVR.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.";
            // 
            // GroupBoxInput_NVR
            // 
            this.GroupBoxInput_NVR.Controls.Add(this.TextBoxStop_NVR);
            this.GroupBoxInput_NVR.Controls.Add(this.TextBoxStart_NVR);
            this.GroupBoxInput_NVR.Controls.Add(this.LabelStop_NVR);
            this.GroupBoxInput_NVR.Controls.Add(this.LabelStart_NVR);
            this.GroupBoxInput_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_NVR.Location = new System.Drawing.Point(12, 322);
            this.GroupBoxInput_NVR.Name = "GroupBoxInput_NVR";
            this.GroupBoxInput_NVR.Size = new System.Drawing.Size(346, 116);
            this.GroupBoxInput_NVR.TabIndex = 1;
            this.GroupBoxInput_NVR.TabStop = false;
            this.GroupBoxInput_NVR.Text = "Ввод данных";
            // 
            // TextBoxStop_NVR
            // 
            this.TextBoxStop_NVR.Location = new System.Drawing.Point(167, 62);
            this.TextBoxStop_NVR.Name = "TextBoxStop_NVR";
            this.TextBoxStop_NVR.Size = new System.Drawing.Size(154, 36);
            this.TextBoxStop_NVR.TabIndex = 3;
            // 
            // TextBoxStart_NVR
            // 
            this.TextBoxStart_NVR.Location = new System.Drawing.Point(10, 62);
            this.TextBoxStart_NVR.Name = "TextBoxStart_NVR";
            this.TextBoxStart_NVR.Size = new System.Drawing.Size(151, 36);
            this.TextBoxStart_NVR.TabIndex = 2;
            // 
            // LabelStop_NVR
            // 
            this.LabelStop_NVR.AutoSize = true;
            this.LabelStop_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStop_NVR.Location = new System.Drawing.Point(163, 35);
            this.LabelStop_NVR.Name = "LabelStop_NVR";
            this.LabelStop_NVR.Size = new System.Drawing.Size(120, 22);
            this.LabelStop_NVR.TabIndex = 1;
            this.LabelStop_NVR.Text = "Конец шага:";
            // 
            // LabelStart_NVR
            // 
            this.LabelStart_NVR.AutoSize = true;
            this.LabelStart_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStart_NVR.Location = new System.Drawing.Point(6, 35);
            this.LabelStart_NVR.Name = "LabelStart_NVR";
            this.LabelStart_NVR.Size = new System.Drawing.Size(120, 22);
            this.LabelStart_NVR.TabIndex = 0;
            this.LabelStart_NVR.Text = "Старт шага:";
            // 
            // ButtonInfo_NVR
            // 
            this.ButtonInfo_NVR.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonInfo_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo_NVR.Location = new System.Drawing.Point(376, 357);
            this.ButtonInfo_NVR.Name = "ButtonInfo_NVR";
            this.ButtonInfo_NVR.Size = new System.Drawing.Size(103, 56);
            this.ButtonInfo_NVR.TabIndex = 2;
            this.ButtonInfo_NVR.Text = "Справка";
            this.ButtonInfo_NVR.UseVisualStyleBackColor = false;
            this.ButtonInfo_NVR.Click += new System.EventHandler(this.ButtonInfo_NVR_Click);
            // 
            // ButtonDone_NVR
            // 
            this.ButtonDone_NVR.BackColor = System.Drawing.Color.Green;
            this.ButtonDone_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDone_NVR.Location = new System.Drawing.Point(485, 357);
            this.ButtonDone_NVR.Name = "ButtonDone_NVR";
            this.ButtonDone_NVR.Size = new System.Drawing.Size(142, 56);
            this.ButtonDone_NVR.TabIndex = 3;
            this.ButtonDone_NVR.Text = "Выполнить";
            this.ButtonDone_NVR.UseVisualStyleBackColor = false;
            this.ButtonDone_NVR.Click += new System.EventHandler(this.ButtonDone_NVR_Click);
            this.ButtonDone_NVR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDone_NVR_MouseDown);
            this.ButtonDone_NVR.MouseEnter += new System.EventHandler(this.ButtonDone_NVR_MouseEnter);
            this.ButtonDone_NVR.MouseLeave += new System.EventHandler(this.ButtonDone_NVR_MouseLeave);
            // 
            // GroupBoxOutput_NVR
            // 
            this.GroupBoxOutput_NVR.Controls.Add(this.dataGridView1);
            this.GroupBoxOutput_NVR.Controls.Add(this.Chart_NVR);
            this.GroupBoxOutput_NVR.Controls.Add(this.DataGridView_NVR);
            this.GroupBoxOutput_NVR.Controls.Add(this.TextBoxResult_NVR);
            this.GroupBoxOutput_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_NVR.Location = new System.Drawing.Point(633, 12);
            this.GroupBoxOutput_NVR.Name = "GroupBoxOutput_NVR";
            this.GroupBoxOutput_NVR.Size = new System.Drawing.Size(673, 426);
            this.GroupBoxOutput_NVR.TabIndex = 4;
            this.GroupBoxOutput_NVR.TabStop = false;
            this.GroupBoxOutput_NVR.Text = "Вывод данных";
            // 
            // Chart_NVR
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart_NVR.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart_NVR.Legends.Add(legend3);
            this.Chart_NVR.Location = new System.Drawing.Point(192, 34);
            this.Chart_NVR.Name = "Chart_NVR";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart_NVR.Series.Add(series3);
            this.Chart_NVR.Size = new System.Drawing.Size(476, 386);
            this.Chart_NVR.TabIndex = 4;
            this.Chart_NVR.Text = "chart1";
            // 
            // DataGridView_NVR
            // 
            this.DataGridView_NVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_NVR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.DataGridView_NVR.Location = new System.Drawing.Point(7, 58);
            this.DataGridView_NVR.Name = "DataGridView_NVR";
            this.DataGridView_NVR.RowHeadersVisible = false;
            this.DataGridView_NVR.RowTemplate.Height = 27;
            this.DataGridView_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView_NVR.Size = new System.Drawing.Size(179, 362);
            this.DataGridView_NVR.TabIndex = 3;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 80;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 80;
            // 
            // TextBoxResult_NVR
            // 
            this.TextBoxResult_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxResult_NVR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxResult_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxResult_NVR.Location = new System.Drawing.Point(7, 34);
            this.TextBoxResult_NVR.Multiline = true;
            this.TextBoxResult_NVR.Name = "TextBoxResult_NVR";
            this.TextBoxResult_NVR.Size = new System.Drawing.Size(660, 392);
            this.TextBoxResult_NVR.TabIndex = 2;
            this.TextBoxResult_NVR.Text = "Результат:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 450);
            this.Controls.Add(this.GroupBoxOutput_NVR);
            this.Controls.Add(this.ButtonDone_NVR);
            this.Controls.Add(this.ButtonInfo_NVR);
            this.Controls.Add(this.GroupBoxInput_NVR);
            this.Controls.Add(this.GroupBoxCond_NVR);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 26 | Насырова В.Р.";
            this.GroupBoxCond_NVR.ResumeLayout(false);
            this.GroupBoxCond_NVR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFormula_NVR)).EndInit();
            this.GroupBoxInput_NVR.ResumeLayout(false);
            this.GroupBoxInput_NVR.PerformLayout();
            this.GroupBoxOutput_NVR.ResumeLayout(false);
            this.GroupBoxOutput_NVR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_NVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxCond_NVR;
        private System.Windows.Forms.TextBox TextBoxTask_NVR;
        private System.Windows.Forms.PictureBox PictureBoxFormula_NVR;
        private System.Windows.Forms.GroupBox GroupBoxInput_NVR;
        private System.Windows.Forms.TextBox TextBoxStop_NVR;
        private System.Windows.Forms.TextBox TextBoxStart_NVR;
        private System.Windows.Forms.Label LabelStop_NVR;
        private System.Windows.Forms.Label LabelStart_NVR;
        private System.Windows.Forms.Button ButtonInfo_NVR;
        private System.Windows.Forms.Button ButtonDone_NVR;
        private System.Windows.Forms.GroupBox GroupBoxOutput_NVR;
        private System.Windows.Forms.TextBox TextBoxResult_NVR;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_NVR;
        private System.Windows.Forms.DataGridView DataGridView_NVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

