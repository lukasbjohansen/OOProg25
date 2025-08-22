
namespace RosBilRP.Models;

/// <summary>
/// Interface som domæne-klasser skal implementere for at blive 
/// kompatible med Repository-klasserne.
/// </summary>
public interface IHarId
{
	int Id { get; set; }
}
