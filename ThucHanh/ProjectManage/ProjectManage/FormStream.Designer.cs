
namespace ProjectManage
{
	partial class FormStream
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
			this.btnRun = new System.Windows.Forms.Button();
			this.btnDong = new System.Windows.Forms.Button();
			this.txtHienThi = new System.Windows.Forms.TextBox();
			this.txtGhi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHienThi1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnRun
			// 
			this.btnRun.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRun.ForeColor = System.Drawing.Color.SpringGreen;
			this.btnRun.Location = new System.Drawing.Point(166, 440);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(259, 71);
			this.btnRun.TabIndex = 0;
			this.btnRun.Text = "Run";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// btnDong
			// 
			this.btnDong.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDong.ForeColor = System.Drawing.Color.Red;
			this.btnDong.Location = new System.Drawing.Point(465, 442);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(259, 67);
			this.btnDong.TabIndex = 1;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// txtHienThi
			// 
			this.txtHienThi.Location = new System.Drawing.Point(26, 62);
			this.txtHienThi.Multiline = true;
			this.txtHienThi.Name = "txtHienThi";
			this.txtHienThi.ReadOnly = true;
			this.txtHienThi.Size = new System.Drawing.Size(842, 108);
			this.txtHienThi.TabIndex = 2;
			// 
			// txtGhi
			// 
			this.txtGhi.Location = new System.Drawing.Point(26, 355);
			this.txtGhi.Multiline = true;
			this.txtGhi.Name = "txtGhi";
			this.txtGhi.Size = new System.Drawing.Size(840, 56);
			this.txtGhi.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 37);
			this.label1.TabIndex = 4;
			this.label1.Text = "Hiển thị:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 315);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 37);
			this.label2.TabIndex = 5;
			this.label2.Text = "Ghi:";
			// 
			// txtHienThi1
			// 
			this.txtHienThi1.Location = new System.Drawing.Point(26, 186);
			this.txtHienThi1.Multiline = true;
			this.txtHienThi1.Name = "txtHienThi1";
			this.txtHienThi1.ReadOnly = true;
			this.txtHienThi1.Size = new System.Drawing.Size(842, 108);
			this.txtHienThi1.TabIndex = 6;
			// 
			// FormStream
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 545);
			this.Controls.Add(this.txtHienThi1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtGhi);
			this.Controls.Add(this.txtHienThi);
			this.Controls.Add(this.btnDong);
			this.Controls.Add(this.btnRun);
			this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "FormStream";
			this.Text = "Form Stream";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Button btnDong;
		public System.Windows.Forms.TextBox txtHienThi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtGhi;
		public System.Windows.Forms.TextBox txtHienThi1;
	}
}

