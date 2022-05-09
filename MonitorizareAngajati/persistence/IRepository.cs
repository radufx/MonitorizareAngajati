using MonitorizareAngajati.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.persistence
{
    public interface IRepository<E> where E:Entity
    {
        /**
     * Function that returns an entity based on the id given
     * @param id: the id of the object to be returned
     * @return
     * throws IllegalArgumentException if id is null
     */
        E findOne(int id);

        /**
         * Function that returns an object
         * @param entity: the object to be returned
         * @return
         * throws IllegalArgumentException if entity is null
         */
        E findOne(E entity);

        /**
         * Function that returns all objects of a type from the repository
         * @return returns all objects of one type from repository, either users or friendships
         */
        IEnumerable<E> findAll();

        /**
         * Function that saves an object of generic type E in the repository
         * @param entity: the object to be saved in the repository
         * @return
         * throws IllegalArgumentException if entity is null
         */
        E save(E entity);

        /**
         * Function that removes an object of generic type E from the repository based on its id
         * @param id: the id of the object to be removed from the repository
         * @return returns the object from the repository if the object with the given id exists or null if it doesn't
         */
        E remove(int id);

        /**
         * Function that removes an object of generic type E from the repository
         * @param entity: the object to be removed from the repository
         * @return returns the object from repository if the object exists or null if it doesn't
         */
        E remove(E entity);

        E update(E entity);

        /**
         * Function that returns the number of objects in the repository
         * @return returns the number of objects of type user or friendship from the repository
         */
        int size();
    }
}
