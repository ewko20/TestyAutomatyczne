using System;
using System.Collections.Generic;
using System.Text;
using ApplicationToLearnTest;
using NUnit.Framework;
using System.Linq;

namespace MyTests
{
    internal class UniversityTests
    {
        [Test]
        public void CheckCreatingStudent()
        {
            var student = new Student(1, "Jan");
            Assert.IsInstanceOf(typeof(Student), student);
            Assert.IsTrue(student.Id==1&&student.Name=="Jan");
        }

        [Test]
        public void CheckCreatingDepartment()
        {
            var student = new Student(1, "Jan");
            var students=new List<Student>();
            students.Add(student);
            student = new Student(2, "Anna");
            students.Add(student);
            var department=new Department(5,"Management",students);
            Assert.IsInstanceOf(typeof(Department), department);
            Assert.IsTrue(department.Id == 5 && department.Name == "Management"&&department.Students.Any(s=>s.Name=="Jan"&&s.Id==1)&&department.Students.Any(s=>s.Name=="Anna"&&s.Id==2));
        }

        [Test]
        public void CheckCreatingUniversity()
        {
            var student = new Student(1, "Jan");
            var students = new List<Student>();
            students.Add(student);
            student = new Student(2, "Anna");
            students.Add(student);
            var department = new Department(5, "Management",students);
            var departments=new List<Department>();
            departments.Add(department);
            department = new Department(6, "Finances", students);
            departments.Add(department) ;
            var university=new University(10,"Uniwersytet Warszawski",departments);
            Assert.IsInstanceOf(typeof (University), university);
            Assert.IsTrue(university.Id == 10 && university.Name == "Uniwersytet Warszawski" && university.Departments.Any(d => d.Name == "Management" && d.Id == 5&&d.Students.Any(s=>s.Name=="Jan"&&s.Id==1)&&d.Students.Any(s=>s.Name=="Anna"&&s.Id==2))&&university.Departments.Any(d=>d.Name=="Finances"&&d.Id==6&&d.Students.Any(s=>s.Name=="Jan"&&s.Id==1)&&d.Students.Any(s=>s.Name=="Anna"&&s.Id==2)));

        }


    }

}
