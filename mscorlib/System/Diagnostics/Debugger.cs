using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Разрешает взаимодействие с отладчиком. Этот класс не наследуется.</summary>
	// Token: 0x020009C0 RID: 2496
	[ComVisible(true)]
	public sealed class Debugger
	{
		/// <summary>Получает значение, показывающее, присоединен ли отладчик к процессу.</summary>
		/// <returns>Значение <see langword="true" />, если отладчик присоединен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060059C9 RID: 22985 RVA: 0x001332B9 File Offset: 0x001314B9
		public static bool IsAttached
		{
			get
			{
				return Debugger.IsAttached_internal();
			}
		}

		// Token: 0x060059CA RID: 22986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsAttached_internal();

		/// <summary>Сообщает присоединенному отладчику точку останова.</summary>
		/// <exception cref="T:System.Security.SecurityException">Класс <see cref="T:System.Security.Permissions.UIPermission" /> не задан для переключения на отладчик.</exception>
		// Token: 0x060059CB RID: 22987 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public static void Break()
		{
		}

		/// <summary>Проверяет, включено ли ведение журнала для присоединенного отладчика.</summary>
		/// <returns>Значение <see langword="true" />, если отладчик присоединен и ведение журнала включено; в противном случае — значение <see langword="false" />. Присоединенным является управляемый отладчик, зарегистрированный в разделе реестра <see langword="DbgManagedDebugger" />. Дополнительные сведения об этом реестре см. в разделе Включение отладки с JIT-присоединением.</returns>
		// Token: 0x060059CC RID: 22988
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLogging();

		/// <summary>Присоединяет и запускает отладчик для процесса.</summary>
		/// <returns>Значение <see langword="true" />, если отладчик успешно запущен или уже присоединен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Класс <see cref="T:System.Security.Permissions.UIPermission" /> не запускает отладчик.</exception>
		// Token: 0x060059CD RID: 22989 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static bool Launch()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060059CE RID: 22990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Log_icall(int level, ref string category, ref string message);

		/// <summary>Посылает сообщение присоединенному отладчику.</summary>
		/// <param name="level">Описание важности сообщения.</param>
		/// <param name="category">Категория сообщения.</param>
		/// <param name="message">Отображаемое сообщение.</param>
		// Token: 0x060059CF RID: 22991 RVA: 0x001332C0 File Offset: 0x001314C0
		public static void Log(int level, string category, string message)
		{
			Debugger.Log_icall(level, ref category, ref message);
		}

		/// <summary>Уведомляет отладчик о том, что выполнение пойдет по пути, включающему зависимость между потоками.</summary>
		// Token: 0x060059D0 RID: 22992 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public static void NotifyOfCrossThreadDependency()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Debugger" />.</summary>
		// Token: 0x060059D1 RID: 22993 RVA: 0x0000259F File Offset: 0x0000079F
		[Obsolete("Call the static methods directly on this type", true)]
		public Debugger()
		{
		}

		/// <summary>Представляет категорию сообщения с константой по умолчанию.</summary>
		// Token: 0x0400378D RID: 14221
		public static readonly string DefaultCategory = "";
	}
}
