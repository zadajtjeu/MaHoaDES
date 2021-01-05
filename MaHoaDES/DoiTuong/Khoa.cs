using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaHoaDES.HangSo;

namespace MaHoaDES.DoiTuong
{
    class Khoa
    {
         /// <summary>
         /// Lớp khóa
         /// lưu trữ thông tin của một khóa trong hệ mã hóa DES
         /// chúng bao gồm:
         /// - 1 khóa chính ở dnagj nhị phân 64bit
         /// - 16 khóa con ở dạng nhị phân sinh ra từ thuật toán sinh khóa
         /// </summary>
        ChuoiNhiPhan KhoaChinhNhiPhan; // khóa chính 64bit
        public ChuoiNhiPhan[] DayKhoaPhu {get; private set;} // dãy 16 khóa con
        /// <summary>
        /// Tạo mới 1 khóa từ chuỗi string 16 ký tự
        /// </summary>
        /// <param name="khoa"></param>
        public Khoa(string khoa) 
        {
            KhoaChinhNhiPhan = new ChuoiNhiPhan(0);
            foreach (var ch in khoa)
            {
                KhoaChinhNhiPhan=KhoaChinhNhiPhan.Cong(ChuoiNhiPhan.ChuyenSoSangNhiPhan(ChuoiHexa.ChuyenHexaSangHe10(ch), 4));
            }
            //KhoaChinhNhiPhan = ChuoiNhiPhan.ChuyenKhoaSangNhiPhan(khoa); // chuyển chuỗi ký tự sang nhị phân và gán cho khóa chính
        }
        /// <summary>
        /// Kiểm tra xem khóa có bị lỗi không
        /// khóa k bị lỗi là khóa có độ dài chia hết cho 64
        /// </summary>
        /// <returns></returns>
        public bool KiemTraKhoa()
        {
            return (KhoaChinhNhiPhan.DoDai % 64==0);            
        }
        /// <summary>
        /// Thuật toán sinh 16 khóa con từ khóa chính 64 bit
        /// </summary>
        public void SinhKhoaCon()  
        {
            DayKhoaPhu = new ChuoiNhiPhan[16];
            ChuoiNhiPhan C0,D0, MotKhoaPhu;
            // b1: tính PC1
            ChuoiNhiPhan[] ChuoiSauPC1 = CacThongSo.TinhPC1(KhoaChinhNhiPhan);
            // sau khi qua PC1 sẽ có 56bit còn lại được chia thành 2 mảng C0 và D0
            C0 = ChuoiSauPC1[0];
            D0 = ChuoiSauPC1[1];
            // thực hiện 16 vòng để được 16 khóa
            for (int i = 0; i < 16; i++)
            {                
                // dịch trái hai chuỗi nhị phân với số bít bị dịch được quy định trước
                // vòng 1,2,9 là 1 bit
                // còn lại dịch 2 bit
                C0 = C0.DichTraiBit(CacThongSo.soBitDichTaiCacVong[i]);
                D0 = D0.DichTraiBit(CacThongSo.soBitDichTaiCacVong[i]);                
                // Khóa phụ thu được sau khi tính PC2 từ C và D
                MotKhoaPhu = CacThongSo.TinhPC2(C0, D0);       
                // thêm khóa phụ vào mảng khóa phụ
                DayKhoaPhu[i] = MotKhoaPhu;                         
            }// cứ thé 16 vòng ta thu được 16 khóa phụ

        }
    }
}
