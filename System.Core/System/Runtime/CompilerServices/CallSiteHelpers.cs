using System;
using System.Dynamic;
using System.Reflection;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Класс, содержащий вспомогательные методы для класса callsite среды DLR.
	///       </summary>
	// Token: 0x020002E0 RID: 736
	public static class CallSiteHelpers
	{
		/// <summary>
		///         Проверяет, может ли <see cref="T:System.Reflection.MethodBase" /> используется внутри среды DLR и не должен отображаться в стеке кода языка.
		///       </summary>
		/// <param name="mb">
		///           Входные данные <see cref="T:System.Reflection.MethodBase" />
		///         </param>
		/// <returns>
		///         Значение true, если входные данные <see cref="T:System.Reflection.MethodBase" /> используется внутри среды DLR и не должен отображаться в стеке кода языка.
		///          В противном случае — значение false.
		///       </returns>
		// Token: 0x06001660 RID: 5728 RVA: 0x0004BC70 File Offset: 0x00049E70
		public static bool IsInternalFrame(MethodBase mb)
		{
			return (mb.Name == "CallSite.Target" && mb.GetType() != CallSiteHelpers.s_knownNonDynamicMethodType) || mb.DeclaringType == typeof(UpdateDelegates);
		}

		// Token: 0x04000B53 RID: 2899
		private static readonly Type s_knownNonDynamicMethodType = typeof(object).GetMethod("ToString").GetType();
	}
}
