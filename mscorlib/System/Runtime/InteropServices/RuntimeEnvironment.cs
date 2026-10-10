using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет коллекцию статических (<see langword="static" />) методов, возвращающих сведения о среде CLR.</summary>
	// Token: 0x0200071C RID: 1820
	[ComVisible(true)]
	public class RuntimeEnvironment
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.RuntimeEnvironment" />.</summary>
		// Token: 0x060040E4 RID: 16612 RVA: 0x0000259F File Offset: 0x0000079F
		[Obsolete("Do not create instances of the RuntimeEnvironment class.  Call the static methods directly on this type instead", true)]
		public RuntimeEnvironment()
		{
		}

		/// <summary>Проверяет, загружена ли указанная сборка в глобальный кэш сборок.</summary>
		/// <param name="a">Проверяемая сборка.</param>
		/// <returns>Значение <see langword="true" />, если сборка загружена в глобальный кэш сборок, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060040E5 RID: 16613 RVA: 0x000E174B File Offset: 0x000DF94B
		public static bool FromGlobalAccessCache(Assembly a)
		{
			return a.GlobalAssemblyCache;
		}

		/// <summary>Возвращает номер версии среды CLR, выполняющей текущий процесс.</summary>
		/// <returns>Строка, содержащая номер версии среды CLR.</returns>
		// Token: 0x060040E6 RID: 16614 RVA: 0x000E1753 File Offset: 0x000DF953
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSystemVersion()
		{
			return Assembly.GetExecutingAssembly().ImageRuntimeVersion;
		}

		/// <summary>Возвращает каталог, в котором установлена среда CLR.</summary>
		/// <returns>Строка, содержащая путь к каталогу, в котором установлена среда CLR.</returns>
		// Token: 0x060040E7 RID: 16615 RVA: 0x000E175F File Offset: 0x000DF95F
		[SecuritySafeCritical]
		public static string GetRuntimeDirectory()
		{
			if (Environment.GetEnvironmentVariable("CSC_SDK_PATH_DISABLED") != null)
			{
				return null;
			}
			return RuntimeEnvironment.GetRuntimeDirectoryImpl();
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x000E1774 File Offset: 0x000DF974
		private static string GetRuntimeDirectoryImpl()
		{
			return Path.GetDirectoryName(typeof(object).Assembly.Location);
		}

		/// <summary>Возвращает путь к файлу конфигурации системы.</summary>
		/// <returns>Путь к файлу конфигурации системы.</returns>
		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x000E178F File Offset: 0x000DF98F
		public static string SystemConfigurationFile
		{
			[SecuritySafeCritical]
			get
			{
				return Environment.GetMachineConfigPath();
			}
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x000472C8 File Offset: 0x000454C8
		private static IntPtr GetRuntimeInterfaceImpl(Guid clsid, Guid riid)
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает указанный интерфейс для указанного класса.</summary>
		/// <param name="clsid">Идентификатор требуемого класса.</param>
		/// <param name="riid">Идентификатор требуемого интерфейса.</param>
		/// <returns>Неуправляемый указатель на запрашиваемый интерфейс.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Сбой IUnknown::QueryInterface.</exception>
		// Token: 0x060040EB RID: 16619 RVA: 0x000E1796 File Offset: 0x000DF996
		[ComVisible(false)]
		[SecurityCritical]
		public static IntPtr GetRuntimeInterfaceAsIntPtr(Guid clsid, Guid riid)
		{
			return RuntimeEnvironment.GetRuntimeInterfaceImpl(clsid, riid);
		}

		/// <summary>Возвращает экземпляр типа, представляющий COM-объект при помощи указателя на его интерфейс <see langword="IUnknown" />.</summary>
		/// <param name="clsid">Идентификатор требуемого класса.</param>
		/// <param name="riid">Идентификатор требуемого интерфейса.</param>
		/// <returns>Объект, представляющий указанный неуправляемый COM-объект.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Сбой IUnknown::QueryInterface.</exception>
		// Token: 0x060040EC RID: 16620 RVA: 0x000E17A0 File Offset: 0x000DF9A0
		[ComVisible(false)]
		[SecurityCritical]
		public static object GetRuntimeInterfaceAsObject(Guid clsid, Guid riid)
		{
			IntPtr intPtr = IntPtr.Zero;
			object objectForIUnknown;
			try
			{
				intPtr = RuntimeEnvironment.GetRuntimeInterfaceImpl(clsid, riid);
				objectForIUnknown = Marshal.GetObjectForIUnknown(intPtr);
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.Release(intPtr);
				}
			}
			return objectForIUnknown;
		}
	}
}
