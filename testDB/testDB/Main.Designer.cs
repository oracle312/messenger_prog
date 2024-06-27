namespace testDB
{
    partial class Main
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
            this.label_userinfo = new MetroFramework.Controls.MetroLabel();
            this.label_lastlogin = new MetroFramework.Controls.MetroLabel();
            this.tree_member = new System.Windows.Forms.TreeView();
            this.sql_connect = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label_userinfo
            // 
            this.label_userinfo.AutoSize = true;
            this.label_userinfo.Location = new System.Drawing.Point(23, 60);
            this.label_userinfo.Name = "label_userinfo";
            this.label_userinfo.Size = new System.Drawing.Size(81, 19);
            this.label_userinfo.TabIndex = 2;
            this.label_userinfo.Text = "metroLabel1";
            // 
            // label_lastlogin
            // 
            this.label_lastlogin.AutoSize = true;
            this.label_lastlogin.Location = new System.Drawing.Point(23, 401);
            this.label_lastlogin.Name = "label_lastlogin";
            this.label_lastlogin.Size = new System.Drawing.Size(81, 19);
            this.label_lastlogin.TabIndex = 3;
            this.label_lastlogin.Text = "metroLabel1";
            // 
            // tree_member
            // 
            this.tree_member.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tree_member.Location = new System.Drawing.Point(23, 82);
            this.tree_member.Name = "tree_member";
            this.tree_member.Size = new System.Drawing.Size(160, 260);
            this.tree_member.TabIndex = 4;
            // 
            // sql_connect
            // 
            this.sql_connect.Tick += new System.EventHandler(this.sql_connect_Tick);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(214, 314);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(171, 27);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "metroButton1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 440);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tree_member);
            this.Controls.Add(this.label_lastlogin);
            this.Controls.Add(this.label_userinfo);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel label_userinfo;
        public MetroFramework.Controls.MetroLabel label_lastlogin;
        private System.Windows.Forms.TreeView tree_member;
        private System.Windows.Forms.Timer sql_connect;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}