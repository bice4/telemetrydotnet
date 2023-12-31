﻿using MongoDB.Bson;
using UserManagement.Domain.UserModels;

namespace UserManagement.Domain.Repositories;

public interface IUserRepository
{
    Task AddUserAsync(User user, CancellationToken cancellationToken);
    
    Task<bool> UserWithEmailExistsAsync(string email, CancellationToken cancellationToken);
    
    Task<bool> DeleteUserAsync(ObjectId id, CancellationToken cancellationToken);
    
    Task<User?> GetUserAsync(ObjectId id, CancellationToken cancellationToken);
    
    Task<List<User>> GetUsersAsync(CancellationToken cancellationToken);
}