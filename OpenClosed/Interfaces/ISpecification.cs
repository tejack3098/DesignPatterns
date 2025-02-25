using OpenClosed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }
}
