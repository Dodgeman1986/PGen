﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pGen.UI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e) => Close();
    }
}