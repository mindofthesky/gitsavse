namespace framenet
{
    partial class Form1
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
            this.lvlist = new System.Windows.Forms.ListView();
            this.child = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chnaem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chjob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.laname = new System.Windows.Forms.Label();
            this.latel = new System.Windows.Forms.Label();
            this.laage = new System.Windows.Forms.Label();
            this.lajob = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.plgroup = new System.Windows.Forms.Panel();
            this.plgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlist
            // 
            this.lvlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.child,
            this.chnaem,
            this.chage,
            this.chtel,
            this.chjob});
            this.lvlist.HideSelection = false;
            this.lvlist.Location = new System.Drawing.Point(3, 3);
            this.lvlist.Name = "lvlist";
            this.lvlist.Size = new System.Drawing.Size(539, 272);
            this.lvlist.TabIndex = 0;
            this.lvlist.UseCompatibleStateImageBehavior = false;
            this.lvlist.Click += new System.EventHandler(this.lvlist_Click);
            // 
            // child
            // 
            this.child.Text = "구분";
            this.child.Width = 50;
            // 
            // chnaem
            // 
            this.chnaem.Text = "이름";
            this.chnaem.Width = 80;
            // 
            // chage
            // 
            this.chage.Text = "나이";
            // 
            // chtel
            // 
            this.chtel.Text = "전화번호";
            this.chtel.Width = 150;
            // 
            // chjob
            // 
            this.chjob.Text = "직업";
            this.chjob.Width = 120;
            // 
            // laname
            // 
            this.laname.AutoSize = true;
            this.laname.Location = new System.Drawing.Point(8, 17);
            this.laname.Name = "laname";
            this.laname.Size = new System.Drawing.Size(37, 12);
            this.laname.TabIndex = 1;
            this.laname.Text = "이 름:";
            // 
            // latel
            // 
            this.latel.AutoSize = true;
            this.latel.Location = new System.Drawing.Point(196, 17);
            this.latel.Name = "latel";
            this.latel.Size = new System.Drawing.Size(57, 12);
            this.latel.TabIndex = 2;
            this.latel.Text = "전화번호:";
            // 
            // laage
            // 
            this.laage.AutoSize = true;
            this.laage.Location = new System.Drawing.Point(11, 341);
            this.laage.Name = "laage";
            this.laage.Size = new System.Drawing.Size(41, 12);
            this.laage.TabIndex = 3;
            this.laage.Text = "나  이:";
            // 
            // lajob
            // 
            this.lajob.AutoSize = true;
            this.lajob.Location = new System.Drawing.Point(196, 51);
            this.lajob.Name = "lajob";
            this.lajob.Size = new System.Drawing.Size(41, 12);
            this.lajob.TabIndex = 4;
            this.lajob.Text = "직  업:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 21);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 336);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(255, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 21);
            this.textBox4.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(377, 15);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 52);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(458, 15);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "수정";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(458, 44);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "삭제";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // plgroup
            // 
            this.plgroup.BackColor = System.Drawing.Color.White;
            this.plgroup.Controls.Add(this.textBox4);
            this.plgroup.Controls.Add(this.textBox2);
            this.plgroup.Controls.Add(this.btn_del);
            this.plgroup.Controls.Add(this.latel);
            this.plgroup.Controls.Add(this.btn_update);
            this.plgroup.Controls.Add(this.laname);
            this.plgroup.Controls.Add(this.lajob);
            this.plgroup.Controls.Add(this.btn_save);
            this.plgroup.Location = new System.Drawing.Point(3, 290);
            this.plgroup.Name = "plgroup";
            this.plgroup.Size = new System.Drawing.Size(539, 83);
            this.plgroup.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 376);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.laage);
            this.Controls.Add(this.lvlist);
            this.Controls.Add(this.plgroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plgroup.ResumeLayout(false);
            this.plgroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvlist;
        private System.Windows.Forms.Label laname;
        private System.Windows.Forms.Label latel;
        private System.Windows.Forms.Label laage;
        private System.Windows.Forms.Label lajob;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Panel plgroup;
        private System.Windows.Forms.ColumnHeader child;
        private System.Windows.Forms.ColumnHeader chnaem;
        private System.Windows.Forms.ColumnHeader chage;
        private System.Windows.Forms.ColumnHeader chtel;
        private System.Windows.Forms.ColumnHeader chjob;
    }
}

