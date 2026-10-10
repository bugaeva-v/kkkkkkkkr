using System;

namespace System.EnterpriseServices
{
	/// <summary>Хранит объекты в текущей транзакции. Этот класс не наследуется.</summary>
	// Token: 0x0200003F RID: 63
	public sealed class ResourcePool
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ResourcePool" />.</summary>
		/// <param name="cb">Объект <see cref="T:System.EnterpriseServices.ResourcePool.TransactionEndDelegate" />, вызываемый по окончании транзакции. Все элементы, хранимые в транзакции в данный момент, возвращаются пользователю через делегата.</param>
		// Token: 0x060000DB RID: 219 RVA: 0x000021E0 File Offset: 0x000003E0
		[MonoTODO]
		public ResourcePool(ResourcePool.TransactionEndDelegate cb)
		{
		}

		/// <summary>Возвращает ресурс из текущей транзакции.</summary>
		/// <returns>Объект ресурса.</returns>
		// Token: 0x060000DC RID: 220 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public object GetResource()
		{
			throw new NotImplementedException();
		}

		/// <summary>Добавляет ресурс в текущую транзакцию.</summary>
		/// <param name="resource">Добавляемый ресурс.</param>
		/// <returns>Значение <see langword="true" />, если объект ресурса добавлен в пул; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000DD RID: 221 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool PutResource(object resource)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет метод, обрабатывающий завершение транзакции.</summary>
		/// <param name="resource">Объект, передаваемый обратно делегату.</param>
		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060000DF RID: 223
		public delegate void TransactionEndDelegate(object resource);
	}
}
