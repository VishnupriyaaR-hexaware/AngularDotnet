using System.Collections.Generic;

namespace testdotnetcomp.Data.Interfaces
{
    public interface IGetAll<out T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
