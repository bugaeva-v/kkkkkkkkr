using System;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Configuration.SchemeSettingElement" />.</summary>
	// Token: 0x02000879 RID: 2169
	[ConfigurationCollection(typeof(SchemeSettingElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap, AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	public sealed class SchemeSettingElementCollection : ConfigurationElementCollection
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SchemeSettingElementCollection" />.</summary>
		// Token: 0x060044BA RID: 17594 RVA: 0x00013BCA File Offset: 0x00011DCA
		public SchemeSettingElementCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает элемент по указанному индексу в коллекции <see cref="T:System.Configuration.SchemeSettingElementCollection" />.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Configuration.SchemeSettingElement" />.</param>
		/// <returns>Указанный <see cref="T:System.Configuration.SchemeSettingElement" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Элемент, заданный параметром, имеет значение <see langword="null" /> или удален.</exception>
		// Token: 0x17000F88 RID: 3976
		public SchemeSettingElement this[int index]
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00032884 File Offset: 0x00030A84
		protected override ConfigurationElement CreateNewElement()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00032884 File Offset: 0x00030A84
		protected override object GetElementKey(ConfigurationElement element)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Индекс указанного объекта <see cref="T:System.Configuration.SchemeSettingElement" />.</summary>
		/// <param name="element">Объект <see cref="T:System.Configuration.SchemeSettingElement" /> по указанному расположению индекса.</param>
		/// <returns>Индекс заданного объекта <see cref="T:System.Configuration.SchemeSettingElement" />; в противном случае — значение -1.</returns>
		// Token: 0x060044BE RID: 17598 RVA: 0x000ED1D4 File Offset: 0x000EB3D4
		public int IndexOf(SchemeSettingElement element)
		{
			ThrowStub.ThrowNotSupportedException();
			return 0;
		}
	}
}
