using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Указывает класс, используемый для реализации служб времени разработки для компонента.</summary>
	// Token: 0x02000412 RID: 1042
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class DesignerAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignerAttribute" />, используя указанное имя типа, предоставляющего службы времени разработки.</summary>
		/// <param name="designerTypeName">Объединение полного имени типа, предоставляющего службы времени разработки для компонента, с которым связан этот атрибут, и имени сборки, в которой находится этот тип.</param>
		// Token: 0x060021AA RID: 8618 RVA: 0x00073334 File Offset: 0x00071534
		public DesignerAttribute(string designerTypeName)
		{
			designerTypeName.ToUpper(CultureInfo.InvariantCulture);
			this.designerTypeName = designerTypeName;
			this.designerBaseTypeName = typeof(IDesigner).FullName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignerAttribute" />, используя указанный тип, предоставляющий службы времени разработки.</summary>
		/// <param name="designerType">
		///   <see cref="T:System.Type" />, представляющий класс, предоставляющий службы времени выполнения для компонента, с которым связан этот атрибут.</param>
		// Token: 0x060021AB RID: 8619 RVA: 0x00073364 File Offset: 0x00071564
		public DesignerAttribute(Type designerType)
		{
			this.designerTypeName = designerType.AssemblyQualifiedName;
			this.designerBaseTypeName = typeof(IDesigner).FullName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignerAttribute" />, используя тип конструктора и базовый класс конструктора.</summary>
		/// <param name="designerTypeName">Объединение полного имени типа, предоставляющего службы времени разработки для компонента, с которым связан этот атрибут, и имени сборки, в которой находится этот тип.</param>
		/// <param name="designerBaseTypeName">Полное имя базового класса, который нужно связать с классом конструктора.</param>
		// Token: 0x060021AC RID: 8620 RVA: 0x0007338D File Offset: 0x0007158D
		public DesignerAttribute(string designerTypeName, string designerBaseTypeName)
		{
			designerTypeName.ToUpper(CultureInfo.InvariantCulture);
			this.designerTypeName = designerTypeName;
			this.designerBaseTypeName = designerBaseTypeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignerAttribute" />, используя имя класса конструктора и базовый класс конструктора.</summary>
		/// <param name="designerTypeName">Объединение полного имени типа, предоставляющего службы времени разработки для компонента, с которым связан этот атрибут, и имени сборки, в которой находится этот тип.</param>
		/// <param name="designerBaseType">
		///   <see cref="T:System.Type" /> задает базовый класс, который нужно связать с параметром <paramref name="designerTypeName" />.</param>
		// Token: 0x060021AD RID: 8621 RVA: 0x000733AF File Offset: 0x000715AF
		public DesignerAttribute(string designerTypeName, Type designerBaseType)
		{
			designerTypeName.ToUpper(CultureInfo.InvariantCulture);
			this.designerTypeName = designerTypeName;
			this.designerBaseTypeName = designerBaseType.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DesignerAttribute" />, используя тип конструктора и базовый класс конструктора.</summary>
		/// <param name="designerType">
		///   <see cref="T:System.Type" />, представляющий класс, предоставляющий службы времени выполнения для компонента, с которым связан этот атрибут.</param>
		/// <param name="designerBaseType">
		///   <see cref="T:System.Type" /> задает базовый класс, который нужно связать с параметром <paramref name="designerType" />.</param>
		// Token: 0x060021AE RID: 8622 RVA: 0x000733D6 File Offset: 0x000715D6
		public DesignerAttribute(Type designerType, Type designerBaseType)
		{
			this.designerTypeName = designerType.AssemblyQualifiedName;
			this.designerBaseTypeName = designerBaseType.AssemblyQualifiedName;
		}

		/// <summary>Возвращает имя базового типа конструктора.</summary>
		/// <returns>Имя базового типа конструктора.</returns>
		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x000733F6 File Offset: 0x000715F6
		public string DesignerBaseTypeName
		{
			get
			{
				return this.designerBaseTypeName;
			}
		}

		/// <summary>Возвращает имя типа конструктора, связанного с этим атрибутом конструктора.</summary>
		/// <returns>Имя типа конструктора, связанного с этим атрибутом конструктора.</returns>
		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000733FE File Offset: 0x000715FE
		public string DesignerTypeName
		{
			get
			{
				return this.designerTypeName;
			}
		}

		/// <summary>Получает уникальный идентификатор для атрибута данного типа.</summary>
		/// <returns>Уникальный идентификатор для атрибута данного типа.</returns>
		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00073408 File Offset: 0x00071608
		public override object TypeId
		{
			get
			{
				if (this.typeId == null)
				{
					string text = this.designerBaseTypeName;
					int num = text.IndexOf(',');
					if (num != -1)
					{
						text = text.Substring(0, num);
					}
					this.typeId = base.GetType().FullName + text;
				}
				return this.typeId;
			}
		}

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.DesignerAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060021B2 RID: 8626 RVA: 0x00073458 File Offset: 0x00071658
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DesignerAttribute designerAttribute = obj as DesignerAttribute;
			return designerAttribute != null && designerAttribute.designerBaseTypeName == this.designerBaseTypeName && designerAttribute.designerTypeName == this.designerTypeName;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060021B3 RID: 8627 RVA: 0x0007349B File Offset: 0x0007169B
		public override int GetHashCode()
		{
			return this.designerTypeName.GetHashCode() ^ this.designerBaseTypeName.GetHashCode();
		}

		// Token: 0x04001022 RID: 4130
		private readonly string designerTypeName;

		// Token: 0x04001023 RID: 4131
		private readonly string designerBaseTypeName;

		// Token: 0x04001024 RID: 4132
		private string typeId;
	}
}
