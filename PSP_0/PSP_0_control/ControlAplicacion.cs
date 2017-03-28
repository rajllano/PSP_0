using PSP_0_modelo;

namespace PSP_0_control
{
    public static class ControlAplicacion
    {
        private static Aplicacion a = null;

        public static Aplicacion getInstancia()
        {
            if (a == null)
                a = new Aplicacion();

            return a;
        }
    }
}
