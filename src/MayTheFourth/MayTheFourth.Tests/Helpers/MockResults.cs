using Bogus;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Tests.Helpers;

public static class MockResults
{
    public static PageListResult<TModel> GetAllPaged<TViewModel, TModel>(
        Faker<TViewModel> faker,
        int page,
        int pageSize) 
        where TModel : BaseModel
        where TViewModel : BaseViewModel
    {
        return new PageListResult<TModel>(
            faker.Generate(pageSize).ToList()
                .Select(r => (TModel)r.GetEntity())
                .ToList()
        );
    }
    
    public static PageListResult<TModel> GetAllPagedFiltered<TViewModel, TModel>(
        int page,
        int pageSize,
        TViewModel result) 
        where TModel : BaseModel
        where TViewModel : BaseViewModel
    {
        return new PageListResult<TModel>(
            [(TModel)result.GetEntity()]
        );
    }
    
    public static IEnumerable<TModel> Query<TViewModel, TModel>(
        Faker<TViewModel> faker) 
        where TModel : BaseModel
        where TViewModel : BaseViewModel
    {
        var rand = new Random();
        return faker.Generate(rand.Next(1, 20)).ToList()
                .Select(r => (TModel)r.GetEntity())
                .ToList();
    }
}