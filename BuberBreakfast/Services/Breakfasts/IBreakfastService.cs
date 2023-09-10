using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast request);
        //Breakfastresponse DeleteBreakfast(Guid id);
       // Breakfastresponse GetBreakfast(Guid id);
       // Breakfastresponse UpsertBreakfast(Guid id);

       ErrorOr<Breakfast> GetBreakfasts(Guid id);
       void UpsertBreakfast(Breakfast breakfast);
       void DeleteBreakfast(Guid id);
    }
}
