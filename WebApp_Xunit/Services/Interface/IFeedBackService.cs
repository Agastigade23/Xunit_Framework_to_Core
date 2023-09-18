using WebApp_Xunit.Models;

namespace WebApp_Xunit.Services.Interface
{
    public interface IFeedBackService
    {
        void Add(FeedBack Info);
        List<FeedBack> Get();
    }
}
