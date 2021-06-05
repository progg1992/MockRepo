using MockRepo.IService;
using MockRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockRepo.Service
{
    public class TeacherService : IGenericService<Teacher>
    {
        List<Teacher> _teachers = new List<Teacher>();

        public TeacherService()
        {
            for (int i = 1; i <= 9; i++)
            {
                _teachers.Add(new Teacher()
                {
                    TeacherId = i,
                    Name = "Tch" + i,
                    Subject = "Sub" + i
                });

            }
        }
        public List<Teacher> Delete(int id)
        {
            _teachers.RemoveAll(x => x.TeacherId == id);
            return _teachers;
        }

        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public List<Teacher> GetById(int id)
        {
            _teachers.Where(x => x.TeacherId == id).SingleOrDefault();
            return _teachers;
        }

        public List<Teacher> Insert(Teacher item)
        {
            _teachers.Add(item);
            return _teachers;
        }

        Teacher IGenericService<Teacher>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
