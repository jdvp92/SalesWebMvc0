using SalesWebMvc0.Data;
using SalesWebMvc0.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc0.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvc0Context _context;

        public DepartmentService(SalesWebMvc0Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
