using System;

namespace System.Security
{
	/// <summary>Указывает, что код или сборка выполняет критические с точки зрения безопасности операции.</summary>
	// Token: 0x020003D3 RID: 979
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class SecurityCriticalAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityCriticalAttribute" />.</summary>
		// Token: 0x06002866 RID: 10342 RVA: 0x00002050 File Offset: 0x00000250
		public SecurityCriticalAttribute()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityCriticalAttribute" /> с указанной областью действия.</summary>
		/// <param name="scope">Одно из значений перечисления, определяющее область действия атрибута.</param>
		// Token: 0x06002867 RID: 10343 RVA: 0x00092A62 File Offset: 0x00090C62
		public SecurityCriticalAttribute(SecurityCriticalScope scope)
		{
			this._val = scope;
		}

		/// <summary>Получает область действия атрибута.</summary>
		/// <returns>Одно из значений перечисления, определяющее область действия атрибута. Значение по умолчанию — <see cref="F:System.Security.SecurityCriticalScope.Explicit" />. Оно указывает, что данный атрибут применяется только к промежуточному элементу.</returns>
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x00092A71 File Offset: 0x00090C71
		[Obsolete("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
		public SecurityCriticalScope Scope
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04001EA1 RID: 7841
		private SecurityCriticalScope _val;
	}
}
