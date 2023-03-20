namespace Validation.Models
{
    public class ClientFactory
    {//singleton Design pattern
        //kendi tipinde privte statik bir değişken tanımla
        private static ClientFactory _factory;

        public List<Client> CLients;
        //fabrikaya ulaşabilmek içiin statik bir property tanımla ._fabrika yoksa yarat yoksa _fabrikayı döndür.
        public static ClientFactory GetFactory
        {
            get
            {
                if (_factory == null)
                
                    _factory = new ClientFactory();
                    return _factory;
                
            }
        }
        public ClientFactory()
        {
            CLients=new List<Client>();
        }
    }
}
