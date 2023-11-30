using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NasyrovaVR.Sprint6.Task1.V7.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task1.V7
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
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                TextBoxResult_NVR.Text = "";
                TextBoxResult_NVR.AppendText("+----------+----------+" + Environment.NewLine);
                TextBoxResult_NVR.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                TextBoxResult_NVR.AppendText("+----------+----------+" + Environment.NewLine);
                for(int i = 0; i <= len-1; i++)
                {
                    strLine = String.Format("|{0,6:d}    |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    TextBoxResult_NVR.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                TextBoxResult_NVR.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonInfo_NVR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-23-3 Насырова Влада Ренатовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
