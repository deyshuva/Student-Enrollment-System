using System;
using System.Collections.Generic;
using System.Text;

namespace faculty
{
    class Faculty
    {
        string facultyName;
        string universityName;
        string campusName;
        string description;

        public Faculty(string name, string university, string campus, string description )
        {
            this.facultyName = name;
            this.universityName = university;
            this.campusName = campus;
            this.description = description;
        }

        public string getFacultyName()
        {
            return this.facultyName;
        }
        public string geUniversityName()
        {
            return this.universityName;
        }
        public string getCampusName()
        {
            return this.campusName;
        }
        public string getDescription()
        {
            return this.description;
        }
    }
}
