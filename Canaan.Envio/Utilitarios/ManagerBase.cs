namespace Canaan.Envio.Utilitarios
{
    public class ManagerBase
    {
        public string Path { get; set; }

        public ManagerBase(string path)
        {
            Path = path;
        }
    }
}
