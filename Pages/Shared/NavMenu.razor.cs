using Microsoft.AspNetCore.Components;
using HealthyTipsBlog.Application.Models;

namespace HealthyTipsBlog.Pages.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout?.User;
}
