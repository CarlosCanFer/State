using System;

namespace EjemploState
{
    class EstadoActivo : Estados
    {
        public override void Activo()
        {
            Console.WriteLine("Cambiar al estado Activado \n");
            this._context.TransitionTo(new EstadoDesactivado());
        }

        public override void Desactivado()
        {
            Console.WriteLine("El estado esta Desactivado \n");
        }
    }
}
