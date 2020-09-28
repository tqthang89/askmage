using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Interfaces
{
    public interface IUMTProvider
    {
        DataSet EmmployeeAccess_UpdateTime(int EmployeeId, int EAId);
        DataSet EmployeeDevices_Create(string Ip, string Province, string Country, string UserAgent);

        DataSet Form1_CheckDate(int Date, int NgayAm);
        DataSet Form1_Province(int EmployeeId);
        DataSet Form1_District(int EmployeeId, int ProvinceId);
        DataSet Form1_Town(int EmployeeId, int DistrictId);

    }
}
