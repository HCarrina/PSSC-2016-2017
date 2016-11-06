using Models.Generics;
using Models.Generics.Exceptions;
using Models.Student;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Models.Factory
{
    public class GradeReportFactory
    {

        public static readonly GradeReportFactory Instance = new GradeReportFactory();

        public GradeReportFactory()
        {

        }

        public Student.GradeReport createInstance(Student.GradeReport gradeReport)
        {
            return gradeReport;
        }
    }
}    



