using Avalonia.Controls;

namespace AvaloniaPlanerDnia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
public class Zadanie
{
    public string Nazwa { get; set; }
    public string Kategoria { get; set; }
    public bool CzyUkonczone { get; set; }
}