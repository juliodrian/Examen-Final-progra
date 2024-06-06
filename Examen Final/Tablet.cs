namespace Examen_Final
{
    public class Tablet : Dispositivos
    {
        public int Tamanio_De_Pantalla {  get; set; }
        public string Soporte { get; set; }

        public Tablet()
        {
            Tamanio_De_Pantalla = 0;
            Soporte = string.Empty; 
        }
    }
}
