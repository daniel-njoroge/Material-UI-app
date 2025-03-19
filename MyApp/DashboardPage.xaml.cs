

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
        contentPanel.Content = new TableView
        {
            Intent = TableIntent.Form,
            Root = new TableRoot("Table Title") {
                    new TableSection ("Section 1 Title") {
                        new TextCell {
                            Text = "TextCell Text1",
                            Detail = "TextCell Detail"
                        },
                        new EntryCell {
                            Label = "EntryCell:",
                            Placeholder = "default keyboard",
                            Keyboard = Keyboard.Default
                        }
                    },
                    new TableSection ("Section 2 Title") {
                        new EntryCell {
                            Label = "Another EntryCell:",
                            Placeholder = "phone keyboard",
                            Keyboard = Keyboard.Telephone
                        },
                        new SwitchCell {
                            Text = "SwitchCell:"
                        }
                    }
                }
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