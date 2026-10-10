using System;
using System.Collections.Generic;

namespace System
{
	/// <summary>Предоставляет члены для задания и получения данных о контексте приложения.</summary>
	// Token: 0x020001E0 RID: 480
	public static class AppContext
	{
		/// <summary>Возвращает путь к базовому каталогу, в котором сопоставитель сборок производит поиск.</summary>
		/// <returns>Путь к базовому каталогу, в котором сопоставитель сборок производит поиск.</returns>
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00051781 File Offset: 0x0004F981
		public static string BaseDirectory
		{
			get
			{
				return ((string)AppDomain.CurrentDomain.GetData("APP_CONTEXT_BASE_DIRECTORY")) ?? AppDomain.CurrentDomain.BaseDirectory;
			}
		}

		/// <summary>Получает имя целевой версии платформы текущего приложения.</summary>
		/// <returns>Имя целевой версии платформы текущего приложения.</returns>
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x000517A5 File Offset: 0x0004F9A5
		public static string TargetFrameworkName
		{
			get
			{
				return AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
			}
		}

		/// <summary>Возвращает значение именованного элемента данных, назначенное текущему домену приложения.</summary>
		/// <param name="name">Имя элемента данных.</param>
		/// <returns>Значение <paramref name="name" />, если <paramref name="name" /> определяет именованное значение; в противном случае — <see langword="null" />.</returns>
		// Token: 0x060014AD RID: 5293 RVA: 0x000517B6 File Offset: 0x0004F9B6
		public static object GetData(string name)
		{
			return AppDomain.CurrentDomain.GetData(name);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x000517C4 File Offset: 0x0004F9C4
		private static void InitializeDefaultSwitchValues()
		{
			Dictionary<string, AppContext.SwitchValueState> obj = AppContext.s_switchMap;
			lock (obj)
			{
				if (!AppContext.s_defaultsInitialized)
				{
					AppContextDefaultValues.PopulateDefaultValues();
					AppContext.s_defaultsInitialized = true;
				}
			}
		}

		/// <summary>Предпринимает попытку получения значения переключателя.</summary>
		/// <param name="switchName">Имя переключателя.</param>
		/// <param name="isEnabled">При возвращении этого метода содержит значение для <paramref name="switchName" />, если <paramref name="switchName" /> найден, или <see langword="false" />, если <paramref name="switchName" /> не найден. Этот параметр передается неинициализированным.</param>
		/// <returns>
		///   <see langword="true" />, если для <paramref name="switchName" /> задано значение и аргумент <paramref name="isEnabled" /> содержит значение переключателя; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="switchName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="switchName" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x060014AF RID: 5295 RVA: 0x00051814 File Offset: 0x0004FA14
		public static bool TryGetSwitch(string switchName, out bool isEnabled)
		{
			if (switchName == null)
			{
				throw new ArgumentNullException("switchName");
			}
			if (switchName.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Empty name is not legal."), "switchName");
			}
			if (!AppContext.s_defaultsInitialized)
			{
				AppContext.InitializeDefaultSwitchValues();
			}
			isEnabled = false;
			Dictionary<string, AppContext.SwitchValueState> obj = AppContext.s_switchMap;
			lock (obj)
			{
				AppContext.SwitchValueState switchValueState;
				if (AppContext.s_switchMap.TryGetValue(switchName, out switchValueState))
				{
					if (switchValueState == AppContext.SwitchValueState.UnknownValue)
					{
						isEnabled = false;
						return false;
					}
					isEnabled = ((switchValueState & AppContext.SwitchValueState.HasTrueValue) == AppContext.SwitchValueState.HasTrueValue);
					if ((switchValueState & AppContext.SwitchValueState.HasLookedForOverride) == AppContext.SwitchValueState.HasLookedForOverride)
					{
						return true;
					}
					bool flag2;
					if (AppContextDefaultValues.TryGetSwitchOverride(switchName, out flag2))
					{
						isEnabled = flag2;
					}
					AppContext.s_switchMap[switchName] = ((isEnabled ? AppContext.SwitchValueState.HasTrueValue : AppContext.SwitchValueState.HasFalseValue) | AppContext.SwitchValueState.HasLookedForOverride);
					return true;
				}
				else
				{
					bool flag3;
					if (AppContextDefaultValues.TryGetSwitchOverride(switchName, out flag3))
					{
						isEnabled = flag3;
						AppContext.s_switchMap[switchName] = ((isEnabled ? AppContext.SwitchValueState.HasTrueValue : AppContext.SwitchValueState.HasFalseValue) | AppContext.SwitchValueState.HasLookedForOverride);
						return true;
					}
					AppContext.s_switchMap[switchName] = AppContext.SwitchValueState.UnknownValue;
				}
			}
			return false;
		}

		/// <summary>Задает значение переключателя.</summary>
		/// <param name="switchName">Имя переключателя.</param>
		/// <param name="isEnabled">Значение переключателя.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="switchName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="switchName" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x060014B0 RID: 5296 RVA: 0x00051918 File Offset: 0x0004FB18
		public static void SetSwitch(string switchName, bool isEnabled)
		{
			if (switchName == null)
			{
				throw new ArgumentNullException("switchName");
			}
			if (switchName.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Empty name is not legal."), "switchName");
			}
			if (!AppContext.s_defaultsInitialized)
			{
				AppContext.InitializeDefaultSwitchValues();
			}
			AppContext.SwitchValueState value = (isEnabled ? AppContext.SwitchValueState.HasTrueValue : AppContext.SwitchValueState.HasFalseValue) | AppContext.SwitchValueState.HasLookedForOverride;
			Dictionary<string, AppContext.SwitchValueState> obj = AppContext.s_switchMap;
			lock (obj)
			{
				AppContext.s_switchMap[switchName] = value;
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x000519A0 File Offset: 0x0004FBA0
		internal static void DefineSwitchDefault(string switchName, bool isEnabled)
		{
			AppContext.s_switchMap[switchName] = (isEnabled ? AppContext.SwitchValueState.HasTrueValue : AppContext.SwitchValueState.HasFalseValue);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x000519B4 File Offset: 0x0004FBB4
		internal static void DefineSwitchOverride(string switchName, bool isEnabled)
		{
			AppContext.s_switchMap[switchName] = ((isEnabled ? AppContext.SwitchValueState.HasTrueValue : AppContext.SwitchValueState.HasFalseValue) | AppContext.SwitchValueState.HasLookedForOverride);
		}

		// Token: 0x04001470 RID: 5232
		private static readonly Dictionary<string, AppContext.SwitchValueState> s_switchMap = new Dictionary<string, AppContext.SwitchValueState>();

		// Token: 0x04001471 RID: 5233
		private static volatile bool s_defaultsInitialized = false;

		// Token: 0x020001E1 RID: 481
		[Flags]
		private enum SwitchValueState
		{
			// Token: 0x04001473 RID: 5235
			HasFalseValue = 1,
			// Token: 0x04001474 RID: 5236
			HasTrueValue = 2,
			// Token: 0x04001475 RID: 5237
			HasLookedForOverride = 4,
			// Token: 0x04001476 RID: 5238
			UnknownValue = 8
		}
	}
}
