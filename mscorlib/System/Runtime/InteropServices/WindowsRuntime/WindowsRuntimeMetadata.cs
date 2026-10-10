using System;
using System.Collections.Generic;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Предоставляет событие для разрешения запросов типов, предназначенных только для отражений, для типов, предоставляемых файлами метаданных Windows, и методы для выполнения разрешения.</summary>
	// Token: 0x0200079A RID: 1946
	[MonoTODO]
	public static class WindowsRuntimeMetadata
	{
		/// <summary>Находит файлы метаданных Windows для указанного пространства имен, используя указанные расположения для поиска.</summary>
		/// <param name="namespaceName">Разрешаемое пространство имен.</param>
		/// <param name="packageGraphFilePaths">Путь приложения для поиска файлов метаданных Windows или значение <see langword="null" /> для поиска только файлов метаданных Windows из каталога установки операционной системы.</param>
		/// <returns>Перечислимый список строк, представляющий файлы метаданных Windows, которые определяют <paramref name="namespaceName" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Версия операционной системой не поддерживает Среда выполнения Windows.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="namespaceName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060044EA RID: 17642 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IEnumerable<string> ResolveNamespace(string namespaceName, IEnumerable<string> packageGraphFilePaths)
		{
			throw new NotImplementedException();
		}

		/// <summary>Находит файлы метаданных Windows для указанного пространства имен, используя указанные расположения для поиска.</summary>
		/// <param name="namespaceName">Разрешаемое пространство имен.</param>
		/// <param name="windowsSdkFilePath">Путь для поиска файлов метаданных Windows, предоставленных пакетом SDK, или <see langword="null" /> для поиска файлов метаданных Windows из установки операционной системы.</param>
		/// <param name="packageGraphFilePaths">Пути приложения, в которых выполняется поиск файлов метаданных Windows.</param>
		/// <returns>Перечислимый список строк, представляющий файлы метаданных Windows, которые определяют <paramref name="namespaceName" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Версия операционной системой не поддерживает Среда выполнения Windows.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="namespaceName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060044EB RID: 17643 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IEnumerable<string> ResolveNamespace(string namespaceName, string windowsSdkFilePath, IEnumerable<string> packageGraphFilePaths)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возникает, когда разрешение файла метаданных Windows завершается неудачей в среде разработки.</summary>
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060044EC RID: 17644 RVA: 0x000E4F90 File Offset: 0x000E3190
		// (remove) Token: 0x060044ED RID: 17645 RVA: 0x000E4FC4 File Offset: 0x000E31C4
		public static event EventHandler<DesignerNamespaceResolveEventArgs> DesignerNamespaceResolve;

		/// <summary>Возникает, когда разрешение файла метаданных Windows завершается неудачей в контексте, поддерживающем только отражение.</summary>
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060044EE RID: 17646 RVA: 0x000E4FF8 File Offset: 0x000E31F8
		// (remove) Token: 0x060044EF RID: 17647 RVA: 0x000E502C File Offset: 0x000E322C
		public static event EventHandler<NamespaceResolveEventArgs> ReflectionOnlyNamespaceResolve;
	}
}
