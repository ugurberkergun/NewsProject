using NewsProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Entities.Concreate
{
    public class News: IEntity
    {
        public int Id { get; set; }
        public string NewsHeader { get; set; }
        public string NewsContext { get; set; }
        public int NewsCategoryId { get; set; }
        public NewsCategory NewsCategory { get; set; }
        public bool IsDeleted { get; set; } =false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public string PhotoUrl { get; set; }

    }
}
