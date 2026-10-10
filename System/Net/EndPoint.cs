using System;
using System.Net.Sockets;

namespace System.Net
{
	/// <summary>Определяет сетевой адрес. Это класс <see langword="abstract" />.</summary>
	// Token: 0x020005CB RID: 1483
	[Serializable]
	public abstract class EndPoint
	{
		/// <summary>Получает семейство адресов, к которому принадлежит конечная точка.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.Sockets.AddressFamily" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Если свойство не переопределено во вложенном классе, делаются все возможные попытки получить или задать его.</exception>
		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x000A5C43 File Offset: 0x000A3E43
		public virtual AddressFamily AddressFamily
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>Выводит в последовательном виде сведения о конечной точке в экземпляр класса <see cref="T:System.Net.SocketAddress" />.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Net.SocketAddress" />, содержащий сведения о конечной точке.</returns>
		/// <exception cref="T:System.NotImplementedException">Предпринимаются любые попытки вызова данного метода, когда метод не переопределен в классе-потомке.</exception>
		// Token: 0x06003007 RID: 12295 RVA: 0x000A5C4A File Offset: 0x000A3E4A
		public virtual SocketAddress Serialize()
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>Создает экземпляр <see cref="T:System.Net.EndPoint" /> из экземпляра <see cref="T:System.Net.SocketAddress" />.</summary>
		/// <param name="socketAddress">Адрес сокета, который используется как конечная точка подключения.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Net.EndPoint" />, получаемый из заданного экземпляра класса <see cref="T:System.Net.SocketAddress" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Предпринимаются любые попытки вызова данного метода, когда метод не переопределен в классе-потомке.</exception>
		// Token: 0x06003008 RID: 12296 RVA: 0x000A5C4A File Offset: 0x000A3E4A
		public virtual EndPoint Create(SocketAddress socketAddress)
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}
	}
}
