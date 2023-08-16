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
        selectTheme.SelectedIndex = 0; //измен€етс€ значение SelectedIndex и вызываетс€ событие SelectedIndexChanged, но не вызываетс€ событие SelectionChangeCommitted
        selectSize.SelectedIndex = 0; //по умолчагнию значение -1, что не подходит дл€ списка
        GenerationThemes.MakeImage(GenerationThemes.ThemesList[0], GenerationThemes.SizesList[0]);
        representsImage.Image = GenerationThemes.TableImage;
    }

    /// <summary>
    /// —обытие, происход€щее при пользовательском изменении выбора selectTheme и selectSize
    /// </summary>
    private void SelectedChanged(object sender, EventArgs e)
    {
        GenerationThemes.MakeImage(GenerationThemes.ThemesList[selectTheme.SelectedIndex], GenerationThemes.SizesList[selectSize.SelectedIndex]);
        representsImage.Image = GenerationThemes.TableImage;
    }
}