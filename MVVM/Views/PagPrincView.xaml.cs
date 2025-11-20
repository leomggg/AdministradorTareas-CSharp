using AdministradorTareas.MVVM.ViewModels;

namespace AdministradorTareas.MVVM.Views;

public partial class PagPrincView : ContentPage
{
	private PagPrincViewModel vm;
	private string texto;

	public PagPrincView()
	{
		InitializeComponent();
		vm = new PagPrincViewModel();
        BindingContext = vm;
    }

    //public PagPrincView(PagPrincViewModel viewm)
    //{
    //    InitializeComponent();
    //    vm = viewm;
    //    BindingContext = vm;
    //}

    public void Button_Clicked(object sender, EventArgs e)
	{
		texto = etiqueta.Text;
		//TERMINAR METODO
		Navigation.PushAsync(new PagSecView(vm));
	}
}