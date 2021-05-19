
namespace Mini_Task_Scheduler
{
    partial class messagetask
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.p_create = new System.Windows.Forms.Panel();
            this.tb_taskname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_dm = new System.Windows.Forms.Panel();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_MTitle = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.p_ot = new System.Windows.Forms.Panel();
            this.dtp2_ot = new System.Windows.Forms.DateTimePicker();
            this.dtp1_ot = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.p_weekly = new System.Windows.Forms.Panel();
            this.clbDays = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_recurWeekly = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp2_weekly = new System.Windows.Forms.DateTimePicker();
            this.dtp1_weekly = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.p_daily = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_recur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_daily = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_daily = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.p_trigger = new System.Windows.Forms.Panel();
            this.rb_ot = new System.Windows.Forms.RadioButton();
            this.rb_weekly = new System.Windows.Forms.RadioButton();
            this.rb_daily = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_finish = new System.Windows.Forms.Button();
            this.p_create.SuspendLayout();
            this.p_dm.SuspendLayout();
            this.p_ot.SuspendLayout();
            this.p_weekly.SuspendLayout();
            this.p_daily.SuspendLayout();
            this.p_trigger.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(321, 375);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 37);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "< back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(409, 375);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(82, 37);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "next >";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(497, 375);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 37);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // p_create
            // 
            this.p_create.Controls.Add(this.tb_taskname);
            this.p_create.Controls.Add(this.label6);
            this.p_create.Controls.Add(this.label5);
            this.p_create.Location = new System.Drawing.Point(48, 69);
            this.p_create.Name = "p_create";
            this.p_create.Size = new System.Drawing.Size(531, 279);
            this.p_create.TabIndex = 3;
            // 
            // tb_taskname
            // 
            this.tb_taskname.Location = new System.Drawing.Point(116, 132);
            this.tb_taskname.MaxLength = 16;
            this.tb_taskname.Name = "tb_taskname";
            this.tb_taskname.Size = new System.Drawing.Size(311, 20);
            this.tb_taskname.TabIndex = 2;
            this.tb_taskname.TextChanged += new System.EventHandler(this.tb_taskname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(61, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Create Task";
            // 
            // p_dm
            // 
            this.p_dm.AllowDrop = true;
            this.p_dm.Controls.Add(this.tb_message);
            this.p_dm.Controls.Add(this.tb_MTitle);
            this.p_dm.Controls.Add(this.label22);
            this.p_dm.Controls.Add(this.label21);
            this.p_dm.Controls.Add(this.label17);
            this.p_dm.Controls.Add(this.label18);
            this.p_dm.Location = new System.Drawing.Point(36, 54);
            this.p_dm.Name = "p_dm";
            this.p_dm.Size = new System.Drawing.Size(531, 282);
            this.p_dm.TabIndex = 15;
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(117, 131);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(291, 112);
            this.tb_message.TabIndex = 5;
            this.tb_message.TextChanged += new System.EventHandler(this.tb_message_TextChanged);
            // 
            // tb_MTitle
            // 
            this.tb_MTitle.Location = new System.Drawing.Point(116, 95);
            this.tb_MTitle.MaxLength = 16;
            this.tb_MTitle.Name = "tb_MTitle";
            this.tb_MTitle.Size = new System.Drawing.Size(292, 20);
            this.tb_MTitle.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(61, 132);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Message:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(61, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Title:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(114, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(238, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "This action displays a message box on a desktop";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label18.Location = new System.Drawing.Point(22, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(197, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = "Display Message";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // p_ot
            // 
            this.p_ot.AllowDrop = true;
            this.p_ot.Controls.Add(this.dtp2_ot);
            this.p_ot.Controls.Add(this.dtp1_ot);
            this.p_ot.Controls.Add(this.label19);
            this.p_ot.Controls.Add(this.label20);
            this.p_ot.Location = new System.Drawing.Point(36, 57);
            this.p_ot.Name = "p_ot";
            this.p_ot.Size = new System.Drawing.Size(534, 285);
            this.p_ot.TabIndex = 14;
            this.p_ot.Paint += new System.Windows.Forms.PaintEventHandler(this.p_OT_Paint);
            // 
            // dtp2_ot
            // 
            this.dtp2_ot.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp2_ot.Location = new System.Drawing.Point(252, 75);
            this.dtp2_ot.Name = "dtp2_ot";
            this.dtp2_ot.ShowUpDown = true;
            this.dtp2_ot.Size = new System.Drawing.Size(102, 20);
            this.dtp2_ot.TabIndex = 3;
            // 
            // dtp1_ot
            // 
            this.dtp1_ot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1_ot.Location = new System.Drawing.Point(144, 75);
            this.dtp1_ot.Name = "dtp1_ot";
            this.dtp1_ot.Size = new System.Drawing.Size(102, 20);
            this.dtp1_ot.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(96, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Start:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label20.Location = new System.Drawing.Point(13, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "One Time";
            // 
            // p_weekly
            // 
            this.p_weekly.Controls.Add(this.clbDays);
            this.p_weekly.Controls.Add(this.label13);
            this.p_weekly.Controls.Add(this.tb_recurWeekly);
            this.p_weekly.Controls.Add(this.label14);
            this.p_weekly.Controls.Add(this.dtp2_weekly);
            this.p_weekly.Controls.Add(this.dtp1_weekly);
            this.p_weekly.Controls.Add(this.label15);
            this.p_weekly.Controls.Add(this.label16);
            this.p_weekly.Location = new System.Drawing.Point(39, 60);
            this.p_weekly.Name = "p_weekly";
            this.p_weekly.Size = new System.Drawing.Size(531, 279);
            this.p_weekly.TabIndex = 7;
            // 
            // clbDays
            // 
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
            this.clbDays.Location = new System.Drawing.Point(81, 158);
            this.clbDays.MultiColumn = true;
            this.clbDays.Name = "clbDays";
            this.clbDays.Size = new System.Drawing.Size(371, 54);
            this.clbDays.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(226, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Weeks on:";
            // 
            // tb_recurWeekly
            // 
            this.tb_recurWeekly.Location = new System.Drawing.Point(191, 132);
            this.tb_recurWeekly.MaxLength = 3;
            this.tb_recurWeekly.Name = "tb_recurWeekly";
            this.tb_recurWeekly.Size = new System.Drawing.Size(29, 20);
            this.tb_recurWeekly.TabIndex = 5;
            this.tb_recurWeekly.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(96, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Recur every:";
            // 
            // dtp2_weekly
            // 
            this.dtp2_weekly.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp2_weekly.Location = new System.Drawing.Point(252, 75);
            this.dtp2_weekly.Name = "dtp2_weekly";
            this.dtp2_weekly.ShowUpDown = true;
            this.dtp2_weekly.Size = new System.Drawing.Size(102, 20);
            this.dtp2_weekly.TabIndex = 3;
            // 
            // dtp1_weekly
            // 
            this.dtp1_weekly.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1_weekly.Location = new System.Drawing.Point(144, 75);
            this.dtp1_weekly.Name = "dtp1_weekly";
            this.dtp1_weekly.Size = new System.Drawing.Size(102, 20);
            this.dtp1_weekly.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(96, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Start:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label16.Location = new System.Drawing.Point(15, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = "Weekly";
            // 
            // p_daily
            // 
            this.p_daily.Controls.Add(this.label12);
            this.p_daily.Controls.Add(this.tb_recur);
            this.p_daily.Controls.Add(this.label11);
            this.p_daily.Controls.Add(this.dtp_daily);
            this.p_daily.Controls.Add(this.dateTimePicker1_daily);
            this.p_daily.Controls.Add(this.label9);
            this.p_daily.Controls.Add(this.label10);
            this.p_daily.Location = new System.Drawing.Point(42, 63);
            this.p_daily.Name = "p_daily";
            this.p_daily.Size = new System.Drawing.Size(531, 279);
            this.p_daily.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(226, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Days";
            // 
            // tb_recur
            // 
            this.tb_recur.Location = new System.Drawing.Point(191, 132);
            this.tb_recur.MaxLength = 3;
            this.tb_recur.Name = "tb_recur";
            this.tb_recur.Size = new System.Drawing.Size(29, 20);
            this.tb_recur.TabIndex = 5;
            this.tb_recur.Text = "1";
            this.tb_recur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(96, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Recur every:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dtp_daily
            // 
            this.dtp_daily.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_daily.Location = new System.Drawing.Point(252, 75);
            this.dtp_daily.Name = "dtp_daily";
            this.dtp_daily.ShowUpDown = true;
            this.dtp_daily.Size = new System.Drawing.Size(102, 20);
            this.dtp_daily.TabIndex = 3;
            this.dtp_daily.ValueChanged += new System.EventHandler(this.dtp_daily_ValueChanged);
            // 
            // dateTimePicker1_daily
            // 
            this.dateTimePicker1_daily.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_daily.Location = new System.Drawing.Point(144, 75);
            this.dateTimePicker1_daily.Name = "dateTimePicker1_daily";
            this.dateTimePicker1_daily.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1_daily.TabIndex = 2;
            this.dateTimePicker1_daily.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(96, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Start:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label10.Location = new System.Drawing.Point(15, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Daily";
            // 
            // p_trigger
            // 
            this.p_trigger.Controls.Add(this.rb_ot);
            this.p_trigger.Controls.Add(this.rb_weekly);
            this.p_trigger.Controls.Add(this.rb_daily);
            this.p_trigger.Controls.Add(this.label7);
            this.p_trigger.Controls.Add(this.label8);
            this.p_trigger.Location = new System.Drawing.Point(45, 66);
            this.p_trigger.Name = "p_trigger";
            this.p_trigger.Size = new System.Drawing.Size(531, 279);
            this.p_trigger.TabIndex = 4;
            this.p_trigger.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // rb_ot
            // 
            this.rb_ot.AutoSize = true;
            this.rb_ot.Location = new System.Drawing.Point(116, 158);
            this.rb_ot.Name = "rb_ot";
            this.rb_ot.Size = new System.Drawing.Size(67, 17);
            this.rb_ot.TabIndex = 5;
            this.rb_ot.TabStop = true;
            this.rb_ot.Text = "One time";
            this.rb_ot.UseVisualStyleBackColor = true;
            this.rb_ot.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rb_weekly
            // 
            this.rb_weekly.AutoSize = true;
            this.rb_weekly.Location = new System.Drawing.Point(116, 135);
            this.rb_weekly.Name = "rb_weekly";
            this.rb_weekly.Size = new System.Drawing.Size(61, 17);
            this.rb_weekly.TabIndex = 3;
            this.rb_weekly.TabStop = true;
            this.rb_weekly.Text = "Weekly";
            this.rb_weekly.UseVisualStyleBackColor = true;
            this.rb_weekly.CheckedChanged += new System.EventHandler(this.rb_weekly_CheckedChanged);
            // 
            // rb_daily
            // 
            this.rb_daily.AutoSize = true;
            this.rb_daily.Location = new System.Drawing.Point(116, 112);
            this.rb_daily.Name = "rb_daily";
            this.rb_daily.Size = new System.Drawing.Size(48, 17);
            this.rb_daily.TabIndex = 2;
            this.rb_daily.TabStop = true;
            this.rb_daily.Text = "Daily";
            this.rb_daily.UseVisualStyleBackColor = true;
            this.rb_daily.CheckedChanged += new System.EventHandler(this.rb_daily_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(96, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "When do you want the task to start?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trigger";
            // 
            // btn_finish
            // 
            this.btn_finish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_finish.Location = new System.Drawing.Point(409, 375);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(82, 37);
            this.btn_finish.TabIndex = 16;
            this.btn_finish.Text = "Finish";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // messagetask
            // 
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.p_dm);
            this.Controls.Add(this.p_ot);
            this.Controls.Add(this.p_weekly);
            this.Controls.Add(this.p_daily);
            this.Controls.Add(this.p_trigger);
            this.Controls.Add(this.p_create);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Name = "messagetask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message task";
            this.Load += new System.EventHandler(this.messagetask_Load);
            this.p_create.ResumeLayout(false);
            this.p_create.PerformLayout();
            this.p_dm.ResumeLayout(false);
            this.p_dm.PerformLayout();
            this.p_ot.ResumeLayout(false);
            this.p_ot.PerformLayout();
            this.p_weekly.ResumeLayout(false);
            this.p_weekly.PerformLayout();
            this.p_daily.ResumeLayout(false);
            this.p_daily.PerformLayout();
            this.p_trigger.ResumeLayout(false);
            this.p_trigger.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel p_create;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_taskname;
        private System.Windows.Forms.Panel p_trigger;
        private System.Windows.Forms.Panel p_daily;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_daily;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rb_ot;
        private System.Windows.Forms.RadioButton rb_weekly;
        private System.Windows.Forms.RadioButton rb_daily;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_daily;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_recur;
        private System.Windows.Forms.Panel p_weekly;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_recurWeekly;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp2_weekly;
        private System.Windows.Forms.DateTimePicker dtp1_weekly;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel p_ot;
        private System.Windows.Forms.DateTimePicker dtp2_ot;
        private System.Windows.Forms.DateTimePicker dtp1_ot;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel p_dm;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.TextBox tb_MTitle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckedListBox clbDays;
        private System.Windows.Forms.Button btn_finish;
    }
}