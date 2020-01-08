using System;
using Operation;
namespace Divided

{
    public interface IDiving
    {
        public dynamic Squared(dynamic a, dynamic b);
    }
    public class Dividing: IDiving
    {
        public dynamic result;
        public dynamic Squared(dynamic a, dynamic b)
        {
            result = Division.Divsion(a,b);
            return result;
        }
    }
}
