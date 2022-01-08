using System;

namespace Shuva_Dey_8781413_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            faculty.Faculty enggFaculty = new faculty.Faculty("Engineering Faculty", "Conestoga College", "Waterloo", "Engineering & Technology");
            faculty.Faculty busFaculty = new faculty.Faculty("Business Faculty", "Conestoga College", "Kitchener", "Business");
            faculty.Faculty artsFaculty = new faculty.Faculty("Arts Faculty", "Conestoga College", "Kitchener", "Atrs");

            //Assigning department to the faculty
            department.Department cse = new department.Department("Computer Science", enggFaculty);
            department.Department eee = new department.Department("Electrical Engineering", enggFaculty);
            department.Department accounting = new department.Department("Accounting", busFaculty);
            department.Department finance = new department.Department("Finance", busFaculty);
            department.Department economics = new department.Department("Economics", artsFaculty);
            department.Department anthropology = new department.Department("Anthropology", artsFaculty);

            //Enrolling students
            int totalStudent;

            Console.Write("How many student do you want to be enrolled: ");
            totalStudent = int.Parse(Console.ReadLine());

            student.Student[] students = new student.Student[totalStudent];
            int count = 0;
            for (int i=1; i<=totalStudent; i++)
            {
                Console.WriteLine("Please, enter the student name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Please, enter Student Id: ");
                string id = Console.ReadLine();

               Console.WriteLine("Please, enter the Department among them -> (cse, eee, accounting, finance, economics,  anthropology ): ");
                string department = Console.ReadLine();
                
                if (department.Equals("cse", StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        student.Student stdobj = new student.Student(name, id, cse);
                        students[count] = stdobj;
                        count++;
                    }
                    catch (Exception ex)
                    {
        
                    }
                } 
                else if (department.Equals("eee",StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        student.Student stdobj = new student.Student(name, id, eee);
                        students[count] = stdobj;
                        count++;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (department.Equals("accounting", StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        student.Student stdobj = new student.Student(name, id, accounting);
                        students[count] = stdobj;
                        count++;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (department.Equals("finance", StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        student.Student stdobj = new student.Student(name, id, finance);
                        students[count] = stdobj;
                        count++;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (department.Equals("anthropology", StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        student.Student stdobj = new student.Student(name, id, anthropology);
                        students[count] = stdobj;
                        count++;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (department.Equals("economics", StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        student.Student stdobj = new student.Student(name, id, economics);
                        students[count] = stdobj;
                        count++;
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }

            //Total number of student in the department
            Console.WriteLine("Total student in Computer Science:" +cse.getNumberofStudent());
            Console.WriteLine("Total student in Electrical Engineering:" + eee.getNumberofStudent());
            Console.WriteLine("Total student in Accounting:" + accounting.getNumberofStudent());
            Console.WriteLine("Total student in Finance:" + finance.getNumberofStudent());
            Console.WriteLine("Total student in Anthropology:" + anthropology.getNumberofStudent());
            Console.WriteLine("Total student in Economics:" + economics.getNumberofStudent());

            //Print all departments with the number of student within the faculty.
            
            Console.WriteLine("Within Engineering Faculty: ");
            Console.WriteLine("1. Computer Science" );
            Console.WriteLine("2. Electrical Engineering");
            int engTotal = cse.getNumberofStudent() + eee.getNumberofStudent();
            Console.WriteLine("Total Students :" + engTotal);

            Console.WriteLine("Within Business Faculty: ");
            
            Console.WriteLine("1. Accounting");
            Console.WriteLine("2. Finance");
            int busTotal = accounting.getNumberofStudent() + finance.getNumberofStudent();
            Console.WriteLine("Total Students :" +busTotal);

            Console.WriteLine("Within Arts Faculty: ");
            Console.WriteLine("1. Anthropology");
            Console.WriteLine("2. Economics");
            int artsTotal = anthropology.getNumberofStudent() + economics.getNumberofStudent();
            Console.WriteLine("Total Students :" +artsTotal);

            //print student info
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Student Name: " +students[i].getStudentName());
                Console.WriteLine("Student Id: " +students[i].getStudentId());
                Console.WriteLine("Faculty Name: " +students[i].getdepartment().getFaculty().getFacultyName());
                Console.WriteLine("University:  " +students[i].getdepartment().getFaculty().geUniversityName());
                Console.WriteLine("Campus: " + students[i].getdepartment().getFaculty().getCampusName());

            }

            //printing Waterloo campus
            Console.WriteLine("Waterloo Campus:-");

            for (int i = 0; i < count; i++)
            {
                if(students[i].getdepartment().getFaculty().getCampusName().Equals("Waterloo"))
                {
                    Console.WriteLine("Student Name: " + students[i].getStudentName());
                    Console.WriteLine("Student Id: " + students[i].getStudentId());
                    Console.WriteLine("Department Name: " + students[i].getdepartment().getDepartmentName());
                    Console.WriteLine("Faculty Name: " + students[i].getdepartment().getFaculty().getFacultyName());
                    Console.WriteLine("University: " + students[i].getdepartment().getFaculty().geUniversityName());
                    Console.WriteLine("Campus: " + students[i].getdepartment().getFaculty().getCampusName());
                    Console.WriteLine("Descriptions: " + students[i].getdepartment().getFaculty().getDescription());
                }
            }

            //Printing Kitchener campus
            Console.WriteLine("Kitchener Campus:-");

            for (int i = 0; i < count; i++)
            {
                if (students[i].getdepartment().getFaculty().getCampusName().Equals("Kitchener"))
                {
                    Console.WriteLine("Student Name: " + students[i].getStudentName());
                    Console.WriteLine("Student Id: " + students[i].getStudentId());
                    Console.WriteLine("Department Name : " + students[i].getdepartment().getDepartmentName());
                    Console.WriteLine("Faculty Name : " + students[i].getdepartment().getFaculty().getFacultyName());
                    Console.WriteLine("University : " + students[i].getdepartment().getFaculty().geUniversityName());
                    Console.WriteLine("Campus: " + students[i].getdepartment().getFaculty().getCampusName());
                    Console.WriteLine("Descriptions : " + students[i].getdepartment().getFaculty().getDescription());
                }
            }


        }
    }
}
