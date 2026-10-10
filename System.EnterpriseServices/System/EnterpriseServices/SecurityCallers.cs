using System;
using System.Collections;

namespace System.EnterpriseServices
{
	/// <summary>Предоставляет упорядоченную коллекцию удостоверений в текущей цепочке вызовов.</summary>
	// Token: 0x02000043 RID: 67
	public sealed class SecurityCallers : IEnumerable
	{
		// Token: 0x060000EE RID: 238 RVA: 0x000021E0 File Offset: 0x000003E0
		internal SecurityCallers()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000021E0 File Offset: 0x000003E0
		internal SecurityCallers(ISecurityCallersColl collection)
		{
		}

		/// <summary>Возвращает число вызывающих объектов в цепочке.</summary>
		/// <returns>Число вызывающих операторов в цепочке.</returns>
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002085 File Offset: 0x00000285
		public int Count
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает указанный элемент <see cref="T:System.EnterpriseServices.SecurityIdentity" />.</summary>
		/// <param name="idx">Элемент, для доступа к которому необходим индекс.</param>
		/// <returns>Объект <see cref="T:System.EnterpriseServices.SecurityIdentity" />.</returns>
		// Token: 0x17000046 RID: 70
		public SecurityIdentity this[int idx]
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Извлекает интерфейс перечисления для объекта.</summary>
		/// <returns>Интерфейс перечислителя для коллекции <see langword="ISecurityCallersColl" />.</returns>
		// Token: 0x060000F2 RID: 242 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
