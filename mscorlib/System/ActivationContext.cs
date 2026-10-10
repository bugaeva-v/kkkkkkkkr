using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Unity;

namespace System
{
	/// <summary>Идентифицирует контекст активации для текущего приложения. Этот класс не наследуется.</summary>
	// Token: 0x02000223 RID: 547
	[ComVisible(false)]
	[Serializable]
	public sealed class ActivationContext : IDisposable, ISerializable
	{
		// Token: 0x06001871 RID: 6257 RVA: 0x0005D854 File Offset: 0x0005BA54
		private ActivationContext(ApplicationIdentity identity)
		{
			this._appid = identity;
		}

		/// <summary>Позволяет объекту <see cref="T:System.ActivationContext" /> попытаться освободить ресурсы и выполнить другие завершающие операции, перед тем как объект <see cref="T:System.ActivationContext" /> будет удален в процессе сборки мусора.</summary>
		// Token: 0x06001872 RID: 6258 RVA: 0x0005D864 File Offset: 0x0005BA64
		~ActivationContext()
		{
			this.Dispose(false);
		}

		/// <summary>Возвращает форму, или контекст хранения, для текущего приложения.</summary>
		/// <returns>Одно из значений перечисления.</returns>
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0005D894 File Offset: 0x0005BA94
		public ActivationContext.ContextForm Form
		{
			get
			{
				return this._form;
			}
		}

		/// <summary>Возвращает удостоверение текущего приложения.</summary>
		/// <returns>Объект <see cref="T:System.ApplicationIdentity" />, идентифицирующий текущее приложение.</returns>
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x0005D89C File Offset: 0x0005BA9C
		public ApplicationIdentity Identity
		{
			get
			{
				return this._appid;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ActivationContext" /> заданным удостоверением приложения.</summary>
		/// <param name="identity">Объект, идентифицирующий приложение.</param>
		/// <returns>Объект с удостоверением указанного приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Ни удостоверение развертывания, ни удостоверение приложения не задано в <paramref name="identity" />.</exception>
		// Token: 0x06001875 RID: 6261 RVA: 0x0005D8A4 File Offset: 0x0005BAA4
		[MonoTODO("Missing validation")]
		public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity)
		{
			if (identity == null)
			{
				throw new ArgumentNullException("identity");
			}
			return new ActivationContext(identity);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ActivationContext" /> заданным удостоверением приложения и массивом путей манифестов.</summary>
		/// <param name="identity">Объект, идентифицирующий приложение.</param>
		/// <param name="manifestPaths">Строковый массив путей манифестов для приложения.</param>
		/// <returns>Объект с удостоверением указанного приложения и массивом путей манифестов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identity" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="manifestPaths" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Ни удостоверение развертывания, ни удостоверение приложения не задано в <paramref name="identity" />.  
		///
		/// или - 
		/// Параметр <paramref name="identity" /> не соответствует удостоверению в манифестах.  
		///
		/// или - 
		/// <paramref name="identity" /> не имеет такого же количества компонентов, как пути манифестов.</exception>
		// Token: 0x06001876 RID: 6262 RVA: 0x0005D8BA File Offset: 0x0005BABA
		[MonoTODO("Missing validation")]
		public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity, string[] manifestPaths)
		{
			if (identity == null)
			{
				throw new ArgumentNullException("identity");
			}
			if (manifestPaths == null)
			{
				throw new ArgumentNullException("manifestPaths");
			}
			return new ActivationContext(identity);
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.ActivationContext" />.</summary>
		// Token: 0x06001877 RID: 6263 RVA: 0x0005D8DE File Offset: 0x0005BADE
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0005D8ED File Offset: 0x0005BAED
		private void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				this._disposed = true;
			}
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="info">Объект, который требуется заполнить данными.</param>
		/// <param name="context">Структура для данной сериализации.</param>
		// Token: 0x06001879 RID: 6265 RVA: 0x0005D900 File Offset: 0x0005BB00
		[MonoTODO("Missing serialization support")]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000173AD File Offset: 0x000155AD
		internal ActivationContext()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает манифест приложения ClickOnce для текущего приложения.</summary>
		/// <returns>Массив байтов, который содержит манифест приложения ClickOnce для приложения, связанного с этим <see cref="T:System.ActivationContext" />.</returns>
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x00052955 File Offset: 0x00050B55
		public byte[] ApplicationManifestBytes
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Получает манифест развертывания ClickOnce для текущего приложения.</summary>
		/// <returns>Массив байтов, который содержит манифест развертывания ClickOnce для приложения, связанного с этим <see cref="T:System.ActivationContext" />.</returns>
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x00052955 File Offset: 0x00050B55
		public byte[] DeploymentManifestBytes
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		// Token: 0x040016B3 RID: 5811
		private ApplicationIdentity _appid;

		// Token: 0x040016B4 RID: 5812
		private ActivationContext.ContextForm _form;

		// Token: 0x040016B5 RID: 5813
		private bool _disposed;

		/// <summary>Указывает контекст для приложения, активируемого на основе манифеста.</summary>
		// Token: 0x02000224 RID: 548
		public enum ContextForm
		{
			/// <summary>Приложение отсутствует в хранилище ClickOnce.</summary>
			// Token: 0x040016B7 RID: 5815
			Loose,
			/// <summary>Приложение содержится в хранилище ClickOnce.</summary>
			// Token: 0x040016B8 RID: 5816
			StoreBounded
		}
	}
}
