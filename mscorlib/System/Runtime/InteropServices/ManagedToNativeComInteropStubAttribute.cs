using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Обеспечивает поддержку пользовательской настройки заглушек взаимодействия в сценариях с управляемым COM-взаимодействием.</summary>
	// Token: 0x02000713 RID: 1811
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class ManagedToNativeComInteropStubAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ManagedToNativeComInteropStubAttribute" /> с заданным типом класса и именем метода.</summary>
		/// <param name="classType">Класс, содержащий требуемый метод-заглушку.</param>
		/// <param name="methodName">Имя метода-заглушки.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="methodName" /> не найден.  
		///
		/// или - 
		/// Метод не является статическим или универсальным.  
		///
		/// или - 
		/// Список параметров метода не соответствует списку параметров, ожидаемых заглушкой.</exception>
		/// <exception cref="T:System.MethodAccessException">Интерфейс, содержащий управляемый метод взаимодействия, не имеет доступа к методу-заглушке, поскольку метод-заглушка имеет закрытый или защищенный доступ, или из-за проблемы безопасности.</exception>
		// Token: 0x060040C6 RID: 16582 RVA: 0x000E164E File Offset: 0x000DF84E
		public ManagedToNativeComInteropStubAttribute(Type classType, string methodName)
		{
			this._classType = classType;
			this._methodName = methodName;
		}

		/// <summary>Получает класс, содержащий требуемый метод-заглушку.</summary>
		/// <returns>Класс, содержащий настроенную заглушку взаимодействия.</returns>
		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x000E1664 File Offset: 0x000DF864
		public Type ClassType
		{
			get
			{
				return this._classType;
			}
		}

		/// <summary>Получает имя метода-заглушки.</summary>
		/// <returns>Имя настроенной заглушки взаимодействия.</returns>
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x000E166C File Offset: 0x000DF86C
		public string MethodName
		{
			get
			{
				return this._methodName;
			}
		}

		// Token: 0x04002AF0 RID: 10992
		internal Type _classType;

		// Token: 0x04002AF1 RID: 10993
		internal string _methodName;
	}
}
