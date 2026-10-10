using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Указывает базовый класс атрибута для управления доступом для кода.</summary>
	// Token: 0x02000432 RID: 1074
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public abstract class CodeAccessSecurityAttribute : SecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Permissions.CodeAccessSecurityAttribute" /> с указанным <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002B99 RID: 11161 RVA: 0x0009D5B3 File Offset: 0x0009B7B3
		protected CodeAccessSecurityAttribute(SecurityAction action) : base(action)
		{
		}
	}
}
