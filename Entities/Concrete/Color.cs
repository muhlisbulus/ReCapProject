using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color:IEntity
    {
        public String ColorName { get; set; }

        public int ColorId { get; set; }


    }
}
