using System;

namespace NiTiS.Core.Annotations;

[AttributeUsage(
	  AttributeTargets.Class
	| AttributeTargets.Struct
	| AttributeTargets.Enum
	| AttributeTargets.Method
	| AttributeTargets.Property
	| AttributeTargets.Event
	| AttributeTargets.Interface
	)]
public class ObsoleteImplAttribute : Attribute { }