using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManage
{
	public class FileStream_DocGhi_TextFile
	{
		static FormStream fs;
		public static string nam = "hello";
		public static void Write()
		{
			//---
			///--- Lớp FileStream - Ghi test file
			//---
			

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
				Console.WriteLine("Thành công");
			}
			
		}
		public static string Read()
		{
			
			//---
			///--- Lớp FileStream - Đọc test file
			//---

			string filePathR = "D:/B1809485/N4_HK2_TN414_LTUDMang/ThucHanh/ProjectManage/ProjectManage/bin/Debug/mycode/2.txt";
			int SIZEBUFFER = 256;
			string s = "";
			string s1 = "";
			using (var stream = new FileStream(path: filePathR,
				mode: FileMode.Open, access: FileAccess.ReadWrite, share: FileShare.Read))
			{
				Encoding encoding = XacDinhEncoding.GetEncoding(stream);
				Console.WriteLine(encoding.ToString());
				//fs.txtGhi.Text = encoding.ToString();
				byte[] buffer = new byte[SIZEBUFFER];
				bool endRead = false;
				
				do
				{
					int numberRead = stream.Read(buffer, 0, SIZEBUFFER);
					s1 = encoding.GetString(buffer, 0, numberRead);
					if (numberRead == 0) endRead = true;
					if (numberRead < SIZEBUFFER)
						Array.Clear(buffer, numberRead, SIZEBUFFER - numberRead);
					s = encoding.GetString(buffer, 0, numberRead);
					Console.WriteLine(s1.ToString());
					//fs.txtHienThi.AppendText(s);
					
				} while (!endRead);
			}
			return s1;
		}

		
	}
}
