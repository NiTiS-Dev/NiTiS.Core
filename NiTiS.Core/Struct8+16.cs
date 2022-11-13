using System;
using System.Runtime.InteropServices;

namespace NiTiS.Core;

/// <summary>
/// Collection of bits, keeps the same bit positions for all primitive types
/// </summary>
[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
public unsafe struct Struct8
{
	[FieldOffset(0)]
	public fixed byte Bytes[1];

	// 8bit
	[FieldOffset(0)]
	public byte UInt8;
	[FieldOffset(0)]
	public sbyte Int8;
	[FieldOffset(0)]
	public char Char;
	[FieldOffset(0)]
	public bool Boolean;
}
/// <summary>
/// Collection of bits, keeps the same bit positions for all primitive types
/// </summary>
[StructLayout(LayoutKind.Explicit, Pack = 2, Size = 2)]
public unsafe struct Struct16
{
	[FieldOffset(0)]
	public fixed byte Bytes[2];

	// 8bit to right
	[FieldOffset(1)]
	public byte UInt8;
	[FieldOffset(1)]
	public sbyte Int8;
	[FieldOffset(1)]
	public char Char;
	[FieldOffset(1)]
	public bool Boolean;
	// 8bit to left
	[FieldOffset(0)]
	public byte LeftUInt8;
	[FieldOffset(0)]
	public sbyte LeftInt8;
	[FieldOffset(0)]
	public char LeftChar;
	[FieldOffset(0)]
	public bool LeftBoolean;
	// 16bit
	[FieldOffset(0)]
	public ushort UInt16;
	[FieldOffset(0)]
	public short Int16;

#if NET5_0_OR_GREATER
	[FieldOffset(0)]
	public Half Float16;
#endif
}