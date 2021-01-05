using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaHoaDES.BieuMau
{
    public partial class frmTienTrinh : Form
    {
        public frmTienTrinh()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dem++;
            dem = dem % 4;
            string str="";
            switch(dem)
            {
                case 0:
                    str="Quá trình đang thực hiện\nVui lòng đợi giây lát ....";
                    break;
                case 1:
                    str="Quá trình đang thực hiện\nVui lòng đợi giây lát ...";
                    break;
                case 2:
                    str="Quá trình đang thực hiện\nVui lòng đợi giây lát ..";
                    break;
                case 3:
                    str="Quá trình đang thực hiện\nVui lòng đợi giây lát .";
                    break;

            }
            lblThongBao.Text = str;
        }
         
    }
}
