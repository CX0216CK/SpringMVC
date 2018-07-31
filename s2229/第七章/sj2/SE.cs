using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
  public class SE:Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int ren { get; set; }
        public int Popularity;
        public SE(string id, string name, int age, string gender, int popularity, List<father> list)
            : base(id, age, name, gender, list)
        {
            this.Popularity = popularity;
        }
    }
}
