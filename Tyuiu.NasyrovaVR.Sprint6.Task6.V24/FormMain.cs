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

using Tyuiu.NasyrovaVR.Sprint6.Task6.V24.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Task6.V24
{
    public partial class FormMain_NVR : Form
    {
        public FormMain_NVR()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void ButtonDone_NVR_Click(object sender, EventArgs e)
        {
            TextBoxOutput_NVR.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void ButtonInfo_NVR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ButtonOpen_NVR_Click(object sender, EventArgs e)
        {
            OpenFileDialog_NVR.ShowDialog();
            openFilePath = OpenFileDialog_NVR.FileName;
            TextBoxInput_NVR.Text = File.ReadAllText(openFilePath);
            GroupBoxOutput_NVR.Text = GroupBoxOutput_NVR.Text + " " + OpenFileDialog_NVR.FileName;
            ButtonDone_NVR.Enabled = true;

        }
    }
}
