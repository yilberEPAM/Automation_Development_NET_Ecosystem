namespace TupleTesting.Classes
{
    public class PersonService
    {
        // Returns a tuple with name and age
        public (string Name, int Age) GetPersonInfo(int id)
        {
            // Simulate a lookup
            if (id == 1)
                return ("Alice", 30);
            if (id == 2)
                return ("Bob", 25);
            return ("Unknown", 0);
        }

        // Returns a tuple with more fields
        public (string Name, int Age, bool IsAdult) GetDetailedPersonInfo(int id)
        {
            var info = GetPersonInfo(id);
            bool isAdult = info.Age >= 18;
            return (info.Name, info.Age, isAdult);
        }
    }
}
