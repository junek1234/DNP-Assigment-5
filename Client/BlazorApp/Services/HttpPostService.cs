using System;
using ApiContracts;

namespace BlazorApp.Services;

public class HttpPostService : IPostService
{
    public Task<PostDto> AddPost7Async(CreatePostDto request)
    {
        throw new NotImplementedException();
    }

    public Task DeletePostAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto> GetPostAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<PostDto> GetPosts()
    {
        throw new NotImplementedException();
    }

    public Task UpdatePostAsync(int id, UpdatePostDto request)
    {
        throw new NotImplementedException();
    }

    Task<List<PostDto>> IPostService.GetPosts()
    {
        throw new NotImplementedException();
    }
}
