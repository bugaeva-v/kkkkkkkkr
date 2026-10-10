using System;
using System.Runtime.Serialization;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001A9 RID: 425
	internal static class Error
	{
		// Token: 0x06000D04 RID: 3332 RVA: 0x0001F988 File Offset: 0x0001DB88
		internal static Exception ArgumentNull(string paramName)
		{
			return new ArgumentNullException(paramName);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0001F990 File Offset: 0x0001DB90
		internal static Exception ArgumentOutOfRange(string paramName)
		{
			return new ArgumentOutOfRangeException(paramName);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0001F998 File Offset: 0x0001DB98
		internal static Exception InvalidOperation()
		{
			return new InvalidOperationException();
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0001F99F File Offset: 0x0001DB9F
		internal static Exception NotSupported()
		{
			return new NotSupportedException();
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0001F9A6 File Offset: 0x0001DBA6
		internal static Exception ObjectDisposed(string objectName)
		{
			return new ObjectDisposedException(objectName);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0001F9AE File Offset: 0x0001DBAE
		internal static Exception AttributeConflict(string propertyName)
		{
			return new InvalidOperationException(string.Format("The behaviors defined for property '{0}' are ambiguous or conflicting.", propertyName));
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		internal static Exception SeparateGetterSetterOnComplexType(string propertyName)
		{
			return new InvalidOperationException(string.Format("Cannot apply getter/setter behaviors for property '{0}'.  Separate getters/setters are supported for simple types only.", propertyName));
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0001F9D2 File Offset: 0x0001DBD2
		internal static Exception XmlMetadataNotAvailable(Type clrType)
		{
			return new InvalidOperationException(string.Format("XML metadata is not available for type '{0}'.", clrType.FullName));
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0001F9E9 File Offset: 0x0001DBE9
		internal static Exception NotDictionaryAdapter(string paramName)
		{
			return new ArgumentException("The argument is not a dictionary adapter.", paramName);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0001F9F6 File Offset: 0x0001DBF6
		internal static Exception NoInstanceDescriptor(string paramName)
		{
			return new ArgumentException("The dictionary adapter does not have an instance descriptor.", paramName);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0001FA03 File Offset: 0x0001DC03
		internal static Exception NoXmlAdapter(string paramName)
		{
			return new ArgumentException("The dictionary adapter does not have XmlAdapter behavior.", paramName);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0001FA10 File Offset: 0x0001DC10
		internal static Exception NotRealizable<T>()
		{
			return new NotSupportedException(string.Format("The given node cannot provide an underlying object of type {0}.", typeof(T).FullName));
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0001FA30 File Offset: 0x0001DC30
		internal static Exception CursorNotMutable()
		{
			return new NotSupportedException("The cursor does not support creation, removal, or modification of nodes.");
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0001FA3C File Offset: 0x0001DC3C
		internal static Exception CursorNotInCreatableState()
		{
			return new InvalidOperationException("The cursor cannot create nodes in its current state.");
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0001FA48 File Offset: 0x0001DC48
		internal static Exception CursorNotInRemovableState()
		{
			return new InvalidOperationException("The cursor cannot remove nodes in its current state.");
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0001FA54 File Offset: 0x0001DC54
		internal static Exception CursorNotInCoercibleState()
		{
			return new InvalidOperationException("The cursor cannot change node types in its current state.");
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0001FA60 File Offset: 0x0001DC60
		internal static Exception CursorNotInRealizableState()
		{
			return new InvalidOperationException("The cursor cannot realize virtual nodes in its current state");
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0001FA6C File Offset: 0x0001DC6C
		internal static Exception CursorCannotMoveToGivenNode()
		{
			return new InvalidOperationException("The cursor cannot move to the given node.");
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0001FA78 File Offset: 0x0001DC78
		internal static Exception CannotSetAttribute(IXmlIdentity identity)
		{
			return new InvalidOperationException(string.Format("Cannot set attribute on node '{0}'.", identity.Name.ToString()));
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		internal static Exception NotXmlKnownType(Type clrType)
		{
			return new SerializationException(string.Format("No XML type is defined for CLR type {0}.", clrType.FullName));
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0001FABF File Offset: 0x0001DCBF
		internal static Exception UnsupportedCollectionType(Type clrType)
		{
			return new SerializationException(string.Format("Unsupported collection type: {0}.", clrType.FullName));
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0001FAD6 File Offset: 0x0001DCD6
		internal static Exception NotCollectionType(string paramName)
		{
			return new ArgumentException("The argument is not a valid collection type.", paramName);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0001FAE3 File Offset: 0x0001DCE3
		internal static Exception InvalidLocalName()
		{
			return new FormatException("Invalid local name.");
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0001FAEF File Offset: 0x0001DCEF
		internal static Exception InvalidNamespaceUri()
		{
			return new FormatException("Invalid namespace URI.");
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0001FAFB File Offset: 0x0001DCFB
		internal static Exception NoDefaultKnownType()
		{
			return new InvalidOperationException("No default XML type exists in the given context.");
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0001FB07 File Offset: 0x0001DD07
		internal static Exception XPathNotCreatable(CompiledXPath path)
		{
			return new XPathException(string.Format("The path '{0}' is not a creatable XPath expression.", path.Path.Expression));
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0001FB23 File Offset: 0x0001DD23
		internal static Exception XPathNavigationFailed(XPathExpression path)
		{
			return new XPathException(string.Format("Failed navigation to {0} element after creation.", path.Expression));
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0001FB3A File Offset: 0x0001DD3A
		internal static Exception ObjectIdNotFound(string id)
		{
			return new SerializationException(string.Format("No object with ID '{0}' was present in the XML.", id));
		}
	}
}
