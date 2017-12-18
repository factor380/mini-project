using System;

using be_MiniPOrject;


namespace DAL
{
    internal class Dal_List : IDAL
    {
       
        /*
        public Dal_List()
        {
            studentList = new List<Student>();
            courseList = new List<Course>();
            studentCourseList = new List<StudentCourseAdapter>();
        }*///somthing that we need to chang i dont sure how


        //private static List<Student> studentList;
        //private static List<Course> courseList;
        //private static List<StudentCourseAdapter> studentCourseList;

        //static Dal_List()
        //{
        //    studentList = new List<Student>();
        //    courseList = new List<Course>();
        //    studentCourseList = new List<StudentCourseAdapter>();
        //}

        #region Child Function
        public void AddChild(Child c )
        {
            Child chi = GetChild(Child.Id);
            if (stud != null)
                throw new Exception("Student with the same id already exists...");
            studentList.Add(student);
        }

        public bool RemoveStudent(int id)
        {
            Student stud = GetStudent(id);
            if (stud == null)
                throw new Exception("Student with the same id not found...");

            studentCourseList.RemoveAll(sc => sc.StudentId == id);

            return studentList.Remove(stud);
        }

        public void UpdateStudent(Student student)
        {
            int index = studentList.FindIndex(s => s.StudentId == student.StudentId);
            if (index == -1)
                throw new Exception("Student with the same id not found...");

            studentList[index] = student;
        }

        public c GetChild(int id)
        {
            return ChildList.FirstOrDefault(c => c.ChildtId == id);
        }

        public IEnumerable<Student> GetAllStudents(Func<Student, bool> predicat = null)
        {
            if (predicat == null)
                return studentList.AsEnumerable();

            return studentList.Where(predicat);
        }
        #endregion


        #region Course Function
        public void AddCourse(Course course)
        {
            Course c = GetCourse(course.CourseId);
            if (c != null)
                throw new Exception("Course with the same id already exists...");
            courseList.Add(course);
        }

        public bool RemoveCourse(int id)
        {
            Course c = GetCourse(id);
            if (c == null)
                throw new Exception("Course with the same id not found...");

            if (GetAllStudentCourse(sc => sc.CourseId == id).Any())
                throw new Exception("The course is used by some students !!!");

            return courseList.Remove(c);
        }

        public void UpdateCourse(Course course)
        {



            int index = courseList.FindIndex(c => c.CourseId == course.CourseId);
            if (index == -1)
                throw new Exception("Course with the same id not found...");

            courseList[index] = course;
        }

        public Course GetCourse(int id)
        {
            return courseList.FirstOrDefault(c => c.CourseId == id);
        }

        public IEnumerable<Course> GetAllCourses(Func<Course, bool> predicat = null)
        {
            if (predicat == null)
                return courseList.AsEnumerable();

            return courseList.Where(predicat);
        }
        #endregion


        #region StudentCours Function
        public void AddStudentCourse(StudentCourseAdapter sc)
        {
            Student stud = GetStudent(sc.StudentId);
            if (stud == null)
                throw new Exception("Student with the same id not found...");

            Course course = GetCourse(sc.CourseId);
            if (course == null)
                throw new Exception("Course with the same id not found...");

            Func<StudentCourseAdapter, bool> predicat = item =>
            {
                bool b1 = item.StudentId == sc.StudentId && item.CourseId == sc.CourseId;
                bool b2 = item.RegisterYear == sc.RegisterYear && item.RegisterSemester == sc.RegisterSemester;
                return b1 && b2;
            };


            if (studentCourseList.Any(predicat))
                throw new Exception("can not Register the course in the same year and the same semester more than once...");

            studentCourseList.Add(sc);
        }

        public void UpdateStudentCourse(StudentCourseAdapter sc)
        {
            Predicate<StudentCourseAdapter> predicat = item =>
            {
                bool b1 = item.StudentId == sc.StudentId && item.CourseId == sc.CourseId;
                bool b2 = item.RegisterYear == sc.RegisterYear && item.RegisterSemester == sc.RegisterSemester;
                return b1 && b2;
            };

            int index = studentCourseList.FindIndex(predicat);
            if (index == -1)
                throw new Exception("not found...");

            studentCourseList[index] = sc;
        }

        public bool RemoveCourseFromStudent(int studentId, int courseId, int year, Semester semester)
        {
            Func<StudentCourseAdapter, bool> predicat = item =>
            {
                bool b1 = item.StudentId == studentId && item.CourseId == courseId;
                bool b2 = item.RegisterYear == year && item.RegisterSemester == semester;
                return b1 && b2;
            };


            StudentCourseAdapter sc = studentCourseList.FirstOrDefault(predicat);
            if (sc == null)
                throw new Exception("not found...");

            return studentCourseList.Remove(sc);
        }

        public IEnumerable<StudentCourseAdapter> GetAllStudentCourse(Func<StudentCourseAdapter, bool> predicat = null)
        {
            if (predicat == null)
                return studentCourseList.AsEnumerable();

            return studentCourseList.Where(predicat);
        }
        #endregion

    }
}