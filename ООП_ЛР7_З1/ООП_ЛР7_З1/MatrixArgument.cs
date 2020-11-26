using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛР7_З1
{
    public class MatrixArgument<T> where T : struct
    {
        public MatrixArgument(T value) { Value = value; }
        public T Value { get; set; }
    }
}
