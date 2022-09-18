using NewsProject.Core.Entities;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Entities.Dtos
{
    public class UpdateNewsDto:IDto
    {
        public int Id { get; set; }
        public string NewsHeader { get; set; }
        public string NewsContext { get; set; }
        public string NewsCategoryId { get; set; }
        public string PhotoUrl { get; set; }
    }
}
