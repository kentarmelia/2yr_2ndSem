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
    public partial class messagetask : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index=0; 
        public messagetask()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void messagetask_Load(object sender, EventArgs e)
        {
            btn_next.Enabled = false;
            listpanel.Add(p_create);
            listpanel.Add(p_trigger);
            listpanel.Add(p_daily);
            listpanel.Add(p_weekly);
            listpanel.Add(p_ot);
            listpanel.Add(p_dm);
            listpanel[index].BringToFront();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_OT_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tb_taskname_TextChanged(object sender, EventArgs e)
        { 
            if (tb_taskname.Text =="")
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }
        }
        private void tb_message_TextChanged(object sender, EventArgs e)
        {
            if (tb_message.Text == "")
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                if (index == 5 || index == 4 || index == 3)
                {
                    index = 2;
                }
                listpanel[--index].BringToFront();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            if (index < listpanel.Count-1) {
                if (index == 1)
                {
                    if (rb_daily.Checked)
                    {
                        index += 3;
                        listpanel[2].BringToFront();
                    }
                    if (rb_weekly.Checked)
                    {
                        index += 3;
                        listpanel[3].BringToFront();
                    }
                    if (rb_ot.Checked)
                    {
                        index += 3;
                        listpanel[4].BringToFront();
                    }
                }
                else
                {
                        listpanel[++index].BringToFront();            
                }
            }
            else
            {
                     btn_next.Text = "Finish";
                     title = tb_taskname.Text;
                     if (rb_daily.Checked)
                     {
                         trigger = "daily";
                         setDate = dateTimePicker1_daily.ToString();
                         setAlarm = dtp_daily.Value;
                         recurD = int.Parse(tb_recur.Text);
                     }
                     if (rb_weekly.Checked)
                     {
                         trigger = "weekly";
                         setDate = dtp1_weekly.ToString();
                         setAlarm = dtp2_weekly.Value;
                         recurW = int.Parse(tb_recurWeekly.Text);
                         for (int i = 0; i < clbDays.CheckedIndices.Count; i++)
                         {
                             day[i] = clbDays.CheckedIndices[i];
                         }
                     }
                     if (rb_ot.Checked)
                     {
                         trigger = "one time";
                         setDate = dtp1_ot.ToString();
                         setAlarm = dtp2_ot.Value;
                     }
                     
                     messTitle = tb_MTitle.Text;
                     description = tb_message.Text;
                
                clsMessage.Title = title;
                clsMessage.Trigger = trigger;
                clsMessage.SetDate = setDate;
                clsMessage.SetAlarm = setAlarm;
                clsMessage.RecurD = recurD;
                clsMessage.RecurW = recurW;
                clsMessage.Day = day;
                clsMessage.MessTitle = messTitle;
                clsMessage.Description = description;
                this.Hide();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_daily_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_weekly_CheckedChanged(object sender, EventArgs e)
        {

        }
        //daily task
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_daily_ValueChanged(object sender, EventArgs e)
        {

        }

        public static string title;
        public static string trigger;
        public static string setDate;
        public static DateTime setAlarm;
        public static int recurD;
        public static int recurW;
        public static int[] day = new int[6];
        public static string messTitle;
        public static string description;

        public int Day { get; private set; }

        

        private void label18_Click(object sender, EventArgs e)
        {

        }

       
    }
}
