using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NasyrovaVR.Sprint6.Task5.V16.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"L:\Проги\DataSprint6\InPutFileTask5V16.txt";

        private void ButtonDone_NVR_Click(object sender, EventArgs e)
        {
            DataGridView_NVR.ColumnCount = 2;
            DataGridView_NVR.Columns[0].Width = 20;
            DataGridView_NVR.Columns[1].Width = 80;

            this.Chart_NVR.ChartAreas[0].AxisX.Title = "Ось X";
            this.Chart_NVR.ChartAreas[0].AxisY.Title = "Ось Y";
            Chart_NVR.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                DataGridView_NVR.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                Chart_NVR.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void ButtonOpen_NVR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void ButtonInfo_NVR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-3 Насырова Влада Ренатовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
