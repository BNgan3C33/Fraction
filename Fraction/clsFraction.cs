using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    class clsFraction
    {
        private int tuSo;
        private int mauSo;

        public clsFraction()
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }
        public clsFraction(int t, int m)
        {
            this.tuSo = t;
            this.mauSo = m;
        }
        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value;
                if (mauSo == 0)
                    MessageBox.Show("Mau So phai khac 0");
            }
        }

        public int UCLN(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            return a;
        }

        private void ToiGian()
        {
            int u = UCLN(tuSo, mauSo);
            this.tuSo /= u;
            this.mauSo /= u;
        }

        public clsFraction Cong(clsFraction ps)
        {
            clsFraction kq = new clsFraction();
            kq.tuSo = this.tuSo * ps.mauSo + this.mauSo * ps.tuSo;
            kq.mauSo = this.mauSo * ps.mauSo;
            kq.ToiGian();
            return kq;
        }
        public clsFraction Tru(clsFraction ps)
        {
            clsFraction kq = new clsFraction();
            kq.tuSo = this.tuSo * ps.mauSo - this.mauSo * ps.tuSo;
            kq.mauSo = this.mauSo * ps.mauSo;
            kq.ToiGian();
            return kq;
        }
        public clsFraction Nhan(clsFraction ps)
        {
            clsFraction kq = new clsFraction();
            kq.tuSo = this.tuSo * ps.tuSo;
            kq.mauSo = this.mauSo * ps.mauSo;
            kq.ToiGian();
            return kq;
        }
        public clsFraction Chia(clsFraction ps)
        {
            clsFraction kq = new clsFraction();
            kq.tuSo = this.tuSo * ps.mauSo;
            kq.mauSo = this.mauSo * ps.tuSo;
            kq.ToiGian();
            return kq;
        }

    }
}
