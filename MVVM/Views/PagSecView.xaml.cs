using AdministradorTareas.MVVM.Models;
using AdministradorTareas.MVVM.ViewModels;

namespace AdministradorTareas.MVVM.Views;

public partial class PagSecView : ContentPage
{
	private readonly PagPrincViewModel viewModel;

	public PagSecView()
	{
		InitializeComponent();
	}

	public PagSecView(PagPrincViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
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
		if (viewModel.Tareas.Any())
		{
			sigId = viewModel.Tareas.Max(t => t.IDTarea) + 1;
		}

		var nuevaTarea = new Tarea(sigId, nombreTarea, categoriaSelec);















        string nombreTarea = CuadroTexto.Text;



        vm.AnadirTarea(new Tarea(3, nombreTarea, );
    }
}