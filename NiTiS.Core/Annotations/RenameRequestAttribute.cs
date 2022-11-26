using System;

namespace NiTiS.Core.Annotations;

[AttributeUsage(
	  AttributeTargets.Field
	| AttributeTargets.Class
	| AttributeTargets.Struct
	| AttributeTargets.Enum
	| AttributeTargets.Method
	| AttributeTargets.Property
	| AttributeTargets.Field
	| AttributeTargets.Interface
	| AttributeTargets.Parameter
	| AttributeTargets.Delegate
	)]
public sealed class RenameRequestAttribute : Attribute { }