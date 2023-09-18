using WebApp_Xunit.Models;
using WebApp_Xunit.Repository;
using WebApp_Xunit.Services.Interface;

namespace WebApp_Xunit.Services
{
    public class FeedBackService :IFeedBackService
    {
        private readonly IRepository<FeedBack> _repository;
        public FeedBackService(IRepository<FeedBack> repository)
        {
            _repository = repository;
        }
        public void Add(FeedBack Info)
        {
            _repository.Add(Info);
        }

        public List<FeedBack> Get()
        {
            return _repository.Get();
        }
    }
}
