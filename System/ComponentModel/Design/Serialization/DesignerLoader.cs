using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет основной интерфейс загрузчика конструктора, используемый для реализации пользовательского загрузчика конструктора.</summary>
	// Token: 0x02000483 RID: 1155
	public abstract class DesignerLoader
	{
		/// <summary>Возвращает значение, определяющее, загружается ли документ загрузчиком.</summary>
		/// <returns>Значение <see langword="true" />, если документ загружается загрузчиком; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool Loading
		{
			get
			{
				return false;
			}
		}

		/// <summary>Начинает загрузку конструктора.</summary>
		/// <param name="host">узел загрузчика, через который происходит загрузка компонентов.</param>
		// Token: 0x0600250B RID: 9483
		public abstract void BeginLoad(IDesignerLoaderHost host);

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.ComponentModel.Design.Serialization.DesignerLoader" />.</summary>
		// Token: 0x0600250C RID: 9484
		public abstract void Dispose();

		/// <summary>Записывает изменения в кэше в то местоположение, из которого был загружен конструктор.</summary>
		// Token: 0x0600250D RID: 9485 RVA: 0x00003917 File Offset: 0x00001B17
		public virtual void Flush()
		{
		}
	}
}
