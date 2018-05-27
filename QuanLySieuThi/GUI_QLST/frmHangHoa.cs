using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI_QLST
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        SanPham_BUS bus_SanPham = new SanPham_BUS();

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dtgvHangHoa.DataSource = bus_SanPham.GetAllSanPham();
        }
    }
}
