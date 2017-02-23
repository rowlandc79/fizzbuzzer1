using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibrary.Model
{
    public class FizzBuzzResponse
    {
        public Dictionary<Model.FizzBuzzType.Type, int> TypesIndex { get; set; }

        public string Value { get; set; }

        public FizzBuzzResponse ()
        {
            TypesIndex = new Dictionary<Model.FizzBuzzType.Type, int>();

        }

        public int GetTypeCount(FizzBuzzType.Type type)
        {
            return TypesIndex.Where(s => s.Key == type).Select(d => d.Value).Sum();
        }


    }
}
