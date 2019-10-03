namespace NinjectTest
{
    class Person
    {

        private readonly IPersonFormatter _personFormatter;
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Person(int age, string firstName, string lastName, IPersonFormatter personFormatter)
        {
            _personFormatter = personFormatter;

            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public string PrintPersonData()
        {
            return _personFormatter.FormatPerson(Age, FirstName, LastName);
        }

    }
}
