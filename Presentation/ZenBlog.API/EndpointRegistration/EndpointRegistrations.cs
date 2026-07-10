using MediatR;
using ZenBlog.Application.Features.Categories.Queries;

namespace ZenBlog.API.EndpointRegistration
{
    public static class EndpointRegistrations
    {
        public static void RegisterCategoryEndpoints(this IEndpointRouteBuilder app)
        {
           var categories = app.MapGroup("/categories").WithTags("Categories");

            categories.MapGet("", async (IMediator _mediator) =>
            {
                var response = await _mediator.Send(new GetCategoryQuery());
                return response.IsSuccess ? Results.Ok(response) : Results.BadRequest(response);
            });
        }
    }
}
