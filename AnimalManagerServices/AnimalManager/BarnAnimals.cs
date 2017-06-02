using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManager
{
    public abstract class BarnAnimal
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }
    public class Cow : BarnAnimal
    {
        public bool Milked { get; set; }
    }

    public class Sheep : BarnAnimal
    {
        public bool Sheared { get; set; }
    }
}
