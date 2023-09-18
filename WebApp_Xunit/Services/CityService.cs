using WebApp_Xunit.Models;
using WebApp_Xunit.Repository;
using WebApp_Xunit.Services.Interface;

namespace WebApp_Xunit.Services
{
    public class CityService : ICityService
    {
        private readonly IRepository<CityInfo> _repository;
        public CityService(IRepository<CityInfo> repository)
        {
            _repository = repository;
        }
        public void Add(CityInfo Info)
        {
            _repository.Add(Info);
        }

        public List<CityInfo> Get()
        {
            return _repository.Get();
        }
    }
}
