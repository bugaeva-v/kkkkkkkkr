using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Lifetime
{
	/// <summary>Предоставляет реализацию по умолчанию для класса спонсора жизненного цикла.</summary>
	// Token: 0x02000582 RID: 1410
	[ComVisible(true)]
	public class ClientSponsor : MarshalByRefObject, ISponsor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" /> значениями по умолчанию.</summary>
		// Token: 0x06003746 RID: 14150 RVA: 0x000C7848 File Offset: 0x000C5A48
		public ClientSponsor()
		{
			this.renewal_time = new TimeSpan(0, 2, 0);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" /> со временем продления существования спонсируемого объекта.</summary>
		/// <param name="renewalTime">Период <see cref="T:System.TimeSpan" />, на который увеличивается время жизни спонсируемых объектов при запросе продления.</param>
		// Token: 0x06003747 RID: 14151 RVA: 0x000C7869 File Offset: 0x000C5A69
		public ClientSponsor(TimeSpan renewalTime)
		{
			this.renewal_time = renewalTime;
		}

		/// <summary>Получает или задает период <see cref="T:System.TimeSpan" />, на который увеличивается время жизни спонсируемых объектов при запросе продления.</summary>
		/// <returns>Период <see cref="T:System.TimeSpan" />, на который увеличивается время жизни спонсируемых объектов при запросе продления.</returns>
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x000C7883 File Offset: 0x000C5A83
		// (set) Token: 0x06003749 RID: 14153 RVA: 0x000C788B File Offset: 0x000C5A8B
		public TimeSpan RenewalTime
		{
			get
			{
				return this.renewal_time;
			}
			set
			{
				this.renewal_time = value;
			}
		}

		/// <summary>Очищает объекты списка, зарегистрированные с текущим <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" />.</summary>
		// Token: 0x0600374A RID: 14154 RVA: 0x000C7894 File Offset: 0x000C5A94
		public void Close()
		{
			foreach (object obj in this.registered_objects.Values)
			{
				(((MarshalByRefObject)obj).GetLifetimeService() as ILease).Unregister(this);
			}
			this.registered_objects.Clear();
		}

		/// <summary>Освобождает ресурсы текущего <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" /> перед тем, как их востребует сборщик мусора.</summary>
		// Token: 0x0600374B RID: 14155 RVA: 0x000C7908 File Offset: 0x000C5B08
		~ClientSponsor()
		{
			this.Close();
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" />, предоставляя аренду для текущего объекта.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.Lifetime.ILease" /> для текущего объекта.</returns>
		// Token: 0x0600374C RID: 14156 RVA: 0x000C2AEC File Offset: 0x000C0CEC
		public override object InitializeLifetimeService()
		{
			return base.InitializeLifetimeService();
		}

		/// <summary>Регистрирует заданный <see cref="T:System.MarshalByRefObject" /> для спонсорства.</summary>
		/// <param name="obj">Объект, регистрируемый для спонсорства с помощью <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" />.</param>
		/// <returns>
		///   <see langword="true" />, если регистрация успешна; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600374D RID: 14157 RVA: 0x000C7934 File Offset: 0x000C5B34
		public bool Register(MarshalByRefObject obj)
		{
			if (this.registered_objects.ContainsKey(obj))
			{
				return false;
			}
			ILease lease = obj.GetLifetimeService() as ILease;
			if (lease == null)
			{
				return false;
			}
			lease.Register(this);
			this.registered_objects.Add(obj, obj);
			return true;
		}

		/// <summary>Запрашивает клиент-спонсор для обновления аренды выбранного объекта.</summary>
		/// <param name="lease">Аренда жизненного цикла объекта, для которого требуется продление срока аренды.</param>
		/// <returns>Дополнительное время аренды для заданного объекта.</returns>
		// Token: 0x0600374E RID: 14158 RVA: 0x000C7883 File Offset: 0x000C5A83
		[SecurityCritical]
		public TimeSpan Renewal(ILease lease)
		{
			return this.renewal_time;
		}

		/// <summary>Отменяет регистрацию заданного <see cref="T:System.MarshalByRefObject" /> из списка объектов, спонсируемых текущим <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" />.</summary>
		/// <param name="obj">Объект, регистрация которого отменяется.</param>
		// Token: 0x0600374F RID: 14159 RVA: 0x000C7977 File Offset: 0x000C5B77
		public void Unregister(MarshalByRefObject obj)
		{
			if (!this.registered_objects.ContainsKey(obj))
			{
				return;
			}
			(obj.GetLifetimeService() as ILease).Unregister(this);
			this.registered_objects.Remove(obj);
		}

		// Token: 0x04002587 RID: 9607
		private TimeSpan renewal_time;

		// Token: 0x04002588 RID: 9608
		private Hashtable registered_objects = new Hashtable();
	}
}
