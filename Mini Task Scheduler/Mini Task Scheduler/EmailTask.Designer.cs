
namespace Mini_Task_Scheduler
{
    partial class EmailTask
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.p_trigger = new System.Windows.Forms.Panel();
            this.rb_ot = new System.Windows.Forms.RadioButton();
            this.rb_weekly = new System.Windows.Forms.RadioButton();
            this.rb_daily = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.p_daily = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_recur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_daily = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_daily = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.p_weekly = new System.Windows.Forms.Panel();
            this.clbDays = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_recurWeekly = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp2_weekly = new System.Windows.Forms.DateTimePicker();
            this.dtp1_weekly = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.p_ot = new System.Windows.Forms.Panel();
            this.dtp2_ot = new System.Windows.Forms.DateTimePicker();
            this.dtp1_ot = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.p_SEmail = new System.Windows.Forms.Panel();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_attachment = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_MTitle = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.p_trigger.SuspendLayout();
            this.p_daily.SuspendLayout();
            this.p_weekly.SuspendLayout();
            this.p_ot.SuspendLayout();
            this.p_SEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(492, 392);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 37);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(404, 392);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(82, 37);
            this.btn_next.TabIndex = 23;
            this.btn_next.Text = "next >";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(316, 392);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 37);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "< back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // p_trigger
            // 
            this.p_trigger.Controls.Add(this.rb_ot);
            this.p_trigger.Controls.Add(this.rb_weekly);
            this.p_trigger.Controls.Add(this.rb_daily);
            this.p_trigger.Controls.Add(this.label7);
            this.p_trigger.Controls.Add(this.label8);
            this.p_trigger.Location = new System.Drawing.Point(44, 59);
            this.p_trigger.Name = "p_trigger";
            this.p_trigger.Size = new System.Drawing.Size(543, 327);
            this.p_trigger.TabIndex = 17;
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
            // p_daily
            // 
            this.p_daily.Controls.Add(this.label12);
            this.p_daily.Controls.Add(this.tb_recur);
            this.p_daily.Controls.Add(this.label11);
            this.p_daily.Controls.Add(this.dtp_daily);
            this.p_daily.Controls.Add(this.dateTimePicker1_daily);
            this.p_daily.Controls.Add(this.label9);
            this.p_daily.Controls.Add(this.label10);
            this.p_daily.Location = new System.Drawing.Point(44, 53);
            this.p_daily.Name = "p_daily";
            this.p_daily.Size = new System.Drawing.Size(540, 333);
            this.p_daily.TabIndex = 18;
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
            // 
            // dtp_daily
            // 
            this.dtp_daily.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_daily.Location = new System.Drawing.Point(252, 75);
            this.dtp_daily.Name = "dtp_daily";
            this.dtp_daily.ShowUpDown = true;
            this.dtp_daily.Size = new System.Drawing.Size(102, 20);
            this.dtp_daily.TabIndex = 3;
            // 
            // dateTimePicker1_daily
            // 
            this.dateTimePicker1_daily.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_daily.Location = new System.Drawing.Point(144, 75);
            this.dateTimePicker1_daily.Name = "dateTimePicker1_daily";
            this.dateTimePicker1_daily.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1_daily.TabIndex = 2;
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
            this.p_weekly.Location = new System.Drawing.Point(41, 46);
            this.p_weekly.Name = "p_weekly";
            this.p_weekly.Size = new System.Drawing.Size(540, 340);
            this.p_weekly.TabIndex = 19;
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
            // p_ot
            // 
            this.p_ot.AllowDrop = true;
            this.p_ot.Controls.Add(this.dtp2_ot);
            this.p_ot.Controls.Add(this.dtp1_ot);
            this.p_ot.Controls.Add(this.label19);
            this.p_ot.Controls.Add(this.label20);
            this.p_ot.Location = new System.Drawing.Point(35, 35);
            this.p_ot.Name = "p_ot";
            this.p_ot.Size = new System.Drawing.Size(543, 338);
            this.p_ot.TabIndex = 20;
            // 
            // dtp2_ot
            // 
            this.dtp2_ot.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp2_ot.Location = new System.Drawing.Point(285, 93);
            this.dtp2_ot.Name = "dtp2_ot";
            this.dtp2_ot.ShowUpDown = true;
            this.dtp2_ot.Size = new System.Drawing.Size(102, 20);
            this.dtp2_ot.TabIndex = 3;
            // 
            // dtp1_ot
            // 
            this.dtp1_ot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1_ot.Location = new System.Drawing.Point(174, 93);
            this.dtp1_ot.Name = "dtp1_ot";
            this.dtp1_ot.Size = new System.Drawing.Size(102, 20);
            this.dtp1_ot.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(126, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Start:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label20.Location = new System.Drawing.Point(47, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "One Time";
            // 
            // p_SEmail
            // 
            this.p_SEmail.AllowDrop = true;
            this.p_SEmail.Controls.Add(this.btn_browse);
            this.p_SEmail.Controls.Add(this.tb_message);
            this.p_SEmail.Controls.Add(this.tb_attachment);
            this.p_SEmail.Controls.Add(this.textBox2);
            this.p_SEmail.Controls.Add(this.textBox1);
            this.p_SEmail.Controls.Add(this.tb_MTitle);
            this.p_SEmail.Controls.Add(this.label22);
            this.p_SEmail.Controls.Add(this.label4);
            this.p_SEmail.Controls.Add(this.label3);
            this.p_SEmail.Controls.Add(this.label2);
            this.p_SEmail.Controls.Add(this.label21);
            this.p_SEmail.Controls.Add(this.label18);
            this.p_SEmail.Location = new System.Drawing.Point(19, 35);
            this.p_SEmail.Name = "p_SEmail";
            this.p_SEmail.Size = new System.Drawing.Size(559, 346);
            this.p_SEmail.TabIndex = 21;
            this.p_SEmail.Paint += new System.Windows.Forms.PaintEventHandler(this.p_dm_Paint);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(427, 270);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Browse...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(129, 152);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(373, 112);
            this.tb_message.TabIndex = 5;
            // 
            // tb_attachment
            // 
            this.tb_attachment.Location = new System.Drawing.Point(129, 270);
            this.tb_attachment.MaxLength = 16;
            this.tb_attachment.Name = "tb_attachment";
            this.tb_attachment.Size = new System.Drawing.Size(292, 20);
            this.tb_attachment.TabIndex = 4;
            this.tb_attachment.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 126);
            this.textBox2.MaxLength = 16;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 100);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_MTitle
            // 
            this.tb_MTitle.Location = new System.Drawing.Point(128, 74);
            this.tb_MTitle.MaxLength = 16;
            this.tb_MTitle.Name = "tb_MTitle";
            this.tb_MTitle.Size = new System.Drawing.Size(374, 20);
            this.tb_MTitle.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(70, 158);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Attachment:";
            this.label4.Click += new System.EventHandler(this.label21_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            this.label3.Click += new System.EventHandler(this.label21_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            this.label2.Click += new System.EventHandler(this.label21_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(83, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "From:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label18.Location = new System.Drawing.Point(32, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = "Send E-mail";
            // 
            // EmailTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.p_SEmail);
            this.Controls.Add(this.p_ot);
            this.Controls.Add(this.p_weekly);
            this.Controls.Add(this.p_daily);
            this.Controls.Add(this.p_trigger);
            this.Name = "EmailTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Scheduler";
            this.Load += new System.EventHandler(this.EmailTask_Load);
            this.p_trigger.ResumeLayout(false);
            this.p_trigger.PerformLayout();
            this.p_daily.ResumeLayout(false);
            this.p_daily.PerformLayout();
            this.p_weekly.ResumeLayout(false);
            this.p_weekly.PerformLayout();
            this.p_ot.ResumeLayout(false);
            this.p_ot.PerformLayout();
            this.p_SEmail.ResumeLayout(false);
            this.p_SEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel p_trigger;
        private System.Windows.Forms.RadioButton rb_ot;
        private System.Windows.Forms.RadioButton rb_weekly;
        private System.Windows.Forms.RadioButton rb_daily;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel p_daily;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_recur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_daily;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_daily;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel p_weekly;
        private System.Windows.Forms.CheckedListBox clbDays;
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
        private System.Windows.Forms.Panel p_SEmail;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.TextBox tb_attachment;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_MTitle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
    }
}