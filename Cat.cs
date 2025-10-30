namespace PredatorsApp
{
    public class Cat : Predator
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
            }
        }

        public int Age
        {
            get
            {
                DateOnly now = DateOnly.FromDateTime(DateTime.Now);
                int age = now.Year - BirthDate.Year;

                if (now.DayOfYear < BirthDate.DayOfYear)
                    age--;

                return age;
            }
        }

        public Cat(int legs, int eyes, DateOnly birthDate, string mainBounty, string name)
            : base(legs, eyes, birthDate, mainBounty)
        {
            Name = name;
        }

        public string Purr() => "purr";
    }
}