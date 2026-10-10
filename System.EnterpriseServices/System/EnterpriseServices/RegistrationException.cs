using System;
using System.Runtime.Serialization;

namespace System.EnterpriseServices
{
	/// <summary>Исключение возникает при обнаружении ошибки регистрации.</summary>
	// Token: 0x0200003C RID: 60
	[Serializable]
	public sealed class RegistrationException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.RegistrationException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="msg">Сообщение, отображаемое для клиента при возникновении исключения.</param>
		// Token: 0x060000C5 RID: 197 RVA: 0x000024D4 File Offset: 0x000006D4
		[MonoTODO]
		public RegistrationException(string msg) : base(msg)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.RegistrationException" />.</summary>
		// Token: 0x060000C6 RID: 198 RVA: 0x000024DD File Offset: 0x000006DD
		public RegistrationException() : this("Registration error")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.RegistrationException" /> с указанным сообщением об ошибке и вложенным исключением.</summary>
		/// <param name="msg">Сообщение, отображаемое для клиента при возникновении исключения.</param>
		/// <param name="inner">Вложенное исключение.</param>
		// Token: 0x060000C7 RID: 199 RVA: 0x000024EA File Offset: 0x000006EA
		public RegistrationException(string msg, Exception inner) : base(msg, inner)
		{
		}

		/// <summary>Получает массив объектов <see cref="T:System.EnterpriseServices.RegistrationErrorInfo" />, который описывает ошибки регистрации.</summary>
		/// <returns>Массив объектов <see cref="T:System.EnterpriseServices.RegistrationErrorInfo" />.</returns>
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000024F4 File Offset: 0x000006F4
		public RegistrationErrorInfo[] ErrorInfo
		{
			get
			{
				return this.errorInfo;
			}
		}

		/// <summary>Задает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> со сведениями об ошибке в объекте <see cref="T:System.EnterpriseServices.RegistrationErrorInfo" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта.</param>
		/// <param name="ctx">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060000C9 RID: 201 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000082 RID: 130
		private RegistrationErrorInfo[] errorInfo;
	}
}
