namespace homework10
{
    public abstract class Fileworker
    {
        public int MaxSize;

        public string Expansion;

        public abstract string Read();
        public abstract string Write();
        public abstract string Edit();
        public abstract string Delete();
    }
}
