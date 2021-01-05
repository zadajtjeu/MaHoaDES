using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaHoaDES.HangSo;
using System.Windows.Forms;

namespace MaHoaDES.DoiTuong
{
    class DES64Bit
    {
        /// <summary>
        /// Hàm mã hóa và giải mã bằng thuật toán DES 
        /// gồm 1 khóa đẻ mã hóa các chuỗi vào
        /// </summary>
        public Khoa KhoaDES { get; private set; }
        public ChuoiNhiPhan ThucHienDES(Khoa key,ChuoiNhiPhan ChuoiVaoDai, int MaHoaHayGiaiMa)// 1 ma hoa, -1 giai ma
        {
            this.KhoaDES = key;// lấy khóa chính
            if(MaHoaHayGiaiMa==1) // nếu là mã hóa thì cần chỉnh lại độ dài của chúng sao cho chia hết cho 64
                ChuoiVaoDai =ChuoiVaoDai.ChinhDoDai64() ;
            
            KhoaDES.SinhKhoaCon( ); // sinh dẫy các khóa con
            ChuoiNhiPhan[] DSChuoiVao = ChuoiVaoDai.Chia(ChuoiVaoDai.DoDai / 64);// chia dữ liệu vào thành từng khối 64 bit và xử lý dần dần
            ChuoiNhiPhan ChuoiVao,ChuoiKQ;
            ChuoiKQ = new ChuoiNhiPhan(0);
            ChuoiNhiPhan[] ChuoiSauIP;
            ChuoiNhiPhan ChuoiSauIP_1;
            ChuoiNhiPhan L, R, F, TG;
            for (int k = 0; k < DSChuoiVao.Length; k++)  // duyêt qua từng chuỗi được chai
            {
                //ChuoiVao = DSChuoiVao[k];
                
                // b1: tính IP
                ChuoiSauIP = CacThongSo.TinhIP(DSChuoiVao[k]);
                // lấy giá trị L,R
                L = ChuoiSauIP[0];
                R = ChuoiSauIP[1];

                for (int i = 0; i < 16; i++)
                {
                    // tính hàm F giữa khóa phụ Right
                    F = HamF(R, KhoaDES.DayKhoaPhu[MaHoaHayGiaiMa==1?i:15-i]);
                    L = L.XOR(F);// tính XOR giữa L và giá trị hàm F
                    TG = L;// đổi L và R cho nhau
                    L = R;
                    R = TG;
                }
                // tính IP_1
                ChuoiSauIP_1 = CacThongSo.TinhIP_1( R,L);

                // cộng thêm chuỗi đã ddc mã hóa vào
                ChuoiKQ = ChuoiKQ.Cong(ChuoiSauIP_1);
            }
            if (MaHoaHayGiaiMa == -1) // nếu là giải mã thì cần cắt bớt các bit bù vào ban đầu
                ChuoiKQ = ChuoiKQ.CatDuLieu64();
            return ChuoiKQ;
        }

        /// <summary>
        /// Để mã hóa 1 chuỗi string
        /// Đơn giản là chuyển string thành mảng nhị phân và đưa vào hàm mã hóa DES
        /// </summary>
        /// <param name="key"></param>
        /// <param name="ChuoiVao"></param>
        /// <param name="MaHoaHayGiaiMa"></param>
        /// <returns></returns>
        public string ThucHienDESText(Khoa key,string ChuoiVao, int MaHoaHayGiaiMa)// 1 ma hoa, -1 giai ma
        {
            ChuoiNhiPhan chuoiNhiPhan;
            if (MaHoaHayGiaiMa == 1)
            {
                chuoiNhiPhan = ChuoiNhiPhan.ChuyenChuSangNhiPhan(ChuoiVao);
            }
            else
            {
                chuoiNhiPhan = ChuoiNhiPhan.ChuyenChuSangChuoiNhiPhan(ChuoiVao);
            }            
            ChuoiNhiPhan KQ = ThucHienDES(key,chuoiNhiPhan, MaHoaHayGiaiMa);
            if (MaHoaHayGiaiMa == 1)
            {
                return KQ.Text;
            }
            if (KQ == null)
            {
                MessageBox.Show("Lỗi giải mã . kiểm tra khóa ");
                return "";
            }
            return ChuoiNhiPhan.ChuyenNhiPhanSangChu(KQ);// chueyren sang dạng text để hiện thị kết quả
        }       
        /// <summary>
        /// Hàm tính F 
        /// đầu vào: chuỗi cần tính (C0 hoặc D0) và khóa co thứ k
        /// </summary>
        /// <param name="chuoiVao"></param>
        /// <param name="KhoaCon"></param>
        /// <returns></returns>
        private ChuoiNhiPhan HamF(ChuoiNhiPhan chuoiVao, ChuoiNhiPhan KhoaCon)
        {
            ChuoiNhiPhan KQ=CacThongSo.TinhE(chuoiVao); // Tính E trước
            KQ = KQ.XOR(KhoaCon); // tính XOR 
            KQ = CacThongSo.TinhSBox(KQ); // tính hộp s-box
            KQ = CacThongSo.TinhP(KQ); // tính P là ok
            return KQ;
        }

    }
}
