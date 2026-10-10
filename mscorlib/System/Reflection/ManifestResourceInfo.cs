using System;

namespace System.Reflection
{
	/// <summary>Предоставляет доступ к ресурсам манифеста, которые являются XML-файлами, описывающими зависимости приложения.</summary>
	// Token: 0x020008A8 RID: 2216
	public class ManifestResourceInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.ManifestResourceInfo" /> для ресурса, содержащегося в заданной сборке и файле и расположенного в указанном месте.</summary>
		/// <param name="containingAssembly">Сборка, содержащая ресурс манифеста.</param>
		/// <param name="containingFileName">Имя файла, содержащего ресурс манифеста, если этот файл отличается от файла манифеста.</param>
		/// <param name="resourceLocation">Битовая комбинация значений перечисления, предоставляющего сведения о расположении ресурса манифеста.</param>
		// Token: 0x06004908 RID: 18696 RVA: 0x000EE930 File Offset: 0x000ECB30
		public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
		{
			this.ReferencedAssembly = containingAssembly;
			this.FileName = containingFileName;
			this.ResourceLocation = resourceLocation;
		}

		/// <summary>Получает для ресурса манифеста содержащую его сборку.</summary>
		/// <returns>Сборка, содержащая ресурс манифеста.</returns>
		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x000EE94D File Offset: 0x000ECB4D
		public virtual Assembly ReferencedAssembly { get; }

		/// <summary>Получает имя файла, содержащего ресурс манифеста, если этот файл отличается от файла манифеста.</summary>
		/// <returns>Имя файла ресурса манифеста.</returns>
		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x000EE955 File Offset: 0x000ECB55
		public virtual string FileName { get; }

		/// <summary>Получает расположение ресурса манифеста.</summary>
		/// <returns>Побитовая комбинация флагов <see cref="T:System.Reflection.ResourceLocation" />, указывающих расположение ресурса манифеста.</returns>
		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x000EE95D File Offset: 0x000ECB5D
		public virtual ResourceLocation ResourceLocation { get; }
	}
}
