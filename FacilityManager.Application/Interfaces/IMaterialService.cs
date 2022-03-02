using FacilityManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FacilityManager.Application.Interfaces
{
    public interface IMaterialService
    {
        Task<List<Material>> GetMaterialsAsync();
    }
}
