using System;

namespace EjemploState
{
    public class EstadoAlarma
    {
        private Estados Estado;

        public EstadoAlarma(Estados _estado)
        {
            this.TransitionTo(_estado);
        }
                
       public void TransitionTo(Estados _estado)
        {
            Console.WriteLine($"EstadoAlarma: Puede cambiar a {_estado.GetType().Name}.");
            this.Estado = _estado;
            this.Estado.SetContext(this);
        }
        public void Activo()
        {
            this.Estado.Activo();
        }

        public void Desactivado()
        {
            this.Estado.Desactivado();

        }
    }
}
