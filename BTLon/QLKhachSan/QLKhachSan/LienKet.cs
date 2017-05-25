using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class LienKet : Form
    {
        public LienKet()
        {            
            InitializeComponent();
            var a = this.PointToScreen(label1.Location);
            a = pic1.PointToClient(a);
            label1.Parent = pic1;
            label1.Location = a;
            label1.BackColor = Color.Transparent;
            //
            var b = this.PointToScreen(label2.Location);
            b = pic1.PointToClient(b);
            label2.Parent = pic1;
            label2.Location = b;
            label2.BackColor = Color.Transparent;

            //
            var c = this.PointToScreen(rbDSKhachSan.Location);
            c = pic1.PointToClient(c);
            rbDSKhachSan.Parent = pic1;
            rbDSKhachSan.Location = c;
            rbDSKhachSan.BackColor = Color.Transparent;
            //
            var d = this.PointToScreen(rbDSLienHe.Location);
            d = pic1.PointToClient(d);
            rbDSLienHe.Parent = pic1;
            rbDSLienHe.Location = d;
            rbDSLienHe.BackColor = Color.Transparent;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain f = new FrmMain();
            f.Show();

        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if(rbDSKhachSan.Checked == true)
            {
                FrmDSKhachSan f = new FrmDSKhachSan();
                f.Show();
            }
            else
            {
                FrmLienHe f = new FrmLienHe();
                f.Show();
            }
        }

    }
}
