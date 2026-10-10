using System;

namespace System.ComponentModel
{
	/// <summary>Определяет тип объекта, подходящий для связывания с объектом <see cref="T:System.Web.UI.WebControls.ObjectDataSource" />. Этот класс не наследуется.</summary>
	// Token: 0x02000394 RID: 916
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DataObjectAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DataObjectAttribute" />.</summary>
		// Token: 0x06001E0D RID: 7693 RVA: 0x0006B4DE File Offset: 0x000696DE
		public DataObjectAttribute() : this(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DataObjectAttribute" /> и показывает, подходит ли объект для связывания с объектом <see cref="T:System.Web.UI.WebControls.ObjectDataSource" />.</summary>
		/// <param name="isDataObject">Значение <see langword="true" />, если объект подходит для связывания с объектом <see cref="T:System.Web.UI.WebControls.ObjectDataSource" />; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001E0E RID: 7694 RVA: 0x0006B4E7 File Offset: 0x000696E7
		public DataObjectAttribute(bool isDataObject)
		{
			this.IsDataObject = isDataObject;
		}

		/// <summary>Возвращает значение, показывающее, следует ли считать объект подходящим для связывания с объектом <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> во время разработки.</summary>
		/// <returns>Значение <see langword="true" />, если объект должен считаться подходящим для связывания с объектом <see cref="T:System.Web.UI.WebControls.ObjectDataSource" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0006B4F6 File Offset: 0x000696F6
		public bool IsDataObject { get; }

		/// <summary>Определяет, соответствует ли этот экземпляр атрибута <see cref="T:System.ComponentModel.DataObjectAttribute" /> шаблону другого объекта.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром атрибута <see cref="T:System.ComponentModel.DataObjectAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если этот экземпляр совпадает с экземпляром, заданным параметром <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E10 RID: 7696 RVA: 0x0006B500 File Offset: 0x00069700
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DataObjectAttribute dataObjectAttribute = obj as DataObjectAttribute;
			return dataObjectAttribute != null && dataObjectAttribute.IsDataObject == this.IsDataObject;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E11 RID: 7697 RVA: 0x0006B530 File Offset: 0x00069730
		public override int GetHashCode()
		{
			return this.IsDataObject.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли текущее значение атрибута его значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если текущим значением атрибута является значение по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E12 RID: 7698 RVA: 0x0006B54B File Offset: 0x0006974B
		public override bool IsDefaultAttribute()
		{
			return this.Equals(DataObjectAttribute.Default);
		}

		/// <summary>Показывает, что этот класс подходит для связывания с объектом <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> во время разработки. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F06 RID: 3846
		public static readonly DataObjectAttribute DataObject = new DataObjectAttribute(true);

		/// <summary>Показывает, что этот класс не подходит для связывания с объектом <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> во время разработки. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F07 RID: 3847
		public static readonly DataObjectAttribute NonDataObject = new DataObjectAttribute(false);

		/// <summary>Представляет значение по умолчанию класса <see cref="T:System.ComponentModel.DataObjectAttribute" />, показывающее, что класс подходит для связывания с объектом <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> во время разработки. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F08 RID: 3848
		public static readonly DataObjectAttribute Default = DataObjectAttribute.NonDataObject;
	}
}
