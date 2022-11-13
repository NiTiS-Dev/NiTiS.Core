using System.Runtime.InteropServices;

namespace NiTiS.Core;

/// <summary>
/// Collection of bits, keeps the same bit positions for all primitive types
/// </summary>
[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
public unsafe struct Struct32
{
	[FieldOffset(0)]
	public fixed byte Bytes[4];

	// 8bit to right
	[FieldOffset(3)]
	public byte UInt8;
	[FieldOffset(3)]
	public sbyte Int8;
	[FieldOffset(3)]
	public char Char;
	[FieldOffset(3)]
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

	// 16bit to right
	[FieldOffset(2)]
	public ushort UInt16;
	[FieldOffset(2)]
	public short Int16;
	// 16bit to left
	[FieldOffset(0)]
	public ushort LeftUInt16;
	[FieldOffset(0)]
	public short LeftInt16;

	// 32bit
	[FieldOffset(0)]
	public uint UInt32;
	[FieldOffset(0)]
	public uint Int32;

	// native to left
	[FieldOffset(0)]
	public nuint UIntPtr;
	[FieldOffset(0)]
	public nint IntPtr;
}
/// <summary>
/// Collection of bits, keeps the same bit positions for all primitive types
/// </summary>
[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 8)]
public unsafe struct Struct64
{
	[FieldOffset(0)]
	public fixed byte Bytes[8];

	// 8bit to right
	[FieldOffset(7)]
	public byte UInt8;
	[FieldOffset(7)]
	public sbyte Int8;
	[FieldOffset(7)]
	public char Char;
	[FieldOffset(7)]
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

	// 16bit to right
	[FieldOffset(6)]
	public ushort UInt16;
	[FieldOffset(6)]
	public short Int16;
	// 16bit to left
	[FieldOffset(0)]
	public ushort LeftUInt16;
	[FieldOffset(0)]
	public short LeftInt16;

	// 32bit to right
	[FieldOffset(4)]
	public uint UInt32;
	[FieldOffset(4)]
	public uint Int32;
	// 32bit to left
	[FieldOffset(0)]
	public uint LeftUInt32;
	[FieldOffset(0)]
	public uint LeftInt32;
	[FieldOffset(0)]

	// 64bit
	public uint UInt64;
	[FieldOffset(0)]
	public int Int64;

	// native to left
	[FieldOffset(0)]
	public nuint UIntPtr;
	[FieldOffset(0)]
	public nint IntPtr;
	
	// native to right
	[FieldOffset(4)]
	public nuint RightUIntPtr;
	[FieldOffset(4)]
	public nint RightIntPtr;
}