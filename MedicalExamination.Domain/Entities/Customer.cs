﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MedicalExamination.Domain.Entities
{
    public class Customer
    {
        private string _customerId;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _email;
        private string _address;
        private string _phoneNumber;
        private string _identityNumber;
        private bool _gender;
        private DateTime _dateOfIssuanceIdentityNumber;
        private string _placeOfIssuanceIdentityNumber;
        [Key]
        [MaxLength(50)]
        public string CustomerId { get => _customerId; set => _customerId = value; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get => _firstName; set => _firstName = value; }
        [Required]
        [MaxLength(70)]
        public string LastName { get => _lastName; set => _lastName = value; }
        [Required]
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        [MaxLength(100)]
        public string Email { get => _email; set => _email = value; }
        [Required]
        [MaxLength(200)]
        public string Address { get => _address; set => _address = value; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        [Required]
        [MaxLength(20)]
        public string IdentityNumber { get => _identityNumber; set => _identityNumber = value; }
        [Required]
        public bool Gender { get => _gender; set => _gender = value; }
        [Required]
        public DateTime DateOfIssuanceIdentityNumber { get => _dateOfIssuanceIdentityNumber; set => _dateOfIssuanceIdentityNumber = value; }
        [Required]
        [MaxLength(100)]
        public string PlaceOfIssuanceIdentityNumber { get => _placeOfIssuanceIdentityNumber; set => _placeOfIssuanceIdentityNumber = value; }
    }
}
