using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_18_09_24
{
    public class Product
    {
        public string tensp { set; get; }
        public float gia { set; get; }
        public string mota { set; get; }   
        public int soluong { get; set; }
        public Product(string tensp, float gia,string mota, int soluong)
        {
            this.tensp = tensp;
            this.gia = gia;
            this.mota = mota;
            this.soluong = soluong;
        }
        public virtual void hienthi()
        {
            Console.WriteLine("tensp:" + tensp + "  gia" + gia + "  soluong:" + soluong);
        }
    }
    public class Electronic : Product
    {
        private int baohiem { set; get; }
        public Electronic(string tensp, float gia,string mota, int soluong , int baohiem):base(tensp, gia,mota, soluong)        
        {
            this.baohiem = baohiem;

        }

        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("   bao hiem:" + baohiem + "   thang");
        }
    }
    public class Clothing : Product
    {
        public string size { set; get; }
        public string color { set; get; }
        public Clothing(string tensp, float gia,string mota, int soluong, string size, string color):base(tensp,gia,mota, soluong)
        {
            this.size = size;
            this.color = color;
        }
        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("size:" + size + "    color:" + color);
        }
    }

    public class Food:Product
    {
        public DateTime ngay_het_han;
        public Food(string tensp, float gia,string mota, int soluong,DateTime ngay_het_han):base(tensp,gia,mota,soluong)
        {
            this.ngay_het_han = ngay_het_han;
        }
        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("     ngay het han:" + ngay_het_han);
        }
    }
}
