using System.Threading.Tasks;

namespace Age12MauiApp;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}
	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			List<DadosUsuario> listas_usuarios = new List<DadosUsuario>()
			{
				new DadosUsuario()
				{
					Usuario = "Jose",
					Senha = "123"
				},

				new DadosUsuario()
				{
					Usuario = "maria",
					Senha = "321"
				}
			};
			DadosUsuario dados_digitados = new DadosUsuario()
			{
				Usuario = txt_usuario.Text,
				Senha = txt_senha.Text
			};

			// LINQ
			if (listas_usuarios.Any(i => (dados_digitados.Usuario == i.Usuario &&
					 dados_digitados.Senha == i.Senha)))
			{
				await SecureStorage.Default.SetAsync("usuario_logado", dados_digitados.Usuario);

				App.Current.MainPage = new protegida();
			}
			else
				throw new Exception("Usuário ou senha incorretos.");
		}
		catch (Exception ex)
		{
			await DisplayActionSheet("Ops", ex.Message, "Fechar");
		}
	}
}