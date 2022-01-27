﻿using Pds.Data;
using Pds.Data.Entities;
using Pds.Services.Interfaces;

namespace Pds.Services.Services;

public class BrandService : IBrandService
{
    private readonly IUnitOfWork unitOfWork;

    public BrandService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<Brand>> GetAllForListsAsync()
    {
        return await unitOfWork.Brands.GetAllAsync();
    }

    public async Task<List<Brand>> GetAllAsync()
    {
        return await unitOfWork.Brands.GetAllFullAsync();
    }
}