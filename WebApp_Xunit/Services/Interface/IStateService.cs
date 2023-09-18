using WebApp_Xunit.Models;

namespace WebApp_Xunit.Services.Interface
{
    public interface IStateService
    {
        void Add(StateImg Info);
        List<StateImg> Get();
    }
}
