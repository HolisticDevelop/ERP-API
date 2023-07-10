namespace ERP.Services.Inventorying.Infrastructure.Idempotency;

public interface IRequestManager
{
    Task<bool> ExistAsync(Guid id);

    Task CreateRequestForCommandAsync<T>(Guid id);
}