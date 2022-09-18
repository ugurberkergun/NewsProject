using NewsProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Entities.Dtos
{
    public class DeleteNewsDto:IDto
    {
        public int Id { get; set; }
        public string NewsHeader { get; set; }
        public string NewsContext { get; set; }
        public int NewsCategoryId { get; set; }
        public DateTime DeletedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = true;
        public string PhotoUrl { get; set; }

    }
}
