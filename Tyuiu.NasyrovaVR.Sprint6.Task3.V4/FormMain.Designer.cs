namespace Tyuiu.NasyrovaVR.Sprint6.Task3.V4
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
            this.GroupBoxTask_NVR = new System.Windows.Forms.GroupBox();
            this.GroupBoxOutput_NVR = new System.Windows.Forms.GroupBox();
            this.LabelResult_NVR = new System.Windows.Forms.Label();
            this.TextBoxResult_NVR = new System.Windows.Forms.TextBox();
            this.TextBoxTask_NVR = new System.Windows.Forms.TextBox();
            this.DataGridView_NVR = new System.Windows.Forms.DataGridView();
            this.ButtonInfo_NVR = new System.Windows.Forms.Button();
            this.ButtonDone_NVR = new System.Windows.Forms.Button();
            this.GroupBoxTask_NVR.SuspendLayout();
            this.GroupBoxOutput_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NVR)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxTask_NVR
            // 
            this.GroupBoxTask_NVR.Controls.Add(this.DataGridView_NVR);
            this.GroupBoxTask_NVR.Controls.Add(this.TextBoxTask_NVR);
            this.GroupBoxTask_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTask_NVR.Location = new System.Drawing.Point(13, 13);
            this.GroupBoxTask_NVR.Name = "GroupBoxTask_NVR";
            this.GroupBoxTask_NVR.Size = new System.Drawing.Size(713, 425);
            this.GroupBoxTask_NVR.TabIndex = 0;
            this.GroupBoxTask_NVR.TabStop = false;
            this.GroupBoxTask_NVR.Text = "Условие";
            // 
            // GroupBoxOutput_NVR
            // 
            this.GroupBoxOutput_NVR.Controls.Add(this.TextBoxResult_NVR);
            this.GroupBoxOutput_NVR.Controls.Add(this.LabelResult_NVR);
            this.GroupBoxOutput_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_NVR.Location = new System.Drawing.Point(733, 13);
            this.GroupBoxOutput_NVR.Name = "GroupBoxOutput_NVR";
            this.GroupBoxOutput_NVR.Size = new System.Drawing.Size(236, 153);
            this.GroupBoxOutput_NVR.TabIndex = 1;
            this.GroupBoxOutput_NVR.TabStop = false;
            this.GroupBoxOutput_NVR.Text = "Вывод данных";
            // 
            // LabelResult_NVR
            // 
            this.LabelResult_NVR.AutoSize = true;
            this.LabelResult_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelResult_NVR.Location = new System.Drawing.Point(7, 36);
            this.LabelResult_NVR.Name = "LabelResult_NVR";
            this.LabelResult_NVR.Size = new System.Drawing.Size(110, 22);
            this.LabelResult_NVR.TabIndex = 0;
            this.LabelResult_NVR.Text = "Результат:";
            // 
            // TextBoxResult_NVR
            // 
            this.TextBoxResult_NVR.BackColor = System.Drawing.Color.White;
            this.TextBoxResult_NVR.Location = new System.Drawing.Point(11, 61);
            this.TextBoxResult_NVR.Name = "TextBoxResult_NVR";
            this.TextBoxResult_NVR.ReadOnly = true;
            this.TextBoxResult_NVR.Size = new System.Drawing.Size(219, 36);
            this.TextBoxResult_NVR.TabIndex = 1;
            // 
            // TextBoxTask_NVR
            // 
            this.TextBoxTask_NVR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_NVR.Location = new System.Drawing.Point(7, 36);
            this.TextBoxTask_NVR.Multiline = true;
            this.TextBoxTask_NVR.Name = "TextBoxTask_NVR";
            this.TextBoxTask_NVR.ReadOnly = true;
            this.TextBoxTask_NVR.Size = new System.Drawing.Size(350, 383);
            this.TextBoxTask_NVR.TabIndex = 0;
            this.TextBoxTask_NVR.TabStop = false;
            this.TextBoxTask_NVR.Text = "Дана матрица 5 на 5\r\n-14  -7  18  12 -20\r\n -2 -15 -19 -19  -3\r\n-18  -5 -10  14 -1" +
    "7 \r\n -1   2 -10   0  11\r\n  6 -18   0  19  16\r\nЗаменить четные значения во второй" +
    " строке на 0";
            // 
            // DataGridView_NVR
            // 
            this.DataGridView_NVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_NVR.Location = new System.Drawing.Point(363, 35);
            this.DataGridView_NVR.Name = "DataGridView_NVR";
            this.DataGridView_NVR.RowHeadersVisible = false;
            this.DataGridView_NVR.Size = new System.Drawing.Size(344, 326);
            this.DataGridView_NVR.TabIndex = 1;
            // 
            // ButtonInfo_NVR
            // 
            this.ButtonInfo_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfo_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo_NVR.Location = new System.Drawing.Point(744, 391);
            this.ButtonInfo_NVR.Name = "ButtonInfo_NVR";
            this.ButtonInfo_NVR.Size = new System.Drawing.Size(52, 47);
            this.ButtonInfo_NVR.TabIndex = 2;
            this.ButtonInfo_NVR.Text = "?";
            this.ButtonInfo_NVR.UseVisualStyleBackColor = true;
            this.ButtonInfo_NVR.Click += new System.EventHandler(this.ButtonInfo_NVR_Click);
            // 
            // ButtonDone_NVR
            // 
            this.ButtonDone_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDone_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDone_NVR.Location = new System.Drawing.Point(802, 391);
            this.ButtonDone_NVR.Name = "ButtonDone_NVR";
            this.ButtonDone_NVR.Size = new System.Drawing.Size(161, 47);
            this.ButtonDone_NVR.TabIndex = 3;
            this.ButtonDone_NVR.Text = "Выполнить";
            this.ButtonDone_NVR.UseVisualStyleBackColor = true;
            this.ButtonDone_NVR.Click += new System.EventHandler(this.ButtonDone_NVR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.ButtonDone_NVR);
            this.Controls.Add(this.ButtonInfo_NVR);
            this.Controls.Add(this.GroupBoxOutput_NVR);
            this.Controls.Add(this.GroupBoxTask_NVR);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 4 | Насырова В.Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBoxTask_NVR.ResumeLayout(false);
            this.GroupBoxTask_NVR.PerformLayout();
            this.GroupBoxOutput_NVR.ResumeLayout(false);
            this.GroupBoxOutput_NVR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NVR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxTask_NVR;
        private System.Windows.Forms.TextBox TextBoxTask_NVR;
        private System.Windows.Forms.GroupBox GroupBoxOutput_NVR;
        private System.Windows.Forms.TextBox TextBoxResult_NVR;
        private System.Windows.Forms.Label LabelResult_NVR;
        private System.Windows.Forms.DataGridView DataGridView_NVR;
        private System.Windows.Forms.Button ButtonInfo_NVR;
        private System.Windows.Forms.Button ButtonDone_NVR;
    }
}

