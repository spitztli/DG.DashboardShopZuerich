using DG.DashboardShopZuerich.Services;
using Microsoft.AspNetCore.Components;

namespace DG.DashboardShopZuerich.Components.Pages
{
    public partial class Home
    {
        [Inject] public JsonDataService JsonDataService { get; set; } = null!;
    }
}
