namespace PredatorsApp
{
    public abstract class Predator
    {
        private int _legsCount;
        private int _eyesCount;
        private DateOnly _birthDate;
        private string _mainBounty;

        public virtual int LegsCount
        {
            get => _legsCount;
            set
            {
                if (value <= 8)
                    _legsCount = value;
            }
        }

        public virtual int EyesCount
        {
            get => _eyesCount;
            set
            {
                if (value <= 8)
                    _eyesCount = value;
            }
        }

        public virtual DateOnly BirthDate { get => _birthDate; set { _birthDate = value; } }
        public virtual string MainBounty { get => _mainBounty; set { _mainBounty = value; } }

        public Predator(int legs, int eyes, DateOnly birthDate, string mainBounty)
        {
            LegsCount = legs;
            EyesCount = eyes;
            BirthDate = birthDate;
            MainBounty = mainBounty;
        }

        public virtual string CatchThePray() => $"Catch {MainBounty}";
        public virtual string EatThePray(int count) => $"Eaten {count} {MainBounty}";
    }

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