using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Управляет доступом к группам общих свойств. Этот класс не наследуется.</summary>
	// Token: 0x0200004C RID: 76
	[ComVisible(false)]
	public sealed class SharedPropertyGroupManager : IEnumerable
	{
		/// <summary>Ищет или создает группу свойств с заданными сведениями.</summary>
		/// <param name="name">Имя запрошенного свойства.</param>
		/// <param name="dwIsoMode">Одно из значений <see cref="T:System.EnterpriseServices.PropertyLockMode" />. Дополнительные сведения см. в разделе "Примечания".</param>
		/// <param name="dwRelMode">Одно из значений <see cref="T:System.EnterpriseServices.PropertyReleaseMode" />. Дополнительные сведения см. в разделе "Примечания".</param>
		/// <param name="fExist">При возвращении метод содержит значение <see langword="true" />, если свойство уже существует; или значение <see langword="false" />, если свойство было создано при вызове.</param>
		/// <returns>Запрошенный <see cref="T:System.EnterpriseServices.SharedPropertyGroup" />.</returns>
		// Token: 0x06000148 RID: 328 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public SharedPropertyGroup CreatePropertyGroup(string name, ref PropertyLockMode dwIsoMode, ref PropertyReleaseMode dwRelMode, out bool fExist)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает интерфейс перечисления для коллекции.</summary>
		/// <returns>Интерфейс перечислителя для коллекции.</returns>
		// Token: 0x06000149 RID: 329 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <summary>Ищет группу свойств с заданным именем.</summary>
		/// <param name="name">Имя запрошенного свойства.</param>
		/// <returns>Запрошенный <see cref="T:System.EnterpriseServices.SharedPropertyGroup" />.</returns>
		// Token: 0x0600014A RID: 330 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public SharedPropertyGroup Group(string name)
		{
			throw new NotImplementedException();
		}
	}
}
