using MayTheFourth.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayTheFourth.Tests.Mocks;
using Xunit.Abstractions;

namespace MayTheFourth.Tests.Services;

public class MoviesServiceTest
{

    [Fact]
    public async Task ShouldListAllMovies()
    {
        var cancellationToken = new CancellationToken();
        var mock = new MockMoviesRepository();
        var repository = mock.MockMovieRepository.Object;
        var obj = await repository.GetByKeyAsync(
            r => r.Id == mock.MockMovieVM.Id,
            cancellationToken
        );
        
        var result = await repository.GetAllPagedAsync(1, 18, cancellationToken);
    }
}
