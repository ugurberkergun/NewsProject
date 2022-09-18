using NewsProject.Core.DAL;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.DAL.Abstract
{
    public interface INewsDal : IEntityRepository<News>
    {
    }
}
