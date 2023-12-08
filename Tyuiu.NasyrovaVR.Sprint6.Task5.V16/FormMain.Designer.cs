namespace Tyuiu.NasyrovaVR.Sprint6.Task5.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelTop_NVR = new System.Windows.Forms.Panel();
            this.PanelLeft_NVR = new System.Windows.Forms.Panel();
            this.PanelFill_NVR = new System.Windows.Forms.Panel();
            this.GroupBoxTask_NVR = new System.Windows.Forms.GroupBox();
            this.GroupBoxOutput_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxTask_NVR = new System.Windows.Forms.TextBox();
            this.ButtonDone_NVR = new System.Windows.Forms.Button();
            this.ButtonOpen_NVR = new System.Windows.Forms.Button();
            this.ButtonInfo_NVR = new System.Windows.Forms.Button();
            this.Chart_NVR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataGridView_NVR = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PanelTop_NVR.SuspendLayout();
            this.PanelLeft_NVR.SuspendLayout();
            this.PanelFill_NVR.SuspendLayout();
            this.GroupBoxTask_NVR.SuspendLayout();
            this.GroupBoxOutput_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_NVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NVR)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop_NVR
            // 
            this.PanelTop_NVR.Controls.Add(this.ButtonInfo_NVR);
            this.PanelTop_NVR.Controls.Add(this.ButtonOpen_NVR);
            this.PanelTop_NVR.Controls.Add(this.ButtonDone_NVR);
            this.PanelTop_NVR.Controls.Add(this.GroupBoxTask_NVR);
            this.PanelTop_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop_NVR.Location = new System.Drawing.Point(0, 0);
            this.PanelTop_NVR.Name = "PanelTop_NVR";
            this.PanelTop_NVR.Size = new System.Drawing.Size(834, 100);
            this.PanelTop_NVR.TabIndex = 0;
            // 
            // PanelLeft_NVR
            // 
            this.PanelLeft_NVR.Controls.Add(this.GroupBoxOutput_NVR);
            this.PanelLeft_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft_NVR.Location = new System.Drawing.Point(0, 100);
            this.PanelLeft_NVR.Name = "PanelLeft_NVR";
            this.PanelLeft_NVR.Padding = new System.Windows.Forms.Padding(5);
            this.PanelLeft_NVR.Size = new System.Drawing.Size(200, 361);
            this.PanelLeft_NVR.TabIndex = 1;
            // 
            // PanelFill_NVR
            // 
            this.PanelFill_NVR.Controls.Add(this.splitter1);
            this.PanelFill_NVR.Controls.Add(this.Chart_NVR);
            this.PanelFill_NVR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill_NVR.Location = new System.Drawing.Point(0, 100);
            this.PanelFill_NVR.Name = "PanelFill_NVR";
            this.PanelFill_NVR.Size = new System.Drawing.Size(834, 361);
            this.PanelFill_NVR.TabIndex = 1;
            // 
            // GroupBoxTask_NVR
            // 
            this.GroupBoxTask_NVR.Controls.Add(this.TextBoxTask_NVR);
            this.GroupBoxTask_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTask_NVR.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxTask_NVR.Name = "GroupBoxTask_NVR";
            this.GroupBoxTask_NVR.Size = new System.Drawing.Size(512, 91);
            this.GroupBoxTask_NVR.TabIndex = 0;
            this.GroupBoxTask_NVR.TabStop = false;
            this.GroupBoxTask_NVR.Text = "Условие";
            // 
            // GroupBoxOutput_NVR
            // 
            this.GroupBoxOutput_NVR.Controls.Add(this.DataGridView_NVR);
            this.GroupBoxOutput_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxOutput_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_NVR.Location = new System.Drawing.Point(5, 5);
            this.GroupBoxOutput_NVR.Name = "GroupBoxOutput_NVR";
            this.GroupBoxOutput_NVR.Size = new System.Drawing.Size(187, 351);
            this.GroupBoxOutput_NVR.TabIndex = 0;
            this.GroupBoxOutput_NVR.TabStop = false;
            this.GroupBoxOutput_NVR.Text = "Вывод данных";
            // 
            // TextBoxTask_NVR
            // 
            this.TextBoxTask_NVR.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_NVR.Location = new System.Drawing.Point(6, 25);
            this.TextBoxTask_NVR.Multiline = true;
            this.TextBoxTask_NVR.Name = "TextBoxTask_NVR";
            this.TextBoxTask_NVR.ReadOnly = true;
            this.TextBoxTask_NVR.Size = new System.Drawing.Size(500, 60);
            this.TextBoxTask_NVR.TabIndex = 0;
            this.TextBoxTask_NVR.TabStop = false;
            this.TextBoxTask_NVR.Text = "Прочитать данные из файла InPutFileTask5V16.txt\r\nВывести в DataGridView все полож" +
    "ительные числа и построить диаграмму по этим значениям. ";
            // 
            // ButtonDone_NVR
            // 
            this.ButtonDone_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDone_NVR.BackColor = System.Drawing.Color.Green;
            this.ButtonDone_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDone_NVR.Location = new System.Drawing.Point(549, 12);
            this.ButtonDone_NVR.Name = "ButtonDone_NVR";
            this.ButtonDone_NVR.Size = new System.Drawing.Size(102, 76);
            this.ButtonDone_NVR.TabIndex = 1;
            this.ButtonDone_NVR.Text = "Выполнить";
            this.ButtonDone_NVR.UseVisualStyleBackColor = false;
            this.ButtonDone_NVR.Click += new System.EventHandler(this.ButtonDone_NVR_Click);
            // 
            // ButtonOpen_NVR
            // 
            this.ButtonOpen_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpen_NVR.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonOpen_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOpen_NVR.Location = new System.Drawing.Point(657, 12);
            this.ButtonOpen_NVR.Name = "ButtonOpen_NVR";
            this.ButtonOpen_NVR.Size = new System.Drawing.Size(84, 76);
            this.ButtonOpen_NVR.TabIndex = 2;
            this.ButtonOpen_NVR.Text = "Открыть файл";
            this.ButtonOpen_NVR.UseVisualStyleBackColor = false;
            this.ButtonOpen_NVR.Click += new System.EventHandler(this.ButtonOpen_NVR_Click);
            // 
            // ButtonInfo_NVR
            // 
            this.ButtonInfo_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInfo_NVR.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonInfo_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo_NVR.Location = new System.Drawing.Point(747, 12);
            this.ButtonInfo_NVR.Name = "ButtonInfo_NVR";
            this.ButtonInfo_NVR.Size = new System.Drawing.Size(84, 76);
            this.ButtonInfo_NVR.TabIndex = 3;
            this.ButtonInfo_NVR.Text = "Справка";
            this.ButtonInfo_NVR.UseVisualStyleBackColor = false;
            this.ButtonInfo_NVR.Click += new System.EventHandler(this.ButtonInfo_NVR_Click);
            // 
            // Chart_NVR
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart_NVR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_NVR.Legends.Add(legend2);
            this.Chart_NVR.Location = new System.Drawing.Point(206, 6);
            this.Chart_NVR.Name = "Chart_NVR";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart_NVR.Series.Add(series2);
            this.Chart_NVR.Size = new System.Drawing.Size(616, 343);
            this.Chart_NVR.TabIndex = 0;
            this.Chart_NVR.Text = "chart1";
            // 
            // DataGridView_NVR
            // 
            this.DataGridView_NVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridView_NVR.Location = new System.Drawing.Point(3, 22);
            this.DataGridView_NVR.Name = "DataGridView_NVR";
            this.DataGridView_NVR.RowHeadersVisible = false;
            this.DataGridView_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView_NVR.Size = new System.Drawing.Size(184, 326);
            this.DataGridView_NVR.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 361);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.PanelLeft_NVR);
            this.Controls.Add(this.PanelFill_NVR);
            this.Controls.Add(this.PanelTop_NVR);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 16 | Насырова В.Р.";
            this.PanelTop_NVR.ResumeLayout(false);
            this.PanelLeft_NVR.ResumeLayout(false);
            this.PanelFill_NVR.ResumeLayout(false);
            this.GroupBoxTask_NVR.ResumeLayout(false);
            this.GroupBoxTask_NVR.PerformLayout();
            this.GroupBoxOutput_NVR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_NVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NVR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop_NVR;
        private System.Windows.Forms.GroupBox GroupBoxTask_NVR;
        private System.Windows.Forms.Panel PanelLeft_NVR;
        private System.Windows.Forms.GroupBox GroupBoxOutput_NVR;
        private System.Windows.Forms.Panel PanelFill_NVR;
        private System.Windows.Forms.TextBox TextBoxTask_NVR;
        private System.Windows.Forms.Button ButtonInfo_NVR;
        private System.Windows.Forms.Button ButtonOpen_NVR;
        private System.Windows.Forms.Button ButtonDone_NVR;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_NVR;
        private System.Windows.Forms.DataGridView DataGridView_NVR;
        private System.Windows.Forms.Splitter splitter1;
    }
}

