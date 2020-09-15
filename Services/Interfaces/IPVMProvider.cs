using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Interfaces
{
    public interface IPVMProvider
    {
        DataTable GetallBylevel(string EmployeeCode, string EmployeeName, string ParentCode, string LoginName, string Mobile, int? Position, int? Level, int? Status, int? RowPerPage, int? PageNumber);
        DataTable QCGetDynamicContents(string FromDate, string ToDate, string ShopCode, string SiteCode, string EmployeeCode, string QCCode,
            string Classified, int? LocationID, int? QCStatus, int? DISPLAYSHELF, int? OOS, int? OOLFREE, int? COMPETITOR, int? PRICE, int? OOL, int? SOS,
            int? STOCK, int? NPD, int? PROMOTION, int? RowPerPage, int? PageNumber);
        DataTable MasterListGetCodeName(string ListCode);
        DataTable QCReasonGetByWorkId(long WorkId, string KPICode);
        DataTable WorkResultsGetAttendant(string ShopCode, string EmployeeCode, string AuditDate);
        DataTable WorkResultGetPhotoFillProduct(long? WorkID);
        DataTable OOSResultGetByWorkId(long? WorkID);
        DataTable WorkResultsGetPhotos(long? WorkID);
        DataTable OOLResultGetOOLFreeByWordId(long? WorkId);
        DataTable QLLResultGetOOL(long? WorkId);
        DataTable GetQCResult(long? WorkId, string KPICode);
        DataTable CheckRental(long? WorkId);
        DataTable GetLocation(int? LocationId);
        DataTable GetSiteGroup(string SiteCode);
        DataTable GetEmployeeByOption(string FromDate = null, string ToDate = null, string EmployeeCode = null, string ParentCode = null, int? Position = null, int? LocationID = null, string lang = null);
        int QCResultInsert(long? WorkId, string KPICode, string QCStatus, int? ReasonId, string Note, string Comment, string ConfirmName, int? Confirm);
        int OOSResultUpdateQC(DataTable TableData, long? WorkId);
        int OOLResultUpdateQC(string LocationCode, long? WorkId, string Competitor, string QCStatus, string QCNote);
    }
}