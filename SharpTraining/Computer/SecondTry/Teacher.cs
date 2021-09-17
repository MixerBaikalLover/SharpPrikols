namespace SecondTry
{
    public class Teacher : Human
    {
        internal string subject { get; set; }
        internal int exp { get; set; }

        public Teacher(string firstName, string surname, string patronymic, GenderEnum gender, int age, string subject, int exp) : base(firstName, surname, patronymic, gender, age)
        {
            this.subject = subject;
            this.exp = exp;
        }

        public void Deconstruct(out string subject, out int exp)
        {
            subject = this.subject;
            exp = this.exp;
        }

        public void  nextYear()
        {
            base.nextYear();
            exp++;
        }
    }
}