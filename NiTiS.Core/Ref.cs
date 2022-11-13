namespace NiTiS.Core;

public class Ref<T>
	where T : struct
{
	public T Value { get; set; }
	public Ref(T value)
	{
		Value = value;
	}
	public Ref() { }
}
public class ReadOnlyRef<T>
	where T : struct
{
	public readonly T Value;
	public ReadOnlyRef(T value)
	{
		Value = value;
	}
	public ReadOnlyRef() { }
}