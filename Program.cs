namespace Ejercicio3DateTime 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 30/01/2024
    /// </summary>
    class Program 
    {
        /// <summary>
        /// Método principal de la aplicacion
        /// irodhan -> 30/01/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        { 
            Random numero= new Random();
            int anyos=numero.Next(0,4+1);
            DateTime fechaActual = DateTime.Now;
            DateTime fechaModificada=fechaActual.AddDays(1).AddMonths(-24).AddYears(anyos);
            Console.WriteLine(fechaModificada.ToString());
            int comprobacion=fechaModificada.CompareTo(fechaActual);
            if (comprobacion > 0)
            {
                Console.WriteLine("La fecha modificada el mayor a la fecha actual");
            }
            else 
            {
                Console.WriteLine("La fecha actual el mayor a la fecha modificada");
            }
        }
    }
}
