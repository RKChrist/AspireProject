using MediatR;

namespace ApplicationLayer.Handler
{
    public interface ICommand<TResult> : IRequest<TResult>
    {
    }

    public interface ICommand : IRequest
    {
    }
}
