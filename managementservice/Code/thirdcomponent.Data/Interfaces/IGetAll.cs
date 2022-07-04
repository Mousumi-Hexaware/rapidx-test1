using System.Collections.Generic;

namespace thirdcomponent.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
