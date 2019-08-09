using System.Collections.Generic;
using MvvmHelpers;
using Net.Qks.Models.NavigationMenu;

namespace Net.Qks.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}