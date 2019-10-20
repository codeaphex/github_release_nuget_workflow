using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_release_nuget_workflow
{
    public class HelloWorld
    {
        public string Greetings()
        {
            return $"Hello Earthling from version: {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}"; 
        }
    }
}
