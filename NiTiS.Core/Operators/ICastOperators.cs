#if NET7_0_OR_GREATER
namespace NiTiS.Core.Operators;
public interface IExplicitCastOperators<TSelf, TOther> where TSelf : IExplicitCastOperators<TSelf, TOther>
{
	static abstract explicit operator TOther(TSelf self);
}
public interface IImplicitCastOperators<TSelf, TOther> where TSelf : IImplicitCastOperators<TSelf, TOther>
{
	static abstract implicit operator TOther(TSelf self);
}
#endif