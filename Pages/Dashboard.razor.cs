using Microsoft.AspNetCore.Components;
using HealthyTipsBlog.Application.Models;
using HealthyTipsBlog.Pages.Shared;

namespace HealthyTipsBlog.Pages;

public partial class Dashboard
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout.User;
}
