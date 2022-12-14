using System.Collections.Generic;

namespace _02_MVVM_Demo
{
    public class SimpleClass
    {
        public int a { get; set; }
        public int b { get; set; }
        public int sum { get; set; }
        /// <summary>
        /// Khoi tao du lieu
        /// </summary>
        /// <returns></returns>
        public List<SimpleClass> InitData()
        {
            List<SimpleClass> lstResult = new List<SimpleClass>();
            lstResult.Add(new SimpleClass { a = 1, b = 2, sum = 3 });
            lstResult.Add(new SimpleClass { a = 4, b = 7, sum = 11 });
            return lstResult;
        }
    }
}
