using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Interfaces
{
    public interface IUMTProvider
    {
        DataTable GetallBylevel(string EmployeeCode, string EmployeeName, string ParentCode, string LoginName, string Mobile, int? Position, int? Level, int? Status, int? RowPerPage, int? PageNumber);
        DataTable QCResult_getall(string FromDate, string ToDate, string SiteCode, string ShopCode, string EmployeeCode, int? Confirmed,
                string QCCode, int? NotQC, int? RowPerPage, int? PageNumber);
        DataSet totalKPIConfirm(long? AuditId, string AuditDate, int? MarketId);
        DataTable OSAResultStatus(long AuditId, string ProductCode, bool? QCStatus);
        DataSet TKKPIMaster(long AuditId);
        DataTable getAttendant(string ShopCode, string EmployeeCode, string AuditDate);
        DataTable getOOC(long? AuditId, string AuditDate);
        DataTable getOOV(long? AuditId, string AuditDate);
        DataTable getOOL(long? AuditId, string DivisionId, string Market_Id);
        DataTable getAllMarket(string empCode, string auditDate);
        DataTable getByKPI(long? AuditId, string Market, string KPI);
        DataTable getListComment(long? AuditId, string KPI, string Market);
        DataTable getMTgroup();
        DataTable GetTree(string EmployeeCode);
        DataSet AuditResultMasterKPI(long? AuditId, string AuditDate, string MarketId_id);
        DataTable getPhotoV2(long? AuditId, string ImageType);
        DataSet AuditResult_OOL_OOC_OOV_Attendant(long? AuditId, string AuditDate, string Market_id, string ShopCode, string EmployeeCode, string DivisionId);
        DataTable CategoryGetMarketDivision();
        int QCConfirm(long? AuditId, string EmployeeCode, int? Type);
        DataTable QCCheckConfirm(long? AuditId, string EmployeeCode);
        int QCConfirmByKPI(long AuditId, string MarketId, string KPI, string ResultQC, string CreateBy, string Comment, DataTable tblCTA, DataTable tblNPD_OSA_OOC, DataTable tblPRO_PROOL, DataTable tblSOS, DataTable tblSSMT, DataTable tblOOL, DataTable tblOOV, DataTable tblReasonQC);
        int OpenQC(long? AuditId, string KPI, string MarketId);
        DataSet QCReason(long? AuditId, string MarketId, string KPI);
        int QCConfirmV2(string AuditId, string EmployeeCode, int? Type);
        int OpenQCV2(string EmployeeCode, string AuditId);



        DataSet EmmployeeAccess_UpdateTime(int EmployeeId, int EAId);
        DataSet EmployeeDevices_Create(string Ip, string Province, string Country, string UserAgent);

        DataSet Form1_CheckDate(int Date, int NgayAm);
        DataSet Form1_Province(int EmployeeId);
        DataSet Form1_District(int EmployeeId, int ProvinceId);
        DataSet Form1_Town(int EmployeeId, int DistrictId);

    }
}
