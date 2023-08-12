namespace TT.Domain
{
    public abstract class Entidade
    {
        public Guid Id { get; set; }

        public Entidade() 
        {
            Id = Guid.Empty;
        }
    }
}
