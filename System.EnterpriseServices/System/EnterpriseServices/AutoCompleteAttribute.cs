using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Помечает метод с атрибутами как объект <see langword="AutoComplete" />. Этот класс не наследуется.</summary>
	// Token: 0x02000012 RID: 18
	[AttributeUsage(AttributeTargets.Method)]
	[ComVisible(false)]
	public sealed class AutoCompleteAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.AutoCompleteAttribute" />, устанавливая, что приложение должно автоматически вызывать объект <see cref="M:System.EnterpriseServices.ContextUtil.SetComplete" /> при успешном завершении транзакции.</summary>
		// Token: 0x06000035 RID: 53 RVA: 0x000021BA File Offset: 0x000003BA
		public AutoCompleteAttribute()
		{
			this.val = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.AutoCompleteAttribute" />, указывая, включен ли параметр <see langword="AutoComplete" /> COM+.</summary>
		/// <param name="val">Значение <see langword="true" />, чтобы активировать <see langword="AutoComplete" /> в объекте COM+; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000036 RID: 54 RVA: 0x000021C9 File Offset: 0x000003C9
		public AutoCompleteAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Получает значение, определяющее значение параметра <see langword="AutoComplete" /> в COM+.</summary>
		/// <returns>Значение <see langword="true" />, если параметр  <see langword="AutoComplete" /> включен в COM+; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000021D8 File Offset: 0x000003D8
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x04000045 RID: 69
		private bool val;
	}
}
