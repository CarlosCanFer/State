namespace EjemploState
{
    public abstract class Estados
    {
        public EstadoAlarma _context;

        public void SetContext(EstadoAlarma context)
        {
            this._context = context;
        }

        public abstract void Activo();

        public abstract void Desactivado();
    }
}
