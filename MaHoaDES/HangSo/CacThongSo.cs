using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaHoaDES.DoiTuong;

namespace MaHoaDES.HangSo
{
    class CacThongSo
    {       
    /// <summary>
    /// Nơi lưu trữ các bảng thông số cơ bản của DES
    /// </summary>
       private static readonly int[] PC1 ={ 57, 49, 41, 33, 25, 17, 9, 1, 58, 50, 
                                          42, 34, 26, 18, 10, 2, 59, 51, 43, 35, 
                                          27, 19, 11, 3, 60, 52, 44, 36, 63, 55, 
                                          47, 39, 31, 23, 15, 7, 62, 54, 46, 38, 
                                          30, 22, 14, 6, 61, 53, 45, 37, 29, 21, 
                                          13, 5, 28, 20, 12, 4 };
       private static readonly int[] PC2 ={ 14, 17, 11, 24, 1, 5, 3, 28, 15, 6, 21, 
                                          10, 23, 19, 12, 4, 26, 8, 16, 7, 27, 
                                          20, 13, 2, 41, 52, 31, 37, 47, 55, 30, 
                                          40, 51, 45, 33, 48, 44, 49, 39, 56, 34, 
                                          53, 46, 42, 50, 36, 29, 32 };
       private static readonly int[] IP ={ 58, 50, 42, 34, 26, 18, 10, 2, 60, 52, 
                                           44, 36, 28, 20, 12, 4, 62, 54, 46, 38, 
                                           30, 22, 14, 6, 64, 56, 48, 40, 32, 24, 
                                           16, 8, 57, 49, 41, 33, 25, 17, 9, 1,
                                           59, 51, 43, 35, 27, 19, 11, 3, 61, 53, 
                                           45, 37, 29, 21, 13, 5, 63, 55, 47, 39, 
                                           31, 23, 15, 7 };
       private static readonly int[] IP_1 ={ 40, 8, 48, 16, 56, 24, 64, 32, 39, 7, 
                                            47, 15, 55, 23, 63, 31, 38, 6, 46, 14, 
                                            54, 22, 62, 30, 37, 5, 45, 13, 53, 21, 
                                            61, 29, 36, 4, 44, 12, 52, 20, 60, 28, 
                                            35, 3, 43, 11, 51, 19, 59, 27, 34, 2, 
                                            42, 10, 50, 18, 58, 26, 33, 1, 41, 9, 
                                            49, 17, 57, 25 };
       private static readonly int[] E ={ 32, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 8, 
                                          9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 
                                          17, 16, 17, 18, 19, 20, 21, 20, 21, 22, 
                                          23, 24, 25, 24, 25, 26, 27, 28, 29, 28, 
                                          29, 30, 31, 32, 1 };
       private static readonly int[] P ={ 16, 7, 20, 21, 29, 12, 28, 17, 1, 15, 23, 
                                          26, 5, 18, 31, 10, 2, 8, 24, 14, 32, 
                                          27, 3, 9, 19, 13, 30, 6, 22, 11, 4, 25 };

       private static readonly int[] nrOfShifts ={ 0, 1, 1, 2, 2, 2, 2, 2, 2, 1, 
                                                2, 2, 2, 2, 2, 2, 1 };

       


       private static readonly int[,] sBox1 ={ { 14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7 }, 
                                         { 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8 }, 
                                         { 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0 }, 
                                         { 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 } };
       private static readonly int[,] sBox2 ={ { 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10 }, 
                                         { 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5 }, 
                                         { 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15 }, 
                                         { 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 } };
       private static readonly int[,] sBox3 ={ { 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8 }, 
                                         { 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1 }, 
                                         { 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7 }, 
                                         { 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12 } };
       private static readonly int[,] sBox4 ={ { 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15 }, 
                                         { 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9 }, 
                                         { 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4 }, 
                                         { 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 } };
       private static readonly int[,] sBox5 ={ { 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9 }, 
                                         { 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6 }, 
                                         { 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14 }, 
                                         { 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 } };
       private static readonly int[,] sBox6 ={ { 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11 }, 
                                         { 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8 }, 
                                         { 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6 }, 
                                         { 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 } };
       private static readonly int[,] sBox7 ={ { 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1 }, 
                                         { 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6 }, 
                                         { 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2 }, 
                                         { 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 } };
       private static readonly int[,] sBox8 ={ { 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7 }, 
                                         { 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2 }, 
                                         { 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8 }, 
                                         { 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 } };
       public static readonly int[] soBitDichTaiCacVong ={  1, 1, 2, 2, 2, 2, 2, 2, 1, 
                                                2, 2, 2, 2, 2, 2, 1 };
       private static List<int[,]> sBoxes = new List<int[,]>();
        // tạo mảng các sbox
        public static void  TaoCacThongSo()
        {
            sBoxes.Add(sBox1);
            sBoxes.Add(sBox2);
            sBoxes.Add(sBox3);
            sBoxes.Add(sBox4);
            sBoxes.Add(sBox5);
            sBoxes.Add(sBox6);
            sBoxes.Add(sBox7);
            sBoxes.Add(sBox8);
        }
        #region LayCacThongSo
        /// <summary>
        /// Tinh IP
        /// 
        /// </summary>
        /// <param name="chuoiVao"></param>
        /// <returns></returns>
        public static ChuoiNhiPhan[] TinhIP(ChuoiNhiPhan chuoiVao) // 1 ma hoa, -1 giai ma
        {
            ChuoiNhiPhan ChuoiSauIP = new ChuoiNhiPhan(chuoiVao.DoDai);
            for (int i = 0; i < chuoiVao.DoDai; i++)
            {
                ChuoiSauIP.MangNhiPhan[i] = chuoiVao.MangNhiPhan[ IP[i]-1];
            }
            return ChuoiSauIP.ChiaDoi();
        }

