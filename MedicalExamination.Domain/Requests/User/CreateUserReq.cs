﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExamination.Domain.Requests.User
{
    public class CreateUserReq
    {
        private string _userName;
        private string _email;
        private string _password;
        private string _phoneNumber;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _address;
        private string _titles;
        private bool _isActive;
        private string _avatar;
        private string _signature;
        private bool _isEmployee;


        public string UserName { get => _userName; set => _userName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public string Address { get => _address; set => _address = value; }
        public string Titles { get => _titles; set => _titles = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }
        public string DepartmentId { get; set; }
        public string Avatar { get => _avatar; set => _avatar = value; }
        public string Signature { get => _signature; set => _signature = value; }
        public bool IsEmployee { get => _isEmployee; set => _isEmployee = value; }
    }
}
