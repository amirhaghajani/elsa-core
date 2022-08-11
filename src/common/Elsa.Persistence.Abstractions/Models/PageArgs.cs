namespace Elsa.Persistence.Common.Models;

public record PageArgs(int? Page, int? PageSize)
{
    public int? Offset => Page * PageSize;
    public int? Limit => PageSize;
}