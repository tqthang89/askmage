using Core.Data.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Core;

namespace Data.UMT
{
    public class UMTRepository : UMTEfRepository<BaseEntity>
    {
        public UMTRepository(UMTIDbContext dbContext) : base(dbContext)
        {

        }
        [Function("[dbo].[EmployeeDevices.Create]")]
        public DataSet EmployeeDevices_Create(string Ip, string Province, string Country, string UserAgent)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), Ip, Province, Country, UserAgent);
        }

        [Function("[dbo].[EmmployeeAccess.UpdateTime]")]
        public DataSet EmmployeeAccess_UpdateTime(int EmployeeId, int EAId)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), EmployeeId, EAId);
        }
        [Function("[dbo].[Form1.CheckDate]")]
        public DataSet Form1_CheckDate(int Date, int NgayAm)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), Date, NgayAm);
        }
        [Function("[dbo].[Form1.Province]")]
        public DataSet Form1_Province(int EmployeeId)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), EmployeeId);
        }
        [Function("[dbo].[Form1.District]")]
        public DataSet Form1_District(int EmployeeId, int ProvinceId)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), EmployeeId, ProvinceId);
        }
        [Function("[dbo].[Form1.Town]")]
        public DataSet Form1_Town(int EmployeeId, int DistrictId)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), EmployeeId, DistrictId);
        }
    }
}
