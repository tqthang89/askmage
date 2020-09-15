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

        public DataTable GetallBylevel(string EmployeeCode, string EmployeeName, string ParentCode, string LoginName, string Mobile, int? Position, int? Level, int? Status, int? RowPerPage, int? PageNumber)
        {
            return repository.GetallBylevel(EmployeeCode, EmployeeName, ParentCode, LoginName, Mobile, Position, Level, Status, RowPerPage, PageNumber);
        }
        public DataTable QCResult_getall(string FromDate, string ToDate, string SiteCode, string ShopCode, string EmployeeCode, int? Confirmed,
            string QCCode, int? NotQC, int? RowPerPage, int? PageNumber)
        {
            return repository.QCResult_getall( FromDate, ToDate, SiteCode, ShopCode, EmployeeCode, Confirmed, QCCode, NotQC, RowPerPage, PageNumber);
        }
        public DataTable OSAResultStatus(long AuditId, string ProductCode, bool? QCStatus)
        {
            return repository.OSAResultStatus( AuditId, ProductCode, QCStatus);
        }
        public DataSet TKKPIMaster(long AuditId)
        {
            return repository.TKKPIMaster( AuditId);
        }
        public DataTable getAttendant(string ShopCode, string EmployeeCode, string AuditDate)
        {
            return repository.getAttendant( ShopCode, EmployeeCode, AuditDate);
        }
        public DataTable getOOC(long? AuditId, string AuditDate)
        {
            return repository.getOOC(AuditId, AuditDate);
        }
        public DataTable getOOV(long? AuditId, string AuditDate)
        {
            return repository.getOOV(AuditId, AuditDate);
        }
        public DataTable getOOL(long? AuditId, string DivisionId, string Market_Id)
        {
            return repository.getOOL(AuditId, DivisionId, Market_Id);
        }
        public DataTable getAllMarket(string empCode, string auditDate)
        {
            return repository.getAllMarket(empCode, auditDate);
        }
        public DataTable getByKPI(long? AuditId, string Market, string KPI)
        {
            return repository.getByKPI(AuditId, Market, KPI);
        }

        public DataTable getListComment(long? AuditId, string KPI, string Market)
        {
            return repository.getListComment(AuditId, KPI, Market);
        }
        public DataTable getMTgroup()
        {
            return repository.getMTgroup();
        }
        public DataTable GetTree(string EmployeeCode)
        {
            return repository.GetTree(EmployeeCode);
        }
        public DataSet totalKPIConfirm(long? AuditId, string AuditDate, int? MarketId)
        {
            return repository.totalKPIConfirm(AuditId, AuditDate, MarketId);
        }
        public DataSet AuditResultMasterKPI(long? AuditId, string AuditDate, string MarketId_id)
        {
            return repository.AuditResultMasterKPI(AuditId, AuditDate, MarketId_id);
        }
        public DataTable getPhotoV2(long? AuditId, string ImageType)
        {
            return repository.getPhotoV2(AuditId, ImageType);
        }
        public DataSet AuditResult_OOL_OOC_OOV_Attendant(long? AuditId, string AuditDate, string Market_id, string ShopCode, string EmployeeCode, string DivisionId)
        {
            return repository.AuditResult_OOL_OOC_OOV_Attendant(AuditId, AuditDate, Market_id, ShopCode, EmployeeCode, DivisionId);
        }
        public DataTable CategoryGetMarketDivision()
        {
            return repository.CategoryGetMarketDivision();
        }
        public int QCConfirm(long? AuditId, string EmployeeCode, int? Type)
        {
            return repository.QCConfirm(AuditId, EmployeeCode, Type);
        }
        public DataTable QCCheckConfirm(long? AuditId, string EmployeeCode)
        {
            return repository.QCCheckConfirm(AuditId, EmployeeCode);
        }
        public int QCConfirmByKPI(long AuditId, string MarketId, string KPI, string ResultQC, string CreateBy, string Comment, DataTable tblCTA, DataTable tblNPD_OSA_OOC, DataTable tblPRO_PROOL, DataTable tblSOS, DataTable tblSSMT, DataTable tblOOL, DataTable tblOOV, DataTable tblReasonQC)
        {
            return repository.QCConfirmByKPI(AuditId, MarketId, KPI, ResultQC, CreateBy, Comment, tblCTA, tblNPD_OSA_OOC, tblPRO_PROOL, tblSOS, tblSSMT, tblOOL, tblOOV, tblReasonQC);
        }
        public int OpenQC(long? AuditId, string KPI, string MarketId)
        {
            return repository.OpenQC(AuditId, KPI, MarketId);
        }
        public DataSet QCReason(long? AuditId, string MarketId, string KPI)
        {
            return repository.QCReason(AuditId,  MarketId, KPI);
        }
        public int QCConfirmV2(string AuditId, string EmployeeCode, int? Type)
        {
            return repository.QCConfirmV2(AuditId, EmployeeCode, Type);
        }
        public int OpenQCV2(string EmployeeCode, string AuditId)
        {
            return repository.OpenQCV2( EmployeeCode, AuditId);
        }


    }
}
