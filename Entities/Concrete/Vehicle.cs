using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Vehicles: IEntity
    {
        public string Description { get; set; }
        public int BrandId { get; set; }
    }
}
