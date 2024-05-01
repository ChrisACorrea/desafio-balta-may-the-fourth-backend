using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.Mappers;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;
using System.Linq.Expressions;
using System.Net;

namespace MayTheFourth.API.Helpers;

public static class ApiHelper
{
    private static bool IsSuccessResponse(HttpStatusCode code)
    {
        if (IsInformational(code))
            return true;
        if (IsSuccess(code))
            return true;
        if (IsRedirect(code))
            return true;
        if (IsClientError(code))
            return false;
        return IsServerError(code) && false;
    }

    private static bool IsInformational(HttpStatusCode code) =>
        (int)code >= 100 && (int)code <= 199;

    private static bool IsRedirect(HttpStatusCode code) =>
        (int)code >= 300 && (int)code <= 399;

    private static bool IsSuccess(HttpStatusCode code) =>
        (int)code >= 200 && (int)code <= 299;

    private static bool IsClientError(HttpStatusCode code) =>
        (int)code >= 400 && (int)code <= 499;

    private static bool IsServerError(HttpStatusCode code) =>
        (int)code >= 500 && (int)code <= 599;

    private static IResult ResultErrorOperation(
        Exception ex,
        HttpStatusCode statusCode = HttpStatusCode.BadRequest)
    {
        return Results.BadRequest(new
        {
            Error = !IsSuccessResponse(statusCode),
            Status = (int)statusCode,
            Detail = new[]
            {
                $"{ex.Message} {ex.InnerException?.Message} {ex.InnerException?.InnerException?.Message}"
            }
        });
    }

    private static IResult ResultPagedOperation<TViewModel>(
        PageListResult<TViewModel> okResult,
        IErrorBaseService service)
        where TViewModel : BaseViewModel
    {
        if (service.Validation.Count != 0)
            return Results.BadRequest(new
            {
                Error = !IsSuccessResponse(HttpStatusCode.BadRequest),
                Status = (int)HttpStatusCode.BadRequest,
                Detail = service.Validation.Select(x => string.Join(" ", x.Messages)).ToArray()
            });

        return Results.Ok(new
        {
            Error = !IsSuccessResponse(HttpStatusCode.OK),
            Status = (int)HttpStatusCode.OK,
            Data = okResult
        });
    }

    private static IResult ResultDtoPagedOperation<TDto>(
        PageListResult<TDto> okResult,
        IErrorBaseService service)
        where TDto : IResultValues
    {
        if (service.Validation.Count != 0)
            return Results.BadRequest(new
            {
                Error = !IsSuccessResponse(HttpStatusCode.BadRequest),
                Status = (int)HttpStatusCode.BadRequest,
                Detail = service.Validation.Select(x => string.Join(" ", x.Messages)).ToArray()
            });

        return Results.Ok(new
        {
            Error = !IsSuccessResponse(HttpStatusCode.OK),
            Status = (int)HttpStatusCode.OK,
            Data = okResult
        });
    }

    public static IResult ResultOperation<TViewModel>(
        TViewModel? okResult,
        IErrorBaseService service)
        where TViewModel : BaseViewModel
    {
        return service.Validation.Count switch
        {
            > 0 => Results.BadRequest(new
            {
                Error = !IsSuccessResponse(HttpStatusCode.BadRequest),
                Status = (int)HttpStatusCode.BadRequest,
                Detail = service.Validation.Select(x => string.Join(" ", x.Messages)).ToArray()
            }),
            0 when okResult == null => Results.NotFound(new
            {
                Error = !IsSuccessResponse(HttpStatusCode.NotFound),
                Status = (int)HttpStatusCode.NotFound,
                Detail = new[] { Utils.Properties.Resources.RegisterNotFound }
            }),
            _ => Results.Ok(new
            {
                Error = !IsSuccessResponse(HttpStatusCode.OK), Status = (int)HttpStatusCode.OK, Data = okResult
            })
        };
    }

    private static IResult ResultDtoOperation<TDto>(
        TDto? okResult,
        IErrorBaseService service)
        where TDto : IResultValues
    {
        return service.Validation.Count switch
        {
            > 0 => Results.BadRequest(new
            {
                Error = !IsSuccessResponse(HttpStatusCode.BadRequest),
                Status = (int)HttpStatusCode.BadRequest,
                Detail = service.Validation.Select(x => string.Join(" ", x.Messages)).ToArray()
            }),
            0 when okResult == null => Results.NotFound(new
            {
                Error = !IsSuccessResponse(HttpStatusCode.NotFound),
                Status = (int)HttpStatusCode.NotFound,
                Detail = new[] { Utils.Properties.Resources.RegisterNotFound }
            }),
            _ => Results.Ok(new
            {
                Error = !IsSuccessResponse(HttpStatusCode.OK), Status = (int)HttpStatusCode.OK, Data = okResult
            })
        };
    }

