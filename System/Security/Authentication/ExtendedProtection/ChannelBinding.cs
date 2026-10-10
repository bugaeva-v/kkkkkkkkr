using System;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Authentication.ExtendedProtection
{
	/// <summary>Класс <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> содержит указатель на непрозрачные данные, используемые для связывания прошедшей проверку подлинности транзакции с безопасным каналом.</summary>
	// Token: 0x020002A4 RID: 676
	public abstract class ChannelBinding : SafeHandleZeroOrMinusOneIsInvalid
	{
		/// <summary>Свойство <see cref="P:System.Security.Authentication.ExtendedProtection.ChannelBinding.Size" /> получает размер (в байтах) токена привязки канала, связанного с экземпляром <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />.</summary>
		/// <returns>Размер (в байтах) токена привязки канала, связанного с экземпляром <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />.</returns>
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600152D RID: 5421
		public abstract int Size { get; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />.</summary>
		// Token: 0x0600152E RID: 5422 RVA: 0x00055AAB File Offset: 0x00053CAB
		protected ChannelBinding() : this(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />.</summary>
		/// <param name="ownsHandle">Логическое значение, указывающее, что приложение содержит безопасный дескриптор собственной области памяти, содержащей байтовые данные, которые передаются собственным вызовам, предоставляющим расширенную защиту для встроенной проверки подлинности Windows.</param>
		// Token: 0x0600152F RID: 5423 RVA: 0x00055AB4 File Offset: 0x00053CB4
		protected ChannelBinding(bool ownsHandle) : base(ownsHandle)
		{
		}
	}
}
