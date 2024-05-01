using System.Linq.Expressions;
using MayTheFourth.Repositories.Repositories.Interfaces;
using Moq;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;

namespace MayTheFourth.Tests.Mocks;

public class MockMoviesRepository
{
    public Mock<IMovieRepository> MockMovieRepository { get; }
    public MovieVM MockMovieVM { get; }

    public MockMoviesRepository()
    {
        var faker = MockMoviesVM.CreateFaker();
        MockMovieVM = faker.Generate();
        var mockMovieEntity = MockMovieVM.GetEntity();
        
        MockMovieRepository = new Mock<IMovieRepository>(MockBehavior.Strict);
        MockMovieRepository.Setup(s =>
                s.Add(mockMovieEntity))
            .Returns(() => true);

        MockMovieRepository.Setup(s =>
                s.Update(mockMovieEntity))
            .Returns(() => true);

        MockMovieRepository.Setup(s =>
                s.Remove(mockMovieEntity))
            .Returns(() => true);

        MockMovieRepository.Setup(s =>
                s.RemoveByKeyAsync(
                    r => r.Id == mockMovieEntity.Id,
                    It.IsAny<CancellationToken>()))
            .Returns(() => Task.FromResult(mockMovieEntity)!);

        MockMovieRepository.Setup(s =>
                s.SaveChangesAsync(
                    It.IsAny<CancellationToken>()))
            .Returns(() => Task.FromResult(1));

        MockMovieRepository.Setup(s => s.GetAllPagedAsync(
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync((int page, int pageSize, CancellationToken _) =>
                MockResults.GetAllPaged<MovieVM, Movie>(faker, page, pageSize));
            
        MockMovieRepository.Setup(s => s.GetAllPagedFilteredAsync(
                It.IsAny<int>(),
                It.IsAny<int>(),
                r => r.Id == mockMovieEntity.Id,
                It.IsAny<CancellationToken>()))
            .ReturnsAsync((int page, int pageSize, Expression<Func<Movie, bool>> _, CancellationToken __) =>
                    MockResults.GetAllPagedFiltered<MovieVM, Movie>(page, pageSize, MockMovieVM));

        MockMovieRepository.Setup(s => s.GetByKeyAsync(
                It.IsAny<Expression<Func<Movie, bool>>>(),
                It.IsAny<CancellationToken>()))
            .Returns(() => Task.FromResult(mockMovieEntity)!);

        MockMovieRepository.Setup(s => s.QueryAsync(
                It.IsAny<Expression<Func<Movie, bool>>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(() =>
                MockResults.Query<MovieVM, Movie>(faker));
    }
}

