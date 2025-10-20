namespace Reflection.Classes
{
    public class Person
    {
        public string Name { get; set; }
        private int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string GetInfo()
        {
            return $"{Name} is {Age} years old.";
        }
    }
}
