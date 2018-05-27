using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLST
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //kiểm tra form con đã tồn tại hay chưa 
        public bool checkForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;

        }
        //duyệt xem form cha đã có form con hay chưa
        public void FormConDaCo(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    break;
                }
            }
        }

        private void toolNhanVien_Click(object sender, EventArgs e)
        {
            if (!checkForm("frmNhanVien"))
            {
                frmNhanVien fnv = new frmNhanVien();
                fnv.MdiParent = this;
                fnv.Show();
            }
            else
            {
                FormConDaCo("frmNhanVien");              
            }
        }

        private void toolKhachHang_Click(object sender, EventArgs e)
        {
            if (!checkForm("frmKhachHang"))
            {
                frmKhachHang fkh = new frmKhachHang();
                fkh.MdiParent = this;
                fkh.Show();
            }
            else
            {
                FormConDaCo("frmKhachHang");
            }
        }

        private void toolHangHoa_Click(object sender, EventArgs e)
        {
            if (!checkForm("frmHangHoa"))
            {
                frmHangHoa fhh = new frmHangHoa();
                fhh.MdiParent = this;
                fhh.Show();
            }
            else
            {
                FormConDaCo("frmHangHoa");
            }
        }

        private void toolBanHang_Click(object sender, EventArgs e)
        {
            if (!checkForm("frmBanHang"))
            {
                frmBanHang fhh = new frmBanHang();
                fhh.MdiParent = this;
                fhh.Show();
            }
            else
            {
                FormConDaCo("frmBanHang");
            }
        }
    }
}
