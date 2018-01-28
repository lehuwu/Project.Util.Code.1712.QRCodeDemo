namespace 联系人名片
{
	partial class FromMain
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
			this.PalMain = new System.Windows.Forms.Panel();
			this.BtnInput = new System.Windows.Forms.Button();
			this.BtnOutPut = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.TextBoxUserIcon = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TextBoxOutputPath = new System.Windows.Forms.TextBox();
			this.TextBoxInputPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.PicBoxShowContactImg = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TextBoxShowTmpInfo = new System.Windows.Forms.TextBox();
			this.LstBoxShowUserInfo = new System.Windows.Forms.ListBox();
			this.PalMain.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxShowContactImg)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PalMain
			// 
			this.PalMain.Controls.Add(this.BtnInput);
			this.PalMain.Controls.Add(this.BtnOutPut);
			this.PalMain.Controls.Add(this.groupBox3);
			this.PalMain.Controls.Add(this.groupBox2);
			this.PalMain.Controls.Add(this.groupBox1);
			this.PalMain.Controls.Add(this.LstBoxShowUserInfo);
			this.PalMain.Location = new System.Drawing.Point(12, 12);
			this.PalMain.Name = "PalMain";
			this.PalMain.Size = new System.Drawing.Size(986, 570);
			this.PalMain.TabIndex = 2;
			// 
			// BtnInput
			// 
			this.BtnInput.Location = new System.Drawing.Point(796, 524);
			this.BtnInput.Name = "BtnInput";
			this.BtnInput.Size = new System.Drawing.Size(87, 35);
			this.BtnInput.TabIndex = 9;
			this.BtnInput.Text = "导入";
			this.BtnInput.UseVisualStyleBackColor = true;
			this.BtnInput.Click += new System.EventHandler(this.BtnInput_Click);
			// 
			// BtnOutPut
			// 
			this.BtnOutPut.Location = new System.Drawing.Point(889, 524);
			this.BtnOutPut.Name = "BtnOutPut";
			this.BtnOutPut.Size = new System.Drawing.Size(87, 35);
			this.BtnOutPut.TabIndex = 8;
			this.BtnOutPut.Text = "导出";
			this.BtnOutPut.UseVisualStyleBackColor = true;
			this.BtnOutPut.Click += new System.EventHandler(this.BtnOutPut_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.TextBoxUserIcon);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.TextBoxOutputPath);
			this.groupBox3.Controls.Add(this.TextBoxInputPath);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox3.Location = new System.Drawing.Point(595, 339);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(381, 145);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "设置";
			// 
			// TextBoxUserIcon
			// 
			this.TextBoxUserIcon.Location = new System.Drawing.Point(58, 102);
			this.TextBoxUserIcon.Name = "TextBoxUserIcon";
			this.TextBoxUserIcon.Size = new System.Drawing.Size(313, 34);
			this.TextBoxUserIcon.TabIndex = 4;
			this.TextBoxUserIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectFileName);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(6, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 27);
			this.label3.TabIndex = 5;
			this.label3.Text = "图标";
			// 
			// TextBoxOutputPath
			// 
			this.TextBoxOutputPath.Location = new System.Drawing.Point(58, 65);
			this.TextBoxOutputPath.Name = "TextBoxOutputPath";
			this.TextBoxOutputPath.Size = new System.Drawing.Size(313, 34);
			this.TextBoxOutputPath.TabIndex = 3;
			this.TextBoxOutputPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectFilePath);
			// 
			// TextBoxInputPath
			// 
			this.TextBoxInputPath.Location = new System.Drawing.Point(58, 28);
			this.TextBoxInputPath.Name = "TextBoxInputPath";
			this.TextBoxInputPath.Size = new System.Drawing.Size(313, 34);
			this.TextBoxInputPath.TabIndex = 2;
			this.TextBoxInputPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectFileName);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(6, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "输出";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(6, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "输入";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.PicBoxShowContactImg);
			this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox2.Location = new System.Drawing.Point(225, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(751, 330);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "预览";
			// 
			// PicBoxShowContactImg
			// 
			this.PicBoxShowContactImg.BackColor = System.Drawing.Color.White;
			this.PicBoxShowContactImg.Location = new System.Drawing.Point(6, 24);
			this.PicBoxShowContactImg.Name = "PicBoxShowContactImg";
			this.PicBoxShowContactImg.Size = new System.Drawing.Size(735, 300);
			this.PicBoxShowContactImg.TabIndex = 7;
			this.PicBoxShowContactImg.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TextBoxShowTmpInfo);
			this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(225, 339);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(364, 220);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "内容";
			// 
			// TextBoxShowTmpInfo
			// 
			this.TextBoxShowTmpInfo.Location = new System.Drawing.Point(6, 30);
			this.TextBoxShowTmpInfo.Multiline = true;
			this.TextBoxShowTmpInfo.Name = "TextBoxShowTmpInfo";
			this.TextBoxShowTmpInfo.Size = new System.Drawing.Size(352, 182);
			this.TextBoxShowTmpInfo.TabIndex = 0;
			this.TextBoxShowTmpInfo.TextChanged += new System.EventHandler(this.TextBoxShowTmpInfo_TextChanged);
			// 
			// LstBoxShowUserInfo
			// 
			this.LstBoxShowUserInfo.FormattingEnabled = true;
			this.LstBoxShowUserInfo.ItemHeight = 15;
			this.LstBoxShowUserInfo.Location = new System.Drawing.Point(0, 0);
			this.LstBoxShowUserInfo.Name = "LstBoxShowUserInfo";
			this.LstBoxShowUserInfo.Size = new System.Drawing.Size(219, 559);
			this.LstBoxShowUserInfo.TabIndex = 2;
			this.LstBoxShowUserInfo.SelectedIndexChanged += new System.EventHandler(this.LstBoxShowUserInfo_SelectedIndexChanged);
			// 
			// FromMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 589);
			this.Controls.Add(this.PalMain);
			this.Name = "FromMain";
			this.Text = "联系人名片";
			this.Load += new System.EventHandler(this.FromMain_Load);
			this.PalMain.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PicBoxShowContactImg)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PalMain;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox PicBoxShowContactImg;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox LstBoxShowUserInfo;
		private System.Windows.Forms.TextBox TextBoxOutputPath;
		private System.Windows.Forms.TextBox TextBoxInputPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextBoxUserIcon;
		private System.Windows.Forms.Button BtnInput;
		private System.Windows.Forms.Button BtnOutPut;
		private System.Windows.Forms.TextBox TextBoxShowTmpInfo;
	}
}

