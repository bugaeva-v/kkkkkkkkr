using System;

namespace System.Runtime.Versioning
{
	/// <summary>Определяет версию платформы .NET Framework, для которой была скомпилирована соответствующая сборка.</summary>
	// Token: 0x0200063B RID: 1595
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class TargetFrameworkAttribute : Attribute
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.Runtime.Versioning.TargetFrameworkAttribute" />, указывая версию платформы .NET Framework, относительно которой скомпилирована определенная сборка.</summary>
		/// <param name="frameworkName">Версия платформы .NET Framework, относительно которой построена сборка.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="frameworkName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C22 RID: 15394 RVA: 0x000D10A4 File Offset: 0x000CF2A4
		public TargetFrameworkAttribute(string frameworkName)
		{
			if (frameworkName == null)
			{
				throw new ArgumentNullException("frameworkName");
			}
			this._frameworkName = frameworkName;
		}

		/// <summary>Получает отображаемое имя версии платформы .NET Framework, относительно которой скомпилирована определенная сборка.</summary>
		/// <returns>Имя версии платформы .NET Framework, с помощью которой скомпилирована сборка.</returns>
		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x000D10C1 File Offset: 0x000CF2C1
		public string FrameworkName
		{
			get
			{
				return this._frameworkName;
			}
		}

		/// <summary>Получает отображаемое имя версии платформы .NET Framework, относительно которой построена сборка.</summary>
		/// <returns>Отображаемое имя версии платформы .NET Framework.</returns>
		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x000D10C9 File Offset: 0x000CF2C9
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x000D10D1 File Offset: 0x000CF2D1
		public string FrameworkDisplayName
		{
			get
			{
				return this._frameworkDisplayName;
			}
			set
			{
				this._frameworkDisplayName = value;
			}
		}

		// Token: 0x040026EE RID: 9966
		private string _frameworkName;

		// Token: 0x040026EF RID: 9967
		private string _frameworkDisplayName;
	}
}
