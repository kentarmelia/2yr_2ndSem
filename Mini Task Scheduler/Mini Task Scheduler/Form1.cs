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

namespace Mini_Task_Scheduler
{
    public partial class MiniTaskSched : Form
    {
        
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        clsMessage clsm = new clsMessage();
        
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
            showData();
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
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null){
                dataGridView.CurrentRow.Selected = true;
                label.Text = dataGridView.Rows[e.RowIndex].Cells["titleDataGridViewTextBoxColumn"].FormattedValue.ToString();
            }
            else
            {

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

            
            for (int i = 0;i <dataGridView.Rows.Count; i++)
            {
                Application.DoEvents();
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
                            cmd = new SqlCommand("update message set ntrigger ='"+gettrigger[i]+ "',action= '"+getaction[i]+ "',setDate= '"+newday.ToString()+ "',setAlarm='"+gettime[i]+ "',recurD = '"+getrecurD[i]+ "',recurW= '"+getrecurW[i]+ "',mon= '"+getmon[i]+ "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "' where title ='"+gettitle[i]+"'",cn);                
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
                                    cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "' where title ='" + gettitle[i] + "'", cn);
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
                                    cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "' where title ='" + gettitle[i] + "'", cn);
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
                                cmd = new SqlCommand("update message set ntrigger ='" + gettrigger[i] + "',action= '" + getaction[i] + "',setDate= '" + newday.ToString() + "',setAlarm='" + gettime[i] + "',recurD = '" + getrecurD[i] + "',recurW= '" + getrecurW[i] + "',mon= '" + getmon[i] + "',tue= '" + gettue[i] + "',wed= '" + getwed[i] + "',thu= '" + getthu[i] + "',fri= '" + getfri[i] + "',sat= '" + getsat[i] + "',sun= '" + getsun[i] + "' where title ='" + gettitle[i] + "'", cn);
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
    }
}
