
namespace Mini_Task_Scheduler
{
    partial class MiniTaskSched
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
            this.btn_messege = new System.Windows.Forms.Button();
            this.btn_email = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.triggerview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.clsMessageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMessageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMessageBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_messege
            // 
            this.btn_messege.BackColor = System.Drawing.Color.White;
            this.btn_messege.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_messege.Location = new System.Drawing.Point(40, 64);
            this.btn_messege.Name = "btn_messege";
            this.btn_messege.Size = new System.Drawing.Size(139, 23);
            this.btn_messege.TabIndex = 0;
            this.btn_messege.Text = "Create Message Task";
            this.btn_messege.UseVisualStyleBackColor = false;
            this.btn_messege.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_email
            // 
            this.btn_email.BackColor = System.Drawing.Color.White;
            this.btn_email.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_email.Location = new System.Drawing.Point(40, 106);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(139, 23);
            this.btn_email.TabIndex = 1;
            this.btn_email.Text = "Create Email Task";
            this.btn_email.UseVisualStyleBackColor = false;
            this.btn_email.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.Action,
            this.trigger,
            this.triggerview,
            this.created,
            this.setDate,
            this.setAlarm,
            this.recurD,
            this.recurW,
            this.messTitle,
            this.message,
            this.mon,
            this.tue,
            this.wed,
            this.thu,
            this.fri,
            this.sat,
            this.sun});
            this.dataGridView.DataSource = this.clsMessageBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(227, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(713, 411);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Name";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 95;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // trigger
            // 
            this.trigger.DataPropertyName = "ntrigger";
            this.trigger.HeaderText = "Trigger Type";
            this.trigger.Name = "trigger";
            this.trigger.ReadOnly = true;
            // 
            // triggerview
            // 
            this.triggerview.DataPropertyName = "triggerview";
            this.triggerview.HeaderText = "Trigger";
            this.triggerview.Name = "triggerview";
            this.triggerview.ReadOnly = true;
            this.triggerview.Width = 327;
            // 
            // created
            // 
            this.created.DataPropertyName = "created";
            this.created.FillWeight = 11.81102F;
            this.created.HeaderText = "Created";
            this.created.Name = "created";
            this.created.ReadOnly = true;
            this.created.Width = 90;
            // 
            // setDate
            // 
            this.setDate.DataPropertyName = "setDate";
            this.setDate.HeaderText = "Incoming date";
            this.setDate.Name = "setDate";
            this.setDate.ReadOnly = true;
            // 
            // setAlarm
            // 
            this.setAlarm.DataPropertyName = "setAlarm";
            this.setAlarm.HeaderText = "Incoming time";
            this.setAlarm.MaxInputLength = 100;
            this.setAlarm.Name = "setAlarm";
            this.setAlarm.ReadOnly = true;
            // 
            // recurD
            // 
            this.recurD.DataPropertyName = "recurD";
            this.recurD.HeaderText = "recur in days";
            this.recurD.Name = "recurD";
            this.recurD.ReadOnly = true;
            // 
            // recurW
            // 
            this.recurW.DataPropertyName = "recurW";
            this.recurW.HeaderText = "recur in weeks";
            this.recurW.Name = "recurW";
            this.recurW.ReadOnly = true;
            // 
            // messTitle
            // 
            this.messTitle.DataPropertyName = "messTitle";
            this.messTitle.HeaderText = "Message Title";
            this.messTitle.Name = "messTitle";
            this.messTitle.ReadOnly = true;
            // 
            // message
            // 
            this.message.DataPropertyName = "message";
            this.message.HeaderText = "message";
            this.message.Name = "message";
            this.message.ReadOnly = true;
            // 
            // mon
            // 
            this.mon.DataPropertyName = "mon";
            this.mon.HeaderText = "mon";
            this.mon.Name = "mon";
            this.mon.ReadOnly = true;
            // 
            // tue
            // 
            this.tue.DataPropertyName = "tue";
            this.tue.HeaderText = "tue";
            this.tue.Name = "tue";
            this.tue.ReadOnly = true;
            // 
            // wed
            // 
            this.wed.DataPropertyName = "wed";
            this.wed.HeaderText = "wed";
            this.wed.Name = "wed";
            this.wed.ReadOnly = true;
            // 
            // thu
            // 
            this.thu.DataPropertyName = "thu";
            this.thu.HeaderText = "thu";
            this.thu.Name = "thu";
            this.thu.ReadOnly = true;
            // 
            // fri
            // 
            this.fri.DataPropertyName = "fri";
            this.fri.HeaderText = "fri";
            this.fri.Name = "fri";
            this.fri.ReadOnly = true;
            // 
            // sat
            // 
            this.sat.DataPropertyName = "sat";
            this.sat.HeaderText = "sat";
            this.sat.Name = "sat";
            this.sat.ReadOnly = true;
            // 
            // sun
            // 
            this.sun.DataPropertyName = "sun";
            this.sun.HeaderText = "sun";
            this.sun.Name = "sun";
            this.sun.ReadOnly = true;
            // 
            // clsMessageBindingSource
            // 
            this.clsMessageBindingSource.DataSource = typeof(Mini_Task_Scheduler.clsMessage);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(144, 184);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(33, 13);
            this.label.TabIndex = 7;
            this.label.Text = "None";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current row clicked:";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Impact", 27F);
            this.lbl_Time.Location = new System.Drawing.Point(12, 299);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(195, 44);
            this.lbl_Time.TabIndex = 9;
            this.lbl_Time.Text = "00:00:00:NN";
            this.lbl_Time.Click += new System.EventHandler(this.lbl_Time_Click);
            // 
            // clsMessageBindingSource1
            // 
            this.clsMessageBindingSource1.DataSource = typeof(Mini_Task_Scheduler.clsMessage);
            // 
            // MiniTaskSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 441);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_messege);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MiniTaskSched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Task Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMessageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMessageBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_messege;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource clsMessageBindingSource;
        private System.Windows.Forms.BindingSource clsMessageBindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigger;
        private System.Windows.Forms.DataGridViewTextBoxColumn triggerview;
        private System.Windows.Forms.DataGridViewTextBoxColumn created;
        private System.Windows.Forms.DataGridViewTextBoxColumn setDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn setAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn recurD;
        private System.Windows.Forms.DataGridViewTextBoxColumn recurW;
        private System.Windows.Forms.DataGridViewTextBoxColumn messTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tue;
        private System.Windows.Forms.DataGridViewTextBoxColumn wed;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fri;
        private System.Windows.Forms.DataGridViewTextBoxColumn sat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sun;
    }
}

