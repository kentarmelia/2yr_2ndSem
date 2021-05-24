using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mini_Task_Scheduler
{
    public partial class EmailTask : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        List<Panel> listpanel = new List<Panel>();
        int index = 0;
        public EmailTask()
        {
            InitializeComponent();
             cn = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DBMessTask;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
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
                        btn_next.Show();
                        btn_finish.Hide();
                        listpanel[1].BringToFront();
                    }
                    if (rb_weekly.Checked)
                    {
                        index += 3;
                        btn_next.Show();
                        btn_finish.Hide();
                        listpanel[2].BringToFront();
                    }
                    if (rb_ot.Checked)
                    {
                        index += 3;
                        btn_next.Show();
                        btn_finish.Hide();
                        listpanel[3].BringToFront();
                    }
                }
                else
                {
                    if (index == 0)
                    {

                        listpanel[++index].BringToFront();
                    }
                    else
                    {
                        btn_next.Hide();
                        btn_finish.Show();
                        listpanel[++index].BringToFront();
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                if (index == 4||index == 3 || index == 2 || index == 1)
                {
                    btn_next.Show();
                    btn_finish.Hide();
                    index = 1;
                }
                listpanel[--index].BringToFront();
            }
        }

        private void EmailTask_Load(object sender, EventArgs e)
        {
            btn_finish.Hide();
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

        private void btn_finish_Click(object sender, EventArgs e)
        {
                cn.Open();
            cmd = new SqlCommand("addmessage");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            // MessageInfo.title = tb_taskname.Text;
            //   MessageInfo.Action = "Message";
            cmd.Parameters.AddWithValue("@Action", "Email");
            if (rb_daily.Checked)
            {
                int recur = int.Parse(tb_recur.Text);
                //  MessageInfo.trigger = "daily";
                cmd.Parameters.AddWithValue("@ntrigger", "Daily");
                //   MessageInfo.setDate = dateTimePicker1_daily.Value.ToString("MM-dd-yyyy");
                cmd.Parameters.AddWithValue("@setDate", dateTimePicker1_daily.Value.ToString("MM/dd/yyyy"));
                //   MessageInfo.setAlarm = dtp_daily.Value;
                cmd.Parameters.AddWithValue("@setalarm", dtp_daily.Value);
                //   MessageInfo.recurD = int.Parse(tb_recur.Text);
                cmd.Parameters.AddWithValue("@recurD", int.Parse(tb_recur.Text));
                cmd.Parameters.AddWithValue("@recurW", 0);
                cmd.Parameters.AddWithValue("@mon", 0);
                cmd.Parameters.AddWithValue("@tue", 0);
                cmd.Parameters.AddWithValue("@wed", 0);
                cmd.Parameters.AddWithValue("@thu", 0);
                cmd.Parameters.AddWithValue("@fri", 0);
                cmd.Parameters.AddWithValue("@sat", 0);
                cmd.Parameters.AddWithValue("@sun", 0);
                if (recur == 1)
                {
                    // MessageInfo.triggerview = "At " + dateTimePicker1_daily.Value.ToShortTimeString() + " every day";
                    cmd.Parameters.AddWithValue("@triggerview", "At " + dateTimePicker1_daily.Value.ToShortTimeString() + " every day");
                }
                else
                {
                    //  MessageInfo.triggerview = "At " + dateTimePicker1_daily.Value.ToShortTimeString() + " every " + recur + " days";
                    cmd.Parameters.AddWithValue("@triggerview", "At " + dateTimePicker1_daily.Value.ToShortTimeString() + " every " + recur + " days");

                }
            }
            if (rb_weekly.Checked)
            {
                String sun = "", mon = "", tue = "", wed = "", thu = "", fri = "", sat = "";
                int recur = int.Parse(tb_recurWeekly.Text);
                Boolean dsun = true, dmon = true, dtue = true, dwed = true, dthu = true, dfri = true, dsat = true;
                cmd.Parameters.AddWithValue("@ntrigger", "Weekly");
                cmd.Parameters.AddWithValue("@setDate", dtp1_weekly.Value.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@setalarm", dtp2_weekly.Value);
                cmd.Parameters.AddWithValue("@recurW", int.Parse(tb_recurWeekly.Text));
                cmd.Parameters.AddWithValue("@recurD", 0);
                int prev = 0;

                for (int i = 0; i < clbDays.CheckedIndices.Count; i++)
                {
                    // MessageInfo.Day[i] = clbDays.CheckedIndices[i];

                    if (clbDays.CheckedIndices[i] == 0)
                    {
                        dsun = false;
                        cmd.Parameters.AddWithValue("@sun", 1);
                        sun = "Sunday";
                        prev++;
                    }
                    else if (clbDays.CheckedIndices[i] == 1)
                    {
                        dmon = false;

                        if (1 != prev)
                        {
                            cmd.Parameters.AddWithValue("@mon", 1);
                            mon = " Monday";
                            prev = 2;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@mon", 1);
                            mon = ", Monday";
                        }
                    }
                    else if (clbDays.CheckedIndices[i] == 2)
                    {
                        dtue = false;
                        if (2 != prev && 2 != prev + 1)
                        {
                            cmd.Parameters.AddWithValue("@tue", 1);
                            tue = " Tuesday";
                            prev = 3;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@tue", 1);
                            tue = ", Tuesday";
                        }

                    }
                    else if (clbDays.CheckedIndices[i] == 3)
                    {
                        dwed = false;

                        if (3 != prev && 3 != prev + 2 && 3 != prev + 1)
                        {
                            cmd.Parameters.AddWithValue("@wed", 1);
                            wed = " Wednesday";
                            prev = 4;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@wed", 1);
                            wed = ", Wednesday";
                        }
                    }
                    else if (clbDays.CheckedIndices[i] == 4)
                    {
                        dthu = false;

                        if (4 != prev && 4 != prev + 3 && 4 != prev + 2 && prev != 1)
                        {
                            cmd.Parameters.AddWithValue("@thu", 1);

                            thu = " Thursday";
                            prev = 5;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@thu", 1);
                            thu = ", Thursday";

                        }
                    }
                    else if (clbDays.CheckedIndices[i] == 5)
                    {
                        dfri = false;

                        if (5 != prev && 5 != prev + 4 && 5 != prev + 3 && 5 != prev + 2 && 5 != prev + 1)
                        {
                            cmd.Parameters.AddWithValue("@fri", 1);
                            fri = " Friday";
                            prev = 6;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@fri", 1);
                            fri = ", Friday";

                        }

                    }
                    else if (clbDays.CheckedIndices[i] == 6)
                    {
                        dsat = false;

                        if (6 != prev && 6 != prev + 5 && 6 != prev + 4 && 6 != prev + 3 && 6 != prev + 2 && 6 != prev + 1)
                        {
                            cmd.Parameters.AddWithValue("@sat", 1);

                            sat = " Saturday";

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@sat", 1);
                            sat = ", Saturday";
                        }
                    }

                }
                if (dsun)
                {
                    cmd.Parameters.AddWithValue("@sun", 0);
                }
                if (dmon)
                {
                    cmd.Parameters.AddWithValue("@mon", 0);
                }
                if (dtue)
                {
                    cmd.Parameters.AddWithValue("@tue", 0);
                }
                if (dwed)
                {
                    cmd.Parameters.AddWithValue("@wed", 0);
                }
                if (dthu)
                {
                    cmd.Parameters.AddWithValue("@thu", 0);
                }
                if (dfri)
                {
                    cmd.Parameters.AddWithValue("@fri", 0);
                }

                if (dsat)
                {
                    cmd.Parameters.AddWithValue("@sat", 0);
                }

                if (recur == 1)
                {
                    //  MessageInfo.triggerview = "At " + dtp1_weekly.Value.ToShortTimeString() + " every " + sun + mon + tue + wed + thu + fri + sat + " of every week";
                    cmd.Parameters.AddWithValue("@triggerview", "At " + dtp1_weekly.Value.ToShortTimeString() + " every " + sun + mon + tue + wed + thu + fri + sat + " of every week");
                }
                else
                {
                    // MessageInfo.triggerview = "At " + dtp1_weekly.Value.ToShortTimeString() + " every " + sun + mon + tue + wed + thu + fri + sat + " every "+recur+" weeks";
                    cmd.Parameters.AddWithValue("@triggerview", "At " + dtp1_weekly.Value.ToShortTimeString() + " every " + sun + mon + tue + wed + thu + fri + sat + " every " + recur + " weeks");
                }


            }
            if (rb_ot.Checked)
            {
                // MessageInfo.trigger = "one time";
                cmd.Parameters.AddWithValue("@ntrigger", "One Time");
                //MessageInfo.setDate = dtp1_ot.Value.ToString("MM-dd-yyyy");
                cmd.Parameters.AddWithValue("@setDate", dtp1_ot.Value.ToString("MM/dd/yyyy"));
                //MessageInfo.setAlarm = dtp2_ot.Value;
                cmd.Parameters.AddWithValue("@setalarm", dtp2_ot.Value.ToString());
                //MessageInfo.triggerview = "At " +dtp2_ot.Value.ToShortTimeString()+" on "+ dtp1_ot.Value.ToShortDateString();
                cmd.Parameters.AddWithValue("@triggerview", "At " + dtp2_ot.Value.ToShortTimeString() + " on " + dtp1_ot.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@recurD", 0);
                cmd.Parameters.AddWithValue("@recurW", 0);
                cmd.Parameters.AddWithValue("@mon", 0);
                cmd.Parameters.AddWithValue("@tue", 0);
                cmd.Parameters.AddWithValue("@wed", 0);
                cmd.Parameters.AddWithValue("@thu", 0);
                cmd.Parameters.AddWithValue("@fri", 0);
                cmd.Parameters.AddWithValue("@sat", 0);
                cmd.Parameters.AddWithValue("@sun", 0);
            }
            
            //  MessageInfo.messTitle = tb_MTitle.Text;
            cmd.Parameters.AddWithValue("@title", tbSubject.Text);
            cmd.Parameters.AddWithValue("@messtitle", "Email message");
            //  MessageInfo.message = tb_message.Text;
            cmd.Parameters.AddWithValue("@message", tb_message.Text);
            //  MessageInfo.created = DateTime.Now.ToString();
            cmd.Parameters.AddWithValue("@created", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@emfrom", tbFrom.Text);
            cmd.Parameters.AddWithValue("@emto", tbTo.Text);
            cmd.Parameters.AddWithValue("@emserver", tbSmtp.Text);
            cmd.Parameters.AddWithValue("@empass", tbPass.Text);
            if (tb_attachment != null)
            {
                cmd.Parameters.AddWithValue("@emattach", tb_attachment.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@emattach",null);
            }
            cmd.ExecuteNonQuery();
            cn.Close();
                //showData();
               
                    this.Close();
          
        }

        private void tbFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                tbPass.Focus();
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                tbTo.Focus();
            }
        }

        private void tbTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                tbSubject.Focus();
            }
        }

        private void tbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                tb_message.Focus();
            }
        }

        private void tb_message_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btn_browse_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
