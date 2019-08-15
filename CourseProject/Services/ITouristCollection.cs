using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public interface ITouristCollection<T>
    { 
        void Add(T item);

        void Delete(T item);

        void Update(T item);
    }
}
