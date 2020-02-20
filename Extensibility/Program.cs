namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\log.txt"));
            dbMigrator.Migrate();
            //var DbMigrator1 = new DbMigrator(new FileLogger());
        }
    }
}
