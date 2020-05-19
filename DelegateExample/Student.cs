namespace DelegateExample
{
    struct Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string HairColour { get; private set; }
        public Student(string name, int age, string hairColour) : this()
        {
            Name = name;
            Age = age;
            HairColour = hairColour;
        }
        public string GiveNameAndAge()
        {
            return Name + " - " + Age;
        }
    }
}
