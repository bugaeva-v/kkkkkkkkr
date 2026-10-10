using System;

namespace System.Net.Mime
{
	/// <summary>Предоставляет строки для задания типа расположения вложения электронной почты.</summary>
	// Token: 0x020007FB RID: 2043
	public static class DispositionTypeNames
	{
		/// <summary>Указывает, что вложение должно отображаться как часть текста сообщения электронной почты.</summary>
		// Token: 0x04002796 RID: 10134
		public const string Inline = "inline";

		/// <summary>Указывает, что вложение должно отображаться как файл, вложенный в сообщение электронной почты.</summary>
		// Token: 0x04002797 RID: 10135
		public const string Attachment = "attachment";
	}
}
