using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Определяет атрибут контекста.</summary>
	// Token: 0x02000594 RID: 1428
	[ComVisible(true)]
	public interface IContextAttribute
	{
		/// <summary>Возвращает контекстные свойства вызывающей стороне данного сообщения.</summary>
		/// <param name="msg">Сообщение <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />, к которому добавляются контекстные свойства.</param>
		// Token: 0x060037CF RID: 14287
		void GetPropertiesForNewContext(IConstructionCallMessage msg);

		/// <summary>Возвращает логическое значение, указывающее, удовлетворяет ли указанный контекст требованиям атрибута контекста.</summary>
		/// <param name="ctx">Контекст, в котором проверяется текущий атрибут контекста.</param>
		/// <param name="msg">Вызов конструирования, параметры которого требуется проверить относительно текущего контекста.</param>
		/// <returns>Имеет значение <see langword="true" />, если заданный контекст приемлем; иначе —  <see langword="false" />.</returns>
		// Token: 0x060037D0 RID: 14288
		bool IsContextOK(Context ctx, IConstructionCallMessage msg);
	}
}
