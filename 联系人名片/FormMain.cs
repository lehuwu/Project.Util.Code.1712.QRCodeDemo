using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNet4.Utilities.UtilReg;
using DotNet4.Utilities.UtilCode;
using System.IO;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace 联系人名片
{
	public partial class FromMain : Form
	{
		public FromMain()
		{
			InitializeComponent();
			TextBoxUserIcon.HandleCreated += LoadControlData;
			TextBoxUserIcon.HandleDestroyed += SaveControlData;
			TextBoxInputPath.HandleCreated += LoadControlData;
			TextBoxInputPath.HandleDestroyed += SaveControlData;
			TextBoxOutputPath.HandleCreated += LoadControlData;
			TextBoxOutputPath.HandleDestroyed += SaveControlData;
		}

		private void FromMain_Load(object sender, EventArgs e)
		{

		}

		private void SelectFilePath(object sender, EventArgs e)
		{
			if (sender is TextBox tar)
			{
				FolderBrowserDialog fileDialog = new FolderBrowserDialog();
				Reg a = new Reg();
				Reg b = a.In("userInfo");
				if (b.GetInfo<string>("User") == "")
					fileDialog.Description = "技术支持请联系qq:331945833";
				else
					fileDialog.Description = "文件所在路径";
				fileDialog.ShowNewFolderButton = true;
				fileDialog.SelectedPath = tar.Text.Length == 0 ? Application.StartupPath : tar.Text;
				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					string file = fileDialog.SelectedPath;//返回文件的完整路径   
					tar.Text = file;
				}
			}
		}
		private void SelectFileName(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			if (sender is TextBox tar)
			{
				if (tar.Name != "TextBoxInputPath")
					fileDialog.Filter = "(图片)|*.png;*.jpg;*.bmp;*.ico;*.jpge;*.gif;*.psd;*.psb|(全部文件)|*.*";
				else
					fileDialog.Filter = "(文本)|*.txt|(全部文件)|*.*";
				fileDialog.RestoreDirectory = true;
				if (fileDialog.ShowDialog() == DialogResult.OK) tar.Text = fileDialog.FileName;//返回文件的完整路径  
			}
 
		}
		private void LoadControlData(object sender,EventArgs e)
		{
			Reg DataBinding = new Reg().In("Setting").In("FormData");
			if(sender is Control tar)
			{
				tar.Text = DataBinding.GetInfo<string>(tar.Name);
			}
		}
		private void SaveControlData(object sender, EventArgs e)
		{
			Reg DataBinding = new Reg().In("Setting").In("FormData");
			if (sender is Control tar)
			{
				DataBinding.SetInfo(tar.Name,tar.Text);
			}
		}
		private string[] fileInfo;
		private void LoadDataList()
		{
			LstBoxShowUserInfo.Items.Clear();
			fileInfo = GetFileData();
			foreach (string tmp in fileInfo)
			{
				LstBoxShowUserInfo.Items.Add(HttpUtil.GetElement(tmp,"FN:","\r"));
			}
		}
		private string[] GetFileData()
		{
			using (StreamReader s = new StreamReader(TextBoxInputPath.Text, Encoding.Default))
			{
				return s.ReadToEnd().Split(new string[] { "BEGIN:VCARD" },StringSplitOptions.RemoveEmptyEntries);
			}
		}
		private void BtnInput_Click(object sender, EventArgs e)
		{
			LoadDataList();
		}

		private void BtnOutPut_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < LstBoxShowUserInfo.Items.Count; i++)
			{
				LstBoxShowUserInfo.SelectedIndex = i;
				OutPutImg("[" + i +"]" + LstBoxShowUserInfo.SelectedItem.ToString()+".png");
			}
			
		}

		private void OutPutImg(string fileName)
		{
			using(Graphics g = Graphics.FromImage(PicBoxShowContactImg.Image))
			{
				PicBoxShowContactImg.Image.Save(TextBoxOutputPath.Text + "\\" + fileName, ImageFormat.Png);
			}
		}
		private void LstBoxShowUserInfo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(sender is ListBox tar)
			{
				if (tar.SelectedIndex == -1) return;
				string info = "BEGIN:VCARD" + fileInfo[tar.SelectedIndex];
				TextBoxShowTmpInfo.Text = info;
			}
		}
		private Image GetContactCard(Image QRCode,string info)
		{
			BufferedGraphicsContext current = BufferedGraphicsManager.Current; //(1)
			PicBoxShowContactImg.Image = new Bitmap(PicBoxShowContactImg.DisplayRectangle.Width,PicBoxShowContactImg.DisplayRectangle.Height );
			using (BufferedGraphics bg = current.Allocate(Graphics.FromImage(PicBoxShowContactImg.Image), PicBoxShowContactImg.DisplayRectangle))
			{  //(2)
				using (Graphics g = bg.Graphics)
				{
					g.Clear(Color.White);
					int size = Convert.ToInt32(PicBoxShowContactImg.Width * 0.01);
					using (LinearGradientBrush BrushOuter = new LinearGradientBrush(new PointF(0, 0), new PointF(0, size * 100), Color.FromArgb(255, 100, 100, 200), Color.FromArgb(50, 100, 100, 255)))
					{
						g.FillRectangle(BrushOuter, 0, 0, size * 100, size * 100);
					}
					g.DrawImage(QRCode, new Rectangle(size * 55, size * 5, size * 30, size * 30));
					var user = new
					{
						name = HttpUtil.GetElement(info, "FN:", "\r"),
						tel = HttpUtil.GetElement(info, "TEL:", "\r"),
						email = HttpUtil.GetElement(info, "EMAIL:", "\r"),
						address = HttpUtil.GetElement(info, "ADR:", "\r"),
						org = HttpUtil.GetElement(info, "ORG:", "\r"),
					};
					using (SolidBrush brh = new SolidBrush(Color.FromArgb(255, 0, 0, 0)))
					{
						using (Font f = new Font("微软雅黑", 16F, FontStyle.Regular))
						{
							PointF p = new PointF(size * 5, size * 5);

							GAddNewInfo("姓名", user.name, ref p, brh, f, g);
							GAddNewInfo("电话", user.tel, ref p, brh, f, g);
							GAddNewInfo("邮箱", user.email, ref p, brh, f, g);
							GAddNewInfo("地址", user.address, ref p, brh, f, g);
							GAddNewInfo("组织", user.org, ref p, brh, f, g);
						}

					}
					bg.Render();
				}
			}
			return QRCode;
		}
		private void GAddNewInfo(string tag,string info, ref PointF point,SolidBrush b,Font font,Graphics g)
		{
			if (info == null || info.Length == 0) return;
			g.DrawString(tag + "   " + info, font, b, point);
			point.Y +=(float)( font.Height*1.1);
		}
		/// <summary>
		/// 生成二维码，如果有Logo，则在二维码中添加Logo
		/// </summary>
		/// <param name="content"></param>
		/// <returns></returns>
		private Bitmap CreateQRCode(string content)
		{
			QRCodeEncoder qrEncoder = new QRCodeEncoder
			{
				QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE,
				QRCodeScale = 4,
				QRCodeVersion = 9,
				QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
			};
			try
			{
				Bitmap qrcode = qrEncoder.Encode(content, Encoding.UTF8);
				if (!TextBoxUserIcon.Text.Equals(string.Empty))
				{
					Graphics g = Graphics.FromImage(qrcode);
					Bitmap bitmapLogo = new Bitmap(TextBoxUserIcon.Text);
					int logoSize = Convert.ToInt32(30);
					bitmapLogo = new Bitmap(bitmapLogo, new System.Drawing.Size(logoSize, logoSize));
					PointF point = new PointF(qrcode.Width / 2 - logoSize / 2, qrcode.Height / 2 - logoSize / 2);
					g.DrawImage(bitmapLogo, point);
				}
				return qrcode;
			}
			catch (IndexOutOfRangeException ex)
			{
				MessageBox.Show("超出当前二维码版本的容量上限，请选择更高的二维码版本！", "系统提示");
				return new Bitmap(100, 100);
			}
			catch (Exception ex)
			{
				MessageBox.Show("生成二维码出错！"+ ex.Message , "系统提示");
				return new Bitmap(100, 100);
			}
		}

		private void TextBoxShowTmpInfo_TextChanged(object sender, EventArgs e)
		{
			Image bimg = CreateQRCode(TextBoxShowTmpInfo.Text);
			GetContactCard(bimg, TextBoxShowTmpInfo.Text);
		}
	}
}
