﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FGiangVien : Form
    {
        public FGiangVien()
        {
            InitializeComponent();
            FGiangVienLoad();
        }
        public void FGiangVienLoad()
        {
            dataGridView_DSSV.DataSource = BUS.GiangVienBUS.Instance.getAllGiangVien();
        }

        private void dataGridView_DSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
