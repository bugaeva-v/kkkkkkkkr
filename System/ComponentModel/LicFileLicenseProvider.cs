using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;

namespace System.ComponentModel
{
	/// <summary>Обеспечивает реализацию поставщика <see cref="T:System.ComponentModel.LicenseProvider" />. Этот поставщик работает таким же образом, как и стандартный модуль лицензирования Microsoft .NET Framework.</summary>
	// Token: 0x020003C4 RID: 964
	public class LicFileLicenseProvider : LicenseProvider
	{
		/// <summary>Определяет, является ли для указанного типа действительным ключ, возвращаемый методом <see cref="M:System.ComponentModel.LicFileLicenseProvider.GetLicense(System.ComponentModel.LicenseContext,System.Type,System.Object,System.Boolean)" />.</summary>
		/// <param name="key">Проверяемый элемент <see cref="P:System.ComponentModel.License.LicenseKey" />.</param>
		/// <param name="type">Объект <see cref="T:System.Type" />, представляющий компонент, запрашивающий лицензию <see cref="T:System.ComponentModel.License" />.</param>
		/// <returns>Значение <see langword="true" />, если ключ является действительным ключом лицензии <see cref="P:System.ComponentModel.License.LicenseKey" /> для заданного типа; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F3F RID: 7999 RVA: 0x0006CDFE File Offset: 0x0006AFFE
		protected virtual bool IsKeyValid(string key, Type type)
		{
			return key != null && key.StartsWith(this.GetKey(type));
		}

		/// <summary>Возвращает ключ для указанного типа.</summary>
		/// <param name="type">Тип объекта для возвращения ключа.</param>
		/// <returns>Подтверждение лицензирования для параметра <paramref name="type" />.</returns>
		// Token: 0x06001F40 RID: 8000 RVA: 0x0006CE12 File Offset: 0x0006B012
		protected virtual string GetKey(Type type)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0} is a licensed component.", type.FullName);
		}

		/// <summary>Возвращает лицензию для экземпляра компонента, если она доступна.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.LicenseContext" />, определяющий, где можно использовать лицензированный объект.</param>
		/// <param name="type">Объект <see cref="T:System.Type" />, представляющий компонент, запрашивающий лицензию <see cref="T:System.ComponentModel.License" />.</param>
		/// <param name="instance">Объект, запрашивающий лицензию <see cref="T:System.ComponentModel.License" />.</param>
		/// <param name="allowExceptions">Значение <see langword="true" />, если исключение <see cref="T:System.ComponentModel.LicenseException" /> должно вызываться, когда компоненту не может быть предоставлена лицензия; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Допустимый класс <see cref="T:System.ComponentModel.License" />. Если этот метод не может найти действительную лицензию <see cref="T:System.ComponentModel.License" /> или действительный параметр <paramref name="context" />, возвращается значение <see langword="null" />.</returns>
		// Token: 0x06001F41 RID: 8001 RVA: 0x0006CE2C File Offset: 0x0006B02C
		public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
		{
			LicFileLicenseProvider.LicFileLicense licFileLicense = null;
			if (context != null)
			{
				if (context.UsageMode == LicenseUsageMode.Runtime)
				{
					string savedLicenseKey = context.GetSavedLicenseKey(type, null);
					if (savedLicenseKey != null && this.IsKeyValid(savedLicenseKey, type))
					{
						licFileLicense = new LicFileLicenseProvider.LicFileLicense(this, savedLicenseKey);
					}
				}
				if (licFileLicense == null)
				{
					string text = null;
					if (context != null)
					{
						ITypeResolutionService typeResolutionService = (ITypeResolutionService)context.GetService(typeof(ITypeResolutionService));
						if (typeResolutionService != null)
						{
							text = typeResolutionService.GetPathOfAssembly(type.Assembly.GetName());
						}
					}
					if (text == null)
					{
						text = type.Module.FullyQualifiedName;
					}
					string path = Path.GetDirectoryName(text) + "\\" + type.FullName + ".lic";
					if (File.Exists(path))
					{
						StreamReader streamReader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read));
						string key = streamReader.ReadLine();
						streamReader.Close();
						if (this.IsKeyValid(key, type))
						{
							licFileLicense = new LicFileLicenseProvider.LicFileLicense(this, this.GetKey(type));
						}
					}
					if (licFileLicense != null)
					{
						context.SetSavedLicenseKey(type, licFileLicense.LicenseKey);
					}
				}
			}
			return licFileLicense;
		}

		// Token: 0x020003C5 RID: 965
		private class LicFileLicense : License
		{
			// Token: 0x06001F43 RID: 8003 RVA: 0x0006CF20 File Offset: 0x0006B120
			public LicFileLicense(LicFileLicenseProvider owner, string key)
			{
				this._owner = owner;
				this.LicenseKey = key;
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x06001F44 RID: 8004 RVA: 0x0006CF36 File Offset: 0x0006B136
			public override string LicenseKey { get; }

			// Token: 0x06001F45 RID: 8005 RVA: 0x0006CF3E File Offset: 0x0006B13E
			public override void Dispose()
			{
				GC.SuppressFinalize(this);
			}

			// Token: 0x04000F4B RID: 3915
			private LicFileLicenseProvider _owner;
		}
	}
}
