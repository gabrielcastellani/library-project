﻿using Library.Api.Domain.Abstracts;
using Library.Api.Domain.Books.Aggregates;
using MediatR;

namespace Library.Api.Domain.Books.Commands
{
    internal record GetAllBook : IRequest<Result<Book[]>>
    {
        public Guid? AuthorId { get; set; }
    }
}
