using System;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Определяет базовое поведение инициализаторов проверки подлинности, которые могут быть зарегистрированы в файле app.config, и предоставляет основу для производных классов.</summary>
	// Token: 0x020003EC RID: 1004
	public abstract class SqlAuthenticationInitializer
	{
		/// <summary>Вызывается из конструкторов в производных классах для инициализации класса <see cref="T:System.Data.SqlClient.SqlAuthenticationInitializer" />.</summary>
		// Token: 0x06002F7F RID: 12159 RVA: 0x000108A6 File Offset: 0x0000EAA6
		protected SqlAuthenticationInitializer()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>При переопределении в производном классе запускает инициализатор проверки подлинности. Конструктор <see cref="M:System.Data.SqlClient.SqlAuthenticationInitializer.#ctor" /> вызывает этот метод во время запуска.</summary>
		// Token: 0x06002F80 RID: 12160
		public abstract void Initialize();
	}
}
