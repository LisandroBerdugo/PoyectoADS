namespace Prueba2_Fase1.Entities
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int RolID { get; set; } // Asegúrate de que esta propiedad existe
        public string RolNombre { get; set; } // Para almacenar el nombre del rol
    }
}
