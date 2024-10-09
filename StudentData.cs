using System;
using System.Collections.Generic; // Perlu di-import untuk IEnumerable
using System.Linq; // Perlu di-import untuk OrderBy
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Data
{
    public class StudentData : IStudent
    {
        private readonly ApplicationDbContext _db;

        public StudentData(ApplicationDbContext db)
        {
            _db = db;
        }

        // Menambahkan student baru
        public Student AddStudent(Student student)
        {
            try
            {
                _db.Students.Add(student);
                _db.SaveChanges();
                return student;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Menghapus student berdasarkan nim
        public void DeleteStudent(string nim) // Menggunakan string nim seperti pada interface
        {
            var student = _db.Students.FirstOrDefault(s => s.Nim == nim);
            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Student not found");
            }
        }

        // Mengambil student berdasarkan nim
        public Student GetStudent(string nim)
        {
            var student = _db.Students.FirstOrDefault(s => s.Nim == nim);
            if (student != null)
            {
                return student;
            }
            else
            {
                throw new Exception("Student not found");
            }
        }

        // Mengambil semua student dan mengurutkan berdasarkan FullName
        public IEnumerable<Student> GetStudents()
        {
            var students = _db.Students.OrderBy(s => s.FullName).ToList();
            return students; // Mengembalikan list dari hasil query
        }

        // Memperbarui data student
        public Student UpdateStudent(Student student)
        {
            var existingStudent = _db.Students.FirstOrDefault(s => s.Nim == student.Nim);
            if (existingStudent != null)
            {
                existingStudent.FullName = student.FullName; // Meng-update FullName, sesuaikan jika ada field lain
                _db.SaveChanges();
                return existingStudent;
            }
            else
            {
                throw new Exception("Student not found");
            }
        }
    }
}
