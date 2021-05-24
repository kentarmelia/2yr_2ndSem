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
using System.Timers;
using System.Net;
using System.Net.Mail;

namespace Mini_Task_Scheduler
{
    public partial class MiniTaskSched : Form
    {
        
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        clsMessage clsm = new clsMessage();
        clsEmail clse = new clsEmail();
        string mtitle;
        string mdate;
        string mtrigger;
        string mtime;
        string maction;
        string mrecurD;
        string mrecurW;
        string mmon;
        string mtue;
        string mwed;
        string mthu;
        string mfri;
        string msat;
        string msun;
        string mmesstitle;
        string mmessage;
        string mfrom;
        string mto;
        string mserver;
        string mpass;
        string mattach;
        string[] gettitle;
        string[] getdate;
        string[] gettrigger;
        string[] gettime;
        string[] getaction;
        string[] getrecurD;
        string[] getrecurW;
        string[] getmon;
        string[] gettue;
        string[] getwed;
        string[] getthu;
        string[] getfri;
        string[] getsat;
        string[] getsun;
        string[] getmesstitle;
        string[] getmessage;
        string[] getfrom;
        string[] getto;
        string[] getserver;
        string[] getpass;
        string[] getattach;
        public MiniTaskSched()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DBMessTask;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            showData();
        }
        void showData()
        {
            cn.Open();
            cmd = new SqlCommand("viewMessage");
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "viewMessage");
            dataGridView.DataSource = ds.Tables[0];
            cn.Close();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             
        }


        private void button1_Click(object sender, EventArgs e)
        {
            messagetask mt = new messagetask();
            mt.ShowDialog();
            
               showData();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //btnProperties
        {
            AboutUs au = new AboutUs();
            au.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.Parse("05/18/2021");
            DateTime curtime = DateTime.Now;
            DateTime usertime = DateTime.Parse("13:51:00");
            /*
            if (dt.Date == dt2.Date)
            {
                if (curtime.Hour == usertime.Hour && curtime.Minute == usertime.Minute && curtime.Second == usertime.Second)
                {
                    MessageBox.Show("ok");
                }
            }
            */
        }
        private void lv_task_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmailTask em = new EmailTask();
            em.ShowDialog();
            showData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            cmd = new SqlCommand("deleteRecord");
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@title", label.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            showData();
           
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView.CurrentRow.Selected = true;
                    label.Text = dataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    mtitle = dataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    mdate = dataGridView.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    mtrigger = dataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    mtime = dataGridView.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    maction = dataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    mrecurD = dataGridView.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    mrecurW = dataGridView.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                    mmon = dataGridView.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                    mtue = dataGridView.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
                    mwed = dataGridView.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
                    mthu = dataGridView.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();
                    mfri = dataGridView.Rows[e.RowIndex].Cells[15].FormattedValue.ToString();
                    msat = dataGridView.Rows[e.RowIndex].Cells[16].FormattedValue.ToString();
                    msun = dataGridView.Rows[e.RowIndex].Cells[17].FormattedValue.ToString();
                    mmesstitle = dataGridView.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                    mmessage = dataGridView.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                    mfrom = dataGridView.Rows[e.RowIndex].Cells[18].FormattedValue.ToString();
                    mto = dataGridView.Rows[e.RowIndex].Cells[19].FormattedValue.ToString();
                    mserver = dataGridView.Rows[e.RowIndex].Cells[20].FormattedValue.ToString();
                    mpass = dataGridView.Rows[e.RowIndex].Cells[21].FormattedValue.ToString();
                    mattach= dataGridView.Rows[e.RowIndex].Cells[22].FormattedValue.ToString();
                }
            }catch(Exception ex){
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTime currenttime = DateTime.Now;
            lbl_Time.Text = DateTime.Now.ToLongTimeString();

            gettitle = new string[dataGridView.Columns.Count];
            getdate = new string[dataGridView.Columns.Count];
            gettrigger = new string[dataGridView.Columns.Count];
            gettime = new string[dataGridView.Columns.Count];
            getaction = new string[dataGridView.Columns.Count];
            getrecurD = new string[dataGridView.Columns.Count];
            getrecurW = new string[dataGridView.Columns.Count];
            getmon = new string[dataGridView.Columns.Count];
            gettue = new string[dataGridView.Columns.Count];
            getwed = new string[dataGridView.Columns.Count];
            getthu = new string[dataGridView.Columns.Count];
            getfri = new string[dataGridView.Columns.Count];
            getsat = new string[dataGridView.Columns.Count];
            getsun = new string[dataGridView.Columns.Count];
            getmesstitle = new string[dataGridView.Columns.Count];
            getmessage = new string[dataGridView.Columns.Count];
            getfrom = new string[dataGridView.Columns.Count];
            getto = new string[dataGridView.Columns.Count];
            getserver = new string[dataGridView.Columns.Count];
            getpass = new string[dataGridView.Columns.Count];
            getattach = new string[dataGridView.Columns.Count];

                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                gettitle[i] = dataGridView.Rows[i].Cells[0].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getdate[i] = dataGridView.Rows[i].Cells[5].Value.ToString().Trim();
                
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                gettrigger[i] = dataGridView.Rows[i].Cells[2].Value.ToString().Trim();
               
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                gettime[i] = dataGridView.Rows[i].Cells[6].Value.ToString().Trim();
                
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
               getaction[i] = dataGridView.Rows[i].Cells[1].Value.ToString().Trim();
                
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getrecurD[i] = dataGridView.Rows[i].Cells[7].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getrecurW[i] = dataGridView.Rows[i].Cells[8].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
               getmon[i] = dataGridView.Rows[i].Cells[11].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                gettue[i] = dataGridView.Rows[i].Cells[12].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getwed[i] = dataGridView.Rows[i].Cells[13].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getthu[i] = dataGridView.Rows[i].Cells[14].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getfri[i] = dataGridView.Rows[i].Cells[15].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getsat[i] = dataGridView.Rows[i].Cells[16].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getsun[i] = dataGridView.Rows[i].Cells[17].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getmesstitle[i] = dataGridView.Rows[i].Cells[9].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
               getmessage[i] = dataGridView.Rows[i].Cells[10].Value.ToString().Trim();
            }           
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getfrom[i] = dataGridView.Rows[i].Cells[18].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getto[i] = dataGridView.Rows[i].Cells[19].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getserver[i] = dataGridView.Rows[i].Cells[20].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getpass[i] = dataGridView.Rows[i].Cells[21].Value.ToString().Trim();
            }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                getattach[i] = dataGridView.Rows[i].Cells[22].Value.ToString().Trim();
            }


            for (int i = 0;i <dataGridView.Rows.Count; i++)
            {
                Application.DoEvents();
                //----------------------------------------------------------MESSAGE-------------------------------------------------
                if (getaction[i] == "Message")
                {
                    if (gettrigger[i] == "One Time")
                    {
                    //   MessageBox.Show(getdate[i] + " == " + DateTime.Now.ToString("MM/dd/yyyy"));
                        if (gettime[i] == DateTime.Now.ToString("HH:mm:ss")&& getdate[i] == DateTime.Now.ToString("MM/dd/yyyy")) 
                        {
                            MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                        }
                        
                    }
                    else if(gettrigger[i] == "Daily")
                    {
                     //  MessageBox.Show(getdate[i] + " == " + DateTime.Now.ToShortDateString());
                        if (gettime[i] == DateTime.Now.ToString("HH:mm:ss") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy"))
                        {
                            MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                            DateTime d = DateTime.Now;
                            string newday;         
                            newday = d.AddDays(int.Parse(getrecurD[i])).ToString();
                            cn.Open();
                            cmd.Connection = cn;
                            cmd = new SqlCommand("update message set ntrigger ='"+gettrigger[i]+ "',action= '"+getaction[i]+ "',setDate= '"+newday.ToString()+ "',setAlarm='"+gettime[i]+ "',recurD = '"+getrecurD[i]+ "',recurW= '"+getrecurW[i]+ "',mon= '"+getmon[i]+ "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "',emfrom ='"+getfrom[i]+"',emto = '"+getto[i]+"',emserver = '"+getserver[i]+"',empass='"+getpass[i]+"',emattach ='"+getattach[i]+"' where title ='"+gettitle[i]+"'",cn);                
                            cmd.ExecuteNonQuery();
                            cn.Close();


                        }

                    }
                    else
                    {
                        DateTime d = DateTime.Now;
                      int NumWeek = int.Parse(getrecurW[i]);
                      int WeekNow = NumWeek*7;
                     //   Boolean recurnow = true;
                        string monday = "Monday", tuesday="Tuesday", wednesday="Wednesday", thursday="Thursday", friday="Friday", saturday="Saturday", sunday="Sunday";
                        string mon="",tue="",wed="",thu="",fri="",sat="",sun="";
 
                        if (getmon[i].ToString() == "1")
                        {
                            mon = monday;
                        }
                        if (gettue[i].ToString() == "1")
                        {
                            tue = tuesday;
                        }
                        if (getwed[i].ToString() == "1")
                        {
                            wed = wednesday;
                        }
                        if (getthu[i].ToString() == "1")
                        {
                            thu = thursday;
                        }
                        if (getfri[i].ToString() == "1")
                        {
                            fri = friday;
                        }
                        if (getsat[i].ToString() == "1")
                        {
                            sat = saturday;
                        }
                        if (getsun[i].ToString() == "1")
                        {
                            sun = sunday;
                        }
                        //MessageBox.Show((thu + " == Thursday  ||" + d.DayOfWeek.ToString() + " == Thursday  ||") + getdate[i] +" == "+ DateTime.Now.ToString("MM/dd/yyyy"));

                            Application.DoEvents();
                            if ((mon == "Monday" && d.DayOfWeek.ToString() == "Monday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy")&& gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                            {
                                MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                                
                            }
                            if ((tue == "Tuesday" && d.DayOfWeek.ToString() == "Tuesday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                            {
                                MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                                
                            }
                            if ((wed == "Wednesday" && d.DayOfWeek.ToString() == "Wednesday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                            {
                                MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                                
                            }
                            if ((thu == "Thursday" && d.DayOfWeek.ToString() == "Thursday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                            {
                                MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                                
                            }
                            if ((fri == "Friday" && d.DayOfWeek.ToString() == "Friday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                            {
                                MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                                
                            }
                            if ((sat == "Saturday" && d.DayOfWeek.ToString() == "Saturday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                            {
                                MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                                
                            }
                            if ((sun == "Sunday" && d.DayOfWeek.ToString() == "Sunday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                            {
                                MessageBox.Show(getmessage[i], getmesstitle[i], MessageBoxButtons.OK);
                            }
                        if (DateTime.Now.ToString("HH/mm/ss") == "23/59/59")
                        {
                            if (sun == "Sunday")
                            {
                                if (getrecurW[i] != "1")
                                {
                                    DateTime dt1 = DateTime.Now;
                                    string newday;
                                    newday = dt1.AddDays(WeekNow).ToString();
                                    cn.Open();
                                    cmd.Connection = cn;
                                    cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "',emfrom ='" + getfrom[i] + "',emto = '" + getto[i] + "',emserver = '" + getserver[i] + "',empass='" + getpass[i] + "',emattach ='" + getattach[i] + "' where title ='" + gettitle[i] + "'", cn);
                                    cmd.ExecuteNonQuery();
                                    cn.Close();
                                }
                                else
                                {
                                    DateTime dt2 = DateTime.Now;
                                    string newday;
                                    newday = dt2.AddDays(1).ToString();
                                    cn.Open();
                                    cmd.Connection = cn;
                                    cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "',emfrom ='" + getfrom[i] + "',emto = '" + getto[i] + "',emserver = '" + getserver[i] + "',empass='" + getpass[i] + "',emattach ='" + getattach[i] + "' where title ='" + gettitle[i] + "'", cn);
                                    cmd.ExecuteNonQuery();
                                    cn.Close();
                                }
                            }
                            else
                            {
                                DateTime dt = DateTime.Now;
                                string newday;
                                newday = dt.AddDays(1).ToString();
                                cn.Open();
                                cmd.Connection = cn;
                                cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "',emfrom ='" + getfrom[i] + "',emto = '" + getto[i] + "',emserver = '" + getserver[i] + "',empass='" + getpass[i] + "',emattach ='" + getattach[i] + "' where title ='" + gettitle[i] + "'", cn);
                                cmd.ExecuteNonQuery();
                                cn.Close();
                            }                        
                        }    
                      
                    }

                }
                else //---------------------------------------------------------------------------EMAIL -------------------------------------------------------------------------------------------------------------
                {
                    if (gettrigger[i] == "One Time")
                    {
                        //   MessageBox.Show(getdate[i] + " == " + DateTime.Now.ToString("MM/dd/yyyy"));
                        if (gettime[i] == DateTime.Now.ToString("HH:mm:ss") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend="";
                            Boolean isTo = false;
                           // MessageBox.Show("it show");
                            for (int j = 0;j < multiTo.Length;j++) 
                            {
                               // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if(multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                        MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                        if (!string.IsNullOrEmpty(getattach[i]))
                                        {
                                            mail.Attachments.Add(new Attachment(getattach[i]));
                                        }
                                        SmtpClient client = new SmtpClient(getserver[i]);
                                        client.Port = 587;
                                        client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                        client.EnableSsl = true;
                                        client.Send(mail);
                                        multiToSend = "";
                                        multiTo2.Remove(0, multiTo2.Length);
                                        isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);
                        }

                    }
                    else if (gettrigger[i] == "Daily")
                    {
                        //  MessageBox.Show(getdate[i] + " == " + DateTime.Now.ToShortDateString());
                        if (gettime[i] == DateTime.Now.ToString("HH:mm:ss") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend = "";
                            Boolean isTo = false;
                            // MessageBox.Show("it show");
                            for (int j = 0; j < multiTo.Length; j++)
                            {
                                // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if (multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                    // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                    MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                    if (!string.IsNullOrEmpty(getattach[i]))
                                    {
                                        mail.Attachments.Add(new Attachment(getattach[i]));
                                    }
                                    SmtpClient client = new SmtpClient(getserver[i]);
                                    client.Port = 587;
                                    client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                    client.EnableSsl = true;
                                    client.Send(mail);
                                    multiToSend = "";
                                    multiTo2.Remove(0, multiTo2.Length);
                                    isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);
                            DateTime d = DateTime.Now;
                            string newday;
                            newday = d.AddDays(int.Parse(getrecurD[i])).ToString();
                            cn.Open();
                            cmd.Connection = cn;
                            cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "',emfrom ='" + getfrom[i] + "',emto = '" + getto[i] + "',emserver = '" + getserver[i] + "',empass='" + getpass[i] + "',emattach ='" + getattach[i] + "' where title ='" + gettitle[i] + "'", cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }

                    }
                    else
                    {
                        DateTime d = DateTime.Now;
                        int NumWeek = int.Parse(getrecurW[i]);
                        int WeekNow = NumWeek * 7;
                        //   Boolean recurnow = true;
                        string monday = "Monday", tuesday = "Tuesday", wednesday = "Wednesday", thursday = "Thursday", friday = "Friday", saturday = "Saturday", sunday = "Sunday";
                        string mon = "", tue = "", wed = "", thu = "", fri = "", sat = "", sun = "";

                        if (getmon[i].ToString() == "1")
                        {
                            mon = monday;
                        }
                        if (gettue[i].ToString() == "1")
                        {
                            tue = tuesday;
                        }
                        if (getwed[i].ToString() == "1")
                        {
                            wed = wednesday;
                        }
                        if (getthu[i].ToString() == "1")
                        {
                            thu = thursday;
                        }
                        if (getfri[i].ToString() == "1")
                        {
                            fri = friday;
                        }
                        if (getsat[i].ToString() == "1")
                        {
                            sat = saturday;
                        }
                        if (getsun[i].ToString() == "1")
                        {
                            sun = sunday;
                        }
                        //MessageBox.Show((thu + " == Thursday  ||" + d.DayOfWeek.ToString() + " == Thursday  ||") + getdate[i] +" == "+ DateTime.Now.ToString("MM/dd/yyyy"));

                        Application.DoEvents();
                        if ((mon == "Monday" && d.DayOfWeek.ToString() == "Monday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend = "";
                            Boolean isTo = false;
                            // MessageBox.Show("it show");
                            for (int j = 0; j < multiTo.Length; j++)
                            {
                                // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if (multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                    // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                    MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                    if (!string.IsNullOrEmpty(getattach[i]))
                                    {
                                        mail.Attachments.Add(new Attachment(getattach[i]));
                                    }
                                    SmtpClient client = new SmtpClient(getserver[i]);
                                    client.Port = 587;
                                    client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                    client.EnableSsl = true;
                                    client.Send(mail);
                                    multiToSend = "";
                                    multiTo2.Remove(0, multiTo2.Length);
                                    isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);
                        }
                        if ((tue == "Tuesday" && d.DayOfWeek.ToString() == "Tuesday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend = "";
                            Boolean isTo = false;
                            // MessageBox.Show("it show");
                            for (int j = 0; j < multiTo.Length; j++)
                            {
                                // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if (multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                    // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                    MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                    if (!string.IsNullOrEmpty(getattach[i]))
                                    {
                                        mail.Attachments.Add(new Attachment(getattach[i]));
                                    }
                                    SmtpClient client = new SmtpClient(getserver[i]);
                                    client.Port = 587;
                                    client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                    client.EnableSsl = true;
                                    client.Send(mail);
                                    multiToSend = "";
                                    multiTo2.Remove(0, multiTo2.Length);
                                    isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);

                        }
                        if ((wed == "Wednesday" && d.DayOfWeek.ToString() == "Wednesday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend = "";
                            Boolean isTo = false;
                            // MessageBox.Show("it show");
                            for (int j = 0; j < multiTo.Length; j++)
                            {
                                // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if (multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                    // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                    MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                    if (!string.IsNullOrEmpty(getattach[i]))
                                    {
                                        mail.Attachments.Add(new Attachment(getattach[i]));
                                    }
                                    SmtpClient client = new SmtpClient(getserver[i]);
                                    client.Port = 587;
                                    client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                    client.EnableSsl = true;
                                    client.Send(mail);
                                    multiToSend = "";
                                    multiTo2.Remove(0, multiTo2.Length);
                                    isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);

                        }
                        if ((thu == "Thursday" && d.DayOfWeek.ToString() == "Thursday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend = "";
                            Boolean isTo = false;
                            // MessageBox.Show("it show");
                            for (int j = 0; j < multiTo.Length; j++)
                            {
                                // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if (multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                    // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                    MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                    if (!string.IsNullOrEmpty(getattach[i]))
                                    {
                                        mail.Attachments.Add(new Attachment(getattach[i]));
                                    }
                                    SmtpClient client = new SmtpClient(getserver[i]);
                                    client.Port = 587;
                                    client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                    client.EnableSsl = true;
                                    client.Send(mail);
                                    multiToSend = "";
                                    multiTo2.Remove(0, multiTo2.Length);
                                    isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);

                        }
                        if ((fri == "Friday" && d.DayOfWeek.ToString() == "Friday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend = "";
                            Boolean isTo = false;
                            // MessageBox.Show("it show");
                            for (int j = 0; j < multiTo.Length; j++)
                            {
                                // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if (multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                    // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                    MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                    if (!string.IsNullOrEmpty(getattach[i]))
                                    {
                                        mail.Attachments.Add(new Attachment(getattach[i]));
                                    }
                                    SmtpClient client = new SmtpClient(getserver[i]);
                                    client.Port = 587;
                                    client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                    client.EnableSsl = true;
                                    client.Send(mail);
                                    multiToSend = "";
                                    multiTo2.Remove(0, multiTo2.Length);
                                    isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);

                        }
                        if ((sat == "Saturday" && d.DayOfWeek.ToString() == "Saturday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend = "";
                            Boolean isTo = false;
                            // MessageBox.Show("it show");
                            for (int j = 0; j < multiTo.Length; j++)
                            {
                                // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if (multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                    // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                    MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                    if (!string.IsNullOrEmpty(getattach[i]))
                                    {
                                        mail.Attachments.Add(new Attachment(getattach[i]));
                                    }
                                    SmtpClient client = new SmtpClient(getserver[i]);
                                    client.Port = 587;
                                    client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                    client.EnableSsl = true;
                                    client.Send(mail);
                                    multiToSend = "";
                                    multiTo2.Remove(0, multiTo2.Length);
                                    isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);

                        }
                        if ((sun == "Sunday" && d.DayOfWeek.ToString() == "Sunday") && getdate[i] == DateTime.Now.ToString("MM/dd/yyyy") && gettime[i] == DateTime.Now.ToString("HH:mm:ss"))
                        {
                            Application.DoEvents();
                            StringBuilder multiTo = new StringBuilder(getto[i]);
                            StringBuilder multiTo2 = new StringBuilder();
                            string multiToSend = "";
                            Boolean isTo = false;
                            // MessageBox.Show("it show");
                            for (int j = 0; j < multiTo.Length; j++)
                            {
                                // MessageBox.Show(multiTo[j].ToString());
                                Application.DoEvents();
                                if (multiTo[j] != ';')
                                {
                                    multiTo2.Append(multiTo[j]);
                                }
                                if (multiTo[j] == ';')
                                {
                                    isTo = true;
                                    multiToSend = multiTo2.ToString();
                                    // MessageBox.Show(multiToSend);
                                }
                                if (isTo)
                                {
                                    MailMessage mail = new MailMessage(getfrom[i], multiToSend, gettitle[i], getmessage[i]);
                                    if (!string.IsNullOrEmpty(getattach[i]))
                                    {
                                        mail.Attachments.Add(new Attachment(getattach[i]));
                                    }
                                    SmtpClient client = new SmtpClient(getserver[i]);
                                    client.Port = 587;
                                    client.Credentials = new System.Net.NetworkCredential(getfrom[i], getpass[i]);
                                    client.EnableSsl = true;
                                    client.Send(mail);
                                    multiToSend = "";
                                    multiTo2.Remove(0, multiTo2.Length);
                                    isTo = false;
                                }
                            }

                            MessageBox.Show("Email Message sent successfully", getmesstitle[i], MessageBoxButtons.OK);
                        }
                        if (DateTime.Now.ToString("HH/mm/ss") == "23/59/59")
                        {
                            if (sun == "Sunday")
                            {
                                if (getrecurW[i] != "1")
                                {
                                    DateTime dt1 = DateTime.Now;
                                    string newday;
                                    newday = dt1.AddDays(WeekNow).ToString();
                                    cn.Open();
                                    cmd.Connection = cn;
                                    cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "',emfrom ='" + getfrom[i] + "',emto = '" + getto[i] + "',emserver = '" + getserver[i] + "',empass='" + getpass[i] + "',emattach ='" + getattach[i] + "' where title ='" + gettitle[i] + "'", cn);
                                    cmd.ExecuteNonQuery();
                                    cn.Close();
                                }
                                else
                                {
                                    DateTime dt2 = DateTime.Now;
                                    string newday;
                                    newday = dt2.AddDays(1).ToString();
                                    cn.Open();
                                    cmd.Connection = cn;
                                    cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "',emfrom ='" + getfrom[i] + "',emto = '" + getto[i] + "',emserver = '" + getserver[i] + "',empass='" + getpass[i] + "',emattach ='" + getattach[i] + "' where title ='" + gettitle[i] + "'", cn);
                                    cmd.ExecuteNonQuery();
                                    cn.Close();
                                }
                            }
                            else
                            {
                                DateTime dt = DateTime.Now;
                                string newday;
                                newday = dt.AddDays(1).ToString();
                                cn.Open();
                                cmd.Connection = cn;
                                cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "',emfrom ='" + getfrom[i] + "',emto = '" + getto[i] + "',emserver = '" + getserver[i] + "',empass='" + getpass[i] + "',emattach ='" + getattach[i] + "' where title ='" + gettitle[i] + "'", cn);
                                cmd.ExecuteNonQuery();
                                cn.Close();
                            }
                        }

                    }

                }
            }
        }
        private void label_Click(object sender, EventArgs e)
        {

        }
        private void lbl_Time_Click(object sender, EventArgs e)
        {

        }
        private void dayBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMessView frm1 = new frmMessView();
            emailUpdate frm2 = new emailUpdate();
            if (maction == "Message")
            {
                frm1.title = mtitle;
                frm1.date = mdate;
                frm1.trigger = mtrigger;
                frm1.time = mtime;
                frm1.action = maction;
                frm1.recurD = mrecurD;
                frm1.recurW = mrecurW;
                frm1.mon = mmon;
                frm1.tue = mtue;
                frm1.wed = mwed;
                frm1.thu = mthu;
                frm1.fri = mfri;
                frm1.sat = msat;
                frm1.sun = msun;
                frm1.messtitle = mmesstitle;
                frm1.message = mmessage;
                frm1.from = mfrom;
                frm1.to = mto;
                frm1.server = mserver;
                frm1.pass = mpass;
                frm1.attach = mattach;
                frm1.ShowDialog();
            }
            if(maction == "Email")
            {
                frm2.title = mtitle;
                frm2.date = mdate;
                frm2.trigger = mtrigger;
                frm2.time = mtime;
                frm2.action = maction;
                frm2.recurD = mrecurD;
                frm2.recurW = mrecurW;
                frm2.mon = mmon;
                frm2.tue = mtue;
                frm2.wed = mwed;
                frm2.thu = mthu;
                frm2.fri = mfri;
                frm2.sat = msat;
                frm2.sun = msun;
                frm2.messtitle = mmesstitle;
                frm2.message = mmessage;
                frm2.from = mfrom;
                frm2.to = mto;
                frm2.server = mserver;
                frm2.pass = mpass;
                frm2.attach = mattach;
                frm2.ShowDialog();

            }
            showData();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
