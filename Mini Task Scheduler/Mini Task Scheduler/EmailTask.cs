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
    public partial class EmailTask : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index = 0;
        public EmailTask()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
            {
                if (index == 0)
                {
                    if (rb_daily.Checked)
                    {
                        index += 3;
                        listpanel[1].BringToFront();
                    }
                    if (rb_weekly.Checked)
                    {
                        index += 3;
                        listpanel[2].BringToFront();
                    }
                    if (rb_ot.Checked)
                    {
                        index += 3;
                        listpanel[3].BringToFront();
                    }
                }
                else
                {
                    listpanel[++index].BringToFront();
                }
            }
            else
            {
                this.Hide();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                if (index == 4||index == 3 || index == 2 || index == 1)
                {
                    index = 1;
                }
                listpanel[--index].BringToFront();
            }
        }

        private void EmailTask_Load(object sender, EventArgs e)
        {
            
            listpanel.Add(p_trigger);
            listpanel.Add(p_daily);
            listpanel.Add(p_weekly);
            listpanel.Add(p_ot);
            listpanel.Add(p_SEmail);
            listpanel[index].BringToFront();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void p_create_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_dm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                tb_attachment.Text = dlg.FileName.ToString();
            }
        }
    }
}
