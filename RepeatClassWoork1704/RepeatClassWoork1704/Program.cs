using System.Xml.Linq;

namespace RepeatClassWoork1704
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            foreach (var animal in animals)
            {
                Cat cat = animal as Cat;
                if (cat != null)
                {
                    cat.Risovkalanmaq();
                }


                if (animal is Cat cat)
                {
                    Cat cat = (Cat)animal;
                    cat.Risovkalanmaq();
                }

                else if (animal is Eagle)
                {
                    Eagle eagle = (Eagle)animal;
                    eagle.hunt();
                }

                else if (animal is Shark)
                {
                    Shark shark = (Shark)animal;
                    shark.swim();
                }
            }


           

           

            Person nurlan = new();
            {
                Name = "anar";
                Surname = "qasimzada";
                Age = 20;
            }
            Person abs = new();
            {
                Name = "abs";
                Surname = "cdf";
                Age = 20;
            }
            Console.WriteLine(nurlan > abs);

        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public static bool operator >(Person left, Person right)
        {
            return left.Age > right.Age;
        }
        public static bool operator <(Person left, Person right)
        {
            return left.Age < right.Age;
        }
        public static bool operator ==(Person left, Person right)
        {
            if (left.Age != right.Age ||
                left.Surname != right.Surname ||
                left.Name != right.Name)
                return false;
            return true;
        }
        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }

    }
    }
}
