namespace Amiasea.Enterprise.Contract.Core.Types;

public record Cart(
    Guid Id,
    IReadOnlyList<CartItem> Items);