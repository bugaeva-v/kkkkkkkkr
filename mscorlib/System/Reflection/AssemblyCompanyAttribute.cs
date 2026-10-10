using System;

namespace System.Reflection
{
	/// <summary>Определяет настраиваемый атрибут имени организации для манифеста сборки.</summary>
	// Token: 0x0200087E RID: 2174
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCompanyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyCompanyAttribute" />.</summary>
		/// <param name="company">Сведения об имени компании.</param>
		// Token: 0x06004851 RID: 18513 RVA: 0x000EE004 File Offset: 0x000EC204
		public AssemblyCompanyAttribute(string company)
		{
			this.Company = company;
		}

		/// <summary>Возвращает сведения об имени компании.</summary>
		/// <returns>Строка, содержащая имя компании.</returns>
		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x000EE013 File Offset: 0x000EC213
		public string Company { get; }
	}
}
