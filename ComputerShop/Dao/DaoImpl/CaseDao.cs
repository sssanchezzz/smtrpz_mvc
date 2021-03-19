using ComputerShop.Dao;
using ComputerShop.Dao.DaoImpl;
using ComputerShop.Model;

namespace ComputerShop.Dao.DaoImpl
{
    public class CaseDao : DAO<Case>, ICaseDao
    {
        public CaseDao(FakeDatabase database)
        {
            Items = database.Cases;
        }

        public Case GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}