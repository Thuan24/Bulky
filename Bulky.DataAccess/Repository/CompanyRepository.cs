using BulkyShop.Models;
using BulkyShop.DataAccess.Repository.IRepository;
using BulkyShop.DataAcess.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyShop.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository 
        {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
