
public class Phone
{
	public string SerialNo { get; set; }
	public int Price { get; set; }

	public Phone(string serialNo, int price)
	{
		SerialNo = serialNo;
		Price = price;
	}

	public override string ToString()
	{
		return $"{SerialNo}, costs {Price} kr.";
	}
}