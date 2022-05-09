using MonitorizareAngajati.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.persistence
{
    public abstract class Repository<E> : IRepository<E> where E : Entity
    {
        public virtual IEnumerable<E> findAll()
        {
            return null;
        }

        public virtual E findOne(int id)
        {
            return null;
        }

        public virtual E findOne(E entity)
        {
            return null;
        }

        public virtual E remove(int id)
        {
            return null;
        }

        public virtual E remove(E entity)
        {
            return null;
        }

        public virtual E save(E entity)
        {
            return null;
        }

        public virtual int size()
        {
            return 0;
        }

        public virtual E update(E entity)
        {
            return null;
        }
    }
}
