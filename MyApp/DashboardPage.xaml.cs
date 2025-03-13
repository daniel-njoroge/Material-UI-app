

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
        contentPanel.Content = new TableView
        {
            Intent = TableIntent.Data,
            Root = new TableRoot("Table Title")
    {
        new TableSection("Section 1")
        {
            new TextCell { Text = "Row 1, Column 1", Detail = "Detail 1" },
            new TextCell { Text = "Row 2, Column 1", Detail = "Detail 2" },
            new TextCell { Text = "Row 3, Column 1", Detail = "Detail 3" }
        },
        new TableSection("Section 2")
        {
            new TextCell { Text = "Row 1, Column 2", Detail = "Detail 4" },
            new TextCell { Text = "Row 2, Column 2", Detail = "Detail 5" },
            new TextCell { Text = "Row 3, Column 2", Detail = "Detail 6" } 
        }
    }
        };
    }

    private void OnSettingsClicked(object sender, EventArgs e)
    {
        contentPanel.Content = new Label
        {
            Text = "Settings Panel",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
    }
}