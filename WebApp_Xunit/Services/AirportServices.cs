using WebApp_Xunit.Models;
using WebApp_Xunit.Repository;
using WebApp_Xunit.Services.Interface;

namespace WebApp_Xunit.Services
{
    public class AirportServices : IAirportService
    {
        private readonly IRepository<AirportInfo> _repository;
        public AirportServices(IRepository<AirportInfo> repository)
        {
            _repository = repository;
        }
        public void Add(AirportInfo Info)
        {
            _repository.Add(Info);

        }
        public List<AirportInfo> GetAirportsByState(string id)
        {
            return _repository.Get().Where(x => x.State == id).ToList();
        }
        public List<AirportInfo> Get()
        {
            return _repository.Get();
        }
    }
}
