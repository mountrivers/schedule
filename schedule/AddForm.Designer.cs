namespace schedule
{
    partial class AddForm
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
            this.year = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.cancleButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(53, 26);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 25);
            this.year.TabIndex = 1;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(187, 26);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 25);
            this.month.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(463, 71);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(316, 26);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 25);
            this.date.TabIndex = 3;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(53, 69);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(363, 25);
            this.content.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "연도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "월";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "시간";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "내용";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(463, 26);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 25);
            this.time.TabIndex = 4;
            // 
            // cancleButton
            // 
            this.cancleButton.Location = new System.Drawing.Point(463, 100);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(100, 23);
            this.cancleButton.TabIndex = 11;
            this.cancleButton.Text = "종료";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "링크";
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(53, 101);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(363, 25);
            this.link.TabIndex = 6;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(590, 145);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.content);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Name = "AddForm";
            this.Text = "추가";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox link;
    }
}