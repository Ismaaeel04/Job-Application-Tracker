    using Job_Application_Tracker.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.IdentityModel.Tokens;



    namespace Job_Application_Tracker.Controllers
    {


        public class JobApplicationController : Controller
        {


            private readonly DBContext _context;


            public JobApplicationController(DBContext context)
            {

                _context = context;


            }

            public IActionResult Index()
            {


                var applications = _context.JobApplications.ToList();

                return View(applications);


            }


            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(JobApplication application)
            {

                _context.JobApplications.Add(application);
                _context.SaveChanges();
                return RedirectToAction("Index");


            }

            [HttpGet]

            public IActionResult Edit(int id)
            {
                var application = _context.JobApplications.Find(id);

                if (application == null)
                {

                    return NotFound();

                }
                return View(application);


            }

            [HttpPost]

            public IActionResult Edit(JobApplication application)
            {
                
                _context.JobApplications.Update(application);
                _context.SaveChanges();
                return RedirectToAction("Index");



            }





        }





    }