using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Todo:IEntity
    {
        public int TodoId { get; set; }
        public int CategoryId { get; set; }
        public string TodoName { get; set; }
        public bool IsCompleted { get; set; }
    }
}
