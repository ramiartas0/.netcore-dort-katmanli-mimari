using ProduKey.Business;
using Microsoft.AspNetCore.Mvc;
using ProduKey.DataAccess;

namespace ProduKey.UI.Controllers
{
    public class AnasayfaController :Controller
    {
        public BaseController bc = new BaseController();

        public ProduKeyContext db;
        public AnasayfaController()
        {
            db = new ProduKeyContext();
        }

        public IActionResult Index()
        {
            Settings();
            return View();
        }
        public void Settings()
        {
            var AdminFind = db.Admins.FirstOrDefault();

            if(AdminFind != null)
            {
                ViewBag.UserName = AdminFind.UserName;
                ViewBag.UserSurname = AdminFind.UserSurname;
                ViewBag.Tel = AdminFind.Tel;
                ViewBag.Mail = AdminFind.Mail;
                ViewBag.Address = AdminFind.Address;
                ViewBag.Instagram = AdminFind.Instagram;
                ViewBag.Twitter = AdminFind.Twitter;
                ViewBag.Facebook = AdminFind.Facebook;
                ViewBag.Linkedin = AdminFind.Linkedin;
            }
            var SettingFind = db.Settings.FirstOrDefault();
            if (SettingFind != null)
            {
               
                ViewBag.SiteName = SettingFind.SiteName;
                ViewBag.Description = SettingFind.Description;
                ViewBag.Keywords = SettingFind.Keywords;
            }
            ViewBag.SliderList = db.Sliders.ToList();
            ViewBag.CourseList = db.Courses.ToList();
            ViewBag.EducatorList = db.Educators.ToList();
            ViewBag.CommentList = db.Comments.ToList();
            var ContentsFind = db.aboutContents.FirstOrDefault();
            var ImagesFind = db.aboutImages.FirstOrDefault();
            ViewBag.AboutContent = ContentsFind.Content;
            ViewBag.AboutImage = ImagesFind.Image;

        }
    }
}
