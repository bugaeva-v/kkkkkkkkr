using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Показывает клиенту COM, что все классы текущей версии сборки совместимы с классами в более ранней версии сборки.</summary>
	// Token: 0x0200070F RID: 1807
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class ComCompatibleVersionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ComCompatibleVersionAttribute" />, используя основной и дополнительный номера версий, номер построения и номер редакции сборки.</summary>
		/// <param name="major">Основной номер версии сборки.</param>
		/// <param name="minor">Дополнительный номер версии сборки.</param>
		/// <param name="build">Номер построения сборки.</param>
		/// <param name="revision">Номер редакции сборки.</param>
		// Token: 0x060040BC RID: 16572 RVA: 0x000E15DB File Offset: 0x000DF7DB
		public ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
		{
			this._major = major;
			this._minor = minor;
			this._build = build;
			this._revision = revision;
		}

		/// <summary>Получает основной номер версии сборки.</summary>
		/// <returns>Основной номер версии сборки.</returns>
		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060040BD RID: 16573 RVA: 0x000E1600 File Offset: 0x000DF800
		public int MajorVersion
		{
			get
			{
				return this._major;
			}
		}

		/// <summary>Получает дополнительный номер версии сборки.</summary>
		/// <returns>Дополнительный номер версии сборки.</returns>
		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x000E1608 File Offset: 0x000DF808
		public int MinorVersion
		{
			get
			{
				return this._minor;
			}
		}

		/// <summary>Получает номер построения сборки.</summary>
		/// <returns>Номер построения сборки.</returns>
		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x000E1610 File Offset: 0x000DF810
		public int BuildNumber
		{
			get
			{
				return this._build;
			}
		}

		/// <summary>Получает номер редакции сборки.</summary>
		/// <returns>Номер редакции сборки.</returns>
		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x000E1618 File Offset: 0x000DF818
		public int RevisionNumber
		{
			get
			{
				return this._revision;
			}
		}

		// Token: 0x04002AE9 RID: 10985
		internal int _major;

		// Token: 0x04002AEA RID: 10986
		internal int _minor;

		// Token: 0x04002AEB RID: 10987
		internal int _build;

		// Token: 0x04002AEC RID: 10988
		internal int _revision;
	}
}
