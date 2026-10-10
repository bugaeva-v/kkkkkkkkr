using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;

namespace System.IO
{
	/// <summary>Выполняет операции для экземпляров класса <see cref="T:System.String" />, содержащих сведения о пути к файлу или каталогу. Эти операции выполняются межплатформенным способом.</summary>
	// Token: 0x02000B67 RID: 2919
	[ComVisible(true)]
	public static class Path
	{
		/// <summary>Изменяет расширение строки пути.</summary>
		/// <param name="path">Сведения о пути, которые нужно изменить. Путь не может содержать символы, определенные в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</param>
		/// <param name="extension">Новое расширение (начинающееся с точки или без нее). Задает <see langword="null" /> для удаления существующего расширения из параметра <paramref name="path" />.</param>
		/// <returns>Измененные сведения о пути.  
		/// В настольных системах, работающих под управлением Windows, сведения о пути возвращаются без изменений, если значение параметра <paramref name="path" /> равно <see langword="null" /> или пустой строке (""). Если значение параметра <paramref name="extension" /> равно <see langword="null" />, возвращаемая строка содержит указанный путь без расширения. Если <paramref name="path" /> не имеет расширения и значение параметра <paramref name="extension" /> не равно <see langword="null" />, возвращаемая строка пути содержит <paramref name="extension" />, добавленное в конец <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		// Token: 0x06006A14 RID: 27156 RVA: 0x0016A0EC File Offset: 0x001682EC
		public static string ChangeExtension(string path, string extension)
		{
			if (path == null)
			{
				return null;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			int num = Path.findExtension(path);
			if (extension == null)
			{
				if (num >= 0)
				{
					return path.Substring(0, num);
				}
				return path;
			}
			else if (extension.Length == 0)
			{
				if (num >= 0)
				{
					return path.Substring(0, num + 1);
				}
				return path + ".";
			}
			else
			{
				if (path.Length != 0)
				{
					if (extension.Length > 0 && extension[0] != '.')
					{
						extension = "." + extension;
					}
				}
				else
				{
					extension = string.Empty;
				}
				if (num < 0)
				{
					return path + extension;
				}
				if (num > 0)
				{
					return path.Substring(0, num) + extension;
				}
				return extension;
			}
		}

		/// <summary>Объединяет две строки в путь.</summary>
		/// <param name="path1">Первый путь для объединения.</param>
		/// <param name="path2">Второй путь для объединения.</param>
		/// <returns>Объединенные пути. Если один из указанных путей является строкой нулевой длины, этот метод возвращает другой путь. Если в качестве значения параметра <paramref name="path2" /> задан абсолютный путь, этот метод возвращает <paramref name="path2" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path1" /> или <paramref name="path2" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="path1" /> или <paramref name="path2" /> — <see langword="null" />.</exception>
		// Token: 0x06006A15 RID: 27157 RVA: 0x0016A1A8 File Offset: 0x001683A8
		public static string Combine(string path1, string path2)
		{
			if (path1 == null)
			{
				throw new ArgumentNullException("path1");
			}
			if (path2 == null)
			{
				throw new ArgumentNullException("path2");
			}
			if (path1.Length == 0)
			{
				return path2;
			}
			if (path2.Length == 0)
			{
				return path1;
			}
			if (path1.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			if (path2.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			if (Path.IsPathRooted(path2))
			{
				return path2;
			}
			char c = path1[path1.Length - 1];
			if (c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar && c != Path.VolumeSeparatorChar)
			{
				return path1 + Path.DirectorySeparatorStr + path2;
			}
			return path1 + path2;
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x0016A25C File Offset: 0x0016845C
		internal static string CleanPath(string s)
		{
			int length = s.Length;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			char c = s[0];
			if (length > 2 && c == '\\' && s[1] == '\\')
			{
				num3 = 2;
			}
			if (length == 1 && (c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar))
			{
				return s;
			}
			for (int i = num3; i < length; i++)
			{
				char c2 = s[i];
				if (c2 == Path.DirectorySeparatorChar || c2 == Path.AltDirectorySeparatorChar)
				{
					if (Path.DirectorySeparatorChar != Path.AltDirectorySeparatorChar && c2 == Path.AltDirectorySeparatorChar)
					{
						num2++;
					}
					if (i + 1 == length)
					{
						num++;
					}
					else
					{
						c2 = s[i + 1];
						if (c2 == Path.DirectorySeparatorChar || c2 == Path.AltDirectorySeparatorChar)
						{
							num++;
						}
					}
				}
			}
			if (num == 0 && num2 == 0)
			{
				return s;
			}
			char[] array = new char[length - num];
			if (num3 != 0)
			{
				array[0] = '\\';
				array[1] = '\\';
			}
			int j = num3;
			int num4 = num3;
			while (j < length && num4 < array.Length)
			{
				char c3 = s[j];
				if (c3 != Path.DirectorySeparatorChar && c3 != Path.AltDirectorySeparatorChar)
				{
					array[num4++] = c3;
				}
				else if (num4 + 1 != array.Length)
				{
					array[num4++] = Path.DirectorySeparatorChar;
					while (j < length - 1)
					{
						c3 = s[j + 1];
						if (c3 != Path.DirectorySeparatorChar && c3 != Path.AltDirectorySeparatorChar)
						{
							break;
						}
						j++;
					}
				}
				j++;
			}
			return new string(array);
		}

		/// <summary>Возвращает для указанной строки пути сведения о каталоге.</summary>
		/// <param name="path">Путь к файлу или каталогу.</param>
		/// <returns>Сведения о каталоге для <paramref name="path" />, или значение <see langword="null" />, если путь <paramref name="path" /> указывает на корневой каталог или равен NULL. Возвращает <see cref="F:System.String.Empty" />, если параметр <paramref name="path" /> не содержит сведения о каталоге.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> пустой или содержит недопустимые символы либо только пробелы.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.IO.IOException" />.  
		///
		///
		///
		///
		///  Имя параметра <paramref name="path" /> превышает максимально допустимую в системе длину.</exception>
		// Token: 0x06006A17 RID: 27159 RVA: 0x0016A3D8 File Offset: 0x001685D8
		public static string GetDirectoryName(string path)
		{
			if (path == string.Empty)
			{
				throw new ArgumentException("Invalid path");
			}
			if (path == null || Path.GetPathRoot(path) == path)
			{
				return null;
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException("Argument string consists of whitespace characters only.");
			}
			if (path.IndexOfAny(Path.InvalidPathChars) > -1)
			{
				throw new ArgumentException("Path contains invalid characters");
			}
			int num = path.LastIndexOfAny(Path.PathSeparatorChars);
			if (num == 0)
			{
				num++;
			}
			if (num <= 0)
			{
				return string.Empty;
			}
			string text = path.Substring(0, num);
			int length = text.Length;
			if (length >= 2 && Path.DirectorySeparatorChar == '\\' && text[length - 1] == Path.VolumeSeparatorChar)
			{
				return text + Path.DirectorySeparatorChar.ToString();
			}
			if (length == 1 && Path.DirectorySeparatorChar == '\\' && path.Length >= 2 && path[num] == Path.VolumeSeparatorChar)
			{
				return text + Path.VolumeSeparatorChar.ToString();
			}
			return Path.CleanPath(text);
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x0016A4D7 File Offset: 0x001686D7
		public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path)
		{
			return Path.GetDirectoryName(path.ToString()).AsSpan();
		}

		/// <summary>Возвращает расширение указанной строки пути.</summary>
		/// <param name="path">Строка пути, из которой нужно получить расширение.</param>
		/// <returns>Расширение указанного пути (включая точку ".") или значение <see langword="null" /> или <see cref="F:System.String.Empty" />. Если параметр <paramref name="path" /> имеет значение <see langword="null" />, <see cref="M:System.IO.Path.GetExtension(System.String)" /> возвращает <see langword="null" />. Если параметр <paramref name="path" /> не содержит сведений о расширении, <see cref="M:System.IO.Path.GetExtension(System.String)" /> возвращает <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		// Token: 0x06006A19 RID: 27161 RVA: 0x0016A4F0 File Offset: 0x001686F0
		public static string GetExtension(string path)
		{
			if (path == null)
			{
				return null;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			int num = Path.findExtension(path);
			if (num > -1 && num < path.Length - 1)
			{
				return path.Substring(num);
			}
			return string.Empty;
		}

		/// <summary>Возвращает имя файла и расширение указанной строки пути.</summary>
		/// <param name="path">Строка пути, из которой нужно получить имя файла и расширение.</param>
		/// <returns>Символы, следующие за последним символом каталога в пути <paramref name="path" />. Если последним символом параметра <paramref name="path" /> является символ разделения тома или каталога, этот метод возвращает <see cref="F:System.String.Empty" />. Если значением параметра <paramref name="path" /> является <see langword="null" />, метод возвращает <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		// Token: 0x06006A1A RID: 27162 RVA: 0x0016A540 File Offset: 0x00168740
		public static string GetFileName(string path)
		{
			if (path == null || path.Length == 0)
			{
				return path;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			int num = path.LastIndexOfAny(Path.PathSeparatorChars);
			if (num >= 0)
			{
				return path.Substring(num + 1);
			}
			return path;
		}

		/// <summary>Возвращает имя файла указанной строки пути без расширения.</summary>
		/// <param name="path">Путь к файлу.</param>
		/// <returns>Строка, возвращенная методом <see cref="M:System.IO.Path.GetFileName(System.String)" />, кроме последней точки (.) и всех следующих за ней символов.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		// Token: 0x06006A1B RID: 27163 RVA: 0x0016A58E File Offset: 0x0016878E
		public static string GetFileNameWithoutExtension(string path)
		{
			return Path.ChangeExtension(Path.GetFileName(path), null);
		}

		/// <summary>Возвращает для указанной строки пути абсолютный путь.</summary>
		/// <param name="path">Файл или каталог, для которых нужно получить сведения об абсолютном пути.</param>
		/// <returns>Полное расположение <paramref name="path" />, например "C:\MyFile.txt".</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, как указано в <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		/// Система не может извлечь абсолютный путь.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствуют необходимые разрешения.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> содержит двоеточие (:), которое не является частью идентификатора тома (например, "c:\").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x06006A1C RID: 27164 RVA: 0x0016A59C File Offset: 0x0016879C
		public static string GetFullPath(string path)
		{
			return Path.InsecureGetFullPath(path);
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x0016A59C File Offset: 0x0016879C
		internal static string GetFullPathInternal(string path)
		{
			return Path.InsecureGetFullPath(path);
		}

		// Token: 0x06006A1E RID: 27166
		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull);

		// Token: 0x06006A1F RID: 27167 RVA: 0x0016A5A4 File Offset: 0x001687A4
		internal static string GetFullPathName(string path)
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			IntPtr zero = IntPtr.Zero;
			int fullPathName = Path.GetFullPathName(path, 260, stringBuilder, ref zero);
			if (fullPathName == 0)
			{
				throw new IOException("Windows API call to GetFullPathName failed, Windows error code: " + Marshal.GetLastWin32Error().ToString());
			}
			if (fullPathName > 260)
			{
				stringBuilder = new StringBuilder(fullPathName);
				Path.GetFullPathName(path, fullPathName, stringBuilder, ref zero);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x0016A614 File Offset: 0x00168814
		internal static string WindowsDriveAdjustment(string path)
		{
			if (path.Length < 2)
			{
				if (path.Length == 1 && (path[0] == '\\' || path[0] == '/'))
				{
					return Path.GetPathRoot(Directory.GetCurrentDirectory());
				}
				return path;
			}
			else
			{
				if (path[1] != ':' || !char.IsLetter(path[0]))
				{
					return path;
				}
				string text = Directory.InsecureGetCurrentDirectory();
				if (path.Length == 2)
				{
					if (text[0] == path[0])
					{
						path = text;
					}
					else
					{
						path = Path.GetFullPathName(path);
					}
				}
				else if (path[2] != Path.DirectorySeparatorChar && path[2] != Path.AltDirectorySeparatorChar)
				{
					if (text[0] == path[0])
					{
						path = Path.Combine(text, path.Substring(2, path.Length - 2));
					}
					else
					{
						path = Path.GetFullPathName(path);
					}
				}
				return path;
			}
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x0016A6F0 File Offset: 0x001688F0
		internal static string InsecureGetFullPath(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException(Locale.GetText("The specified path is not of a legal form (empty)."));
			}
			if (Environment.IsRunningOnWindows)
			{
				path = Path.WindowsDriveAdjustment(path);
			}
			char c = path[path.Length - 1];
			bool flag = true;
			if (path.Length >= 2 && Path.IsDirectorySeparator(path[0]) && Path.IsDirectorySeparator(path[1]))
			{
				if (path.Length == 2 || path.IndexOf(path[0], 2) < 0)
				{
					throw new ArgumentException("UNC paths should be of the form \\\\server\\share.");
				}
				if (path[0] != Path.DirectorySeparatorChar)
				{
					path = path.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
				}
			}
			else if (!Path.IsPathRooted(path))
			{
				if (!Environment.IsRunningOnWindows)
				{
					int num = 0;
					while ((num = path.IndexOf('.', num)) != -1 && ++num != path.Length && path[num] != Path.DirectorySeparatorChar && path[num] != Path.AltDirectorySeparatorChar)
					{
					}
					flag = (num > 0);
				}
				string text = Directory.InsecureGetCurrentDirectory();
				if (text[text.Length - 1] == Path.DirectorySeparatorChar)
				{
					path = text + path;
				}
				else
				{
					path = text + Path.DirectorySeparatorChar.ToString() + path;
				}
			}
			else if (Path.DirectorySeparatorChar == '\\' && path.Length >= 2 && Path.IsDirectorySeparator(path[0]) && !Path.IsDirectorySeparator(path[1]))
			{
				string text2 = Directory.InsecureGetCurrentDirectory();
				if (text2[1] == Path.VolumeSeparatorChar)
				{
					path = text2.Substring(0, 2) + path;
				}
				else
				{
					path = text2.Substring(0, text2.IndexOf('\\', text2.IndexOfUnchecked("\\\\", 0, text2.Length) + 1));
				}
			}
			if (flag)
			{
				path = Path.CanonicalizePath(path);
			}
			if (Path.IsDirectorySeparator(c) && path[path.Length - 1] != Path.DirectorySeparatorChar)
			{
				path += Path.DirectorySeparatorChar.ToString();
			}
			string text3;
			if (MonoIO.RemapPath(path, out text3))
			{
				path = text3;
			}
			return path;
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x0016A91D File Offset: 0x00168B1D
		internal static bool IsDirectorySeparator(char c)
		{
			return c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar;
		}

		/// <summary>Возвращает сведения о корневом каталоге для указанного пути.</summary>
		/// <param name="path">Путь, из которого нужно получить сведения о корневом каталоге.</param>
		/// <returns>Корневой каталог параметра <paramref name="path" /> или <see langword="null" />, если параметр <paramref name="path" /> имеет значение <see langword="null" />, или пустая строка, если параметр <paramref name="path" /> не содержит сведений о корневом каталоге.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  Компонент <see cref="F:System.String.Empty" /> был передан в <paramref name="path" />.</exception>
		// Token: 0x06006A23 RID: 27171 RVA: 0x0016A934 File Offset: 0x00168B34
		public static string GetPathRoot(string path)
		{
			if (path == null)
			{
				return null;
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException("The specified path is not of a legal form.");
			}
			if (!Path.IsPathRooted(path))
			{
				return string.Empty;
			}
			if (Path.DirectorySeparatorChar == '/')
			{
				if (!Path.IsDirectorySeparator(path[0]))
				{
					return string.Empty;
				}
				return Path.DirectorySeparatorStr;
			}
			else
			{
				int num = 2;
				if (path.Length == 1 && Path.IsDirectorySeparator(path[0]))
				{
					return Path.DirectorySeparatorStr;
				}
				if (path.Length < 2)
				{
					return string.Empty;
				}
				if (Path.IsDirectorySeparator(path[0]) && Path.IsDirectorySeparator(path[1]))
				{
					while (num < path.Length && !Path.IsDirectorySeparator(path[num]))
					{
						num++;
					}
					if (num < path.Length)
					{
						num++;
						while (num < path.Length && !Path.IsDirectorySeparator(path[num]))
						{
							num++;
						}
					}
					return Path.DirectorySeparatorStr + Path.DirectorySeparatorStr + path.Substring(2, num - 2).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
				}
				if (Path.IsDirectorySeparator(path[0]))
				{
					return Path.DirectorySeparatorStr;
				}
				if (path[1] == Path.VolumeSeparatorChar)
				{
					if (path.Length >= 3 && Path.IsDirectorySeparator(path[2]))
					{
						num++;
					}
					return path.Substring(0, num);
				}
				return Directory.GetCurrentDirectory().Substring(0, 2);
			}
		}

		/// <summary>Создает на диске временный пустой файл с уникальным именем и возвращает полный путь этого файла.</summary>
		/// <returns>Полный путь к временному файлу.</returns>
		/// <exception cref="T:System.IO.IOException">Возникает ошибка ввода-вывода, например, отсутствует уникальное имя временного файла.  
		/// -или- 
		/// Этот метод не смог создать временный файл.</exception>
		// Token: 0x06006A24 RID: 27172 RVA: 0x0016AAA0 File Offset: 0x00168CA0
		[FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
		public static string GetTempFileName()
		{
			FileStream fileStream = null;
			int num = 0;
			Random random = new Random();
			string tempPath = Path.GetTempPath();
			string text;
			do
			{
				int num2 = random.Next();
				text = Path.Combine(tempPath, "tmp" + (num2 + 1).ToString("x", CultureInfo.InvariantCulture) + ".tmp");
				try
				{
					fileStream = new FileStream(text, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.Read, 8192, false, (FileOptions)1);
				}
				catch (IOException ex)
				{
					if (ex._HResult != -2147024816 || num++ > 65536)
					{
						throw;
					}
				}
				catch (UnauthorizedAccessException ex2)
				{
					if (num++ > 65536)
					{
						throw new IOException(ex2.Message, ex2);
					}
				}
			}
			while (fileStream == null);
			fileStream.Close();
			return text;
		}

		/// <summary>Возвращает путь к временной папке текущего пользователя.</summary>
		/// <returns>Путь к временной папке, заканчивающийся обратной косой чертой.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствуют необходимые разрешения.</exception>
		// Token: 0x06006A25 RID: 27173 RVA: 0x0016AB70 File Offset: 0x00168D70
		[EnvironmentPermission(SecurityAction.Demand, Unrestricted = true)]
		public static string GetTempPath()
		{
			string temp_path = Path.get_temp_path();
			if (temp_path.Length > 0 && temp_path[temp_path.Length - 1] != Path.DirectorySeparatorChar)
			{
				return temp_path + Path.DirectorySeparatorChar.ToString();
			}
			return temp_path;
		}

		// Token: 0x06006A26 RID: 27174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string get_temp_path();

		/// <summary>Определяет, включает ли путь расширение имени файла.</summary>
		/// <param name="path">Путь для поиска расширения.</param>
		/// <returns>Значение <see langword="true" />, если знаки, следующие за последним разделителем каталога (\\ или /) или разделителем тома (:) в пути, включают точку (.), за которой следует один или несколько символов. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		// Token: 0x06006A27 RID: 27175 RVA: 0x0016ABB4 File Offset: 0x00168DB4
		public static bool HasExtension(string path)
		{
			if (path == null || path.Trim().Length == 0)
			{
				return false;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			int num = Path.findExtension(path);
			return 0 <= num && num < path.Length - 1;
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x0016AC04 File Offset: 0x00168E04
		public unsafe static bool IsPathRooted(ReadOnlySpan<char> path)
		{
			if (path.Length == 0)
			{
				return false;
			}
			char c = (char)(*path[0]);
			return c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar || (!Path.dirEqualsVolume && path.Length > 1 && *path[1] == (ushort)Path.VolumeSeparatorChar);
		}

		/// <summary>Возвращает значение, указывающее, содержит ли заданный путь корневую папку.</summary>
		/// <param name="path">Проверяемый путь.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="path" /> содержит корневую папку; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		// Token: 0x06006A29 RID: 27177 RVA: 0x0016AC5B File Offset: 0x00168E5B
		public static bool IsPathRooted(string path)
		{
			if (path == null || path.Length == 0)
			{
				return false;
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Illegal characters in path.");
			}
			return Path.IsPathRooted(path.AsSpan());
		}

		/// <summary>Возвращает массив, содержащий символы, которые не разрешены в именах файлов.</summary>
		/// <returns>Массив, содержащий символы, которые не разрешены в именах файлов.</returns>
		// Token: 0x06006A2A RID: 27178 RVA: 0x0016AC8E File Offset: 0x00168E8E
		public static char[] GetInvalidFileNameChars()
		{
			if (Environment.IsRunningOnWindows)
			{
				return new char[]
				{
					'\0',
					'\u0001',
					'\u0002',
					'\u0003',
					'\u0004',
					'\u0005',
					'\u0006',
					'\a',
					'\b',
					'\t',
					'\n',
					'\v',
					'\f',
					'\r',
					'\u000e',
					'\u000f',
					'\u0010',
					'\u0011',
					'\u0012',
					'\u0013',
					'\u0014',
					'\u0015',
					'\u0016',
					'\u0017',
					'\u0018',
					'\u0019',
					'\u001a',
					'\u001b',
					'\u001c',
					'\u001d',
					'\u001e',
					'\u001f',
					'"',
					'<',
					'>',
					'|',
					':',
					'*',
					'?',
					'\\',
					'/'
				};
			}
			return new char[]
			{
				'\0',
				'/'
			};
		}

		/// <summary>Возвращает массив, содержащий символы, которые не разрешены в именах путей.</summary>
		/// <returns>Массив, содержащий символы, которые не разрешены в именах путей.</returns>
		// Token: 0x06006A2B RID: 27179 RVA: 0x0016ACB5 File Offset: 0x00168EB5
		public static char[] GetInvalidPathChars()
		{
			if (Environment.IsRunningOnWindows)
			{
				return new char[]
				{
					'"',
					'<',
					'>',
					'|',
					'\0',
					'\u0001',
					'\u0002',
					'\u0003',
					'\u0004',
					'\u0005',
					'\u0006',
					'\a',
					'\b',
					'\t',
					'\n',
					'\v',
					'\f',
					'\r',
					'\u000e',
					'\u000f',
					'\u0010',
					'\u0011',
					'\u0012',
					'\u0013',
					'\u0014',
					'\u0015',
					'\u0016',
					'\u0017',
					'\u0018',
					'\u0019',
					'\u001a',
					'\u001b',
					'\u001c',
					'\u001d',
					'\u001e',
					'\u001f'
				};
			}
			return new char[1];
		}

		/// <summary>Возвращает произвольное имя каталога или файла.</summary>
		/// <returns>Произвольное имя каталога или файла.</returns>
		// Token: 0x06006A2C RID: 27180 RVA: 0x0016ACD8 File Offset: 0x00168ED8
		public static string GetRandomFileName()
		{
			StringBuilder stringBuilder = new StringBuilder(12);
			RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
			byte[] array = new byte[11];
			randomNumberGenerator.GetBytes(array);
			for (int i = 0; i < array.Length; i++)
			{
				if (stringBuilder.Length == 8)
				{
					stringBuilder.Append('.');
				}
				int num = (int)(array[i] % 36);
				char value = (char)((num < 26) ? (num + 97) : (num - 26 + 48));
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x0016AD4C File Offset: 0x00168F4C
		private static int findExtension(string path)
		{
			if (path != null)
			{
				int num = path.LastIndexOf('.');
				int num2 = path.LastIndexOfAny(Path.PathSeparatorChars);
				if (num > num2)
				{
					return num;
				}
			}
			return -1;
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x0016AD78 File Offset: 0x00168F78
		static Path()
		{
			Path.VolumeSeparatorChar = MonoIO.VolumeSeparatorChar;
			Path.DirectorySeparatorChar = MonoIO.DirectorySeparatorChar;
			Path.AltDirectorySeparatorChar = MonoIO.AltDirectorySeparatorChar;
			Path.PathSeparator = MonoIO.PathSeparator;
			Path.InvalidPathChars = Path.GetInvalidPathChars();
			Path.DirectorySeparatorStr = Path.DirectorySeparatorChar.ToString();
			Path.PathSeparatorChars = new char[]
			{
				Path.DirectorySeparatorChar,
				Path.AltDirectorySeparatorChar,
				Path.VolumeSeparatorChar
			};
			Path.dirEqualsVolume = (Path.DirectorySeparatorChar == Path.VolumeSeparatorChar);
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x0016AE1C File Offset: 0x0016901C
		private static string GetServerAndShare(string path)
		{
			int num = 2;
			while (num < path.Length && !Path.IsDirectorySeparator(path[num]))
			{
				num++;
			}
			if (num < path.Length)
			{
				num++;
				while (num < path.Length && !Path.IsDirectorySeparator(path[num]))
				{
					num++;
				}
			}
			return path.Substring(2, num - 2).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x0016AE8C File Offset: 0x0016908C
		private static bool SameRoot(string root, string path)
		{
			if (root.Length < 2 || path.Length < 2)
			{
				return false;
			}
			if (!Path.IsDirectorySeparator(root[0]) || !Path.IsDirectorySeparator(root[1]))
			{
				return root[0].Equals(path[0]) && path[1] == Path.VolumeSeparatorChar && (root.Length <= 2 || path.Length <= 2 || (Path.IsDirectorySeparator(root[2]) && Path.IsDirectorySeparator(path[2])));
			}
			if (!Path.IsDirectorySeparator(path[0]) || !Path.IsDirectorySeparator(path[1]))
			{
				return false;
			}
			string serverAndShare = Path.GetServerAndShare(root);
			string serverAndShare2 = Path.GetServerAndShare(path);
			return string.Compare(serverAndShare, serverAndShare2, true, CultureInfo.InvariantCulture) == 0;
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x0016AF60 File Offset: 0x00169160
		private static string CanonicalizePath(string path)
		{
			if (path == null)
			{
				return path;
			}
			if (Environment.IsRunningOnWindows)
			{
				path = path.Trim();
			}
			if (path.Length == 0)
			{
				return path;
			}
			string pathRoot = Path.GetPathRoot(path);
			string[] array = path.Split(new char[]
			{
				Path.DirectorySeparatorChar,
				Path.AltDirectorySeparatorChar
			});
			int num = 0;
			bool flag = Environment.IsRunningOnWindows && pathRoot.Length > 2 && Path.IsDirectorySeparator(pathRoot[0]) && Path.IsDirectorySeparator(pathRoot[1]);
			int num2 = flag ? 3 : 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (Environment.IsRunningOnWindows)
				{
					array[i] = array[i].TrimEnd();
				}
				if (((flag && i == 2) || !(array[i] == ".")) && (i == 0 || array[i].Length != 0))
				{
					if (array[i] == "..")
					{
						if (num > num2)
						{
							num--;
						}
					}
					else
					{
						array[num++] = array[i];
					}
				}
			}
			if (num == 0 || (num == 1 && array[0] == ""))
			{
				return pathRoot;
			}
			string text = string.Join(Path.DirectorySeparatorStr, array, 0, num);
			if (!Environment.IsRunningOnWindows)
			{
				if (pathRoot != "" && text.Length > 0 && text[0] != '/')
				{
					text = pathRoot + text;
				}
				return text;
			}
			if (flag)
			{
				text = Path.DirectorySeparatorStr + text;
			}
			if (!Path.SameRoot(pathRoot, text))
			{
				text = pathRoot + text;
			}
			if (flag)
			{
				return text;
			}
			if (!Path.IsDirectorySeparator(path[0]) && Path.SameRoot(pathRoot, path))
			{
				if (text.Length <= 2 && !text.EndsWith(Path.DirectorySeparatorStr))
				{
					text += Path.DirectorySeparatorChar.ToString();
				}
				return text;
			}
			string currentDirectory = Directory.GetCurrentDirectory();
			if (currentDirectory.Length > 1 && currentDirectory[1] == Path.VolumeSeparatorChar)
			{
				if (text.Length == 0 || Path.IsDirectorySeparator(text[0]))
				{
					text += "\\";
				}
				return currentDirectory.Substring(0, 2) + text;
			}
			if (Path.IsDirectorySeparator(currentDirectory[currentDirectory.Length - 1]) && Path.IsDirectorySeparator(text[0]))
			{
				return currentDirectory + text.Substring(1);
			}
			return currentDirectory + text;
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x0016B1C4 File Offset: 0x001693C4
		internal static bool IsPathSubsetOf(string subset, string path)
		{
			if (subset.Length > path.Length)
			{
				return false;
			}
			int num = subset.LastIndexOfAny(Path.PathSeparatorChars);
			if (string.Compare(subset, 0, path, 0, num) != 0)
			{
				return false;
			}
			num++;
			int num2 = path.IndexOfAny(Path.PathSeparatorChars, num);
			if (num2 >= num)
			{
				return string.Compare(subset, num, path, num, path.Length - num2) == 0;
			}
			return subset.Length == path.Length && string.Compare(subset, num, path, num, subset.Length - num) == 0;
		}

		/// <summary>Объединяет массив строк в путь.</summary>
		/// <param name="paths">Массив частей пути.</param>
		/// <returns>Объединенные пути.</returns>
		/// <exception cref="T:System.ArgumentException">Одна из строк в массиве содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Одна из строк в массиве имеет значение <see langword="null" />.</exception>
		// Token: 0x06006A33 RID: 27187 RVA: 0x0016B24C File Offset: 0x0016944C
		public static string Combine(params string[] paths)
		{
			if (paths == null)
			{
				throw new ArgumentNullException("paths");
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = paths.Length;
			bool flag = false;
			foreach (string text in paths)
			{
				if (text == null)
				{
					throw new ArgumentNullException("One of the paths contains a null value", "paths");
				}
				if (text.Length != 0)
				{
					if (text.IndexOfAny(Path.InvalidPathChars) != -1)
					{
						throw new ArgumentException("Illegal characters in path.");
					}
					if (flag)
					{
						flag = false;
						stringBuilder.Append(Path.DirectorySeparatorStr);
					}
					num--;
					if (Path.IsPathRooted(text))
					{
						stringBuilder.Length = 0;
					}
					stringBuilder.Append(text);
					int length = text.Length;
					if (length > 0 && num > 0)
					{
						char c = text[length - 1];
						if (c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar && c != Path.VolumeSeparatorChar)
						{
							flag = true;
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		/// <summary>Объединяет три строки в путь.</summary>
		/// <param name="path1">Первый путь для объединения.</param>
		/// <param name="path2">Второй путь для объединения.</param>
		/// <param name="path3">Третий путь для объединения.</param>
		/// <returns>Объединенные пути.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path1" />, <paramref name="path2" /> или <paramref name="path3" /> содержит по крайней мере один из недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="path1" />, <paramref name="path2" /> или <paramref name="path3" /> равно <see langword="null" />.</exception>
		// Token: 0x06006A34 RID: 27188 RVA: 0x0016B340 File Offset: 0x00169540
		public static string Combine(string path1, string path2, string path3)
		{
			if (path1 == null)
			{
				throw new ArgumentNullException("path1");
			}
			if (path2 == null)
			{
				throw new ArgumentNullException("path2");
			}
			if (path3 == null)
			{
				throw new ArgumentNullException("path3");
			}
			return Path.Combine(new string[]
			{
				path1,
				path2,
				path3
			});
		}

		/// <summary>Объединяет четыре строки в путь.</summary>
		/// <param name="path1">Первый путь для объединения.</param>
		/// <param name="path2">Второй путь для объединения.</param>
		/// <param name="path3">Третий путь для объединения.</param>
		/// <param name="path4">Четвертый путь для объединения.</param>
		/// <returns>Объединенные пути.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path1" />, <paramref name="path2" />, <paramref name="path3" /> или <paramref name="path4" /> содержит один или несколько недопустимых символов, определенных в <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path1" />, <paramref name="path2" />, <paramref name="path3" /> или <paramref name="path4" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006A35 RID: 27189 RVA: 0x0016B390 File Offset: 0x00169590
		public static string Combine(string path1, string path2, string path3, string path4)
		{
			if (path1 == null)
			{
				throw new ArgumentNullException("path1");
			}
			if (path2 == null)
			{
				throw new ArgumentNullException("path2");
			}
			if (path3 == null)
			{
				throw new ArgumentNullException("path3");
			}
			if (path4 == null)
			{
				throw new ArgumentNullException("path4");
			}
			return Path.Combine(new string[]
			{
				path1,
				path2,
				path3,
				path4
			});
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x0016B3F0 File Offset: 0x001695F0
		internal static void Validate(string path)
		{
			Path.Validate(path, "path");
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x0016B400 File Offset: 0x00169600
		internal static void Validate(string path, string parameterName)
		{
			if (path == null)
			{
				throw new ArgumentNullException(parameterName);
			}
			if (string.IsNullOrWhiteSpace(path))
			{
				throw new ArgumentException(Locale.GetText("Path is empty"));
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException(Locale.GetText("Path contains invalid chars"));
			}
			if (Environment.IsRunningOnWindows)
			{
				int num = path.IndexOf(':');
				if (num >= 0 && num != 1)
				{
					throw new ArgumentException(parameterName);
				}
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x0016B46C File Offset: 0x0016966C
		internal static string DirectorySeparatorCharAsString
		{
			get
			{
				return Path.DirectorySeparatorStr;
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06006A39 RID: 27193 RVA: 0x0016B473 File Offset: 0x00169673
		internal static char[] TrimEndChars
		{
			get
			{
				if (!Environment.IsRunningOnWindows)
				{
					return Path.trimEndCharsUnix;
				}
				return Path.trimEndCharsWindows;
			}
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x0016B488 File Offset: 0x00169688
		internal static void CheckSearchPattern(string searchPattern)
		{
			int num;
			while ((num = searchPattern.IndexOf("..", StringComparison.Ordinal)) != -1)
			{
				if (num + 2 == searchPattern.Length)
				{
					throw new ArgumentException(Environment.GetResourceString("Search pattern cannot contain \"..\" to move up directories and can be contained only internally in file/directory names, as in \"a..b\"."));
				}
				if (searchPattern[num + 2] == Path.DirectorySeparatorChar || searchPattern[num + 2] == Path.AltDirectorySeparatorChar)
				{
					throw new ArgumentException(Environment.GetResourceString("Search pattern cannot contain \"..\" to move up directories and can be contained only internally in file/directory names, as in \"a..b\"."));
				}
				searchPattern = searchPattern.Substring(num + 2);
			}
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x0016B4FE File Offset: 0x001696FE
		internal static void CheckInvalidPathChars(string path, bool checkAdditional = false)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (PathInternal.HasIllegalCharacters(path, checkAdditional))
			{
				throw new ArgumentException(Environment.GetResourceString("Illegal characters in path."));
			}
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x0016B528 File Offset: 0x00169728
		internal static string InternalCombine(string path1, string path2)
		{
			if (path1 == null || path2 == null)
			{
				throw new ArgumentNullException((path1 == null) ? "path1" : "path2");
			}
			Path.CheckInvalidPathChars(path1, false);
			Path.CheckInvalidPathChars(path2, false);
			if (path2.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Path cannot be the empty string or all whitespace."), "path2");
			}
			if (Path.IsPathRooted(path2))
			{
				throw new ArgumentException(Environment.GetResourceString("Second path fragment must not be a drive or UNC name."), "path2");
			}
			int length = path1.Length;
			if (length == 0)
			{
				return path2;
			}
			char c = path1[length - 1];
			if (c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar && c != Path.VolumeSeparatorChar)
			{
				return path1 + Path.DirectorySeparatorCharAsString + path2;
			}
			return path1 + path2;
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x0016B5DC File Offset: 0x001697DC
		public unsafe static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path)
		{
			int length = Path.GetPathRoot(new string(path)).Length;
			int num = path.Length;
			while (--num >= 0)
			{
				if (num < length || Path.IsDirectorySeparator((char)(*path[num])))
				{
					return path.Slice(num + 1, path.Length - num - 1);
				}
			}
			return path;
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x0016B637 File Offset: 0x00169837
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
		{
			if (path1.Length == 0)
			{
				return new string(path2);
			}
			if (path2.Length == 0)
			{
				return new string(path1);
			}
			return Path.JoinInternal(path1, path2);
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x0016B660 File Offset: 0x00169860
		public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
		{
			if (path1.Length == 0)
			{
				return Path.Join(path2, path3);
			}
			if (path2.Length == 0)
			{
				return Path.Join(path1, path3);
			}
			if (path3.Length == 0)
			{
				return Path.Join(path1, path2);
			}
			return Path.JoinInternal(path1, path2, path3);
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x0016B6A0 File Offset: 0x001698A0
		public unsafe static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten)
		{
			charsWritten = 0;
			if (path1.Length == 0 && path2.Length == 0)
			{
				return true;
			}
			if (path1.Length == 0 || path2.Length == 0)
			{
				ref ReadOnlySpan<char> ptr = ref (path1.Length == 0) ? ref path2 : ref path1;
				if (destination.Length < ptr.Length)
				{
					return false;
				}
				ptr.CopyTo(destination);
				charsWritten = ptr.Length;
				return true;
			}
			else
			{
				bool flag = !PathInternal.EndsInDirectorySeparator(path1) && !PathInternal.StartsWithDirectorySeparator(path2);
				int num = path1.Length + path2.Length + (flag ? 1 : 0);
				if (destination.Length < num)
				{
					return false;
				}
				path1.CopyTo(destination);
				if (flag)
				{
					*destination[path1.Length] = Path.DirectorySeparatorChar;
				}
				path2.CopyTo(destination.Slice(path1.Length + (flag ? 1 : 0)));
				charsWritten = num;
				return true;
			}
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x0016B784 File Offset: 0x00169984
		public unsafe static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten)
		{
			charsWritten = 0;
			if (path1.Length == 0 && path2.Length == 0 && path3.Length == 0)
			{
				return true;
			}
			if (path1.Length == 0)
			{
				return Path.TryJoin(path2, path3, destination, out charsWritten);
			}
			if (path2.Length == 0)
			{
				return Path.TryJoin(path1, path3, destination, out charsWritten);
			}
			if (path3.Length == 0)
			{
				return Path.TryJoin(path1, path2, destination, out charsWritten);
			}
			int num = (PathInternal.EndsInDirectorySeparator(path1) || PathInternal.StartsWithDirectorySeparator(path2)) ? 0 : 1;
			bool flag = !PathInternal.EndsInDirectorySeparator(path2) && !PathInternal.StartsWithDirectorySeparator(path3);
			if (flag)
			{
				num++;
			}
			int num2 = path1.Length + path2.Length + path3.Length + num;
			if (destination.Length < num2)
			{
				return false;
			}
			Path.TryJoin(path1, path2, destination, out charsWritten);
			if (flag)
			{
				int num3 = charsWritten;
				charsWritten = num3 + 1;
				*destination[num3] = Path.DirectorySeparatorChar;
			}
			path3.CopyTo(destination.Slice(charsWritten));
			charsWritten += path3.Length;
			return true;
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x0016B88C File Offset: 0x00169A8C
		private unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second)
		{
			bool flag = PathInternal.IsDirectorySeparator((char)(*first[first.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*second[0]));
			fixed (char* reference = MemoryMarshal.GetReference<char>(first))
			{
				char* value = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(second))
				{
					char* value2 = reference2;
					return string.Create<ValueTuple<IntPtr, int, IntPtr, int, bool>>(first.Length + second.Length + (flag ? 0 : 1), new ValueTuple<IntPtr, int, IntPtr, int, bool>((IntPtr)((void*)value), first.Length, (IntPtr)((void*)value2), second.Length, flag), delegate(Span<char> destination, [TupleElementNames(new string[]
					{
						"First",
						"FirstLength",
						"Second",
						"SecondLength",
						"HasSeparator"
					})] ValueTuple<IntPtr, int, IntPtr, int, bool> state)
					{
						Span<char> span = new Span<char>((void*)state.Item1, state.Item2);
						span.CopyTo(destination);
						if (!state.Item5)
						{
							*destination[state.Item2] = '\\';
						}
						span = new Span<char>((void*)state.Item3, state.Item4);
						span.CopyTo(destination.Slice(state.Item2 + (state.Item5 ? 0 : 1)));
					});
				}
			}
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x0016B934 File Offset: 0x00169B34
		private unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third)
		{
			bool flag = PathInternal.IsDirectorySeparator((char)(*first[first.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*second[0]));
			bool flag2 = PathInternal.IsDirectorySeparator((char)(*second[second.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*third[0]));
			fixed (char* reference = MemoryMarshal.GetReference<char>(first))
			{
				char* value = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(second))
				{
					char* value2 = reference2;
					fixed (char* reference3 = MemoryMarshal.GetReference<char>(third))
					{
						char* value3 = reference3;
						return string.Create<ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>(first.Length + second.Length + third.Length + (flag ? 0 : 1) + (flag2 ? 0 : 1), new ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>((IntPtr)((void*)value), first.Length, (IntPtr)((void*)value2), second.Length, (IntPtr)((void*)value3), third.Length, flag, new ValueTuple<bool>(flag2)), delegate(Span<char> destination, [TupleElementNames(new string[]
						{
							"First",
							"FirstLength",
							"Second",
							"SecondLength",
							"Third",
							"ThirdLength",
							"FirstHasSeparator",
							"ThirdHasSeparator",
							null
						})] ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>> state)
						{
							Span<char> span = new Span<char>((void*)state.Item1, state.Item2);
							span.CopyTo(destination);
							if (!state.Item7)
							{
								*destination[state.Item2] = '\\';
							}
							span = new Span<char>((void*)state.Item3, state.Item4);
							span.CopyTo(destination.Slice(state.Item2 + (state.Item7 ? 0 : 1)));
							if (!state.Rest.Item1)
							{
								*destination[destination.Length - state.Item6 - 1] = '\\';
							}
							span = new Span<char>((void*)state.Item5, state.Item6);
							span.CopyTo(destination.Slice(destination.Length - state.Item6));
						});
					}
				}
			}
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x0016BA3C File Offset: 0x00169C3C
		private unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third, ReadOnlySpan<char> fourth)
		{
			bool flag = PathInternal.IsDirectorySeparator((char)(*first[first.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*second[0]));
			bool flag2 = PathInternal.IsDirectorySeparator((char)(*second[second.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*third[0]));
			bool flag3 = PathInternal.IsDirectorySeparator((char)(*third[third.Length - 1])) || PathInternal.IsDirectorySeparator((char)(*fourth[0]));
			fixed (char* reference = MemoryMarshal.GetReference<char>(first))
			{
				char* value = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(second))
				{
					char* value2 = reference2;
					fixed (char* reference3 = MemoryMarshal.GetReference<char>(third))
					{
						char* value3 = reference3;
						fixed (char* reference4 = MemoryMarshal.GetReference<char>(fourth))
						{
							char* value4 = reference4;
							return string.Create<ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, IntPtr, ValueTuple<int, bool, bool, bool>>>(first.Length + second.Length + third.Length + fourth.Length + (flag ? 0 : 1) + (flag2 ? 0 : 1) + (flag3 ? 0 : 1), new ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, IntPtr, ValueTuple<int, bool, bool, bool>>((IntPtr)((void*)value), first.Length, (IntPtr)((void*)value2), second.Length, (IntPtr)((void*)value3), third.Length, (IntPtr)((void*)value4), new ValueTuple<int, bool, bool, bool>(fourth.Length, flag, flag2, flag3)), delegate(Span<char> destination, [TupleElementNames(new string[]
							{
								"First",
								"FirstLength",
								"Second",
								"SecondLength",
								"Third",
								"ThirdLength",
								"Fourth",
								"FourthLength",
								"FirstHasSeparator",
								"ThirdHasSeparator",
								"FourthHasSeparator",
								null,
								null,
								null,
								null
							})] ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, IntPtr, ValueTuple<int, bool, bool, bool>> state)
							{
								Span<char> span = new Span<char>((void*)state.Item1, state.Item2);
								span.CopyTo(destination);
								if (!state.Rest.Item2)
								{
									*destination[state.Item2] = '\\';
								}
								span = new Span<char>((void*)state.Item3, state.Item4);
								span.CopyTo(destination.Slice(state.Item2 + (state.Rest.Item2 ? 0 : 1)));
								if (!state.Rest.Item3)
								{
									*destination[state.Item2 + state.Item4 + (state.Rest.Item2 ? 0 : 1)] = '\\';
								}
								span = new Span<char>((void*)state.Item5, state.Item6);
								span.CopyTo(destination.Slice(state.Item2 + state.Item4 + (state.Rest.Item2 ? 0 : 1) + (state.Rest.Item3 ? 0 : 1)));
								if (!state.Rest.Item4)
								{
									*destination[destination.Length - state.Rest.Item1 - 1] = '\\';
								}
								span = new Span<char>((void*)state.Item7, state.Rest.Item1);
								span.CopyTo(destination.Slice(destination.Length - state.Rest.Item1));
							});
						}
					}
				}
			}
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x0016BB99 File Offset: 0x00169D99
		public static ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path)
		{
			return Path.GetExtension(path.ToString()).AsSpan();
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x0016BBB2 File Offset: 0x00169DB2
		public static ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path)
		{
			return Path.GetFileNameWithoutExtension(path.ToString()).AsSpan();
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x0016BBCB File Offset: 0x00169DCB
		public static ReadOnlySpan<char> GetPathRoot(ReadOnlySpan<char> path)
		{
			return Path.GetPathRoot(path.ToString()).AsSpan();
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x0016BBE4 File Offset: 0x00169DE4
		public static bool HasExtension(ReadOnlySpan<char> path)
		{
			return Path.HasExtension(path.ToString());
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x0016BBF8 File Offset: 0x00169DF8
		public static string GetRelativePath(string relativeTo, string path)
		{
			return Path.GetRelativePath(relativeTo, path, Path.StringComparison);
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x0016BC08 File Offset: 0x00169E08
		private static string GetRelativePath(string relativeTo, string path, StringComparison comparisonType)
		{
			if (string.IsNullOrEmpty(relativeTo))
			{
				throw new ArgumentNullException("relativeTo");
			}
			if (PathInternal.IsEffectivelyEmpty(path.AsSpan()))
			{
				throw new ArgumentNullException("path");
			}
			relativeTo = Path.GetFullPath(relativeTo);
			path = Path.GetFullPath(path);
			if (!PathInternal.AreRootsEqual(relativeTo, path, comparisonType))
			{
				return path;
			}
			int num = PathInternal.GetCommonPathLength(relativeTo, path, comparisonType == StringComparison.OrdinalIgnoreCase);
			if (num == 0)
			{
				return path;
			}
			int num2 = relativeTo.Length;
			if (PathInternal.EndsInDirectorySeparator(relativeTo.AsSpan()))
			{
				num2--;
			}
			bool flag = PathInternal.EndsInDirectorySeparator(path.AsSpan());
			int num3 = path.Length;
			if (flag)
			{
				num3--;
			}
			if (num2 == num3 && num >= num2)
			{
				return ".";
			}
			StringBuilder stringBuilder = StringBuilderCache.Acquire(Math.Max(relativeTo.Length, path.Length));
			if (num < num2)
			{
				stringBuilder.Append("..");
				for (int i = num + 1; i < num2; i++)
				{
					if (PathInternal.IsDirectorySeparator(relativeTo[i]))
					{
						stringBuilder.Append(Path.DirectorySeparatorChar);
						stringBuilder.Append("..");
					}
				}
			}
			else if (PathInternal.IsDirectorySeparator(path[num]))
			{
				num++;
			}
			int num4 = num3 - num;
			if (flag)
			{
				num4++;
			}
			if (num4 > 0)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(Path.DirectorySeparatorChar);
				}
				stringBuilder.Append(path, num, num4);
			}
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06006A4B RID: 27211 RVA: 0x0016BD62 File Offset: 0x00169F62
		internal static StringComparison StringComparison
		{
			get
			{
				if (!Path.IsCaseSensitive)
				{
					return StringComparison.OrdinalIgnoreCase;
				}
				return StringComparison.Ordinal;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06006A4C RID: 27212 RVA: 0x0016BD6E File Offset: 0x00169F6E
		internal static bool IsCaseSensitive
		{
			get
			{
				return !Path.IsWindows;
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06006A4D RID: 27213 RVA: 0x0016BD78 File Offset: 0x00169F78
		private static bool IsWindows
		{
			get
			{
				PlatformID platform = Environment.OSVersion.Platform;
				return platform == PlatformID.Win32S || platform == PlatformID.Win32Windows || platform == PlatformID.Win32NT || platform == PlatformID.WinCE;
			}
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x0016BDA2 File Offset: 0x00169FA2
		public static bool IsPathFullyQualified(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			return Path.IsPathFullyQualified(path.AsSpan());
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x0016BDBD File Offset: 0x00169FBD
		public static bool IsPathFullyQualified(ReadOnlySpan<char> path)
		{
			return !PathInternal.IsPartiallyQualified(path);
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x0016BDC8 File Offset: 0x00169FC8
		public static string GetFullPath(string path, string basePath)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (basePath == null)
			{
				throw new ArgumentNullException("basePath");
			}
			if (!Path.IsPathFullyQualified(basePath))
			{
				throw new ArgumentException("Basepath argument is not fully qualified.", "basePath");
			}
			if (basePath.Contains('\0') || path.Contains('\0'))
			{
				throw new ArgumentException("Illegal characters in path '{0}'.");
			}
			if (Path.IsPathFullyQualified(path))
			{
				return Path.GetFullPath(path);
			}
			return Path.GetFullPath(Path.CombineInternal(basePath, path));
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x0016BE41 File Offset: 0x0016A041
		private static string CombineInternal(string first, string second)
		{
			if (string.IsNullOrEmpty(first))
			{
				return second;
			}
			if (string.IsNullOrEmpty(second))
			{
				return first;
			}
			if (Path.IsPathRooted(second.AsSpan()))
			{
				return second;
			}
			return Path.JoinInternal(first.AsSpan(), second.AsSpan());
		}

		/// <summary>Предоставляет массив символов, задаваемых платформой, которые не могут быть указаны в аргументах строки пути, передаваемых в элементы класса <see cref="T:System.IO.Path" />.</summary>
		// Token: 0x04003D79 RID: 15737
		[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
		public static readonly char[] InvalidPathChars;

		/// <summary>Предоставляет дополнительный символ, задаваемый платформой, для разделения уровней каталогов в строке пути, в которой отражена иерархическая организация файловой системы.</summary>
		// Token: 0x04003D7A RID: 15738
		public static readonly char AltDirectorySeparatorChar;

		/// <summary>Предоставляет символ, задаваемый платформой, для разделения уровней папок в строке пути, в которой отражена иерархическая организация файловой системы.</summary>
		// Token: 0x04003D7B RID: 15739
		public static readonly char DirectorySeparatorChar;

		/// <summary>Разделитель, задаваемый платформой, который используется в переменных среды для разделения строк пути.</summary>
		// Token: 0x04003D7C RID: 15740
		public static readonly char PathSeparator;

		// Token: 0x04003D7D RID: 15741
		internal static readonly string DirectorySeparatorStr;

		/// <summary>Предоставляет разделитель томов, задаваемый платформой.</summary>
		// Token: 0x04003D7E RID: 15742
		public static readonly char VolumeSeparatorChar;

		// Token: 0x04003D7F RID: 15743
		internal static readonly char[] PathSeparatorChars;

		// Token: 0x04003D80 RID: 15744
		private static readonly bool dirEqualsVolume;

		// Token: 0x04003D81 RID: 15745
		internal const int MAX_PATH = 260;

		// Token: 0x04003D82 RID: 15746
		internal static readonly char[] trimEndCharsWindows = new char[]
		{
			'\t',
			'\n',
			'\v',
			'\f',
			'\r',
			' ',
			'\u0085',
			'\u00a0'
		};

		// Token: 0x04003D83 RID: 15747
		internal static readonly char[] trimEndCharsUnix = new char[0];
	}
}
