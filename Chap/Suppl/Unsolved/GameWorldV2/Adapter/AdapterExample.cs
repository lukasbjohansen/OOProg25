
// Denne fil rummer blot en "skabelon" for strukturen af en Adapter-klasse
// Bemærk, at typen for en "adaptee" ikke behøver være et interface,
// det kan også bare være en klasse.
// Disse elementer er således IKKE en del af opgaven som sådan, de er
// kun medtaget som hjælp.

public interface ISource
{
	string TheName { get; }
	int GetPhoneNumber();
	string Address { get; }
}

public interface ITarget
{
	string Name { get; }
	int PhoneNr { get; }
}

public class ISourceToITargetAdapter : ITarget
{
	private ISource _adaptee;

	public string Name { get { return _adaptee.TheName; } }

	public int PhoneNr { get { return _adaptee.GetPhoneNumber(); } }

	public ISourceToITargetAdapter(ISource adaptee)
	{
		_adaptee = adaptee;
	}
}