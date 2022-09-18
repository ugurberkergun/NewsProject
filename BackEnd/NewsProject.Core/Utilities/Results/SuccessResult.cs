using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        // success result zaten success true olduğunda olacağı için direk true veriyoruz.
        public SuccessResult(string message):base(success:true,message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
