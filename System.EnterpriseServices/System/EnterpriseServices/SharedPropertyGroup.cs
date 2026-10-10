using System;
using System.Runtime.InteropServices;
using Unity;

namespace System.EnterpriseServices
{
	/// <summary>Представляет коллекцию общих свойств. Этот класс не наследуется.</summary>
	// Token: 0x0200004B RID: 75
	[ComVisible(false)]
	public sealed class SharedPropertyGroup
	{
		// Token: 0x06000141 RID: 321 RVA: 0x000025E7 File Offset: 0x000007E7
		internal SharedPropertyGroup(ISharedPropertyGroup propertyGroup)
		{
			this.propertyGroup = propertyGroup;
		}

		/// <summary>Создает свойство с заданным именем.</summary>
		/// <param name="name">Имя нового свойства.</param>
		/// <param name="fExists">Определяет, существует ли свойство. Возвращается значение <see langword="true" />, если свойство существует.</param>
		/// <returns>Запрошенный <see cref="T:System.EnterpriseServices.SharedProperty" />.</returns>
		// Token: 0x06000142 RID: 322 RVA: 0x000025F6 File Offset: 0x000007F6
		public SharedProperty CreateProperty(string name, out bool fExists)
		{
			return new SharedProperty(this.propertyGroup.CreateProperty(name, out fExists));
		}

		/// <summary>Создает свойство в заданной позиции.</summary>
		/// <param name="position">Индекс нового свойства.</param>
		/// <param name="fExists">Определяет, существует ли свойство. Возвращается значение <see langword="true" />, если свойство существует.</param>
		/// <returns>Запрошенный <see cref="T:System.EnterpriseServices.SharedProperty" />.</returns>
		// Token: 0x06000143 RID: 323 RVA: 0x0000260A File Offset: 0x0000080A
		public SharedProperty CreatePropertyByPosition(int position, out bool fExists)
		{
			return new SharedProperty(this.propertyGroup.CreatePropertyByPosition(position, out fExists));
		}

		/// <summary>Возвращает свойство с заданным именем.</summary>
		/// <param name="name">Имя запрошенного свойства.</param>
		/// <returns>Запрошенный <see cref="T:System.EnterpriseServices.SharedProperty" />.</returns>
		// Token: 0x06000144 RID: 324 RVA: 0x0000261E File Offset: 0x0000081E
		public SharedProperty Property(string name)
		{
			return new SharedProperty(this.propertyGroup.Property(name));
		}

		/// <summary>Возвращает свойство в заданной позиции.</summary>
		/// <param name="position">Индекс свойства.</param>
		/// <returns>Запрошенный <see cref="T:System.EnterpriseServices.SharedProperty" />.</returns>
		// Token: 0x06000145 RID: 325 RVA: 0x00002631 File Offset: 0x00000831
		public SharedProperty PropertyByPosition(int position)
		{
			return new SharedProperty(this.propertyGroup.PropertyByPosition(position));
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000024CD File Offset: 0x000006CD
		internal SharedPropertyGroup()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000087 RID: 135
		private ISharedPropertyGroup propertyGroup;
	}
}
