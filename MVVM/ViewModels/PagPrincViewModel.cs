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
                new Categoria { IDCategoria = 1, NombreCategoria = "Trabajo"},
                new Categoria { IDCategoria = 2, NombreCategoria = "Hogar"}
            };

            Tareas = new ObservableCollection<Tarea>
            {
                new Tarea (1, "Tarea 1", GetCategoriaById(1)),
                new Tarea (2, "Tarea 2", GetCategoriaById(2)),
                new Tarea (3, "Tarea 3", GetCategoriaById(3))
            };
        }

        public void AnadirTarea(Tarea tarea)
        {
            Tareas.Add(tarea);
        }

        public Categoria GetCategoriaById(int id)
        {
            return Categoria.FirstOrDefault(c => c.IDCategoria == id);
        }
    }
}
