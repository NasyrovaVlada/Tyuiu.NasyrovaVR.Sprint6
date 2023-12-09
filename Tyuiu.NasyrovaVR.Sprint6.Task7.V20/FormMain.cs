using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.NasyrovaVR.Sprint6.Task7.V20.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task7.V20
{
    public partial class FormMain_NVR : Form
    {
        public FormMain_NVR()
        {
            InitializeComponent();

            OpenFileDialog_NVR.Filter = "Значения, разделененые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            SaveFileDialog_NVR.Filter = "Значения, разделененые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_m = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_m[j]);
                }
            }
            return arrayValues;
        }

        private void ButtonOpen_NVR_Click(object sender, EventArgs e)
        {
            OpenFileDialog_NVR.ShowDialog();
            openFilePath = OpenFileDialog_NVR.FileName;

            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            DataGridViewInput_NVR.ColumnCount = colums;
            DataGridViewInput_NVR.RowCount = rows;
            DataGridViewOutput_NVR.ColumnCount = colums;
            DataGridViewOutput_NVR.RowCount = rows;

            //ширина столбцов
            for (int i = 0;i < rows; i++)
            {
                DataGridViewInput_NVR.Columns[i].Width = 50;
                DataGridViewOutput_NVR.Columns[i].Width = 50;
            }

            //добавление данных
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    DataGridViewInput_NVR.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            ButtonDone_NVR.Enabled = true;
        }

        private void ButtonDone_NVR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for(int i = 0; i<rows; i++)
            {
                for(int j = 0;j<colums; j++)
                {
                    DataGridViewOutput_NVR.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            ButtonSave_NVR.Enabled = true;
        }

        private void ButtonSave_NVR_Click(object sender, EventArgs e)
        {
            SaveFileDialog_NVR.FileName = "OutPutFileTask7V20.csv";
            SaveFileDialog_NVR.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialog_NVR.ShowDialog();

            string path = SaveFileDialog_NVR.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = DataGridViewOutput_NVR.RowCount;
            int colums = DataGridViewOutput_NVR.ColumnCount;

            string str = "";
            for(int i = 0;i<rows;i++)
            {
                for(int j = 0; j<colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + DataGridViewOutput_NVR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + DataGridViewOutput_NVR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void ButtonOpen_NVR_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_NVR.ToolTipTitle = "Открыть файл";
        }

        private void ButtonDone_NVR_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_NVR.ToolTipTitle = "Выполнить";
        }

        private void ButtonSave_NVR_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_NVR.ToolTipTitle = "Сохранить в файл";
        }

        private void ButtonInfo_NVR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
