using System;
using System.Collections.Generic;

namespace SecondTry
{
    public class School : Building
    {
        internal int index { get; set; }
        internal string title { get; set; }
        internal List<Teacher> teachers { get; set; }
        internal List<Student> students { get; set; }

        public School(string address, int floorCount, int index, string title, List<Teacher> teachers,
            List<Student> students) : base(address, floorCount)
        {
            this.index = index;
            this.title = title;
            this.teachers = teachers;
            this.students = students;
        }

        public void Deconstruct(out int index, out string title, out List<Teacher> teachers, out List<Student> students)
        {
            index = this.index;
            title = this.title;
            teachers = this.teachers;
            students = this.students;
        }

        public bool AddEntity(Human human)
        {
            if (human.GetType() == typeof(Teacher))
            {
                teachers.Add((Teacher) human);
                return true;
            }
            if (human.GetType() == typeof(Student))
            {
                    students.Add((Student) human);
                    return true;
            }
            Console.WriteLine("Not a school entity");
            return false;
        }

        public int NextYearAll()
        {
            int countOut = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i] != null)
                {
                    students[i].nextYear();
                    if (students[i].level > 5)
                    {
                        Console.WriteLine(students[i].firstName + " " + students[i].surname + " Окончил обучение");
                        students[i] = null;
                        countOut++;
                    }
                    
                }
            }

            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i] != null)
                {
                    teachers[i].nextYear();
                    if (teachers[i].age > 65)
                    {
                        Console.WriteLine(teachers[i].firstName +" " + teachers[i].surname + " Вышел на пенсию.");
                        teachers[i] = null;
                        countOut++;
                    }
                }
            }
            return countOut;
        }
    }
}