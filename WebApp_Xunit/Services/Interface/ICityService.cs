using WebApp_Xunit.Models;

namespace WebApp_Xunit.Services.Interface
{
    public interface ICityService
    {
        void Add(CityInfo Info);
        List<CityInfo> Get();
    }
}
