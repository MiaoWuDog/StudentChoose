namespace 简易班里挑一
{
    partial class Frm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labTitle = new Sunny.UI.UILabel();
            this.lab = new Sunny.UI.UILabel();
            this.txName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txZhuanye = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txID = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txClass = new Sunny.UI.UITextBox();
            this.ButtonStart = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.labTime = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labTitle.Location = new System.Drawing.Point(214, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(251, 92);
            this.labTitle.Style = Sunny.UI.UIStyle.Custom;
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "班里挑一";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab
            // 
            this.lab.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lab.Location = new System.Drawing.Point(51, 120);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(100, 23);
            this.lab.Style = Sunny.UI.UIStyle.Custom;
            this.lab.TabIndex = 1;
            this.lab.Text = "姓名";
            this.lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txName
            // 
            this.txName.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txName.Location = new System.Drawing.Point(112, 120);
            this.txName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txName.Name = "txName";
            this.txName.Padding = new System.Windows.Forms.Padding(5);
            this.txName.ShowText = false;
            this.txName.Size = new System.Drawing.Size(162, 29);
            this.txName.TabIndex = 2;
            this.txName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txName.Watermark = "这里本应该是姓名";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiLabel1.Location = new System.Drawing.Point(51, 212);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "专业";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txZhuanye
            // 
            this.txZhuanye.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txZhuanye.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txZhuanye.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txZhuanye.Location = new System.Drawing.Point(112, 212);
            this.txZhuanye.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txZhuanye.MinimumSize = new System.Drawing.Size(1, 16);
            this.txZhuanye.Name = "txZhuanye";
            this.txZhuanye.Padding = new System.Windows.Forms.Padding(5);
            this.txZhuanye.ShowText = false;
            this.txZhuanye.Size = new System.Drawing.Size(162, 29);
            this.txZhuanye.TabIndex = 2;
            this.txZhuanye.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txZhuanye.Watermark = "这里本应该是专业";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiLabel2.Location = new System.Drawing.Point(321, 120);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "ID";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txID
            // 
            this.txID.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txID.Location = new System.Drawing.Point(382, 120);
            this.txID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txID.MinimumSize = new System.Drawing.Size(1, 16);
            this.txID.Name = "txID";
            this.txID.Padding = new System.Windows.Forms.Padding(5);
            this.txID.ShowText = false;
            this.txID.Size = new System.Drawing.Size(162, 29);
            this.txID.TabIndex = 2;
            this.txID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txID.Watermark = "这里本应该是id";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiLabel3.Location = new System.Drawing.Point(321, 212);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "班级";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txClass
            // 
            this.txClass.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txClass.Location = new System.Drawing.Point(382, 212);
            this.txClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txClass.MinimumSize = new System.Drawing.Size(1, 16);
            this.txClass.Name = "txClass";
            this.txClass.Padding = new System.Windows.Forms.Padding(5);
            this.txClass.ShowText = false;
            this.txClass.Size = new System.Drawing.Size(162, 29);
            this.txClass.TabIndex = 2;
            this.txClass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txClass.Watermark = "这里本应该是班级";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonStart.Location = new System.Drawing.Point(444, 291);
            this.ButtonStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 35);
            this.ButtonStart.TabIndex = 3;
            this.ButtonStart.Text = "随机抽人";
            this.ButtonStart.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(52, 291);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(83, 23);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "倒计时：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(174, 291);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(27, 23);
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "秒";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTime
            // 
            this.labTime.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labTime.Location = new System.Drawing.Point(131, 291);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(27, 23);
            this.labTime.Style = Sunny.UI.UIStyle.Custom;
            this.labTime.TabIndex = 1;
            this.labTime.Text = "5";
            this.labTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 411);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.txClass);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.txZhuanye);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.labTitle);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm";
            this.Text = "班里挑一";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel labTitle;
        private Sunny.UI.UILabel lab;
        private Sunny.UI.UITextBox txName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txZhuanye;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txID;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txClass;
        private Sunny.UI.UIButton ButtonStart;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel labTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

