namespace ClientesAPI.Models
{
    public class ModelsCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
