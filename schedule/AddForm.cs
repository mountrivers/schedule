﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule
{
    public delegate void ToMainForm(string a, string b);
    public partial class AddForm : Form
    {
        public static event ToMainForm ToMainForm;
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToMainForm(year.Text, month.Text);
            EndForm(); 
        }

        private void EndForm()
        {
            year.Text = "";
            month.Text = "";
            this.Close();
        }
    }
}
