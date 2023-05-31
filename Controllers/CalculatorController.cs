using laba_4.Models;
using Microsoft.AspNetCore.Mvc;


namespace laba_4.Conrollers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model, string action)
        {
            if (action == "clear")
            {
                model.Num1 = 0;
                model.Num2 = 0;
                model.Operation = "+";
                ViewBag.Result = null;
            }
            else
            {
                float result = 0;

                switch (model.Operation)
                {
                    case "+":
                        result = model.Num1 + model.Num2;
                        break;
                    case "-":
                        result = model.Num1 - model.Num2;
                        break;
                    case "*":
                        result = model.Num1 * model.Num2;
                        break;
                    case "/":
                        result = model.Num1 / model.Num2;
                        break;
                }

                ViewBag.Result = result;
            }

            return View(model);
        }
    }

}