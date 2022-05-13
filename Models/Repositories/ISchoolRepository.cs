using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationSchool.Models;

namespace WebApplicationSchool.Repositories
{
    public interface ISchoolRepository
    {
        IList<School> GetAll();
        School GetById(int id);
        void Add(School s);
        void Edit(School s);
        void Delete(School s);
        double StudentAgeAverage(int schoolId);
        int StudentCount(int schoolId);
    }
}
