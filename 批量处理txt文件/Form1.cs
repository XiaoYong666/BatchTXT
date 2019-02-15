using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 批量处理txt文件
{
	public partial class FormHome : Form
	{

		private string _fileName = string.Empty;
		private FileStream files;
		private string _filePath = string.Empty;
		public FormHome()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;//干掉检测 不再检测跨线程
		}

		private void btnTxt_Click(object sender, EventArgs e)
		{
			textLog.Text = "";
			toolStripProgressBar1.Value = 0;
			toolStatus.Text = "执行状态：文件开始上传";

			OpenFileDialog mydialog = new OpenFileDialog();
			mydialog.Filter = "txt(*.txt)|*.txt";
			if (mydialog.ShowDialog() == DialogResult.OK)
			{
				_filePath = mydialog.FileName;
				using (FileStream filestream = File.OpenRead(mydialog.FileName))
				{

					files = filestream;
					string filename = mydialog.FileName.Substring(mydialog.FileName.LastIndexOf("\\") + 1,
						mydialog.FileName.Length - mydialog.FileName.LastIndexOf("\\") - 1);
					using (StreamReader streamreader = new StreamReader(filestream, Encoding.Default))
					{
						labelFileName.Text = filename;
						_fileName = filename;
						string textLine = string.Empty;
						var leg = 0;
						while ((textLine = streamreader.ReadLine()) != null)
						{
							++leg;
							textLog.Text += textLine + "\r\n";
							try
							{
								toolStripProgressBar1.Value += 100 / leg;

							}
							catch
							{
								toolStripProgressBar1.Value = 100;
							}

							toolLine.Text = string.Format("                 共{0}行", leg);
						}

						toolStatus.Text = "执行状态：文件上传完成";
						streamreader.Close();
						filestream.Close();
					}
				}
			}

		}


		private void button1_Click(object sender, EventArgs e)
		{
			textBoxNewContext.Text = "";
			if (string.IsNullOrEmpty(textContent.Text))
			{
				MessageBox.Show("没有新增任何内容，无需进行转换");
				return;
			}
			toolStripProgressBar1.Value = 0;
			toolStatus.Text = "执行状态：转换中...";
			Read(files.Name);
		}
		public void Read(string path)
		{
			var file = File.Open(path, FileMode.Open);
			List<string> txt = new List<string>();
			using (StreamReader streamreader = new StreamReader(file, Encoding.Default))
			{
				var leg = streamreader.ReadLine().Length;
				string textLine = string.Empty;
				while ((textLine = streamreader.ReadLine()) != null)
				{
					txt.Add(textLine);
					try
					{
						toolStripProgressBar1.Value += 100 / leg;

					}
					catch
					{
						toolStripProgressBar1.Value = 100;
					}
				}
				streamreader.Close();
			}

			var array = new string[2000, 2000];
			var line = 0;
			txt.ForEach(t =>
			{
				var row = 0;
				t.Split(',').ToList().ForEach(p =>
				{
					array.SetValue(p, line, row);
					row++;
				});
				textBoxNewContext.Text += t + textContent.Text + "\r\n";

				line++;
			});
			toolStatus.Text = "执行状态：转换完成";

			toolLine.Text = string.Format("                 共{0}行", line);

			Write();
			file.Close();
			MessageBox.Show("操作完成，请打开D盘按时间查看最新的txt文件");
		}

		public void Write()
		{
			Random ts = new Random();
			var reslt = ts.Next(0, 1000);
			FileStream fs =
				new FileStream(
					"D:\\" + _fileName.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries)[0] + "" +
					reslt + "" + ".txt", FileMode.Create);
			//获得字节数组
			byte[] data = System.Text.Encoding.Default.GetBytes(textBoxNewContext.Text);
			//开始写入
			fs.Write(data, 0, data.Length);
			//清空缓冲区、关闭流
			fs.Flush();
			fs.Close();
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			toolStatus.Text = "执行状态：空闲";
			toolLine.Text = "                 共0行";
		}

		private void statusLine_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void 清空所有文本ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textContent.Text = string.Empty;
			textLog.Text = string.Empty;
			textBoxNewContext.Text = string.Empty;
			toolStripProgressBar1.Value = 0;
			toolStatus.Text = "执行中：空闲";
			labelFileName.Text = string.Empty;
			toolLine.Text = "                 共0行";
		}

		private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormAbout m = new FormAbout();
			m.ShowDialog();
		}
	}
}
