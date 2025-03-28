using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThienThanh1_bai17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtTen.Text;
        }

        private void raRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;
            txtTen.ForeColor = Color.Red;
        }

        private void raGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtTen.ForeColor = Color.Green;
        }

        private void raBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
            txtTen.ForeColor = Color.Blue;
        }

        private void raBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtTen.ForeColor = Color.Black;
        }

        private void ckDam_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size,
lblLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void ckNghien_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size,
lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void ckChan_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size,
lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
