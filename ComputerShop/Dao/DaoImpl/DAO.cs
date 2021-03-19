using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShop.Dao.DaoImpl
{
    public class DAO<T> : IDAO<T>
    {
        public Dictionary<Guid, T> Items { set; get; }


        public DAO()
        {
        }

        public T Get(Guid id)
        {
            return Items[id];
        }

        public List<T> FindAll()
        {
            return Items.Values.ToList();
        }

        public void Insert(Guid id, T t)
        {
            Items.Add(id, t);
        }


        public void Update(Guid id, T t)
        {
            Items[id] = t;
        }

        public void Delete(Guid id)
        {
            Items.Remove(id);
        }
    }
}