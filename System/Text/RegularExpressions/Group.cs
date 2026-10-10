using System;
using Unity;

namespace System.Text.RegularExpressions
{
	/// <summary>Представляет результаты из одной группы записи.</summary>
	// Token: 0x020001ED RID: 493
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x06000CF4 RID: 3316 RVA: 0x00035986 File Offset: 0x00033B86
		internal Group(string text, int[] caps, int capcount, string name) : base(text, (capcount == 0) ? 0 : caps[(capcount - 1) * 2], (capcount == 0) ? 0 : caps[capcount * 2 - 1])
		{
			this._caps = caps;
			this._capcount = capcount;
			this.Name = name;
		}

		/// <summary>Получает значение, указывающее на то, успешно ли совпадение.</summary>
		/// <returns>Значение <see langword="true" />, если совпадение успешно, иначе значение <see langword="false" />.</returns>
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x000359BF File Offset: 0x00033BBF
		public bool Success
		{
			get
			{
				return this._capcount != 0;
			}
		}

		/// <summary>Возвращает имя группы записи, представляемой текущим экземпляром.</summary>
		/// <returns>Имя захватываемой группы, представляемое текущим экземпляром.</returns>
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000359CA File Offset: 0x00033BCA
		public string Name { get; }

		/// <summary>Получает коллекцию всех записей, соответствующих группе записи, в порядке, в котором первыми расположены внутренние слева направо (или внутренние справа налево, если регулярное выражение изменено с помощью параметра <see cref="F:System.Text.RegularExpressions.RegexOptions.RightToLeft" />). Коллекция может иметь ноль и более элементов.</summary>
		/// <returns>Коллекция подстрок, соответствующих группе.</returns>
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x000359D2 File Offset: 0x00033BD2
		public CaptureCollection Captures
		{
			get
			{
				if (this._capcoll == null)
				{
					this._capcoll = new CaptureCollection(this);
				}
				return this._capcoll;
			}
		}

		/// <summary>Возвращает объект <see langword="Group" />, эквивалентный тому из предоставленных, который можно безопасно разделить между несколькими потоками.</summary>
		/// <param name="inner">Входной объект <see cref="T:System.Text.RegularExpressions.Group" />.</param>
		/// <returns>Объект регулярного выражения <see langword="Group" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inner" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000CF8 RID: 3320 RVA: 0x000359F0 File Offset: 0x00033BF0
		public static Group Synchronized(Group inner)
		{
			if (inner == null)
			{
				throw new ArgumentNullException("inner");
			}
			CaptureCollection captures = inner.Captures;
			if (inner.Success)
			{
				captures.ForceInitialized();
			}
			return inner;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal Group()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040007E1 RID: 2017
		internal static readonly Group s_emptyGroup = new Group(string.Empty, Array.Empty<int>(), 0, string.Empty);

		// Token: 0x040007E2 RID: 2018
		internal readonly int[] _caps;

		// Token: 0x040007E3 RID: 2019
		internal int _capcount;

		// Token: 0x040007E4 RID: 2020
		internal CaptureCollection _capcoll;
	}
}
