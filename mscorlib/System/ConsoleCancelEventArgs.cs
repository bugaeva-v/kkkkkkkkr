using System;
using Unity;

namespace System
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Console.CancelKeyPress" />. Этот класс не наследуется.</summary>
	// Token: 0x020001BD RID: 445
	[Serializable]
	public sealed class ConsoleCancelEventArgs : EventArgs
	{
		// Token: 0x06001334 RID: 4916 RVA: 0x0004D860 File Offset: 0x0004BA60
		internal ConsoleCancelEventArgs(ConsoleSpecialKey type)
		{
			this._type = type;
		}

		/// <summary>Получает или задает значение, указывающее, останавливается ли текущий процесс при одновременном нажатии клавиши-модификатора <see cref="F:System.ConsoleModifiers.Control" /> и клавиши консоли <see cref="F:System.ConsoleKey.C" /> (CTRL+C) либо клавиш CTRL+BREAK. Значение по умолчанию <see langword="false" />, которое используется для завершения текущего процесса.</summary>
		/// <returns>
		///   <see langword="true" />, если по завершении работы обработчика событий текущий процесс следует возобновлять; <see langword="false" />, если текущий процесс следует останавливать. Значение по умолчанию — <see langword="false" />; текущий процесс заканчивается, когда обработчик событий возвращает. <see langword="true" />, если текущий процесс продолжается.</returns>
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0004D86F File Offset: 0x0004BA6F
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x0004D877 File Offset: 0x0004BA77
		public bool Cancel { get; set; }

		/// <summary>Возвращает сочетание клавиш, с помощью которого была прервана работа текущего процесса.</summary>
		/// <returns>Одно из значений перечисления, указывающее сочетание клавиш, которое прервало текущий процесс. Значение по умолчанию отсутствует.</returns>
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0004D880 File Offset: 0x0004BA80
		public ConsoleSpecialKey SpecialKey
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x000173AD File Offset: 0x000155AD
		internal ConsoleCancelEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001395 RID: 5013
		private readonly ConsoleSpecialKey _type;
	}
}
