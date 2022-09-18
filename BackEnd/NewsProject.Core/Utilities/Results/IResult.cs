using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; } // yapılan işlem başarılı mı değil mi sorgusu.Sadece readonly.
        string Message { get; } // yapılan işlemin mesajı
    }
}
