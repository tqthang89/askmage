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

        [Function("[dbo].[Employee.GetallBylevel]")]
        public DataTable GetallBylevel(string EmployeeCode, string EmployeeName, string ParentCode, string LoginName, string Mobile, int? Position, int? Level, int? Status, int? RowPerPage, int? PageNumber)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), EmployeeCode, EmployeeName, ParentCode, LoginName, Mobile, Position, Level, Status, RowPerPage, PageNumber);
        }
        [Function("[dbo].[QCResult.getAll]")]
        public DataTable QCResult_getall(string FromDate, string ToDate,  string SiteCode, string ShopCode, string EmployeeCode, int? Confirmed,
            string QCCode, int? NotQC, int? RowPerPage, int? PageNumber)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), FromDate, ToDate, SiteCode, ShopCode, EmployeeCode, Confirmed, QCCode, NotQC, RowPerPage, PageNumber);
        }
        [Function("[dbo].[OSAResult.UpdateStatus]")]
        public DataTable OSAResultStatus(long AuditId, string ProductCode, bool? QCStatus)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, ProductCode, QCStatus);
        }
        [Function("[dbo].[TK.KPI.Master]")]
        public DataSet TKKPIMaster(long AuditId)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), AuditId);
        }
        [Function("[dbo].[AuditResult.getAttendant]")]
        public DataTable getAttendant(string ShopCode, string EmployeeCode, string AuditDate)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), ShopCode, EmployeeCode, AuditDate);
        }
        [Function("[dbo].[AuditResult.getOOC]")]
        public DataTable getOOC(long? AuditId, string AuditDate)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, AuditDate);
        }
        [Function("[dbo].[AuditResult.getOOV]")]
        public DataTable getOOV(long? AuditId, string AuditDate)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, AuditDate);
        }
        [Function("[dbo].[AuditResult.getOOL]")]
        public DataTable getOOL(long? AuditId, string DivisionId, string Market_Id)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, DivisionId, Market_Id);
        }
        [Function("[dbo].[Categories.getAll]")]
        public DataTable getAllMarket(string empCode, string auditDate)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), empCode, auditDate);
        }
        [Function("[dbo].[ResultQC.getByKPI]")]
        public DataTable getByKPI(long? AuditId, string Market, string KPI)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, Market, KPI);
        }
        
        [Function("[dbo].[Comment.GetList]")]
        public DataTable getListComment(long? AuditId,  string KPI, string Market)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), AuditId,  KPI, Market);
        }
        [Function("[dbo].[SiteGroup.getMTgroup]")]
        public DataTable getMTgroup()
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod());
        }
        [Function("[dbo].[Employee.GetTree]")]
        public DataTable GetTree(string EmployeeCode)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), EmployeeCode);
        }
        [Function("[dbo].[AuditResult.totalKPIConfirmV2]")]
        public DataSet totalKPIConfirm(long? AuditId, string AuditDate, int? MarketId)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, AuditDate, MarketId);
        }
        [Function("[dbo].[AuditResult.MasterKPI]")]
        public DataSet AuditResultMasterKPI(long? AuditId, string AuditDate, string Market_id )
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, AuditDate, Market_id);
        }
        [Function("[dbo].[AuditResult.getPhoto]")]
        public DataTable getPhotoV2(long? AuditId, string ImageType)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, ImageType);
        }
        [Function("[dbo].[AuditResult.OOL_OOC_OOV_Attendant]")]
        public DataSet AuditResult_OOL_OOC_OOV_Attendant(long? AuditId, string AuditDate, string Market_id, string ShopCode, string EmployeeCode, string DivisionId)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, AuditDate, Market_id, ShopCode, EmployeeCode, DivisionId);
        }
        
        [Function("[dbo].[Category.GetMarketDivision]")]
        public DataTable CategoryGetMarketDivision()
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod());
        }
        
        [Function("[dbo].[ResultQC.Confirm]")]
        public int QCConfirm(long? AuditId, string EmployeeCode, int? Type)
        {
            return DbContext.ExecuteNonQuery((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, EmployeeCode, Type);
        }
        [Function("[dbo].[ResultQC.ConfirmV2]")]
        public int QCConfirmV2(string AuditId, string EmployeeCode, int? Type)
        {
            return DbContext.ExecuteNonQuery((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, EmployeeCode, Type);
        }
        [Function("[dbo].[ResultQC.checkConfirm]")]
        public DataTable QCCheckConfirm(long? AuditId, string EmployeeCode)
        {
            return DbContext.ExecuteDatatable((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, EmployeeCode);
        }

        [Function("[dbo].[QCConfirmByKPI]")]
        public int QCConfirmByKPI(long AuditId, string MarketId, string KPI, string ResultQC, string CreateBy, string Comment, DataTable tblCTA, DataTable tbl_NPD_OSA_OOC, DataTable tbl_PRO_PROOL, DataTable tblSOS, DataTable tblSSMT, DataTable tblOOL, DataTable tblOOV, DataTable tblReasonQC)
        {
            return DbContext.ExecuteNonQuery((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, MarketId, KPI, ResultQC, CreateBy, Comment, tblCTA, tbl_NPD_OSA_OOC, tbl_PRO_PROOL, tblSOS, tblSSMT, tblOOL, tblOOV, tblReasonQC);
        }
        [Function("[dbo].[ResultQC.OpenQC]")]
        public int OpenQC(long? AuditId, string KPI, string MarketId)
        {
            return DbContext.ExecuteNonQuery((MethodInfo)MethodBase.GetCurrentMethod(), AuditId, KPI, MarketId);
        }
        [Function("[dbo].[ResultQC.OpenQCV2]")]
        public int OpenQCV2(string EmployeeCode, string AuditId)
        {
            return DbContext.ExecuteNonQuery((MethodInfo)MethodBase.GetCurrentMethod(), EmployeeCode, AuditId);
        }
        [Function("[dbo].[QC.Reason]")]
        public DataSet QCReason(long? AuditId, string MarketId, string KPI)
        {
            return DbContext.ExecuteDataset((MethodInfo)MethodBase.GetCurrentMethod(), AuditId,  MarketId, KPI);
        }
    }
}
