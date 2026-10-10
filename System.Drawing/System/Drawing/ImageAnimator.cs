using System;
using System.Collections;
using System.Drawing.Imaging;
using System.Threading;

namespace System.Drawing
{
	/// <summary>Анимирует изображение, в котором есть кадры на основе времени.</summary>
	// Token: 0x02000080 RID: 128
	public sealed class ImageAnimator
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
		private ImageAnimator()
		{
		}

		/// <summary>Отображает многокадровое изображение в виде анимации.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, который требуется анимировать.</param>
		/// <param name="onFrameChangedHandler">Объект <see langword="EventHandler" />, определяющий метод, вызываемый при изменении кадра анимации.</param>
		// Token: 0x06000626 RID: 1574 RVA: 0x00011D8C File Offset: 0x0000FF8C
		public static void Animate(Image image, EventHandler onFrameChangedHandler)
		{
			if (!ImageAnimator.CanAnimate(image))
			{
				return;
			}
			if (ImageAnimator.ht.ContainsKey(image))
			{
				return;
			}
			byte[] value = image.GetPropertyItem(20736).Value;
			int[] array = new int[value.Length >> 2];
			int i = 0;
			int num = 0;
			while (i < value.Length)
			{
				int num2 = BitConverter.ToInt32(value, i) * 10;
				array[num] = ((num2 < 100) ? 100 : num2);
				i += 4;
				num++;
			}
			AnimateEventArgs animateEventArgs = new AnimateEventArgs(image);
			Thread thread = new Thread(new ThreadStart(new WorkerThread(onFrameChangedHandler, animateEventArgs, array).LoopHandler));
			thread.IsBackground = true;
			animateEventArgs.RunThread = thread;
			ImageAnimator.ht.Add(image, animateEventArgs);
			thread.Start();
		}

		/// <summary>Возвращает логическое значение, определяющее, содержит ли указанное изображение кадры на основе времени.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для проверки.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если указанное изображение содержит кадры на основе времени; в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000627 RID: 1575 RVA: 0x00011E44 File Offset: 0x00010044
		public static bool CanAnimate(Image image)
		{
			if (image == null)
			{
				return false;
			}
			int num = image.FrameDimensionsList.Length;
			if (num < 1)
			{
				return false;
			}
			for (int i = 0; i < num; i++)
			{
				if (image.FrameDimensionsList[i].Equals(FrameDimension.Time.Guid))
				{
					return image.GetFrameCount(FrameDimension.Time) > 1;
				}
			}
			return false;
		}

		/// <summary>Прекращает выполняющуюся анимацию.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для остановки анимирования.</param>
		/// <param name="onFrameChangedHandler">Объект <see langword="EventHandler" />, определяющий метод, вызываемый при изменении кадра анимации.</param>
		// Token: 0x06000628 RID: 1576 RVA: 0x00011E9E File Offset: 0x0001009E
		public static void StopAnimate(Image image, EventHandler onFrameChangedHandler)
		{
			if (image == null)
			{
				return;
			}
			if (ImageAnimator.ht.ContainsKey(image))
			{
				((AnimateEventArgs)ImageAnimator.ht[image]).RunThread.Abort();
				ImageAnimator.ht.Remove(image);
			}
		}

		/// <summary>Продвигает кадр во все изображения, для которых сейчас выполняется анимация. Новый кадр выводится при следующей отрисовке изображения.</summary>
		// Token: 0x06000629 RID: 1577 RVA: 0x00011ED8 File Offset: 0x000100D8
		public static void UpdateFrames()
		{
			foreach (object obj in ImageAnimator.ht.Keys)
			{
				ImageAnimator.UpdateImageFrame((Image)obj);
			}
		}

		/// <summary>Продвигает кадр в указанном изображении. Новый кадр выводится при следующей отрисовке изображения. Этот метод применяется только к изображениям с кадрами на основе времени.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, для которого требуется обновить кадры.</param>
		// Token: 0x0600062A RID: 1578 RVA: 0x00011F34 File Offset: 0x00010134
		public static void UpdateFrames(Image image)
		{
			if (image == null)
			{
				return;
			}
			if (ImageAnimator.ht.ContainsKey(image))
			{
				ImageAnimator.UpdateImageFrame(image);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00011F50 File Offset: 0x00010150
		private static void UpdateImageFrame(Image image)
		{
			AnimateEventArgs animateEventArgs = (AnimateEventArgs)ImageAnimator.ht[image];
			image.SelectActiveFrame(FrameDimension.Time, animateEventArgs.GetNextFrame());
		}

		// Token: 0x040004CF RID: 1231
		private static Hashtable ht = Hashtable.Synchronized(new Hashtable());
	}
}
