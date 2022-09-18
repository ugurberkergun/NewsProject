using NewsProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Entities.Concreate
{
    public class NewsCategory:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<News> News { get; set; }
    }
}
