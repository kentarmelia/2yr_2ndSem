
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
            this.btn_messege = new System.Windows.Forms.Button();
            this.btn_email = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lv_task = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTriggers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Task";
            this.button3.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lv_task
            // 
            this.lv_task.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAction,
            this.chTriggers,
            this.chMessage});
            this.lv_task.HideSelection = false;
            this.lv_task.Location = new System.Drawing.Point(229, 48);
            this.lv_task.Name = "lv_task";
            this.lv_task.Size = new System.Drawing.Size(393, 369);
            this.lv_task.TabIndex = 6;
            this.lv_task.UseCompatibleStateImageBehavior = false;
            this.lv_task.View = System.Windows.Forms.View.Details;
            this.lv_task.SelectedIndexChanged += new System.EventHandler(this.lv_task_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 80;
            // 
            // chAction
            // 
            this.chAction.Text = "Action";
            this.chAction.Width = 80;
            // 
            // chTriggers
            // 
            this.chTriggers.Text = "Triggers";
            this.chTriggers.Width = 80;
            // 
            // chMessage
            // 
            this.chMessage.Text = "Message";
            this.chMessage.Width = 150;
            // 
            // MiniTaskSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.lv_task);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_messege);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MiniTaskSched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Task Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_messege;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView lv_task;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAction;
        private System.Windows.Forms.ColumnHeader chTriggers;
        private System.Windows.Forms.ColumnHeader chMessage;
    }
}

