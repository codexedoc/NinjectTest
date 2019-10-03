namespace NinjectTest
{
    class PersonFormatter : IPersonFormatter
    {

        public PersonFormatter()
        {

        }

        public string FormatPerson(int age, string firstname, string lastname)
        {
            return "My name is " + firstname + " " + lastname + " " + "and my age is " + age;
        }

    }
}
