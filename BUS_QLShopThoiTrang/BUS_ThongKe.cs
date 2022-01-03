using DAL_QLShopThoiTrang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLShopThoiTrang;

namespace BUS_QLShopThoiTrang
{
    public class BUS_ThongKe
    {
        DAL_ThongKe dal_thongke = new DAL_ThongKe();
        public DataTable DanhSachHoaDon()
        {
            return dal_thongke.DanhSachHoaDon();
        }
        public DataTable TimHoaDon(DateTime ngaybatdau, DateTime ngayketthuc,string tennv)
        {
            return dal_thongke.TimHoaDon(ngaybatdau, ngayketthuc, tennv);
        }
        public DataTable ThongKeTongHop(DateTime tuNgay, DateTime denNgay)
        {
            return dal_thongke.ThongKeTongHop(tuNgay, denNgay);
        }
    }
}
