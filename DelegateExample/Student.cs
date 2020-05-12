namespace DelegateExample
{
    struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColour { get; set; }
        public Student(string name, int age, string hairColour) : this()
        {
            this.Name = name;
            this.Age = age;
            this.HairColour = hairColour;
        }
        public string GiveNameAndAge()
        {
            return Name + " - " + Age;
        }
    }
}
