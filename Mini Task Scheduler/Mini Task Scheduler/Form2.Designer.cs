
namespace Mini_Task_Scheduler
{
    partial class frmMessView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessView));
            this.tcMessage = new System.Windows.Forms.TabControl();
            this.tpTittle = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_taskname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpTrigger = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_ot = new System.Windows.Forms.RadioButton();
            this.rb_weekly = new System.Windows.Forms.RadioButton();
            this.rb_daily = new System.Windows.Forms.RadioButton();
            this.tpDT = new System.Windows.Forms.TabPage();
            this.pnlNtrigger = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlOT = new System.Windows.Forms.Panel();
            this.dtp2_ot = new System.Windows.Forms.DateTimePicker();
            this.dtp1_ot = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlWeekly = new System.Windows.Forms.Panel();
            this.clbDays = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_recurWeekly = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp2_weekly = new System.Windows.Forms.DateTimePicker();
            this.dtp1_weekly = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlDaily = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_recur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_daily = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_daily = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpDM = new System.Windows.Forms.TabPage();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_MTitle = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tcMessage.SuspendLayout();
            this.tpTittle.SuspendLayout();
            this.tpTrigger.SuspendLayout();
            this.tpDT.SuspendLayout();
            this.pnlNtrigger.SuspendLayout();
            this.pnlOT.SuspendLayout();
            this.pnlWeekly.SuspendLayout();
            this.pnlDaily.SuspendLayout();
            this.tpDM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMessage
            // 
            this.tcMessage.Controls.Add(this.tpTittle);
            this.tcMessage.Controls.Add(this.tpTrigger);
            this.tcMessage.Controls.Add(this.tpDT);
            this.tcMessage.Controls.Add(this.tpDM);
            this.tcMessage.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMessage.Location = new System.Drawing.Point(3, 67);
            this.tcMessage.Name = "tcMessage";
            this.tcMessage.SelectedIndex = 0;
            this.tcMessage.Size = new System.Drawing.Size(497, 291);
            this.tcMessage.TabIndex = 0;
            // 
            // tpTittle
            // 
            this.tpTittle.BackColor = System.Drawing.Color.LightBlue;
            this.tpTittle.Controls.Add(this.label5);
            this.tpTittle.Controls.Add(this.tb_taskname);
            this.tpTittle.Controls.Add(this.label6);
            this.tpTittle.Location = new System.Drawing.Point(4, 27);
            this.tpTittle.Name = "tpTittle";
            this.tpTittle.Padding = new System.Windows.Forms.Padding(3);
            this.tpTittle.Size = new System.Drawing.Size(489, 260);
            this.tpTittle.TabIndex = 0;
            this.tpTittle.Text = "Title Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Title Task";
            // 
            // tb_taskname
            // 
            this.tb_taskname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_taskname.Location = new System.Drawing.Point(116, 116);
            this.tb_taskname.MaxLength = 16;
            this.tb_taskname.Name = "tb_taskname";
            this.tb_taskname.Size = new System.Drawing.Size(311, 25);
            this.tb_taskname.TabIndex = 4;
            this.tb_taskname.TextChanged += new System.EventHandler(this.tb_taskname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name:";
            // 
            // tpTrigger
            // 
            this.tpTrigger.BackColor = System.Drawing.Color.LightCoral;
            this.tpTrigger.Controls.Add(this.label8);
            this.tpTrigger.Controls.Add(this.rb_ot);
            this.tpTrigger.Controls.Add(this.rb_weekly);
            this.tpTrigger.Controls.Add(this.rb_daily);
            this.tpTrigger.Location = new System.Drawing.Point(4, 27);
            this.tpTrigger.Name = "tpTrigger";
            this.tpTrigger.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrigger.Size = new System.Drawing.Size(489, 260);
            this.tpTrigger.TabIndex = 1;
            this.tpTrigger.Text = "Trigger";
            this.tpTrigger.Click += new System.EventHandler(this.tpTrigger_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "Trigger";
            // 
            // rb_ot
            // 
            this.rb_ot.AutoSize = true;
            this.rb_ot.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ot.Location = new System.Drawing.Point(191, 138);
            this.rb_ot.Name = "rb_ot";
            this.rb_ot.Size = new System.Drawing.Size(110, 24);
            this.rb_ot.TabIndex = 9;
            this.rb_ot.Text = "One time";
            this.rb_ot.UseVisualStyleBackColor = true;
            this.rb_ot.CheckedChanged += new System.EventHandler(this.rb_ot_CheckedChanged);
            // 
            // rb_weekly
            // 
            this.rb_weekly.AutoSize = true;
            this.rb_weekly.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_weekly.Location = new System.Drawing.Point(191, 115);
            this.rb_weekly.Name = "rb_weekly";
            this.rb_weekly.Size = new System.Drawing.Size(100, 24);
            this.rb_weekly.TabIndex = 8;
            this.rb_weekly.Text = "Weekly";
            this.rb_weekly.UseVisualStyleBackColor = true;
            this.rb_weekly.CheckedChanged += new System.EventHandler(this.rb_weekly_CheckedChanged);
            // 
            // rb_daily
            // 
            this.rb_daily.AutoSize = true;
            this.rb_daily.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_daily.Location = new System.Drawing.Point(191, 92);
            this.rb_daily.Name = "rb_daily";
            this.rb_daily.Size = new System.Drawing.Size(80, 24);
            this.rb_daily.TabIndex = 7;
            this.rb_daily.Text = "Daily";
            this.rb_daily.UseVisualStyleBackColor = true;
            this.rb_daily.CheckedChanged += new System.EventHandler(this.rb_daily_CheckedChanged);
            // 
            // tpDT
            // 
            this.tpDT.BackColor = System.Drawing.Color.Khaki;
            this.tpDT.Controls.Add(this.pnlNtrigger);
            this.tpDT.Controls.Add(this.pnlOT);
            this.tpDT.Controls.Add(this.pnlWeekly);
            this.tpDT.Controls.Add(this.pnlDaily);
            this.tpDT.Location = new System.Drawing.Point(4, 27);
            this.tpDT.Name = "tpDT";
            this.tpDT.Padding = new System.Windows.Forms.Padding(3);
            this.tpDT.Size = new System.Drawing.Size(489, 260);
            this.tpDT.TabIndex = 2;
            this.tpDT.Text = "Date and Time";
            // 
            // pnlNtrigger
            // 
            this.pnlNtrigger.Controls.Add(this.label2);
            this.pnlNtrigger.Location = new System.Drawing.Point(10, 6);
            this.pnlNtrigger.Name = "pnlNtrigger";
            this.pnlNtrigger.Size = new System.Drawing.Size(467, 240);
            this.pnlNtrigger.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(40, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose a trigger first";
            // 
            // pnlOT
            // 
            this.pnlOT.Controls.Add(this.dtp2_ot);
            this.pnlOT.Controls.Add(this.dtp1_ot);
            this.pnlOT.Controls.Add(this.label19);
            this.pnlOT.Controls.Add(this.label20);
            this.pnlOT.Location = new System.Drawing.Point(11, 9);
            this.pnlOT.Name = "pnlOT";
            this.pnlOT.Size = new System.Drawing.Size(466, 237);
            this.pnlOT.TabIndex = 0;
            // 
            // dtp2_ot
            // 
            this.dtp2_ot.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2_ot.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp2_ot.Location = new System.Drawing.Point(210, 93);
            this.dtp2_ot.Name = "dtp2_ot";
            this.dtp2_ot.ShowUpDown = true;
            this.dtp2_ot.Size = new System.Drawing.Size(138, 26);
            this.dtp2_ot.TabIndex = 7;
            // 
            // dtp1_ot
            // 
            this.dtp1_ot.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1_ot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1_ot.Location = new System.Drawing.Point(102, 93);
            this.dtp1_ot.Name = "dtp1_ot";
            this.dtp1_ot.Size = new System.Drawing.Size(102, 26);
            this.dtp1_ot.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(40, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 18);
            this.label19.TabIndex = 5;
            this.label19.Text = "Start:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(154, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 36);
            this.label20.TabIndex = 4;
            this.label20.Text = "One Time";
            // 
            // pnlWeekly
            // 
            this.pnlWeekly.Controls.Add(this.clbDays);
            this.pnlWeekly.Controls.Add(this.label13);
            this.pnlWeekly.Controls.Add(this.tb_recurWeekly);
            this.pnlWeekly.Controls.Add(this.label14);
            this.pnlWeekly.Controls.Add(this.dtp2_weekly);
            this.pnlWeekly.Controls.Add(this.dtp1_weekly);
            this.pnlWeekly.Controls.Add(this.label15);
            this.pnlWeekly.Controls.Add(this.label16);
            this.pnlWeekly.Location = new System.Drawing.Point(14, 12);
            this.pnlWeekly.Name = "pnlWeekly";
            this.pnlWeekly.Size = new System.Drawing.Size(466, 237);
            this.pnlWeekly.TabIndex = 2;
            // 
            // clbDays
            // 
            this.clbDays.BackColor = System.Drawing.Color.Khaki;
            this.clbDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDays.CheckOnClick = true;
            this.clbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clbDays.FormattingEnabled = true;
            this.clbDays.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.clbDays.Location = new System.Drawing.Point(81, 163);
            this.clbDays.MultiColumn = true;
            this.clbDays.Name = "clbDays";
            this.clbDays.Size = new System.Drawing.Size(371, 54);
            this.clbDays.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(226, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Weeks on:";
            // 
            // tb_recurWeekly
            // 
            this.tb_recurWeekly.Location = new System.Drawing.Point(191, 137);
            this.tb_recurWeekly.MaxLength = 3;
            this.tb_recurWeekly.Name = "tb_recurWeekly";
            this.tb_recurWeekly.Size = new System.Drawing.Size(29, 26);
            this.tb_recurWeekly.TabIndex = 21;
            this.tb_recurWeekly.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(96, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Recur every:";
            // 
            // dtp2_weekly
            // 
            this.dtp2_weekly.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp2_weekly.Location = new System.Drawing.Point(252, 80);
            this.dtp2_weekly.Name = "dtp2_weekly";
            this.dtp2_weekly.ShowUpDown = true;
            this.dtp2_weekly.Size = new System.Drawing.Size(102, 26);
            this.dtp2_weekly.TabIndex = 19;
            // 
            // dtp1_weekly
            // 
            this.dtp1_weekly.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1_weekly.Location = new System.Drawing.Point(144, 80);
            this.dtp1_weekly.Name = "dtp1_weekly";
            this.dtp1_weekly.Size = new System.Drawing.Size(102, 26);
            this.dtp1_weekly.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(96, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Start:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(174, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 40);
            this.label16.TabIndex = 16;
            this.label16.Text = "Weekly";
            // 
            // pnlDaily
            // 
            this.pnlDaily.Controls.Add(this.label12);
            this.pnlDaily.Controls.Add(this.tb_recur);
            this.pnlDaily.Controls.Add(this.label11);
            this.pnlDaily.Controls.Add(this.dtp_daily);
            this.pnlDaily.Controls.Add(this.dateTimePicker1_daily);
            this.pnlDaily.Controls.Add(this.label9);
            this.pnlDaily.Controls.Add(this.label10);
            this.pnlDaily.Location = new System.Drawing.Point(17, 15);
            this.pnlDaily.Name = "pnlDaily";
            this.pnlDaily.Size = new System.Drawing.Size(466, 237);
            this.pnlDaily.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(275, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Days";
            // 
            // tb_recur
            // 
            this.tb_recur.Location = new System.Drawing.Point(240, 164);
            this.tb_recur.MaxLength = 3;
            this.tb_recur.Name = "tb_recur";
            this.tb_recur.Size = new System.Drawing.Size(29, 26);
            this.tb_recur.TabIndex = 12;
            this.tb_recur.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(145, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Recur every:";
            // 
            // dtp_daily
            // 
            this.dtp_daily.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_daily.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_daily.Location = new System.Drawing.Point(242, 98);
            this.dtp_daily.Name = "dtp_daily";
            this.dtp_daily.ShowUpDown = true;
            this.dtp_daily.Size = new System.Drawing.Size(123, 26);
            this.dtp_daily.TabIndex = 10;
            // 
            // dateTimePicker1_daily
            // 
            this.dateTimePicker1_daily.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1_daily.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_daily.Location = new System.Drawing.Point(134, 99);
            this.dateTimePicker1_daily.Name = "dateTimePicker1_daily";
            this.dateTimePicker1_daily.Size = new System.Drawing.Size(102, 26);
            this.dateTimePicker1_daily.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Start:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 40);
            this.label10.TabIndex = 7;
            this.label10.Text = "Daily";
            // 
            // tpDM
            // 
            this.tpDM.BackColor = System.Drawing.Color.Plum;
            this.tpDM.Controls.Add(this.tb_message);
            this.tpDM.Controls.Add(this.tb_MTitle);
            this.tpDM.Controls.Add(this.label22);
            this.tpDM.Controls.Add(this.label21);
            this.tpDM.Controls.Add(this.label18);
            this.tpDM.Location = new System.Drawing.Point(4, 27);
            this.tpDM.Name = "tpDM";
            this.tpDM.Padding = new System.Windows.Forms.Padding(3);
            this.tpDM.Size = new System.Drawing.Size(489, 260);
            this.tpDM.TabIndex = 3;
            this.tpDM.Text = "Display Message";
            // 
            // tb_message
            // 
            this.tb_message.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.Location = new System.Drawing.Point(117, 109);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(291, 112);
            this.tb_message.TabIndex = 11;
            // 
            // tb_MTitle
            // 
            this.tb_MTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MTitle.Location = new System.Drawing.Point(116, 77);
            this.tb_MTitle.MaxLength = 16;
            this.tb_MTitle.Name = "tb_MTitle";
            this.tb_MTitle.Size = new System.Drawing.Size(292, 26);
            this.tb_MTitle.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(24, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 18);
            this.label22.TabIndex = 9;
            this.label22.Text = "Message:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(51, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 18);
            this.label21.TabIndex = 8;
            this.label21.Text = "Title:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(123, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(285, 36);
            this.label18.TabIndex = 6;
            this.label18.Text = "Display Message";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 59);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(147, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.Location = new System.Drawing.Point(288, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Location = new System.Drawing.Point(387, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(503, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMessView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message View";
            this.Load += new System.EventHandler(this.frmMessView_Load);
            this.tcMessage.ResumeLayout(false);
            this.tpTittle.ResumeLayout(false);
            this.tpTittle.PerformLayout();
            this.tpTrigger.ResumeLayout(false);
            this.tpTrigger.PerformLayout();
            this.tpDT.ResumeLayout(false);
            this.pnlNtrigger.ResumeLayout(false);
            this.pnlNtrigger.PerformLayout();
            this.pnlOT.ResumeLayout(false);
            this.pnlOT.PerformLayout();
            this.pnlWeekly.ResumeLayout(false);
            this.pnlWeekly.PerformLayout();
            this.pnlDaily.ResumeLayout(false);
            this.pnlDaily.PerformLayout();
            this.tpDM.ResumeLayout(false);
            this.tpDM.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMessage;
        private System.Windows.Forms.TabPage tpTittle;
        private System.Windows.Forms.TabPage tpTrigger;
        private System.Windows.Forms.TabPage tpDT;
        private System.Windows.Forms.TabPage tpDM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_taskname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_ot;
        private System.Windows.Forms.RadioButton rb_weekly;
        private System.Windows.Forms.RadioButton rb_daily;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlOT;
        private System.Windows.Forms.Panel pnlDaily;
        private System.Windows.Forms.Panel pnlWeekly;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_recur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_daily;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_daily;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox clbDays;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_recurWeekly;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp2_weekly;
        private System.Windows.Forms.DateTimePicker dtp1_weekly;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtp2_ot;
        private System.Windows.Forms.DateTimePicker dtp1_ot;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.TextBox tb_MTitle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlNtrigger;
        private System.Windows.Forms.Label label2;
    }
}