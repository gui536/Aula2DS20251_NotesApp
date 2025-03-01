namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        string caminho = FileSystem.AppDataDirectory;
        string arquivo = "arquivo.txt";

      

        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(Path.Combine(caminho, arquivo))){
                ConteudoEditor.Text = File.ReadAllText(Path.Combine(caminho, arquivo));
            }
        }

        private void SalvarButton_Clicked(object sender, EventArgs e)
        {

            string conteudo = ConteudoEditor.Text;
            //Código para combinar o caminho e o nome do arquivo
            File.WriteAllText(Path.Combine(caminho, arquivo),conteudo);
        }

        private void DeletarButton_Clicked(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(caminho, arquivo));
            DisplayAlert("Arquivo apagado", $"O arquivo {arquivo}  foi apagado com sucesso.", "Ok");
            ConteudoEditor.Text = "";
        }
    }

}
