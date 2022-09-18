using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result:IResult
    {
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public  Result ( bool success)
        {
            Success = success;
        }
        // 2 tane ctor olmasının sebebi, kullanıcı bazen mesajı görmek istemeyebilir.Bunun yerine sadece başırılı mı değil mi onu da öğrenmek isteyebilir.
        // 2. ctor un amacı budur.
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
