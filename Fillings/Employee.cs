namespace Data
{
    class Employee
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public Employee(string firstName, string name, string lastName, string position)
        {
            FirstName = firstName;
            Name = name;
            LastName = lastName;
            Position = position;
        }

    }
}
