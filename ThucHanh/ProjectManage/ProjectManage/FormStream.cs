using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManage
{
	public partial class FormStream : Form
	{
		//public static FormStream txt = 
		public FormStream()
		{
			InitializeComponent();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			Write();
			Read();
			txtGhi.Text = FileStream_DocGhi_TextFile.nam;
		}


		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//---
		///--- Lớp FileStream - Đọc test file
		//---
		public void Read()
		{
			string filePathR = "D:/B1809485/N4_HK2_TN414_LTUDMang/ThucHanh/ProjectManage/ProjectManage/bin/Debug/mycode/2.txt";
			int SIZEBUFFER = 256;
			using (var stream = new FileStream(path: filePathR,
				mode: FileMode.Open, access: FileAccess.ReadWrite, share: FileShare.Read))
			{
				Encoding encoding = XacDinhEncoding.GetEncoding(stream);
				Console.WriteLine("Đọc kiểu: " + encoding.ToString());
				txtGhi.Text = encoding.ToString();
				byte[] buffer = new byte[SIZEBUFFER];
				bool endRead = false;
				do
				{
					int numberRead = stream.Read(buffer, 0, SIZEBUFFER);
					if (numberRead == 0) endRead = true;
					if (numberRead < SIZEBUFFER)
						Array.Clear(buffer, numberRead, SIZEBUFFER - numberRead);
					string s = encoding.GetString(buffer, 0, numberRead);
					txtHienThi.AppendText(s);
				} while (!endRead);
			}

		}//---end

		//--
		///--- Lớp FileStream - Ghi test file
		//--
		public void Write()
		{
			string filePathW = "D:/B1809485/N4_HK2_TN414_LTUDMang/ThucHanh/ProjectManage/ProjectManage/bin/Debug/mycode/2.txt";

			using (var stream = new FileStream(path: filePathW,
				mode: FileMode.Create, access: FileAccess.Write, share: FileShare.None))
			{
				//Write BOM - UTF8
				Encoding encoding = Encoding.UTF8;
				byte[] bom = encoding.GetPreamble();
				stream.Write(bom, 0, bom.Length);
				string s1 = "Xin chào các bạn sinh viên CTU! \n";
				string s2 = "Ví dụ ghi file text bằng stream";

				// Encoding chuỗi lưu vào mảng bytes
				byte[] buffer = encoding.GetBytes(s1);
				stream.Write(buffer, 0, buffer.Length); // Luu vao stream
				buffer = encoding.GetBytes(s2);
				stream.Write(buffer, 0, buffer.Length); // Luu vao stream
				Console.WriteLine("Ghi thành công");
			}
		}//---end

	}
}
