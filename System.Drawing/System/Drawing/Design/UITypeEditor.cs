using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет базовый класс, используемый для конструирования редакторов значений, которые обеспечивают пользовательский интерфейс для визуализации и редактирования значений объектов поддерживаемых типов данных.</summary>
	// Token: 0x0200012F RID: 303
	public class UITypeEditor
	{
		// Token: 0x06000DC1 RID: 3521 RVA: 0x0001F0D0 File Offset: 0x0001D2D0
		static UITypeEditor()
		{
			Hashtable hashtable = new Hashtable();
			hashtable[typeof(DateTime)] = "System.ComponentModel.Design.DateTimeEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			hashtable[typeof(Array)] = "System.ComponentModel.Design.ArrayEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			hashtable[typeof(IList)] = "System.ComponentModel.Design.CollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			hashtable[typeof(ICollection)] = "System.ComponentModel.Design.CollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			hashtable[typeof(byte[])] = "System.ComponentModel.Design.BinaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			hashtable[typeof(Stream)] = "System.ComponentModel.Design.BinaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			hashtable[typeof(string[])] = "System.Windows.Forms.Design.StringArrayEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			hashtable[typeof(Collection<string>)] = "System.Windows.Forms.Design.StringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			TypeDescriptor.AddEditorTable(typeof(UITypeEditor), hashtable);
		}

		/// <summary>Возвращает значение, указывающее, должен ли пользователь иметь возможность изменять размер редакторов с раскрывающимися списками.</summary>
		/// <returns>Значение <see langword="true" />, если предоставлена возможность изменять размер редакторов с раскрывающимися списками; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0000C228 File Offset: 0x0000A428
		public virtual bool IsDropDownResizable
		{
			get
			{
				return false;
			}
		}

		/// <summary>Изменяет значение заданного объекта, используя стиль редактирования, определенного при помощи метода <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle" />.</summary>
		/// <param name="provider">Поставщик <see cref="T:System.IServiceProvider" />, который этот редактор может использовать для получения услуг.</param>
		/// <param name="value">Редактируемый объект.</param>
		/// <returns>Новое значение объекта.</returns>
		// Token: 0x06000DC4 RID: 3524 RVA: 0x0001F19B File Offset: 0x0001D39B
		public object EditValue(IServiceProvider provider, object value)
		{
			return this.EditValue(null, provider, value);
		}

		/// <summary>Изменяет значение указанного объекта, используя стиль редактирования, определенный с помощью метода <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle" />.</summary>
		/// <param name="context">Интерфейс <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для получения дополнительных сведений о контексте.</param>
		/// <param name="provider">Поставщик <see cref="T:System.IServiceProvider" />, который этот редактор может использовать для получения услуг.</param>
		/// <param name="value">Редактируемый объект.</param>
		/// <returns>Новое значение объекта. Если значение объекта не изменилось, должен быть возвращен переданный объект.</returns>
		// Token: 0x06000DC5 RID: 3525 RVA: 0x0001F1A6 File Offset: 0x0001D3A6
		public virtual object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			return value;
		}

		/// <summary>Получает стиль редактирования, используемый методом <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)" />.</summary>
		/// <returns>Значение перечисления <see cref="T:System.Drawing.Design.UITypeEditorEditStyle" />, которое указывает на стиль редактирования, используемый текущим объектом <see cref="T:System.Drawing.Design.UITypeEditor" />. По умолчанию этот метод возвращает значение <see cref="F:System.Drawing.Design.UITypeEditorEditStyle.None" />.</returns>
		// Token: 0x06000DC6 RID: 3526 RVA: 0x0001F1A9 File Offset: 0x0001D3A9
		public UITypeEditorEditStyle GetEditStyle()
		{
			return this.GetEditStyle(null);
		}

		/// <summary>Указывает, поддерживает ли этот редактор визуальное представление значения объекта.</summary>
		/// <returns>Значение <see langword="true" />, если реализован класс <see cref="M:System.Drawing.Design.UITypeEditor.PaintValue(System.Object,System.Drawing.Graphics,System.Drawing.Rectangle)" />, в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000DC7 RID: 3527 RVA: 0x0001F1B2 File Offset: 0x0001D3B2
		public bool GetPaintValueSupported()
		{
			return this.GetPaintValueSupported(null);
		}

		/// <summary>Указывает, поддерживает ли указанный контекст визуальное представление значения объекта в пределах определенного контекста.</summary>
		/// <param name="context">Интерфейс <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для получения дополнительных сведений о контексте.</param>
		/// <returns>Значение <see langword="true" />, если реализован класс <see cref="M:System.Drawing.Design.UITypeEditor.PaintValue(System.Object,System.Drawing.Graphics,System.Drawing.Rectangle)" />, в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000DC8 RID: 3528 RVA: 0x0000C228 File Offset: 0x0000A428
		public virtual bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Получает стиль редактирования, используемый методом <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)" />.</summary>
		/// <param name="context">Интерфейс <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для получения дополнительных сведений о контексте.</param>
		/// <returns>Значение <see cref="T:System.Drawing.Design.UITypeEditorEditStyle" />, которое указывает стиль редактирования, используемый методом <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)" />. Если класс <see cref="T:System.Drawing.Design.UITypeEditor" /> не поддерживает данный метод, то метод <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle" /> вернет <see cref="F:System.Drawing.Design.UITypeEditorEditStyle.None" />.</returns>
		// Token: 0x06000DC9 RID: 3529 RVA: 0x00003610 File Offset: 0x00001810
		public virtual UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.None;
		}

		/// <summary>Рисует представление значения указанного объекта на заданном холсте.</summary>
		/// <param name="value">Объект, значение которого данного типа отображает редактор.</param>
		/// <param name="canvas">Основа, на которой рисуется представление значения объекта.</param>
		/// <param name="rectangle">Объект <see cref="T:System.Drawing.Rectangle" />, в границах которого рисуется значение.</param>
		// Token: 0x06000DCA RID: 3530 RVA: 0x0001F1BB File Offset: 0x0001D3BB
		public void PaintValue(object value, Graphics canvas, Rectangle rectangle)
		{
			this.PaintValue(new PaintValueEventArgs(null, value, canvas, rectangle));
		}

		/// <summary>Рисует представление значения объекта с помощью указанного аргумента <see cref="T:System.Drawing.Design.PaintValueEventArgs" />.</summary>
		/// <param name="e">Аргумент <see cref="T:System.Drawing.Design.PaintValueEventArgs" /> указывает предмет и место рисования.</param>
		// Token: 0x06000DCB RID: 3531 RVA: 0x000049FE File Offset: 0x00002BFE
		public virtual void PaintValue(PaintValueEventArgs e)
		{
		}
	}
}
