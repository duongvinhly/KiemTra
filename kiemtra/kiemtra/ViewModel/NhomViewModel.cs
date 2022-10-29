using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kiemtra.Model;

namespace kiemtra.ViewModel
{
    public class NhomViewModel
    {
        public int ID { get; set; }
        public string TenNhom { get; set; }

        public NhomViewModel()
        {

        }

        public static void AddNhom(Nhom nhom)
        {
            var db = new Model1();
            var rs = db.Nhoms.Add(nhom);
            db.SaveChanges();
        }

        public static List<NhomViewModel> Getlist()
        {
            

            var db = new Model1();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom,
            }).ToList();
            return rs;
        }
        public static void DeleteNhom(int id)
        {
            var db = new Model1();
            var sinhvien = db.Nhoms.Where(e => e.ID == id).FirstOrDefault();
            var rs = db.Nhoms.Remove(sinhvien);
            db.SaveChanges();
        }
    }
}
