using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
namespace schedule
{
    public delegate void ToEditForm(string a, string b, string c);

    public partial class MainForm : Form
    {
        public static event ToEditForm ToEditForm;
        string fileName = "data";
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
            EditForm.ToMainEdit += new ToMainForm(editList);
            LoadData();
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
                
                textDay.Text = listView1.Items[indexNum].SubItems[0].Text;
                textContent.Text = listView1.Items[indexNum].SubItems[1].Text;
            }
            else
            {
                textDay.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm.ShowDialog();
        }
        public void addLIst(string a, string b,string c)
        {
            listView1.Items.Add(new ListViewItem(new string[] {a,b,c}));
            SaveData();
        }
        public void editList(string a, string b, string c)
        {
            toChange.SubItems[0].Text = a;
            toChange.SubItems[1].Text = b;
            toChange.SubItems[2].Text = c;
            SaveData();

        }

        private void linkButton_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                int indexNum;
                indexNum = listView1.FocusedItem.Index;
                string test = listView1.Items[indexNum].SubItems[2].Text;
                System.Diagnostics.Process.Start(test);
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                listView1.Items.Remove(listView1.FocusedItem);
                listView1.FocusedItem = null;
                SaveData();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            toChange = listView1.FocusedItem;
            if (toChange != null)
            {
                ToEditForm(toChange.SubItems[0].Text, toChange.SubItems[1].Text, toChange.SubItems[2].Text);

                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("먼저 바꿀것을 선택 해 주세요");
            }
        }
        private void LoadData()

        {

            using (TextReader tReader = new StreamReader(fileName))

            {
                string[] stringLines

                    = tReader.ReadToEnd().Replace("\n", "").Split((char)System.Windows.Forms.Keys.Enter);


                
                foreach (string stringLine in stringLines)

                {
                    if (stringLine != string.Empty)

                    {
                        string[] stringArray = stringLine.Split(';');

                        
                        ListViewItem item = new ListViewItem(stringArray[0]);

                        item.SubItems.Add(stringArray[1]);

                        item.SubItems.Add(stringArray[2]);
                        
                        listView1.Items.Add(item);

                    }

                }

            }

        }
        private void SaveData()

        {


            // StreamWriter를 이용하여 문자작성기를 생성합니다.

            using (TextWriter tWriter = new StreamWriter(fileName))

            {

                // ListView의 Item을 하나씩 가져와서..

                foreach (ListViewItem item in listView1.Items)

                {

                    // 원하는 형태의 문자열로 한줄씩 기록합니다.

                    tWriter.WriteLine(string.Format("{0};{1};{2}"

                        , item.Text, item.SubItems[1].Text, item.SubItems[2].Text));

                }
                tWriter.Close();
            }
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indexNum;
            indexNum = listView1.FocusedItem.Index;
            string test = listView1.Items[indexNum].SubItems[2].Text;
            System.Diagnostics.Process.Start(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String path = "https://jasoseol.com/recruit/37471";

            using (WebClient client = new WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;
                string data = client.DownloadString(path);
                try
                {
                    JArray jarr = JArray.Parse(data);
                    foreach (JObject jobj in jarr)
                    {
                        MessageBox.Show("{ key.rank}");
                    }
                }
                catch(Exception ex) { }
               
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
