using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RncManagement.Controllers
{
    public class RncController : ApiController
    {
        private readonly Data.Database _context;
        public RncController()
        {
            _context = new Data.Database();
        }

        /// <summary>
        /// Metodo GET publico. Soporta OData
        /// </summary>
        /// <returns></returns>
        [Queryable]
        public IQueryable<Data.Models.RNC> Get()
        {
            IQueryable<Data.Models.RNC> list = null;
            list = (from c in _context.ListadoRNCs
                    select c).AsQueryable<Data.Models.RNC>();

            return list;
        }
    }
}
