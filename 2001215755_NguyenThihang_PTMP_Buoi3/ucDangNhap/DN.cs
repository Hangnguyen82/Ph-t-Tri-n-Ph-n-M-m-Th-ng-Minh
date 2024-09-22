using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
namespace ucDangNhap
{
    public partial class DN : UserControl
    {
        String _cnn;
        SQLClass sqldt = new SQLClass();
        
        public String Cnn
        {
          get { return _cnn; }
          set { _cnn = value; }
        }
        public DN()
        {
            InitializeComponent();
            this.btnDN.Click += btnDN_Click;
        }

        void btnDN_Click(object sender, EventArgs e)
        {
            sqldt.CreateConnection(_cnn);
            String Ten = txtTen.Text;
            String MK = txtMK.Text;

            string caulenh = "select count(*) from DN where TENDN='"+Ten+"' and MKDN='"+MK+"'";

            int kq = (int)sqldt.ExecuteScalar(caulenh);

            if(kq==1)
            {
                MessageBox.Show("Thanh Cong");
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }
    }
}
