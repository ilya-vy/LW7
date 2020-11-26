using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛР7_З1
{
    public class Matrix2D<T> where T : struct
    {
        public MatrixArgument<T>[,] Arguments { get; set; }

        public IEnumerable<MatrixArgument<T>> LinearArguments
        {
            get
            {
                foreach (var arg in Arguments)
                {
                    yield return arg;
                }
            }
        }
        public int RowCount { get; set; }
        public int ColCount { get; set; }
    }
}
