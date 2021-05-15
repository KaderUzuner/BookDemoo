using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }

    }
}
