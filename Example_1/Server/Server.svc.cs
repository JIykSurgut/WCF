
namespace Server
{
    public class Server: IServer
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }       
    }
}
