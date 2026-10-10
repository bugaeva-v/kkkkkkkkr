using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	/// <summary>Определяет объект времени жизни аренды, который используется службой времени жизни удаленного взаимодействия.</summary>
	// Token: 0x02000583 RID: 1411
	[ComVisible(true)]
	public interface ILease
	{
		/// <summary>Возвращает оставшееся время аренды.</summary>
		/// <returns>Оставшееся время аренды.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06003750 RID: 14160
		TimeSpan CurrentLeaseTime { get; }

		/// <summary>Возвращает текущее состояние аренды — <see cref="T:System.Runtime.Remoting.Lifetime.LeaseState" />.</summary>
		/// <returns>Текущее состояние аренды — <see cref="T:System.Runtime.Remoting.Lifetime.LeaseState" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06003751 RID: 14161
		LeaseState CurrentState { get; }

		/// <summary>Возвращает или задает начальное время для аренды.</summary>
		/// <returns>Начальное время для аренды.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06003752 RID: 14162
		// (set) Token: 0x06003753 RID: 14163
		TimeSpan InitialLeaseTime { get; set; }

		/// <summary>Возвращает или задает промежуток времени, на который вызов удаленного объекта продляет <see cref="P:System.Runtime.Remoting.Lifetime.ILease.CurrentLeaseTime" />.</summary>
		/// <returns>Промежуток времени, на который вызов удаленного объекта продляет <see cref="P:System.Runtime.Remoting.Lifetime.ILease.CurrentLeaseTime" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06003754 RID: 14164
		// (set) Token: 0x06003755 RID: 14165
		TimeSpan RenewOnCallTime { get; set; }

		/// <summary>Возвращает или задает время ожидания спонсора для возврата со временем продления срока аренды.</summary>
		/// <returns>Время ожидания спонсора для возврата со временем продления срока аренды.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06003756 RID: 14166
		// (set) Token: 0x06003757 RID: 14167
		TimeSpan SponsorshipTimeout { get; set; }

		/// <summary>Регистрирует спонсора для аренды без продления ее срока.</summary>
		/// <param name="obj">Объект обратного вызова спонсора.</param>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003758 RID: 14168
		void Register(ISponsor obj);

		/// <summary>Регистрирует спонсора для аренды и продляет ее на заданный срок <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="obj">Объект обратного вызова спонсора.</param>
		/// <param name="renewalTime">Интервал времени для продления аренды.</param>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003759 RID: 14169
		void Register(ISponsor obj, TimeSpan renewalTime);

		/// <summary>Продляет аренду на заданное время.</summary>
		/// <param name="renewalTime">Интервал времени для продления аренды.</param>
		/// <returns>Новый срок аренды.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x0600375A RID: 14170
		TimeSpan Renew(TimeSpan renewalTime);

		/// <summary>Удаляет спонсора из списка спонсоров.</summary>
		/// <param name="obj">Спонсор аренды, для которого нужно отменить регистрацию.</param>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x0600375B RID: 14171
		void Unregister(ISponsor obj);
	}
}
