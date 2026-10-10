using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200010D RID: 269
	[NativeHeader("Runtime/Utilities/PropertyName.h")]
	[NativeHeader("Runtime/Director/Core/ExposedPropertyTable.bindings.h")]
	public struct ExposedPropertyResolver
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x00008D3C File Offset: 0x00006F3C
		internal static Object ResolveReferenceInternal(IntPtr ptr, PropertyName name, out bool isValid)
		{
			bool flag = ptr == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentNullException("Argument \"ptr\" can't be null.");
			}
			return ExposedPropertyResolver.ResolveReferenceBindingsInternal(ptr, name, out isValid);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00008D70 File Offset: 0x00006F70
		[FreeFunction("ExposedPropertyTableBindings::ResolveReferenceInternal")]
		private static Object ResolveReferenceBindingsInternal(IntPtr ptr, PropertyName name, out bool isValid)
		{
			return ExposedPropertyResolver.ResolveReferenceBindingsInternal_Injected(ptr, ref name, out isValid);
		}

		// Token: 0x0600067E RID: 1662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object ResolveReferenceBindingsInternal_Injected(IntPtr ptr, ref PropertyName name, out bool isValid);

		// Token: 0x04000385 RID: 901
		internal IntPtr table;
	}
}
