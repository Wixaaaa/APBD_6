using APBD_6.Models;

namespace APBD_6.Repositories
{
    public interface IPatientRepository
    {
        public Task<Patient> GetPatientAsync(int id);
        public Task<int> AddPatientAsync(Patient patient);
    }
}