namespace ProjProduto.Util
{
    public class IProjMongoDotnetDatabaseSettings
    {
        string ProdutoCollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }
    }
}