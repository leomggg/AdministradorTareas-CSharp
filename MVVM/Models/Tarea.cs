namespace AdministradorTareas.MVVM.Models
{
    public class Tarea
    {
        private int sigId;
        private Categoria? categoriaSelec;

        public int IDTarea { get; set; }
        public string NombreTarea { get; set; }
        public Categoria CategoriaAsoc { get; set; }

        public int CategoriaID => CategoriaAsoc?.IDCategoria ?? 0;

        public Tarea(int iDTarea, string nombreTarea, Categoria categoriaSelec)
        {
            IDTarea = iDTarea;
            NombreTarea = nombreTarea;
            CategoriaAsoc = categoriaSelec;
        }

    }
}
