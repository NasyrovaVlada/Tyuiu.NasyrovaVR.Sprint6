﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.NasyrovaVR.Sprint6.Task6.V24
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void ButtonOk_NVR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
