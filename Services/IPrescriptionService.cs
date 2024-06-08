using APBD_6.DTOs.Request;

namespace APBD_6.Services
{
    public interface IPrescriptionService
    {
        public Task<int> AddPrescriptionAsync(PrescriptionCreateDTO request);
    }
}
