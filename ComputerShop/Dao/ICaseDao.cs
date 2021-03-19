using ComputerShop.Model;

namespace ComputerShop.Dao
{
    public interface ICaseDao: IDAO<Case>
    {
        Case GetByName(string name);
    }
}