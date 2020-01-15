using System;

namespace EjemploState
{
    class EstadoDesactivado : Estados
    {
        public override void Activo()
        {
            Console.Write("Se encuentra Activado.\n");
        }

        public override void Desactivado()
        {
            Console.WriteLine("Se pasa a estado Desactivado \n");
            this._context.TransitionTo(new EstadoActivo());
        }
    }
}
