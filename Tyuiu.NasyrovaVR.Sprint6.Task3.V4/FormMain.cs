using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NasyrovaVR.Sprint6.Task3.V4.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -14, -7, 18, 12, -20 },
                                         { -2, -15, -19, -19, -3 },
                                         { -18, -5, -10, 14, -17 },
                                         { -1, 2, -10, 0, 11 },
                                         { 6, -18, 0, 19, 16 } };

        private void ButtonDone_NVR_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    DataGridView_NVR.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void ButtonInfo_NVR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-3 Насырова Влада Ренатовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            DataGridView_NVR.ColumnCount = columns;
            DataGridView_NVR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                DataGridView_NVR.Columns[i].Width = 60;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridView_NVR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
