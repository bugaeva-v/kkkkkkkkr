using System;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Предоставляет функции, необходимые для всех компонентов.</summary>
	// Token: 0x02000416 RID: 1046
	[Designer("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IRootDesigner))]
	[ComVisible(true)]
	[Designer("System.ComponentModel.Design.ComponentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IDesigner))]
	[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
	[TypeConverter(typeof(ComponentConverter))]
	public interface IComponent : IDisposable
	{
		/// <summary>Возвращает или задает объект <see cref="T:System.ComponentModel.ISite" />, связанный с объектом <see cref="T:System.ComponentModel.IComponent" />.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.ISite" />, связанный с компонентом; или <see langword="null" />, если у компонента нет узла.</returns>
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060021C9 RID: 8649
		// (set) Token: 0x060021CA RID: 8650
		ISite Site { get; set; }

		/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.ComponentModel.IComponent.Disposed" /> компонента.</summary>
		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060021CB RID: 8651
		// (remove) Token: 0x060021CC RID: 8652
		event EventHandler Disposed;
	}
}
