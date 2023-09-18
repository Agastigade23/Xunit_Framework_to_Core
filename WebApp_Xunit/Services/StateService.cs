using WebApp_Xunit.Models;
using WebApp_Xunit.Repository;
using WebApp_Xunit.Services.Interface;

namespace WebApp_Xunit.Services
{
    public class StateService : IStateService
    {
        private readonly IRepository<StateImg> _repository;
        public StateService(IRepository<StateImg> repository)
        {
            _repository = repository;
        }
        public void Add(StateImg Info)
        {
            _repository.Add(Info);
        }

        public List<StateImg> Get()
        {
            return _repository.Get();
        }
    }
}
