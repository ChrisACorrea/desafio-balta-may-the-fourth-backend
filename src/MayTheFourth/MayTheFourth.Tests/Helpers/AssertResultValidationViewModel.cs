using FluentAssertions;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Validation;

namespace MayTheFourth.Tests.Helpers
{
    internal static class AssertResultValidationViewModel
    {
        public static void ValidateAndCheck<Model>(
            this BaseViewModel<Model> model,
            string message)
            where Model : BaseModel
        {
            model.ValidateAndCheck(ValidationModelResult.Success, 1, message);
        }

        public static void ValidateAndCheck<Model>(
            this BaseViewModel<Model> model,
            ValidationModelResult result,
            string message)
            where Model : BaseModel
        {
            model.ValidateAndCheck(result, 1, message);
        }

        public static void ValidateAndCheck<Model>(
            this BaseViewModel<Model> model,
            ValidationModelResult result, 
            int length, 
            string message)
            where Model : BaseModel
        {
            var ValidatedResult = model.IsValid();

            ValidatedResult.Check(result, length, message);
        }

        public static void Check(this ValidationViewModel model, ValidationModelResult result, string message)
        {
            model.Check(result, 1, message);
        }

        public static void Check(this ValidationViewModel model, ValidationModelResult result, int length, string message)
        {
            model.Result.Should().Be(result);
            model.Messages.Length.Should().Be(length);
            model.Messages.First().Should().Be(message);
        }

        public static void Check(this ValidationViewModel model, ValidationModelResult result, int length)
        {
            model.Result.Should().Be(result);
            model.Messages.Length.Should().Be(length);
        }
    }
}
