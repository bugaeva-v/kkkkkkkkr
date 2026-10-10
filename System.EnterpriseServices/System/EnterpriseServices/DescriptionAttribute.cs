using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Задает описание для сборки (приложения), компонента, метода или интерфейса. Этот класс не наследуется.</summary>
	// Token: 0x0200001A RID: 26
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Interface)]
	public sealed class DescriptionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.DescriptionAttribute" />.</summary>
		/// <param name="desc">Описание сборки (приложения), компонента, метода или интерфейса.</param>
		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		public DescriptionAttribute(string desc)
		{
		}
	}
}
