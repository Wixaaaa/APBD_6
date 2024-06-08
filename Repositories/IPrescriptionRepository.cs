using APBD_6.Models;

namespace APBD_6.Repositories
{
    public interface IPrescriptionRepository
    {
        public Task<int> AddPrescriptionAsync(Prescription prescription);
        public Task<IEnumerable<Prescription>> GetPrescriptionsByPatientsIdAsync(int patientId);
    }
}