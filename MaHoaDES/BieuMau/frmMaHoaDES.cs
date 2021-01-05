using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaHoaDES.DoiTuong;
using AOC.ThuVien;
 
using System.Threading;

namespace MaHoaDES.BieuMau
{
    public partial class frmMaHoaDES : Form
    {
        int MaHoaHayGiaiMa = 1;
        bool FileHayChuoi = false;
        DES64Bit MaHoaDES64;
        Khoa Khoa;
        Thread thread = null;

        public static string TenTienTrinh = "";
        public static int GiaiDoan = -1;
        private static int Dem = 0;

        public frmMaHoaDES()
        {
            InitializeComponent();
        }       
        private void EnableHoacDisableNut(bool b)
        {
            btnChonFile.Enabled = b;
            btnGiaiMaFile.Enabled = b;
            btnGiaiMaVanBan.Enabled = b;
            btnMaHoaFile.Enabled = b;
            btnMaHoaVanBan.Enabled = b;
        }
        private void Chay()
        {
            thread = new Thread(new ThreadStart(MaHoa));
            thread.IsBackground = true;
            timer1.Enabled = true;
            thread.Start();
        }
       
        private void MaHoa()
        {
            //try
            //{
               
                MaHoaDES64 = new DES64Bit();
                //if (!ckbCheDoDebug.Checked)
                //{
                    //EnableHoacDisableNut(false);
                    //progressBar1.Value = 10;
                //}
            
                //TenTienTrinh = "";
                 
                GiaiDoan = 0;
                Dem = 0;
               
                if (FileHayChuoi)
                {
                    Khoa = new Khoa(txtKhoaFile.Text);
                    if (MaHoaHayGiaiMa == 1)
                    {
                        GiaiDoan = 0;
                        ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(txtFileNguon.Text);
                        GiaiDoan = 1;
                        ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, 1);
                        GiaiDoan = 2;
                        DocFileTxt.WriteBinaryToFile(txtFileDich.Text, KQ);
                        GiaiDoan = 3;
                        MessageBox.Show("Mã hóa file thành công");
                    }
                    else
                    {
                        GiaiDoan = 0;
                        ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(txtFileNguon.Text);
                        GiaiDoan = 1;
                        ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, -1);
                        if (KQ == null)
                        {
                            MessageBox.Show("Lỗi giải mã . kiểm tra khóa ");
                            return;
                        }
                        GiaiDoan = 2;
                        DocFileTxt.WriteBinaryToFile(txtFileDich.Text, KQ);
                        GiaiDoan = 3;
                        MessageBox.Show("Giải mã file thành công");
                    }
                }
                else
                {
                    Khoa = new Khoa(txtKhoaVanBan.Text);
                    if (MaHoaHayGiaiMa == 1)
                    {

                        MaHoaDES64 = new DES64Bit();
                        GiaiDoan = 0;
                        GiaiDoan = 1;
                        string kq=MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon.Text, 1);
                        txtVanBanDich.Text = kq;
                        GiaiDoan = 2;
                        GiaiDoan = 3;
                        MessageBox.Show("Mã hóa chuỗi thành công");
                    }
                    else
                    {
                        MaHoaDES64 = new DES64Bit();
                        GiaiDoan = 0;
                        GiaiDoan = 1;
                        string kq = MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon.Text, -1);
                        txtVanBanDich.Text = kq;
                        if (kq == "")
                        {
                            return;
                        }
                        GiaiDoan = 2;
                        GiaiDoan = 3;
                        MessageBox.Show("Giải mã chuỗi thành công");
                    }
                }
                //if (!ckbCheDoDebug.Checked)
                //{
                    //EnableHoacDisableNut(true);
                    timer1.Enabled = false;
                //}
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString()); 
            //}
            
        }

        private void txtMaHoaVanBan_Click(object sender, EventArgs e)
        {
            FileHayChuoi = false;
            MaHoaHayGiaiMa = 1;
            ClearProgressBar();
            EnableHoacDisableNut(false);
            MaHoa();
            EnableHoacDisableNut(true);
        }

        private void txtGiaiMaVanBan_Click(object sender, EventArgs e)
        {

            FileHayChuoi = false;
            MaHoaHayGiaiMa = -1;
            ClearProgressBar();
            EnableHoacDisableNut(false);
            MaHoa();
            EnableHoacDisableNut(true);
        }

        private void btnMaHoaFile_Click(object sender, EventArgs e)
        {
            FileHayChuoi = true;
            MaHoaHayGiaiMa = 1;
            ClearProgressBar();
            EnableHoacDisableNut(false);
            Chay();
            EnableHoacDisableNut(true);
        }

        private void btnGiaiMaFile_Click(object sender, EventArgs e)
        {
            FileHayChuoi = true;
            MaHoaHayGiaiMa = -1;
            ClearProgressBar();
            EnableHoacDisableNut(false);
            Chay();
            EnableHoacDisableNut(true);
        }
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            txtFileNguon.Clear();
            txtFileDich.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileNguon.Text = openFileDialog1.FileName;
                txtFileDich.Text = openFileDialog1.FileName.Replace(".", "_2.");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            if (GiaiDoan != -1)
                Dem++;
            if (GiaiDoan == 0)
            {
       
                if (Dem > 200)
                    Dem = 200;
            }
            else if (GiaiDoan == 1)
            {
                if (Dem < 200)
                    Dem = 200;
                if (Dem > 600)
                    Dem = 600;
               
            }
            else if (GiaiDoan == 2)
            {
                if (Dem < 600)
                    Dem = 600;
                if (Dem >= 900)
                    Dem = 900;
                 
            }
            else if (GiaiDoan == 3)
            {
                Dem = 1000;
                
            }
            progressBar1.Value = Dem;
        }

        private void frmMaHoaDES_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread!=null && thread.ThreadState == ThreadState.Running)
                thread.Abort();
            //e.Cancel = DangChay;
        }

        private void txtKhoaFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !(ChuoiHexa.BoHexa.Contains(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void frmMaHoaDES_Load(object sender, EventArgs e)
        {
            txtVanBanNguon.Text = "DES Crypto";
            MaHoa();
        }




        private void ClearProgressBar()
        {
            progressBar1.Value = 0;
        }




        //Xử lý chia khóa và gộp khóa

        private void btnChiaKhoa_Click(object sender, EventArgs e)
        {
            string kq = "Các cặp khóa: \n";
            decimal Key = decimal.Parse(txtKChia.Text);
            decimal P = decimal.Parse(txtPChia.Text);

            int m = 3, t = 3;

            decimal[] v = {0,decimal.Parse(txtGTV1.Text),
                            decimal.Parse(txtGTV2.Text),
                            decimal.Parse(txtGTV3.Text)};
            decimal[] a = {0,decimal.Parse(txtGTA1.Text),
                            decimal.Parse(txtGTA2.Text)};

            for (int i = 1; i <= m; i++)
            {
                decimal l = 0;
                for (int j = t - 1; j > 0; j--)
                {
                    //vong for = pow(vi, j)
                    decimal h = 1;
                    for (int id = 1; id <= j; id++)
                    {
                        h = (h % P * v[i] % P) % P;
                    }

                    l = (l % P + (a[j] % P * h % P) % P) % P;
                }
                decimal y = (Key%P + l%P) % P;
                kq += String.Format("(v{0}, f(v{1}) = ({2}, {3})\n", i, i, v[i], y);
            }
            kq += String.Format("Cần 2/3 cặp (vj, f(vj)) để khôi phục khóa\n");
            richTextBoxChia.Text = kq;
        }

        private void btnGhepKhoa_Click(object sender, EventArgs e)
        {
            decimal p = decimal.Parse(txtPGhep.Text);
            decimal[] v = {0,decimal.Parse(txtV1.Text),
                            decimal.Parse(txtV2.Text),
                            decimal.Parse(txtV3.Text)};

            decimal[] f = {0,decimal.Parse(txtFv1.Text),
                            decimal.Parse(txtFv2.Text),
                            decimal.Parse(txtFv3.Text)};
            decimal k = 0;

                txtKhoaKPHexa.Text = f[2].ToString();
            int t = 3;
            for (int i = 1; i <= t; i++)
            {
                decimal m = 1;
                for (int j = 1; j <= t; j++)
                {
                    if (j != i)
                    {
                        decimal b = v[j] - v[i];
                        decimal n = mul_inv(b, p) % p;
                        n = (v[j] % p * n % p) % p;
                        m = (m % p * n % p) % p;
                    }
                }
                k = (k%p + (f[i]%p * m%p) % p) % p;
            }
            txtKhoaKP.Text = k.ToString();
            txtKhoaKPHexa.Text = Convert.ToString((long)k, 16).ToUpper();
        }


        // Các hàm gộp khóa 
        private static decimal mul_inv(decimal a, decimal b) //a^-1 mod b
        {
            decimal b0 = b, t, q;
            decimal x0 = 0, x1 = 1;
            if (b == 1) return 1;
            while (a < 0) a += b;
            while (a > 1)
            {
                q = (ulong)(a / b);
                t = b; b = a % b; a = t;
                t = x0; x0 = x1 - q * x0; x1 = t;
            }
            if (x1 < 0) x1 += b0;
            return x1;
        }

    }
}
