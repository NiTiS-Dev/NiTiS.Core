using System;

namespace NiTiS.Core.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Interface)]
public sealed class NotImplementYetAttribute : Attribute { }
