using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMoreBooks.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }


    }
}
