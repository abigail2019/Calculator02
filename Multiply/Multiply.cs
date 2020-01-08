using System;
using Operation;
namespace Multiply
{
    public interface IMultiply
    {
        public dynamic Time(dynamic a, dynamic b);
    }
    public class Multiply : IMultiply
    {
        public dynamic result;
        public dynamic Time(dynamic a, dynamic b)
        {
            result = Multiplication.Multiply(a,b);
            return result;
        }
    }
}
