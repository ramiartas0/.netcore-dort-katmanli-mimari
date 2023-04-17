using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProduKey.Business;
using ProduKey.DataAccess;
using ProduKey.Entity;

namespace ProduKey.UI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public BaseController bc = new BaseController();

        public ProduKeyContext db;
        public AdminController()
        {
            db = new ProduKeyContext();
        }
        [Route("index")]
        public IActionResult Index()
        {
            
            return View();
        }
        [Route("account")]
        public IActionResult Account()
        {
            var AdminFind = db.Admins.FirstOrDefault();
            ViewBag.UserName = AdminFind.UserName;
            ViewBag.UserSurname = AdminFind.UserSurname;
            ViewBag.Tel = AdminFind.Tel;
            ViewBag.Mail = AdminFind.Mail;
            ViewBag.Address = AdminFind.Address;
            ViewBag.Instagram = AdminFind.Instagram;
            ViewBag.Twitter = AdminFind.Twitter;
            ViewBag.Facebook = AdminFind.Facebook;
            ViewBag.Linkedin = AdminFind.Linkedin;
            
            return View();
        }
        [Route("profile-update")]
        [HttpPost]

        public IActionResult ProfileUpdate(Admin model)
        {
            var kontrol = bc.Profile_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Account", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("instagram-update")]
        [HttpPost]

        public IActionResult InstagramUpdate(Admin model)
        {
            var kontrol = bc.Instagram_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Account", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("twitter-update")]
        [HttpPost]

        public IActionResult TwitterUpdate(Admin model)
        {
            var kontrol = bc.Twitter_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Account", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("linkedin-update")]
        [HttpPost]

        public IActionResult LinkedinUpdate(Admin model)
        {
            var kontrol = bc.Linkedin_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Account", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("facebook-update")]
        [HttpPost]

        public IActionResult FacebookUpdate(Admin model)
        {
            var kontrol = bc.Facebook_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Account", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("setting")]
        public IActionResult Setting()
        {

            return View(db.Settings.FirstOrDefault());
        }
        [Route("setting-seo-update")]
        [HttpPost]

        public IActionResult SettingSeoUpdate(Setting model)
        {
            var kontrol = bc.SettingSeo_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Setting", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("slider")]
        public IActionResult Slider()
        {
            return View(bc.Slider_List().ToList());
        }
        [Route("slider-insert")]
        public IActionResult SliderInsert()
        {
            return View();
        }
        [Route("slider-insert")]
        [HttpPost]
        public IActionResult SliderInsert(Slider model)
        {
            var SliderFind = bc.Slider_Insert(model);
            if (SliderFind != null)
            {
               
                return RedirectToAction("Slider", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("slider-update/{id}")]
        public IActionResult SliderUpdate(int id)
        {
            return View(bc.Slider_Find(id));

        }
        [HttpPost]

        public IActionResult SliderUpdate(Slider model)
        {
            var kontrol = bc.Slider_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Slider", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("slider-delete/{id}")]
        public IActionResult SliderDelete(int id)
        {
            var sil = bc.Slider_Delete(id);
            if (sil != null)
            {
                
                return RedirectToAction("Slider", "Admin");
            }

            else
            {
                
                return RedirectToAction("Slider", "Admin");
            }
        }
        [Route("about")]
        public IActionResult About()
        {
            var ContentsFind = db.aboutContents.FirstOrDefault();
            var ImagesFind = db.aboutImages.FirstOrDefault();
            ViewBag.AboutContent = ContentsFind.Content;
            ViewBag.AboutImage = ImagesFind.Image;
            return View();
        }

        [Route("about-content-update")]
        [HttpPost]

        public IActionResult AboutContentUpdate(AboutContent model)
        {
            var kontrol = bc.AboutContent_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("About", "Admin");
            }
            else
            {
                
                return View();
            }

        }
        [Route("about-imaget-update")]
        [HttpPost]

        public IActionResult AboutImagetUpdate(AboutImage model)
        {
            var kontrol = bc.AboutImage_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("About", "Admin");
            }
            else
            {
                
                return View();
            }

        }
        [Route("course")]
        public IActionResult Course()
        {
            var CoursesFind = db.Courses.FirstOrDefault();
            ViewBag.CourseImage = CoursesFind.CourseImage;
            ViewBag.CourseTimes = CoursesFind.CoursePrice;
            ViewBag.CourseImage = CoursesFind.CourseName;
            ViewBag.CourseImage = CoursesFind.CourseTeacher;
            ViewBag.CourseImage = CoursesFind.CourseTimes;
            ViewBag.CourseImage = CoursesFind.CourseQuota;
            ViewBag.EducatorList = db.Educators.ToList();
            return View(bc.Course_List().ToList());
        }
        [Route("course-insert")]
        public IActionResult CourseInsert()
        {
            return View();
        }
        [Route("course-insert")]
        [HttpPost]
        public IActionResult CourseInsert(Course model)
        {
            var CourseFind = bc.Course_Insert(model);
            if (CourseFind != null)
            {
               
                return RedirectToAction("Course", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("course-update")]
        [HttpPost]

        public IActionResult CourseUpdate(Course model)
        {
            var kontrol = bc.Course_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Course", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("course-delete/{id}")]
        public IActionResult CourseDelete(int id)
        {
            var sil = bc.Course_Delete(id);
            if (sil != null)
            {
                
                return RedirectToAction("Course", "Admin");
            }

            else
            {
                
                return RedirectToAction("Course", "Admin");
            }
        }
        [Route("educatore")]
        public IActionResult Educator()
        {
            var CoursesFind = db.Courses.FirstOrDefault();
            ViewBag.CourseImage = CoursesFind.CourseImage;
            ViewBag.CourseTimes = CoursesFind.CoursePrice;
            ViewBag.CourseImage = CoursesFind.CourseName;
            ViewBag.CourseImage = CoursesFind.CourseTeacher;
            ViewBag.CourseImage = CoursesFind.CourseTimes;
            ViewBag.CourseImage = CoursesFind.CourseQuota;
            return View(bc.Educator_List().ToList());
        }
        [Route("educator-insert")]
        public IActionResult EducatorInsert()
        {
            return View();
        }
        [Route("educator-insert")]
        [HttpPost]
        public IActionResult EducatorInsert(Educator model)
        {
            var EducatorFind = bc.Educator_Insert(model);
            if (EducatorFind != null)
            {
               
                return RedirectToAction("Educator", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("educator-update")]
        [HttpPost]

        public IActionResult EducatorUpdate(Educator model)
        {
            var kontrol = bc.Educator_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Educator", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("educator-delete/{id}")]
        public IActionResult EducatorDelete(int id)
        {
            var sil = bc.Educator_Delete(id);
            if (sil != null)
            {
                
                return RedirectToAction("Educator", "Admin");
            }

            else
            {
                
                return RedirectToAction("Educator", "Admin");
            }
        }
        [Route("comment")]
        public IActionResult Comment()
        {

            return View(bc.Comment_List().ToList());
        }
        [Route("comment-insert")]
        public IActionResult CommentInsert()
        {
            return View();
        }
        [Route("comment-insert")]
        [HttpPost]
        public IActionResult CommentInsert(Comment model)
        {
            var CommentFind = bc.Comment_Insert(model);
            if (CommentFind != null)
            {
               
                return RedirectToAction("Comment", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("comment-update")]
        [HttpPost]

        public IActionResult CommentUpdate(Comment model)
        {
            var kontrol = bc.Comment_Update(model);
            if (kontrol != null)
            {
                
                return RedirectToAction("Comment", "Admin");
            }
            else
            {
                
                return View();
            }
        }
        [Route("comment-delete/{id}")]
        public IActionResult CommentDelete(int id)
        {
            var sil = bc.Comment_Delete(id);
            if (sil != null)
            {
                
                return RedirectToAction("Comment", "Admin");
            }

            else
            {
                
                return RedirectToAction("Comment", "Admin");
            }
        }

        [Route("inbox")]
        public IActionResult Inbox()
        {

            return View(bc.Inbox_List().ToList());
        }
        [Route("inbox-delete")]
        public IActionResult InboxDelete(int id)
        {
            var sil = bc.Inbox_Delete(id);
            if (sil != null)
            {
                
                return RedirectToAction("Inbox", "Admin");
            }

            else
            {
                
                return RedirectToAction("Inbox", "Admin");
            }
        }
    }
}
