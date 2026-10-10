using System;
using System.Collections.Generic;

namespace System.Xml.Linq
{
	/// <summary>Представляет узел или атрибут в дереве XML.</summary>
	// Token: 0x0200005A RID: 90
	public abstract class XObject : IXmlLineInfo
	{
		// Token: 0x0600035C RID: 860 RVA: 0x00003E36 File Offset: 0x00002036
		internal XObject()
		{
		}

		/// <summary>Получение базового URI для данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>
		///   <see cref="T:System.String" />, содержащий базовый URI для данного <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000F818 File Offset: 0x0000DA18
		public string BaseUri
		{
			get
			{
				XObject xobject = this;
				BaseUriAnnotation baseUriAnnotation;
				for (;;)
				{
					if (xobject == null || xobject.annotations != null)
					{
						if (xobject == null)
						{
							goto IL_33;
						}
						baseUriAnnotation = xobject.Annotation<BaseUriAnnotation>();
						if (baseUriAnnotation != null)
						{
							break;
						}
						xobject = xobject.parent;
					}
					else
					{
						xobject = xobject.parent;
					}
				}
				return baseUriAnnotation.baseUri;
				IL_33:
				return string.Empty;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Xml.Linq.XDocument" /> для данного объекта <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XDocument" /> для этой службы <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000F860 File Offset: 0x0000DA60
		public XDocument Document
		{
			get
			{
				XObject xobject = this;
				while (xobject.parent != null)
				{
					xobject = xobject.parent;
				}
				return xobject as XDocument;
			}
		}

		/// <summary>Получение типа узла для данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>Тип узла для данного <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600035F RID: 863
		public abstract XmlNodeType NodeType { get; }

		/// <summary>Возвращает родительский объект <see cref="T:System.Xml.Linq.XElement" /> этого объекта <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>Родительский элемент <see cref="T:System.Xml.Linq.XElement" /> данного объекта <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0000F886 File Offset: 0x0000DA86
		public XElement Parent
		{
			get
			{
				return this.parent as XElement;
			}
		}

		/// <summary>Добавление объекта в список примечаний данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <param name="annotation">Объект, содержащий добавляемое примечание.</param>
		// Token: 0x06000361 RID: 865 RVA: 0x0000F894 File Offset: 0x0000DA94
		public void AddAnnotation(object annotation)
		{
			if (annotation == null)
			{
				throw new ArgumentNullException("annotation");
			}
			if (this.annotations == null)
			{
				object obj;
				if (!(annotation is object[]))
				{
					obj = annotation;
				}
				else
				{
					(obj = new object[1])[0] = annotation;
				}
				this.annotations = obj;
				return;
			}
			object[] array = this.annotations as object[];
			if (array == null)
			{
				this.annotations = new object[]
				{
					this.annotations,
					annotation
				};
				return;
			}
			int num = 0;
			while (num < array.Length && array[num] != null)
			{
				num++;
			}
			if (num == array.Length)
			{
				Array.Resize<object>(ref array, num * 2);
				this.annotations = array;
			}
			array[num] = annotation;
		}

		/// <summary>Получение первого объекта примечаний заданного типа из данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <param name="type">Тип извлекаемого примечания.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, который содержит первый объект примечаний, который соответствует заданному типу, или <see langword="null" />, если примечаний заданного типа нет.</returns>
		// Token: 0x06000362 RID: 866 RVA: 0x0000F92C File Offset: 0x0000DB2C
		public object Annotation(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this.annotations != null)
			{
				object[] array = this.annotations as object[];
				if (array == null)
				{
					if (XHelper.IsInstanceOfType(this.annotations, type))
					{
						return this.annotations;
					}
				}
				else
				{
					foreach (object obj in array)
					{
						if (obj == null)
						{
							break;
						}
						if (XHelper.IsInstanceOfType(obj, type))
						{
							return obj;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000F99C File Offset: 0x0000DB9C
		private object AnnotationForSealedType(Type type)
		{
			if (this.annotations != null)
			{
				object[] array = this.annotations as object[];
				if (array == null)
				{
					if (this.annotations.GetType() == type)
					{
						return this.annotations;
					}
				}
				else
				{
					foreach (object obj in array)
					{
						if (obj == null)
						{
							break;
						}
						if (obj.GetType() == type)
						{
							return obj;
						}
					}
				}
			}
			return null;
		}

		/// <summary>Получение первого объекта примечаний заданного типа из данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <typeparam name="T">Тип извлекаемого примечания.</typeparam>
		/// <returns>Первый объект примечаний, который соответствует заданному типу, или <see langword="null" />, если примечаний заданного типа нет.</returns>
		// Token: 0x06000364 RID: 868 RVA: 0x0000FA00 File Offset: 0x0000DC00
		public T Annotation<T>() where T : class
		{
			if (this.annotations != null)
			{
				object[] array = this.annotations as object[];
				if (array == null)
				{
					return this.annotations as T;
				}
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						return t;
					}
				}
			}
			return default(T);
		}

		/// <summary>Получение коллекции примечаний заданного типа для данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <param name="type">Тип извлекаемого примечания.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" />
		///   <see cref="T:System.Object" />, содержащий примечания, которые соответствуют заданному типу для данного <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x06000365 RID: 869 RVA: 0x0000FA6A File Offset: 0x0000DC6A
		public IEnumerable<object> Annotations(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return this.AnnotationsIterator(type);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000FA87 File Offset: 0x0000DC87
		private IEnumerable<object> AnnotationsIterator(Type type)
		{
			if (this.annotations != null)
			{
				object[] a = this.annotations as object[];
				if (a == null)
				{
					if (XHelper.IsInstanceOfType(this.annotations, type))
					{
						yield return this.annotations;
					}
				}
				else
				{
					int num;
					for (int i = 0; i < a.Length; i = num + 1)
					{
						object obj = a[i];
						if (obj == null)
						{
							break;
						}
						if (XHelper.IsInstanceOfType(obj, type))
						{
							yield return obj;
						}
						num = i;
					}
				}
				a = null;
			}
			yield break;
		}

		/// <summary>Получение коллекции примечаний заданного типа для данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <typeparam name="T">Тип извлекаемого примечания.</typeparam>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" />, содержащий добавляемые примечания <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x06000367 RID: 871 RVA: 0x0000FA9E File Offset: 0x0000DC9E
		public IEnumerable<T> Annotations<T>() where T : class
		{
			if (this.annotations != null)
			{
				object[] a = this.annotations as object[];
				if (a == null)
				{
					T t = this.annotations as T;
					if (t != null)
					{
						yield return t;
					}
				}
				else
				{
					int num;
					for (int i = 0; i < a.Length; i = num + 1)
					{
						object obj = a[i];
						if (obj == null)
						{
							break;
						}
						T t2 = obj as T;
						if (t2 != null)
						{
							yield return t2;
						}
						num = i;
					}
				}
				a = null;
			}
			yield break;
		}

		/// <summary>Удаление примечаний заданного типа из данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <param name="type">Тип удаляемых примечаний.</param>
		// Token: 0x06000368 RID: 872 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		public void RemoveAnnotations(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this.annotations != null)
			{
				object[] array = this.annotations as object[];
				if (array == null)
				{
					if (XHelper.IsInstanceOfType(this.annotations, type))
					{
						this.annotations = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!XHelper.IsInstanceOfType(obj, type))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j == 0)
					{
						this.annotations = null;
						return;
					}
					while (j < i)
					{
						array[j++] = null;
					}
				}
			}
		}

		/// <summary>Удаление примечаний заданного типа из данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <typeparam name="T">Тип удаляемых примечаний.</typeparam>
		// Token: 0x06000369 RID: 873 RVA: 0x0000FB40 File Offset: 0x0000DD40
		public void RemoveAnnotations<T>() where T : class
		{
			if (this.annotations != null)
			{
				object[] array = this.annotations as object[];
				if (array == null)
				{
					if (this.annotations is T)
					{
						this.annotations = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!(obj is T))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j == 0)
					{
						this.annotations = null;
						return;
					}
					while (j < i)
					{
						array[j++] = null;
					}
				}
			}
		}

		/// <summary>Возникновение в случае изменения данного <see cref="T:System.Xml.Linq.XObject" /> или одного из его подчиненных элементов.</summary>
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600036A RID: 874 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		// (remove) Token: 0x0600036B RID: 875 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
		public event EventHandler<XObjectChangeEventArgs> Changed
		{
			add
			{
				if (value == null)
				{
					return;
				}
				XObjectChangeAnnotation xobjectChangeAnnotation = this.Annotation<XObjectChangeAnnotation>();
				if (xobjectChangeAnnotation == null)
				{
					xobjectChangeAnnotation = new XObjectChangeAnnotation();
					this.AddAnnotation(xobjectChangeAnnotation);
				}
				XObjectChangeAnnotation xobjectChangeAnnotation2 = xobjectChangeAnnotation;
				xobjectChangeAnnotation2.changed = (EventHandler<XObjectChangeEventArgs>)Delegate.Combine(xobjectChangeAnnotation2.changed, value);
			}
			remove
			{
				if (value == null)
				{
					return;
				}
				XObjectChangeAnnotation xobjectChangeAnnotation = this.Annotation<XObjectChangeAnnotation>();
				if (xobjectChangeAnnotation == null)
				{
					return;
				}
				XObjectChangeAnnotation xobjectChangeAnnotation2 = xobjectChangeAnnotation;
				xobjectChangeAnnotation2.changed = (EventHandler<XObjectChangeEventArgs>)Delegate.Remove(xobjectChangeAnnotation2.changed, value);
				if (xobjectChangeAnnotation.changing == null && xobjectChangeAnnotation.changed == null)
				{
					this.RemoveAnnotations<XObjectChangeAnnotation>();
				}
			}
		}

		/// <summary>Возникновение в случае возможного изменения данного <see cref="T:System.Xml.Linq.XObject" /> или одного из его подчиненных элементов.</summary>
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600036C RID: 876 RVA: 0x0000FC44 File Offset: 0x0000DE44
		// (remove) Token: 0x0600036D RID: 877 RVA: 0x0000FC84 File Offset: 0x0000DE84
		public event EventHandler<XObjectChangeEventArgs> Changing
		{
			add
			{
				if (value == null)
				{
					return;
				}
				XObjectChangeAnnotation xobjectChangeAnnotation = this.Annotation<XObjectChangeAnnotation>();
				if (xobjectChangeAnnotation == null)
				{
					xobjectChangeAnnotation = new XObjectChangeAnnotation();
					this.AddAnnotation(xobjectChangeAnnotation);
				}
				XObjectChangeAnnotation xobjectChangeAnnotation2 = xobjectChangeAnnotation;
				xobjectChangeAnnotation2.changing = (EventHandler<XObjectChangeEventArgs>)Delegate.Combine(xobjectChangeAnnotation2.changing, value);
			}
			remove
			{
				if (value == null)
				{
					return;
				}
				XObjectChangeAnnotation xobjectChangeAnnotation = this.Annotation<XObjectChangeAnnotation>();
				if (xobjectChangeAnnotation == null)
				{
					return;
				}
				XObjectChangeAnnotation xobjectChangeAnnotation2 = xobjectChangeAnnotation;
				xobjectChangeAnnotation2.changing = (EventHandler<XObjectChangeEventArgs>)Delegate.Remove(xobjectChangeAnnotation2.changing, value);
				if (xobjectChangeAnnotation.changing == null && xobjectChangeAnnotation.changed == null)
				{
					this.RemoveAnnotations<XObjectChangeAnnotation>();
				}
			}
		}

		/// <summary>Получение значения, указывающего, есть ли у данного <see cref="T:System.Xml.Linq.XObject" /> сведения строки.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Xml.Linq.XObject" /> имеет сведения строки, в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600036E RID: 878 RVA: 0x0000FCCD File Offset: 0x0000DECD
		bool IXmlLineInfo.HasLineInfo()
		{
			return this.Annotation<LineInfoAnnotation>() != null;
		}

		/// <summary>Получения номера строки, которую базовый <see cref="T:System.Xml.XmlReader" /> сообщил для данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>
		///   <see cref="T:System.Int32" />, содержащий номер строки, сообщенный <see cref="T:System.Xml.XmlReader" /> для данного <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		int IXmlLineInfo.LineNumber
		{
			get
			{
				LineInfoAnnotation lineInfoAnnotation = this.Annotation<LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.lineNumber;
				}
				return 0;
			}
		}

		/// <summary>Получения номера позиции, которую базовый <see cref="T:System.Xml.XmlReader" /> сообщил для данного <see cref="T:System.Xml.Linq.XObject" />.</summary>
		/// <returns>
		///   <see cref="T:System.Int32" />, содержащий номер позиции, сообщенный <see cref="T:System.Xml.XmlReader" /> для данного <see cref="T:System.Xml.Linq.XObject" />.</returns>
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
		int IXmlLineInfo.LinePosition
		{
			get
			{
				LineInfoAnnotation lineInfoAnnotation = this.Annotation<LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.linePosition;
				}
				return 0;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000FD17 File Offset: 0x0000DF17
		internal bool HasBaseUri
		{
			get
			{
				return this.Annotation<BaseUriAnnotation>() != null;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000FD24 File Offset: 0x0000DF24
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e)
		{
			bool result = false;
			XObject xobject = this;
			for (;;)
			{
				if (xobject == null || xobject.annotations != null)
				{
					if (xobject == null)
					{
						break;
					}
					XObjectChangeAnnotation xobjectChangeAnnotation = xobject.Annotation<XObjectChangeAnnotation>();
					if (xobjectChangeAnnotation != null)
					{
						result = true;
						if (xobjectChangeAnnotation.changed != null)
						{
							xobjectChangeAnnotation.changed(sender, e);
						}
					}
					xobject = xobject.parent;
				}
				else
				{
					xobject = xobject.parent;
				}
			}
			return result;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000FD78 File Offset: 0x0000DF78
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e)
		{
			bool result = false;
			XObject xobject = this;
			for (;;)
			{
				if (xobject == null || xobject.annotations != null)
				{
					if (xobject == null)
					{
						break;
					}
					XObjectChangeAnnotation xobjectChangeAnnotation = xobject.Annotation<XObjectChangeAnnotation>();
					if (xobjectChangeAnnotation != null)
					{
						result = true;
						if (xobjectChangeAnnotation.changing != null)
						{
							xobjectChangeAnnotation.changing(sender, e);
						}
					}
					xobject = xobject.parent;
				}
				else
				{
					xobject = xobject.parent;
				}
			}
			return result;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000FDCB File Offset: 0x0000DFCB
		internal void SetBaseUri(string baseUri)
		{
			this.AddAnnotation(new BaseUriAnnotation(baseUri));
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000FDD9 File Offset: 0x0000DFD9
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
			this.AddAnnotation(new LineInfoAnnotation(lineNumber, linePosition));
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
		internal bool SkipNotify()
		{
			XObject xobject = this;
			for (;;)
			{
				if (xobject == null || xobject.annotations != null)
				{
					if (xobject == null)
					{
						break;
					}
					if (xobject.Annotation<XObjectChangeAnnotation>() != null)
					{
						return false;
					}
					xobject = xobject.parent;
				}
				else
				{
					xobject = xobject.parent;
				}
			}
			return true;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000FE24 File Offset: 0x0000E024
		internal SaveOptions GetSaveOptionsFromAnnotations()
		{
			XObject xobject = this;
			object obj;
			for (;;)
			{
				if (xobject == null || xobject.annotations != null)
				{
					if (xobject == null)
					{
						break;
					}
					obj = xobject.AnnotationForSealedType(typeof(SaveOptions));
					if (obj != null)
					{
						goto Block_3;
					}
					xobject = xobject.parent;
				}
				else
				{
					xobject = xobject.parent;
				}
			}
			return SaveOptions.None;
			Block_3:
			return (SaveOptions)obj;
		}

		// Token: 0x040001C7 RID: 455
		internal XContainer parent;

		// Token: 0x040001C8 RID: 456
		internal object annotations;
	}
}
