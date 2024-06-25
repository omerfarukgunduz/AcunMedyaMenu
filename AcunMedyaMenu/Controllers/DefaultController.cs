using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{

	public class DefaultController : Controller
	{
		MenuContext context=new MenuContext();
		public IActionResult Index()
		{
			return View();

			ViewBag.p1 = "250 yıllık sırlarla dolu özel odamıza hoşgeldiniz. Burası AcunMedya bir odaya sığan kocaman dostluklar, kutlamalar, özel anlaşmalar ve davetleri için Olden tutkunlarına açıldı. Eski bir hikayede yeni uzun sofralar kurmak için rezervasyon yaptırmanız yeterli. ";
			ViewBag.p2 = "Geçmişin değerlerini içselleştirip onları bugünle buluşturarak geleceğe taşıyan tohumları atmayı hedefleyen Lacivert, menüsünü bu anlayışla hazırlıyor. Menümüzün klasikleşen lezzetlerine, yeni ve çarpıcı dokunuşlar da ekleyerek mevsimselliği ve yerelin güzelliklerini yansıtan bir çerçeve içinde hareket ediyoruz, daha bilinçli bir tüketimi hedefliyoruz. ";

        }
		public PartialViewResult PartialHead()
		{ 
			return PartialView();
		}

		public PartialViewResult PartialNavbar() 
		{
			return PartialView();
		}

		public PartialViewResult PartialCarousel()
		{
			return PartialView();
		}

		public PartialViewResult PartialScript()
		{
			return PartialView();
		}

		public PartialViewResult PartialFooter()
		{
			return PartialView();
		}

		public PartialViewResult PartialContact()
		{
			return PartialView();
		}

		public PartialViewResult PartialTestimonial()
		{
			return PartialView();
		}

		public PartialViewResult PartialTeam()
		{
			return PartialView();
		}
		public PartialViewResult PartialFeature()
		{
			return PartialView();
		}
		public PartialViewResult PartialAbout()
		{
			return PartialView();
		}
		public PartialViewResult PartialMenu()
		{
			return PartialView();
		}

		[HttpGet]
		public PartialViewResult CreateBooking()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult CreateBooking(Booking booking) 
		{
			booking.Description = "Rezervasyon Alındı";
			context.Bookings.Add(booking);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
