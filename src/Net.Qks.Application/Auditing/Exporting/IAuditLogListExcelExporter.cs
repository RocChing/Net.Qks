using System.Collections.Generic;
using Net.Qks.Auditing.Dto;
using Net.Qks.Dto;

namespace Net.Qks.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
