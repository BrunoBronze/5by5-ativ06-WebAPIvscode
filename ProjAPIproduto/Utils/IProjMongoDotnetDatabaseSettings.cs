namespace ProjAPIproduto.Utils
{
    public interface IProjMongoDotnetDatabaseSettings
    {
        string ProdutoColletionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}