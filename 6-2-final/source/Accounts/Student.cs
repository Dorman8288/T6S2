using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace tamrin_6_2_final
{
    class Student : Account
    {
        string _studentNumber;
        public string studentNumber
        {
            get { return _studentNumber; }
            set
            {
                if (!isInStudentNumberFormat(value)) throw new Exception("student number format is not correct!");
                _studentNumber = value;
            }
        }
        public Student(string name, string studentNumber) : base(name)
        {
            this.studentNumber = studentNumber;
        }
        bool isInStudentNumberFormat(string input)
        {
            return Regex.IsMatch(input, @"^9.{7}$");
        }
    }
}
