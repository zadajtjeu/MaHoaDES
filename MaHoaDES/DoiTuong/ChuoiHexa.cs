using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaHoaDES.DoiTuong
{
    class ChuoiHexa
    {
        /// <summary>
        /// Lớp đối tượng thể hiện chuỗi hexa hệ thập lục phân
        /// </summary>
        public string Chuoi { get; private set; } // chuỗi nội dung
        private int _doDai; // độ dài của chuỗi
        public ChuoiNhiPhan chuoiNhiPhan { get; private set; }// lưu trữ dạng cơ số 2
        public static readonly string BoHexa = "0123456789ABCDEFabcdef";// bộ chữ trong hệ 16
        public int DoDai
        {
            get { return Chuoi.Length; }            
        }
       /// <summary>
       /// Tạo lập một chuỗi hexa từ 1 chuỗi chữ cái bên ngoài đưa vào
       /// </summary>
       /// <param name="chuoi"></param>
        public ChuoiHexa(string chuoi)
        {
            this.Chuoi = chuoi.ToUpper(); // đưa về chữ hoa hết cho dễ đọc
            ChuoiNhiPhan chNP;//   
            if (KiemTra())// kiểm tra xem chuỗi này có hợp lệ k
            {
                chuoiNhiPhan = new ChuoiNhiPhan(0);
                foreach (var ch in Chuoi)// chuyển sang cơ số 2
                {
                    chNP= ChuoiNhiPhan.ChuyenSoSangNhiPhan(ChuoiHexa.ChuyenHexaSangHe10(ch),4); // chuyển từng ký tự 1 về dạng 4bit cơ số 2
                    chuoiNhiPhan = chuoiNhiPhan.Cong(chNP);
                }
            }
        }
        /// <summary>
        /// Kiểm tra xem chuỗi này có phải hệ hexa k
        /// 
        /// </summary>
        /// <returns></returns>
        public bool KiemTra()
        {
            bool Kt = true;
            foreach (char ch in Chuoi)
            {
                if (!ChuoiHexa.BoHexa.Contains(ch))// nếu có 1 ký tự k nằm trong bộ hexa thì báo lỗi
                {
                    Kt = false;
                    break;

                }
            }
            return Kt;
        }
        /// <summary>
        /// Chuyển 1 ký tự trong hệ 16 sang hệ 10
        /// </summary>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int ChuyenHexaSangHe10(char K)
        {

            int KQ = 0;
            switch (K)
            {
                case '0':
                    KQ = 0;
                    break;
                case '1':
                    KQ = 1;
                    break;
                case '2':
                    KQ = 2;
                    break;
                case '3':
                    KQ = 3;
                    break;
                case '4':
                    KQ = 4;
                    break;
                case '5':
                    KQ = 5;
                    break;
                case '6':
                    KQ = 6;
                    break;
                case '7':
                    KQ = 7;
                    break;
                case '8':
                    KQ = 8;
                    break;
                case '9':
                    KQ = 9;
                    break;
                case 'A':
                    KQ = 10;
                    break;
                case 'B':
                    KQ = 11;
                    break;
                case 'C':
                    KQ = 12;
                    break;
                case 'D':
                    KQ = 13;
                    break;
                case 'E':
                    KQ = 14;
                    break;
                case 'F':
                    KQ = 15;
                    break;
            }
            return KQ;
        }


    }
}
