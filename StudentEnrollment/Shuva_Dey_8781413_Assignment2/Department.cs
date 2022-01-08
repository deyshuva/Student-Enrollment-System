using System;
using System.Collections.Generic;
using System.Text;

namespace department
{
    class Department
    {
        //Store student entry for each department in cache
        static Dictionary<string, int> numberofStudent = new Dictionary<string, int>();

        string departmentName;
        faculty.Faculty faculty;

        public Department (string name, faculty.Faculty faculty)
        {
            this.departmentName = name;
            this.faculty = faculty;
        }

        public void calculateStudent()
        {
            calculateNumberofStudent();
        }

        public string getDepartmentName()
        {
            return this.departmentName;
        }
        public faculty.Faculty getFaculty()
        {
            return this.faculty;
        }
        public int getNumberofStudent()
        {
            if(numberofStudent.ContainsKey(departmentName))
            {
                return numberofStudent[departmentName];
            }
            return 0;
        }
        private void calculateNumberofStudent()
        {
            if(numberofStudent.ContainsKey(departmentName))
            {
                numberofStudent[departmentName] = numberofStudent[departmentName] + 1;
            }
            else
            {
                numberofStudent.Add(departmentName, 1);
            }
        }
    }

    
}
