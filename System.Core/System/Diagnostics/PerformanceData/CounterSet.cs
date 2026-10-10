using System;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.PerformanceData
{
	/// <summary>
	///         Определяет набор логических счетчиков.
	///       </summary>
	// Token: 0x0200038E RID: 910
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class CounterSet : IDisposable
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceData.CounterSet" />.
		///       </summary>
		/// <param name="providerGuid">
		///           Идентификатор GUID, который уникально идентифицирует поставщика данных счетчика.
		///            Используйте идентификатор Guid, указанный в манифесте.
		///         </param>
		/// <param name="counterSetGuid">
		///           Идентификатор GUID, однозначно определяющий поставщика набора счетчиков.
		///            Используйте идентификатор Guid, указанный в манифесте.
		///         </param>
		/// <param name="instanceType">
		///           Идентифицирует тип набора счетчиков, например, ли набор счетчиков — это набор счетчиков одного или нескольких экземпляров.
		///         </param>
		/// <exception cref="T:System.InsufficientMemoryException">
		///             Недостаточно памяти для завершения операции.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Не поддерживается до Windows Vista.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Один из параметров имеет значение NULL или не является допустимым.
		///           </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">
		///             Сбой вызова базовой функции Win32.
		///           </exception>
		// Token: 0x06001B43 RID: 6979 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		[PermissionSet(SecurityAction.Demand, Unrestricted = true)]
		public CounterSet(Guid providerGuid, Guid counterSetGuid, CounterSetInstanceType instanceType)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Добавляет в набор с помощью указанного идентификатора счетчика и тип счетчиков.
		///       </summary>
		/// <param name="counterId">
		///           Идентифицирует счетчик.
		///            Используйте значение используется в манифесте для определения счетчика.
		///         </param>
		/// <param name="counterType">
		///           Идентифицирует тип счетчика.
		///            Тип счетчика определяет, как вычисляется, в среднем и отображаются данные счетчика.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Идентификатор счетчика уже существует в наборе или является отрицательным, или тип счетчика имеет значение NULL или не является допустимым.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Невозможно добавить счетчики в набор после создания экземпляра счетчика набора счетчиков.
		///           </exception>
		// Token: 0x06001B44 RID: 6980 RVA: 0x0000235B File Offset: 0x0000055B
		public void AddCounter(int counterId, CounterType counterType)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Добавляет в набор с помощью указанного идентификатора счетчика и тип и отображаемое имя для данного счетчика счетчиков.
		///       </summary>
		/// <param name="counterId">
		///           Идентифицирует счетчик.
		///            Используйте значение используется в манифесте для определения счетчика.
		///         </param>
		/// <param name="counterType">
		///           Идентифицирует тип счетчика.
		///            Тип счетчика определяет, как вычисляется, в среднем и отображаются данные счетчика.
		///         </param>
		/// <param name="counterName">
		///           Имя счетчика.
		///            Это имя можно использовать для индексации счетчика в экземпляре набора счетчиков.
		///            (См. раздел <see cref="P:System.Diagnostics.PerformanceData.CounterSetInstanceCounterDataSet.Item(System.String)" />).
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Идентификатор счетчика уже существует в наборе или является отрицательным, или тип счетчика имеет значение NULL или не является допустимым.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Невозможно добавить счетчики в набор после создания экземпляра счетчика набора счетчиков.
		///           </exception>
		// Token: 0x06001B45 RID: 6981 RVA: 0x0000235B File Offset: 0x0000055B
		public void AddCounter(int counterId, CounterType counterType, string counterName)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Создает экземпляр набора счетчиков.
		///       </summary>
		/// <param name="instanceName">
		///           Имя экземпляра.
		///            Имя должно быть уникальным.
		///         </param>
		/// <returns>
		///         Экземпляр набора счетчиков, в котором будут содержаться данные счетчиков.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Имя экземпляра имеет значение NULL.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Необходимо добавить счетчики в набор перед созданием экземпляра набора счетчиков счетчиков.
		///           </exception>
		// Token: 0x06001B46 RID: 6982 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecuritySafeCritical]
		[PermissionSet(SecurityAction.Demand, Unrestricted = true)]
		public CounterSetInstance CreateCounterSetInstance(string instanceName)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Освобождает все неуправляемые ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001B47 RID: 6983 RVA: 0x0000235B File Offset: 0x0000055B
		public void Dispose()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Выпуски все неуправляемые ресурсы, используемые этим объектом и при необходимости освобождает также управляемые ресурсы.
		///       </summary>
		/// <param name="disposing">
		///           <see langword="True" /> Если был совершен из метода Dispose <see langword="False" /> при вызове из метода завершения.
		///         </param>
		// Token: 0x06001B48 RID: 6984 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
