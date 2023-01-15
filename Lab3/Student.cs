using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Student
    {
        public string _name;
        public string _id;
        public double _height;
        public int _birthYear;
        public double _grade;
        public string _subject;

        public string dp_Name
        {
            get { return _name; }
        }
        public string dp_Id
        {
            get { return _id; }
        }
        public double dp_Height
        {
            get { return _height; }
        }
        public string dp_Subject
        {
            get { return _subject; }
        }
        public double dp_Grade
        {
            get { return _grade; }
        }
        public int dp_BirthYear
        {
            get { return _birthYear; }
        }
        public Student(string name, string id, int birth, double height, double garde, string subject)
        {
            this._name = name;
            this._id = id;
            this._birthYear = birth;
            this._height = height;
            this._grade = garde;
            this._subject = subject;
        }
    }
}
