using Core;
using Data;
using Data.UMT;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services
{
    public class UMTProvider : IUMTProvider
    {
        private readonly UMTRepository repository;
        public UMTProvider(UMTIDbContext dbContext)
        {
            repository = new UMTRepository(dbContext);
        }

        public DataSet EmmployeeAccess_UpdateTime(int EmployeeId, int EAId)
        {
            return repository.EmmployeeAccess_UpdateTime( EmployeeId,  EAId);
        }

        public DataSet EmployeeDevices_Create(string Ip, string Province, string Country, string UserAgent)
        {
            return repository.EmployeeDevices_Create(Ip, Province, Country, UserAgent);
        }

        public DataSet Form1_CheckDate(int Date, int NgayAm)
        {
            return repository.Form1_CheckDate(Date, NgayAm);
        }

        public DataSet Form1_Province(int EmployeeId)
        {
            return repository.Form1_Province(EmployeeId);
        }

        public DataSet Form1_District(int EmployeeId, int ProvinceId)
        {
            return repository.Form1_District( EmployeeId,  ProvinceId);
        }

        public DataSet Form1_Town(int EmployeeId, int DistrictId)
        {
            return repository.Form1_Town(EmployeeId, DistrictId);
        }
    }
}
