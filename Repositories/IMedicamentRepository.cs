using APBD_6.Models;

namespace APBD_6.Repositories
{
    public interface IMedicamentRepository
    {
        public Task<Medicament> GetMedicamentAsync(int id);
    }
}