using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ReadWrite
{   
    public enum Gender{select,Male,Female,Transgender}
    public class Student
    {
        public string Name{get;set;}

        public string FatherName{get;set;}

        public Gender Gender{get;set;}

        public DateTime DOB{get;set;}

        public int TotalMark{get;set;}
    }
}