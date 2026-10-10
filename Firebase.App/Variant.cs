using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x02000019 RID: 25
	internal class Variant : IDisposable
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00007C94 File Offset: 0x00005E94
		internal Variant(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007CB4 File Offset: 0x00005EB4
		internal static HandleRef getCPtr(Variant obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007CDC File Offset: 0x00005EDC
		internal static HandleRef swigRelease(Variant obj)
		{
			bool flag = obj != null;
			HandleRef result;
			if (flag)
			{
				bool flag2 = !obj.swigCMemOwn;
				if (flag2)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef handleRef = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				result = handleRef;
			}
			else
			{
				result = new HandleRef(null, IntPtr.Zero);
			}
			return result;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007D34 File Offset: 0x00005F34
		~Variant()
		{
			this.Dispose(false);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00007D68 File Offset: 0x00005F68
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00007D7C File Offset: 0x00005F7C
		public virtual void Dispose(bool disposing)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle != IntPtr.Zero;
				if (flag2)
				{
					bool flag3 = this.swigCMemOwn;
					if (flag3)
					{
						this.swigCMemOwn = false;
						AppUtilPINVOKE.delete_Variant(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007E0C File Offset: 0x0000600C
		public static Variant FromBlob(byte[] blob)
		{
			Variant variant = Variant.EmptyMutableBlob((uint)blob.Length);
			Marshal.Copy(blob, 0, variant.untyped_mutable_blob_data(), blob.Length);
			return variant;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007E3C File Offset: 0x0000603C
		public byte[] blob_as_bytes()
		{
			byte[] array = new byte[this.blob_size()];
			Marshal.Copy(this.untyped_mutable_blob_data(), array, 0, array.Length);
			return array;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007E6C File Offset: 0x0000606C
		public static Variant FromObject(object o)
		{
			bool flag = o == null;
			Variant result;
			if (flag)
			{
				result = Variant.Null();
			}
			else
			{
				bool flag2 = o is string;
				if (flag2)
				{
					result = Variant.FromString((string)o);
				}
				else
				{
					bool flag3 = o is long;
					if (flag3)
					{
						result = Variant.FromInt64((long)o);
					}
					else
					{
						bool flag4 = o is double;
						if (flag4)
						{
							result = Variant.FromDouble((double)o);
						}
						else
						{
							bool flag5 = o is bool;
							if (flag5)
							{
								result = Variant.FromBool((bool)o);
							}
							else
							{
								bool flag6 = o is byte[];
								if (flag6)
								{
									result = Variant.FromBlob((byte[])o);
								}
								else
								{
									bool flag7 = o is IList;
									if (flag7)
									{
										IList list = (IList)o;
										Variant variant = Variant.EmptyVector();
										VariantList variantList = variant.vector();
										foreach (object o2 in list)
										{
											variantList.Add(Variant.FromObject(o2));
										}
										result = variant;
									}
									else
									{
										bool flag8 = o is IDictionary;
										if (flag8)
										{
											IDictionary dictionary = (IDictionary)o;
											Variant variant2 = Variant.EmptyMap();
											VariantVariantMap variantVariantMap = variant2.map();
											foreach (object obj in dictionary)
											{
												DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
												Variant key = Variant.FromObject(dictionaryEntry.Key);
												Variant value = Variant.FromObject(dictionaryEntry.Value);
												variantVariantMap[key] = value;
											}
											result = variant2;
										}
										else
										{
											bool flag9 = o is byte || o is short || o is int || o is sbyte || o is ushort || o is uint;
											if (flag9)
											{
												result = Variant.FromInt64(Convert.ToInt64(o));
											}
											else
											{
												bool flag10 = o is float;
												if (!flag10)
												{
													string str = "Invalid type ";
													System.Type type = o.GetType();
													throw new ArgumentException(str + ((type != null) ? type.ToString() : null) + " for conversion to Variant");
												}
												result = Variant.FromDouble(Convert.ToDouble(o));
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000080EC File Offset: 0x000062EC
		public static Variant Null()
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_Null(), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000811C File Offset: 0x0000631C
		public static Variant EmptyVector()
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_EmptyVector(), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000814C File Offset: 0x0000634C
		public static Variant EmptyMap()
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_EmptyMap(), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000817C File Offset: 0x0000637C
		public static Variant EmptyMutableBlob(uint sizeBytes)
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_EmptyMutableBlob(sizeBytes), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000081AC File Offset: 0x000063AC
		public Variant.Type type()
		{
			Variant.Type result = (Variant.Type)AppUtilPINVOKE.Variant_type(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000081DC File Offset: 0x000063DC
		public bool is_string()
		{
			bool result = AppUtilPINVOKE.Variant_is_string(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000820C File Offset: 0x0000640C
		public bool is_fundamental_type()
		{
			bool result = AppUtilPINVOKE.Variant_is_fundamental_type(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000823C File Offset: 0x0000643C
		public Variant AsString()
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_AsString(this.swigCPtr), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00008270 File Offset: 0x00006470
		public uint blob_size()
		{
			uint result = AppUtilPINVOKE.Variant_blob_size(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000082A0 File Offset: 0x000064A0
		public VariantList vector()
		{
			VariantList result = new VariantList(AppUtilPINVOKE.Variant_vector__SWIG_0(this.swigCPtr), false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000082D4 File Offset: 0x000064D4
		public VariantVariantMap map()
		{
			VariantVariantMap result = new VariantVariantMap(AppUtilPINVOKE.Variant_map__SWIG_0(this.swigCPtr), false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00008308 File Offset: 0x00006508
		public long int64_value()
		{
			long result = AppUtilPINVOKE.Variant_int64_value(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00008338 File Offset: 0x00006538
		public double double_value()
		{
			double result = AppUtilPINVOKE.Variant_double_value(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00008368 File Offset: 0x00006568
		public bool bool_value()
		{
			bool result = AppUtilPINVOKE.Variant_bool_value(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00008398 File Offset: 0x00006598
		public string string_value()
		{
			string result = AppUtilPINVOKE.Variant_string_value(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000083C8 File Offset: 0x000065C8
		public static Variant FromInt64(long value)
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_FromInt64(value), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000083F8 File Offset: 0x000065F8
		public static Variant FromDouble(double value)
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_FromDouble(value), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00008428 File Offset: 0x00006628
		public static Variant FromBool(bool value)
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_FromBool(value), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00008458 File Offset: 0x00006658
		public static Variant FromString(string value)
		{
			Variant result = new Variant(AppUtilPINVOKE.Variant_FromString(value), true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00008488 File Offset: 0x00006688
		public IntPtr untyped_mutable_blob_data()
		{
			IntPtr result = AppUtilPINVOKE.Variant_untyped_mutable_blob_data(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x04000065 RID: 101
		private HandleRef swigCPtr;

		// Token: 0x04000066 RID: 102
		protected bool swigCMemOwn;

		// Token: 0x02000037 RID: 55
		public enum Type
		{
			// Token: 0x0400009A RID: 154
			Null,
			// Token: 0x0400009B RID: 155
			Int64,
			// Token: 0x0400009C RID: 156
			Double,
			// Token: 0x0400009D RID: 157
			Bool,
			// Token: 0x0400009E RID: 158
			StaticString,
			// Token: 0x0400009F RID: 159
			MutableString,
			// Token: 0x040000A0 RID: 160
			Vector,
			// Token: 0x040000A1 RID: 161
			Map,
			// Token: 0x040000A2 RID: 162
			StaticBlob,
			// Token: 0x040000A3 RID: 163
			MutableBlob
		}
	}
}
