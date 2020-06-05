using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        int tCounter = 100;
        public Form1()
        {
            InitializeComponent();
           

        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] {tCounter.ToString(), "100" }));
            tCounter += new Random().Next(-100, 100);
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexNum;
            indexNum = listView1.FocusedItem.Index;
            string test = listView1.Items[indexNum].SubItems[0].Text;
            textBox1.Text = test;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.ListViewItemSorter = new ListViewItemComparer();
            listView1.Sort();
        }
    }

    class ListViewItemComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[0].Text, ((ListViewItem)y).SubItems[0].Text);
        }
    }
}
