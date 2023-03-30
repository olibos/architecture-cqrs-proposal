// <copyright file="SyncRequestHandler.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Application;

using MediatR;

public abstract class SyncRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    Task<TResponse> IRequestHandler<TRequest, TResponse>.Handle(TRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Handle(request, cancellationToken));
    }

    public abstract TResponse Handle(TRequest request, CancellationToken cancellationToken);
}
