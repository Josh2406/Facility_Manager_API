using FacilityManager.Application.Interfaces;
using FacilityManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FacilityManager.Service.Implementations
{
    public class MaterialService : IMaterialService
    {
        private readonly IGenericRepository<Material> _materialRepo;

        delegate int SomeMath(int a, int b);

        public MaterialService(IGenericRepository<Material> materialRepo)
        {
            _materialRepo = materialRepo;
        }

        public async Task<List<Material>> GetMaterialsAsync()
        {

            throw new NotImplementedException();
        }
    }
}
