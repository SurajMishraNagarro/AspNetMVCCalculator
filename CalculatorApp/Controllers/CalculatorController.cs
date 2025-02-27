using Microsoft.AspNetCore.Mvc;
using CalculatorApp.Models;


namespace CalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        // This method will manage the basic get request on the index or root url of the app
        // and return the view , here in this case it will be index.cshtml
        // Default behaviour of this method is get
        public IActionResult Index()
        {
            var model = new CalculatorModel();
            return View(model);
        }

        // now some post requests using diff methods that will take data from view, use the model 
        // class , update the data and reshare it to the view 

        // ADD Method

        [HttpPost] // do the post request to the url
        public IActionResult Add(CalculatorModel model)
        {
            model.Result = model.Add();
            return View("Index", model);
        }

        //Subtract Method
        [HttpPost]
        public IActionResult Subtract(CalculatorModel model)
        {
            model.Result = model.Subtract();
            return View("Index", model);
        }

        //Multiply Method
        [HttpPost]
        public IActionResult Multiply(CalculatorModel model)
        {
            model.Result = model.Multiply();
            return View("Index", model);
        }


        ///Divide Method
        [HttpPost]
        public IActionResult Divide(CalculatorModel model)
        {
            var result = model.Divide();
            if (result == "Error: Division by zero.")
            {
                /**
                 
                 here viewbag is a way to share data from controller to view
                 I am assigning the result which is the error message to the ErrorMessage 
                 porperty of the viewbag 

                 but why ?  I am updating the viewbag as i want to pass some data to view without 
                 modifying the model.

                Also it is a temporary data , only valid for this request .

                this is to tell the view see error is happend with this request.
                
                 **/

                ViewBag.ErrorMessage = result;
            }
            else
            {
                model.Result = int.Parse(result);
            }
            return View("Index", model);
        }



    }
}
