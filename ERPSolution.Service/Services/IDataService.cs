using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.Service.Services
{
    public interface IDataService
    {
        /// <summary>
        /// Get all object from the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IList<T> GetObjects<T>();

        /// <summary>
        /// Get one object by it key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        object GetObjectByKey<T>();

        /// <summary>
        /// Delete object with given key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void DeleteObjectByKey(Guid Oid);

        /// <summary>
        /// Delete list object
        /// </summary>
        /// <param name="objects"></param>
        void DeleteObjects(IList objects);

    }
}
