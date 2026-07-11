using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBlog.Application.Base;
using ZenBlog.Application.Contracts.Persistence;
using ZenBlog.Application.Features.Socials.Commands;
using ZenBlog.Domain.Entities;

namespace ZenBlog.Application.Features.Socials.Handlers
{
    public class RemoveSocialCommandHandler(IRepository<Social> repository, IUnitOfWork unitOfWork) : IRequestHandler<RemoveSocialCommand, BaseResult<object>>
    {
        public async Task<BaseResult<object>> Handle(RemoveSocialCommand request, CancellationToken cancellationToken)
        {
            //remove the social by ID
            var social = await repository.GetByIdAsync(request.Id);
            if (social == null)
            {
                return BaseResult<object>.Fail("Social not found.");
            }
            repository.Delete(social);
            await unitOfWork.SaveChangesAsync();
            return BaseResult<object>.Success("Social Removed");
        }
    }
}
