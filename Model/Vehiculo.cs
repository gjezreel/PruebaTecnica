namespace PrimerNombrePrimerApellido.Model
{
    public  class Vehiculo
    {
        private float velocidadMaxima;
        public float VelocidadMaxima
        {
            get { return velocidadMaxima; }
            set { velocidadMaxima = value; }
        }
        private float velocidadMinima;
        public float VelocidadMinima
        {
            get { return velocidadMinima; }
            set { velocidadMinima = value; }
        }
        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public void encender()
        {

        }
        public void apagar()
        {

        }

      //  public void MostrarDetalle()
       // {
         //   throw new System.NotImplementedException();
        //}
    }
}