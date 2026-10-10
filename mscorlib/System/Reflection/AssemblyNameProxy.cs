using System;

namespace System.Reflection
{
	/// <summary>Обеспечивает версию <see langword="AssemblyName" />, поддерживающую удаленное взаимодействие.</summary>
	// Token: 0x020008DB RID: 2267
	public class AssemblyNameProxy : MarshalByRefObject
	{
		/// <summary>Возвращает <see langword="AssemblyName" /> для заданного файла.</summary>
		/// <param name="assemblyFile">Файл сборки, для которого нужно возвратить значение <see langword="AssemblyName" />.</param>
		/// <returns>Объект <see langword="AssemblyName" />, представляющий заданный файл.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyFile" /> пуст.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.</exception>
		// Token: 0x06004B82 RID: 19330 RVA: 0x000F08F9 File Offset: 0x000EEAF9
		public AssemblyName GetAssemblyName(string assemblyFile)
		{
			return AssemblyName.GetAssemblyName(assemblyFile);
		}
	}
}
