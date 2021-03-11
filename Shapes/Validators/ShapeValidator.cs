using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AreaLibrary.Shapes.Validators
{
    public static class ShapeValidator
    {
        public static bool IsValid(Shape shape)
        { 
              return shape.Validation();
        }
    }
}
