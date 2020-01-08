using System;
using Operation;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Subtracted(dynamic a, dynamic b);
    }
    public class Subtract:ISubtract
    {
        public dynamic results;
        public dynamic Subtracted(dynamic a, dynamic b)
        {
            results = Subtraction.Subtract(a,b);
            return results;
        }
    }
}
