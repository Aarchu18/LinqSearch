using LinqSearch.Models.SearchData;
using LinqSearch.Models.SearchModel;
using Microsoft.AspNetCore.Mvc;

namespace LinqSearch.Controllers
{
    public class SearchController : Controller
    {
        
        public IActionResult Index()
        {
            var model = SearchDataModel.GetStudentDetail();
            return View(model);
        }

        public IActionResult SearchByName(StudentModel studentName)
        {
            if(studentName.name != null) {
                var model = SearchDataModel.GetStudentByName(studentName.name);
                if (model != null)
                {
                    return PartialView("_SingleStudentDetailPartial", model);
                }
            }
            
            return NotFound();
        }
    }
}