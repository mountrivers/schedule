﻿namespace schedule
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.textDay = new System.Windows.Forms.TextBox();
            this.linkButton = new System.Windows.Forms.Button();
            this.textContent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.textDay);
            this.panel1.Controls.Add(this.linkButton);
            this.panel1.Controls.Add(this.textContent);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Location = new System.Drawing.Point(51, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 306);
            this.panel1.TabIndex = 7;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(706, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(39, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(560, 128);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(194, 45);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "수정";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.title,
            this.link});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(269, 306);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "날짜";
            this.date.Width = 90;
            // 
            // title
            // 
            this.title.Text = "내용";
            this.title.Width = 140;
            // 
            // link
            // 
            this.link.Text = "링크";
            this.link.Width = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(560, 227);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(194, 45);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // textDay
            // 
            this.textDay.BackColor = System.Drawing.Color.White;
            this.textDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textDay.Location = new System.Drawing.Point(593, 20);
            this.textDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDay.Name = "textDay";
            this.textDay.Size = new System.Drawing.Size(161, 25);
            this.textDay.TabIndex = 8;
            // 
            // linkButton
            // 
            this.linkButton.BackColor = System.Drawing.Color.White;
            this.linkButton.Location = new System.Drawing.Point(326, 128);
            this.linkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(194, 45);
            this.linkButton.TabIndex = 11;
            this.linkButton.Text = "링크";
            this.linkButton.UseVisualStyleBackColor = false;
            // 
            // textContent
            // 
            this.textContent.BackColor = System.Drawing.Color.White;
            this.textContent.Location = new System.Drawing.Point(326, 63);
            this.textContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(428, 25);
            this.textContent.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(326, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "일정추가";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1286, 756);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader link;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textDay;
        private System.Windows.Forms.Button linkButton;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExit;
    }
}

