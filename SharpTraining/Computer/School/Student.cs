namespace SecondTry
{
    public class Student : Human
    {
        internal int level { get; set; }

        public Student(string firstName, string surname, string patronymic, GenderEnum gender, int age, int level) : base(firstName, surname, patronymic, gender, age)
        {
            this.level = level;
        }

        public void Deconstruct(out int level)
        {
            level = this.level;
        }

        public void nextYear()
        {
            base.nextYear();
            level++;
        }
    }
}