using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld.Pages
{
    public class FormsModel : PageModel
    {
        // These variables may be accessed from the cshtml when prefixed with "Model.".
        public string requestType { get; set; }
        public bool isPost { get; set; }


        public void OnGet()
        {
            requestType = "Get";
            isPost = false;
        }
        public void OnPost()
        {
            requestType = "Post";
            isPost = true;
        }
    }
}