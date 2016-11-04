using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject.Pages
{
    public class HomePage : BasePage
    {
        protected readonly string url = ConfigurationManager.AppSettings["HomeUrl"];
    }
}
