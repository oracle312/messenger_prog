namespace testDB
{
    partial class Join
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.txtbox_pw = new System.Windows.Forms.TextBox();
            this.combo_rank = new System.Windows.Forms.ComboBox();
            this.combo_team = new System.Windows.Forms.ComboBox();
            this.btn_join = new System.Windows.Forms.Button();
            this.txtbox_pw2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(39, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(51, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "직급 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(51, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "소속 :";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_name.Location = new System.Drawing.Point(95, 15);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(146, 23);
            this.txtbox_name.TabIndex = 5;
            // 
            // txtbox_id
            // 
            this.txtbox_id.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_id.Location = new System.Drawing.Point(95, 44);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(146, 23);
            this.txtbox_id.TabIndex = 6;
            // 
            // txtbox_pw
            // 
            this.txtbox_pw.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_pw.Location = new System.Drawing.Point(95, 73);
            this.txtbox_pw.Name = "txtbox_pw";
            this.txtbox_pw.PasswordChar = '●';
            this.txtbox_pw.Size = new System.Drawing.Size(146, 23);
            this.txtbox_pw.TabIndex = 7;
            // 
            // combo_rank
            // 
            this.combo_rank.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_rank.FormattingEnabled = true;
            this.combo_rank.Items.AddRange(new object[] {
            "인턴",
            "사원",
            "주임",
            "대리",
            "과장",
            "차장",
            "부장",
            "이사",
            "부사장",
            "사장"});
            this.combo_rank.Location = new System.Drawing.Point(95, 128);
            this.combo_rank.Name = "combo_rank";
            this.combo_rank.Size = new System.Drawing.Size(146, 23);
            this.combo_rank.TabIndex = 8;
            // 
            // combo_team
            // 
            this.combo_team.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_team.FormattingEnabled = true;
            this.combo_team.Items.AddRange(new object[] {
            "개발1팀",
            "개발2팀",
            "인사팀",
            "기획팀",
            "생산팀"});
            this.combo_team.Location = new System.Drawing.Point(95, 158);
            this.combo_team.Name = "combo_team";
            this.combo_team.Size = new System.Drawing.Size(146, 23);
            this.combo_team.TabIndex = 9;
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(30, 187);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(195, 31);
            this.btn_join.TabIndex = 10;
            this.btn_join.Text = "회원가입";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_pw2
            // 
            this.txtbox_pw2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_pw2.Location = new System.Drawing.Point(95, 99);
            this.txtbox_pw2.Name = "txtbox_pw2";
            this.txtbox_pw2.PasswordChar = '●';
            this.txtbox_pw2.Size = new System.Drawing.Size(146, 23);
            this.txtbox_pw2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "비밀번호확인 :";
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 236);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_pw2);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.combo_team);
            this.Controls.Add(this.combo_rank);
            this.Controls.Add(this.txtbox_pw);
            this.Controls.Add(this.txtbox_id);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Join";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Join";
            this.Load += new System.EventHandler(this.Join_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.TextBox txtbox_pw;
        private System.Windows.Forms.ComboBox combo_rank;
        private System.Windows.Forms.ComboBox combo_team;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.TextBox txtbox_pw2;
        private System.Windows.Forms.Label label6;
    }
}