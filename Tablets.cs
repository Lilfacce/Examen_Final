namespace Examen_Final
{
    public class Tablets : Dispositivos
    {
        public string Tamanio { get; set; }

        public string Soporte { get; set; }

        public Tablets()
        {
            Tamanio = string.Empty;
            Soporte = string.Empty;
        }
    }
}