    public static async Task<IResult> GetByKeyAsync<TViewModel, TModel>(
        IBaseReaderService<TViewModel, TModel> service,
        Expression<Func<TModel, bool>> expr,
        CancellationToken cancellationToken
    )
        where TViewModel : BaseViewModel
        where TModel : BaseModel
    {
        service.ClearValidation();
        try
        {
            var result = await service.GetByKeyAsync(expr, cancellationToken);
            
            return ResultOperation(result, service);
        }
        catch (Exception ex)
        {
            return ResultErrorOperation(ex);
        }
    }

    public static async Task<IResult> GetByKeyAsync<TViewModel, TDto, TModel>(
        IBaseReaderService<TViewModel, TModel> service,
        Expression<Func<TModel, bool>> expr,
        CancellationToken cancellationToken)
        where TViewModel : BaseViewModel
        where TDto : IResultValues
        where TModel : BaseModel
    {
        service.ClearValidation();
        try
        {
            var result = await service.GetByKeyAsync(expr, cancellationToken);
            
            var dtoResult = MapperModel.Map<TViewModel, TDto>(result!);

            return ResultDtoOperation(dtoResult, service);
        }
        catch (Exception ex)
        {
            return ResultErrorOperation(ex);
        }
    }

    public static async Task<IResult> GetAllPagedAsync<TViewModel, TDto, TModel>(
        IBaseReaderService<TViewModel, TModel> service,
        int page,
        int limit,
        CancellationToken cancellationToken)
        where TViewModel : BaseViewModel
        where TDto : IResultValues
        where TModel : BaseModel
    {
        service.ClearValidation();
        try
        {
            var result = await service.GetAllPagedAsync(
                page, limit, cancellationToken);

            var dtoResult = MapperModel.Map<PageListResult<TViewModel>, PageListResult<TDto>>(result);

            return ResultDtoPagedOperation(dtoResult, service);
        }
        catch (Exception ex)
        {
            return ResultErrorOperation(ex);
        }
    }

    public static async Task<IResult> GetAllPagedFilteredAsync<TViewModel, TModel>(
        IBaseReaderService<TViewModel, TModel> service,
        int page,
        int limit,
        Expression<Func<TModel, bool>> expr,
        CancellationToken cancellationToken
    )
        where TViewModel : BaseViewModel
        where TModel : BaseModel
    {
        service.ClearValidation();
        try
        {
            var result = await service.GetAllPagedFilteredAsync(
                page, limit, expr, cancellationToken);
            return ResultPagedOperation(result, service);
        }
        catch (Exception ex)
        {
            return ResultErrorOperation(ex);
        }
    }
    
    public static async Task<IResult> GetAllPagedFilteredAsync<TViewModel, TDto, TModel>(
        IBaseReaderService<TViewModel, TModel> service,
        int page,
        int limit,
        Expression<Func<TModel, bool>> expr,
        CancellationToken cancellationToken
    )
        where TViewModel : BaseViewModel
        where TDto : IResultValues
        where TModel : BaseModel
    {
        service.ClearValidation();
        try
        {
            var result = await service.GetAllPagedFilteredAsync(
                page, limit, expr, cancellationToken);

            var dtoResult = MapperModel.Map<PageListResult<TViewModel>, PageListResult<TDto>>(result);

            return ResultDtoPagedOperation(dtoResult, service);
        }
        catch (Exception ex)
        {
            return ResultErrorOperation(ex);
        }
    }
    

    public static async Task<IResult> RemoveByIdAsync<TViewModel, TModel>(
        IBaseWriterService<TViewModel, TModel> service,
        Guid id,
        CancellationToken cancellationToken
    )
        where TViewModel : BaseViewModel
        where TModel : BaseModel
    {
        service.ClearValidation();
        try
        {
            var result = await service.RemoveAsync(id, cancellationToken);

            return ResultOperation(result, service);
        }
        catch (Exception ex)
        {
            return ResultErrorOperation(ex);
        }
    }
}

