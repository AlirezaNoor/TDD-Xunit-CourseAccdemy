using System.Transactions;
using Infrastructrue.Course;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure.Course.IntegrationTest;

public class IDatabaseFixture:IDisposable, IAsyncDisposable
{
    public Acddemy context;
    private readonly TransactionScope _transactionScope;
    public IDatabaseFixture()
    {
        var option = new DbContextOptionsBuilder<Acddemy>().UseSqlServer(
            "Server=.;Database=BlinkShop.CartShop;User Id=sa;Password=55375447;TrustServerCertificate=True"
        ).Options;
          context = new Acddemy(option);
          _transactionScope = new TransactionScope();
          var test = new Domain.Course.Course(0, "testq", true, 780);
          var test2 = new Domain.Course.Course(0, "testq", true, 790);
          var test3 = new Domain.Course.Course(0, "testq", true, 900);
    }

    public void Dispose()
    {
        context.Dispose();
        _transactionScope.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        await context.DisposeAsync();
         _transactionScope.Dispose();
    }
}