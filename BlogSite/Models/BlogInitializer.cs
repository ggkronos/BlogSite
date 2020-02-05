using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            //Deneme için veri ekleyelim
            List<Category> categories = new List<Category>()
            {
                new Category() {CategoryName = "Magazine"},
                new Category() {CategoryName = "Health"},
                new Category() {CategoryName = "Shoes"},
                new Category() {CategoryName = "Make Up"},
                new Category() {CategoryName = "Food"}
            };

            //Kategori içerisine elemanlar ekledik şimdi bunları context e göndermemiz gerek
            foreach (var category in categories)
            {
                //Context in kategoriler sınıfı/tablosu üzerine ekleme işlemi yapıyoruz.
                context.Categories.Add(category);
            }

            //İşlem bittikten sonra değişiklikleri kaydetmemiz gerekiyor foreach içerisinde seçme işlemi yapıyor 
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog()
                {
                    BlogTitle = "In Bong Joon Ho’s World of Domestic Bliss, Cho Yeo Jeong Is the Star",
                    BlogDescription = "Magazine weekly news",
                    AddedTime = DateTime.Now.AddDays(-30),
                    HomePage = true,
                    Approval = true,
                    Context = "In his film Parasite, the director Bong Joon Ho depicts the parallel universes of two families of four—one rich, one poor—who infiltrate each other’s lives. When the son of the impoverished family is employed to tutor the young daughter of the affluent one, he senses an opportunity, and in short order his sister masquerades as an art therapist for the well-off family’s withdrawn son; his father becomes the family’s chauffeur; and his mother displaces a beloved housekeeper. From their flood-prone semibasement apartment in a slum, the Kims ascend to the Parks’ sleek mansion on a hill.\r\n\r\nThe movie deftly seesaws between empathy for one side and the other: The tonal shifts in Parasite happen so subtly that victims become aggressors—and vice versa—with fascinating speed. Director Bong, as he is known in South Korea, his native country, creates a lacerating, highly entertaining commentary on class resentment and envy. “Parasite is a comedy without clowns, a tragedy without villains,” Bong has said. It’s a film in which the moral high ground does not hold. ",
                    Picture = "1.jpg",
                    CategoryId = 1
                },
                new Blog()
                {
                    BlogTitle = "In Bong Joon Ho’s World of Domestic Bliss, Cho Yeo Jeong Is the Star",
                    BlogDescription = "Magazine weekly news",
                    AddedTime = DateTime.Now.AddDays(-5),
                    HomePage = true,
                    Approval = true,
                    Context = "In his film Parasite, the director Bong Joon Ho depicts the parallel universes of two families of four—one rich, one poor—who infiltrate each other’s lives. When the son of the impoverished family is employed to tutor the young daughter of the affluent one, he senses an opportunity, and in short order his sister masquerades as an art therapist for the well-off family’s withdrawn son; his father becomes the family’s chauffeur; and his mother displaces a beloved housekeeper. From their flood-prone semibasement apartment in a slum, the Kims ascend to the Parks’ sleek mansion on a hill.\r\n\r\nThe movie deftly seesaws between empathy for one side and the other: The tonal shifts in Parasite happen so subtly that victims become aggressors—and vice versa—with fascinating speed. Director Bong, as he is known in South Korea, his native country, creates a lacerating, highly entertaining commentary on class resentment and envy. “Parasite is a comedy without clowns, a tragedy without villains,” Bong has said. It’s a film in which the moral high ground does not hold. ",
                    Picture = "1.jpg",
                    CategoryId = 1
                },
                new Blog()
                {
                    BlogTitle = "In Bong Joon Ho’s World of Domestic Bliss, Cho Yeo Jeong Is the Star",
                    BlogDescription = "Magazine weekly news",
                    AddedTime = DateTime.Now.AddDays(-17),
                    HomePage = true,
                    Approval = true,
                    Context = "In his film Parasite, the director Bong Joon Ho depicts the parallel universes of two families of four—one rich, one poor—who infiltrate each other’s lives. When the son of the impoverished family is employed to tutor the young daughter of the affluent one, he senses an opportunity, and in short order his sister masquerades as an art therapist for the well-off family’s withdrawn son; his father becomes the family’s chauffeur; and his mother displaces a beloved housekeeper. From their flood-prone semibasement apartment in a slum, the Kims ascend to the Parks’ sleek mansion on a hill.\r\n\r\nThe movie deftly seesaws between empathy for one side and the other: The tonal shifts in Parasite happen so subtly that victims become aggressors—and vice versa—with fascinating speed. Director Bong, as he is known in South Korea, his native country, creates a lacerating, highly entertaining commentary on class resentment and envy. “Parasite is a comedy without clowns, a tragedy without villains,” Bong has said. It’s a film in which the moral high ground does not hold. ",
                    Picture = "1.jpg",
                    CategoryId = 2
                },
                new Blog()
                {
                    BlogTitle = "In Bong Joon Ho’s World of Domestic Bliss, Cho Yeo Jeong Is the Star",
                    BlogDescription = "Magazine weekly news",
                    AddedTime = DateTime.Now.AddDays(-30),
                    HomePage = false,
                    Approval = true,
                    Context = "In his film Parasite, the director Bong Joon Ho depicts the parallel universes of two families of four—one rich, one poor—who infiltrate each other’s lives. When the son of the impoverished family is employed to tutor the young daughter of the affluent one, he senses an opportunity, and in short order his sister masquerades as an art therapist for the well-off family’s withdrawn son; his father becomes the family’s chauffeur; and his mother displaces a beloved housekeeper. From their flood-prone semibasement apartment in a slum, the Kims ascend to the Parks’ sleek mansion on a hill.\r\n\r\nThe movie deftly seesaws between empathy for one side and the other: The tonal shifts in Parasite happen so subtly that victims become aggressors—and vice versa—with fascinating speed. Director Bong, as he is known in South Korea, his native country, creates a lacerating, highly entertaining commentary on class resentment and envy. “Parasite is a comedy without clowns, a tragedy without villains,” Bong has said. It’s a film in which the moral high ground does not hold. ",
                    Picture = "1.jpg",
                    CategoryId = 1
                },
                new Blog()
                {
                    BlogTitle = "In Bong Joon Ho’s World of Domestic Bliss, Cho Yeo Jeong Is the Star",
                    BlogDescription = "Magazine weekly news",
                    AddedTime = DateTime.Now.AddDays(-15),
                    HomePage = true,
                    Approval = true,
                    Context = "In his film Parasite, the director Bong Joon Ho depicts the parallel universes of two families of four—one rich, one poor—who infiltrate each other’s lives. When the son of the impoverished family is employed to tutor the young daughter of the affluent one, he senses an opportunity, and in short order his sister masquerades as an art therapist for the well-off family’s withdrawn son; his father becomes the family’s chauffeur; and his mother displaces a beloved housekeeper. From their flood-prone semibasement apartment in a slum, the Kims ascend to the Parks’ sleek mansion on a hill.\r\n\r\nThe movie deftly seesaws between empathy for one side and the other: The tonal shifts in Parasite happen so subtly that victims become aggressors—and vice versa—with fascinating speed. Director Bong, as he is known in South Korea, his native country, creates a lacerating, highly entertaining commentary on class resentment and envy. “Parasite is a comedy without clowns, a tragedy without villains,” Bong has said. It’s a film in which the moral high ground does not hold. ",
                    Picture = "1.jpg",
                    CategoryId = 3
                },
                new Blog()
                {
                    BlogTitle = "In Bong Joon Ho’s World of Domestic Bliss, Cho Yeo Jeong Is the Star",
                    BlogDescription = "Magazine weekly news",
                    AddedTime = DateTime.Now.AddDays(-10),
                    HomePage = true,
                    Approval = true,
                    Context = "In his film Parasite, the director Bong Joon Ho depicts the parallel universes of two families of four—one rich, one poor—who infiltrate each other’s lives. When the son of the impoverished family is employed to tutor the young daughter of the affluent one, he senses an opportunity, and in short order his sister masquerades as an art therapist for the well-off family’s withdrawn son; his father becomes the family’s chauffeur; and his mother displaces a beloved housekeeper. From their flood-prone semibasement apartment in a slum, the Kims ascend to the Parks’ sleek mansion on a hill.\r\n\r\nThe movie deftly seesaws between empathy for one side and the other: The tonal shifts in Parasite happen so subtly that victims become aggressors—and vice versa—with fascinating speed. Director Bong, as he is known in South Korea, his native country, creates a lacerating, highly entertaining commentary on class resentment and envy. “Parasite is a comedy without clowns, a tragedy without villains,” Bong has said. It’s a film in which the moral high ground does not hold. ",
                    Picture = "1.jpg",
                    CategoryId = 4
                }
            };

            foreach (var blog in blogs)
            {
                context.Blogs.Add(blog);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}