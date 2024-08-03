using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Handler
{
    public interface IQueryHandler<in IRequest, TResult> : IRequestHandler<IRequest, TResult>
        where IRequest : IQuery<TResult>

    {
    }

    public interface IQueryHandler<TEntity> : IRequestHandler<TEntity>
        where TEntity : IQuery
    {
    }
}
