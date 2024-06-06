namespace Examen_Final
{
    public class Computadoras : Dispositivos
    {
        public string Ram { get; set; }

        public string Almacenamiento { get; set; }

        public Computadoras()
        {
            Ram = string.Empty;
            Almacenamiento = string.Empty;
        }
    }
}
