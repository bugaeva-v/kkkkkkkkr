using System;

namespace System.Drawing.Imaging
{
	/// <summary>Предоставляет свойства, получающие размеры кадра изображения. Не наследуется.</summary>
	// Token: 0x02000106 RID: 262
	public sealed class FrameDimension
	{
		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.FrameDimension" /> с помощью указанной структуры <see langword="Guid" />.</summary>
		/// <param name="guid">Структура <see langword="Guid" /> содержит GUID для этого объекта <see cref="T:System.Drawing.Imaging.FrameDimension" />.</param>
		// Token: 0x06000C73 RID: 3187 RVA: 0x0001D16A File Offset: 0x0001B36A
		public FrameDimension(Guid guid)
		{
			this._guid = guid;
		}

		/// <summary>Получает глобальный уникальный идентификатор (GUID), представляющий объект <see cref="T:System.Drawing.Imaging.FrameDimension" />.</summary>
		/// <returns>Структура <see langword="Guid" /> содержит GUID, представляющий объект <see cref="T:System.Drawing.Imaging.FrameDimension" />.</returns>
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0001D179 File Offset: 0x0001B379
		public Guid Guid
		{
			get
			{
				return this._guid;
			}
		}

		/// <summary>Возвращает размерность времени.</summary>
		/// <returns>Размерность времени.</returns>
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0001D181 File Offset: 0x0001B381
		public static FrameDimension Time
		{
			get
			{
				return FrameDimension.s_time;
			}
		}

		/// <summary>Возвращает размерность разрешения.</summary>
		/// <returns>Размерность разрешения.</returns>
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0001D188 File Offset: 0x0001B388
		public static FrameDimension Resolution
		{
			get
			{
				return FrameDimension.s_resolution;
			}
		}

		/// <summary>Возвращает размер страницы.</summary>
		/// <returns>Размер страницы.</returns>
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0001D18F File Offset: 0x0001B38F
		public static FrameDimension Page
		{
			get
			{
				return FrameDimension.s_page;
			}
		}

		/// <summary>Возвращает значение, которое определяет, эквивалентен ли указанный объект <see cref="T:System.Drawing.Imaging.FrameDimension" /> объекту <see cref="T:System.Drawing.Imaging.FrameDimension" />.</summary>
		/// <param name="o">Объект для тестирования.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="o" /> является объектом <see cref="T:System.Drawing.Imaging.FrameDimension" />, эквивалентным объекту <see cref="T:System.Drawing.Imaging.FrameDimension" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000C78 RID: 3192 RVA: 0x0001D198 File Offset: 0x0001B398
		public override bool Equals(object o)
		{
			FrameDimension frameDimension = o as FrameDimension;
			return frameDimension != null && this._guid == frameDimension._guid;
		}

		/// <summary>Возвращает хэш-код объекта <see cref="T:System.Drawing.Imaging.FrameDimension" />.</summary>
		/// <returns>Хэш-код данного объекта <see cref="T:System.Drawing.Imaging.FrameDimension" />.</returns>
		// Token: 0x06000C79 RID: 3193 RVA: 0x0001D1C2 File Offset: 0x0001B3C2
		public override int GetHashCode()
		{
			return this._guid.GetHashCode();
		}

		/// <summary>Преобразует этот объект <see cref="T:System.Drawing.Imaging.FrameDimension" /> в удобную для восприятия строку.</summary>
		/// <returns>Строка, представляющая данный объект <see cref="T:System.Drawing.Imaging.FrameDimension" />.</returns>
		// Token: 0x06000C7A RID: 3194 RVA: 0x0001D1D8 File Offset: 0x0001B3D8
		public override string ToString()
		{
			if (this == FrameDimension.s_time)
			{
				return "Time";
			}
			if (this == FrameDimension.s_resolution)
			{
				return "Resolution";
			}
			if (this == FrameDimension.s_page)
			{
				return "Page";
			}
			string str = "[FrameDimension: ";
			Guid guid = this._guid;
			return str + guid.ToString() + "]";
		}

		// Token: 0x040009A6 RID: 2470
		private static FrameDimension s_time = new FrameDimension(new Guid("{6aedbd6d-3fb5-418a-83a6-7f45229dc872}"));

		// Token: 0x040009A7 RID: 2471
		private static FrameDimension s_resolution = new FrameDimension(new Guid("{84236f7b-3bd3-428f-8dab-4ea1439ca315}"));

		// Token: 0x040009A8 RID: 2472
		private static FrameDimension s_page = new FrameDimension(new Guid("{7462dc86-6180-4c7e-8e3f-ee7333a7a483}"));

		// Token: 0x040009A9 RID: 2473
		private Guid _guid;
	}
}
