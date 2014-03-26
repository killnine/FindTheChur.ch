using System;
using System.Linq;
namespace Web.DataAccess
{
    public interface IFindTheChurchRepository
    {
        IQueryable<Church> GetChurches();
        IQueryable<ServiceTime> GetServiceTimesForChurch(int churchId);
    }
}
