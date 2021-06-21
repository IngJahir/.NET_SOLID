namespace LSP_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal miNoticiero = new Noticiero("Hola a todos");
            miNoticiero.Muestra();

            Principal miRadio = new Radio("Como estan?");
            miRadio.Muestra();
        }
    }
}

// Revisar el patron estrategia OJO!!!!