﻿using MedicalExamination.BAL.Interface;
using MedicalExamination.DAL.Interface;
using MedicalExamination.Domain.Entities;
using MedicalExamination.Domain.Requests;
using MedicalExamination.Domain.Responses.OrganizationRes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExamination.BAL.Implement
{
    public class OrganizationsServices : IOrganizationsServices
    {
        private readonly IOrganizationsRepository _organizationsRepository;
        public OrganizationsServices(IOrganizationsRepository organizationsRepository)
        {
            _organizationsRepository = organizationsRepository;
        }

        public async Task<CreateOrganizationRes> CreateOrganization(CreateOrganizationReq request)
        {
            return await _organizationsRepository.CreateOrganization(request);
        }

        public async Task<UpdateOrganizationRes> UpdateOrganization(UpdateOrganizationReq request)
        {
            return await _organizationsRepository.UpdateOrganization(request);
        }

        public async Task<IEnumerable<Organization>> GetAllOrganizations()
        {
            return await _organizationsRepository.GetAllOrganizations();
        }

        public async Task<Organization> GetOrganizationById(string orangizationId)
        {
            return await _organizationsRepository.GetOrganizationById(orangizationId);
        }

       

        public async Task<IEnumerable<Organization>> SearchOrganizationsByNameASCByName(string orangizationName)
        {
            return await _organizationsRepository.SearchOrganizationsByNameASCByName(orangizationName);
        }

        public async Task<IEnumerable<Organization>> SearchOrganizationsByNameDESCByName(string orangizationName)
        {
            return await _organizationsRepository.SearchOrganizationsByNameDESCByName(orangizationName);
        }
    }
}
