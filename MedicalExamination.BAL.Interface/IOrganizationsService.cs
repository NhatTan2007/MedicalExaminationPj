﻿using MedicalExamination.Domain.Entities;
using MedicalExamination.Domain.Requests;
using MedicalExamination.Domain.Responses.Organization;
using MedicalExamination.Domain.Responses.OrganizationRes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExamination.BAL.Interface
{
   public interface IOrganizationsService
    {
        Task<IEnumerable<Organization>> GetAllOrganizations();

        Task<QueryOrganizationRes> GetOrganizationBypagination(int currentPage, int pageSize);

        Task<Organization> GetOrganizationById(string orangizationId);
        Task<CreateOrganizationRes> CreateOrganization(CreateOrganizationReq request);
        Task<UpdateOrganizationRes> UpdateOrganization(UpdateOrganizationReq request);
        
        Task<IEnumerable<Organization>> SearchOrganizationsByNameASCByName(string search);
        Task<IEnumerable<Organization>> SearchOrganizationsByNameDESCByName(string search);
        Task<QueryOrganizationRes> SearchByOrganizationPagination(string keyword, int currentPage, int pageSize);

    }
}
