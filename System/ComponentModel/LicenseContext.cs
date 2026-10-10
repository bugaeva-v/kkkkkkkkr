using System;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Определяет, когда можно использовать лицензированный объект, и предоставляет способ получения дополнительных служб, необходимых для поддержки лицензий, выполняемых в границах своего домена.</summary>
	// Token: 0x020003C7 RID: 967
	public class LicenseContext : IServiceProvider
	{
		/// <summary>При переопределении в производном классе возвращает значение, определяющее, когда можно использовать лицензию.</summary>
		/// <returns>Одно из значений объекта <see cref="T:System.ComponentModel.LicenseUsageMode" />, определяющее, когда можно использовать лицензию. Значение по умолчанию — <see cref="F:System.ComponentModel.LicenseUsageMode.Runtime" />.</returns>
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00003062 File Offset: 0x00001262
		public virtual LicenseUsageMode UsageMode
		{
			get
			{
				return LicenseUsageMode.Runtime;
			}
		}

		/// <summary>При переопределении в производном классе возвращает из заданной сборки ресурсов сохраненный ключ лицензии для заданного типа.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, представляющий тип компонента.</param>
		/// <param name="resourceAssembly">Объект <see cref="T:System.Reflection.Assembly" /> с ключом лицензии.</param>
		/// <returns>Свойство <see cref="P:System.ComponentModel.License.LicenseKey" /> для указанного типа. Этот метод, если он не переопределен, возвращает значение <see langword="null" />.</returns>
		// Token: 0x06001F4A RID: 8010 RVA: 0x00002F6A File Offset: 0x0000116A
		public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			return null;
		}

		/// <summary>Возвращает запрашиваемую службу, если она доступна.</summary>
		/// <param name="type">Тип возвращаемой службы.</param>
		/// <returns>Экземпляр службы или значение <see langword="null" />, если службу не удается обнаружить.</returns>
		// Token: 0x06001F4B RID: 8011 RVA: 0x00002F6A File Offset: 0x0000116A
		public virtual object GetService(Type type)
		{
			return null;
		}

		/// <summary>При переопределении в производном классе задает ключ лицензии для указанного типа.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, представляющий компонент, связанный с ключом лицензии.</param>
		/// <param name="key">Свойство <see cref="P:System.ComponentModel.License.LicenseKey" /> для сохранения типа компонента.</param>
		// Token: 0x06001F4C RID: 8012 RVA: 0x00003917 File Offset: 0x00001B17
		public virtual void SetSavedLicenseKey(Type type, string key)
		{
		}
	}
}
