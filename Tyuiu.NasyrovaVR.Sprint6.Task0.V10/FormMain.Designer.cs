namespace Tyuiu.NasyrovaVR.Sprint6.Task0.V10
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
            this.GroupBoxCond_NVR = new System.Windows.Forms.GroupBox();
            this.PictureBoxFormula_NVR = new System.Windows.Forms.PictureBox();
            this.TextBoxTask_NVR = new System.Windows.Forms.TextBox();
            this.GroupBoxInput_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxVarX_NVR = new System.Windows.Forms.TextBox();
            this.LabelVarX_NVR = new System.Windows.Forms.Label();
            this.GroupBoxOutput_NVR = new System.Windows.Forms.GroupBox();
            this.TextBoxResult_NVR = new System.Windows.Forms.TextBox();
            this.LabelResult_NVR = new System.Windows.Forms.Label();
            this.ButtonDone_NVR = new System.Windows.Forms.Button();
            this.ButtonInfo_NVR = new System.Windows.Forms.Button();
            this.GroupBoxCond_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFormula_NVR)).BeginInit();
            this.GroupBoxInput_NVR.SuspendLayout();
            this.GroupBoxOutput_NVR.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxCond_NVR
            // 
            this.GroupBoxCond_NVR.Controls.Add(this.PictureBoxFormula_NVR);
            this.GroupBoxCond_NVR.Controls.Add(this.TextBoxTask_NVR);
            this.GroupBoxCond_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxCond_NVR.Location = new System.Drawing.Point(6, 12);
            this.GroupBoxCond_NVR.Name = "GroupBoxCond_NVR";
            this.GroupBoxCond_NVR.Size = new System.Drawing.Size(782, 191);
            this.GroupBoxCond_NVR.TabIndex = 0;
            this.GroupBoxCond_NVR.TabStop = false;
            this.GroupBoxCond_NVR.Text = "Условие";
            // 
            // PictureBoxFormula_NVR
            // 
            this.PictureBoxFormula_NVR.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFormula_NVR.Image")));
            this.PictureBoxFormula_NVR.Location = new System.Drawing.Point(347, 27);
            this.PictureBoxFormula_NVR.Name = "PictureBoxFormula_NVR";
            this.PictureBoxFormula_NVR.Size = new System.Drawing.Size(429, 44);
            this.PictureBoxFormula_NVR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxFormula_NVR.TabIndex = 1;
            this.PictureBoxFormula_NVR.TabStop = false;
            // 
            // TextBoxTask_NVR
            // 
            this.TextBoxTask_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxTask_NVR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_NVR.Location = new System.Drawing.Point(17, 34);
            this.TextBoxTask_NVR.Multiline = true;
            this.TextBoxTask_NVR.Name = "TextBoxTask_NVR";
            this.TextBoxTask_NVR.ReadOnly = true;
            this.TextBoxTask_NVR.Size = new System.Drawing.Size(324, 135);
            this.TextBoxTask_NVR.TabIndex = 0;
            this.TextBoxTask_NVR.TabStop = false;
            this.TextBoxTask_NVR.Text = "Вычислить выражение по формуле";
            // 
            // GroupBoxInput_NVR
            // 
            this.GroupBoxInput_NVR.Controls.Add(this.TextBoxVarX_NVR);
            this.GroupBoxInput_NVR.Controls.Add(this.LabelVarX_NVR);
            this.GroupBoxInput_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_NVR.Location = new System.Drawing.Point(6, 209);
            this.GroupBoxInput_NVR.Name = "GroupBoxInput_NVR";
            this.GroupBoxInput_NVR.Size = new System.Drawing.Size(507, 169);
            this.GroupBoxInput_NVR.TabIndex = 1;
            this.GroupBoxInput_NVR.TabStop = false;
            this.GroupBoxInput_NVR.Text = "Ввод данных";
            // 
            // TextBoxVarX_NVR
            // 
            this.TextBoxVarX_NVR.Location = new System.Drawing.Point(40, 112);
            this.TextBoxVarX_NVR.Name = "TextBoxVarX_NVR";
            this.TextBoxVarX_NVR.Size = new System.Drawing.Size(213, 36);
            this.TextBoxVarX_NVR.TabIndex = 1;
            this.TextBoxVarX_NVR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxVarX_NVR_KeyPress);
            // 
            // LabelVarX_NVR
            // 
            this.LabelVarX_NVR.AutoSize = true;
            this.LabelVarX_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVarX_NVR.Location = new System.Drawing.Point(36, 76);
            this.LabelVarX_NVR.Name = "LabelVarX_NVR";
            this.LabelVarX_NVR.Size = new System.Drawing.Size(140, 22);
            this.LabelVarX_NVR.TabIndex = 0;
            this.LabelVarX_NVR.Text = "Переменная X:";
            // 
            // GroupBoxOutput_NVR
            // 
            this.GroupBoxOutput_NVR.Controls.Add(this.TextBoxResult_NVR);
            this.GroupBoxOutput_NVR.Controls.Add(this.LabelResult_NVR);
            this.GroupBoxOutput_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_NVR.Location = new System.Drawing.Point(532, 209);
            this.GroupBoxOutput_NVR.Name = "GroupBoxOutput_NVR";
            this.GroupBoxOutput_NVR.Size = new System.Drawing.Size(256, 169);
            this.GroupBoxOutput_NVR.TabIndex = 2;
            this.GroupBoxOutput_NVR.TabStop = false;
            this.GroupBoxOutput_NVR.Text = "Вывод данных";
            // 
            // TextBoxResult_NVR
            // 
            this.TextBoxResult_NVR.Location = new System.Drawing.Point(10, 112);
            this.TextBoxResult_NVR.Name = "TextBoxResult_NVR";
            this.TextBoxResult_NVR.ReadOnly = true;
            this.TextBoxResult_NVR.Size = new System.Drawing.Size(219, 36);
            this.TextBoxResult_NVR.TabIndex = 2;
            // 
            // LabelResult_NVR
            // 
            this.LabelResult_NVR.AutoSize = true;
            this.LabelResult_NVR.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelResult_NVR.Location = new System.Drawing.Point(6, 76);
            this.LabelResult_NVR.Name = "LabelResult_NVR";
            this.LabelResult_NVR.Size = new System.Drawing.Size(110, 22);
            this.LabelResult_NVR.TabIndex = 1;
            this.LabelResult_NVR.Text = "Результат:";
            // 
            // ButtonDone_NVR
            // 
            this.ButtonDone_NVR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonDone_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDone_NVR.Location = new System.Drawing.Point(607, 384);
            this.ButtonDone_NVR.Name = "ButtonDone_NVR";
            this.ButtonDone_NVR.Size = new System.Drawing.Size(181, 54);
            this.ButtonDone_NVR.TabIndex = 4;
            this.ButtonDone_NVR.Text = "Выполнить";
            this.ButtonDone_NVR.UseVisualStyleBackColor = false;
            this.ButtonDone_NVR.Click += new System.EventHandler(this.ButtonDone_NVR_Click);
            // 
            // ButtonInfo_NVR
            // 
            this.ButtonInfo_NVR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonInfo_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfo_NVR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo_NVR.Location = new System.Drawing.Point(532, 384);
            this.ButtonInfo_NVR.Name = "ButtonInfo_NVR";
            this.ButtonInfo_NVR.Size = new System.Drawing.Size(69, 54);
            this.ButtonInfo_NVR.TabIndex = 5;
            this.ButtonInfo_NVR.Text = "?";
            this.ButtonInfo_NVR.UseVisualStyleBackColor = false;
            this.ButtonInfo_NVR.Click += new System.EventHandler(this.ButtonInfo_NVR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonInfo_NVR);
            this.Controls.Add(this.ButtonDone_NVR);
            this.Controls.Add(this.GroupBoxOutput_NVR);
            this.Controls.Add(this.GroupBoxInput_NVR);
            this.Controls.Add(this.GroupBoxCond_NVR);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 10 | Насырова В.Р.";
            this.GroupBoxCond_NVR.ResumeLayout(false);
            this.GroupBoxCond_NVR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFormula_NVR)).EndInit();
            this.GroupBoxInput_NVR.ResumeLayout(false);
            this.GroupBoxInput_NVR.PerformLayout();
            this.GroupBoxOutput_NVR.ResumeLayout(false);
            this.GroupBoxOutput_NVR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxCond_NVR;
        private System.Windows.Forms.TextBox TextBoxTask_NVR;
        private System.Windows.Forms.GroupBox GroupBoxInput_NVR;
        private System.Windows.Forms.GroupBox GroupBoxOutput_NVR;
        private System.Windows.Forms.PictureBox PictureBoxFormula_NVR;
        private System.Windows.Forms.TextBox TextBoxVarX_NVR;
        private System.Windows.Forms.Label LabelVarX_NVR;
        private System.Windows.Forms.Label LabelResult_NVR;
        private System.Windows.Forms.TextBox TextBoxResult_NVR;
        private System.Windows.Forms.Button ButtonDone_NVR;
        private System.Windows.Forms.Button ButtonInfo_NVR;
    }
}

