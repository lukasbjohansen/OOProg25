using System.Numerics;

BigInteger a = UInt128.MaxValue;
for (int i = 0; i < 16; i++)
{
    a *= a;
}
Console.WriteLine(a);