        // Tính IP_1
        public static ChuoiNhiPhan TinhIP_1(ChuoiNhiPhan chuoiTrai, ChuoiNhiPhan chuoiPhai) // 1 ma hoa, -1 giai ma
        {
            ChuoiNhiPhan ChuoiNoi =chuoiTrai.Cong(chuoiPhai);
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(ChuoiNoi.DoDai);
            for (int i = 0; i < ChuoiNoi.DoDai; i++)
            {
                KQ.MangNhiPhan[i] = ChuoiNoi.MangNhiPhan[IP_1[i] - 1];
            }
            return KQ;
        }

        // Tính PC1
        public static ChuoiNhiPhan[] TinhPC1(ChuoiNhiPhan chuoiVao)
        {
            ChuoiNhiPhan ChuoiSauPC1 = new ChuoiNhiPhan(56);
            for (int i = 0; i < ChuoiSauPC1.DoDai; i++)
            {
                ChuoiSauPC1.MangNhiPhan[i] = chuoiVao.MangNhiPhan[PC1[i]-1];
            }
            return ChuoiSauPC1.ChiaDoi();
        }

        // Tính PC2
        public static ChuoiNhiPhan TinhPC2(ChuoiNhiPhan chuoiTrai, ChuoiNhiPhan chuoiPhai)
        {
            ChuoiNhiPhan CongChuoiVao = chuoiTrai.Cong(chuoiPhai);
            ChuoiNhiPhan ChuoiSauPC2 = new ChuoiNhiPhan(48);

            for (int i = 0; i < ChuoiSauPC2.DoDai; i++)
            {
                ChuoiSauPC2.MangNhiPhan[i] = CongChuoiVao.MangNhiPhan[PC2[i]-1];
            }
            return ChuoiSauPC2;
        }

        // Tính bảng mở rộng E
        public static ChuoiNhiPhan TinhE(ChuoiNhiPhan chuoiVao)
        {
            ChuoiNhiPhan chuoiKQ = new ChuoiNhiPhan(48);
            for (int i = 0; i < chuoiKQ.DoDai; i++)
            {
                chuoiKQ.MangNhiPhan[i] = chuoiVao.MangNhiPhan[E[i]-1];
            }
            return chuoiKQ;

        }

        // Tính P
        public static ChuoiNhiPhan TinhP(ChuoiNhiPhan chuoiVao)
        {
            ChuoiNhiPhan chuoiKQ = new ChuoiNhiPhan(32);
            for (int i = 0; i < chuoiKQ.DoDai; i++)
            {
                chuoiKQ.MangNhiPhan[i] = chuoiVao.MangNhiPhan[P[i]-1];
            }
            return chuoiKQ;

        }

        // Tính 8 sbox
        public static ChuoiNhiPhan TinhSBox(ChuoiNhiPhan chuoiVao)
        {
            ChuoiNhiPhan chuoiKQ  ;
            ChuoiNhiPhan[] ChuoiBiChia = chuoiVao.Chia(8);
            chuoiKQ = Tinh1SBox(ChuoiBiChia[0],sBox1);
            chuoiKQ = chuoiKQ.Cong(Tinh1SBox(ChuoiBiChia[1], sBox2));
            chuoiKQ = chuoiKQ.Cong(Tinh1SBox(ChuoiBiChia[2], sBox3));
            chuoiKQ = chuoiKQ.Cong(Tinh1SBox(ChuoiBiChia[3], sBox4));
            chuoiKQ = chuoiKQ.Cong(Tinh1SBox(ChuoiBiChia[4], sBox5));
            chuoiKQ = chuoiKQ.Cong(Tinh1SBox(ChuoiBiChia[5], sBox6));
            chuoiKQ = chuoiKQ.Cong(Tinh1SBox(ChuoiBiChia[6], sBox7));
            chuoiKQ = chuoiKQ.Cong(Tinh1SBox(ChuoiBiChia[7], sBox8));
            return chuoiKQ;
        }

        // tính 1 sbox
        private static ChuoiNhiPhan Tinh1SBox(ChuoiNhiPhan chuoiVao,int[,] sBox)
        {
            // giá trị hamgf = giá trị hệ 10 của hai bit đầu và cuối
            // giá trị cột= giá trị hệ 10 của 4 bit còn lại
            int[] GiaTriDauVaDuoi= new int[]{chuoiVao.MangNhiPhan[0],chuoiVao.MangNhiPhan[5]};
            int Hang = ChuoiNhiPhan.ChuyenNhiPhanSangSo(new ChuoiNhiPhan( GiaTriDauVaDuoi));
            int[] GiaTriGiua= new int[]{chuoiVao.MangNhiPhan[1],chuoiVao.MangNhiPhan[2],chuoiVao.MangNhiPhan[3],chuoiVao.MangNhiPhan[4]};
            int Cot = ChuoiNhiPhan.ChuyenNhiPhanSangSo(new ChuoiNhiPhan(GiaTriGiua));

            int GiaTriSbox = sBox[Hang, Cot];
            return (ChuoiNhiPhan.ChuyenSoSangNhiPhan(GiaTriSbox,4));// chuyển giá trị tại sbox sang nhị phân
        }
        #endregion

    }
}
