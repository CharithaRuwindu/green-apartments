using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Create;

internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    Task IRequestHandler<CreateUserCommand>.Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User(
            new Id(Guid.NewGuid()),
            request Email,
            request FirstName,
            request.lastname,
            request.PasswordHash,
            Sku.Create(request.Sku)!);

        _userRepository.Add(user);
    }
}
