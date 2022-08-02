using BookStore.Core.Models;
using BookStore.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookStore.Api.Filters
{
    public class NotFoundFilter<T> : IAsyncActionFilter where T : BaseEntity
    {
        private readonly IService<T> _service;

        public NotFoundFilter(IService<T> service)
        {
            _service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var idValue = context.ActionArguments.Values.FirstOrDefault();

            if (idValue==null)
            {
                await next.Invoke();
                return;
            }

            var id = (int)idValue;
            var anyEntity=await _service.GetByIdAsync(id);

            if (anyEntity!=null)
            {
                await next.Invoke();
                return;
            }

            context.Result = new NotFoundObjectResult("404 not found!");
        }
    }
}
