using System;
using System.Collections.Generic;

namespace SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Human pudge = new Human("Padj", "Pudjak", "Pudgers", GenderEnum.MALE, 15);
            Human teach1 = new Teacher("Kol", "Hitori", "who", GenderEnum.MALE, 65, "RMP", 20);
            Human stud1 = new Student("Max", "Plakhti", "Pentagon", GenderEnum.FEMALE, 20, 5);
            School sch = new School("no address", 3, 32, "Itma", new List<Teacher>() {(Teacher) teach1},
                new List<Student>() {(Student) stud1});
           // Console.Write(sch.AddEntity(pudge));
           Console.Write(sch.NextYearAll());
        }
    }
}