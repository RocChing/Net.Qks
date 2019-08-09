using System.Collections.Generic;
using Net.Qks.Chat.Dto;
using Net.Qks.Dto;

namespace Net.Qks.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
