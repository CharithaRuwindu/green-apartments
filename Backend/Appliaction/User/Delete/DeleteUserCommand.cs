using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Delete
{
    public class DeleteUserCommand(UserId UserId) : IRequest;
    {
    }
}
