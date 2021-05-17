﻿using MedicalExamination.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExamination.Domain.Responses.OrganizationRes
{
   public class UpdateOrganizationRes
    {

        public MedicalExamination.Domain.Entities.Organization Organization { get; set; }
        public string Message { get; set; }
        public bool Success => Organization != null;

    }
}
