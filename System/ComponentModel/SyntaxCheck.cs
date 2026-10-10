using System;
using System.IO;

namespace System.ComponentModel
{
	/// <summary>Предоставляет методы проверки соответствия имени компьютера и пути конкретному синтаксису. Этот класс не наследуется.</summary>
	// Token: 0x020003EE RID: 1006
	public static class SyntaxCheck
	{
		/// <summary>Проверяет синтаксис имени компьютера, подтверждая отсутствие символа "\".</summary>
		/// <param name="value">Строка, содержащая проверяемое имя компьютера.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> соответствует правильному имени компьютера; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020EA RID: 8426 RVA: 0x00071914 File Offset: 0x0006FB14
		public static bool CheckMachineName(string value)
		{
			if (value == null)
			{
				return false;
			}
			value = value.Trim();
			return !value.Equals(string.Empty) && value.IndexOf('\\') == -1;
		}

		/// <summary>Проверяет синтаксис пути, подтверждая, что путь начинается с "\\".</summary>
		/// <param name="value">Строка, содержащая проверяемый путь.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> соответствует правильному формату пути; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020EB RID: 8427 RVA: 0x0007193D File Offset: 0x0006FB3D
		public static bool CheckPath(string value)
		{
			if (value == null)
			{
				return false;
			}
			value = value.Trim();
			return !value.Equals(string.Empty) && value.StartsWith("\\\\");
		}

		/// <summary>Проверяет синтаксис пути, определяя, начинается ли он с символа "\" или буквы диска "C:".</summary>
		/// <param name="value">Строка, содержащая проверяемый путь.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> соответствует правильному формату пути; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020EC RID: 8428 RVA: 0x00071966 File Offset: 0x0006FB66
		public static bool CheckRootedPath(string value)
		{
			if (value == null)
			{
				return false;
			}
			value = value.Trim();
			return !value.Equals(string.Empty) && Path.IsPathRooted(value);
		}
	}
}
