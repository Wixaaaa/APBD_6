using APBD_6.DTOs.Response;

namespace APBD_6.Services
{
    public interface IPatientService
    {
        public Task<PatientQueryDTO> GetPatientAsync(int id);
    }
}
