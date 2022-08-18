namespace BibliotecaClases
{
    public class Persona
    {
        public string Nombre { get; set; } = "-- Sin nombre --";

        private string documento = "";
        public string Documento { 
            get { return documento; }
            set 
            {
                if (value.Length < 7)
                    throw new Exception("Formato de documento incorrecto");
                else
                    documento = value.ToUpper();
            } 
        }

        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}