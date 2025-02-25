using OpenClosed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Models
{
    public class SizeSpecification: ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        { 
            this.size = size;
        }

        public bool IsSatisfied(Product p) 
        {
            return p.Size == size;
        }
    }
}
