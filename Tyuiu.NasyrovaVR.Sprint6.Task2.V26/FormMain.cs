using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NasyrovaVR.Sprint6.Task2.V26.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
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
                this.Chart_NVR.Titles.Add("График функции");
                this.Chart_NVR.ChartAreas[0].AxisX.Title = "Ось X";
                this.Chart_NVR.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len-1; i++)
                {
                    this.DataGridView_NVR.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.Chart_NVR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonDone_NVR_MouseEnter(object sender, EventArgs e)
        {
            ButtonDone_NVR.BackColor = Color.Red;
        }

        private void ButtonDone_NVR_MouseLeave(object sender, EventArgs e)
        {
            ButtonDone_NVR.BackColor = Color.Green;
        }

        private void ButtonDone_NVR_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonDone_NVR.BackColor = Color.Blue;
        }

        private void ButtonInfo_NVR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-3 Насырова Влада Ренатовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
