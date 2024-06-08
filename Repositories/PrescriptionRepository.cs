using APBD_6.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_6.Repositories
{
    public class PrescriptionRepository(Context context) : IPrescriptionRepository
    {
        public async Task<int> AddPrescriptionAsync(Prescription prescription)
        {
            await context.Prescriptions.AddAsync(prescription);
            await context.SaveChangesAsync();
            return prescription.IdPrescription;
        }

        public async Task<IEnumerable<Prescription>> GetPrescriptionsByPatientsIdAsync(int patientId)
        {
            return await context.Prescriptions.Where(p => p.IdPatient == patientId)
                .Include(p => p.PrescriptionMedicaments)
                .ThenInclude(pm => pm.IdMedicamentNav)
                .ToListAsync();
        }
    }
}
