﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.DataAccess;

namespace Web.Controllers
{
    public class ChurchesController : ApiController
    {
        IFindTheChurchRepository _repository;
        public ChurchesController(IFindTheChurchRepository repo)
        {
            _repository = repo;
        }

        public IEnumerable<Church> Get()
        {
            return _repository.GetChurches().ToList();
        }
    }
}