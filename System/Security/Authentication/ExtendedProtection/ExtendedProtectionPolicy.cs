using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security.Authentication.ExtendedProtection
{
	/// <summary>Класс <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" /> представляет расширенную политику защиты, используемую сервером для проверки входящих соединений от клиентов.</summary>
	// Token: 0x020002A6 RID: 678
	[MonoTODO]
	[TypeConverter(typeof(ExtendedProtectionPolicyTypeConverter))]
	[Serializable]
	public class ExtendedProtectionPolicy : ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который указывает, когда следует применять расширенную политику защиты.</summary>
		/// <param name="policyEnforcement">Значение <see cref="T:System.Security.Authentication.ExtendedProtection.PolicyEnforcement" />, указывающее, когда следует применять расширенную политику защиты.</param>
		// Token: 0x06001530 RID: 5424 RVA: 0x0000219B File Offset: 0x0000039B
		[MonoTODO("Not implemented.")]
		public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который указывает, когда следует применять расширенную политику защиты и токен привязки канала (CBT).</summary>
		/// <param name="policyEnforcement">Значение <see cref="T:System.Security.Authentication.ExtendedProtection.PolicyEnforcement" />, указывающее, когда следует применять расширенную политику защиты.</param>
		/// <param name="customChannelBinding">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, содержащий настраиваемую привязку канала для проверки.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="policyEnforcement" /> определяется как <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Never" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="customChannelBinding" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001531 RID: 5425 RVA: 0x00055ABD File Offset: 0x00053CBD
		public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ChannelBinding customChannelBinding)
		{
			throw new NotImplementedException();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, указывающий, когда следует применять расширенную политику защиты, тип защиты, определяемый политикой, и настраиваемый список имен поставщиков услуг (SPN), используемый для сопоставления с SPN клиента.</summary>
		/// <param name="policyEnforcement">Значение <see cref="T:System.Security.Authentication.ExtendedProtection.PolicyEnforcement" />, указывающее, когда следует применять расширенную политику защиты.</param>
		/// <param name="protectionScenario">Значение <see cref="T:System.Security.Authentication.ExtendedProtection.ProtectionScenario" />, которое указывает тип защиты, определяемый политикой.</param>
		/// <param name="customServiceNames">Объект <see cref="T:System.Collections.ICollection" />, содержащий настраиваемый список SPN, используемый для сопоставления с SPN клиента.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="policyEnforcement" /> определяется как <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Never" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="customServiceNames" /> имеет значение <see langword="null" /> или является пустым списком.</exception>
		// Token: 0x06001532 RID: 5426 RVA: 0x00055ABD File Offset: 0x00053CBD
		public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ICollection customServiceNames)
		{
			throw new NotImplementedException();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, указывающий, когда следует применять расширенную политику защиты, тип защиты, определяемый политикой, и настраиваемый список имен поставщиков услуг (SPN), используемый для сопоставления с SPN клиента.</summary>
		/// <param name="policyEnforcement">Значение <see cref="T:System.Security.Authentication.ExtendedProtection.PolicyEnforcement" />, указывающее, когда следует применять расширенную политику защиты.</param>
		/// <param name="protectionScenario">Значение <see cref="T:System.Security.Authentication.ExtendedProtection.ProtectionScenario" />, которое указывает тип защиты, определяемый политикой.</param>
		/// <param name="customServiceNames">Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, содержащий настраиваемый список SPN, используемый для сопоставления с SPN клиента.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="policyEnforcement" /> определяется как <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Never" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="customServiceNames" /> имеет значение <see langword="null" /> или является пустым списком.</exception>
		// Token: 0x06001533 RID: 5427 RVA: 0x00055ABD File Offset: 0x00053CBD
		public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ServiceNameCollection customServiceNames)
		{
			throw new NotImplementedException();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, из объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащего данные, необходимые для заполнения <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</summary>
		/// <param name="info">Экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, необходимые для сериализации нового экземпляра класса <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</param>
		/// <param name="context">Экземпляр класса <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий источник сериализованного потока, связанного с новым экземпляром класса <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</param>
		// Token: 0x06001534 RID: 5428 RVA: 0x00055ABD File Offset: 0x00053CBD
		protected ExtendedProtectionPolicy(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает настраиваемую привязку канала (CBT) для проверки.</summary>
		/// <returns>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, содержащий настраиваемую привязку канала для проверки.</returns>
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x0000829A File Offset: 0x0000649A
		public ChannelBinding CustomChannelBinding
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает список пользовательских имен поставщиков услуг SPN, которые используются для сопоставления с SPN клиента.</summary>
		/// <returns>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, содержащий настраиваемый список SPN, используемый для сопоставления с SPN клиента.</returns>
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x0000829A File Offset: 0x0000649A
		public ServiceNameCollection CustomServiceNames
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Указывает, поддерживает ли операционная система встроенную проверку подлинности Windows с расширенной защитой.</summary>
		/// <returns>Значение <see langword="true" />, если операционная система поддерживает встроенную проверку подлинности Windows с расширенной защитой; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x0000829A File Offset: 0x0000649A
		public static bool OSSupportsExtendedProtection
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает значение, которое указывает, когда следует применять расширенную политику защиты.</summary>
		/// <returns>Значение <see cref="T:System.Security.Authentication.ExtendedProtection.PolicyEnforcement" />, указывающее, когда следует применять расширенную политику защиты.</returns>
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0000829A File Offset: 0x0000649A
		public PolicyEnforcement PolicyEnforcement
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает значение, которое указывает тип защиты, регламентированный расширенной политикой защиты.</summary>
		/// <returns>Значение <see cref="T:System.Security.Authentication.ExtendedProtection.ProtectionScenario" />, которое указывает тип защиты, определяемый политикой.</returns>
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x0000829A File Offset: 0x0000649A
		public ProtectionScenario ProtectionScenario
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает строковое представление экземпляра расширенной политики защиты.</summary>
		/// <returns>Экземпляр <see cref="T:System.String" />, содержащий представление экземпляра <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</returns>
		// Token: 0x0600153A RID: 5434 RVA: 0x00055ACA File Offset: 0x00053CCA
		[MonoTODO]
		public override string ToString()
		{
			return base.ToString();
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимые для сериализации объекта <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные для объекта <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий назначение сериализованного потока, связанного с классом <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</param>
		// Token: 0x0600153B RID: 5435 RVA: 0x0000829A File Offset: 0x0000649A
		[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}
	}
}
