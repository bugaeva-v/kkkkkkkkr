using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает исходный класс <see cref="T:System.Type" /> в другой сборке.</summary>
	// Token: 0x02000809 RID: 2057
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	public sealed class TypeForwardedFromAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.TypeForwardedFromAttribute" />.</summary>
		/// <param name="assemblyFullName">Исходный класс <see cref="T:System.Type" /> в другой сборке.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyFullName" /> имеет значение <see langword="null" /> или пуст.</exception>
		// Token: 0x06004626 RID: 17958 RVA: 0x000E596F File Offset: 0x000E3B6F
		public TypeForwardedFromAttribute(string assemblyFullName)
		{
			if (string.IsNullOrEmpty(assemblyFullName))
			{
				throw new ArgumentNullException("assemblyFullName");
			}
			this.AssemblyFullName = assemblyFullName;
		}

		/// <summary>Получает имя исходного типа с указанием сборки.</summary>
		/// <returns>Имя исходного типа с указанием сборки.</returns>
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x000E5991 File Offset: 0x000E3B91
		public string AssemblyFullName { get; }
	}
}
