﻿using LaptopStoreApi.Data;
using LaptopStoreApi.Models;
namespace LaptopStoreApi.Services
{
    public interface ILaptopRepository
    {
        Task<List<Laptop>> GetAll();
        List<Laptop> Filter(string name, decimal? from, decimal? to, string sortBy);
        Task<Laptop> GetById(int id);
        Task<Laptop> Add(LaptopModel model);
        Task Update(LaptopModel model);
        Task Delete(int id);
        Task<List<Laptop>> Search(string keyword);
    }
}
