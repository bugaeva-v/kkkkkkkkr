using System;

namespace System.Drawing
{
	/// <summary>Предоставляет методы создания графических буферов, которые могут использоваться для двойной буферизации.</summary>
	// Token: 0x02000050 RID: 80
	public sealed class BufferedGraphicsContext : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.BufferedGraphicsContext" />.</summary>
		// Token: 0x060003A9 RID: 937 RVA: 0x00009B71 File Offset: 0x00007D71
		public BufferedGraphicsContext()
		{
			this.max_buffer = Size.Empty;
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x060003AA RID: 938 RVA: 0x00009B84 File Offset: 0x00007D84
		~BufferedGraphicsContext()
		{
		}

		/// <summary>Создает графический буфер заданного размера, используя формат пикселей заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="targetGraphics">Объект <see cref="T:System.Drawing.Graphics" /> для сопоставления формата пикселей для нового буфера.</param>
		/// <param name="targetRectangle">Объект <see cref="T:System.Drawing.Rectangle" />, показывающий размер создаваемого буфера.</param>
		/// <returns>Объект <see cref="T:System.Drawing.BufferedGraphics" />, который может использоваться для рисования буфера заданных размеров.</returns>
		// Token: 0x060003AB RID: 939 RVA: 0x00009BAC File Offset: 0x00007DAC
		public BufferedGraphics Allocate(Graphics targetGraphics, Rectangle targetRectangle)
		{
			return new BufferedGraphics(targetGraphics, targetRectangle);
		}

		/// <summary>Создает графический буфер заданного размера, используя формат пикселей заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="targetDC">Указатель <see cref="T:System.IntPtr" /> на контекст устройства для соответствия формату пикселей нового буфера.</param>
		/// <param name="targetRectangle">Объект <see cref="T:System.Drawing.Rectangle" />, показывающий размер создаваемого буфера.</param>
		/// <returns>Объект <see cref="T:System.Drawing.BufferedGraphics" />, который может использоваться для рисования буфера заданных размеров.</returns>
		// Token: 0x060003AC RID: 940 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("The targetDC parameter has no equivalent in libgdiplus.")]
		public BufferedGraphics Allocate(IntPtr targetDC, Rectangle targetRectangle)
		{
			throw new NotImplementedException();
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Drawing.BufferedGraphicsContext" />.</summary>
		// Token: 0x060003AD RID: 941 RVA: 0x00009BB5 File Offset: 0x00007DB5
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		/// <summary>Удаляет текущий графический буфер, если буфер был выделен и еще не был распределен.</summary>
		// Token: 0x060003AE RID: 942 RVA: 0x000049FE File Offset: 0x00002BFE
		public void Invalidate()
		{
		}

		/// <summary>Возвращает или задает максимальный размер используемого буфера.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Size" />, показывающий максимальный размер буфера.</returns>
		/// <exception cref="T:System.ArgumentException">Значение высоты или ширины размера меньше или равно нулю.</exception>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00009BBD File Offset: 0x00007DBD
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00009BC5 File Offset: 0x00007DC5
		public Size MaximumBuffer
		{
			get
			{
				return this.max_buffer;
			}
			set
			{
				if (value.Width <= 0 || value.Height <= 0)
				{
					throw new ArgumentException("The height or width of the size is less than or equal to zero.");
				}
				this.max_buffer = value;
			}
		}

		// Token: 0x04000432 RID: 1074
		private Size max_buffer;
	}
}
