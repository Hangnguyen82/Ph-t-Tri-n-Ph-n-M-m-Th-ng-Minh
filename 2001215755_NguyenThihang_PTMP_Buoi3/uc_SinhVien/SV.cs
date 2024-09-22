using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace uc_SinhVien
{
    public partial class SV : UserControl
    {
        public string FilePath{get;set;}="E:\LuuDuLieuSV\2001215755_NguyenThihang_PTMP_Buoi3\SV.txt";
        public SV()
        {
            InitializeComponent();
        }
        public void LoadSinhVienInfo(string mssv)
        {
            if(File.Exists(FilePath))
            {
                var lines=File.ReadAllLines(FilePath);
                foreach(var line in lines)
                {
                    var data=line.Split('|');
                    if(data[0])
                }
            }
        }
    }
}
