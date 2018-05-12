using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore.Models;
using System.Web.Mvc;

namespace BookStore.Models
{
    public class Giohang
    {
        QuanLyBanSachDataContext db = new QuanLyBanSachDataContext();

        public int iMasach { set; get; }
        public string sTensach { set; get; }
        public string sAnhbia { set; get; }
        public Double dDongia { set; get; }
        public int iSoluong { set; get; }

        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        public Giohang(int Masach)
        {
            iMasach = Masach;
            SACH sach = db.SACHes.Single(n => n.Masach == iMasach);
            sTensach = sach.Tensach;
            sAnhbia = sach.Hinhminhhoa;
            dDongia = double.Parse(sach.Dongia.ToString());
            iSoluong = 1;
        }

    }
}