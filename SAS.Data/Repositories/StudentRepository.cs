using Microsoft.EntityFrameworkCore;
using SAS.Data.Entities;
using SAS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Data.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        } 

        public void CreateStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _context.Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            var res = _context.Students.FirstOrDefault(s => s.Id == student.Id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }
    }
}
