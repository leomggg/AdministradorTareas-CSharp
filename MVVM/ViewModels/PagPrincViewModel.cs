using AdministradorTareas.MVVM.Models;
using System.Collections.ObjectModel;

namespace AdministradorTareas.MVVM.ViewModels
{
    public class PagPrincViewModel
    {
        public ObservableCollection<Categoria> Categoria { get; set; }
        public ObservableCollection<Tarea> Tareas { get; set; }

        public PagPrincViewModel()
        {
            Categoria = new ObservableCollection<Categoria>
            {
                new Categoria { IDCategoria = 1, NombreCategoria = "Categoria 1"},
                new Categoria { IDCategoria = 2, NombreCategoria = "Categoria 2"}
            };

            Tareas = new ObservableCollection<Tarea>
            {
                new Tarea (1, "Tarea 1", 1),
                new Tarea (2, "Tarea 2", 2),
                new Tarea (3, "Tarea 3", 1)
            };
        }

        public void AnadirTarea(Tarea tarea)
        {
            Tareas.Add(tarea);
        }
    }
}
