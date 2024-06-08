using APBD_6.Models;

namespace APBD_6.Repositories
{
    public interface IDoctorRepository
    {
        public Task<Doctor> GetDoctorAsync(int id);
    }
}