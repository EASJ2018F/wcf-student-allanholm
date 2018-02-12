using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyNameWCFservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        
        public string GetName()
        {
            return "Allan";
        }

        public string GetMyEmail()
        {
            return "alla2653@easj.edu.dk";
        }
    }
}
