using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NasyrovaVR.Sprint6.Task4.V11.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task4.V11
{
    public partial class FormMain_NVR : Form
    {
        public FormMain_NVR()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void ButtonDone_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(TextBoxStart_NVR.Text);
                int stopStep = Convert.ToInt32(TextBoxStop_NVR.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.Chart_NVR.ChartAreas[0].AxisX.Title = "Ось X";
                this.Chart_NVR.ChartAreas[0].AxisY.Title = "Ось Y";

                TextBoxOutput_NVR.Text = "";

                Chart_NVR.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.Chart_NVR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    TextBoxOutput_NVR.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonInfo_NVR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-3 Насырова Влада Ренатовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonSave_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V11.txt";
                File.WriteAllText(path, TextBoxOutput_NVR.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();

                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
