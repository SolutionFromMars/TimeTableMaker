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
        GenerationThemes.MakeImage(GenerationThemes.ThemesList[0], GenerationThemes.SizesList[0]);
        representsImage.Image = GenerationThemes.TableImage;
    }

    private void selectTheme_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void selectSize_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}