using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinances.WebApi.Models.Response
{
    public class Response
    {
        public Response()
        {
            Errors = new List<Error>();
        }

        
        public List<Error> Errors { get; set; }
        /*
        public bool IsSuccess
        {
            get
            {
                return Errors == null || !Errors.Any();
            }
        }
        */
        // to samo co znaczy co zaremowany zapis wyżej
        public bool IsSuccess => Errors == null || !Errors.Any();
    }
}
