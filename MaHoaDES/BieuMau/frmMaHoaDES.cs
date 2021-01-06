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
using System.Numerics;

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
                        MessageBox.Show("Mã hóa file thành công!", "Thành công");
                    }
                    else
                    {
                        GiaiDoan = 0;
                        ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(txtFileNguon.Text);
                        GiaiDoan = 1;
                        ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, -1);
                        if (KQ == null)
                        {
                            MessageBox.Show("Lỗi giải mã . kiểm tra khóa!", "Lỗi");
                            timer1.Enabled = false;
                            return;
                        }
                        GiaiDoan = 2;
                        DocFileTxt.WriteBinaryToFile(txtFileDich.Text, KQ);
                        GiaiDoan = 3;
                        MessageBox.Show("Giải mã file thành công!", "Thành công");
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
                        MessageBox.Show("Mã hóa chuỗi thành công!", "Thành công");
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
                        MessageBox.Show("Giải mã chuỗi thành công!", "Thành công");
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
            MaHoa();
            EnableHoacDisableNut(true);
        }

        private void txtGiaiMaVanBan_Click(object sender, EventArgs e)
        {

            FileHayChuoi = false;
            MaHoaHayGiaiMa = -1;
            ClearProgressBar();
            MaHoa();
            EnableHoacDisableNut(true);
        }

        private void btnMaHoaFile_Click(object sender, EventArgs e)
        {
            FileHayChuoi = true;
            MaHoaHayGiaiMa = 1;
            ClearProgressBar();
            Chay();
            EnableHoacDisableNut(true);
        }

        private void btnGiaiMaFile_Click(object sender, EventArgs e)
        {
            FileHayChuoi = true;
            MaHoaHayGiaiMa = -1;
            ClearProgressBar();
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
            EnableHoacDisableNut(false);
        }




        //Xử lý chia khóa và gộp khóa

        private void btnChiaKhoa_Click(object sender, EventArgs e)
        {
            bool check = true;
            BigInteger checkP;
            if (String.IsNullOrEmpty(txtKChia.Text) || String.IsNullOrEmpty(txtPChia.Text)
                || String.IsNullOrEmpty(txtGTV1.Text) || String.IsNullOrEmpty(txtGTV2.Text)
                || String.IsNullOrEmpty(txtGTA1.Text))
            {
                check = false;
                MessageBox.Show("Vui lòng nhập lòng nhập đầy đủ thông tin để chia khóa!", "Lỗi");
            }

            else if (BigInteger.TryParse(txtPChia.Text, out checkP) == false || !IsPrime(checkP))
            {
                check = false;
                MessageBox.Show("Vui lòng nhập p phải là một số nguyên tố!", "Lỗi");
            }

            if (check)
            {
                string kq = "Các cặp khóa: \n";
                BigInteger Key = BigInteger.Parse(txtKChia.Text);
                BigInteger P = BigInteger.Parse(txtPChia.Text);

                int m = 2, t = 2;

                BigInteger[] v = {0,BigInteger.Parse(txtGTV1.Text),
                            BigInteger.Parse(txtGTV2.Text)};
                BigInteger[] a = { 0, BigInteger.Parse(txtGTA1.Text) };

                for (int i = 1; i <= m; i++)
                {
                    BigInteger l = 0;
                    for (int j = t - 1; j > 0; j--)
                    {
                        //vong for = pow(vi, j)
                        BigInteger h = BigInteger.ModPow(v[i], j, P);

                        l = (l + (a[j] * h)) % P;
                    }
                    BigInteger y = (Key + l) % P;
                    kq += String.Format("(v{0}, f(v{1}) = ({2}, {3})\n", i, i, v[i], y);
                }
                kq += String.Format("Cần 2/2 cặp (vj, f(vj)) để khôi phục khóa\n");
                richTextBoxChia.Text = kq; 
            }
        }

        private void btnGhepKhoa_Click(object sender, EventArgs e)
        {
            bool check = true;
            BigInteger checkP;
            if (String.IsNullOrEmpty(txtPGhep.Text) || String.IsNullOrEmpty(txtV1.Text)
                || String.IsNullOrEmpty(txtV2.Text) || String.IsNullOrEmpty(txtFv1.Text)
                || String.IsNullOrEmpty(txtFv2.Text))
            {
                check = false;
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để ghép khóa!", "Lỗi");
            }

            else if (BigInteger.TryParse(txtPGhep.Text, out checkP) == false || !IsPrime(checkP))
            {
                check = false;
                MessageBox.Show("Vui lòng nhập p phải là một số nguyên tố!", "Lỗi");
            }

            if (check)
            {
                BigInteger p = BigInteger.Parse(txtPGhep.Text);
                BigInteger[] v = {0,BigInteger.Parse(txtV1.Text),
                            BigInteger.Parse(txtV2.Text)};

                BigInteger[] f = {0,BigInteger.Parse(txtFv1.Text),
                            BigInteger.Parse(txtFv2.Text)};
                BigInteger k = 0;

                txtKhoaKPHexa.Text = f[2].ToString();
                int t = 2;
                for (int i = 1; i <= t; i++)
                {
                    BigInteger m = 1;
                    for (int j = 1; j <= t; j++)
                    {
                        if (j != i)
                        {
                            BigInteger b = v[j] - v[i];
                            BigInteger n = mul_inv(b, p) % p;
                            n = (v[j] * n) % p;
                            m = (m * n) % p;
                        }
                    }
                    txtKhoaKPHexa.Text = m.ToString();
                    k = (k % p + (f[i] % p * m % p) % p) % p;
                }
                txtKhoaKP.Text = k.ToString();
                txtKhoaKPHexa.Text = k.ToString("X"); 
            }
        }


        // Các hàm gộp khóa 
        private static BigInteger mul_inv(BigInteger a, BigInteger b) //a^-1 mod b
        {
            BigInteger b0 = b, t, q;
            BigInteger x0 = 0, x1 = 1;
            if (b == 1) return 1;
            while (a < 0) a += b;
            while (a > 1)
            {
                q = (a / b);
                t = b; b = a % b; a = t;
                t = x0; x0 = x1 - q * x0; x1 = t;
            }
            if (x1 < 0) x1 += b0;
            return x1;
        }
        // Miller rabbin
        public static bool IsPrime(BigInteger n)
        {
            if (n < 2)
                return false;
            if (n == 2 || n == 3 || n == 5 || n == 7)
                return true;
            if (n % 2 == 0)
                return false;

            BigInteger bn = n; // converting to BigInteger here to avoid converting up to 48 times below
            BigInteger n1 = bn - 1;
            int r = 1;
            BigInteger d = n1;
            while (d.IsEven)
            {
                r++;
                d >>= 1;
            }
            if (!Witness(2, r, d, bn, n1)) return false;
            if (!Witness(3, r, d, bn, n1)) return false;
            if (!Witness(5, r, d, bn, n1)) return false;
            if (!Witness(7, r, d, bn, n1)) return false;
            if (!Witness(11, r, d, bn, n1)) return false;
            if (n < 2152302898747) return true;
            if (!Witness(13, r, d, bn, n1)) return false;
            if (n < 3474749660383) return true;
            if (!Witness(17, r, d, bn, n1)) return false;
            if (n < 341550071728321) return true;
            if (!Witness(19, r, d, bn, n1)) return false;
            if (!Witness(23, r, d, bn, n1)) return false;
            if (n < 3825123056546413051) return true;
            return Witness(29, r, d, bn, n1)
                   && Witness(31, r, d, bn, n1)
                   && Witness(37, r, d, bn, n1);
        }

        // a single instance of the Miller-Rabin Witness loop
        private static bool Witness(BigInteger a, int r, BigInteger d, BigInteger n, BigInteger n1)
        {
            var x = BigInteger.ModPow(a, d, n);
            if (x == BigInteger.One || x == n1) return true;

            while (r > 1)
            {
                x = BigInteger.ModPow(x, 2, n);
                if (x == BigInteger.One) return false;
                if (x == n1) return true;
                r--;
            }
            return false;
        }

    }
}
