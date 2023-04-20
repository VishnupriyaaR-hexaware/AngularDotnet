using testdotnetcomp.BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace testdotnetcomp.Data.Interfaces
{
    public interface IUserRepository : IGetAll<User>,IGet<User,string>, ISave<User>, IUpdate<User, string>, IDelete<string>
    {
    }
}
