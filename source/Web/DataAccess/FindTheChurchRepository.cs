using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.DataAccess;

namespace Web.DataAccess
{
    public class FindTheChurchRepository : IFindTheChurchRepository
    {
        private ChurchContext _churchContext;

        public FindTheChurchRepository(ChurchContext context)
        {
            _churchContext = context;
        }

        public IQueryable<Church> GetChurches()
        {
            return _churchContext.Churches;
        }

        public IQueryable<ServiceTime> GetServiceTimesForChurch(int churchId)
        {
            return _churchContext.ServiceTimes.Where(st => st.ChurchId == churchId);
        }


        public bool Save()
        {
            try
            {
                return _churchContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                //TODO: Log error
                return false;
            }
        }

        public bool AddChurch(Church newChurch)
        {
            try
            {
                _churchContext.Churches.Add(newChurch);
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Log error
                return false;
            }
        }
    }
}