using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcCharacter.Controllers
{
    public class HelloCharacterController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome(string name="Default", int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
