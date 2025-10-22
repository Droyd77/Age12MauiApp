namespace Age12MauiApp;

public partial class protegida : ContentPage
{
	public protegida()
	{
		InitializeComponent();
		string? usuario_logado = null;

		Task.Run(async () =>
		{
			usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
            lbl_boasvindas.Text = $"Bem-vinda (a) {usuario_logado}";
		});
	}

    private async void Button_Clicked(object sender, EventArgs e)
	{
		bool  confimacao = await DisplayAlert("Tem Certeza?", "Sair do App?", "Sim", "Não");
		if(confimacao)
		{
			SecureStorage.Default.Remove("usuario_logado");
			App.Current.MainPage = new login();
		}
	}

    }