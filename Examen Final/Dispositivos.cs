namespace Examen_Final
{
    public class Dispositivos
    {
        public int Numero_De_Serie {  get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set;}
        public Dispositivos()
        {
            Numero_De_Serie = 0;
            Marca = string.Empty;
            Modelo = 0;
        }

    }
}
