﻿using MedicalExamination.DAL.Implement.DbContexts;
using MedicalExamination.DAL.Interface;
using MedicalExamination.Domain.Entities;
using MedicalExamination.Domain.Helper;
using MedicalExamination.Domain.Requests.User;
using MedicalExamination.Domain.Responses.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExamination.DAL.Implement
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppIdentityUser> _userManager;
        private readonly AppDbContext _dbContext;

        public UserRepository(UserManager<AppIdentityUser> userManager,
                                AppDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public int CountEmployees()
        {
            return _userManager.Users.Where(u => u.EmployeeCode != null).Count();
        }

        public async Task<CreateUserRes> CreateNewUser(AppIdentityUser newUser, string password)
        {
            var result = await _userManager.CreateAsync(newUser, password);
            CreateUserRes response = new CreateUserRes();
            if (result.Succeeded)
            {
                response.UserId = newUser.Id;
                response.Message = "Tài khoản mới đã được tạo";
            }
            else response.Message = "Có lỗi đã xảy ra, xin mời liên lạc Quản trị hệ thống";
            return response;
        }

        public List<UserViewModel> GetAllUser()
        {
            return (from u in _dbContext.Users
                    join d in _dbContext.Departments
                    on u.DepartmentId equals d.DepartmentId
                    select new UserViewModel()
                    {
                        UserId = u.Id,
                        EmployeeCode = u.EmployeeCode,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        DateOfBirth = u.DateOfBirth,
                        DepartmentId = u.DepartmentId,
                        IsActive = u.IsActive,
                        DepartmentName = d.DepartmentName
                    }).OrderBy(u => u.DepartmentName).ToList();
        }

        public async Task<AppIdentityUser> GetUserById(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }
    }
}
