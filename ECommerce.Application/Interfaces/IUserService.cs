using ECommerce.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> CreateAsync(UserDto userDto);
        Task<IEnumerable<UserListDto>> GetAllAsync();
        Task<UserDto?> GetByIdAsync(int id);
        Task<UserDto?> UpdateAsync(int id, UserDto userDto);
        Task<bool> DeleteAsync(int id);
    }
}
