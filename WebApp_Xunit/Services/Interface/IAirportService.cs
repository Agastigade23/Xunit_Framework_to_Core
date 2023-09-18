using WebApp_Xunit.Models;

namespace WebApp_Xunit.Services.Interface
{
    public interface IAirportService
    {
        void Add(AirportInfo Info);
        List<AirportInfo> Get();
        List<AirportInfo> GetAirportsByState(string id);
    }
}
