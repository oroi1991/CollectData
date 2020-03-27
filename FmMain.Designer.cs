namespace CollectData
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pbxTitle = new System.Windows.Forms.PictureBox();
            this.mlkExit = new MetroFramework.Controls.MetroLink();
            this.mlbTitle = new MetroFramework.Controls.MetroLabel();
            this.mlkLogin = new MetroFramework.Controls.MetroLink();
            this.mlkLogout = new MetroFramework.Controls.MetroLink();
            this.mlkStart = new MetroFramework.Controls.MetroLink();
            this.mlkStop = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(860, 520);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(852, 478);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tags";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(822, 414);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Current Values";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(822, 414);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Database";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(286, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tab 1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(360, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Tab 2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(360, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Tab 3";
            // 
            // pbxTitle
            // 
            this.pbxTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxTitle.BackgroundImage")));
            this.pbxTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxTitle.Location = new System.Drawing.Point(13, 14);
            this.pbxTitle.Name = "pbxTitle";
            this.pbxTitle.Size = new System.Drawing.Size(40, 40);
            this.pbxTitle.TabIndex = 2;
            this.pbxTitle.TabStop = false;
            // 
            // mlkExit
            // 
            this.mlkExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlkExit.Image = ((System.Drawing.Image)(resources.GetObject("mlkExit.Image")));
            this.mlkExit.ImageSize = 32;
            this.mlkExit.Location = new System.Drawing.Point(852, 8);
            this.mlkExit.Name = "mlkExit";
            this.mlkExit.Size = new System.Drawing.Size(42, 40);
            this.mlkExit.TabIndex = 3;
            this.mlkExit.UseSelectable = true;
            this.mlkExit.Click += new System.EventHandler(this.mlExit_Click);
            // 
            // mlbTitle
            // 
            this.mlbTitle.AutoSize = true;
            this.mlbTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbTitle.Location = new System.Drawing.Point(58, 22);
            this.mlbTitle.Name = "mlbTitle";
            this.mlbTitle.Size = new System.Drawing.Size(250, 25);
            this.mlbTitle.TabIndex = 4;
            this.mlbTitle.Text = "Collect Data using Modbus TCP";
            // 
            // mlkLogin
            // 
            this.mlkLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlkLogin.Image = ((System.Drawing.Image)(resources.GetObject("mlkLogin.Image")));
            this.mlkLogin.ImageSize = 32;
            this.mlkLogin.Location = new System.Drawing.Point(804, 8);
            this.mlkLogin.Name = "mlkLogin";
            this.mlkLogin.Size = new System.Drawing.Size(42, 40);
            this.mlkLogin.TabIndex = 5;
            this.mlkLogin.UseSelectable = true;
            this.mlkLogin.Click += new System.EventHandler(this.mlkLogin_Click);
            // 
            // mlkLogout
            // 
            this.mlkLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlkLogout.Image = ((System.Drawing.Image)(resources.GetObject("mlkLogout.Image")));
            this.mlkLogout.ImageSize = 32;
            this.mlkLogout.Location = new System.Drawing.Point(804, 8);
            this.mlkLogout.Name = "mlkLogout";
            this.mlkLogout.Size = new System.Drawing.Size(42, 40);
            this.mlkLogout.TabIndex = 6;
            this.mlkLogout.UseSelectable = true;
            this.mlkLogout.Visible = false;
            this.mlkLogout.Click += new System.EventHandler(this.mlkLogout_Click);
            // 
            // mlkStart
            // 
            this.mlkStart.Image = ((System.Drawing.Image)(resources.GetObject("mlkStart.Image")));
            this.mlkStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlkStart.ImageSize = 40;
            this.mlkStart.Location = new System.Drawing.Point(335, 15);
            this.mlkStart.Name = "mlkStart";
            this.mlkStart.Size = new System.Drawing.Size(115, 44);
            this.mlkStart.TabIndex = 7;
            this.mlkStart.Text = "RUNNNING";
            this.mlkStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlkStart.UseSelectable = true;
            // 
            // mlkStop
            // 
            this.mlkStop.Image = ((System.Drawing.Image)(resources.GetObject("mlkStop.Image")));
            this.mlkStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlkStop.ImageSize = 40;
            this.mlkStop.Location = new System.Drawing.Point(462, 15);
            this.mlkStop.Name = "mlkStop";
            this.mlkStop.Size = new System.Drawing.Size(81, 44);
            this.mlkStop.TabIndex = 8;
            this.mlkStop.Text = "STOP";
            this.mlkStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlkStop.UseSelectable = true;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.mlkStop);
            this.Controls.Add(this.mlkStart);
            this.Controls.Add(this.mlkLogin);
            this.Controls.Add(this.mlbTitle);
            this.Controls.Add(this.mlkExit);
            this.Controls.Add(this.pbxTitle);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.mlkLogout);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pbxTitle;
        private MetroFramework.Controls.MetroLink mlkExit;
        private MetroFramework.Controls.MetroLabel mlbTitle;
        private MetroFramework.Controls.MetroLink mlkLogin;
        private MetroFramework.Controls.MetroLink mlkLogout;
        private MetroFramework.Controls.MetroLink mlkStart;
        private MetroFramework.Controls.MetroLink mlkStop;
    }
}

