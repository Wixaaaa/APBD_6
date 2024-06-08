using APBD_6.Models;

namespace APBD_6.Repositories
{
    public class DoctorRepository(Context context) : IDoctorRepository
    {
        public async Task<Doctor> GetDoctorAsync(int id)
        {
            return (await context.Doctors.FindAsync(id))!;
        }
    }

}
