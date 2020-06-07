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
    public partial class MainForm : Form
    {
        int tCounter = 100;
        AddForm addForm = new AddForm();
        EditForm editForm = new EditForm();
        ListViewItem toChange;

        public MainForm()
        {
            InitializeComponent();

            listView1.ListViewItemSorter = new ListViewItemComparer();
            listView1.Sort();
            AddForm.ToMainForm += new ToMainForm(addLIst);
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] {tCounter.ToString(), "100","as" }));
            tCounter += new Random().Next(-100, 100);
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexNum;
            indexNum = listView1.FocusedItem.Index;
            if (indexNum >= 0)
            {
                string test = listView1.Items[indexNum].SubItems[0].Text;
                textBox1.Text = test;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            addForm.ShowDialog();
        }
        public void addLIst(string a, string b,string c)
        {
            listView1.Items.Add(new ListViewItem(new string[] {a,b,c}));
        }

        private void linkButton_Click(object sender, EventArgs e)
        {
            int indexNum;
            indexNum = listView1.FocusedItem.Index;
            string test = listView1.Items[indexNum].SubItems[2].Text;
            System.Diagnostics.Process.Start(test);
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.FocusedItem);
            listView1.FocusedItem = null;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            toChange = listView1.FocusedItem;
            if (toChange != null)
            {
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("먼저 바꿀것을 선택 해 주세요");
            }
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
