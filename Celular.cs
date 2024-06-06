namespace Examen_Final
{
    public class Celular:Dispositivos
    {
        public string SOperativo { get; set; }

        public string NumCamara { get; set; }

        public Celular()
        {
            SOperativo = string.Empty;
            NumCamara = string.Empty;
        }
    }
}
