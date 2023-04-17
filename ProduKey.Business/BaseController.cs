using ProduKey.DataAccess;
using ProduKey.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduKey.Business
{
    public class BaseController
    {
        public ProduKeyContext db;
        public BaseController()
        {
            db = new ProduKeyContext();
        }

        //Slider Başlangıç
        public List<Slider> Slider_List()
        {
            return db.Sliders.ToList();
        }

        public Slider Slider_Find(int id)
        {
            return db.Sliders.FirstOrDefault(x => x.ID == id);
        }
        public bool Slider_Insert(Slider model)
        {
            try
            {
                db.Sliders.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Slider_Update(Slider model)
        {
            var find = db.Sliders.FirstOrDefault();
            if (find != null)
            {
                find.SliderTitle = model.SliderTitle;
                find.imageUrl = model.imageUrl;
                find.SliderContent = model.SliderContent;
                find.SliderButtonName = model.SliderButtonName;
                find.SliderButtonUrl = model.SliderButtonUrl;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Slider_Delete(int id)
        {
            var find = Slider_Find(id);
            if (find != null)
            {

                db.Sliders.Remove(find);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Slider Bitiş
        //*********************************************************************************************************
        //Hakkımızda Başlangıç
        public bool AboutContent_Update(AboutContent model)
        {
            var find = db.aboutContents.FirstOrDefault();
            if (find != null)
            {
                find.Content = model.Content;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AboutImage_Update(AboutImage model)
        {
            var find = db.aboutImages.FirstOrDefault();
            if (find != null)
            {
                find.Image = model.Image;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Hakkımızda Bitiş
        //*******************************************************************************************************************
        //Ayar Başlangıç
        public List<Setting> Setting_List()
        {
            return db.Settings.ToList();
        }
        public bool SettingSeo_Update(Setting model)
        {
            var find = db.Settings.FirstOrDefault();
            if (find != null)
            {
                find.SiteName = model.SiteName;
                find.Keywords = model.Keywords;
                find.Description = model.Description;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Ayar Bitiş
        //*****************************************************************************************
        //Hesap Ayarı Başlangıç
        public bool Profile_Update(Admin model)
        {
            var find = db.Admins.FirstOrDefault();
            if (find != null)
            {
                find.UserName = model.UserName;
                find.UserSurname = model.UserSurname;
                find.Tel = model.Tel;
                find.Mail = model.Mail;
                find.Address = model.Address;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Instagram_Update(Admin model)
        {
            var find = db.Admins.FirstOrDefault();
            if (find != null)
            {
                find.Instagram = model.Instagram;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Twitter_Update(Admin model)
        {
            var find = db.Admins.FirstOrDefault();
            if (find != null)
            {
                find.Twitter = model.Twitter;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Linkedin_Update(Admin model)
        {
            var find = db.Admins.FirstOrDefault();
            if (find != null)
            {
                find.Linkedin = model.Linkedin;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Facebook_Update(Admin model)
        {
            var find = db.Admins.FirstOrDefault();
            if (find != null)
            {
                find.Facebook = model.Facebook;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Hesap Ayarı Bitiş
        //*******************************************************************************************************************
        //Kurs Başlangıç
        public List<Course> Course_List()
        {
            return db.Courses.ToList();
        }

        public Course Course_Find(int id)
        {
            return db.Courses.FirstOrDefault(x => x.ID == id);
        }
        public bool Course_Insert(Course model)
        {
            try
            {
                db.Courses.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Course_Update(Course model)
        {
            var find = db.Courses.FirstOrDefault(x => x.ID == model.ID);
            if (find != null)
            {
                find.CourseImage = model.CourseImage;
                find.CourseQuota = model.CourseQuota;
                find.CoursePrice = model.CoursePrice;
                find.CourseTeacher = model.CourseTeacher;
                find.CourseTimes = model.CourseTimes;
                find.CourseName = model.CourseName;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Course_Delete(int id)
        {
            var find = Course_Find(id);
            if (find != null)
            {

                db.Courses.Remove(find);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Kurs Bitiş
        //*******************************************************************************************************************
        //Eğitmen Ekle
        public List<Educator> Educator_List()
        {
            return db.Educators.ToList();
        }

        public Educator Educator_Find(int id)
        {
            return db.Educators.FirstOrDefault(x => x.ID == id);
        }
        public bool Educator_Insert(Educator model)
        {
            try
            {
                db.Educators.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Educator_Update(Educator model)
        {
            var find = db.Educators.FirstOrDefault(x => x.ID == model.ID);
            if (find != null)
            {
                find.Image = model.Image;
                find.Name = model.Name;
                find.Department = model.Department;
                find.Facebook = model.Facebook;
                find.Twitter = model.Twitter;
                find.Instagram = model.Instagram;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Educator_Delete(int id)
        {
            var find = Educator_Find(id);
            if (find != null)
            {

                db.Educators.Remove(find);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Eğitmen Bitiş
        //*******************************************************************************************************************
        //Yorum Ekle
        public List<Comment> Comment_List()
        {
            return db.Comments.ToList();
        }

        public Comment Comment_Find(int id)
        {
            return db.Comments.FirstOrDefault(x => x.ID == id);
        }
        public bool Comment_Insert(Comment model)
        {
            try
            {
                db.Comments.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Comment_Update(Comment model)
        {
            var find = db.Comments.FirstOrDefault(x => x.ID == model.ID);
            if (find != null)
            {
                find.CommentName = model.CommentName;
                find.CommentContent = model.CommentContent;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Comment_Delete(int id)
        {
            var find = Comment_Find(id);
            if (find != null)
            {

                db.Comments.Remove(find);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Yorum Bitiş
        //*********************************************************************************************
        //İletişim
        public List<Inbox> Inbox_List()
        {
            return db.Inboxs.ToList();
        }

        public Inbox Inbox_Find(int id)
        {
            return db.Inboxs.FirstOrDefault(x => x.ID == id);
        }
        public bool Inbox_Insert(Inbox model)
        {
            try
            {
                db.Inboxs.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Inbox_Delete(int id)
        {
            var find = Inbox_Find(id);
            if (find != null)
            {

                db.Inboxs.Remove(find);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
