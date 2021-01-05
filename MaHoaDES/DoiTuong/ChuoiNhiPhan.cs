using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaHoaDES.DoiTuong
{
    class ChuoiNhiPhan
    {
        /// <summary>
        /// Lớp thể hiện một chuỗi nhị phân với các thuộc tính và chức năng 
        /// </summary>
        public int[] MangNhiPhan { get;   set; } // chứa mảng nhị phân ví dụ: 011011011010
        private double _doDai;//độ dài của mảng nhị phân
        string _text = "";// đưa mảng nhị phân về dạng text để tiện hiển thị
        public int DoDai
        {
            get { return MangNhiPhan.Length; }
        }

        /// <summary>
        /// Hàm tạo lập
        /// tọa mới 1 chuỗi với chiều dài cố định
        /// </summary>
        /// <param name="doDai"></param>
        public ChuoiNhiPhan(int doDai)
        {
            MangNhiPhan = new int[doDai];
        }
        /// <summary>
        /// Tạo 1 chuỗi từ một mảng nhị phân
        /// </summary>
        /// <param name="mangNhiPhan"></param>
        public ChuoiNhiPhan(int[] mangNhiPhan)
        {
            MangNhiPhan = mangNhiPhan;
        }
        /// <summary>
        /// Tạo mới 1 chuỗi biểu diễ 1 ký tự
        /// </summary>
        /// <param name="kyTu"></param>
        public ChuoiNhiPhan(char kyTu )
        {
            MangNhiPhan = new int[16];
            int MaUnicode = (int)kyTu;
            int i = 15;
            while (MaUnicode > 0)
            {
                MangNhiPhan[i] = MaUnicode % 2;
                MaUnicode = MaUnicode / 2;
                i--;
            }
        }


        public string Text
        {
            get { return GetText(); }
        }
        // chuyển mảng nhị phân sang text
        public string GetText()
        {
            string str = "";
            foreach (var ch in MangNhiPhan)
            {
                str += ch.ToString();
            }
            return str;
        }
        /// <summary>
        /// Cắt chuỗi nhị phân thành các chuỗi con. tương tự như trong String.substring(start,number)
        /// thực chất của việc cắt là lấy mảng nhị phân từ vị trí start với số lượng nào đó
        /// </summary>
        /// <param name="viTriBatDau"></param>
        /// <param name="SoLuong"></param>
        /// <returns></returns>
        public ChuoiNhiPhan Cat(long viTriBatDau, long SoLuong) // vị trí căt và số lượng bit bị cắt
        {
            int[] mangNhiPhanDuocCat = new int[SoLuong];
            for (long i = viTriBatDau; i < viTriBatDau + SoLuong;i++ )
            {
                mangNhiPhanDuocCat[i - viTriBatDau] = MangNhiPhan[i];
            }
            return (new ChuoiNhiPhan(mangNhiPhanDuocCat));// trả về mảng con thu được từ việc cắt
        }
        /// <summary>
        /// Hàm này thực hiện khi 1 chuỗi dữ liệu có số bit không chia hết cho 64
        /// chúng ta cần bổ sung thêm số bit thiếu để chúng là bội của 64
        /// Khi giải mã chúng ta cần cắt phần vừa bổ sung đó đi
        /// Để làm được điều đó ta làm 2 bước
        /// 1. Bổ sung các bit 0 vào để chuỗi có độ dài chia hết cho 64
        /// 1. thêm 64 bit biểu diễn độ dài thực của chuỗi vào cuối chuỗi. đẻ khi giải mã
        ///     ta dựa vào 64 bit này để cắt đi các bit thừa
        /// </summary>
        /// <returns></returns>
        public ChuoiNhiPhan ChinhDoDai64() 
        {
            int Mod = DoDai % 64;
            int thieu = 64 - Mod;// số bit thiếu cần bổ sung để chuỗi có độ dài là bội của 64
            ChuoiNhiPhan chuoiBuThieu = new ChuoiNhiPhan(thieu);
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(MangNhiPhan);
            KQ = KQ.Cong(chuoiBuThieu);// công thêm chuỗi bù

            ChuoiNhiPhan ChuoiChieuDai = ChuoiNhiPhan.ChuyenSoSangNhiPhan((int)DoDai, 64);// mã hóa chiều dài thực của chuỗi thành 64 bit
            KQ = KQ.Cong(ChuoiChieuDai); //công thêm 64 bit ddso vào chuỗi
            return KQ;
        }
        /// <summary>
        /// Khi giải mã chúng ta cần loại bỏ các bit bù đi để giải mã các bit đúng mà thôi
        /// bằng cách:
        /// 1 -  cắt lấy 64bit cuối, chuyển chúng về dạng số để biết được độ dài thực của chuỗi
        /// 2 - chỉ lấy số bit tương ứng với chiều dài
        /// </summary>
        /// <returns></returns>
        public ChuoiNhiPhan CatDuLieu64()
        {           
            ChuoiNhiPhan ChuoiChieuDai=this.Cat(DoDai-64,64);// lấy 64 bit cuối
            long d = ChuoiNhiPhan.ChuyenNhiPhanSangSo(ChuoiChieuDai); // chuyển sang số
            
            ChuoiNhiPhan KQ = this.Cat(0, DoDai - 64); // chỉ lấy số bit tương ứng vs chiefu dài
            if (d < 0 || d > KQ.DoDai)
                return null;
            KQ = KQ.Cat(0, d);
            return KQ;
        }
      
        #region cac phep toan
        /// <summary>
        /// Phép toán XOR giữa hai chuỗi
        /// trả về 1 chuỗi tương ứng với cách XOR
        /// 1 - 1 = 0
        /// 1 - 0 = 1
        /// 0 - 1 = 1
        /// 0 - 0 = 0
        /// </summary>
        /// <param name="Chuoi2"></param>
        /// <returns></returns>
        public ChuoiNhiPhan XOR(ChuoiNhiPhan Chuoi2)
        {
            if(DoDai!=Chuoi2.DoDai)
                return null;
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(DoDai);
            int x = 0,y=0;// duyệt qua từng phần tử của hai chuỗi
            for (int i = 0; i < ChuoiKQ.DoDai; i++)
            {
                x = MangNhiPhan[i];
                y = Chuoi2.MangNhiPhan[i];
                if (x !=y) // XOR
                {
                    ChuoiKQ.MangNhiPhan[i] = 1;
                }
                else
                {
                    ChuoiKQ.MangNhiPhan[i] = 0;
                }
            }
            return ChuoiKQ;
        }
        /// <summary>
        /// Dịch bit sang trái
        /// chuyển bit ở vị trí i+1 thành bit i và thêm bit ở vị trí 0 ở chuỗi ban đầu vào cuối kq
        /// </summary>
        /// <param name="SoBitDich"></param>
        /// <returns></returns>
        public ChuoiNhiPhan DichTraiBit(int SoBitDich)
        {
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(MangNhiPhan);
            int tam = 0;
            for (int i = 0; i < SoBitDich; i++) // số bit dịch là bao nhiêu thì dịch bấy nhieue lần
            {
                tam = MangNhiPhan[0];
                for (int j = 0; j < MangNhiPhan.Length - 1; j++)
                {
                    KQ.MangNhiPhan[j] = MangNhiPhan[j + 1]; // cho phân tử i=i+1
                }
                KQ.MangNhiPhan[MangNhiPhan.Length - 1] = tam; // cho phàn tử cuối cùng ở kq thành ptu 00 ở ban đàu
            }
            return (KQ);
        }                 
        /// <summary>
        /// Phép công hai chuỗi tương đương với phép nối hai chuỗi nhị phân lại với nhau
        /// </summary>
        /// <param name="chuoi2"></param>
        /// <returns></returns>
        public ChuoiNhiPhan Cong(ChuoiNhiPhan chuoi2)
        {
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(chuoi2.DoDai + this.DoDai);
            for (int i = 0; i < DoDai; i++)
            {
                ChuoiKQ.MangNhiPhan[i] = MangNhiPhan[i];
            }
            for (int i = 0; i < chuoi2.DoDai; i++)
            {
                ChuoiKQ.MangNhiPhan[DoDai + i] = chuoi2.MangNhiPhan[i];
            }
            return ChuoiKQ; // thêm chuỗi 2 vào bên phải chuỗi 1
        }
        /// <summary>
        /// Chia 1 chuỗi thành hai chuỗi bằng nhau
        /// trả về mảng chứ hai chuỗi đó
        /// </summary>
        /// <returns></returns>
        public ChuoiNhiPhan[] ChiaDoi( )
        {
            ChuoiNhiPhan ChuoiTrai = new ChuoiNhiPhan(this.DoDai/2);
            ChuoiNhiPhan ChuoiPhai = new ChuoiNhiPhan(DoDai- ChuoiTrai.DoDai);
            for (int i = 0; i < ChuoiTrai.DoDai; i++)
            {
                ChuoiTrai.MangNhiPhan[i] = MangNhiPhan[i];
            }
            for (int i = 0; i < ChuoiPhai.DoDai; i++)
            {
                ChuoiPhai.MangNhiPhan[i] = MangNhiPhan[i+ChuoiTrai.DoDai];
            }
            return (new ChuoiNhiPhan[]{ChuoiTrai,ChuoiPhai});
        }
        /// <summary>
        /// Chia 1 chuỗi thành n chuỗi con
        /// bằng việc chia mảng nhị phân thành n phần khác nhau
        /// </summary>
        /// <param name="SoLuong"></param>
        /// <returns></returns>
        public ChuoiNhiPhan[] Chia(int SoLuong)
        {
            ChuoiNhiPhan[] KQ = new ChuoiNhiPhan[SoLuong];
            ChuoiNhiPhan chuoi;
            int SoBit= DoDai/SoLuong; // số bit của 1 chuỗi con
            int[]  NhiPhan = new int[SoBit] ;
            int leng= SoBit;
            for (int i = 0; i < SoLuong ; i++)
            {
                if (i * SoBit + SoBit > DoDai)
                {
                    SoBit = DoDai - i * SoBit;
                }
                NhiPhan = new int[SoBit];
                for (int j = i * SoBit; j < i * SoBit + SoBit; j++)
                {
                    NhiPhan[j - i * SoBit] = MangNhiPhan[j];
                }
                chuoi = new ChuoiNhiPhan(NhiPhan);
                KQ[i] = chuoi;
            }            
            return (KQ);
        }
        #endregion
        #region Cac Ham convert

        /// <summary>
        /// Hàm chuyển 1 sô sang nhị phân theo cơ số 2
        /// </summary>
        /// <param name="SoInput"></param>
        /// <param name="doDai"></param>
        /// <returns></returns>
        public static ChuoiNhiPhan ChuyenSoSangNhiPhan(int SoInput, int doDai)
        {
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(doDai);
            int i = doDai - 1;
            while (SoInput > 0)
            {
                ChuoiKQ.MangNhiPhan[i] = SoInput % 2;
                SoInput = SoInput / 2;
                i--;
            }
            return ChuoiKQ;
        }
        public static int[] ChuyenSoSangMangNhiPhan(int SoInput, int doDai)
        {
            int[] MangNhiPhan = new int[doDai];
            int i = doDai - 1;
            while (SoInput > 0)
            {
                MangNhiPhan[i] = SoInput % 2;
                SoInput = SoInput / 2;
                i--;
            }
            return MangNhiPhan;
        }

        /// <summary>
        /// Chuyển số sang chuỗi nhị phân nhưng ở dạng text
        /// </summary>
        /// <param name="SoInput"></param>
        /// <param name="doDai"></param>
        /// <returns></returns>
        public static string ChuyenSoSangStringNhiPhan(int SoInput, int doDai)
        {
            return ChuyenSoSangNhiPhan(SoInput,doDai).Text;
        }
        /// <summary>
        /// Chuyeren ngược lại nhị phân sang số
        /// </summary>
        /// <param name="ChuoiVao"></param>
        /// <returns></returns>
        public static int ChuyenNhiPhanSangSo(ChuoiNhiPhan ChuoiVao)
        {
            int KQ = 0;
            for (int i = ChuoiVao.DoDai - 1; i >= 0; i--)
            {
                KQ += ChuoiVao.MangNhiPhan[i]* (int)Math.Pow(2, ChuoiVao.DoDai- i-1);
            }
            return KQ;
        }

        /// <summary>
        /// Chuyển từ chuỗi nhị phân dạng text sang số
        /// </summary>
        /// <param name="ChuoiVao"></param>
        /// <returns></returns>
        public static ChuoiNhiPhan ChuyenChuSangChuoiNhiPhan(string ChuoiVao)
        {
            try
            {
                ChuoiVao = ChuoiVao.Trim();
                int[] mangNhiPhan = new int[ChuoiVao.Length];
                for (int i = ChuoiVao.Length - 1; i >= 0; i--)
                {
                    mangNhiPhan[i] = int.Parse(ChuoiVao[i].ToString());
                }
                return (new ChuoiNhiPhan(mangNhiPhan));
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

        public static int ChuyenMangSangByte(int[] mang, int batDau, int KetThuc)
        {
           
                int KQ = 0;
                for (int i = KetThuc - 1; i >= batDau; i--)
                {
                    KQ += mang[i] * (int)Math.Pow(2, KetThuc - i - 1);
                }
                return KQ;
             

        }
        /// <summary>
        /// Chuyển từ chuỗi nhị phân dạng text sang số
        /// </summary>
        /// <param name="ChuoiVao"></param>
        /// <returns></returns>
        public static int ChuyenNhiPhanSangSo(string ChuoiVao)
        {
            int KQ = 0;
            for (int i = ChuoiVao.Length - 1; i >= 0; i--)
            {
                KQ +=  int.Parse(ChuoiVao[i].ToString()) * (int)Math.Pow(2, ChuoiVao.Length - i - 1);
            }
            return KQ;
        }
        /// <summary>
        /// chuyển mảng nhị phân thành chuỗi text 
        /// </summary>
        /// <param name="ChuoiVao"></param>
        /// <returns></returns>
        public static string ChuyenNhiPhanSangChu(ChuoiNhiPhan ChuoiVao)
        {
 
            int soChu = ChuoiVao.DoDai / 16;
            ChuoiNhiPhan[] MangChuoi = ChuoiVao.Chia(soChu);
            string KQ = "";
            foreach (var ch in MangChuoi)
            {
                KQ += (char) ChuyenNhiPhanSangSo(ch);
            }
            return KQ;
 
        }  
        /// <summary>
        /// chuyển 1 chuỗi các char thành 1 mảng nhị phân bằng cách chuyển từng ký tự char thành nhị phân rồi cộng vào
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static ChuoiNhiPhan ChuyenChuSangNhiPhan(string text)
        {
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(0);
            ChuoiNhiPhan chuoi;
            foreach (var ch in text)
            {
                chuoi = new ChuoiNhiPhan(ch);
                KQ = KQ.Cong(chuoi);
            }
            return KQ;

        }
        public static ChuoiNhiPhan ChuyenKhoaSangNhiPhan(string text)
        {
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(0);
            ChuoiNhiPhan chuoi;
            foreach (var ch in text)
            {
                chuoi = ChuoiNhiPhan.ChuyenSoSangNhiPhan((int)ch,16);
                KQ = KQ.Cong(chuoi);
            }
            return KQ;

        }
        #endregion
    }
}
