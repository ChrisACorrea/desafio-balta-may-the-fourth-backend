using MayTheFourth.Entities;
using MayTheFourth.Utils.Validation;
using NetSwissTools.System;

namespace MayTheFourth.Services.ViewModels
{
    public abstract class BaseViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ValidationViewModel IsValid() =>
            ValidationViewModel.Create(ValidationModelResult.Success);

        public virtual BaseModel GetEntity() =>
            throw new NotImplementedException("Falta criar a conversão da classe");

    }
}
