using System;
using System.Collections.Generic;
using System.Text;

namespace student
{
    class Student
    {
        //store student's department in cache
        static Dictionary<string, List <department.Department>> dbDepartment = new Dictionary<string, List<department.Department>>();
        
        string studentName;
        string studentId;
        department.Department department;

        //constructor
        public Student(string name, string id, department.Department department)
        {
            this.studentName = name;
            this.studentId = id;
            this.department = department;
            if(!dbEntry())
            {
                throw new SystemException("Trying to enter moret than one department under same faculty");
            }
            this.department.calculateStudent();
        }

        public string getStudentName()
        {
            return this.studentName;
        }
        public string getStudentId()
        {
            return this.studentId;
        }
        public department.Department getdepartment()
        {
            return this.department;
        }

        /**
         * This method checks whether students try to enter into same faculy-department
         */
        private bool dbEntry()
        {
            if(dbDepartment.ContainsKey(studentId)) {
                List<department.Department> enrolledDepartment = dbDepartment[studentId];
                foreach(department.Department dept in enrolledDepartment)
                {
                    if(dept.getFaculty().getFacultyName().Equals(department.getFaculty().getFacultyName()))
                    {
                        return false;
                    }

                }
                enrolledDepartment.Add(department);
                dbDepartment[studentId] = enrolledDepartment;
                return true;
            } 
            else
            {
                dbDepartment.Add(studentId, new List<department.Department> { department });
                return true;
            }
        }
    }
}
