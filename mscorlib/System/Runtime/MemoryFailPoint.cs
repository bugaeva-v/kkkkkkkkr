using System;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Runtime
{
	/// <summary>Проверяет наличие достаточного количество ресурсов памяти перед выполнением операции. Этот класс не наследуется.</summary>
	// Token: 0x02000553 RID: 1363
	public sealed class MemoryFailPoint : CriticalFinalizerObject, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.MemoryFailPoint" />, указывающий объем памяти, необходимый для успешного выполнения.</summary>
		/// <param name="sizeInMegabytes">Необходимый объем памяти в мегабайтах. Это значение должно быть положительным.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Заданный объем памяти является отрицательным числом.</exception>
		/// <exception cref="T:System.InsufficientMemoryException">Для выполнения кода, защищенного логическим элементом, недостаточно памяти.</exception>
		// Token: 0x060035B8 RID: 13752 RVA: 0x000C2008 File Offset: 0x000C0208
		[MonoTODO]
		public MemoryFailPoint(int sizeInMegabytes)
		{
			throw new NotImplementedException();
		}

		/// <summary>Обеспечивает освобождение ресурсов и выполнение других завершающих операций, когда сборщик мусора восстанавливает объект <see cref="T:System.Runtime.MemoryFailPoint" />.</summary>
		// Token: 0x060035B9 RID: 13753 RVA: 0x000C2018 File Offset: 0x000C0218
		~MemoryFailPoint()
		{
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Runtime.MemoryFailPoint" />.</summary>
		// Token: 0x060035BA RID: 13754 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		[SecuritySafeCritical]
		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
