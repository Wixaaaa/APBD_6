using APBD_6.Models;

namespace APBD_6.Repositories
{
    public class MedicamentRepository(Context context): IMedicamentRepository
    {
        public async Task<Medicament> GetMedicamentAsync(int id)
        {
            return (await context.Medicaments.FindAsync(id))!;
        }
    }
}
