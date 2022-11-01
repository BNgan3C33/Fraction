using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    public partial class FrmFraction : Form
    {
        public FrmFraction()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string opt = btn.Text;

            lbOpt.Text = opt;

            try
            {
                clsFraction ps1 = new clsFraction(Int32.Parse(txtTu1.Text), Int32.Parse(txtMau1.Text));
                clsFraction ps2 = new clsFraction(Int32.Parse(txtTu2.Text), Int32.Parse(txtMau2.Text));
                if (Int32.Parse(txtMau1.Text)==0 || Int32.Parse(txtMau2.Text)==0)
                {
                    MessageBox.Show("Mau So khong duoc bang 0");
                    Close();
                    return;
                }    
                clsFraction kq = new clsFraction();
                switch (opt)
                {
                    case "+":
                        kq = ps1.Cong(ps2);
                        break;
                    case "-":
                        kq = ps1.Tru(ps2);
                        break;
                    case "*":
                        kq = ps1.Nhan(ps2);
                        break;
                    case "/":
                        kq = ps1.Chia(ps2);
                        break;
                }
                txtTuKq.Text = kq.TuSo.ToString();
                txtMauKq.Text = kq.MauSo.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
