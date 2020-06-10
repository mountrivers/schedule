namespace schedule
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textDay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.textContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(269, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
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
            // textDay
            // 
            this.textDay.BackColor = System.Drawing.Color.White;
            this.textDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textDay.Location = new System.Drawing.Point(555, 21);
            this.textDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDay.Name = "textDay";
            this.textDay.Size = new System.Drawing.Size(161, 25);
            this.textDay.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(288, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "일정추가";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkButton
            // 
            this.linkButton.BackColor = System.Drawing.Color.White;
            this.linkButton.Location = new System.Drawing.Point(288, 129);
            this.linkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(194, 45);
            this.linkButton.TabIndex = 4;
            this.linkButton.Text = "링크";
            this.linkButton.UseVisualStyleBackColor = false;
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(522, 228);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(194, 45);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(522, 129);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(194, 45);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "수정";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // textContent
            // 
            this.textContent.BackColor = System.Drawing.Color.White;
            this.textContent.Location = new System.Drawing.Point(288, 64);
            this.textContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(428, 25);
            this.textContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(751, 302);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.linkButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.textDay);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.TextBox textDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader link;
        private System.Windows.Forms.Button linkButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox textContent;
    }
}

