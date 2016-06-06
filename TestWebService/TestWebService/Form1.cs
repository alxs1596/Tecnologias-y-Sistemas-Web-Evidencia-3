using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            UserData data = ForumApiClient.GetUser(textBox1.Text);
            listView1.Items.Add(data.id.ToString());
            listView1.Items.Add(data.firstname);
            listView1.Items.Add(data.lastname);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            UsersData data = ForumApiClient.GetUsers();
            foreach (List item in data.list)
            {
                ListViewItem lvitem = new ListViewItem();
                lvitem.SubItems.Add(item.id.ToString());
                lvitem.SubItems.Add(item.firstname);
                lvitem.SubItems.Add(item.lastname);
                listView2.Items.Add(lvitem);
            }
        }
    }
}
