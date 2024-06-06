namespace Examen_Final
{
    public class Smarthphone : Dispositivos
    {
        public string Sistema_Operativo { get; set; }
        public int Numero_De_Camaras { get; set; }

        public Smarthphone()
        {
            Sistema_Operativo = string.Empty;
            Numero_De_Camaras = 0;
        }
    }
}
