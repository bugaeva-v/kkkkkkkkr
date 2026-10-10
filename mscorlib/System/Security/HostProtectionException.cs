using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security
{
	/// <summary>Исключение, создаваемое при обнаружении ресурса запрещенного сайта.</summary>
	// Token: 0x020003DE RID: 990
	[ComVisible(true)]
	[MonoTODO("Not supported in the runtime")]
	[Serializable]
	public class HostProtectionException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.HostProtectionException" /> со значениями по умолчанию.</summary>
		// Token: 0x060028A2 RID: 10402 RVA: 0x00092A49 File Offset: 0x00090C49
		public HostProtectionException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.HostProtectionException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x060028A3 RID: 10403 RVA: 0x0006E6A5 File Offset: 0x0006C8A5
		public HostProtectionException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.HostProtectionException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="e">Исключение, которое является причиной текущего исключения. Если значение параметра innerException не равно <see langword="null" />, текущее исключение возникает в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060028A4 RID: 10404 RVA: 0x0006E6AE File Offset: 0x0006C8AE
		public HostProtectionException(string message, Exception e) : base(message, e)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.HostProtectionException" /> с указанным сообщением об ошибке, защищенными ресурсами сайта и ресурсами сайта, которые вызвали исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="protectedResources">Побитовое сочетание значений перечисления, указывающих ресурсы узла, недоступные для частично доверенного кода.</param>
		/// <param name="demandedResources">Побитовое сочетание значений перечисления, указывающих затребованные ресурсы узла.</param>
		// Token: 0x060028A5 RID: 10405 RVA: 0x000932C4 File Offset: 0x000914C4
		public HostProtectionException(string message, HostProtectionResource protectedResources, HostProtectionResource demandedResources) : base(message)
		{
			this._protected = protectedResources;
			this._demanded = demandedResources;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.HostProtectionException" />, используя предоставленные информацию о сериализации и контекст потоков.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060028A6 RID: 10406 RVA: 0x000932DB File Offset: 0x000914DB
		protected HostProtectionException(SerializationInfo info, StreamingContext context)
		{
			this.GetObjectData(info, context);
		}

		/// <summary>Получает или задает ресурсы защиты сайта, вызвавшие исключение.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.Permissions.HostProtectionResource" />, определяющее ресурсы защиты, которые вызывали исключение. Значение по умолчанию — <see cref="F:System.Security.Permissions.HostProtectionResource.None" />.</returns>
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000932EB File Offset: 0x000914EB
		public HostProtectionResource DemandedResources
		{
			get
			{
				return this._demanded;
			}
		}

		/// <summary>Получает или задает ресурсы защиты сайта, недоступные коду с частичным доверием.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Security.Permissions.HostProtectionResource" />, обозначающее недоступные категории защиты сайта. Значение по умолчанию — <see cref="F:System.Security.Permissions.HostProtectionResource.None" />.</returns>
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000932F3 File Offset: 0x000914F3
		public HostProtectionResource ProtectedResources
		{
			get
			{
				return this._protected;
			}
		}

		/// <summary>Устанавливает для указанного объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" /> информацию об исключении защиты сайта.</summary>
		/// <param name="info">Данные сериализованного объекта о вызываемом исключении.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060028A9 RID: 10409 RVA: 0x0005D900 File Offset: 0x0005BB00
		[MonoTODO]
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
		}

		/// <summary>Возвращает строковое представление текущего исключения защиты сайта.</summary>
		/// <returns>Строковое представление текущего <see cref="T:System.Security.HostProtectionException" />.</returns>
		// Token: 0x060028AA RID: 10410 RVA: 0x000932FB File Offset: 0x000914FB
		[MonoTODO]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x04001EB5 RID: 7861
		private HostProtectionResource _protected;

		// Token: 0x04001EB6 RID: 7862
		private HostProtectionResource _demanded;
	}
}
