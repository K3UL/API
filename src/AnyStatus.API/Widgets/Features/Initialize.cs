﻿namespace AnyStatus.API
{
    public interface IInitializable
    {
    }

    public interface IInitialize<T> : IRequestHandler<InitializeRequest<T>> where T : IInitializable
    {
    }

    public class InitializeRequest<T> : Request<T> where T : IInitializable
    {
        public InitializeRequest(T context) : base(context) { }
    }

    public class InitializeRequest
    {
        public static InitializeRequest<T> Create<T>(T context) where T : IInitializable
        {
            return new InitializeRequest<T>(context);
        }
    }
}
