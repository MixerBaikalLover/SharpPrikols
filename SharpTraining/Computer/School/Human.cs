namespace SecondTry
{
    public class Human
    {
        internal string firstName { set; get; }
        internal string surname { get; set; }
        internal string patronymic { get; set; }
        internal GenderEnum gender { get; set; }
        internal int age { get; set; }

        public Human(string firstName, string surname, string patronymic, GenderEnum gender, int age)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.patronymic = patronymic;
            this.gender = gender;
            this.age = age;
        }

        public Human()
        {
        }

        public void Deconstruct(out string firstName, out string surname, out string patronymic, out GenderEnum gender, out int age)
        {
            firstName = this.firstName;
            surname = this.surname;
            patronymic = this.patronymic;
            gender = this.gender;
            age = this.age;
        }

        public void nextYear()
        {
            age++;
        }
    }
}