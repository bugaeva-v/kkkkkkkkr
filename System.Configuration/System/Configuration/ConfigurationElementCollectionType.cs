using System;

namespace System.Configuration
{
	/// <summary>Указывает тип объекта <see cref="T:System.Configuration.ConfigurationElementCollectionType" />.</summary>
	// Token: 0x0200001E RID: 30
	public enum ConfigurationElementCollectionType
	{
		/// <summary>Коллекции этого типа содержат элементы, которые применяются на том уровне, на котором они определены, и на всех дочерних уровнях. Дочерний уровень не может изменить свойства, определенные родительским элементом данного типа.</summary>
		// Token: 0x04000081 RID: 129
		BasicMap,
		/// <summary>Тип по умолчанию объекта <see cref="T:System.Configuration.ConfigurationElementCollection" />. Коллекции этого типа содержат элементы, которые могут быть объединены в иерархии файлов конфигурации. На любом уровне такой иерархии директивы <see langword="add" />, <see langword="remove" /> и <see langword="clear" /> используются для изменения любых унаследованных свойств и определения новых.</summary>
		// Token: 0x04000082 RID: 130
		AddRemoveClearMap,
		/// <summary>То же самое, что и <see cref="F:System.Configuration.ConfigurationElementCollectionType.BasicMap" />, за исключением того, что этот тип заставляет объект <see cref="T:System.Configuration.ConfigurationElementCollection" /> сортировать свое содержимое так, что унаследованные элементы перечисляются последними.</summary>
		// Token: 0x04000083 RID: 131
		BasicMapAlternate,
		/// <summary>То же самое, что и <see cref="F:System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap" />, за исключением того, что этот тип заставляет объект <see cref="T:System.Configuration.ConfigurationElementCollection" /> сортировать свое содержимое так, что унаследованные элементы перечисляются последними.</summary>
		// Token: 0x04000084 RID: 132
		AddRemoveClearMapAlternate
	}
}
