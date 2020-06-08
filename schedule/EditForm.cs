﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule
{
    public delegate void ToMainEdit(string a, string b, string c);
    public partial class EditForm : Form
    {
        public static event ToMainForm ToMainEdit;
        public EditForm()
        {
            InitializeComponent();
            MainForm.ToEditForm += new ToEditForm(editList);

        }
        
        private void editList(string a, string b, string c)
        {
            ThreadPool.QueueUserWorkItem((state) =>
            {
                Thread.Sleep(100);

                year.Text = a.Substring(0,4);
                month.Text = a.Substring(5,2);
                date.Text = a.Substring(8,2);
                time.Text = a.Substring(11, 2);
                content.Text = b;
                link.Text = c;
                // CAUTION: use Invoke where necessary
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool fail = false;
            string dateSet;
            string y, m, d, t;
            int yy, mm, dd, tt;
            int temp;
            y = year.Text; m = month.Text; d = date.Text; t = time.Text;
            if (!int.TryParse(y, out yy))
            {
                MessageBox.Show("연도를 확인해주세요");
                fail = true;
            }
            else
            {
                if (yy > 10 && yy < 100)
                {
                    y = "20" + yy.ToString();
                }
                else if (yy < 2000 || yy > 3000)
                {
                    MessageBox.Show("연도를 확인해주세요");
                    fail = true;
                }
            }
            if (!int.TryParse(m, out mm) && !fail)
            {
                MessageBox.Show("월을 확인해주세요");
                fail = true;
            }
            else
            {
                if (!fail)
                {
                    if (mm >= 1 && mm <= 9)
                    {
                        m = "0" + mm.ToString();
                    }
                    else if (mm < 10 || mm > 12)
                    {
                        MessageBox.Show("월을 확인해주세요");
                        fail = true;
                    }
                }
            }

            if (!int.TryParse(d, out dd) && !fail)
            {
                MessageBox.Show("일을 확인해주세요");
                fail = true;
            }
            else
            {
                if (!fail)
                {
                    if (dd >= 1 && dd <= 9)
                    {
                        d = "0" + dd.ToString();
                    }
                    else if (dd < 0 || dd > 31)
                    {
                        MessageBox.Show("일을 확인해주세요");
                        fail = true;
                    }
                }
            }

            if (!int.TryParse(t, out tt) && !fail)
            {
                MessageBox.Show("시간을 확인해주세요");
                fail = true;
            }
            else
            {
                if (!fail)
                {
                    if (tt >= 1 && tt <= 9)
                    {
                        t = "0" + tt.ToString();
                    }
                    else if (tt < 10 || tt > 24)
                    {
                        MessageBox.Show("시간을 확인해주세요");
                        fail = true;
                    }
                }
            }

            if (!fail)
            {
                dateSet = y + "." + m + "." + d + "-" + t;
                ToMainEdit(dateSet, content.Text, link.Text);
                EndForm();

            }
        }
        private void EndForm()
        {
            month.Text = "";
            date.Text = "";
            time.Text = "";
            content.Text = "";
            link.Text = "";
            this.Close();
        }
        private void cancleButton_Click(object sender, EventArgs e)
        {

            EndForm();
        }
    }
}
