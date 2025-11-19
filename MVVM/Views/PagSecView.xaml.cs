using AdministradorTareas.MVVM.Models;
using AdministradorTareas.MVVM.ViewModels;

namespace AdministradorTareas.MVVM.Views;

public partial class PagSecView : ContentPage
{
	private PagPrincViewModel ViewModel { get; set; }

	public PagSecView()
	{
		InitializeComponent();
		ViewModel = new PagPrincViewModel();
		BindingContext = ViewModel;
	}

	public PagSecView(PagPrincViewModel vm)
	{
		InitializeComponent();
        ViewModel = new PagPrincViewModel();
        BindingContext = ViewModel;
    }

	public PagSecView(string dato)
	{
		InitializeComponent();
        BindingContext = dato;
	}

	public void Button_Clicked(object sender, EventArgs e)
	{
		Categoria categoriaSelec = ListaSelec.SelectedItem as Categoria;
        string nombreTarea = CuadroTexto.Text;

        int sigId = 1;
		if (ViewModel.Tareas.Any())
		{
			sigId = ViewModel.Tareas.Max(t => t.IDTarea) + 1;
		}

		var nuevaTarea = new Tarea(sigId, nombreTarea, categoriaSelec);



        //string nombreTarea = CuadroTexto.Text;

        //vm.AnadirTarea(new Tarea(3, nombreTarea, );
    }

	public void ListaSelec_SelectionChanged(object sender, EventArgs e)
	{

	}
}