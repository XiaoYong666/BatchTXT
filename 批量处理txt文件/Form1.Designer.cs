namespace 批量处理txt文件
{
	partial class FormHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
			this.statusLine = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolLine = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelFileName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textContent = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.labName = new System.Windows.Forms.Label();
			this.btnTxt = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBoxNewContext = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textLog = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioLast = new System.Windows.Forms.RadioButton();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.清空所有文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLine.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusLine
			// 
			this.statusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStatus,
            this.toolLine});
			this.statusLine.Location = new System.Drawing.Point(0, 677);
			this.statusLine.Name = "statusLine";
			this.statusLine.Size = new System.Drawing.Size(602, 22);
			this.statusLine.TabIndex = 0;
			this.statusLine.Text = "statusStrip1";
			this.statusLine.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusLine_ItemClicked);
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStatus
			// 
			this.toolStatus.Name = "toolStatus";
			this.toolStatus.Size = new System.Drawing.Size(68, 17);
			this.toolStatus.Text = "执行状态：";
			// 
			// toolLine
			// 
			this.toolLine.Name = "toolLine";
			this.toolLine.Size = new System.Drawing.Size(107, 17);
			this.toolLine.Text = "                 共0行";
			// 
			// groupBox1
			// 
			this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.groupBox1.Controls.Add(this.radioLast);
			this.groupBox1.Controls.Add(this.labelFileName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textContent);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.labName);
			this.groupBox1.Controls.Add(this.btnTxt);
			this.groupBox1.Location = new System.Drawing.Point(12, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(571, 106);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "文件组";
			// 
			// labelFileName
			// 
			this.labelFileName.AutoSize = true;
			this.labelFileName.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelFileName.ForeColor = System.Drawing.Color.Blue;
			this.labelFileName.Location = new System.Drawing.Point(122, 38);
			this.labelFileName.Name = "labelFileName";
			this.labelFileName.Size = new System.Drawing.Size(0, 14);
			this.labelFileName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(297, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "输入需要加入的字符";
			// 
			// textContent
			// 
			this.textContent.Location = new System.Drawing.Point(298, 37);
			this.textContent.Name = "textContent";
			this.textContent.Size = new System.Drawing.Size(261, 21);
			this.textContent.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(484, 66);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "开始转换";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labName
			// 
			this.labName.AutoSize = true;
			this.labName.Location = new System.Drawing.Point(93, 35);
			this.labName.Name = "labName";
			this.labName.Size = new System.Drawing.Size(0, 12);
			this.labName.TabIndex = 1;
			// 
			// btnTxt
			// 
			this.btnTxt.Location = new System.Drawing.Point(20, 26);
			this.btnTxt.Name = "btnTxt";
			this.btnTxt.Size = new System.Drawing.Size(97, 34);
			this.btnTxt.TabIndex = 0;
			this.btnTxt.Text = "上传txt文件";
			this.btnTxt.UseVisualStyleBackColor = true;
			this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new System.Drawing.Point(12, 148);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(571, 526);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "输出日志";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBoxNewContext);
			this.groupBox4.Location = new System.Drawing.Point(7, 261);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(558, 247);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "新增字符后文件内容";
			// 
			// textBoxNewContext
			// 
			this.textBoxNewContext.BackColor = System.Drawing.Color.White;
			this.textBoxNewContext.ContextMenuStrip = this.contextMenuStrip1;
			this.textBoxNewContext.Location = new System.Drawing.Point(7, 20);
			this.textBoxNewContext.Multiline = true;
			this.textBoxNewContext.Name = "textBoxNewContext";
			this.textBoxNewContext.ReadOnly = true;
			this.textBoxNewContext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxNewContext.Size = new System.Drawing.Size(545, 216);
			this.textBoxNewContext.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textLog);
			this.groupBox3.Location = new System.Drawing.Point(9, 23);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(556, 232);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "原始文件内容";
			// 
			// textLog
			// 
			this.textLog.BackColor = System.Drawing.Color.White;
			this.textLog.ContextMenuStrip = this.contextMenuStrip1;
			this.textLog.Location = new System.Drawing.Point(6, 20);
			this.textLog.Multiline = true;
			this.textLog.Name = "textLog";
			this.textLog.ReadOnly = true;
			this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textLog.Size = new System.Drawing.Size(544, 206);
			this.textLog.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(16, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(567, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "①先上传txt文件 ② 输入需要加入的字符 ③ 点击开始转换 ④ 转换完成后文件保存在D盘";
			// 
			// radioLast
			// 
			this.radioLast.AutoSize = true;
			this.radioLast.Checked = true;
			this.radioLast.Location = new System.Drawing.Point(460, 15);
			this.radioLast.Name = "radioLast";
			this.radioLast.Size = new System.Drawing.Size(95, 16);
			this.radioLast.TabIndex = 6;
			this.radioLast.TabStop = true;
			this.radioLast.Text = "追加到行末尾";
			this.radioLast.UseVisualStyleBackColor = true;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空所有文本ToolStripMenuItem,
            this.关于ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// 清空所有文本ToolStripMenuItem
			// 
			this.清空所有文本ToolStripMenuItem.Image = global::批量处理txt文件.Properties.Resources.empty;
			this.清空所有文本ToolStripMenuItem.Name = "清空所有文本ToolStripMenuItem";
			this.清空所有文本ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.清空所有文本ToolStripMenuItem.Text = "清空所有文本";
			this.清空所有文本ToolStripMenuItem.Click += new System.EventHandler(this.清空所有文本ToolStripMenuItem_Click);
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.Image = global::批量处理txt文件.Properties.Resources.guanyu;
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.关于ToolStripMenuItem.Text = "关于";
			this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Image = global::批量处理txt文件.Properties.Resources.t;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
			this.toolStripStatusLabel1.Text = "潇十一郎";
			// 
			// FormHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 699);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusLine);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "批量处理txt内容";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusLine.ResumeLayout(false);
			this.statusLine.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusLine;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labName;
		private System.Windows.Forms.Button btnTxt;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textLog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textContent;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelFileName;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBoxNewContext;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStatus;
		private System.Windows.Forms.ToolStripStatusLabel toolLine;
		private System.Windows.Forms.RadioButton radioLast;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 清空所有文本ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
	}
}

