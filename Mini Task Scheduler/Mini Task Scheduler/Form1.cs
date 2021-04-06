using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Task_Scheduler
{
    public partial class MiniTaskSched : Form
    {
        public MiniTaskSched()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            messagetask mt = new messagetask();
            mt.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string title = clsMessage.Title;
            String trigger = clsMessage.Trigger;
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(trigger))
                return;
            ListViewItem item = new ListViewItem(title);
            item.SubItems.Add(trigger);
            lv_task.Items.Add(item);
           // sample.Text = title; // sample title nga makita sa label1

        }

        private void lv_task_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmailTask em = new EmailTask();
            em.ShowDialog();
        }
    }
}
