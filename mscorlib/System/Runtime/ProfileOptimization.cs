using System;
using System.Security;

namespace System.Runtime
{
	/// <summary>Улучшает производительность при запуске доменов приложения в приложениях, требующих JIT-компилятора путем фоновой компиляции методов, выполнение которых ожидается, на основе профилей, созданных во время предыдущих компиляций.</summary>
	// Token: 0x0200054F RID: 1359
	public static class ProfileOptimization
	{
		// Token: 0x060035AF RID: 13743 RVA: 0x00004BF9 File Offset: 0x00002DF9
		internal static void InternalSetProfileRoot(string directoryPath)
		{
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00004BF9 File Offset: 0x00002DF9
		internal static void InternalStartProfile(string profile, IntPtr ptrNativeAssemblyLoadContext)
		{
		}

		/// <summary>Включает профилирование оптимизации для текущего домена приложения и задает каталог, в котором хранятся файлы профиля оптимизации. На одноядерном компьютере этот метод игнорируется.</summary>
		/// <param name="directoryPath">Полный путь к папке, где хранятся файлы профиля для текущего домена приложения.</param>
		// Token: 0x060035B1 RID: 13745 RVA: 0x000C1FE4 File Offset: 0x000C01E4
		[SecurityCritical]
		public static void SetProfileRoot(string directoryPath)
		{
			ProfileOptimization.InternalSetProfileRoot(directoryPath);
		}

		/// <summary>Запускает JIT-компиляцию методов, которые ранее были записаны в указанном файле профиля, в фоновом потоке. Запускает процесс записи текущего использования методов, который позже перезаписывает указанный файл профиля.</summary>
		/// <param name="profile">Имя файла профиля для использования.</param>
		// Token: 0x060035B2 RID: 13746 RVA: 0x000C1FEC File Offset: 0x000C01EC
		[SecurityCritical]
		public static void StartProfile(string profile)
		{
			ProfileOptimization.InternalStartProfile(profile, IntPtr.Zero);
		}
	}
}
