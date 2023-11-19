namespace GUI
{
	partial class FLichThi
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
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			panel1 = new Panel();
			dataGridView_DSMonHoc = new DataGridView();
			TenMH = new DataGridViewTextBoxColumn();
			MaMH = new DataGridViewTextBoxColumn();
			HocKy = new DataGridViewTextBoxColumn();
			Nam = new DataGridViewTextBoxColumn();
			label_DSMonHoc = new Label();
			panel2 = new Panel();
			dataGridView1 = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
			label1 = new Label();
			button_TaoLichThi = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_DSMonHoc).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(dataGridView_DSMonHoc);
			panel1.Controls.Add(label_DSMonHoc);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(524, 672);
			panel1.TabIndex = 0;
			// 
			// dataGridView_DSMonHoc
			// 
			dataGridView_DSMonHoc.AllowUserToAddRows = false;
			dataGridView_DSMonHoc.AllowUserToDeleteRows = false;
			dataGridView_DSMonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView_DSMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_DSMonHoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridView_DSMonHoc.BackgroundColor = SystemColors.Info;
			dataGridView_DSMonHoc.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = SystemColors.Control;
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dataGridView_DSMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dataGridView_DSMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView_DSMonHoc.Columns.AddRange(new DataGridViewColumn[] { TenMH, MaMH, HocKy, Nam });
			dataGridView_DSMonHoc.Location = new Point(3, 92);
			dataGridView_DSMonHoc.Name = "dataGridView_DSMonHoc";
			dataGridView_DSMonHoc.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = SystemColors.Control;
			dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			dataGridView_DSMonHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			dataGridView_DSMonHoc.RowHeadersVisible = false;
			dataGridView_DSMonHoc.RowHeadersWidth = 51;
			dataGridView_DSMonHoc.RowTemplate.Height = 29;
			dataGridView_DSMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_DSMonHoc.Size = new Size(521, 506);
			dataGridView_DSMonHoc.TabIndex = 4;
			// 
			// TenMH
			// 
			TenMH.HeaderText = "Tên môn học";
			TenMH.MinimumWidth = 6;
			TenMH.Name = "TenMH";
			TenMH.ReadOnly = true;
			// 
			// MaMH
			// 
			MaMH.DataPropertyName = "MaMH";
			MaMH.HeaderText = "Mã môn học";
			MaMH.MinimumWidth = 6;
			MaMH.Name = "MaMH";
			MaMH.ReadOnly = true;
			// 
			// HocKy
			// 
			HocKy.DataPropertyName = "HocKy";
			HocKy.HeaderText = "Học kỳ";
			HocKy.MinimumWidth = 6;
			HocKy.Name = "HocKy";
			HocKy.ReadOnly = true;
			// 
			// Nam
			// 
			Nam.DataPropertyName = "Nam";
			Nam.HeaderText = "Năm";
			Nam.MinimumWidth = 6;
			Nam.Name = "Nam";
			Nam.ReadOnly = true;
			// 
			// label_DSMonHoc
			// 
			label_DSMonHoc.Anchor = AnchorStyles.Top;
			label_DSMonHoc.AutoSize = true;
			label_DSMonHoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label_DSMonHoc.Location = new Point(151, 54);
			label_DSMonHoc.Name = "label_DSMonHoc";
			label_DSMonHoc.Size = new Size(198, 28);
			label_DSMonHoc.TabIndex = 3;
			label_DSMonHoc.Text = "Danh sách môn học";
			// 
			// panel2
			// 
			panel2.Controls.Add(button_TaoLichThi);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(label1);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(524, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(515, 672);
			panel2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridView1.BackgroundColor = SystemColors.Info;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = SystemColors.Control;
			dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
			dataGridView1.Location = new Point(0, 92);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = SystemColors.Control;
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
			dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(512, 506);
			dataGridView1.TabIndex = 6;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "Tên môn học";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "MaMH";
			dataGridViewTextBoxColumn2.HeaderText = "Mã môn học";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.DataPropertyName = "HocKy";
			dataGridViewTextBoxColumn3.HeaderText = "Học kỳ";
			dataGridViewTextBoxColumn3.MinimumWidth = 6;
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			dataGridViewTextBoxColumn4.DataPropertyName = "Nam";
			dataGridViewTextBoxColumn4.HeaderText = "Năm";
			dataGridViewTextBoxColumn4.MinimumWidth = 6;
			dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(148, 54);
			label1.Name = "label1";
			label1.Size = new Size(182, 28);
			label1.TabIndex = 5;
			label1.Text = "Danh sách lịch thi";
			// 
			// button_TaoLichThi
			// 
			button_TaoLichThi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button_TaoLichThi.Location = new Point(317, 615);
			button_TaoLichThi.Name = "button_TaoLichThi";
			button_TaoLichThi.Size = new Size(156, 45);
			button_TaoLichThi.TabIndex = 5;
			button_TaoLichThi.Text = "Lập lịch thi tự động";
			button_TaoLichThi.UseVisualStyleBackColor = true;
			// 
			// FLichThi
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1039, 672);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FLichThi";
			Text = "FLichThi";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_DSMonHoc).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private DataGridView dataGridView_DSMonHoc;
		private DataGridViewTextBoxColumn TenMH;
		private DataGridViewTextBoxColumn MaMH;
		private DataGridViewTextBoxColumn HocKy;
		private DataGridViewTextBoxColumn Nam;
		private Label label_DSMonHoc;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private Label label1;
		private Button button_TaoLichThi;
	}
}