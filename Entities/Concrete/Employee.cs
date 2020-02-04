using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
