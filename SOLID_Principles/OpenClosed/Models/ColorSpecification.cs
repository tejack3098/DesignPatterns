﻿using OpenClosed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Models
{
    public class ColorSpecification: ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        { 
            this.color = color;
        }

        public bool IsSatisfied(Product p) 
        {
            return p.Color == color;
        }
    }
}
