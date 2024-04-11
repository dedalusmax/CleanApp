using CleanApp.Application.Commands;
using MediatR;

namespace CleanApp.Application.CommandHandlers;

public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand, Guid>
{
    Task<Guid> IRequestHandler<CreateExamCommand, Guid>.Handle(CreateExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
