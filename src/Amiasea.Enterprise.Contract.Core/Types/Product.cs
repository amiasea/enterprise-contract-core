namespace Amiasea.Enterprise.Contract.Core.Types;

public record Product(
    Guid Id,
    string Name,
    decimal Price);