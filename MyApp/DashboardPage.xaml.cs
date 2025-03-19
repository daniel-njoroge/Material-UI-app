

using System.Xml;

namespace MyApp;
public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
        InitializeComponent();
	}
    private void OnApartmentsClicked(object sender, EventArgs e)
    {
        contentPanel.Content = new Label
        {
            Text = "Apartments Panel",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
    }

    private void OnTenantsClicked(object sender, EventArgs e)
    {
        contentPanel.Content = new Label
        {
            Text = "Tenants Panel",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
    }

    private void OnSettingsClicked(object sender, EventArgs e)
    {
        contentPanel.Content = new Label
        {
            Text = "Settings Panell",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
    }
}