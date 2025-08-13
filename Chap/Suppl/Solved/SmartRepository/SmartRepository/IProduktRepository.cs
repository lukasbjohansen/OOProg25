
public interface IProduktRepository
{
	/// <summary>
	/// Hent alle produkter
	/// </summary>
	List<Produkt> HentAlle();

	/// <summary>
	/// Vi definerer "dyre produkter" som produkter der koster 
	/// mere end 50 kroner.
	/// </summary>
	List<Produkt> HentDyreProdukter();

	/// <summary>
	/// Vi definerer "produkter med stor lagerværdi" som produkter hvor 
	/// den samlede værdi af lagerbeholdningen er over 3000 kr.
	/// </summary>
	List<Produkt> HentProdukterMedStorLagerværdi();


	/// <summary>
	/// Vi definerer "produkter vi snart mangler" som produkter hvor 
	/// der højst er 40 stk. på lager
	/// </summary>/// 
	List<Produkt> HentProdukterViSnartMangler();
}