namespace Examen_Final
{
    public class Laptop : Dispositivos
    {
        public int Memoria_Ram {  get; set; }
        public int Almacenamiento { get; set; }

        public Laptop()
        {
            Memoria_Ram = 0;
            Almacenamiento = 0;
        }
    }
}
