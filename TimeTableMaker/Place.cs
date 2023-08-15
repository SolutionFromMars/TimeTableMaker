namespace TimeTableMaker;

public partial class Place : Form
{
    public Place()
    {
        InitializeComponent();
    }

    private void Place_Load(object sender, EventArgs e)
    {
        foreach (var elem in GenerationThemes.ThemesList) selectTheme.Items.Add(elem.themeName);
        foreach (var elem in GenerationThemes.SizesList) selectSize.Items.Add(elem.name);
        selectTheme.SelectedIndex = 0;
        selectSize.SelectedIndex = 0;
    }
}