﻿using System.Collections.Generic;
using AllReady.Areas.Admin.Models;
using MediatR;

namespace AllReady.Areas.Admin.Features.Organizations
{
    public class OrganizationListQueryAysnc : IAsyncRequest<List<OrganizationSummaryModel>>
    {
    }
}