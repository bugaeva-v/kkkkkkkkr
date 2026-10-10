using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет сведения о событии.</summary>
	// Token: 0x020003A6 RID: 934
	public abstract class EventDescriptor : MemberDescriptor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EventDescriptor" />, используя указанные имя и массив атрибутов.</summary>
		/// <param name="name">Имя события.</param>
		/// <param name="attrs">Массив типа <see cref="T:System.Attribute" />, который содержит атрибуты события.</param>
		// Token: 0x06001E83 RID: 7811 RVA: 0x0006C2CB File Offset: 0x0006A4CB
		protected EventDescriptor(string name, Attribute[] attrs) : base(name, attrs)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EventDescriptor" />, используя имя и атрибуты заданного объекта <see cref="T:System.ComponentModel.MemberDescriptor" />.</summary>
		/// <param name="descr">Объект <see cref="T:System.ComponentModel.MemberDescriptor" />, содержащий имя события и его атрибуты.</param>
		// Token: 0x06001E84 RID: 7812 RVA: 0x0006C2D5 File Offset: 0x0006A4D5
		protected EventDescriptor(MemberDescriptor descr) : base(descr)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EventDescriptor" />, используя имя в заданном дескрипторе <see cref="T:System.ComponentModel.MemberDescriptor" /> и атрибуты как в дескрипторе <see cref="T:System.ComponentModel.MemberDescriptor" />, так и в массиве <see cref="T:System.Attribute" />.</summary>
		/// <param name="descr">Объект <see cref="T:System.ComponentModel.MemberDescriptor" />, который содержит имя члена и его атрибуты.</param>
		/// <param name="attrs">Массив <see cref="T:System.Attribute" /> с атрибутами, которые нужно добавить в описание этого события.</param>
		// Token: 0x06001E85 RID: 7813 RVA: 0x0006C2DE File Offset: 0x0006A4DE
		protected EventDescriptor(MemberDescriptor descr, Attribute[] attrs) : base(descr, attrs)
		{
		}

		/// <summary>При переопределении в производном классе возвращает тип компонента, с которым связано это событие.</summary>
		/// <returns>Тип <see cref="T:System.Type" />, представляющий тип компонента, с которым связано событие.</returns>
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001E86 RID: 7814
		public abstract Type ComponentType { get; }

		/// <summary>При переопределении в производном классе возвращает тип делегата для события.</summary>
		/// <returns>
		///   <see cref="T:System.Type" />, где представляется тип делегата для события.</returns>
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001E87 RID: 7815
		public abstract Type EventType { get; }

		/// <summary>При переопределении в производном классе возвращает значение, показывающее, является ли делегат события многоадресным.</summary>
		/// <returns>Значение <see langword="true" />, если делегат является многоадресным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001E88 RID: 7816
		public abstract bool IsMulticast { get; }

		/// <summary>При переопределении в производном классе связывает событие с компонентом.</summary>
		/// <param name="component">Компонент, который передает события делегату.</param>
		/// <param name="value">Делегат, который представляет метод для обработки события.</param>
		// Token: 0x06001E89 RID: 7817
		public abstract void AddEventHandler(object component, Delegate value);

		/// <summary>При переопределении в производном классе разрывает связь делегата с компонентом и, таким образом, в дальнейшем делегат не будет получать события от компонента.</summary>
		/// <param name="component">Компонент, с которым связан делегат.</param>
		/// <param name="value">Делегат, связь которого с компонентом разрывается.</param>
		// Token: 0x06001E8A RID: 7818
		public abstract void RemoveEventHandler(object component, Delegate value);
	}
}
