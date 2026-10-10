using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Предоставляет возможность уникальной идентификации приложения, активируемого на основе манифеста. Этот класс не наследуется.</summary>
	// Token: 0x02000228 RID: 552
	[ComVisible(false)]
	[Serializable]
	public sealed class ApplicationIdentity : ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ApplicationIdentity" />.</summary>
		/// <param name="applicationIdentityFullName">Полное имя приложения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="applicationIdentityFullName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060018C7 RID: 6343 RVA: 0x0005DFFB File Offset: 0x0005C1FB
		public ApplicationIdentity(string applicationIdentityFullName)
		{
			if (applicationIdentityFullName == null)
			{
				throw new ArgumentNullException("applicationIdentityFullName");
			}
			if (applicationIdentityFullName.IndexOf(", Culture=") == -1)
			{
				this._fullName = applicationIdentityFullName + ", Culture=neutral";
				return;
			}
			this._fullName = applicationIdentityFullName;
		}

		/// <summary>Возвращает расположение манифеста развертывания в виде URL-адреса.</summary>
		/// <returns>URL-адрес манифеста развертывания.</returns>
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0005E038 File Offset: 0x0005C238
		public string CodeBase
		{
			get
			{
				return this._codeBase;
			}
		}

		/// <summary>Возвращает полное имя приложения.</summary>
		/// <returns>Полное имя приложения, также называемое отображаемым именем.</returns>
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0005E040 File Offset: 0x0005C240
		public string FullName
		{
			get
			{
				return this._fullName;
			}
		}

		/// <summary>Возвращает полное имя приложения, активируемого на основе манифеста.</summary>
		/// <returns>Полное имя приложения, активируемого на основе манифеста.</returns>
		// Token: 0x060018CA RID: 6346 RVA: 0x0005E040 File Offset: 0x0005C240
		public override string ToString()
		{
			return this._fullName;
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Структура <see cref="T:System.Runtime.Serialization.StreamingContext" /> для сериализации.</param>
		// Token: 0x060018CB RID: 6347 RVA: 0x0005D900 File Offset: 0x0005BB00
		[MonoTODO("Missing serialization")]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
		}

		// Token: 0x040016D5 RID: 5845
		private string _fullName;

		// Token: 0x040016D6 RID: 5846
		private string _codeBase;
	}
}
