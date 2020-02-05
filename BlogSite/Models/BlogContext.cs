using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    //Ef code first özellikleri kazandırmak için Dbcontext ten türetmemiz gerek
    public class BlogContext : DbContext
    {
        //Veritabanımızı yöneten sınıf
        //İçerisine çalışacağımız entity sınıflarını tanıtmamız gerek


        //Veritabanı adını değiştirmek için
        public BlogContext():base("BlogDb")
        //Bir isim vermeyip connectionstringde verebiliriz.Direk bir isim verirsek o isimde oluşturur yada 
        //connectionstring den name kısmını parametre olarak alır.
        {
            //Initializer sınıfı bir değişiklik olduğunda tetiklensin diye
            Database.SetInitializer(new BlogInitializer());
        }

        //Entity tablolarımızı eklerken sonlarına s takısı ekliyor yani çoğaltıyor bunu engellemek için yazdığımız kod
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        //Tablolara karşılık gelen alanlarımız
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}