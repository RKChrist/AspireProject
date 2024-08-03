using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Handler
{
    public interface ICommandHandler<in IRequest, TResult> : IRequestHandler<IRequest, TResult>
        where IRequest : ICommand<TResult>
    {
    }

    public interface ICommandHandler<TEntity> : IRequestHandler<TEntity>
        where TEntity : ICommand
    {
    }
}
