namespace Amiasea.Enterprise.Contract.Core.Commands;

public sealed record CreateProductCommand(
    string Name,
    decimal Price);