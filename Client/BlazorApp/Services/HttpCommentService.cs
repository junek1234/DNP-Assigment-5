using System;
using ApiContracts;

namespace BlazorApp.Services;

public class HttpCommentService : ICommentService
{
    public Task<CommentDto> AddCommentAsync(CreateCommentDto request)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCommentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CommentDto> GetCommentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<CommentDto> GetComments()
    {
        throw new NotImplementedException();
    }

    public Task UpdateCommentAsync(int id, UpdateCommentDto request)
    {
        throw new NotImplementedException();
    }

    Task<List<CommentDto>> ICommentService.GetComments()
    {
        throw new NotImplementedException();
    }
}
