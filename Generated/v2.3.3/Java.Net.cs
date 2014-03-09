// Copyright (C) 2014 dot42
//
// Original filename: Java.Net.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#pragma warning disable 1717
namespace Java.Net
{
		/// <summary>
		/// <para>This class represents a datagram packet which contains data either to be sent or received through a <c> DatagramSocket </c> . It holds additional information such as its source or destination host.</para><para><para>DatagramSocket </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/DatagramPacket
		/// </java-name>
		[Dot42.DexImport("java/net/DatagramPacket", AccessFlags = 49)]
		public sealed partial class DatagramPacket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> DatagramPacket </c> object to receive data up to <c> length </c> bytes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] data, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> DatagramPacket </c> object to receive data up to <c> length </c> bytes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] data, int length) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> DatagramPacket </c> object to send data to the port <c> aPort </c> of the address <c> host </c> . The <c> length </c> must be lesser than or equal to the size of <c> data </c> . The first <c>       length </c> bytes from the byte array position <c> offset </c> are sent.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIILjava/net/InetAddress;I)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] data, int offset, int length, global::Java.Net.InetAddress host, int aPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> DatagramPacket </c> object to send data to the port <c> aPort </c> of the address <c> host </c> . The <c> length </c> must be lesser than or equal to the size of <c> data </c> . The first <c>       length </c> bytes from the byte array position <c> offset </c> are sent.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIILjava/net/InetAddress;I)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] data, int offset, int length, global::Java.Net.InetAddress host, int aPort) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BILjava/net/InetAddress;I)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, global::Java.Net.InetAddress inetAddress, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BILjava/net/InetAddress;I)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, global::Java.Net.InetAddress inetAddress, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BILjava/net/SocketAddress;)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BILjava/net/SocketAddress;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/net/SocketAddress;)V", AccessFlags = 1)]
				public DatagramPacket(sbyte[] sByte, int int32, int int321, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/net/SocketAddress;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DatagramPacket(byte[] @byte, int int32, int int321, global::Java.Net.SocketAddress socketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the sender or destination IP address of this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the address from where the datagram was received or to which it is sent. </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 33)]
				public global::Java.Net.InetAddress GetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Gets the data of this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the received data or the data to be sent. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 33)]
				public sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Gets the data of this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the received data or the data to be sent. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 33, IgnoreFromJava = true)]
				public byte[] GetData() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Gets the length of the data stored in this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the received data or the data to be sent. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 33)]
				public int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the offset of the data stored in this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of the received data or the data to be sent. </para>
				/// </returns>
				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 33)]
				public int GetOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the port number of the target or sender host of this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the port number of the origin or target host. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 33)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the IP address of the target host.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAddress
				/// </java-name>
				[Dot42.DexImport("setAddress", "(Ljava/net/InetAddress;)V", AccessFlags = 33)]
				public void SetAddress(global::Java.Net.InetAddress addr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the data buffer for this datagram packet. </para>        
				/// </summary>
				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "([BII)V", AccessFlags = 33)]
				public void SetData(sbyte[] data, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the data buffer for this datagram packet. </para>        
				/// </summary>
				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public void SetData(byte[] data, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the data buffer for this datagram packet. The length of the datagram packet is set to the buffer length.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "([B)V", AccessFlags = 33)]
				public void SetData(sbyte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the data buffer for this datagram packet. The length of the datagram packet is set to the buffer length.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public void SetData(byte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the length of the datagram packet. This length plus the offset must be lesser than or equal to the buffer size.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 33)]
				public void SetLength(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the port number of the target host of this datagram packet.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPort
				/// </java-name>
				[Dot42.DexImport("setPort", "(I)V", AccessFlags = 33)]
				public void SetPort(int aPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the host address and the port to which this datagram packet is sent as a <c> SocketAddress </c> object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SocketAddress of the target host. </para>
				/// </returns>
				/// <java-name>
				/// getSocketAddress
				/// </java-name>
				[Dot42.DexImport("getSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 33)]
				public global::Java.Net.SocketAddress GetSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <summary>
				/// <para>Sets the <c> SocketAddress </c> for this datagram packet.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSocketAddress
				/// </java-name>
				[Dot42.DexImport("setSocketAddress", "(Ljava/net/SocketAddress;)V", AccessFlags = 33)]
				public void SetSocketAddress(global::Java.Net.SocketAddress sockAddr) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DatagramPacket() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the sender or destination IP address of this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the address from where the datagram was received or to which it is sent. </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				public global::Java.Net.InetAddress Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 33)]
						get{ return GetAddress(); }
				[Dot42.DexImport("setAddress", "(Ljava/net/InetAddress;)V", AccessFlags = 33)]
						set{ SetAddress(value); }
				}

				/// <summary>
				/// <para>Gets the data of this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the received data or the data to be sent. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				public byte[] Data
				{
				[Dot42.DexImport("getData", "()[B", AccessFlags = 33, IgnoreFromJava = true)]
						get{ return GetData(); }
				[Dot42.DexImport("setData", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
						set{ SetData(value); }
				}

				/// <summary>
				/// <para>Gets the length of the data stored in this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the received data or the data to be sent. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("getLength", "()I", AccessFlags = 33)]
						get{ return GetLength(); }
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 33)]
						set{ SetLength(value); }
				}

				/// <summary>
				/// <para>Gets the offset of the data stored in this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of the received data or the data to be sent. </para>
				/// </returns>
				/// <java-name>
				/// getOffset
				/// </java-name>
				public int Offset
				{
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 33)]
						get{ return GetOffset(); }
				}

				/// <summary>
				/// <para>Gets the port number of the target or sender host of this datagram packet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the port number of the origin or target host. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 33)]
						get{ return GetPort(); }
				[Dot42.DexImport("setPort", "(I)V", AccessFlags = 33)]
						set{ SetPort(value); }
				}

				/// <summary>
				/// <para>Gets the host address and the port to which this datagram packet is sent as a <c> SocketAddress </c> object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SocketAddress of the target host. </para>
				/// </returns>
				/// <java-name>
				/// getSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress SocketAddress
				{
				[Dot42.DexImport("getSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 33)]
						get{ return GetSocketAddress(); }
				[Dot42.DexImport("setSocketAddress", "(Ljava/net/SocketAddress;)V", AccessFlags = 33)]
						set{ SetSocketAddress(value); }
				}

		}

		/// <summary>
		/// <para>This <c> PortUnreachableException </c> will be thrown if an <c>   ICMP_Port_Unreachable </c> message has been received.</para><para>Most applications <b>should not</b> catch this exception; it is more robust to catch the superclass <c> SocketException </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/net/PortUnreachableException
		/// </java-name>
		[Dot42.DexImport("java/net/PortUnreachableException", AccessFlags = 33)]
		public partial class PortUnreachableException : global::Java.Net.SocketException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PortUnreachableException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PortUnreachableException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A response cache entry. A <c> CacheResponse </c> object provides an <c>   InputStream </c> to access the response body and a <c> Map </c> for the response headers. <para>ResponseCache </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/CacheResponse
		/// </java-name>
		[Dot42.DexImport("java/net/CacheResponse", AccessFlags = 1057)]
		public abstract partial class CacheResponse
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CacheResponse() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an <c> InputStream </c> to access the response body.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> InputStream </c> which can be used to fetch the response body. </para>
				/// </returns>
				/// <java-name>
				/// getBody
				/// </java-name>
				[Dot42.DexImport("getBody", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				public abstract global::Java.Io.InputStream GetBody() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an immutable <c> Map </c> which contains the response headers information. Note that <c> URLConnection </c> may need the original headers to be able to fully reconstruct the response. In particular, failure to provide a mapping from null to the original HTTP status line will prevent an <c> HttpURLConnection </c> from returning the correct response code. See URLConnection#getHeaderFields.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an immutable <c> Map </c> which contains the response headers. </para>
				/// </returns>
				/// <java-name>
				/// getHeaders
				/// </java-name>
				[Dot42.DexImport("getHeaders", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public abstract global::Java.Util.IMap<string, global::Java.Util.IList<string>> GetHeaders() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an <c> InputStream </c> to access the response body.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> InputStream </c> which can be used to fetch the response body. </para>
				/// </returns>
				/// <java-name>
				/// getBody
				/// </java-name>
				public global::Java.Io.InputStream Body
				{
				[Dot42.DexImport("getBody", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get{ return GetBody(); }
				}

				/// <summary>
				/// <para>Returns an immutable <c> Map </c> which contains the response headers information. Note that <c> URLConnection </c> may need the original headers to be able to fully reconstruct the response. In particular, failure to provide a mapping from null to the original HTTP status line will prevent an <c> HttpURLConnection </c> from returning the correct response code. See URLConnection#getHeaderFields.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an immutable <c> Map </c> which contains the response headers. </para>
				/// </returns>
				/// <java-name>
				/// getHeaders
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Util.IList<string>> Headers
				{
				[Dot42.DexImport("getHeaders", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
						get{ return GetHeaders(); }
				}

		}

		/// <summary>
		/// <para>This class is used to represent a network interface of the local device. An interface is defined by its address and a platform dependent name. The class provides methods to get all information about the available interfaces of the system or to identify the local interface of a joined multicast group. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/NetworkInterface
		/// </java-name>
		[Dot42.DexImport("java/net/NetworkInterface", AccessFlags = 49)]
		public sealed partial class NetworkInterface
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NetworkInterface() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this network interface (such as "eth0" or "lo"). </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns an enumeration of the addresses bound to this network interface. </para>        
				/// </summary>
				/// <java-name>
				/// getInetAddresses
				/// </java-name>
				[Dot42.DexImport("getInetAddresses", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/net/InetAddress;>;")]
				public global::Java.Util.IEnumeration<global::Java.Net.InetAddress> GetInetAddresses() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.InetAddress>);
				}

				/// <summary>
				/// <para>Returns a human-readable name for this network interface. On Android, this is the same string as returned by getName. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetDisplayName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> NetworkInterface </c> corresponding to the named network interface, or null if no interface has this name.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getByName
				/// </java-name>
				[Dot42.DexImport("getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;", AccessFlags = 9)]
				public static global::Java.Net.NetworkInterface GetByName(string interfaceName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <summary>
				/// <para>Returns the <c> NetworkInterface </c> corresponding to the given address, or null if no interface has this address.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getByInetAddress
				/// </java-name>
				[Dot42.DexImport("getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;", AccessFlags = 9)]
				public static global::Java.Net.NetworkInterface GetByInetAddress(global::Java.Net.InetAddress address) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <summary>
				/// <para>Gets a list of all network interfaces available on the local system or <c> null </c> if no interface is available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of <c> NetworkInterface </c> instances representing the available interfaces. </para>
				/// </returns>
				/// <java-name>
				/// getNetworkInterfaces
				/// </java-name>
				[Dot42.DexImport("getNetworkInterfaces", "()Ljava/util/Enumeration;", AccessFlags = 9, Signature = "()Ljava/util/Enumeration<Ljava/net/NetworkInterface;>;")]
				public static global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface> GetNetworkInterfaces() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface>);
				}

				/// <summary>
				/// <para>Compares the specified object to this <c> NetworkInterface </c> and returns whether they are equal or not. The object must be an instance of <c> NetworkInterface </c> with the same name, display name, and list of interface addresses.</para><para><para>hashCode() </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c>               NetworkInterface </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hash code for this <c> NetworkInterface </c> . Since the name should be unique for each network interface the hash code is generated using the name. </para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a string containing details of this network interface. The exact format is deliberately unspecified. Callers that require a specific format should build a string themselves, using this class' accessor methods. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a List of the InterfaceAddresses for this network interface. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getInterfaceAddresses
				/// </java-name>
				[Dot42.DexImport("getInterfaceAddresses", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/net/InterfaceAddress;>;")]
				public global::Java.Util.IList<global::Java.Net.InterfaceAddress> GetInterfaceAddresses() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Net.InterfaceAddress>);
				}

				/// <summary>
				/// <para>Returns an enumeration of all the sub-interfaces of this network interface. Sub-interfaces are also known as virtual interfaces.</para><para>For example, <c> eth0:1 </c> would be a sub-interface of <c> eth0 </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an Enumeration of all the sub-interfaces of this network interface </para>
				/// </returns>
				/// <java-name>
				/// getSubInterfaces
				/// </java-name>
				[Dot42.DexImport("getSubInterfaces", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/net/NetworkInterface;>;")]
				public global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface> GetSubInterfaces() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface>);
				}

				/// <summary>
				/// <para>Returns the parent NetworkInterface of this interface if this is a sub-interface, or null if it's a physical (non virtual) interface.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the NetworkInterface this interface is attached to. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
				public global::Java.Net.NetworkInterface GetParent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <summary>
				/// <para>Returns true if this network interface is up.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the interface is up. </para>
				/// </returns>
				/// <java-name>
				/// isUp
				/// </java-name>
				[Dot42.DexImport("isUp", "()Z", AccessFlags = 1)]
				public bool IsUp() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this network interface is a loopback interface.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the interface is a loopback interface. </para>
				/// </returns>
				/// <java-name>
				/// isLoopback
				/// </java-name>
				[Dot42.DexImport("isLoopback", "()Z", AccessFlags = 1)]
				public bool IsLoopback() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this network interface is a point-to-point interface. (For example, a PPP connection using a modem.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the interface is point-to-point. </para>
				/// </returns>
				/// <java-name>
				/// isPointToPoint
				/// </java-name>
				[Dot42.DexImport("isPointToPoint", "()Z", AccessFlags = 1)]
				public bool IsPointToPoint() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this network interface supports multicast.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// supportsMulticast
				/// </java-name>
				[Dot42.DexImport("supportsMulticast", "()Z", AccessFlags = 1)]
				public bool SupportsMulticast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hardware address of the interface, if it has one, or null otherwise.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getHardwareAddress
				/// </java-name>
				[Dot42.DexImport("getHardwareAddress", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetHardwareAddress() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the hardware address of the interface, if it has one, or null otherwise.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getHardwareAddress
				/// </java-name>
				[Dot42.DexImport("getHardwareAddress", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetHardwareAddress() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the Maximum Transmission Unit (MTU) of this interface.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the MTU for the interface. </para>
				/// </returns>
				/// <java-name>
				/// getMTU
				/// </java-name>
				[Dot42.DexImport("getMTU", "()I", AccessFlags = 1)]
				public int GetMTU() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns true if this interface is a virtual interface (also called a sub-interface). Virtual interfaces are, on some systems, interfaces created as a child of a physical interface and given different settings (like address or MTU). Usually the name of the interface will the name of the parent followed by a colon (:) and a number identifying the child, since there can be several virtual interfaces attached to a single physical interface.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this interface is a virtual interface. </para>
				/// </returns>
				/// <java-name>
				/// isVirtual
				/// </java-name>
				[Dot42.DexImport("isVirtual", "()Z", AccessFlags = 1)]
				public bool IsVirtual() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the name of this network interface (such as "eth0" or "lo"). </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Returns an enumeration of the addresses bound to this network interface. </para>        
				/// </summary>
				/// <java-name>
				/// getInetAddresses
				/// </java-name>
				public global::Java.Util.IEnumeration<global::Java.Net.InetAddress> InetAddresses
				{
				[Dot42.DexImport("getInetAddresses", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/net/InetAddress;>;")]
						get{ return GetInetAddresses(); }
				}

				/// <summary>
				/// <para>Returns a human-readable name for this network interface. On Android, this is the same string as returned by getName. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				public string DisplayName
				{
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDisplayName(); }
				}

				/// <summary>
				/// <para>Gets a list of all network interfaces available on the local system or <c> null </c> if no interface is available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of <c> NetworkInterface </c> instances representing the available interfaces. </para>
				/// </returns>
				/// <java-name>
				/// getNetworkInterfaces
				/// </java-name>
				public static global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface> NetworkInterfaces
				{
				[Dot42.DexImport("getNetworkInterfaces", "()Ljava/util/Enumeration;", AccessFlags = 9, Signature = "()Ljava/util/Enumeration<Ljava/net/NetworkInterface;>;")]
						get{ return GetNetworkInterfaces(); }
				}

				/// <summary>
				/// <para>Returns a List of the InterfaceAddresses for this network interface. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getInterfaceAddresses
				/// </java-name>
				public global::Java.Util.IList<global::Java.Net.InterfaceAddress> InterfaceAddresses
				{
				[Dot42.DexImport("getInterfaceAddresses", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/net/InterfaceAddress;>;")]
						get{ return GetInterfaceAddresses(); }
				}

				/// <summary>
				/// <para>Returns an enumeration of all the sub-interfaces of this network interface. Sub-interfaces are also known as virtual interfaces.</para><para>For example, <c> eth0:1 </c> would be a sub-interface of <c> eth0 </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an Enumeration of all the sub-interfaces of this network interface </para>
				/// </returns>
				/// <java-name>
				/// getSubInterfaces
				/// </java-name>
				public global::Java.Util.IEnumeration<global::Java.Net.NetworkInterface> SubInterfaces
				{
				[Dot42.DexImport("getSubInterfaces", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/net/NetworkInterface;>;")]
						get{ return GetSubInterfaces(); }
				}

				/// <summary>
				/// <para>Returns the parent NetworkInterface of this interface if this is a sub-interface, or null if it's a physical (non virtual) interface.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the NetworkInterface this interface is attached to. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Java.Net.NetworkInterface Parent
				{
				[Dot42.DexImport("getParent", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
						get{ return GetParent(); }
				}

				/// <summary>
				/// <para>Returns the hardware address of the interface, if it has one, or null otherwise.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getHardwareAddress
				/// </java-name>
				public byte[] HardwareAddress
				{
				[Dot42.DexImport("getHardwareAddress", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetHardwareAddress(); }
				}

				/// <summary>
				/// <para>Returns the Maximum Transmission Unit (MTU) of this interface.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the MTU for the interface. </para>
				/// </returns>
				/// <java-name>
				/// getMTU
				/// </java-name>
				public int MTU
				{
				[Dot42.DexImport("getMTU", "()I", AccessFlags = 1)]
						get{ return GetMTU(); }
				}

		}

		/// <summary>
		/// <para>This immutable class is a data structure that encapsulates username and password which is used by the <c> Authenticator </c> class.</para><para><para>Authenticator </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/PasswordAuthentication
		/// </java-name>
		[Dot42.DexImport("java/net/PasswordAuthentication", AccessFlags = 49)]
		public sealed partial class PasswordAuthentication
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates an instance of a password authentication with a specified username and password.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;[C)V", AccessFlags = 1)]
				public PasswordAuthentication(string userName, char[] password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets a clone of the password stored by this instance. The user is responsible to finalize the returned array if the password clone is no longer needed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the copied password. </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1)]
				public char[] GetPassword() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				/// <para>Gets the username stored by this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the stored username. </para>
				/// </returns>
				/// <java-name>
				/// getUserName
				/// </java-name>
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetUserName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PasswordAuthentication() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets a clone of the password stored by this instance. The user is responsible to finalize the returned array if the password clone is no longer needed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the copied password. </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				public char[] Password
				{
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1)]
						get{ return GetPassword(); }
				}

				/// <summary>
				/// <para>Gets the username stored by this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the stored username. </para>
				/// </returns>
				/// <java-name>
				/// getUserName
				/// </java-name>
				public string UserName
				{
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUserName(); }
				}

		}

		/// <summary>
		/// <para>A connection to a URL for reading or writing. For HTTP connections, see HttpURLConnection for documentation of HTTP-specific features.</para><para>For example, to retrieve <c>   ftp://mirror.csclub.uwaterloo.ca/index.html </c> : <pre>        URL url = new URL("ftp://mirror.csclub.uwaterloo.ca/index.html");
		/// 
		///      URLConnection urlConnection = url.openConnection();
		/// 
		///      InputStream in = new BufferedInputStream(urlConnection.getInputStream());
		/// 
		///      try {
		/// 
		///        readStream(in);
		/// 
		///      } finally {
		/// 
		///        in.close();
		/// 
		///      }
		/// 
		///  </pre></para><para><c> URLConnection </c> must be configured before it has connected to the remote resource. Instances of <c> URLConnection </c> are not reusable: you must use a different instance for each connection to a resource.</para><para><h3>Timeouts</h3></para><para><c> URLConnection </c> supports two timeouts: a connect timeout and a read timeout. By default, operations never time out.</para><para><h3>Built-in Protocols</h3></para><para><ul><li><para><b>File</b><br></br> Resources from the local file system can be loaded using <c> file: </c> URIs. File connections can only be used for input. </para></li><li><para><b>FTP</b><br></br> File Transfer Protocol () is supported, but with no public subclass. FTP connections can be used for input or output but not both. </para><para>By default, FTP connections will be made using <c> anonymous </c> as the username and the empty string as the password. Specify alternate usernames and passwords in the URL: <c>        ftp://username:password@host/path </c> . </para></li><li><para><b>HTTP and HTTPS</b><br></br> Refer to the HttpURLConnection and HttpsURLConnection subclasses. </para></li><li><para><b>Jar</b><br></br> Refer to the JarURLConnection subclass. </para></li></ul></para><para><h3>Registering Additional Protocols</h3></para><para>Use URL#setURLStreamHandlerFactory to register handlers for other protocol types. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URLConnection
		/// </java-name>
		[Dot42.DexImport("java/net/URLConnection", AccessFlags = 1057)]
		public abstract partial class URLConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The URL which represents the remote target of this <c> URLConnection </c> . </para>        
				/// </summary>
				/// <java-name>
				/// url
				/// </java-name>
				[Dot42.DexImport("url", "Ljava/net/URL;", AccessFlags = 4)]
				protected internal global::Java.Net.URL Url;
				/// <summary>
				/// <para>The data must be modified more recently than this time in milliseconds since January 1, 1970, GMT to be transmitted. </para>        
				/// </summary>
				/// <java-name>
				/// ifModifiedSince
				/// </java-name>
				[Dot42.DexImport("ifModifiedSince", "J", AccessFlags = 4)]
				protected internal long IfModifiedSince;
				/// <summary>
				/// <para>Specifies whether the using of caches is enabled or the data has to be recent for every request. </para>        
				/// </summary>
				/// <java-name>
				/// useCaches
				/// </java-name>
				[Dot42.DexImport("useCaches", "Z", AccessFlags = 4)]
				protected internal bool UseCaches;
				/// <summary>
				/// <para>Specifies whether this <c> URLConnection </c> is already connected to the remote resource. If this field is set to <c> true </c> the flags for setting up the connection are not changeable anymore. </para>        
				/// </summary>
				/// <java-name>
				/// connected
				/// </java-name>
				[Dot42.DexImport("connected", "Z", AccessFlags = 4)]
				protected internal bool Connected;
				/// <summary>
				/// <para>Specifies whether this <c> URLConnection </c> allows sending data. </para>        
				/// </summary>
				/// <java-name>
				/// doOutput
				/// </java-name>
				[Dot42.DexImport("doOutput", "Z", AccessFlags = 4)]
				protected internal bool DoOutput;
				/// <summary>
				/// <para>Specifies whether this <c> URLConnection </c> allows receiving data. </para>        
				/// </summary>
				/// <java-name>
				/// doInput
				/// </java-name>
				[Dot42.DexImport("doInput", "Z", AccessFlags = 4)]
				protected internal bool DoInput;
				/// <summary>
				/// <para>Unused by Android. This field can be accessed via getAllowUserInteraction and setAllowUserInteraction. </para>        
				/// </summary>
				/// <java-name>
				/// allowUserInteraction
				/// </java-name>
				[Dot42.DexImport("allowUserInteraction", "Z", AccessFlags = 4)]
				protected internal bool AllowUserInteraction;
				/// <summary>
				/// <para>Creates a new <c> URLConnection </c> instance pointing to the resource specified by the given URL.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal URLConnection(global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Opens a connection to the resource. This method will <b>not</b> reconnect to a resource after the initial connection has been closed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1025)]
				public abstract void Connect() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns <c> allowUserInteraction </c> . Unused by Android. </para>        
				/// </summary>
				/// <java-name>
				/// getAllowUserInteraction
				/// </java-name>
				[Dot42.DexImport("getAllowUserInteraction", "()Z", AccessFlags = 1)]
				public virtual bool GetAllowUserInteraction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an object representing the content of the resource this <c>       URLConnection </c> is connected to. First, it attempts to get the content type from the method <c> getContentType() </c> which looks at the response header field "Content-Type". If none is found it will guess the content type from the filename extension. If that fails the stream itself will be used to guess the content type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the content representing object. </para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetContent() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns an object representing the content of the resource this <c>       URLConnection </c> is connected to. First, it attempts to get the content type from the method <c> getContentType() </c> which looks at the response header field "Content-Type". If none is found it will guess the content type from the filename extension. If that fails the stream itself will be used to guess the content type. The content type must match with one of the list <c> types </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the content representing object or <c> null </c> if the content type does not match with one of the specified types. </para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetContent(global::System.Type[] types) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the content encoding type specified by the response header field <c> content-encoding </c> or <c> null </c> if this field is not set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the response header field <c> content-encoding </c> . </para>
				/// </returns>
				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				[Dot42.DexImport("getContentEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetContentEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the content length in bytes specified by the response header field <c> content-length </c> or <c> -1 </c> if this field is not set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the response header field <c> content-length </c> . </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()I", AccessFlags = 1)]
				public virtual int GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the MIME-type of the content specified by the response header field <c> content-type </c> or <c> null </c> if type is unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the response header field <c> content-type </c> . </para>
				/// </returns>
				/// <java-name>
				/// getContentType
				/// </java-name>
				[Dot42.DexImport("getContentType", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetContentType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the timestamp when this response has been sent as a date in milliseconds since January 1, 1970 GMT or <c> 0 </c> if this timestamp is unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sending timestamp of the current response. </para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "()J", AccessFlags = 1)]
				public virtual long GetDate() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the default value of <c> allowUserInteraction </c> . Unused by Android. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultAllowUserInteraction
				/// </java-name>
				[Dot42.DexImport("getDefaultAllowUserInteraction", "()Z", AccessFlags = 9)]
				public static bool GetDefaultAllowUserInteraction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns null.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use getRequestProperty </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getDefaultRequestProperty
				/// </java-name>
				[Dot42.DexImport("getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetDefaultRequestProperty(string field) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the default setting whether this connection allows using caches.</para><para><para>useCaches </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the default setting <c> defaultUseCaches </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDefaultUseCaches
				/// </java-name>
				[Dot42.DexImport("getDefaultUseCaches", "()Z", AccessFlags = 1)]
				public virtual bool GetDefaultUseCaches() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value of the option <c> doInput </c> which specifies whether this connection allows to receive data.</para><para><para>doInput </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this connection allows input, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getDoInput
				/// </java-name>
				[Dot42.DexImport("getDoInput", "()Z", AccessFlags = 1)]
				public virtual bool GetDoInput() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value of the option <c> doOutput </c> which specifies whether this connection allows to send data.</para><para><para>doOutput </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this connection allows output, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getDoOutput
				/// </java-name>
				[Dot42.DexImport("getDoOutput", "()Z", AccessFlags = 1)]
				public virtual bool GetDoOutput() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the timestamp when this response will be expired in milliseconds since January 1, 1970 GMT or <c> 0 </c> if this timestamp is unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the response header field <c> expires </c> . </para>
				/// </returns>
				/// <java-name>
				/// getExpiration
				/// </java-name>
				[Dot42.DexImport("getExpiration", "()J", AccessFlags = 1)]
				public virtual long GetExpiration() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the table which is used by all <c> URLConnection </c> instances to determine the MIME-type according to a file extension.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file name map to determine the MIME-type. </para>
				/// </returns>
				/// <java-name>
				/// getFileNameMap
				/// </java-name>
				[Dot42.DexImport("getFileNameMap", "()Ljava/net/FileNameMap;", AccessFlags = 9)]
				public static global::Java.Net.IFileNameMap GetFileNameMap() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.IFileNameMap);
				}

				/// <summary>
				/// <para>Returns the header value at the field position <c> pos </c> or <c> null </c> if the header has fewer than <c> pos </c> fields. The base implementation of this method returns always <c> null </c> .</para><para>Some implementations (notably <c> HttpURLConnection </c> ) include a mapping for the null key; in HTTP's case, this maps to the HTTP status line and is treated as being at position 0 when indexing into the header fields.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the field at position <c> pos </c> . </para>
				/// </returns>
				/// <java-name>
				/// getHeaderField
				/// </java-name>
				[Dot42.DexImport("getHeaderField", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHeaderField(int pos) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns an unmodifiable map of the response-header fields and values. The response-header field names are the key values of the map. The map values are lists of header field values associated with a particular key name.</para><para>Some implementations (notably <c> HttpURLConnection </c> ) include a mapping for the null key; in HTTP's case, this maps to the HTTP status line and is treated as being at position 0 when indexing into the header fields.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response-header representing generic map. </para>
				/// </returns>
				/// <java-name>
				/// getHeaderFields
				/// </java-name>
				[Dot42.DexImport("getHeaderFields", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public virtual global::Java.Util.IMap<string, global::Java.Util.IList<string>> GetHeaderFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Util.IList<string>>);
				}

				/// <summary>
				/// <para>Returns an unmodifiable map of general request properties used by this connection. The request property names are the key values of the map. The map values are lists of property values of the corresponding key name.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the request-property representing generic map. </para>
				/// </returns>
				/// <java-name>
				/// getRequestProperties
				/// </java-name>
				[Dot42.DexImport("getRequestProperties", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public virtual global::Java.Util.IMap<string, global::Java.Util.IList<string>> GetRequestProperties() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Util.IList<string>>);
				}

				/// <summary>
				/// <para>Adds the given property to the request header. Existing properties with the same name will not be overwritten by this method.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// addRequestProperty
				/// </java-name>
				[Dot42.DexImport("addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddRequestProperty(string field, string newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the header value at the field position <c> pos </c> or <c> null </c> if the header has fewer than <c> pos </c> fields. The base implementation of this method returns always <c> null </c> .</para><para>Some implementations (notably <c> HttpURLConnection </c> ) include a mapping for the null key; in HTTP's case, this maps to the HTTP status line and is treated as being at position 0 when indexing into the header fields.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the field at position <c> pos </c> . </para>
				/// </returns>
				/// <java-name>
				/// getHeaderField
				/// </java-name>
				[Dot42.DexImport("getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHeaderField(string pos) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the specified header value as a date in milliseconds since January 1, 1970 GMT. Returns the <c> defaultValue </c> if no such header field could be found.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the specified header field as a date in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getHeaderFieldDate
				/// </java-name>
				[Dot42.DexImport("getHeaderFieldDate", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public virtual long GetHeaderFieldDate(string field, long defaultValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the specified header value as a number. Returns the <c>       defaultValue </c> if no such header field could be found or the value could not be parsed as an <c> Integer </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the specified header field as a number. </para>
				/// </returns>
				/// <java-name>
				/// getHeaderFieldInt
				/// </java-name>
				[Dot42.DexImport("getHeaderFieldInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int GetHeaderFieldInt(string field, int defaultValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the name of the header field at the given position <c> posn </c> or <c> null </c> if there are fewer than <c> posn </c> fields. The base implementation of this method returns always <c> null </c> .</para><para>Some implementations (notably <c> HttpURLConnection </c> ) include a mapping for the null key; in HTTP's case, this maps to the HTTP status line and is treated as being at position 0 when indexing into the header fields.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the header field name at the given position. </para>
				/// </returns>
				/// <java-name>
				/// getHeaderFieldKey
				/// </java-name>
				[Dot42.DexImport("getHeaderFieldKey", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHeaderFieldKey(int posn) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the point of time since when the data must be modified to be transmitted. Some protocols transmit data only if it has been modified more recently than a particular time.</para><para><para>ifModifiedSince </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time in milliseconds since January 1, 1970 GMT. </para>
				/// </returns>
				/// <java-name>
				/// getIfModifiedSince
				/// </java-name>
				[Dot42.DexImport("getIfModifiedSince", "()J", AccessFlags = 1)]
				public virtual long GetIfModifiedSince() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns an <c> InputStream </c> for reading data from the resource pointed by this <c> URLConnection </c> . It throws an UnknownServiceException by default. This method must be overridden by its subclasses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the InputStream to read data from. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Returns the value of the response header field <c> last-modified </c> or <c> 0 </c> if this value is not set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the <c> last-modified </c> header field. </para>
				/// </returns>
				/// <java-name>
				/// getLastModified
				/// </java-name>
				[Dot42.DexImport("getLastModified", "()J", AccessFlags = 1)]
				public virtual long GetLastModified() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns an <c> OutputStream </c> for writing data to this <c>       URLConnection </c> . It throws an <c> UnknownServiceException </c> by default. This method must be overridden by its subclasses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the OutputStream to write data. </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <summary>
				/// <para>Returns a <c> Permission </c> object representing all needed permissions to open this connection. The returned permission object depends on the state of the connection and will be <c> null </c> if no permissions are necessary. By default, this method returns <c> AllPermission </c> . Subclasses should overwrite this method to return an appropriate permission object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the permission object representing the needed permissions to open this connection. </para>
				/// </returns>
				/// <java-name>
				/// getPermission
				/// </java-name>
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
				public virtual global::Java.Security.Permission GetPermission() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Permission);
				}

				/// <summary>
				/// <para>Returns the value of the request header property specified by {code field} or <c> null </c> if there is no field with this name. The base implementation of this method returns always <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the property. </para>
				/// </returns>
				/// <java-name>
				/// getRequestProperty
				/// </java-name>
				[Dot42.DexImport("getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetRequestProperty(string field) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the URL represented by this <c> URLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL of this connection. </para>
				/// </returns>
				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "()Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL GetURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <summary>
				/// <para>Returns the value of the flag which specifies whether this <c>       URLConnection </c> allows to use caches.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if using caches is allowed, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getUseCaches
				/// </java-name>
				[Dot42.DexImport("getUseCaches", "()Z", AccessFlags = 1)]
				public virtual bool GetUseCaches() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Determines the MIME-type of the given resource <c> url </c> by resolving the filename extension with the internal FileNameMap. Any fragment identifier is removed before processing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the guessed content type or <c> null </c> if the type could not be determined. </para>
				/// </returns>
				/// <java-name>
				/// guessContentTypeFromName
				/// </java-name>
				[Dot42.DexImport("guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GuessContentTypeFromName(string url) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Determines the MIME-type of the resource represented by the input stream <c> is </c> by reading its first few characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the guessed content type or <c> null </c> if the type could not be determined. </para>
				/// </returns>
				/// <java-name>
				/// guessContentTypeFromStream
				/// </java-name>
				[Dot42.DexImport("guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GuessContentTypeFromStream(global::Java.Io.InputStream @is) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets <c> allowUserInteraction </c> . Unused by Android. </para>        
				/// </summary>
				/// <java-name>
				/// setAllowUserInteraction
				/// </java-name>
				[Dot42.DexImport("setAllowUserInteraction", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllowUserInteraction(bool newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the internally used content handler factory. The content factory can only be set once during the lifetime of the application.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentHandlerFactory
				/// </java-name>
				[Dot42.DexImport("setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V", AccessFlags = 41)]
				public static void SetContentHandlerFactory(global::Java.Net.IContentHandlerFactory contentFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the default value for <c> allowUserInteraction </c> . Unused by Android. </para>        
				/// </summary>
				/// <java-name>
				/// setDefaultAllowUserInteraction
				/// </java-name>
				[Dot42.DexImport("setDefaultAllowUserInteraction", "(Z)V", AccessFlags = 9)]
				public static void SetDefaultAllowUserInteraction(bool allows) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Does nothing.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use URLConnection#setRequestProperty(String, String). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultRequestProperty
				/// </java-name>
				[Dot42.DexImport("setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetDefaultRequestProperty(string field, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the default value for the flag indicating whether this connection allows to use caches. Existing <c> URLConnection </c> s are unaffected.</para><para><para>useCaches </para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultUseCaches
				/// </java-name>
				[Dot42.DexImport("setDefaultUseCaches", "(Z)V", AccessFlags = 1)]
				public virtual void SetDefaultUseCaches(bool newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the flag indicating whether this <c> URLConnection </c> allows input. It cannot be set after the connection is established.</para><para><para>doInput </para></para>        
				/// </summary>
				/// <java-name>
				/// setDoInput
				/// </java-name>
				[Dot42.DexImport("setDoInput", "(Z)V", AccessFlags = 1)]
				public virtual void SetDoInput(bool newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the flag indicating whether this <c> URLConnection </c> allows output. It cannot be set after the connection is established.</para><para><para>doOutput </para></para>        
				/// </summary>
				/// <java-name>
				/// setDoOutput
				/// </java-name>
				[Dot42.DexImport("setDoOutput", "(Z)V", AccessFlags = 1)]
				public virtual void SetDoOutput(bool newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the internal map which is used by all <c> URLConnection </c> instances to determine the MIME-type according to a filename extension.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFileNameMap
				/// </java-name>
				[Dot42.DexImport("setFileNameMap", "(Ljava/net/FileNameMap;)V", AccessFlags = 9)]
				public static void SetFileNameMap(global::Java.Net.IFileNameMap map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the point of time since when the data must be modified to be transmitted. Some protocols transmit data only if it has been modified more recently than a particular time. The data will be transmitted regardless of its timestamp if this option is set to <c> 0 </c> .</para><para><para>ifModifiedSince </para></para>        
				/// </summary>
				/// <java-name>
				/// setIfModifiedSince
				/// </java-name>
				[Dot42.DexImport("setIfModifiedSince", "(J)V", AccessFlags = 1)]
				public virtual void SetIfModifiedSince(long newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the specified request header field. The value will only be used by the current <c> URLConnection </c> instance. This method can only be called before the connection is established.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRequestProperty
				/// </java-name>
				[Dot42.DexImport("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetRequestProperty(string field, string newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the flag indicating whether this connection allows to use caches or not. This method can only be called prior to the connection establishment.</para><para><para>useCaches </para></para>        
				/// </summary>
				/// <java-name>
				/// setUseCaches
				/// </java-name>
				[Dot42.DexImport("setUseCaches", "(Z)V", AccessFlags = 1)]
				public virtual void SetUseCaches(bool newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the maximum time in milliseconds to wait while connecting. Connecting to a server will fail with a SocketTimeoutException if the timeout elapses before a connection is established. The default value of <c> 0 </c> causes us to do a blocking connect. This does not mean we will never time out, but it probably means you'll get a TCP timeout after several minutes.</para><para><b>Warning:</b> if the hostname resolves to multiple IP addresses, this client will try each in  order. If connecting to each of these addresses fails, multiple timeouts will elapse before the connect attempt throws an exception. Host names that support both IPv6 and IPv4 always have at least 2 IP addresses.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setConnectTimeout
				/// </java-name>
				[Dot42.DexImport("setConnectTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetConnectTimeout(int timeoutMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the connect timeout in milliseconds. (See {setConnectTimeout}.) </para>        
				/// </summary>
				/// <java-name>
				/// getConnectTimeout
				/// </java-name>
				[Dot42.DexImport("getConnectTimeout", "()I", AccessFlags = 1)]
				public virtual int GetConnectTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the maximum time to wait for an input stream read to complete before giving up. Reading will fail with a SocketTimeoutException if the timeout elapses before data becomes available. The default value of <c> 0 </c> disables read timeouts; read attempts will block indefinitely.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setReadTimeout
				/// </java-name>
				[Dot42.DexImport("setReadTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetReadTimeout(int timeoutMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the read timeout in milliseconds, or <c> 0 </c> if reads never timeout. </para>        
				/// </summary>
				/// <java-name>
				/// getReadTimeout
				/// </java-name>
				[Dot42.DexImport("getReadTimeout", "()I", AccessFlags = 1)]
				public virtual int GetReadTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the string representation containing the name of this class and the URL.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this <c> URLConnection </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URLConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns <c> allowUserInteraction </c> . Unused by Android. </para>        
				/// </summary>
				/// <java-name>
				/// getAllowUserInteraction
				/// </java-name>
				public bool IsAllowUserInteraction
				{
				[Dot42.DexImport("getAllowUserInteraction", "()Z", AccessFlags = 1)]
						get{ return GetAllowUserInteraction(); }
				[Dot42.DexImport("setAllowUserInteraction", "(Z)V", AccessFlags = 1)]
						set{ SetAllowUserInteraction(value); }
				}

				/// <summary>
				/// <para>Returns an object representing the content of the resource this <c>       URLConnection </c> is connected to. First, it attempts to get the content type from the method <c> getContentType() </c> which looks at the response header field "Content-Type". If none is found it will guess the content type from the filename extension. If that fails the stream itself will be used to guess the content type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the content representing object. </para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public object Content
				{
				[Dot42.DexImport("getContent", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

				/// <summary>
				/// <para>Returns the content encoding type specified by the response header field <c> content-encoding </c> or <c> null </c> if this field is not set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the response header field <c> content-encoding </c> . </para>
				/// </returns>
				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				public string ContentEncoding
				{
				[Dot42.DexImport("getContentEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetContentEncoding(); }
				}

				/// <summary>
				/// <para>Returns the content length in bytes specified by the response header field <c> content-length </c> or <c> -1 </c> if this field is not set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the response header field <c> content-length </c> . </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				public int ContentLength
				{
				[Dot42.DexImport("getContentLength", "()I", AccessFlags = 1)]
						get{ return GetContentLength(); }
				}

				/// <summary>
				/// <para>Returns the MIME-type of the content specified by the response header field <c> content-type </c> or <c> null </c> if type is unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the response header field <c> content-type </c> . </para>
				/// </returns>
				/// <java-name>
				/// getContentType
				/// </java-name>
				public string ContentType
				{
				[Dot42.DexImport("getContentType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetContentType(); }
				}

				/// <summary>
				/// <para>Returns the timestamp when this response has been sent as a date in milliseconds since January 1, 1970 GMT or <c> 0 </c> if this timestamp is unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sending timestamp of the current response. </para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				public long Date
				{
				[Dot42.DexImport("getDate", "()J", AccessFlags = 1)]
						get{ return GetDate(); }
				}

				/// <summary>
				/// <para>Returns the default value of <c> allowUserInteraction </c> . Unused by Android. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultAllowUserInteraction
				/// </java-name>
				public static bool IsDefaultAllowUserInteraction
				{
				[Dot42.DexImport("getDefaultAllowUserInteraction", "()Z", AccessFlags = 9)]
						get{ return GetDefaultAllowUserInteraction(); }
				[Dot42.DexImport("setDefaultAllowUserInteraction", "(Z)V", AccessFlags = 9)]
						set{ SetDefaultAllowUserInteraction(value); }
				}

				/// <summary>
				/// <para>Returns the default setting whether this connection allows using caches.</para><para><para>useCaches </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the default setting <c> defaultUseCaches </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDefaultUseCaches
				/// </java-name>
				public bool IsDefaultUseCaches
				{
				[Dot42.DexImport("getDefaultUseCaches", "()Z", AccessFlags = 1)]
						get{ return GetDefaultUseCaches(); }
				[Dot42.DexImport("setDefaultUseCaches", "(Z)V", AccessFlags = 1)]
						set{ SetDefaultUseCaches(value); }
				}

				/// <summary>
				/// <para>Returns the value of the option <c> doInput </c> which specifies whether this connection allows to receive data.</para><para><para>doInput </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this connection allows input, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getDoInput
				/// </java-name>
				public bool IsDoInput
				{
				[Dot42.DexImport("getDoInput", "()Z", AccessFlags = 1)]
						get{ return GetDoInput(); }
				[Dot42.DexImport("setDoInput", "(Z)V", AccessFlags = 1)]
						set{ SetDoInput(value); }
				}

				/// <summary>
				/// <para>Returns the value of the option <c> doOutput </c> which specifies whether this connection allows to send data.</para><para><para>doOutput </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this connection allows output, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getDoOutput
				/// </java-name>
				public bool IsDoOutput
				{
				[Dot42.DexImport("getDoOutput", "()Z", AccessFlags = 1)]
						get{ return GetDoOutput(); }
				[Dot42.DexImport("setDoOutput", "(Z)V", AccessFlags = 1)]
						set{ SetDoOutput(value); }
				}

				/// <summary>
				/// <para>Returns the timestamp when this response will be expired in milliseconds since January 1, 1970 GMT or <c> 0 </c> if this timestamp is unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the response header field <c> expires </c> . </para>
				/// </returns>
				/// <java-name>
				/// getExpiration
				/// </java-name>
				public long Expiration
				{
				[Dot42.DexImport("getExpiration", "()J", AccessFlags = 1)]
						get{ return GetExpiration(); }
				}

				/// <summary>
				/// <para>Returns the table which is used by all <c> URLConnection </c> instances to determine the MIME-type according to a file extension.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file name map to determine the MIME-type. </para>
				/// </returns>
				/// <java-name>
				/// getFileNameMap
				/// </java-name>
				public static global::Java.Net.IFileNameMap FileNameMap
				{
				[Dot42.DexImport("getFileNameMap", "()Ljava/net/FileNameMap;", AccessFlags = 9)]
						get{ return GetFileNameMap(); }
				[Dot42.DexImport("setFileNameMap", "(Ljava/net/FileNameMap;)V", AccessFlags = 9)]
						set{ SetFileNameMap(value); }
				}

				/// <summary>
				/// <para>Returns an unmodifiable map of the response-header fields and values. The response-header field names are the key values of the map. The map values are lists of header field values associated with a particular key name.</para><para>Some implementations (notably <c> HttpURLConnection </c> ) include a mapping for the null key; in HTTP's case, this maps to the HTTP status line and is treated as being at position 0 when indexing into the header fields.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response-header representing generic map. </para>
				/// </returns>
				/// <java-name>
				/// getHeaderFields
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Util.IList<string>> HeaderFields
				{
				[Dot42.DexImport("getHeaderFields", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
						get{ return GetHeaderFields(); }
				}

				/// <summary>
				/// <para>Returns an unmodifiable map of general request properties used by this connection. The request property names are the key values of the map. The map values are lists of property values of the corresponding key name.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the request-property representing generic map. </para>
				/// </returns>
				/// <java-name>
				/// getRequestProperties
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Util.IList<string>> RequestProperties
				{
				[Dot42.DexImport("getRequestProperties", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
						get{ return GetRequestProperties(); }
				}

				/// <summary>
				/// <para>Returns an <c> InputStream </c> for reading data from the resource pointed by this <c> URLConnection </c> . It throws an UnknownServiceException by default. This method must be overridden by its subclasses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the InputStream to read data from. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				public global::Java.Io.InputStream InputStream
				{
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetInputStream(); }
				}

				/// <summary>
				/// <para>Returns the value of the response header field <c> last-modified </c> or <c> 0 </c> if this value is not set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the <c> last-modified </c> header field. </para>
				/// </returns>
				/// <java-name>
				/// getLastModified
				/// </java-name>
				public long LastModified
				{
				[Dot42.DexImport("getLastModified", "()J", AccessFlags = 1)]
						get{ return GetLastModified(); }
				}

				/// <summary>
				/// <para>Returns an <c> OutputStream </c> for writing data to this <c>       URLConnection </c> . It throws an <c> UnknownServiceException </c> by default. This method must be overridden by its subclasses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the OutputStream to write data. </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public global::Java.Io.OutputStream OutputStream
				{
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return GetOutputStream(); }
				}

				/// <summary>
				/// <para>Returns a <c> Permission </c> object representing all needed permissions to open this connection. The returned permission object depends on the state of the connection and will be <c> null </c> if no permissions are necessary. By default, this method returns <c> AllPermission </c> . Subclasses should overwrite this method to return an appropriate permission object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the permission object representing the needed permissions to open this connection. </para>
				/// </returns>
				/// <java-name>
				/// getPermission
				/// </java-name>
				public global::Java.Security.Permission Permission
				{
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
						get{ return GetPermission(); }
				}

				/// <summary>
				/// <para>Returns the URL represented by this <c> URLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL of this connection. </para>
				/// </returns>
				/// <java-name>
				/// getURL
				/// </java-name>
				public global::Java.Net.URL URL
				{
				[Dot42.DexImport("getURL", "()Ljava/net/URL;", AccessFlags = 1)]
						get{ return GetURL(); }
				}

				/// <summary>
				/// <para>Returns the value of the flag which specifies whether this <c>       URLConnection </c> allows to use caches.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if using caches is allowed, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getUseCaches
				/// </java-name>
				public bool IsUseCaches
				{
				[Dot42.DexImport("getUseCaches", "()Z", AccessFlags = 1)]
						get{ return GetUseCaches(); }
				[Dot42.DexImport("setUseCaches", "(Z)V", AccessFlags = 1)]
						set{ SetUseCaches(value); }
				}

				/// <summary>
				/// <para>Returns the connect timeout in milliseconds. (See {setConnectTimeout}.) </para>        
				/// </summary>
				/// <java-name>
				/// getConnectTimeout
				/// </java-name>
				public int ConnectTimeout
				{
				[Dot42.DexImport("getConnectTimeout", "()I", AccessFlags = 1)]
						get{ return GetConnectTimeout(); }
				[Dot42.DexImport("setConnectTimeout", "(I)V", AccessFlags = 1)]
						set{ SetConnectTimeout(value); }
				}

				/// <summary>
				/// <para>Returns the read timeout in milliseconds, or <c> 0 </c> if reads never timeout. </para>        
				/// </summary>
				/// <java-name>
				/// getReadTimeout
				/// </java-name>
				public int ReadTimeout
				{
				[Dot42.DexImport("getReadTimeout", "()I", AccessFlags = 1)]
						get{ return GetReadTimeout(); }
				[Dot42.DexImport("setReadTimeout", "(I)V", AccessFlags = 1)]
						set{ SetReadTimeout(value); }
				}

		}

		/// <summary>
		/// <para>Caches <c> URLConnection </c> responses. </para><para>The system's default cache can be set using setDefault. If URLConnection#getUseCaches returns true, <c> URLConnection </c> will use the default response cache, if one has been set. </para><para>Although <c> URLConnection </c> will always call put, the specific <c> ResponseCache </c> implementation gets to decide what will actually be cached, and for how long. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/ResponseCache
		/// </java-name>
		[Dot42.DexImport("java/net/ResponseCache", AccessFlags = 1057)]
		public abstract partial class ResponseCache
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResponseCache() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the system's default response cache, or null. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljava/net/ResponseCache;", AccessFlags = 9)]
				public static global::Java.Net.ResponseCache GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ResponseCache);
				}

				/// <summary>
				/// <para>Sets the system's default response cache. Use null to remove the response cache. </para>        
				/// </summary>
				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/net/ResponseCache;)V", AccessFlags = 9)]
				public static void SetDefault(global::Java.Net.ResponseCache responseCache) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the cached response corresponding to the given request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> CacheResponse </c> object if the request is available in the cache or <c> null </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;", AccessFlags = 1025, Signature = "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/util/List" +
    "<Ljava/lang/String;>;>;)Ljava/net/CacheResponse;")]
				public abstract global::Java.Net.CacheResponse Get(global::System.Uri uri, string requestMethod, global::Java.Util.IMap<string, global::Java.Util.IList<string>> requestHeaders) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allows the protocol handler to cache data after retrieving resources. The <c> ResponseCache </c> decides whether the resource data should be cached or not. If so, this method returns a <c> CacheRequest </c> to write the resource data to. Otherwise, this method returns <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a CacheRequest object with a WriteableByteChannel if the resource has to be cached, <c> null </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;", AccessFlags = 1025)]
				public abstract global::Java.Net.CacheRequest Put(global::System.Uri uri, global::Java.Net.URLConnection connection) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the system's default response cache, or null. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Net.ResponseCache Default
				{
				[Dot42.DexImport("getDefault", "()Ljava/net/ResponseCache;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljava/net/ResponseCache;)V", AccessFlags = 9)]
						set{ SetDefault(value); }
				}

		}

		/// <summary>
		/// <para>The <c> NoRouteToHostException </c> will be thrown while attempting to connect to a remote host but the host cannot be reached for instance because of a badly configured router or a blocking firewall.</para><para>Most applications <b>should not</b> catch this exception; it is more robust to catch the superclass <c> SocketException </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/net/NoRouteToHostException
		/// </java-name>
		[Dot42.DexImport("java/net/NoRouteToHostException", AccessFlags = 33)]
		public partial class NoRouteToHostException : global::Java.Net.SocketException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoRouteToHostException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoRouteToHostException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para><c> CacheRequest </c> is a kind of channel for storing resource data in the <c> ResponseCache </c> . A protocol handler calls the <c> OutputStream </c> which is provided by the <c> CacheRequest </c> object, to store the resource data into the cache. It also allows the user to interrupt and abort the current store operation by calling the method <c> abort </c> . If an <c>   IOException </c> occurs while reading the response or writing data to the cache, the current cache store operation is abandoned.</para><para><para>ResponseCache </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/CacheRequest
		/// </java-name>
		[Dot42.DexImport("java/net/CacheRequest", AccessFlags = 1057)]
		public abstract partial class CacheRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This implementation does nothing. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CacheRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Aborts the current cache operation. If an <c> IOException </c> occurs while reading the response or writing resource data to the cache, the current cache store operation is aborted. </para>        
				/// </summary>
				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				public abstract void Abort() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an <c> OutputStream </c> which is used to write the response body.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> OutputStream </c> which is used to write the response body. </para>
				/// </returns>
				/// <java-name>
				/// getBody
				/// </java-name>
				[Dot42.DexImport("getBody", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
				public abstract global::Java.Io.OutputStream GetBody() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an <c> OutputStream </c> which is used to write the response body.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> OutputStream </c> which is used to write the response body. </para>
				/// </returns>
				/// <java-name>
				/// getBody
				/// </java-name>
				public global::Java.Io.OutputStream Body
				{
				[Dot42.DexImport("getBody", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
						get{ return GetBody(); }
				}

		}

		/// <summary>
		/// <para>Defines a scheme for mapping a filename type to a MIME content type. Mainly used by <c> URLStreamHandler </c> for determining the right content handler to handle the resource.</para><para><para>ContentHandler </para><simplesectsep></simplesectsep><para>URLConnection::getFileNameMap() </para><simplesectsep></simplesectsep><para>URLConnection::guessContentTypeFromName(String) </para><simplesectsep></simplesectsep><para>URLStreamHandler </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/FileNameMap
		/// </java-name>
		[Dot42.DexImport("java/net/FileNameMap", AccessFlags = 1537)]
		public partial interface IFileNameMap
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the MIME type (such as "text/plain") for the given filename, or null. </para>        
				/// </summary>
				/// <java-name>
				/// getContentTypeFor
				/// </java-name>
				[Dot42.DexImport("getContentTypeFor", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetContentTypeFor(string filename) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This interface defines a factory for socket implementations. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/SocketImplFactory
		/// </java-name>
		[Dot42.DexImport("java/net/SocketImplFactory", AccessFlags = 1537)]
		public partial interface ISocketImplFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SocketImpl </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created <c> SocketImpl </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// createSocketImpl
				/// </java-name>
				[Dot42.DexImport("createSocketImpl", "()Ljava/net/SocketImpl;", AccessFlags = 1025)]
				global::Java.Net.SocketImpl CreateSocketImpl() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>CookiePolicy has three pre-defined policy. They are ACCEPT_ALL, ACCEPT_NONE and ACCEPT_ORIGINAL_SERVER respectively. They are used to decide which cookies should be accepted and which should not be.</para><para>See  sections 3.3 and 7 for more detail.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/CookiePolicy
		/// </java-name>
		[Dot42.DexImport("java/net/CookiePolicy", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICookiePolicyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A pre-defined policy, accepts all cookies. </para>        
				/// </summary>
				/// <java-name>
				/// ACCEPT_ALL
				/// </java-name>
				[Dot42.DexImport("ACCEPT_ALL", "Ljava/net/CookiePolicy;", AccessFlags = 25)]
				public static readonly global::Java.Net.ICookiePolicy ACCEPT_ALL;
				/// <summary>
				/// <para>A pre-defined policy, accepts no cookies at all. </para>        
				/// </summary>
				/// <java-name>
				/// ACCEPT_NONE
				/// </java-name>
				[Dot42.DexImport("ACCEPT_NONE", "Ljava/net/CookiePolicy;", AccessFlags = 25)]
				public static readonly global::Java.Net.ICookiePolicy ACCEPT_NONE;
				/// <summary>
				/// <para>A pre-defined policy, only accepts cookies from original server. </para>        
				/// </summary>
				/// <java-name>
				/// ACCEPT_ORIGINAL_SERVER
				/// </java-name>
				[Dot42.DexImport("ACCEPT_ORIGINAL_SERVER", "Ljava/net/CookiePolicy;", AccessFlags = 25)]
				public static readonly global::Java.Net.ICookiePolicy ACCEPT_ORIGINAL_SERVER;
		}

		/// <summary>
		/// <para>CookiePolicy has three pre-defined policy. They are ACCEPT_ALL, ACCEPT_NONE and ACCEPT_ORIGINAL_SERVER respectively. They are used to decide which cookies should be accepted and which should not be.</para><para>See  sections 3.3 and 7 for more detail.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/CookiePolicy
		/// </java-name>
		[Dot42.DexImport("java/net/CookiePolicy", AccessFlags = 1537)]
		public partial interface ICookiePolicy
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This method is used to determine whether or not the specified cookie should be accepted.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this cookie should be accepted; false otherwise </para>
				/// </returns>
				/// <java-name>
				/// shouldAccept
				/// </java-name>
				[Dot42.DexImport("shouldAccept", "(Ljava/net/URI;Ljava/net/HttpCookie;)Z", AccessFlags = 1025)]
				bool ShouldAccept(global::System.Uri uri, global::Java.Net.HttpCookie cookie) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class represents a server-side socket that waits for incoming client connections. A <c> ServerSocket </c> handles the requests and sends back an appropriate reply. The actual tasks that a server socket must accomplish are implemented by an internal <c> SocketImpl </c> instance. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/ServerSocket
		/// </java-name>
		[Dot42.DexImport("java/net/ServerSocket", AccessFlags = 33)]
		public partial class ServerSocket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new unbound <c> ServerSocket </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ServerSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> ServerSocket </c> instance bound to the given <c> port </c> . The backlog is set to 50. If <c> port == 0 </c> , a port will be assigned by the OS.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ServerSocket(int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> ServerSocket </c> instance bound to the given <c> port </c> . The backlog is set to <c> backlog </c> . If <c> port == 0 </c> , a port will be assigned by the OS.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public ServerSocket(int port, int backlog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> ServerSocket </c> instance bound to the given <c> localAddress </c> and <c> port </c> . The backlog is set to <c> backlog </c> . If <c> localAddress == null </c> , the ANY address is used. If <c> port == 0 </c> , a port will be assigned by the OS.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILjava/net/InetAddress;)V", AccessFlags = 1)]
				public ServerSocket(int port, int backlog, global::Java.Net.InetAddress localAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Waits for an incoming request and blocks until the connection is opened. This method returns a socket object representing the just opened connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connection representing socket. </para>
				/// </returns>
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "()Ljava/net/Socket;", AccessFlags = 1)]
				public virtual global::Java.Net.Socket Accept() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				/// <para>Closes this server socket and its implementation. Any attempt to connect to this socket thereafter will fail.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the local IP address of this server socket or <c> null </c> if the socket is unbound. This is useful for multihomed hosts.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address of this server socket. </para>
				/// </returns>
				/// <java-name>
				/// getInetAddress
				/// </java-name>
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetInetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Gets the local port of this server socket or <c> -1 </c> if the socket is unbound.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local port this server is listening on. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
				public virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the socket accept timeout.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
				public virtual int GetSoTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Invokes the server socket implementation to accept a connection on the given socket <c> aSocket </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// implAccept
				/// </java-name>
				[Dot42.DexImport("implAccept", "(Ljava/net/Socket;)V", AccessFlags = 20)]
				protected internal void ImplAccept(global::Java.Net.Socket aSocket) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the server socket implementation factory of this instance. This method may only be invoked with sufficient security privilege and only once during the application lifetime.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSocketFactory
				/// </java-name>
				[Dot42.DexImport("setSocketFactory", "(Ljava/net/SocketImplFactory;)V", AccessFlags = 41)]
				public static void SetSocketFactory(global::Java.Net.ISocketImplFactory aFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the accept timeout in milliseconds for this socket. This accept timeout defines the period the socket will block waiting to accept a connection before throwing an <c> InterruptedIOException </c> . The value <c> 0 </c> (default) is used to set an infinite timeout. To have effect this option must be set before the blocking method was called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
				public virtual void SetSoTimeout(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a textual representation of this server socket including the address, port and the state. The port field is set to <c> 0 </c> if there is no connection to the server socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the textual socket representation. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Binds this server socket to the given local socket address with a maximum backlog of 50 unaccepted connections. If the <c> localAddr </c> is set to <c> null </c> the socket will be bound to an available local address on any free port of the system.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Bind(global::Java.Net.SocketAddress localAddr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Binds this server socket to the given local socket address. If the <c> localAddr </c> is set to <c> null </c> the socket will be bound to an available local address on any free port of the system.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/SocketAddress;I)V", AccessFlags = 1)]
				public virtual void Bind(global::Java.Net.SocketAddress localAddr, int backlog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the local socket address of this server socket or <c> null </c> if the socket is unbound. This is useful on multihomed hosts.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local socket address and port this socket is bound to. </para>
				/// </returns>
				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetLocalSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <summary>
				/// <para>Returns whether this server socket is bound to a local address and port or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this socket is bound, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isBound
				/// </java-name>
				[Dot42.DexImport("isBound", "()Z", AccessFlags = 1)]
				public virtual bool IsBound() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this server socket is closed or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this socket is closed, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the value for the socket option <c> SocketOptions.SO_REUSEADDR </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setReuseAddress
				/// </java-name>
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
				public virtual void SetReuseAddress(bool reuse) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the value of the socket option <c> SocketOptions.SO_REUSEADDR </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the option is enabled, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
				public virtual bool GetReuseAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// setReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 1)]
				public virtual void SetReceiveBufferSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 1)]
				public virtual int GetReceiveBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this socket's <c> ServerSocketChannel </c> , if one exists. A channel is available only if this socket wraps a channel. (That is, you can go from a channel to a socket and back again, but you can't go from an arbitrary socket to a channel.) In practice, this means that the socket must have been created by java.nio.channels.ServerSocketChannel#open. </para>        
				/// </summary>
				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/ServerSocketChannel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.ServerSocketChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.ServerSocketChannel);
				}

				/// <summary>
				/// <para>Sets performance preferences for connection time, latency and bandwidth. </para><para>This method does currently nothing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPerformancePreferences
				/// </java-name>
				[Dot42.DexImport("setPerformancePreferences", "(III)V", AccessFlags = 1)]
				public virtual void SetPerformancePreferences(int connectionTime, int latency, int bandwidth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the local IP address of this server socket or <c> null </c> if the socket is unbound. This is useful for multihomed hosts.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address of this server socket. </para>
				/// </returns>
				/// <java-name>
				/// getInetAddress
				/// </java-name>
				public global::Java.Net.InetAddress InetAddress
				{
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetInetAddress(); }
				}

				/// <summary>
				/// <para>Gets the local port of this server socket or <c> -1 </c> if the socket is unbound.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local port this server is listening on. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				public int LocalPort
				{
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
						get{ return GetLocalPort(); }
				}

				/// <summary>
				/// <para>Gets the socket accept timeout.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				public int SoTimeout
				{
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
						get{ return GetSoTimeout(); }
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
						set{ SetSoTimeout(value); }
				}

				/// <summary>
				/// <para>Gets the local socket address of this server socket or <c> null </c> if the socket is unbound. This is useful on multihomed hosts.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local socket address and port this socket is bound to. </para>
				/// </returns>
				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress LocalSocketAddress
				{
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetLocalSocketAddress(); }
				}

				/// <summary>
				/// <para>Gets the value of the socket option <c> SocketOptions.SO_REUSEADDR </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the option is enabled, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				public bool IsReuseAddress
				{
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
						get{ return GetReuseAddress(); }
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
						set{ SetReuseAddress(value); }
				}

				/// <summary>
				/// <para>Returns this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				public int ReceiveBufferSize
				{
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 1)]
						get{ return GetReceiveBufferSize(); }
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 1)]
						set{ SetReceiveBufferSize(value); }
				}

				/// <summary>
				/// <para>Returns this socket's <c> ServerSocketChannel </c> , if one exists. A channel is available only if this socket wraps a channel. (That is, you can go from a channel to a socket and back again, but you can't go from an arbitrary socket to a channel.) In practice, this means that the socket must have been created by java.nio.channels.ServerSocketChannel#open. </para>        
				/// </summary>
				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.ServerSocketChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/ServerSocketChannel;", AccessFlags = 1)]
						get{ return GetChannel(); }
				}

		}

		/// <summary>
		/// <para>This class provides a way to manage cookies with a HTTP protocol handler. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/CookieHandler
		/// </java-name>
		[Dot42.DexImport("java/net/CookieHandler", AccessFlags = 1057)]
		public abstract partial class CookieHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CookieHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the system-wide cookie handler or <c> null </c> if not set. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljava/net/CookieHandler;", AccessFlags = 9)]
				public static global::Java.Net.CookieHandler GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.CookieHandler);
				}

				/// <summary>
				/// <para>Sets the system-wide cookie handler. </para>        
				/// </summary>
				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/net/CookieHandler;)V", AccessFlags = 9)]
				public static void SetDefault(global::Java.Net.CookieHandler cHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets all cookies for a specific URI from the cookie cache.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an unchangeable map of all appropriate cookies. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;", AccessFlags = 1025, Signature = "(Ljava/net/URI;Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String" +
    ";>;>;)Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public abstract global::Java.Util.IMap<string, global::Java.Util.IList<string>> Get(global::System.Uri uri, global::Java.Util.IMap<string, global::Java.Util.IList<string>> requestHeaders) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets all cookies of a specific URI in the <c> responseHeaders </c> into the cookie cache.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/net/URI;Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/net/URI;Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String" +
    ";>;>;)V")]
				public abstract void Put(global::System.Uri uri, global::Java.Util.IMap<string, global::Java.Util.IList<string>> responseHeaders) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the system-wide cookie handler or <c> null </c> if not set. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Net.CookieHandler Default
				{
				[Dot42.DexImport("getDefault", "()Ljava/net/CookieHandler;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljava/net/CookieHandler;)V", AccessFlags = 9)]
						set{ SetDefault(value); }
				}

		}

		/// <summary>
		/// <para>Converts internationalized domain names between Unicode and the ASCII Compatible Encoding (ACE) representation.</para><para>See  for full details.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/IDN
		/// </java-name>
		[Dot42.DexImport("java/net/IDN", AccessFlags = 49)]
		public sealed partial class IDN
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>When set, allows IDN to process unassigned unicode points. </para>        
				/// </summary>
				/// <java-name>
				/// ALLOW_UNASSIGNED
				/// </java-name>
				[Dot42.DexImport("ALLOW_UNASSIGNED", "I", AccessFlags = 25)]
				public const int ALLOW_UNASSIGNED = 1;
				/// <summary>
				/// <para>When set, ASCII strings are checked against  and . </para>        
				/// </summary>
				/// <java-name>
				/// USE_STD3_ASCII_RULES
				/// </java-name>
				[Dot42.DexImport("USE_STD3_ASCII_RULES", "I", AccessFlags = 25)]
				public const int USE_STD3_ASCII_RULES = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal IDN() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Transform a Unicode String to ASCII Compatible Encoding String according to the algorithm defined in .</para><para>If the transformation fails (because the input is not a valid IDN), an exception will be thrown.</para><para>This method can handle either an individual label or an entire domain name. In the latter case, the separators are: U+002E (full stop), U+3002 (ideographic full stop), U+FF0E (fullwidth full stop), and U+FF61 (halfwidth ideographic full stop). All of these will become U+002E (full stop) in the result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ACE name </para>
				/// </returns>
				/// <java-name>
				/// toASCII
				/// </java-name>
				[Dot42.DexImport("toASCII", "(Ljava/lang/String;I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToASCII(string input, int flags) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Equivalent to <c> toASCII(input, 0) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ACE name </para>
				/// </returns>
				/// <java-name>
				/// toASCII
				/// </java-name>
				[Dot42.DexImport("toASCII", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToASCII(string input) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Translates a string from ASCII Compatible Encoding (ACE) to Unicode according to the algorithm defined in .</para><para>Unlike <c> toASCII </c> , this transformation cannot fail.</para><para>This method can handle either an individual label or an entire domain name. In the latter case, the separators are: U+002E (full stop), U+3002 (ideographic full stop), U+FF0E (fullwidth full stop), and U+FF61 (halfwidth ideographic full stop).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode name </para>
				/// </returns>
				/// <java-name>
				/// toUnicode
				/// </java-name>
				[Dot42.DexImport("toUnicode", "(Ljava/lang/String;I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToUnicode(string input, int flags) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Equivalent to <c> toUnicode(input, 0) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode name </para>
				/// </returns>
				/// <java-name>
				/// toUnicode
				/// </java-name>
				[Dot42.DexImport("toUnicode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToUnicode(string input) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>This exception is thrown when a timeout expired on a socket <c> read </c> or <c> accept </c> operation. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/SocketTimeoutException
		/// </java-name>
		[Dot42.DexImport("java/net/SocketTimeoutException", AccessFlags = 33)]
		public partial class SocketTimeoutException : global::Java.Io.InterruptedIOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketTimeoutException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SocketTimeoutException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines a factory which creates an <c> URLStreamHandler </c> for a specified protocol. It is used by the class <c> URL </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URLStreamHandlerFactory
		/// </java-name>
		[Dot42.DexImport("java/net/URLStreamHandlerFactory", AccessFlags = 1537)]
		public partial interface IURLStreamHandlerFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> URLStreamHandler </c> instance for the given <c>       protocol </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created handler. </para>
				/// </returns>
				/// <java-name>
				/// createURLStreamHandler
				/// </java-name>
				[Dot42.DexImport("createURLStreamHandler", "(Ljava/lang/String;)Ljava/net/URLStreamHandler;", AccessFlags = 1025)]
				global::Java.Net.URLStreamHandler CreateURLStreamHandler(string protocol) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class is the base of all streaming socket implementation classes. Streaming sockets are wrapped by two classes, <c> ServerSocket </c> and <c> Socket </c> at the server and client end of a connection. At the server, there are two types of sockets engaged in communication, the <c>   ServerSocket </c> on a well known port (referred to as listener) used to establish a connection and the resulting <c> Socket </c> (referred to as host). </para>    
		/// </summary>
		/// <java-name>
		/// java/net/SocketImpl
		/// </java-name>
		[Dot42.DexImport("java/net/SocketImpl", AccessFlags = 1057)]
		public abstract partial class SocketImpl : global::Java.Net.ISocketOptions
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The remote address this socket is connected to. </para>        
				/// </summary>
				/// <java-name>
				/// address
				/// </java-name>
				[Dot42.DexImport("address", "Ljava/net/InetAddress;", AccessFlags = 4)]
				protected internal global::Java.Net.InetAddress Address;
				/// <summary>
				/// <para>The remote port this socket is connected to. </para>        
				/// </summary>
				/// <java-name>
				/// port
				/// </java-name>
				[Dot42.DexImport("port", "I", AccessFlags = 4)]
				protected internal int Port;
				/// <summary>
				/// <para>The file descriptor of this socket. </para>        
				/// </summary>
				/// <java-name>
				/// fd
				/// </java-name>
				[Dot42.DexImport("fd", "Ljava/io/FileDescriptor;", AccessFlags = 4)]
				protected internal global::Java.Io.FileDescriptor Fd;
				/// <summary>
				/// <para>The local port this socket is connected to. </para>        
				/// </summary>
				/// <java-name>
				/// localport
				/// </java-name>
				[Dot42.DexImport("localport", "I", AccessFlags = 4)]
				protected internal int Localport;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Waits for an incoming request and blocks until the connection is opened on the given socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "(Ljava/net/SocketImpl;)V", AccessFlags = 1028)]
				protected internal abstract void Accept(global::Java.Net.SocketImpl newSocket) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the available number of bytes which are readable from this socket without blocking.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes that may be read without blocking. </para>
				/// </returns>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1028)]
				protected internal abstract int Available() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Binds this socket to the specified local host address and port number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/InetAddress;I)V", AccessFlags = 1028)]
				protected internal abstract void Bind(global::Java.Net.InetAddress address, int port) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Closes this socket. This makes later access invalid.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1028)]
				protected internal abstract void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Connects this socket to the specified remote host address and port number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/lang/String;I)V", AccessFlags = 1028)]
				protected internal abstract void Connect(string address, int port) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Connects this socket to the specified remote host address and port number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/InetAddress;I)V", AccessFlags = 1028)]
				protected internal abstract void Connect(global::Java.Net.InetAddress address, int port) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a new unconnected socket. The argument <c> isStreaming </c> defines whether the new socket is a streaming or a datagram socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Z)V", AccessFlags = 1028)]
				protected internal abstract void Create(bool isStreaming) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the file descriptor of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file descriptor of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 4)]
				protected internal virtual global::Java.Io.FileDescriptor GetFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileDescriptor);
				}

				/// <summary>
				/// <para>Gets the remote address this socket is connected to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote address of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getInetAddress
				/// </java-name>
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.InetAddress GetInetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Gets the input stream of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the input stream of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1028)]
				protected internal abstract global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the local port number of this socket. The field is initialized to <c> -1 </c> and upon demand will go to the IP stack to get the bound value. See the class comment for the context of the local port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local port number this socket is bound to. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 4)]
				protected internal virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the output stream of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the output stream of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1028)]
				protected internal abstract global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the remote port number of this socket. This value is not meaningful when this instance is wrapped by a <c> ServerSocket </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote port this socket is connected to. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 4)]
				protected internal virtual int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Listens for connection requests on this streaming socket. Incoming connection requests are queued up to the limit specified by <c>       backlog </c> . Additional requests are rejected. This method may only be invoked on stream sockets.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// listen
				/// </java-name>
				[Dot42.DexImport("listen", "(I)V", AccessFlags = 1028)]
				protected internal abstract void Listen(int backlog) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of the socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the textual representation of this socket. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Closes the input channel of this socket.</para><para>This default implementation always throws an IOException to indicate that the subclass should have overridden this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shutdownInput
				/// </java-name>
				[Dot42.DexImport("shutdownInput", "()V", AccessFlags = 4)]
				protected internal virtual void ShutdownInput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes the output channel of this socket.</para><para>This default implementation always throws an IOException to indicate that the subclass should have overridden this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shutdownOutput
				/// </java-name>
				[Dot42.DexImport("shutdownOutput", "()V", AccessFlags = 4)]
				protected internal virtual void ShutdownOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Connects this socket to the specified remote host address and port number.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;I)V", AccessFlags = 1028)]
				protected internal abstract void Connect(global::Java.Net.SocketAddress address, int port) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether the socket supports urgent data or not. Subclasses should override this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> false </c> because subclasses must override this method. </para>
				/// </returns>
				/// <java-name>
				/// supportsUrgentData
				/// </java-name>
				[Dot42.DexImport("supportsUrgentData", "()Z", AccessFlags = 4)]
				protected internal virtual bool SupportsUrgentData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sends the single byte of urgent data on the socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sendUrgentData
				/// </java-name>
				[Dot42.DexImport("sendUrgentData", "(I)V", AccessFlags = 1028)]
				protected internal abstract void SendUrgentData(int value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets performance preference for connection time, latency and bandwidth. Does nothing by default.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPerformancePreferences
				/// </java-name>
				[Dot42.DexImport("setPerformancePreferences", "(III)V", AccessFlags = 4)]
				protected internal virtual void SetPerformancePreferences(int connectionTime, int latency, int bandwidth) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("java/net/SocketOptions", "getOption", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetOption(int optID) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("java/net/SocketOptions", "setOption", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				public virtual void SetOption(int optID, object val) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				/// <para>Gets the file descriptor of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the file descriptor of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				protected internal global::Java.Io.FileDescriptor FileDescriptor
				{
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 4)]
						get{ return GetFileDescriptor(); }
				}

				/// <summary>
				/// <para>Gets the remote address this socket is connected to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote address of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getInetAddress
				/// </java-name>
				protected internal global::Java.Net.InetAddress InetAddress
				{
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 4)]
						get{ return GetInetAddress(); }
				}

				/// <summary>
				/// <para>Gets the input stream of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the input stream of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				protected internal global::Java.Io.InputStream InputStream
				{
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1028)]
						get{ return GetInputStream(); }
				}

				/// <summary>
				/// <para>Gets the local port number of this socket. The field is initialized to <c> -1 </c> and upon demand will go to the IP stack to get the bound value. See the class comment for the context of the local port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local port number this socket is bound to. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				protected internal int LocalPort
				{
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 4)]
						get{ return GetLocalPort(); }
				}

				/// <summary>
				/// <para>Gets the output stream of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the output stream of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				protected internal global::Java.Io.OutputStream OutputStream
				{
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1028)]
						get{ return GetOutputStream(); }
				}

		}

		/// <summary>
		/// <para>The abstract class <c> URLStreamHandler </c> is the base for all classes which can handle the communication with a URL object over a particular protocol type. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URLStreamHandler
		/// </java-name>
		[Dot42.DexImport("java/net/URLStreamHandler", AccessFlags = 1057)]
		public abstract partial class URLStreamHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public URLStreamHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Establishes a new connection to the resource specified by the URL <c>       u </c> . Since different protocols also have unique ways of connecting, it must be overwritten by the subclass.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the opened URLConnection to the specified resource. </para>
				/// </returns>
				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;", AccessFlags = 1028)]
				protected internal abstract global::Java.Net.URLConnection OpenConnection(global::Java.Net.URL u) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Establishes a new connection to the resource specified by the URL <c>       u </c> using the given <c> proxy </c> . Since different protocols also have unique ways of connecting, it must be overwritten by the subclass.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the opened URLConnection to the specified resource. </para>
				/// </returns>
				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Ljava/net/URL;Ljava/net/Proxy;)Ljava/net/URLConnection;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.URLConnection OpenConnection(global::Java.Net.URL u, global::Java.Net.Proxy proxy) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLConnection);
				}

				/// <summary>
				/// <para>Parses the clear text URL in <c> str </c> into a URL object. URL strings generally have the following format: </para><para> </para><para>The string is parsed in HTTP format. If the protocol has a different URL format this method must be overridden.</para><para><para>toExternalForm </para><simplesectsep></simplesectsep><para>URL </para></para>        
				/// </summary>
				/// <java-name>
				/// parseURL
				/// </java-name>
				[Dot42.DexImport("parseURL", "(Ljava/net/URL;Ljava/lang/String;II)V", AccessFlags = 4)]
				protected internal virtual void ParseURL(global::Java.Net.URL url, string spec, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the fields of the URL <c> u </c> to the values of the supplied arguments.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use setURL(URL, String String, int, String, String, String, String, String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/" +
    "String;)V", AccessFlags = 4)]
				protected internal virtual void SetURL(global::Java.Net.URL u, string protocol, string host, int port, string file, string @ref) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the fields of the URL <c> u </c> to the values of the supplied arguments. </para>        
				/// </summary>
				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/" +
    "String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void SetURL(global::Java.Net.URL u, string protocol, string host, int port, string authority, string userInfo, string path, string query, string @ref) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the clear text representation of a given URL using HTTP format.</para><para><para>parseURL </para><simplesectsep></simplesectsep><para>URL::toExternalForm() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the clear text representation of the specified URL. </para>
				/// </returns>
				/// <java-name>
				/// toExternalForm
				/// </java-name>
				[Dot42.DexImport("toExternalForm", "(Ljava/net/URL;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string ToExternalForm(global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns true if <c> a </c> and <c> b </c> have the same protocol, host, port, file, and reference. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/net/URL;Ljava/net/URL;)Z", AccessFlags = 4)]
				protected internal virtual bool Equals(global::Java.Net.URL a, global::Java.Net.URL b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the default port of the protocol used by the handled URL. The default implementation always returns <c> -1 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 4)]
				protected internal virtual int GetDefaultPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the host address of <c> url </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getHostAddress
				/// </java-name>
				[Dot42.DexImport("getHostAddress", "(Ljava/net/URL;)Ljava/net/InetAddress;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.InetAddress GetHostAddress(global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the hash code of <c> url </c> . </para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "(Ljava/net/URL;)I", AccessFlags = 4)]
				protected internal virtual int GetHashCode(global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns true if the hosts of <c> a </c> and <c> b </c> are equal. </para>        
				/// </summary>
				/// <java-name>
				/// hostsEqual
				/// </java-name>
				[Dot42.DexImport("hostsEqual", "(Ljava/net/URL;Ljava/net/URL;)Z", AccessFlags = 4)]
				protected internal virtual bool HostsEqual(global::Java.Net.URL a, global::Java.Net.URL b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if <c> a </c> and <c> b </c> have the same protocol, host, port and file. </para>        
				/// </summary>
				/// <java-name>
				/// sameFile
				/// </java-name>
				[Dot42.DexImport("sameFile", "(Ljava/net/URL;Ljava/net/URL;)Z", AccessFlags = 4)]
				protected internal virtual bool SameFile(global::Java.Net.URL a, global::Java.Net.URL b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the default port of the protocol used by the handled URL. The default implementation always returns <c> -1 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				protected internal int DefaultPort
				{
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 4)]
						get{ return GetDefaultPort(); }
				}

		}

		/// <summary>
		/// <para>This exception is thrown when a program attempts to create an URL from an incorrect specification.</para><para><para>URL </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/MalformedURLException
		/// </java-name>
		[Dot42.DexImport("java/net/MalformedURLException", AccessFlags = 33)]
		public partial class MalformedURLException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedURLException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedURLException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class is used to decode a string which is encoded in the <c>   application/x-www-form-urlencoded </c> MIME content type. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URLDecoder
		/// </java-name>
		[Dot42.DexImport("java/net/URLDecoder", AccessFlags = 33)]
		public partial class URLDecoder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public URLDecoder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Decodes the argument which is assumed to be encoded in the <c>       x-www-form-urlencoded </c> MIME content type. </para><para>'+' will be converted to space, '' and two following hex digit characters are converted to the equivalent byte value. All other characters are passed through unmodified. For example "A+B+C %24%25" -&gt; "A B C $%".</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use decode(String, String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the decoded clear-text representation of the given string. </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Decode(string s) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Decodes the argument which is assumed to be encoded in the <c>       x-www-form-urlencoded </c> MIME content type, assuming the given <c> charsetName </c> .</para><para>'</para><para>+' will be converted to space, '' and two following hex digit characters are converted to the equivalent byte value. All other characters are passed through unmodified. For example "A+B+C %24%25" -&gt; "A B C $%".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Decode(string s, string charsetName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Defines an interface for socket implementations to get and set socket options. It is implemented by the classes <c> SocketImpl </c> and <c>   DatagramSocketImpl </c> .</para><para><para>SocketImpl </para><simplesectsep></simplesectsep><para>DatagramSocketImpl </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/SocketOptions
		/// </java-name>
		[Dot42.DexImport("java/net/SocketOptions", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISocketOptionsConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Number of seconds to wait when closing a socket if there is still some buffered data to be sent.</para><para>If this option is set to 0, the TCP socket is closed forcefully and the call to <c> close </c> returns immediately.</para><para>If this option is set to a value greater than 0, the value is interpreted as the number of seconds to wait. If all data could be sent during this time, the socket is closed normally. Otherwise the connection will be closed forcefully.</para><para>Valid values for this option are in the range 0 to 65535 inclusive. (Larger timeouts will be treated as 65535s timeouts; roughly 18 hours.) </para>        
				/// </summary>
				/// <java-name>
				/// SO_LINGER
				/// </java-name>
				[Dot42.DexImport("SO_LINGER", "I", AccessFlags = 25)]
				public const int SO_LINGER = 128;
				/// <summary>
				/// <para>Integer timeout in milliseconds for blocking accept or read/receive operations (but not write/send operations). A timeout of 0 means no timeout. Negative timeouts are not allowed.</para><para>An <c> InterruptedIOException </c> is thrown if this timeout expires. </para>        
				/// </summary>
				/// <java-name>
				/// SO_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("SO_TIMEOUT", "I", AccessFlags = 25)]
				public const int SO_TIMEOUT = 4102;
				/// <summary>
				/// <para>This boolean option specifies whether data is sent immediately on this socket. As a side-effect this could lead to low packet efficiency. The socket implementation uses the Nagle's algorithm to try to reach a higher packet efficiency if this option is disabled. </para>        
				/// </summary>
				/// <java-name>
				/// TCP_NODELAY
				/// </java-name>
				[Dot42.DexImport("TCP_NODELAY", "I", AccessFlags = 25)]
				public const int TCP_NODELAY = 1;
				/// <summary>
				/// <para>This is an IPv4-only socket option whose functionality is subsumed by IP_MULTICAST_IF and not implemented on Android. </para>        
				/// </summary>
				/// <java-name>
				/// IP_MULTICAST_IF
				/// </java-name>
				[Dot42.DexImport("IP_MULTICAST_IF", "I", AccessFlags = 25)]
				public const int IP_MULTICAST_IF = 16;
				/// <summary>
				/// <para>This option does not correspond to any Unix socket option and is not implemented on Android. </para>        
				/// </summary>
				/// <java-name>
				/// SO_BINDADDR
				/// </java-name>
				[Dot42.DexImport("SO_BINDADDR", "I", AccessFlags = 25)]
				public const int SO_BINDADDR = 15;
				/// <summary>
				/// <para>This boolean option specifies whether a reuse of a local address is allowed even if another socket is not yet removed by the operating system. It's only available on a <c> MulticastSocket </c> . </para>        
				/// </summary>
				/// <java-name>
				/// SO_REUSEADDR
				/// </java-name>
				[Dot42.DexImport("SO_REUSEADDR", "I", AccessFlags = 25)]
				public const int SO_REUSEADDR = 4;
				/// <summary>
				/// <para>The size in bytes of a socket's send buffer. This must be an integer greater than 0. This is a hint to the kernel; the kernel may use a larger buffer.</para><para>For datagram sockets, it is implementation-defined whether packets larger than this size can be sent. </para>        
				/// </summary>
				/// <java-name>
				/// SO_SNDBUF
				/// </java-name>
				[Dot42.DexImport("SO_SNDBUF", "I", AccessFlags = 25)]
				public const int SO_SNDBUF = 4097;
				/// <summary>
				/// <para>The size in bytes of a socket's receive buffer. This must be an integer greater than 0. This is a hint to the kernel; the kernel may use a larger buffer.</para><para>For datagram sockets, packets larger than this value will be discarded. </para>        
				/// </summary>
				/// <java-name>
				/// SO_RCVBUF
				/// </java-name>
				[Dot42.DexImport("SO_RCVBUF", "I", AccessFlags = 25)]
				public const int SO_RCVBUF = 4098;
				/// <summary>
				/// <para>This boolean option specifies whether the kernel sends keepalive messages. </para>        
				/// </summary>
				/// <java-name>
				/// SO_KEEPALIVE
				/// </java-name>
				[Dot42.DexImport("SO_KEEPALIVE", "I", AccessFlags = 25)]
				public const int SO_KEEPALIVE = 8;
				/// <summary>
				/// <para>This integer option specifies the value for the type-of-service field of the IPv4 header, or the traffic class field of the IPv6 header. These correspond to the IP_TOS and IPV6_TCLASS socket options. These may be ignored by the underlying OS. Values must be between 0 and 255 inclusive.</para><para>See  for more about IPv4 and  for more about IPv6. </para>        
				/// </summary>
				/// <java-name>
				/// IP_TOS
				/// </java-name>
				[Dot42.DexImport("IP_TOS", "I", AccessFlags = 25)]
				public const int IP_TOS = 3;
				/// <summary>
				/// <para>This boolean option specifies whether the local loopback of multicast packets is enabled or disabled. This option is enabled by default on multicast sockets. Note that the sense of this option in Java is the <b>opposite</b> of the underlying Unix <c> IP_MULTICAST_LOOP </c> . See MulticastSocket#setLoopbackMode. </para>        
				/// </summary>
				/// <java-name>
				/// IP_MULTICAST_LOOP
				/// </java-name>
				[Dot42.DexImport("IP_MULTICAST_LOOP", "I", AccessFlags = 25)]
				public const int IP_MULTICAST_LOOP = 18;
				/// <summary>
				/// <para>This boolean option can be used to enable broadcasting on datagram sockets. </para>        
				/// </summary>
				/// <java-name>
				/// SO_BROADCAST
				/// </java-name>
				[Dot42.DexImport("SO_BROADCAST", "I", AccessFlags = 25)]
				public const int SO_BROADCAST = 32;
				/// <summary>
				/// <para>This boolean option specifies whether sending TCP urgent data is supported on this socket or not. </para>        
				/// </summary>
				/// <java-name>
				/// SO_OOBINLINE
				/// </java-name>
				[Dot42.DexImport("SO_OOBINLINE", "I", AccessFlags = 25)]
				public const int SO_OOBINLINE = 4099;
				/// <summary>
				/// <para>This integer option sets the outgoing interface for multicast packets using an interface index. </para>        
				/// </summary>
				/// <java-name>
				/// IP_MULTICAST_IF2
				/// </java-name>
				[Dot42.DexImport("IP_MULTICAST_IF2", "I", AccessFlags = 25)]
				public const int IP_MULTICAST_IF2 = 31;
		}

		/// <summary>
		/// <para>Defines an interface for socket implementations to get and set socket options. It is implemented by the classes <c> SocketImpl </c> and <c>   DatagramSocketImpl </c> .</para><para><para>SocketImpl </para><simplesectsep></simplesectsep><para>DatagramSocketImpl </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/SocketOptions
		/// </java-name>
		[Dot42.DexImport("java/net/SocketOptions", AccessFlags = 1537)]
		public partial interface ISocketOptions
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Gets the value for the specified socket option.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the option value. </para>
				/// </returns>
				/// <java-name>
				/// getOption
				/// </java-name>
				[Dot42.DexImport("getOption", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetOption(int optID) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified socket option.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setOption
				/// </java-name>
				[Dot42.DexImport("setOption", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				void SetOption(int optID, object val) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This interface defines a factory for datagram socket implementations. It is used by the class <c> DatagramSocket </c> to create a new datagram socket implementation.</para><para><para>DatagramSocket </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/DatagramSocketImplFactory
		/// </java-name>
		[Dot42.DexImport("java/net/DatagramSocketImplFactory", AccessFlags = 1537)]
		public partial interface IDatagramSocketImplFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> DatagramSocketImpl </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new datagram socket implementation. </para>
				/// </returns>
				/// <java-name>
				/// createDatagramSocketImpl
				/// </java-name>
				[Dot42.DexImport("createDatagramSocketImpl", "()Ljava/net/DatagramSocketImpl;", AccessFlags = 1025)]
				global::Java.Net.DatagramSocketImpl CreateDatagramSocketImpl() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A secure cache response represents data which is originally retrieved over a secure connection. Such a connection can be secured by using a cryptographic protocol like TLS or SSL.</para><para><para>ResponseCache </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/SecureCacheResponse
		/// </java-name>
		[Dot42.DexImport("java/net/SecureCacheResponse", AccessFlags = 1057)]
		public abstract partial class SecureCacheResponse : global::Java.Net.CacheResponse
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new instance of this class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecureCacheResponse() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the cipher suite string on the connection which is originally used to retrieve the network resource.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cipher suite string. </para>
				/// </returns>
				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetCipherSuite() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the local certificate chain. When the original connection retrieved the resource data, this certificate chain was sent to the server during handshaking process. This method only takes effect when certificate-based cipher suite is enabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificate chain that was sent to the server. If no certificate chain was sent, the method returns <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLocalCertificateChain
				/// </java-name>
				[Dot42.DexImport("getLocalCertificateChain", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/security/cert/Certificate;>;")]
				public abstract global::Java.Util.IList<global::Java.Security.Cert.Certificate> GetLocalCertificateChain() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the cached server's certificate chain. As part of defining the session, the certificate chain was established when the original connection retrieved network resource. This method can only be invoked when certificated-based cipher suite is enabled. Otherwise, it throws an <c> SSLPeerUnverifiedException </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the server's certificate chain. </para>
				/// </returns>
				/// <java-name>
				/// getServerCertificateChain
				/// </java-name>
				[Dot42.DexImport("getServerCertificateChain", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/security/cert/Certificate;>;")]
				public abstract global::Java.Util.IList<global::Java.Security.Cert.Certificate> GetServerCertificateChain() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the server's principle. When the original connection retrieved network resource, the principle was established when defining the session.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a principal object representing the server's principal. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				public abstract global::Java.Security.IPrincipal GetPeerPrincipal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the local principle that the original connection sent to the server. When the original connection fetched the network resource, the principle was sent to the server during handshaking process.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local principal object being sent to the server. Returns an <c> X500Principal </c> object for X509-based cipher suites. If no principal was sent, it returns <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				public abstract global::Java.Security.IPrincipal GetLocalPrincipal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the cipher suite string on the connection which is originally used to retrieve the network resource.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cipher suite string. </para>
				/// </returns>
				/// <java-name>
				/// getCipherSuite
				/// </java-name>
				public string CipherSuite
				{
				[Dot42.DexImport("getCipherSuite", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetCipherSuite(); }
				}

				/// <summary>
				/// <para>Gets the local certificate chain. When the original connection retrieved the resource data, this certificate chain was sent to the server during handshaking process. This method only takes effect when certificate-based cipher suite is enabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificate chain that was sent to the server. If no certificate chain was sent, the method returns <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLocalCertificateChain
				/// </java-name>
				public global::Java.Util.IList<global::Java.Security.Cert.Certificate> LocalCertificateChain
				{
				[Dot42.DexImport("getLocalCertificateChain", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/security/cert/Certificate;>;")]
						get{ return GetLocalCertificateChain(); }
				}

				/// <summary>
				/// <para>Gets the cached server's certificate chain. As part of defining the session, the certificate chain was established when the original connection retrieved network resource. This method can only be invoked when certificated-based cipher suite is enabled. Otherwise, it throws an <c> SSLPeerUnverifiedException </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the server's certificate chain. </para>
				/// </returns>
				/// <java-name>
				/// getServerCertificateChain
				/// </java-name>
				public global::Java.Util.IList<global::Java.Security.Cert.Certificate> ServerCertificateChain
				{
				[Dot42.DexImport("getServerCertificateChain", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/security/cert/Certificate;>;")]
						get{ return GetServerCertificateChain(); }
				}

				/// <summary>
				/// <para>Gets the server's principle. When the original connection retrieved network resource, the principle was established when defining the session.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a principal object representing the server's principal. </para>
				/// </returns>
				/// <java-name>
				/// getPeerPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal PeerPrincipal
				{
				[Dot42.DexImport("getPeerPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get{ return GetPeerPrincipal(); }
				}

				/// <summary>
				/// <para>Gets the local principle that the original connection sent to the server. When the original connection fetched the network resource, the principle was sent to the server during handshaking process.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local principal object being sent to the server. Returns an <c> X500Principal </c> object for X509-based cipher suites. If no principal was sent, it returns <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLocalPrincipal
				/// </java-name>
				public global::Java.Security.IPrincipal LocalPrincipal
				{
				[Dot42.DexImport("getLocalPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get{ return GetLocalPrincipal(); }
				}

		}

		/// <summary>
		/// <para>An Internet Protocol (IP) address. This can be either an IPv4 address or an IPv6 address, and in practice you'll have an instance of either <c> Inet4Address </c> or <c> Inet6Address </c> (this class cannot be instantiated directly). Most code does not need to distinguish between the two families, and should use <c> InetAddress </c> .</para><para>An <c> InetAddress </c> may have a hostname (accessible via <c> getHostName </c> ), but may not, depending on how the <c> InetAddress </c> was created.</para><para><h4>IPv4 numeric address formats</h4></para><para>The <c> getAllByName </c> method accepts IPv4 addresses in the "decimal-dotted-quad" form only: <ul><li><para><c> "1.2.3.4" </c> - 1.2.3.4 </para></li></ul></para><para><h4>IPv6 numeric address formats</h4></para><para>The <c> getAllByName </c> method accepts IPv6 addresses in the following forms (this text comes from , which you should consult for full details of IPv6 addressing): <ul><li><para></para><para>The preferred form is <c> x:x:x:x:x:x:x:x </c> , where the 'x's are the hexadecimal values of the eight 16-bit pieces of the address. Note that it is not necessary to write the leading zeros in an individual field, but there must be at least one numeral in every field (except for the case described in the next bullet). Examples: <pre>
		///        FEDC:BA98:7654:3210:FEDC:BA98:7654:3210
		///        1080:0:0:0:8:800:200C:417A</pre>  </para></li><li><para>Due to some methods of allocating certain styles of IPv6 addresses, it will be common for addresses to contain long strings of zero bits. In order to make writing addresses containing zero bits easier a special syntax is available to compress the zeros. The use of "::" indicates multiple groups of 16-bits of zeros. The "::" can only appear once in an address. The "::" can also be used to compress the leading and/or trailing zeros in an address.</para><para>For example the following addresses: <pre>
		///        1080:0:0:0:8:800:200C:417A  a unicast address
		///        FF01:0:0:0:0:0:0:101        a multicast address
		///        0:0:0:0:0:0:0:1             the loopback address
		///        0:0:0:0:0:0:0:0             the unspecified addresses</pre> may be represented as: <pre>
		///        1080::8:800:200C:417A       a unicast address
		///        FF01::101                   a multicast address
		///        ::1                         the loopback address
		///        ::                          the unspecified addresses</pre>  </para></li><li><para></para><para>An alternative form that is sometimes more convenient when dealing with a mixed environment of IPv4 and IPv6 nodes is <c> x:x:x:x:x:x:d.d.d.d </c> , where the 'x's are the hexadecimal values of the six high-order 16-bit pieces of the address, and the 'd's are the decimal values of the four low-order 8-bit pieces of the address (standard IPv4 representation). Examples: <pre>
		///        0:0:0:0:0:0:13.1.68.3
		///        0:0:0:0:0:FFFF:129.144.52.38</pre> or in compressed form: <pre>
		///        ::13.1.68.3
		///        ::FFFF:129.144.52.38</pre>  </para></li></ul></para><para>Scopes are given using a trailing <c> % </c> followed by the scope id, as in <c> 1080::8:800:200C:417A%2 </c> or <c> 1080::8:800:200C:417A%en0 </c> . See  for more on IPv6's scoped address architecture.</para><para>Additionally, for backwards compatibility, IPv6 addresses may be surrounded by square brackets.</para><para><h4>DNS caching</h4></para><para>In Android 4.0 (Ice Cream Sandwich) and earlier, DNS caching was performed both by InetAddress and by the C library, which meant that DNS TTLs could not be honored correctly. In later releases, caching is done solely by the C library and DNS TTLs are honored.</para><para><para>Inet4Address </para><simplesectsep></simplesectsep><para>Inet6Address </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/InetAddress
		/// </java-name>
		[Dot42.DexImport("java/net/InetAddress", AccessFlags = 33)]
		public partial class InetAddress : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InetAddress() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares this <c> InetAddress </c> instance against the specified address in <c> obj </c> . Two addresses are equal if their address byte arrays have the same length and if the bytes in the arrays are equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if both objects are equal, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the IP address represented by this <c> InetAddress </c> instance as a byte array. The elements are in network order (the highest order address byte is in the zeroth element).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the address in form of a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetAddress() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the IP address represented by this <c> InetAddress </c> instance as a byte array. The elements are in network order (the highest order address byte is in the zeroth element).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the address in form of a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetAddress() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Gets all IP addresses associated with the given <c> host </c> identified by name or literal IP address. The IP address is resolved by the configured name service. If the host name is empty or <c> null </c> an <c> UnknownHostException </c> is thrown. If the host name is a literal IP address string an array with the corresponding single <c> InetAddress </c> is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array of addresses associated with the specified host. </para>
				/// </returns>
				/// <java-name>
				/// getAllByName
				/// </java-name>
				[Dot42.DexImport("getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress[] GetAllByName(string host) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress[]);
				}

				/// <summary>
				/// <para>Returns the address of a host according to the given host string name <c> host </c> . The host string may be either a machine name or a dotted string IP address. If the latter, the <c> hostName </c> field is determined upon demand. <c> host </c> can be <c> null </c> which means that an address of the loopback interface is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> InetAddress </c> instance representing the host. </para>
				/// </returns>
				/// <java-name>
				/// getByName
				/// </java-name>
				[Dot42.DexImport("getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetByName(string host) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the numeric representation of this IP address (such as "127.0.0.1"). </para>        
				/// </summary>
				/// <java-name>
				/// getHostAddress
				/// </java-name>
				[Dot42.DexImport("getHostAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHostAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the host name corresponding to this IP address. This may or may not be a fully-qualified name. If the IP address could not be resolved, the numeric representation is returned instead (see getHostAddress). </para>        
				/// </summary>
				/// <java-name>
				/// getHostName
				/// </java-name>
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHostName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the fully qualified hostname corresponding to this IP address. </para>        
				/// </summary>
				/// <java-name>
				/// getCanonicalHostName
				/// </java-name>
				[Dot42.DexImport("getCanonicalHostName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCanonicalHostName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns an <c> InetAddress </c> for the local host if possible, or the loopback address otherwise. This method works by getting the hostname, performing a DNS lookup, and then taking the first returned address. For devices with multiple network interfaces and/or multiple addresses per interface, this does not necessarily return the <c> InetAddress </c> you want.</para><para>Multiple interface/address configurations were relatively rare when this API was designed, but multiple interfaces are the default for modern mobile devices (with separate wifi and radio interfaces), and the need to support both IPv4 and IPv6 has made multiple addresses commonplace. New code should thus avoid this method except where it's basically being used to get a loopback address or equivalent.</para><para>There are two main ways to get a more specific answer: <ul><li><para>If you have a connected socket, you should probably use Socket#getLocalAddress instead: that will give you the address that's actually in use for that connection. (It's not possible to ask the question "what local address would a connection to a given remote       address use?"; you have to actually make the connection and see.) </para></li><li><para>For other use cases, see NetworkInterface, which lets you enumerate all available network interfaces and their addresses. </para></li></ul></para><para>Note that if the host doesn't have a hostname set  as Android devices typically don't  this method will effectively return the loopback address, albeit by getting the name <c> localhost </c> and then doing a lookup to translate that to <c> 127.0.0.1 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> InetAddress </c> representing the local host, or the loopback address. </para>
				/// </returns>
				/// <java-name>
				/// getLocalHost
				/// </java-name>
				[Dot42.DexImport("getLocalHost", "()Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetLocalHost() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Gets the hashcode of the represented IP address.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the appropriate hashcode value. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns whether this address is a multicast address or not.</para><para>Valid IPv6 multicast addresses have the prefix <c> ff::/8 </c> .</para><para>Valid IPv4 multicast addresses have the prefix <c> 224/4 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMulticastAddress
				/// </java-name>
				[Dot42.DexImport("isMulticastAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsMulticastAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a string containing the host name (if available) and host address. For example: <c> "www.google.com/74.125.224.115" </c> or <c> "/127.0.0.1" </c> .</para><para>IPv6 addresses may additionally include an interface name or scope id. For example: <c> "www.google.com/2001:4860:4001:803::1013%eth0" </c> or <c> "/2001:4860:4001:803::1013%2" </c> . </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns whether this address is a loopback address or not.</para><para>Valid IPv4 loopback addresses have the prefix <c> 127/8 </c> .</para><para>The only valid IPv6 loopback address is <c> ::1 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isLoopbackAddress
				/// </java-name>
				[Dot42.DexImport("isLoopbackAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsLoopbackAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a link-local address or not.</para><para>Valid IPv6 link-local addresses have the prefix <c> fe80::/10 </c> .</para><para> "Default Address Selection for Internet Protocol Version 6 (IPv6)" states that both IPv4 auto-configuration addresses (prefix <c> 169.254/16 </c> ) and IPv4 loopback addresses (prefix <c> 127/8 </c> ) have link-local scope, but Inet4Address only considers the auto-configuration addresses to have link-local scope. That is: the IPv4 loopback address returns false. </para>        
				/// </summary>
				/// <java-name>
				/// isLinkLocalAddress
				/// </java-name>
				[Dot42.DexImport("isLinkLocalAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsLinkLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a site-local address or not.</para><para>For the purposes of this method, valid IPv6 site-local addresses have the deprecated prefix <c> fec0::/10 </c> from , <b>not</b> the modern prefix <c> fc00::/7 </c> from .</para><para> "Default Address Selection for Internet Protocol Version 6 (IPv6)" states that IPv4 private addresses have the prefix <c> 10/8 </c> , <c> 172.16/12 </c> , or <c> 192.168/16 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this instance represents a site-local address, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSiteLocalAddress
				/// </java-name>
				[Dot42.DexImport("isSiteLocalAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsSiteLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a global multicast address or not.</para><para>Valid IPv6 global multicast addresses have the prefix <c> ffxe::/16 </c> , where <c> x </c> is a set of flags and the additional 112 bits make up the global multicast address space.</para><para>Valid IPv4 global multicast addresses are the range of addresses from <c> 224.0.1.0 </c> to <c> 238.255.255.255 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCGlobal
				/// </java-name>
				[Dot42.DexImport("isMCGlobal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCGlobal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a node-local multicast address or not.</para><para>Valid IPv6 node-local multicast addresses have the prefix <c> ffx1::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>There are no valid IPv4 node-local multicast addresses. </para>        
				/// </summary>
				/// <java-name>
				/// isMCNodeLocal
				/// </java-name>
				[Dot42.DexImport("isMCNodeLocal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCNodeLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a link-local multicast address or not.</para><para>Valid IPv6 link-local multicast addresses have the prefix <c> ffx2::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 link-local multicast addresses have the prefix <c> 224.0.0/24 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCLinkLocal
				/// </java-name>
				[Dot42.DexImport("isMCLinkLocal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCLinkLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a site-local multicast address or not.</para><para>Valid IPv6 site-local multicast addresses have the prefix <c> ffx5::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 site-local multicast addresses have the prefix <c> 239.255/16 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCSiteLocal
				/// </java-name>
				[Dot42.DexImport("isMCSiteLocal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCSiteLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a organization-local multicast address or not.</para><para>Valid IPv6 organization-local multicast addresses have the prefix <c> ffx8::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 organization-local multicast addresses have the prefix <c> 239.192/14 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCOrgLocal
				/// </java-name>
				[Dot42.DexImport("isMCOrgLocal", "()Z", AccessFlags = 1)]
				public virtual bool IsMCOrgLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this is the IPv6 unspecified wildcard address <c> :: </c> or the IPv4 "any" address, <c> 0.0.0.0 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isAnyLocalAddress
				/// </java-name>
				[Dot42.DexImport("isAnyLocalAddress", "()Z", AccessFlags = 1)]
				public virtual bool IsAnyLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tries to reach this <c> InetAddress </c> . This method first tries to use ICMP <b>(ICMP ECHO REQUEST)</b>, falling back to a TCP connection on port 7 (Echo) of the remote host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this address is reachable, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isReachable
				/// </java-name>
				[Dot42.DexImport("isReachable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsReachable(int timeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isReachable
				/// </java-name>
				[Dot42.DexImport("isReachable", "(Ljava/net/NetworkInterface;II)Z", AccessFlags = 1)]
				public virtual bool IsReachable(global::Java.Net.NetworkInterface destination, int source, int timeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Equivalent to <c> getByAddress(null, ipAddress) </c> . Handy for addresses with no associated hostname. </para>        
				/// </summary>
				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "([B)Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetByAddress(sbyte[] ipAddress) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Equivalent to <c> getByAddress(null, ipAddress) </c> . Handy for addresses with no associated hostname. </para>        
				/// </summary>
				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "([B)Ljava/net/InetAddress;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Net.InetAddress GetByAddress(byte[] ipAddress) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns an <c> InetAddress </c> corresponding to the given network-order bytes <c> ipAddress </c> and <c> scopeId </c> .</para><para>For an IPv4 address, the byte array must be of length 4. For IPv6, the byte array must be of length 16. Any other length will cause an <c>       UnknownHostException </c> .</para><para>No reverse lookup is performed. The given <c> hostName </c> (which may be null) is associated with the new <c> InetAddress </c> with no validation done.</para><para>(Note that numeric addresses such as <c> "127.0.0.1" </c> are names for the purposes of this API. Most callers probably want getAllByName instead.)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetAddress GetByAddress(string hostName, sbyte[] ipAddress) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns an <c> InetAddress </c> corresponding to the given network-order bytes <c> ipAddress </c> and <c> scopeId </c> .</para><para>For an IPv4 address, the byte array must be of length 4. For IPv6, the byte array must be of length 16. Any other length will cause an <c>       UnknownHostException </c> .</para><para>No reverse lookup is performed. The given <c> hostName </c> (which may be null) is associated with the new <c> InetAddress </c> with no validation done.</para><para>(Note that numeric addresses such as <c> "127.0.0.1" </c> are names for the purposes of this API. Most callers probably want getAllByName instead.)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Net.InetAddress GetByAddress(string hostName, byte[] ipAddress) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the IP address represented by this <c> InetAddress </c> instance as a byte array. The elements are in network order (the highest order address byte is in the zeroth element).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the address in form of a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				public byte[] Address
				{
				[Dot42.DexImport("getAddress", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetAddress(); }
				}

				/// <summary>
				/// <para>Returns the numeric representation of this IP address (such as "127.0.0.1"). </para>        
				/// </summary>
				/// <java-name>
				/// getHostAddress
				/// </java-name>
				public string HostAddress
				{
				[Dot42.DexImport("getHostAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHostAddress(); }
				}

				/// <summary>
				/// <para>Returns the host name corresponding to this IP address. This may or may not be a fully-qualified name. If the IP address could not be resolved, the numeric representation is returned instead (see getHostAddress). </para>        
				/// </summary>
				/// <java-name>
				/// getHostName
				/// </java-name>
				public string HostName
				{
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHostName(); }
				}

				/// <summary>
				/// <para>Returns the fully qualified hostname corresponding to this IP address. </para>        
				/// </summary>
				/// <java-name>
				/// getCanonicalHostName
				/// </java-name>
				public string CanonicalHostName
				{
				[Dot42.DexImport("getCanonicalHostName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCanonicalHostName(); }
				}

				/// <summary>
				/// <para>Returns an <c> InetAddress </c> for the local host if possible, or the loopback address otherwise. This method works by getting the hostname, performing a DNS lookup, and then taking the first returned address. For devices with multiple network interfaces and/or multiple addresses per interface, this does not necessarily return the <c> InetAddress </c> you want.</para><para>Multiple interface/address configurations were relatively rare when this API was designed, but multiple interfaces are the default for modern mobile devices (with separate wifi and radio interfaces), and the need to support both IPv4 and IPv6 has made multiple addresses commonplace. New code should thus avoid this method except where it's basically being used to get a loopback address or equivalent.</para><para>There are two main ways to get a more specific answer: <ul><li><para>If you have a connected socket, you should probably use Socket#getLocalAddress instead: that will give you the address that's actually in use for that connection. (It's not possible to ask the question "what local address would a connection to a given remote       address use?"; you have to actually make the connection and see.) </para></li><li><para>For other use cases, see NetworkInterface, which lets you enumerate all available network interfaces and their addresses. </para></li></ul></para><para>Note that if the host doesn't have a hostname set  as Android devices typically don't  this method will effectively return the loopback address, albeit by getting the name <c> localhost </c> and then doing a lookup to translate that to <c> 127.0.0.1 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> InetAddress </c> representing the local host, or the loopback address. </para>
				/// </returns>
				/// <java-name>
				/// getLocalHost
				/// </java-name>
				public static global::Java.Net.InetAddress LocalHost
				{
				[Dot42.DexImport("getLocalHost", "()Ljava/net/InetAddress;", AccessFlags = 9)]
						get{ return GetLocalHost(); }
				}

		}

		/// <summary>
		/// <para>The abstract superclass for datagram and multicast socket implementations. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/DatagramSocketImpl
		/// </java-name>
		[Dot42.DexImport("java/net/DatagramSocketImpl", AccessFlags = 1057)]
		public abstract partial class DatagramSocketImpl : global::Java.Net.ISocketOptions
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>File descriptor that is used to address this socket. </para>        
				/// </summary>
				/// <java-name>
				/// fd
				/// </java-name>
				[Dot42.DexImport("fd", "Ljava/io/FileDescriptor;", AccessFlags = 4)]
				protected internal global::Java.Io.FileDescriptor Fd;
				/// <summary>
				/// <para>The number of the local port to which this socket is bound. </para>        
				/// </summary>
				/// <java-name>
				/// localPort
				/// </java-name>
				[Dot42.DexImport("localPort", "I", AccessFlags = 4)]
				protected internal int LocalPort;
				/// <summary>
				/// <para>Constructs an unbound datagram socket implementation. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DatagramSocketImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Binds the datagram socket to the given localhost/port. Sockets must be bound prior to attempting to send or receive data.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(ILjava/net/InetAddress;)V", AccessFlags = 1028)]
				protected internal abstract void Bind(int port, global::Java.Net.InetAddress addr) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Closes this socket. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1028)]
				protected internal abstract void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method allocates the socket descriptor in the underlying operating system.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "()V", AccessFlags = 1028)]
				protected internal abstract void Create() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> FileDescriptor </c> of this datagram socket, which is invalid if the socket is closed or not bound.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current file descriptor of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 4)]
				protected internal virtual global::Java.Io.FileDescriptor GetFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileDescriptor);
				}

				/// <summary>
				/// <para>Returns the local port to which this socket is bound. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 4)]
				protected internal virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the time-to-live (TTL) for multicast packets sent on this socket.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by getTimeToLive </para></xrefdescription></xrefsect><para>getTimeToLive() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time-to-live option as a byte value. </para>
				/// </returns>
				/// <java-name>
				/// getTTL
				/// </java-name>
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1028)]
				protected internal abstract sbyte JavaGetTTL() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the time-to-live (TTL) for multicast packets sent on this socket.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by getTimeToLive </para></xrefdescription></xrefsect><para>getTimeToLive() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time-to-live option as a byte value. </para>
				/// </returns>
				/// <java-name>
				/// getTTL
				/// </java-name>
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte GetTTL() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the time-to-live (TTL) for multicast packets sent on this socket. The TTL option defines how many routers a packet may be pass before it is discarded.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time-to-live option as an integer value. </para>
				/// </returns>
				/// <java-name>
				/// getTimeToLive
				/// </java-name>
				[Dot42.DexImport("getTimeToLive", "()I", AccessFlags = 1028)]
				protected internal abstract int GetTimeToLive() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds this socket to the multicast group <c> addr </c> . A socket must join a group before being able to receive data. Further, a socket may be a member of multiple groups but may join any group only once.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(Ljava/net/InetAddress;)V", AccessFlags = 1028)]
				protected internal abstract void Join(global::Java.Net.InetAddress addr) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds this socket to the multicast group <c> addr </c> . A socket must join a group before being able to receive data. Further, a socket may be a member of multiple groups but may join any group only once.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// joinGroup
				/// </java-name>
				[Dot42.DexImport("joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", AccessFlags = 1028)]
				protected internal abstract void JoinGroup(global::Java.Net.SocketAddress addr, global::Java.Net.NetworkInterface netInterface) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes this socket from the multicast group <c> addr </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// leave
				/// </java-name>
				[Dot42.DexImport("leave", "(Ljava/net/InetAddress;)V", AccessFlags = 1028)]
				protected internal abstract void Leave(global::Java.Net.InetAddress addr) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes this socket from the multicast group <c> addr </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// leaveGroup
				/// </java-name>
				[Dot42.DexImport("leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", AccessFlags = 1028)]
				protected internal abstract void LeaveGroup(global::Java.Net.SocketAddress addr, global::Java.Net.NetworkInterface netInterface) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Peeks at the incoming packet to this socket and returns the address of the <c> sender </c> . The method will block until a packet is received or timeout expires.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the address of <c> sender </c> as an integer value. </para>
				/// </returns>
				/// <java-name>
				/// peek
				/// </java-name>
				[Dot42.DexImport("peek", "(Ljava/net/InetAddress;)I", AccessFlags = 1028)]
				protected internal abstract int Peek(global::Java.Net.InetAddress sender) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receives data and stores it in the supplied datagram packet <c> pack </c> . This call will block until either data has been received or, if a timeout is set, the timeout has expired. If the timeout expires an <c>       InterruptedIOException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// receive
				/// </java-name>
				[Dot42.DexImport("receive", "(Ljava/net/DatagramPacket;)V", AccessFlags = 1028)]
				protected internal abstract void Receive(global::Java.Net.DatagramPacket pack) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sends the given datagram packet <c> pack </c> . The packet contains the data and the address and port information of the target host as well.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/net/DatagramPacket;)V", AccessFlags = 1028)]
				protected internal abstract void Send(global::Java.Net.DatagramPacket pack) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the time-to-live (TTL) option for multicast packets sent on this socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTimeToLive
				/// </java-name>
				[Dot42.DexImport("setTimeToLive", "(I)V", AccessFlags = 1028)]
				protected internal abstract void SetTimeToLive(int ttl) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the time-to-live (TTL) option for multicast packets sent on this socket.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by setTimeToLive </para></xrefdescription></xrefsect><para>setTimeToLive(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTTL
				/// </java-name>
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1028)]
				protected internal abstract void SetTTL(sbyte ttl) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the time-to-live (TTL) option for multicast packets sent on this socket.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by setTimeToLive </para></xrefdescription></xrefsect><para>setTimeToLive(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTTL
				/// </java-name>
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void SetTTL(byte ttl) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Connects this socket to the specified remote address and port.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/InetAddress;I)V", AccessFlags = 4)]
				protected internal virtual void Connect(global::Java.Net.InetAddress inetAddr, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disconnects this socket from the remote host. </para>        
				/// </summary>
				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()V", AccessFlags = 4)]
				protected internal virtual void Disconnect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receives data into the supplied datagram packet by peeking. The data is not removed from socket buffer and can be received again by another <c> peekData() </c> or <c> receive() </c> call. This call blocks until either data has been received or, if a timeout is set, the timeout has been expired.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the port the packet was received from. </para>
				/// </returns>
				/// <java-name>
				/// peekData
				/// </java-name>
				[Dot42.DexImport("peekData", "(Ljava/net/DatagramPacket;)I", AccessFlags = 1028)]
				protected internal abstract int PeekData(global::Java.Net.DatagramPacket pack) /* MethodBuilder.Create */ ;

				[Dot42.DexImport("java/net/SocketOptions", "getOption", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetOption(int optID) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("java/net/SocketOptions", "setOption", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				public virtual void SetOption(int optID, object val) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				/// <para>Gets the <c> FileDescriptor </c> of this datagram socket, which is invalid if the socket is closed or not bound.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current file descriptor of this socket. </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				protected internal global::Java.Io.FileDescriptor FileDescriptor
				{
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 4)]
						get{ return GetFileDescriptor(); }
				}

				/// <summary>
				/// <para>Gets the time-to-live (TTL) for multicast packets sent on this socket.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by getTimeToLive </para></xrefdescription></xrefsect><para>getTimeToLive() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time-to-live option as a byte value. </para>
				/// </returns>
				/// <java-name>
				/// getTTL
				/// </java-name>
				protected internal byte TTL
				{
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1028, IgnoreFromJava = true)]
						get{ return GetTTL(); }
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
						set{ SetTTL(value); }
				}

				/// <summary>
				/// <para>Gets the time-to-live (TTL) for multicast packets sent on this socket. The TTL option defines how many routers a packet may be pass before it is discarded.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time-to-live option as an integer value. </para>
				/// </returns>
				/// <java-name>
				/// getTimeToLive
				/// </java-name>
				protected internal int TimeToLive
				{
				[Dot42.DexImport("getTimeToLive", "()I", AccessFlags = 1028)]
						get{ return GetTimeToLive(); }
				[Dot42.DexImport("setTimeToLive", "(I)V", AccessFlags = 1028)]
						set{ SetTimeToLive(value); }
				}

		}

		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/NetPermission
		/// </java-name>
		[Dot42.DexImport("java/net/NetPermission", AccessFlags = 49)]
		public sealed partial class NetPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NetPermission(string name) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public NetPermission(string name, string actions) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NetPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This abstract class represents a protocol-independent base for socket-endpoint representing classes. The class has to be implemented according to a specific protocol. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/SocketAddress
		/// </java-name>
		[Dot42.DexImport("java/net/SocketAddress", AccessFlags = 1057)]
		public abstract partial class SocketAddress : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SocketAddress </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketAddress() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An URLConnection for HTTP () used to send and receive data over the web. Data may be of any type and length. This class may be used to send and receive streaming data whose length is not known in advance.</para><para>Uses of this class follow a pattern: <ol><li><para>Obtain a new <c> HttpURLConnection </c> by calling URL.openConnection() and casting the result to <c> HttpURLConnection </c> . </para></li><li><para>Prepare the request. The primary property of a request is its URI. Request headers may also include metadata such as credentials, preferred content types, and session cookies. </para></li><li><para>Optionally upload a request body. Instances must be configured with setDoOutput(true) if they include a request body. Transmit data by writing to the stream returned by getOutputStream(). </para></li><li><para>Read the response. Response headers typically include metadata such as the response body's content type and length, modified dates and session cookies. The response body may be read from the stream returned by getInputStream(). If the response has no body, that method returns an empty stream. </para></li><li><para>Disconnect. Once the response body has been read, the <c>         HttpURLConnection </c> should be closed by calling disconnect(). Disconnecting releases the resources held by a connection so they may be closed or reused. </para></li></ol></para><para>For example, to retrieve the webpage at <c> http://www.android.com/ </c> : <pre>        URL url = new URL("http://www.android.com/");
		/// 
		///      HttpURLConnection urlConnection = (HttpURLConnection) url.openConnection();
		/// 
		///      try {
		/// 
		///        InputStream in = new BufferedInputStream(urlConnection.getInputStream());
		/// 
		///        readStream(in);
		/// 
		///      } finally {
		/// 
		///        urlConnection.disconnect();
		/// 
		///      }
		/// 
		///  </pre></para><para><h3>Secure Communication with HTTPS</h3></para><para>Calling URL#openConnection() on a URL with the "https" scheme will return an <c> HttpsURLConnection </c> , which allows for overriding the default HostnameVerifier and SSLSocketFactory. An application-supplied <c> SSLSocketFactory </c> created from an SSLContext can provide a custom X509TrustManager for verifying certificate chains and a custom X509KeyManager for supplying client certificates. See HttpsURLConnection for more details.</para><para><h3>Response Handling</h3></para><para><c> HttpURLConnection </c> will follow up to five HTTP redirects. It will follow redirects from one origin server to another. This implementation doesn't follow redirects from HTTPS to HTTP or vice versa.</para><para>If the HTTP response indicates that an error occurred, getInputStream() will throw an IOException. Use getErrorStream() to read the error response. The headers can be read in the normal way using getHeaderFields(),</para><para><h3>Posting Content</h3></para><para>To upload data to a web server, configure the connection for output using setDoOutput(true).</para><para>For best performance, you should call either setFixedLengthStreamingMode(int) when the body length is known in advance, or setChunkedStreamingMode(int) when it is not. Otherwise <c>   HttpURLConnection </c> will be forced to buffer the complete request body in memory before it is transmitted, wasting (and possibly exhausting) heap and increasing latency.</para><para>For example, to perform an upload: <pre>        HttpURLConnection urlConnection = (HttpURLConnection) url.openConnection();
		/// 
		///      try {
		/// 
		///        urlConnection.setDoOutput(true);
		/// 
		///        urlConnection.setChunkedStreamingMode(0);
		/// 
		///   
		/// 
		///        OutputStream out = new BufferedOutputStream(urlConnection.getOutputStream());
		/// 
		///        writeStream(out);
		/// 
		///   
		/// 
		///        InputStream in = new BufferedInputStream(urlConnection.getInputStream());
		/// 
		///        readStream(in);
		/// 
		///      } finally {
		/// 
		///        urlConnection.disconnect();
		/// 
		///      }
		/// 
		///  </pre></para><para><h3>Performance</h3></para><para>The input and output streams returned by this class are <b>not buffered</b>. Most callers should wrap the returned streams with BufferedInputStream or BufferedOutputStream. Callers that do only bulk reads or writes may omit buffering.</para><para>When transferring large amounts of data to or from a server, use streams to limit how much data is in memory at once. Unless you need the entire body to be in memory at once, process it as a stream (rather than storing the complete body as a single byte array or string).</para><para>To reduce latency, this class may reuse the same underlying <c> Socket </c> for multiple request/response pairs. As a result, HTTP connections may be held open longer than necessary. Calls to disconnect() may return the socket to a pool of connected sockets. This behavior can be disabled by setting the <c> http.keepAlive </c> system property to <c> false </c> before issuing any HTTP requests. The <c> http.maxConnections </c> property may be used to control how many idle connections to each server will be held.</para><para>By default, this implementation of <c> HttpURLConnection </c> requests that servers use gzip compression. Since getContentLength() returns the number of bytes transmitted, you cannot use that method to predict how many bytes can be read from getInputStream(). Instead, read that stream until it is exhausted: when InputStream#read returns -1. Gzip compression can be disabled by setting the acceptable encodings in the request header: <pre>        urlConnection.setRequestProperty("Accept-Encoding", "identity");
		/// 
		///  </pre></para><para><h3>Handling Network Sign-On</h3></para><para>Some Wi-Fi networks block Internet access until the user clicks through a sign-on page. Such sign-on pages are typically presented by using HTTP redirects. You can use getURL() to test if your connection has been unexpectedly redirected. This check is not valid until <b>after</b> the response headers have been received, which you can trigger by calling getHeaderFields() or getInputStream(). For example, to check that a response was not redirected to an unexpected host: <pre>        HttpURLConnection urlConnection = (HttpURLConnection) url.openConnection();
		/// 
		///      try {
		/// 
		///        InputStream in = new BufferedInputStream(urlConnection.getInputStream());
		/// 
		///        if (!url.getHost().equals(urlConnection.getURL().getHost())) {
		/// 
		///          // we were redirected! Kick the user out to the browser to sign on?
		/// 
		///        }
		/// 
		///        ...
		/// 
		///      } finally {
		/// 
		///        urlConnection.disconnect();
		/// 
		///      }
		/// 
		///  </pre></para><para><h3>HTTP Authentication</h3></para><para><c> HttpURLConnection </c> supports . Use Authenticator to set the VM-wide authentication handler: <pre>        Authenticator.setDefault(new Authenticator() {
		/// 
		///        protected PasswordAuthentication getPasswordAuthentication() {
		/// 
		///          return new PasswordAuthentication(username, password.toCharArray());
		/// 
		///        }
		/// 
		///      });
		/// 
		///  </pre> Unless paired with HTTPS, this is <b>not</b> a secure mechanism for user authentication. In particular, the username, password, request and response are all transmitted over the network without encryption.</para><para><h3>Sessions with Cookies</h3></para><para>To establish and maintain a potentially long-lived session between client and server, <c> HttpURLConnection </c> includes an extensible cookie manager. Enable VM-wide cookie management using CookieHandler and CookieManager: <pre>        CookieManager cookieManager = new CookieManager();
		/// 
		///      CookieHandler.setDefault(cookieManager);
		/// 
		///  </pre> By default, <c> CookieManager </c> accepts cookies from the  only. Two other policies are included: CookiePolicy#ACCEPT_ALL and CookiePolicy#ACCEPT_NONE. Implement CookiePolicy to define a custom policy.</para><para>The default <c> CookieManager </c> keeps all accepted cookies in memory. It will forget these cookies when the VM exits. Implement CookieStore to define a custom cookie store.</para><para>In addition to the cookies set by HTTP responses, you may set cookies programmatically. To be included in HTTP request headers, cookies must have the domain and path properties set.</para><para>By default, new instances of <c> HttpCookie </c> work only with servers that support  cookies. Many web servers support only the older specification, . For compatibility with the most web servers, set the cookie version to 0.</para><para>For example, to receive <c> www.twitter.com </c> in French: <pre>        HttpCookie cookie = new HttpCookie("lang", "fr");
		/// 
		///      cookie.setDomain("twitter.com");
		/// 
		///      cookie.setPath("/");
		/// 
		///      cookie.setVersion(0);
		/// 
		///      cookieManager.getCookieStore().add(new URI("http://twitter.com/"), cookie);
		/// 
		///  </pre></para><para><h3>HTTP Methods</h3></para><para><c> HttpURLConnection </c> uses the <c> GET </c> method by default. It will use <c> POST </c> if setDoOutput(true) has been called. Other HTTP methods (<c> OPTIONS </c> , <c> HEAD </c> , <c> PUT </c> , <c>   DELETE </c> and <c> TRACE </c> ) can be used with setRequestMethod.</para><para><h3>Proxies</h3></para><para>By default, this class will connect directly to the . It can also connect via an HTTP or SOCKS proxy. To use a proxy, use URL.openConnection(Proxy) when creating the connection.</para><para><h3>IPv6 Support</h3></para><para>This class includes transparent support for IPv6. For hosts with both IPv4 and IPv6 addresses, it will attempt to connect to each of a host's addresses until a connection is established.</para><para><h3>Response Caching</h3></para><para>Android 4.0 (Ice Cream Sandwich) includes a response cache. See <c>   android.net.http.HttpResponseCache </c> for instructions on enabling HTTP caching in your application.</para><para><h3>Avoiding Bugs In Earlier Releases</h3></para><para>Prior to Android 2.2 (Froyo), this class had some frustrating bugs. In particular, calling <c> close() </c> on a readable <c> InputStream </c> could . Work around this by disabling connection pooling: <pre>      private void disableConnectionReuseIfNecessary() {
		/// 
		///      // Work around pre-Froyo bugs in HTTP connection reuse.
		/// 
		///      if (Integer.parseInt(Build.VERSION.SDK) &lt; Build.VERSION_CODES.FROYO) {
		/// 
		///        System.setProperty("http.keepAlive", "false");
		/// 
		///      }
		/// 
		///    } 
		/// 
		///  </pre></para><para>Each instance of <c> HttpURLConnection </c> may be used for one request/response pair. Instances of this class are not thread safe. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/HttpURLConnection
		/// </java-name>
		[Dot42.DexImport("java/net/HttpURLConnection", AccessFlags = 1057)]
		public abstract partial class HttpURLConnection : global::Java.Net.URLConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The HTTP request method of this <c> HttpURLConnection </c> . The default value is <c> "GET" </c> . </para>        
				/// </summary>
				/// <java-name>
				/// method
				/// </java-name>
				[Dot42.DexImport("method", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string Method;
				/// <summary>
				/// <para>The status code of the response obtained from the HTTP request. The default value is <c> -1 </c> . </para><para>1xx: Informational 2xx: Success 3xx: Relocation/Redirection 4xx: Client Error 5xx: Server Error </para>        
				/// </summary>
				/// <java-name>
				/// responseCode
				/// </java-name>
				[Dot42.DexImport("responseCode", "I", AccessFlags = 4)]
				protected internal int ResponseCode;
				/// <summary>
				/// <para>The HTTP response message which corresponds to the response code. </para>        
				/// </summary>
				/// <java-name>
				/// responseMessage
				/// </java-name>
				[Dot42.DexImport("responseMessage", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string ResponseMessage;
				/// <summary>
				/// <para>Flag to define whether the protocol will automatically follow redirects or not. The default value is <c> true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// instanceFollowRedirects
				/// </java-name>
				[Dot42.DexImport("instanceFollowRedirects", "Z", AccessFlags = 4)]
				protected internal bool InstanceFollowRedirects;
				/// <summary>
				/// <para>If the HTTP chunked encoding is enabled this parameter defines the chunk-length. Default value is <c> -1 </c> that means the chunked encoding mode is disabled. </para>        
				/// </summary>
				/// <java-name>
				/// chunkLength
				/// </java-name>
				[Dot42.DexImport("chunkLength", "I", AccessFlags = 4)]
				protected internal int ChunkLength;
				/// <summary>
				/// <para>If using HTTP fixed-length streaming mode this parameter defines the fixed length of content. Default value is <c> -1 </c> that means the fixed-length streaming mode is disabled. </para>        
				/// </summary>
				/// <java-name>
				/// fixedContentLength
				/// </java-name>
				[Dot42.DexImport("fixedContentLength", "I", AccessFlags = 4)]
				protected internal int FixedContentLength;
				/// <summary>
				/// <para>Numeric status code, 202: Accepted </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_ACCEPTED
				/// </java-name>
				[Dot42.DexImport("HTTP_ACCEPTED", "I", AccessFlags = 25)]
				public const int HTTP_ACCEPTED = 202;
				/// <summary>
				/// <para>Numeric status code, 502: Bad Gateway </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_BAD_GATEWAY
				/// </java-name>
				[Dot42.DexImport("HTTP_BAD_GATEWAY", "I", AccessFlags = 25)]
				public const int HTTP_BAD_GATEWAY = 502;
				/// <summary>
				/// <para>Numeric status code, 405: Bad Method </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_BAD_METHOD
				/// </java-name>
				[Dot42.DexImport("HTTP_BAD_METHOD", "I", AccessFlags = 25)]
				public const int HTTP_BAD_METHOD = 405;
				/// <summary>
				/// <para>Numeric status code, 400: Bad Request </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_BAD_REQUEST
				/// </java-name>
				[Dot42.DexImport("HTTP_BAD_REQUEST", "I", AccessFlags = 25)]
				public const int HTTP_BAD_REQUEST = 400;
				/// <summary>
				/// <para>Numeric status code, 408: Client Timeout </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_CLIENT_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("HTTP_CLIENT_TIMEOUT", "I", AccessFlags = 25)]
				public const int HTTP_CLIENT_TIMEOUT = 408;
				/// <summary>
				/// <para>Numeric status code, 409: Conflict </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_CONFLICT
				/// </java-name>
				[Dot42.DexImport("HTTP_CONFLICT", "I", AccessFlags = 25)]
				public const int HTTP_CONFLICT = 409;
				/// <summary>
				/// <para>Numeric status code, 201: Created </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_CREATED
				/// </java-name>
				[Dot42.DexImport("HTTP_CREATED", "I", AccessFlags = 25)]
				public const int HTTP_CREATED = 201;
				/// <summary>
				/// <para>Numeric status code, 413: Entity too large </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_ENTITY_TOO_LARGE
				/// </java-name>
				[Dot42.DexImport("HTTP_ENTITY_TOO_LARGE", "I", AccessFlags = 25)]
				public const int HTTP_ENTITY_TOO_LARGE = 413;
				/// <summary>
				/// <para>Numeric status code, 403: Forbidden </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_FORBIDDEN
				/// </java-name>
				[Dot42.DexImport("HTTP_FORBIDDEN", "I", AccessFlags = 25)]
				public const int HTTP_FORBIDDEN = 403;
				/// <summary>
				/// <para>Numeric status code, 504: Gateway timeout </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_GATEWAY_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("HTTP_GATEWAY_TIMEOUT", "I", AccessFlags = 25)]
				public const int HTTP_GATEWAY_TIMEOUT = 504;
				/// <summary>
				/// <para>Numeric status code, 410: Gone </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_GONE
				/// </java-name>
				[Dot42.DexImport("HTTP_GONE", "I", AccessFlags = 25)]
				public const int HTTP_GONE = 410;
				/// <summary>
				/// <para>Numeric status code, 500: Internal error </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_INTERNAL_ERROR
				/// </java-name>
				[Dot42.DexImport("HTTP_INTERNAL_ERROR", "I", AccessFlags = 25)]
				public const int HTTP_INTERNAL_ERROR = 500;
				/// <summary>
				/// <para>Numeric status code, 411: Length required </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_LENGTH_REQUIRED
				/// </java-name>
				[Dot42.DexImport("HTTP_LENGTH_REQUIRED", "I", AccessFlags = 25)]
				public const int HTTP_LENGTH_REQUIRED = 411;
				/// <summary>
				/// <para>Numeric status code, 301 Moved permanently </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_MOVED_PERM
				/// </java-name>
				[Dot42.DexImport("HTTP_MOVED_PERM", "I", AccessFlags = 25)]
				public const int HTTP_MOVED_PERM = 301;
				/// <summary>
				/// <para>Numeric status code, 302: Moved temporarily </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_MOVED_TEMP
				/// </java-name>
				[Dot42.DexImport("HTTP_MOVED_TEMP", "I", AccessFlags = 25)]
				public const int HTTP_MOVED_TEMP = 302;
				/// <summary>
				/// <para>Numeric status code, 300: Multiple choices </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_MULT_CHOICE
				/// </java-name>
				[Dot42.DexImport("HTTP_MULT_CHOICE", "I", AccessFlags = 25)]
				public const int HTTP_MULT_CHOICE = 300;
				/// <summary>
				/// <para>Numeric status code, 204: No content </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_NO_CONTENT
				/// </java-name>
				[Dot42.DexImport("HTTP_NO_CONTENT", "I", AccessFlags = 25)]
				public const int HTTP_NO_CONTENT = 204;
				/// <summary>
				/// <para>Numeric status code, 406: Not acceptable </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_NOT_ACCEPTABLE
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_ACCEPTABLE", "I", AccessFlags = 25)]
				public const int HTTP_NOT_ACCEPTABLE = 406;
				/// <summary>
				/// <para>Numeric status code, 203: Not authoritative </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_NOT_AUTHORITATIVE
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_AUTHORITATIVE", "I", AccessFlags = 25)]
				public const int HTTP_NOT_AUTHORITATIVE = 203;
				/// <summary>
				/// <para>Numeric status code, 404: Not found </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_NOT_FOUND
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_FOUND", "I", AccessFlags = 25)]
				public const int HTTP_NOT_FOUND = 404;
				/// <summary>
				/// <para>Numeric status code, 501: Not implemented </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_NOT_IMPLEMENTED
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_IMPLEMENTED", "I", AccessFlags = 25)]
				public const int HTTP_NOT_IMPLEMENTED = 501;
				/// <summary>
				/// <para>Numeric status code, 304: Not modified </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_NOT_MODIFIED
				/// </java-name>
				[Dot42.DexImport("HTTP_NOT_MODIFIED", "I", AccessFlags = 25)]
				public const int HTTP_NOT_MODIFIED = 304;
				/// <summary>
				/// <para>Numeric status code, 200: OK </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_OK
				/// </java-name>
				[Dot42.DexImport("HTTP_OK", "I", AccessFlags = 25)]
				public const int HTTP_OK = 200;
				/// <summary>
				/// <para>Numeric status code, 206: Partial </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_PARTIAL
				/// </java-name>
				[Dot42.DexImport("HTTP_PARTIAL", "I", AccessFlags = 25)]
				public const int HTTP_PARTIAL = 206;
				/// <summary>
				/// <para>Numeric status code, 402: Payment required </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_PAYMENT_REQUIRED
				/// </java-name>
				[Dot42.DexImport("HTTP_PAYMENT_REQUIRED", "I", AccessFlags = 25)]
				public const int HTTP_PAYMENT_REQUIRED = 402;
				/// <summary>
				/// <para>Numeric status code, 412: Precondition failed </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_PRECON_FAILED
				/// </java-name>
				[Dot42.DexImport("HTTP_PRECON_FAILED", "I", AccessFlags = 25)]
				public const int HTTP_PRECON_FAILED = 412;
				/// <summary>
				/// <para>Numeric status code, 407: Proxy authentication required </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_PROXY_AUTH
				/// </java-name>
				[Dot42.DexImport("HTTP_PROXY_AUTH", "I", AccessFlags = 25)]
				public const int HTTP_PROXY_AUTH = 407;
				/// <summary>
				/// <para>Numeric status code, 414: Request too long </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_REQ_TOO_LONG
				/// </java-name>
				[Dot42.DexImport("HTTP_REQ_TOO_LONG", "I", AccessFlags = 25)]
				public const int HTTP_REQ_TOO_LONG = 414;
				/// <summary>
				/// <para>Numeric status code, 205: Reset </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_RESET
				/// </java-name>
				[Dot42.DexImport("HTTP_RESET", "I", AccessFlags = 25)]
				public const int HTTP_RESET = 205;
				/// <summary>
				/// <para>Numeric status code, 303: See other </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_SEE_OTHER
				/// </java-name>
				[Dot42.DexImport("HTTP_SEE_OTHER", "I", AccessFlags = 25)]
				public const int HTTP_SEE_OTHER = 303;
				/// <summary>
				/// <para>Numeric status code, 500: Internal error</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use HTTP_INTERNAL_ERROR </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// HTTP_SERVER_ERROR
				/// </java-name>
				[Dot42.DexImport("HTTP_SERVER_ERROR", "I", AccessFlags = 25)]
				public const int HTTP_SERVER_ERROR = 500;
				/// <summary>
				/// <para>Numeric status code, 305: Use proxy.</para><para>Like Firefox and Chrome, this class doesn't honor this response code. Other implementations respond to this status code by retrying the request using the HTTP proxy named by the response's Location header field. </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_USE_PROXY
				/// </java-name>
				[Dot42.DexImport("HTTP_USE_PROXY", "I", AccessFlags = 25)]
				public const int HTTP_USE_PROXY = 305;
				/// <summary>
				/// <para>Numeric status code, 401: Unauthorized </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_UNAUTHORIZED
				/// </java-name>
				[Dot42.DexImport("HTTP_UNAUTHORIZED", "I", AccessFlags = 25)]
				public const int HTTP_UNAUTHORIZED = 401;
				/// <summary>
				/// <para>Numeric status code, 415: Unsupported type </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_UNSUPPORTED_TYPE
				/// </java-name>
				[Dot42.DexImport("HTTP_UNSUPPORTED_TYPE", "I", AccessFlags = 25)]
				public const int HTTP_UNSUPPORTED_TYPE = 415;
				/// <summary>
				/// <para>Numeric status code, 503: Unavailable </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("HTTP_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int HTTP_UNAVAILABLE = 503;
				/// <summary>
				/// <para>Numeric status code, 505: Version not supported </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_VERSION
				/// </java-name>
				[Dot42.DexImport("HTTP_VERSION", "I", AccessFlags = 25)]
				public const int HTTP_VERSION = 505;
				/// <summary>
				/// <para>Constructs a new <c> HttpURLConnection </c> instance pointing to the resource specified by the <c> url </c> .</para><para><para>URL </para><simplesectsep></simplesectsep><para>URLConnection </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal HttpURLConnection(global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Releases this connection so that its resources may be either reused or closed.</para><para>Unlike other Java implementations, this will not necessarily close socket connections that can be reused. You can disable all connection reuse by setting the <c> http.keepAlive </c> system property to <c>       false </c> before issuing any HTTP requests. </para>        
				/// </summary>
				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()V", AccessFlags = 1025)]
				public abstract void Disconnect() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an input stream from the server in the case of an error such as the requested file has not been found on the remote server. This stream can be used to read the data the server will send back.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the error input stream returned by the server. </para>
				/// </returns>
				/// <java-name>
				/// getErrorStream
				/// </java-name>
				[Dot42.DexImport("getErrorStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetErrorStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Returns the value of <c> followRedirects </c> which indicates if this connection follows a different URL redirected by the server. It is enabled by default.</para><para><para>setFollowRedirects </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the flag. </para>
				/// </returns>
				/// <java-name>
				/// getFollowRedirects
				/// </java-name>
				[Dot42.DexImport("getFollowRedirects", "()Z", AccessFlags = 9)]
				public static bool GetFollowRedirects() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the permission object (in this case <c> SocketPermission </c> ) with the host and the port number as the target name and <c>       "resolve, connect" </c> as the action list. If the port number of this URL instance is lower than <c> 0 </c> the port will be set to <c> 80 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the permission object required for this connection. </para>
				/// </returns>
				/// <java-name>
				/// getPermission
				/// </java-name>
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
				public override global::Java.Security.Permission GetPermission() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Permission);
				}

				/// <summary>
				/// <para>Returns the request method which will be used to make the request to the remote HTTP server. All possible methods of this HTTP implementation is listed in the class definition.</para><para><para>method </para><simplesectsep></simplesectsep><para>setRequestMethod </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the request method string. </para>
				/// </returns>
				/// <java-name>
				/// getRequestMethod
				/// </java-name>
				[Dot42.DexImport("getRequestMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetRequestMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the response code returned by the remote HTTP server.</para><para><para>getResponseMessage </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response code, -1 if no valid response code. </para>
				/// </returns>
				/// <java-name>
				/// getResponseCode
				/// </java-name>
				[Dot42.DexImport("getResponseCode", "()I", AccessFlags = 1)]
				public virtual int GetResponseCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the response message returned by the remote HTTP server.</para><para><para>getResponseCode() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response message. <c> null </c> if no such response exists. </para>
				/// </returns>
				/// <java-name>
				/// getResponseMessage
				/// </java-name>
				[Dot42.DexImport("getResponseMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResponseMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the flag of whether this connection will follow redirects returned by the remote server.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFollowRedirects
				/// </java-name>
				[Dot42.DexImport("setFollowRedirects", "(Z)V", AccessFlags = 9)]
				public static void SetFollowRedirects(bool auto) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the request command which will be sent to the remote HTTP server. This method can only be called before the connection is made.</para><para><para>getRequestMethod() </para><simplesectsep></simplesectsep><para>method </para></para>        
				/// </summary>
				/// <java-name>
				/// setRequestMethod
				/// </java-name>
				[Dot42.DexImport("setRequestMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetRequestMethod(string method) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether this connection uses a proxy server or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this connection passes a proxy server, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// usingProxy
				/// </java-name>
				[Dot42.DexImport("usingProxy", "()Z", AccessFlags = 1025)]
				public abstract bool UsingProxy() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the encoding used to transmit the response body over the network. This is null or "identity" if the content was not encoded, or "gzip" if the body was gzip compressed. Most callers will be more interested in the content type, which may also include the content's character encoding. </para>        
				/// </summary>
				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				[Dot42.DexImport("getContentEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetContentEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns whether this connection follows redirects.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this connection follows redirects, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getInstanceFollowRedirects
				/// </java-name>
				[Dot42.DexImport("getInstanceFollowRedirects", "()Z", AccessFlags = 1)]
				public virtual bool GetInstanceFollowRedirects() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this connection follows redirects.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInstanceFollowRedirects
				/// </java-name>
				[Dot42.DexImport("setInstanceFollowRedirects", "(Z)V", AccessFlags = 1)]
				public virtual void SetInstanceFollowRedirects(bool followRedirects) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the date value in milliseconds since <c> 01.01.1970, 00:00h </c> corresponding to the header field <c> field </c> . The <c> defaultValue </c> will be returned if no such field can be found in the response header.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the header field represented in milliseconds since January 1, 1970 GMT. </para>
				/// </returns>
				/// <java-name>
				/// getHeaderFieldDate
				/// </java-name>
				[Dot42.DexImport("getHeaderFieldDate", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public override long GetHeaderFieldDate(string field, long defaultValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>If the length of a HTTP request body is known ahead, sets fixed length to enable streaming without buffering. Sets after connection will cause an exception.</para><para><para>setChunkedStreamingMode </para></para>        
				/// </summary>
				/// <java-name>
				/// setFixedLengthStreamingMode
				/// </java-name>
				[Dot42.DexImport("setFixedLengthStreamingMode", "(I)V", AccessFlags = 1)]
				public virtual void SetFixedLengthStreamingMode(int contentLength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stream a request body whose length is not known in advance. Old HTTP/1.0 only servers may not support this mode.</para><para>When HTTP chunked encoding is used, the stream is divided into chunks, each prefixed with a header containing the chunk's size. Setting a large chunk length requires a large internal buffer, potentially wasting memory. Setting a small chunk length increases the number of bytes that must be transmitted because of the header on every chunk. Most caller should use <c> 0 </c> to get the system default.</para><para><para>setFixedLengthStreamingMode </para></para>        
				/// </summary>
				/// <java-name>
				/// setChunkedStreamingMode
				/// </java-name>
				[Dot42.DexImport("setChunkedStreamingMode", "(I)V", AccessFlags = 1)]
				public virtual void SetChunkedStreamingMode(int chunkLength) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpURLConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns an input stream from the server in the case of an error such as the requested file has not been found on the remote server. This stream can be used to read the data the server will send back.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the error input stream returned by the server. </para>
				/// </returns>
				/// <java-name>
				/// getErrorStream
				/// </java-name>
				public global::Java.Io.InputStream ErrorStream
				{
				[Dot42.DexImport("getErrorStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetErrorStream(); }
				}

				/// <summary>
				/// <para>Returns the value of <c> followRedirects </c> which indicates if this connection follows a different URL redirected by the server. It is enabled by default.</para><para><para>setFollowRedirects </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the flag. </para>
				/// </returns>
				/// <java-name>
				/// getFollowRedirects
				/// </java-name>
				public static bool IsFollowRedirects
				{
				[Dot42.DexImport("getFollowRedirects", "()Z", AccessFlags = 9)]
						get{ return GetFollowRedirects(); }
				[Dot42.DexImport("setFollowRedirects", "(Z)V", AccessFlags = 9)]
						set{ SetFollowRedirects(value); }
				}

				/// <summary>
				/// <para>Returns the permission object (in this case <c> SocketPermission </c> ) with the host and the port number as the target name and <c>       "resolve, connect" </c> as the action list. If the port number of this URL instance is lower than <c> 0 </c> the port will be set to <c> 80 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the permission object required for this connection. </para>
				/// </returns>
				/// <java-name>
				/// getPermission
				/// </java-name>
				public global::Java.Security.Permission Permission
				{
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
						get{ return GetPermission(); }
				}

				/// <summary>
				/// <para>Returns the request method which will be used to make the request to the remote HTTP server. All possible methods of this HTTP implementation is listed in the class definition.</para><para><para>method </para><simplesectsep></simplesectsep><para>setRequestMethod </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the request method string. </para>
				/// </returns>
				/// <java-name>
				/// getRequestMethod
				/// </java-name>
				public string RequestMethod
				{
				[Dot42.DexImport("getRequestMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRequestMethod(); }
				[Dot42.DexImport("setRequestMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetRequestMethod(value); }
				}

				/// <summary>
				/// <para>Returns the encoding used to transmit the response body over the network. This is null or "identity" if the content was not encoded, or "gzip" if the body was gzip compressed. Most callers will be more interested in the content type, which may also include the content's character encoding. </para>        
				/// </summary>
				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				public string ContentEncoding
				{
				[Dot42.DexImport("getContentEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetContentEncoding(); }
				}

				/// <summary>
				/// <para>Returns whether this connection follows redirects.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this connection follows redirects, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getInstanceFollowRedirects
				/// </java-name>
				public bool IsInstanceFollowRedirects
				{
				[Dot42.DexImport("getInstanceFollowRedirects", "()Z", AccessFlags = 1)]
						get{ return GetInstanceFollowRedirects(); }
				[Dot42.DexImport("setInstanceFollowRedirects", "(Z)V", AccessFlags = 1)]
						set{ SetInstanceFollowRedirects(value); }
				}

		}

		/// <summary>
		/// <para>Defines a factory which is responsible for creating a <c> ContentHandler </c> .</para><para><para>ContentHandler </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/ContentHandlerFactory
		/// </java-name>
		[Dot42.DexImport("java/net/ContentHandlerFactory", AccessFlags = 1537)]
		public partial interface IContentHandlerFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a content handler to handle <c> contentType </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>content handler object for a specific content type. </para>
				/// </returns>
				/// <java-name>
				/// createContentHandler
				/// </java-name>
				[Dot42.DexImport("createContentHandler", "(Ljava/lang/String;)Ljava/net/ContentHandler;", AccessFlags = 1025)]
				global::Java.Net.ContentHandler CreateContentHandler(string contentType) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <c> ConnectException </c> is thrown if a connection cannot be established to a remote host on a specific port.</para><para>Most applications <b>should not</b> catch this exception; it is more robust to catch the superclass <c> SocketException </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/net/ConnectException
		/// </java-name>
		[Dot42.DexImport("java/net/ConnectException", AccessFlags = 33)]
		public partial class ConnectException : global::Java.Net.SocketException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConnectException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConnectException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A Uniform Resource Locator that identifies the location of an Internet resource as specified by .</para><para><h3>Parts of a URL</h3></para><para>A URL is composed of many parts. This class can both parse URL strings into parts and compose URL strings from parts. For example, consider the parts of this URL: <c> http://username:password@host:8080/directory/file?query#ref </c> : <table><row><entry><para>Component</para></entry><entry><para>Example value</para></entry><entry><para>Also known as </para></entry></row><row><entry><para>Protocol</para></entry><entry><para><c> http </c> </para></entry><entry><para>scheme </para></entry></row><row><entry><para>Authority</para></entry><entry><para><c> username:password@host:8080 </c> </para></entry><entry><para></para></entry></row><row><entry><para>User Info</para></entry><entry><para><c> username:password </c> </para></entry><entry><para></para></entry></row><row><entry><para>Host</para></entry><entry><para><c> host </c> </para></entry><entry><para></para></entry></row><row><entry><para>Port</para></entry><entry><para><c> 8080 </c> </para></entry><entry><para></para></entry></row><row><entry><para>File</para></entry><entry><para><c> /directory/file?query </c> </para></entry><entry><para></para></entry></row><row><entry><para>Path</para></entry><entry><para><c> /directory/file </c> </para></entry><entry><para></para></entry></row><row><entry><para>Query</para></entry><entry><para><c> query </c> </para></entry><entry><para></para></entry></row><row><entry><para>Ref</para></entry><entry><para><c> ref </c> </para></entry><entry><para>fragment </para></entry></row></table></para><para><h3>Supported Protocols</h3></para><para>This class may be used to construct URLs with the following protocols: <ul><li><para><b>file</b>: read files from the local filesystem. </para></li><li><para><b>ftp</b>:  </para></li><li><para><b>http</b>:  </para></li><li><para><b>https</b>:  </para></li><li><para><b>jar</b>: read Jar files from the filesystem </para></li></ul>In general, attempts to create URLs with any other protocol will fail with a MalformedURLException. Applications may install handlers for other schemes using setURLStreamHandlerFactory or with the <c>   java.protocol.handler.pkgs </c> system property.</para><para>The URI class can be used to manipulate URLs of any protocol. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URL
		/// </java-name>
		[Dot42.DexImport("java/net/URL", AccessFlags = 49)]
		public sealed partial class URL : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new URL instance by parsing <c> spec </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public URL(string spec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new URL by resolving <c> spec </c> relative to <c> context </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/URL;Ljava/lang/String;)V", AccessFlags = 1)]
				public URL(global::Java.Net.URL context, string spec) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V", AccessFlags = 1)]
				public URL(global::Java.Net.URL uRL, string @string, global::Java.Net.URLStreamHandler uRLStreamHandler) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public URL(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new URL of the given component parts. The URL uses the protocol's default port.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public URL(string protocol, string host, int port, string file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new URL of the given component parts. The URL uses the protocol's default port.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandle" +
    "r;)V", AccessFlags = 1)]
				public URL(string protocol, string host, int port, string file, global::Java.Net.URLStreamHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the stream handler factory for this VM.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setURLStreamHandlerFactory
				/// </java-name>
				[Dot42.DexImport("setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V", AccessFlags = 41)]
				public static void SetURLStreamHandlerFactory(global::Java.Net.IURLStreamHandlerFactory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the properties of this URL using the provided arguments. Only a <c> URLStreamHandler </c> can use this method to set fields of the existing URL instance. A URL is generally constant. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				internal void Set(string protocol, string host, int port, string file, string @ref) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if this URL equals <c> o </c> . URLs are equal if they have the same protocol, host, port, file, and reference.</para><para><h3>Network I/O Warning</h3></para><para>Some implementations of URL.equals() resolve host names over the network. This is problematic: <ul><li><para><b>The network may be slow.</b> Many classes, including core collections like Map and Set expect that <c> equals </c> and <c> hashCode </c> will return quickly. By violating this assumption, this method posed potential performance problems. </para></li><li><para><b>Equal IP addresses do not imply equal content.</b> Virtual hosting permits unrelated sites to share an IP address. This method could report two otherwise unrelated URLs to be equal because they're hosted on the same server. </para></li><li><para><b>The network many not be available.</b> Two URLs could be equal when a network is available and unequal otherwise. </para></li><li><para><b>The network may change.</b> The IP address for a given host name varies by network and over time. This is problematic for mobile devices. Two URLs could be equal on some networks and unequal on others. </para></li></ul></para><para>This problem is fixed in Android 4.0 (Ice Cream Sandwich). In that release, URLs are only equal if their host names are equal (ignoring case). </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this URL refers to the same resource as <c> otherURL </c> . All URL components except the reference field are compared. </para>        
				/// </summary>
				/// <java-name>
				/// sameFile
				/// </java-name>
				[Dot42.DexImport("sameFile", "(Ljava/net/URL;)Z", AccessFlags = 1)]
				public bool SameFile(global::Java.Net.URL otherURL) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the content of the resource which is referred by this URL. By default this returns an <c> InputStream </c> , or null if the content type of the response is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object GetContent() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Equivalent to <c> openConnection().getContent(types) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetContent(global::System.Type[] types) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Equivalent to <c> openConnection().getInputStream(types) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// openStream
				/// </java-name>
				[Dot42.DexImport("openStream", "()Ljava/io/InputStream;", AccessFlags = 17)]
				public global::Java.Io.InputStream OpenStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Returns a new connection to the resource referred to by this URL.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "()Ljava/net/URLConnection;", AccessFlags = 1)]
				public global::Java.Net.URLConnection OpenConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLConnection);
				}

				/// <summary>
				/// <para>Returns the URI equivalent to this URL.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// toURI
				/// </java-name>
				[Dot42.DexImport("toURI", "()Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri ToURI() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>Returns a new connection to the resource referred to by this URL.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// openConnection
				/// </java-name>
				[Dot42.DexImport("openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;", AccessFlags = 1)]
				public global::Java.Net.URLConnection OpenConnection(global::Java.Net.Proxy proxy) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLConnection);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable representation of this URL. The returned string is the same as the result of the method <c> toExternalForm() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable representation of this URL. </para>        
				/// </summary>
				/// <java-name>
				/// toExternalForm
				/// </java-name>
				[Dot42.DexImport("toExternalForm", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToExternalForm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the file of this URL. </para>        
				/// </summary>
				/// <java-name>
				/// getFile
				/// </java-name>
				[Dot42.DexImport("getFile", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetFile() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the host name or IP address of this URL. </para>        
				/// </summary>
				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the port number of this URL or <c> -1 </c> if this URL has no explicit port.</para><para>If this URL has no explicit port, connections opened using this URL will use its default port. </para>        
				/// </summary>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the protocol of this URL like "http" or "file". This is also known as the scheme. The returned string is lower case. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocol
				/// </java-name>
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetProtocol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value of the reference part of this URL, or null if this URL has no reference part. This is also known as the fragment. </para>        
				/// </summary>
				/// <java-name>
				/// getRef
				/// </java-name>
				[Dot42.DexImport("getRef", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetRef() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the query part of this URL, or null if this URL has no query. </para>        
				/// </summary>
				/// <java-name>
				/// getQuery
				/// </java-name>
				[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetQuery() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the path part of this URL. </para>        
				/// </summary>
				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the user info of this URL, or null if this URL has no user info. </para>        
				/// </summary>
				/// <java-name>
				/// getUserInfo
				/// </java-name>
				[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetUserInfo() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the authority part of this URL, or null if this URL has no authority. </para>        
				/// </summary>
				/// <java-name>
				/// getAuthority
				/// </java-name>
				[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetAuthority() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the properties of this URL using the provided arguments. Only a <c> URLStreamHandler </c> can use this method to set fields of the existing URL instance. A URL is generally constant. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/l" +
    "ang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				internal void Set(string protocol, string host, int port, string authority, string userInfo, string path, string query, string @ref) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default port number of the protocol used by this URL. If no default port is defined by the protocol or the <c> URLStreamHandler </c> , <c> -1 </c> will be returned.</para><para><para>URLStreamHandler::getDefaultPort </para></para>        
				/// </summary>
				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 1)]
				public int GetDefaultPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URL() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the content of the resource which is referred by this URL. By default this returns an <c> InputStream </c> , or null if the content type of the response is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getContent
				/// </java-name>
				public object Content
				{
				[Dot42.DexImport("getContent", "()Ljava/lang/Object;", AccessFlags = 17)]
						get{ return GetContent(); }
				}

				/// <summary>
				/// <para>Returns the file of this URL. </para>        
				/// </summary>
				/// <java-name>
				/// getFile
				/// </java-name>
				public string File
				{
				[Dot42.DexImport("getFile", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFile(); }
				}

				/// <summary>
				/// <para>Returns the host name or IP address of this URL. </para>        
				/// </summary>
				/// <java-name>
				/// getHost
				/// </java-name>
				public string Host
				{
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHost(); }
				}

				/// <summary>
				/// <para>Returns the port number of this URL or <c> -1 </c> if this URL has no explicit port.</para><para>If this URL has no explicit port, connections opened using this URL will use its default port. </para>        
				/// </summary>
				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <summary>
				/// <para>Returns the protocol of this URL like "http" or "file". This is also known as the scheme. The returned string is lower case. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocol
				/// </java-name>
				public string Protocol
				{
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProtocol(); }
				}

				/// <summary>
				/// <para>Returns the value of the reference part of this URL, or null if this URL has no reference part. This is also known as the fragment. </para>        
				/// </summary>
				/// <java-name>
				/// getRef
				/// </java-name>
				public string Ref
				{
				[Dot42.DexImport("getRef", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRef(); }
				}

				/// <summary>
				/// <para>Returns the query part of this URL, or null if this URL has no query. </para>        
				/// </summary>
				/// <java-name>
				/// getQuery
				/// </java-name>
				public string Query
				{
				[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetQuery(); }
				}

				/// <summary>
				/// <para>Returns the path part of this URL. </para>        
				/// </summary>
				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPath(); }
				}

				/// <summary>
				/// <para>Returns the user info of this URL, or null if this URL has no user info. </para>        
				/// </summary>
				/// <java-name>
				/// getUserInfo
				/// </java-name>
				public string UserInfo
				{
				[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUserInfo(); }
				}

				/// <summary>
				/// <para>Returns the authority part of this URL, or null if this URL has no authority. </para>        
				/// </summary>
				/// <java-name>
				/// getAuthority
				/// </java-name>
				public string Authority
				{
				[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAuthority(); }
				}

				/// <summary>
				/// <para>Returns the default port number of the protocol used by this URL. If no default port is defined by the protocol or the <c> URLStreamHandler </c> , <c> -1 </c> will be returned.</para><para><para>URLStreamHandler::getDefaultPort </para></para>        
				/// </summary>
				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				public int DefaultPort
				{
				[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 1)]
						get{ return GetDefaultPort(); }
				}

		}

		/// <summary>
		/// <para>An IPv4 address. See InetAddress. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/Inet4Address
		/// </java-name>
		[Dot42.DexImport("java/net/Inet4Address", AccessFlags = 49)]
		public sealed partial class Inet4Address : global::Java.Net.InetAddress
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Inet4Address() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether this address is a multicast address or not.</para><para>Valid IPv6 multicast addresses have the prefix <c> ff::/8 </c> .</para><para>Valid IPv4 multicast addresses have the prefix <c> 224/4 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMulticastAddress
				/// </java-name>
				[Dot42.DexImport("isMulticastAddress", "()Z", AccessFlags = 1)]
				public override bool IsMulticastAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this is the IPv6 unspecified wildcard address <c> :: </c> or the IPv4 "any" address, <c> 0.0.0.0 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isAnyLocalAddress
				/// </java-name>
				[Dot42.DexImport("isAnyLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsAnyLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a loopback address or not.</para><para>Valid IPv4 loopback addresses have the prefix <c> 127/8 </c> .</para><para>The only valid IPv6 loopback address is <c> ::1 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isLoopbackAddress
				/// </java-name>
				[Dot42.DexImport("isLoopbackAddress", "()Z", AccessFlags = 1)]
				public override bool IsLoopbackAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a link-local address or not.</para><para>Valid IPv6 link-local addresses have the prefix <c> fe80::/10 </c> .</para><para> "Default Address Selection for Internet Protocol Version 6 (IPv6)" states that both IPv4 auto-configuration addresses (prefix <c> 169.254/16 </c> ) and IPv4 loopback addresses (prefix <c> 127/8 </c> ) have link-local scope, but Inet4Address only considers the auto-configuration addresses to have link-local scope. That is: the IPv4 loopback address returns false. </para>        
				/// </summary>
				/// <java-name>
				/// isLinkLocalAddress
				/// </java-name>
				[Dot42.DexImport("isLinkLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsLinkLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a site-local address or not.</para><para>For the purposes of this method, valid IPv6 site-local addresses have the deprecated prefix <c> fec0::/10 </c> from , <b>not</b> the modern prefix <c> fc00::/7 </c> from .</para><para> "Default Address Selection for Internet Protocol Version 6 (IPv6)" states that IPv4 private addresses have the prefix <c> 10/8 </c> , <c> 172.16/12 </c> , or <c> 192.168/16 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this instance represents a site-local address, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSiteLocalAddress
				/// </java-name>
				[Dot42.DexImport("isSiteLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsSiteLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a global multicast address or not.</para><para>Valid IPv6 global multicast addresses have the prefix <c> ffxe::/16 </c> , where <c> x </c> is a set of flags and the additional 112 bits make up the global multicast address space.</para><para>Valid IPv4 global multicast addresses are the range of addresses from <c> 224.0.1.0 </c> to <c> 238.255.255.255 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCGlobal
				/// </java-name>
				[Dot42.DexImport("isMCGlobal", "()Z", AccessFlags = 1)]
				public override bool IsMCGlobal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a node-local multicast address or not.</para><para>Valid IPv6 node-local multicast addresses have the prefix <c> ffx1::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>There are no valid IPv4 node-local multicast addresses. </para>        
				/// </summary>
				/// <java-name>
				/// isMCNodeLocal
				/// </java-name>
				[Dot42.DexImport("isMCNodeLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCNodeLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a link-local multicast address or not.</para><para>Valid IPv6 link-local multicast addresses have the prefix <c> ffx2::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 link-local multicast addresses have the prefix <c> 224.0.0/24 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCLinkLocal
				/// </java-name>
				[Dot42.DexImport("isMCLinkLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCLinkLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a site-local multicast address or not.</para><para>Valid IPv6 site-local multicast addresses have the prefix <c> ffx5::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 site-local multicast addresses have the prefix <c> 239.255/16 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCSiteLocal
				/// </java-name>
				[Dot42.DexImport("isMCSiteLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCSiteLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a organization-local multicast address or not.</para><para>Valid IPv6 organization-local multicast addresses have the prefix <c> ffx8::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 organization-local multicast addresses have the prefix <c> 239.192/14 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCOrgLocal
				/// </java-name>
				[Dot42.DexImport("isMCOrgLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCOrgLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>An opaque key-value value pair held by an HTTP client to permit a stateful session with an HTTP server. This class parses cookie headers for all three commonly used HTTP cookie specifications:</para><para><ul><li><para>The Netscape cookie spec is officially obsolete but widely used in practice. Each cookie contains one key-value pair and the following attributes: <c> Domain </c> , <c> Expires </c> , <c> Path </c> , and <c> Secure </c> . The version of cookies in this format is <c> 0 </c> . </para><para>There are no accessors for the <c> Expires </c> attribute. When parsed, expires attributes are assigned to the Max-Age attribute as an offset from now. </para></li><li><para> formalizes the Netscape cookie spec. It replaces the <c> Expires </c> timestamp with a <c> Max-Age </c> duration and adds <c> Comment </c> and <c>           Version </c> attributes. The version of cookies in this format is <c> 1 </c> . </para></li><li><para> refines RFC 2109. It adds <c> Discard </c> , <c> Port </c> , and <c>           CommentURL </c> attributes and renames the header from <c> Set-Cookie </c> to <c> Set-Cookie2 </c> . The version of cookies in this format is <c> 1 </c> . </para></li></ul></para><para>This implementation silently discards unrecognized attributes. In particular, the <c> HttpOnly </c> attribute is widely served but isn't in any of the above specs. It was introduced by Internet Explorer to prevent server cookies from being exposed in the DOM to JavaScript, etc.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/HttpCookie
		/// </java-name>
		[Dot42.DexImport("java/net/HttpCookie", AccessFlags = 49)]
		public sealed partial class HttpCookie : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new cookie.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpCookie(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if <c> host </c> matches the domain pattern <c> domain </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// domainMatches
				/// </java-name>
				[Dot42.DexImport("domainMatches", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool DomainMatches(string domainPattern, string host) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 9, Signature = "(Ljava/lang/String;)Ljava/util/List<Ljava/net/HttpCookie;>;")]
				public static global::Java.Util.IList<global::Java.Net.HttpCookie> Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Net.HttpCookie>);
				}

				/// <summary>
				/// <para>Returns the <c> Comment </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getComment
				/// </java-name>
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetComment() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value of <c> CommentURL </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getCommentURL
				/// </java-name>
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCommentURL() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> Discard </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getDiscard
				/// </java-name>
				[Dot42.DexImport("getDiscard", "()Z", AccessFlags = 1)]
				public bool GetDiscard() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the <c> Domain </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getDomain
				/// </java-name>
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetDomain() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> Max-Age </c> attribute, in delta-seconds. </para>        
				/// </summary>
				/// <java-name>
				/// getMaxAge
				/// </java-name>
				[Dot42.DexImport("getMaxAge", "()J", AccessFlags = 1)]
				public long GetMaxAge() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the name of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> Path </c> attribute. This cookie is visible to all subpaths. </para>        
				/// </summary>
				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> Port </c> attribute, usually containing comma-separated port numbers. A null port indicates that the cookie may be sent to any port. The empty string indicates that the cookie should only be sent to the port of the originating request. </para>        
				/// </summary>
				/// <java-name>
				/// getPortlist
				/// </java-name>
				[Dot42.DexImport("getPortlist", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPortlist() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> Secure </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getSecure
				/// </java-name>
				[Dot42.DexImport("getSecure", "()Z", AccessFlags = 1)]
				public bool GetSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the version of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns true if this cookie's Max-Age is 0. </para>        
				/// </summary>
				/// <java-name>
				/// hasExpired
				/// </java-name>
				[Dot42.DexImport("hasExpired", "()Z", AccessFlags = 1)]
				public bool HasExpired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set the <c> Comment </c> attribute of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetComment(string comment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the <c> CommentURL </c> attribute of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// setCommentURL
				/// </java-name>
				[Dot42.DexImport("setCommentURL", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetCommentURL(string commentURL) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the <c> Discard </c> attribute of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// setDiscard
				/// </java-name>
				[Dot42.DexImport("setDiscard", "(Z)V", AccessFlags = 1)]
				public void SetDiscard(bool discard) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the <c> Domain </c> attribute of this cookie. HTTP clients send cookies only to matching domains. </para>        
				/// </summary>
				/// <java-name>
				/// setDomain
				/// </java-name>
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetDomain(string pattern) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the <c> Max-Age </c> attribute of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// setMaxAge
				/// </java-name>
				[Dot42.DexImport("setMaxAge", "(J)V", AccessFlags = 1)]
				public void SetMaxAge(long deltaSeconds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the <c> Path </c> attribute of this cookie. HTTP clients send cookies to this path and its subpaths. </para>        
				/// </summary>
				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetPath(string path) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the <c> Port </c> attribute of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// setPortlist
				/// </java-name>
				[Dot42.DexImport("setPortlist", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetPortlist(string portList) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the <c> Secure </c> attribute of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// setSecure
				/// </java-name>
				[Dot42.DexImport("setSecure", "(Z)V", AccessFlags = 1)]
				public void SetSecure(bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the opaque value of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetValue(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the <c> Version </c> attribute of the cookie.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
				public void SetVersion(int newVersion) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns true if <c> object </c> is a cookie with the same domain, name and path. Domain and name use case-insensitive comparison; path uses a case-sensitive comparison. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hash code of this HTTP cookie: <pre>            name.toLowerCase(Locale.US).hashCode()
				/// 
				///              + (domain == null ? 0 : domain.toLowerCase(Locale.US).hashCode())
				/// 
				///              + (path == null ? 0 : path.hashCode())
				/// 
				///  </pre> </para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a string representing this cookie in the format used by the <c> Cookie </c> header line in an HTTP request. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpCookie() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> Comment </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getComment
				/// </java-name>
				public string Comment
				{
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetComment(); }
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetComment(value); }
				}

				/// <summary>
				/// <para>Returns the value of <c> CommentURL </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getCommentURL
				/// </java-name>
				public string CommentURL
				{
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCommentURL(); }
				[Dot42.DexImport("setCommentURL", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCommentURL(value); }
				}

				/// <summary>
				/// <para>Returns the <c> Discard </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getDiscard
				/// </java-name>
				public bool IsDiscard
				{
				[Dot42.DexImport("getDiscard", "()Z", AccessFlags = 1)]
						get{ return GetDiscard(); }
				[Dot42.DexImport("setDiscard", "(Z)V", AccessFlags = 1)]
						set{ SetDiscard(value); }
				}

				/// <summary>
				/// <para>Returns the <c> Domain </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getDomain
				/// </java-name>
				public string Domain
				{
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDomain(); }
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetDomain(value); }
				}

				/// <summary>
				/// <para>Returns the <c> Max-Age </c> attribute, in delta-seconds. </para>        
				/// </summary>
				/// <java-name>
				/// getMaxAge
				/// </java-name>
				public long MaxAge
				{
				[Dot42.DexImport("getMaxAge", "()J", AccessFlags = 1)]
						get{ return GetMaxAge(); }
				[Dot42.DexImport("setMaxAge", "(J)V", AccessFlags = 1)]
						set{ SetMaxAge(value); }
				}

				/// <summary>
				/// <para>Returns the name of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Returns the <c> Path </c> attribute. This cookie is visible to all subpaths. </para>        
				/// </summary>
				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPath(); }
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPath(value); }
				}

				/// <summary>
				/// <para>Returns the <c> Port </c> attribute, usually containing comma-separated port numbers. A null port indicates that the cookie may be sent to any port. The empty string indicates that the cookie should only be sent to the port of the originating request. </para>        
				/// </summary>
				/// <java-name>
				/// getPortlist
				/// </java-name>
				public string Portlist
				{
				[Dot42.DexImport("getPortlist", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPortlist(); }
				[Dot42.DexImport("setPortlist", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPortlist(value); }
				}

				/// <summary>
				/// <para>Returns the <c> Secure </c> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getSecure
				/// </java-name>
				public bool IsSecure
				{
				[Dot42.DexImport("getSecure", "()Z", AccessFlags = 1)]
						get{ return GetSecure(); }
				[Dot42.DexImport("setSecure", "(Z)V", AccessFlags = 1)]
						set{ SetSecure(value); }
				}

				/// <summary>
				/// <para>Returns the value of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetValue(value); }
				}

				/// <summary>
				/// <para>Returns the version of this cookie. </para>        
				/// </summary>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
						set{ SetVersion(value); }
				}

		}

		/// <summary>
		/// <para>This class provides a concrete implementation of CookieHandler. It separates the storage of cookies from the policy which decides to accept or deny cookies. The constructor can have two arguments: a CookieStore and a CookiePolicy. The former is in charge of cookie storage and the latter makes decision on acceptance/rejection.</para><para>CookieHandler is in the center of cookie management. User can make use of CookieHandler.setDefault to set a CookieManager as the default one used.</para><para>CookieManager.put uses CookiePolicy.shouldAccept to decide whether to put some cookies into a cookie store. Three built-in CookiePolicy is defined: ACCEPT_ALL, ACCEPT_NONE and ACCEPT_ORIGINAL_SERVER. Users can also customize the policy by implementing CookiePolicy. Any accepted HTTP cookie is stored in CookieStore and users can also have their own implementation. Up to now, Only add(URI, HttpCookie) and get(URI) are used by CookieManager. Other methods in this class may probably be used in a more complicated implementation.</para><para>There are many ways to customize user's own HTTP cookie management:</para><para>First, call CookieHandler.setDefault to set a new CookieHandler implementation. Second, call CookieHandler.getDefault to use CookieManager. The CookiePolicy and CookieStore used are customized. Third, use the customized CookiePolicy and the CookieStore.</para><para>This implementation conforms to  section 3.3.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/CookieManager
		/// </java-name>
		[Dot42.DexImport("java/net/CookieManager", AccessFlags = 33)]
		public partial class CookieManager : global::Java.Net.CookieHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new cookie manager.</para><para>The invocation of this constructor is the same as the invocation of CookieManager(null, null). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CookieManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new cookie manager using a specified cookie store and a cookie policy.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/CookieStore;Ljava/net/CookiePolicy;)V", AccessFlags = 1)]
				public CookieManager(global::Java.Net.ICookieStore store, global::Java.Net.ICookiePolicy cookiePolicy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Searches and gets all cookies in the cache by the specified uri in the request header.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a map that record all such cookies, the map is unchangeable </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;", AccessFlags = 1, Signature = "(Ljava/net/URI;Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String" +
    ";>;>;)Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;>;")]
				public override global::Java.Util.IMap<string, global::Java.Util.IList<string>> Get(global::System.Uri uri, global::Java.Util.IMap<string, global::Java.Util.IList<string>> requestHeaders) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Util.IList<string>>);
				}

				/// <summary>
				/// <para>Sets cookies according to uri and responseHeaders</para><para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/net/URI;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/net/URI;Ljava/util/Map<Ljava/lang/String;Ljava/util/List<Ljava/lang/String" +
    ";>;>;)V")]
				public override void Put(global::System.Uri uri, global::Java.Util.IMap<string, global::Java.Util.IList<string>> responseHeaders) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the cookie policy of this cookie manager.</para><para>ACCEPT_ORIGINAL_SERVER is the default policy for CookieManager.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCookiePolicy
				/// </java-name>
				[Dot42.DexImport("setCookiePolicy", "(Ljava/net/CookiePolicy;)V", AccessFlags = 1)]
				public virtual void SetCookiePolicy(global::Java.Net.ICookiePolicy cookiePolicy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets current cookie store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cookie store currently used by cookie manager. </para>
				/// </returns>
				/// <java-name>
				/// getCookieStore
				/// </java-name>
				[Dot42.DexImport("getCookieStore", "()Ljava/net/CookieStore;", AccessFlags = 1)]
				public virtual global::Java.Net.ICookieStore GetCookieStore() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ICookieStore);
				}

				/// <summary>
				/// <para>Gets current cookie store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cookie store currently used by cookie manager. </para>
				/// </returns>
				/// <java-name>
				/// getCookieStore
				/// </java-name>
				public global::Java.Net.ICookieStore CookieStore
				{
				[Dot42.DexImport("getCookieStore", "()Ljava/net/CookieStore;", AccessFlags = 1)]
						get{ return GetCookieStore(); }
				}

		}

		/// <summary>
		/// <para>Is thrown if no appropriate <c> ContentHandler </c> could be found for a particular service requested by the URL connection. This could be happened if there is an invalid MIME type or the application wants to send data over a read-only connection. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/UnknownServiceException
		/// </java-name>
		[Dot42.DexImport("java/net/UnknownServiceException", AccessFlags = 33)]
		public partial class UnknownServiceException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnknownServiceException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownServiceException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <c> URISyntaxException </c> will be thrown if some information could not be parsed while creating a URI. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URISyntaxException
		/// </java-name>
		[Dot42.DexImport("java/net/URISyntaxException", AccessFlags = 33)]
		public partial class URISyntaxException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> URISyntaxException </c> instance containing the string that caused the exception, a description of the problem and the index at which the error occurred.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public URISyntaxException(string input, string reason, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> URISyntaxException </c> instance containing the string that caused the exception and a description of the problem.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public URISyntaxException(string input, string reason) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the index at which the syntax error was found or <c> -1 </c> if the index is unknown/unavailable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the syntax error. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
				public virtual int GetIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets a description of the syntax error.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string describing the syntax error. </para>
				/// </returns>
				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReason() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the initial string that contains an invalid syntax.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string that caused the exception. </para>
				/// </returns>
				/// <java-name>
				/// getInput
				/// </java-name>
				[Dot42.DexImport("getInput", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetInput() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets a description of the exception, including the reason, the string that caused the syntax error and the position of the syntax error if available.</para><para><para>java.lang.Throwable::getMessage() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sting containing information about the exception. </para>
				/// </returns>
				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URISyntaxException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the index at which the syntax error was found or <c> -1 </c> if the index is unknown/unavailable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the syntax error. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				public int Index
				{
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return GetIndex(); }
				}

				/// <summary>
				/// <para>Gets a description of the syntax error.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string describing the syntax error. </para>
				/// </returns>
				/// <java-name>
				/// getReason
				/// </java-name>
				public string Reason
				{
				[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetReason(); }
				}

				/// <summary>
				/// <para>Gets the initial string that contains an invalid syntax.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string that caused the exception. </para>
				/// </returns>
				/// <java-name>
				/// getInput
				/// </java-name>
				public string Input
				{
				[Dot42.DexImport("getInput", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetInput(); }
				}

		}

		/// <summary>
		/// <para>This class is used to encode a string using the format required by <c> application/x-www-form-urlencoded </c> MIME content type.</para><para>All characters except letters ('a'..'z', 'A'..'Z') and numbers ('0'..'9') and characters '.', '-', '*', '_' are converted into their hexadecimal value prepended by ''. For example: '#' -&gt; %23. In addition, spaces are substituted by '+'. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URLEncoder
		/// </java-name>
		[Dot42.DexImport("java/net/URLEncoder", AccessFlags = 33)]
		public partial class URLEncoder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal URLEncoder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Equivalent to <c> encode(s, "UTF-8") </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use encode(String, String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Encode(string s) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Encodes <c> s </c> using the Charset named by <c> charsetName </c> . </para>        
				/// </summary>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Encode(string s, string charsetName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>This class represents proxy server settings. A created instance of <c>   Proxy </c> stores a type and an address and is immutable. There are three types of proxies: <ul><li><para>DIRECT </para></li><li><para>HTTP </para></li><li><para>SOCKS&lt;/ul </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/net/Proxy
		/// </java-name>
		[Dot42.DexImport("java/net/Proxy", AccessFlags = 33)]
		public partial class Proxy
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Represents the proxy type setting <c> Proxy.Type.DIRECT </c> . It tells protocol handlers that there is no proxy to be used. The address is set to <c> null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// NO_PROXY
				/// </java-name>
				[Dot42.DexImport("NO_PROXY", "Ljava/net/Proxy;", AccessFlags = 25)]
				public static readonly global::Java.Net.Proxy NO_PROXY;
				/// <summary>
				/// <para>Creates a new <c> Proxy </c> instance. <c> SocketAddress </c> must NOT be <c> null </c> when <c> type </c> is either <c> Proxy.Type.HTTP </c> or <c> Proxy.Type.SOCKS </c> . To create a <c> Proxy </c> instance representing the proxy type <c> Proxy.Type.DIRECT </c> , use <c> Proxy.NO_PROXY </c> instead of this constructor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/Proxy$Type;Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public Proxy(global::Java.Net.Proxy.JavaType type, global::Java.Net.SocketAddress sa) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the type of this <c> Proxy </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the stored proxy type. </para>
				/// </returns>
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "()Ljava/net/Proxy$Type;", AccessFlags = 1)]
				public virtual global::Java.Net.Proxy.JavaType Type() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Proxy.JavaType);
				}

				/// <summary>
				/// <para>Gets the address of this <c> Proxy </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the stored proxy address or <c> null </c> if the proxy type is <c> DIRECT </c> . </para>
				/// </returns>
				/// <java-name>
				/// address
				/// </java-name>
				[Dot42.DexImport("address", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress Address() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <summary>
				/// <para>Gets a textual representation of this <c> Proxy </c> instance. The string includes the two parts <c> type.toString() </c> and <c>       address.toString() </c> if <c> address </c> is not <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the representing string of this proxy. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Compares the specified <c> obj </c> to this <c> Proxy </c> instance and returns whether they are equal or not. The given object must be an instance of <c> Proxy </c> with the same address and the same type value to be equal.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the given object represents the same <c>               Proxy </c> as this instance, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the hashcode for this <c> Proxy </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hashcode value for this Proxy instance. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Proxy() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// java/net/Proxy$Type
				/// </java-name>
				[Dot42.DexImport("java/net/Proxy$Type", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/net/Proxy$Type;>;")]
				public sealed class JavaType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DIRECT
						/// </java-name>
						[Dot42.DexImport("DIRECT", "Ljava/net/Proxy$Type;", AccessFlags = 16409)]
						public static readonly JavaType DIRECT;
						/// <java-name>
						/// HTTP
						/// </java-name>
						[Dot42.DexImport("HTTP", "Ljava/net/Proxy$Type;", AccessFlags = 16409)]
						public static readonly JavaType HTTP;
						/// <java-name>
						/// SOCKS
						/// </java-name>
						[Dot42.DexImport("SOCKS", "Ljava/net/Proxy$Type;", AccessFlags = 16409)]
						public static readonly JavaType SOCKS;
						private JavaType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/SocketPermission
		/// </java-name>
		[Dot42.DexImport("java/net/SocketPermission", AccessFlags = 49)]
		public sealed partial class SocketPermission : global::Java.Security.Permission, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SocketPermission(string host, string action) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// newPermissionCollection
				/// </java-name>
				[Dot42.DexImport("newPermissionCollection", "()Ljava/security/PermissionCollection;", AccessFlags = 1)]
				public override global::Java.Security.PermissionCollection NewPermissionCollection() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SocketPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <summary>
		/// <para>An implementation of this class is able to obtain authentication information for a connection in several ways. For this purpose it has to set the default authenticator which extends <c> Authenticator </c> by <c>   setDefault(Authenticator a) </c> . Then it should override <c>   getPasswordAuthentication() </c> which dictates how the authentication info is obtained. Usually, it prompts the user for the required input.</para><para><para>setDefault </para><simplesectsep></simplesectsep><para>getPasswordAuthentication </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/Authenticator
		/// </java-name>
		[Dot42.DexImport("java/net/Authenticator", AccessFlags = 1057)]
		public abstract partial class Authenticator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Authenticator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the collected username and password for authorization. The subclass has to override this method to return a value different to the default which is <c> null </c> . </para><para>Returns <c> null </c> by default.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>collected password authentication data. </para>
				/// </returns>
				/// <java-name>
				/// getPasswordAuthentication
				/// </java-name>
				[Dot42.DexImport("getPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.PasswordAuthentication GetPasswordAuthentication() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.PasswordAuthentication);
				}

				/// <summary>
				/// <para>Returns the port of the connection that requests authorization.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>port of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingPort
				/// </java-name>
				[Dot42.DexImport("getRequestingPort", "()I", AccessFlags = 20)]
				protected internal int GetRequestingPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the address of the connection that requests authorization or <c> null </c> if unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>address of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingSite
				/// </java-name>
				[Dot42.DexImport("getRequestingSite", "()Ljava/net/InetAddress;", AccessFlags = 20)]
				protected internal global::Java.Net.InetAddress GetRequestingSite() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the realm (prompt string) of the connection that requests authorization.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>prompt string of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingPrompt
				/// </java-name>
				[Dot42.DexImport("getRequestingPrompt", "()Ljava/lang/String;", AccessFlags = 20)]
				protected internal string GetRequestingPrompt() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the protocol of the connection that requests authorization.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>protocol of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingProtocol
				/// </java-name>
				[Dot42.DexImport("getRequestingProtocol", "()Ljava/lang/String;", AccessFlags = 20)]
				protected internal string GetRequestingProtocol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the scheme of the connection that requests authorization, for example HTTP Basic Authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>scheme of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingScheme
				/// </java-name>
				[Dot42.DexImport("getRequestingScheme", "()Ljava/lang/String;", AccessFlags = 20)]
				protected internal string GetRequestingScheme() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Invokes the methods of the registered authenticator to get the authentication info.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>password authentication info or <c> null </c> if no authenticator exists. </para>
				/// </returns>
				/// <java-name>
				/// requestPasswordAuthentication
				/// </java-name>
				[Dot42.DexImport("requestPasswordAuthentication", "(Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lj" +
    "ava/net/PasswordAuthentication;", AccessFlags = 41)]
				public static global::Java.Net.PasswordAuthentication RequestPasswordAuthentication(global::Java.Net.InetAddress rAddr, int rPort, string rProtocol, string rPrompt, string rScheme) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.PasswordAuthentication);
				}

				/// <summary>
				/// <para>Sets <c> a </c> as the default authenticator. It will be called whenever the realm that the URL is pointing to requires authorization.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/net/Authenticator;)V", AccessFlags = 9)]
				public static void SetDefault(global::Java.Net.Authenticator a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Invokes the methods of the registered authenticator to get the authentication info.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>password authentication info or <c> null </c> if no authenticator exists. </para>
				/// </returns>
				/// <java-name>
				/// requestPasswordAuthentication
				/// </java-name>
				[Dot42.DexImport("requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Lja" +
    "va/lang/String;)Ljava/net/PasswordAuthentication;", AccessFlags = 41)]
				public static global::Java.Net.PasswordAuthentication RequestPasswordAuthentication(string rHost, global::Java.Net.InetAddress rAddr, int rPort, string rProtocol, string rPrompt, string rScheme) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.PasswordAuthentication);
				}

				/// <summary>
				/// <para>Returns the host name of the connection that requests authentication or <c> null </c> if unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>name of the requesting host or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getRequestingHost
				/// </java-name>
				[Dot42.DexImport("getRequestingHost", "()Ljava/lang/String;", AccessFlags = 20)]
				protected internal string GetRequestingHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Invokes the methods of the registered authenticator to get the authentication info.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>password authentication info or <c> null </c> if no authenticator exists. </para>
				/// </returns>
				/// <java-name>
				/// requestPasswordAuthentication
				/// </java-name>
				[Dot42.DexImport("requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Lja" +
    "va/lang/String;Ljava/net/URL;Ljava/net/Authenticator$RequestorType;)Ljava/net/Pa" +
    "sswordAuthentication;", AccessFlags = 9)]
				public static global::Java.Net.PasswordAuthentication RequestPasswordAuthentication(string rHost, global::Java.Net.InetAddress rAddr, int rPort, string rProtocol, string rPrompt, string rScheme, global::Java.Net.URL rURL, global::Java.Net.Authenticator.RequestorType reqType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.PasswordAuthentication);
				}

				/// <summary>
				/// <para>Returns the URL of the authentication request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>authentication request url. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingURL
				/// </java-name>
				[Dot42.DexImport("getRequestingURL", "()Ljava/net/URL;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.URL GetRequestingURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <summary>
				/// <para>Returns the type of this request, it can be <c> PROXY </c> or <c> SERVER </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>RequestorType of the authentication request. </para>
				/// </returns>
				/// <java-name>
				/// getRequestorType
				/// </java-name>
				[Dot42.DexImport("getRequestorType", "()Ljava/net/Authenticator$RequestorType;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.Authenticator.RequestorType GetRequestorType() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Authenticator.RequestorType);
				}

				/// <summary>
				/// <para>Returns the collected username and password for authorization. The subclass has to override this method to return a value different to the default which is <c> null </c> . </para><para>Returns <c> null </c> by default.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>collected password authentication data. </para>
				/// </returns>
				/// <java-name>
				/// getPasswordAuthentication
				/// </java-name>
				protected internal global::Java.Net.PasswordAuthentication PasswordAuthentication
				{
				[Dot42.DexImport("getPasswordAuthentication", "()Ljava/net/PasswordAuthentication;", AccessFlags = 4)]
						get{ return GetPasswordAuthentication(); }
				}

				/// <summary>
				/// <para>Returns the port of the connection that requests authorization.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>port of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingPort
				/// </java-name>
				protected internal int RequestingPort
				{
				[Dot42.DexImport("getRequestingPort", "()I", AccessFlags = 20)]
						get{ return GetRequestingPort(); }
				}

				/// <summary>
				/// <para>Returns the address of the connection that requests authorization or <c> null </c> if unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>address of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingSite
				/// </java-name>
				protected internal global::Java.Net.InetAddress RequestingSite
				{
				[Dot42.DexImport("getRequestingSite", "()Ljava/net/InetAddress;", AccessFlags = 20)]
						get{ return GetRequestingSite(); }
				}

				/// <summary>
				/// <para>Returns the realm (prompt string) of the connection that requests authorization.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>prompt string of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingPrompt
				/// </java-name>
				protected internal string RequestingPrompt
				{
				[Dot42.DexImport("getRequestingPrompt", "()Ljava/lang/String;", AccessFlags = 20)]
						get{ return GetRequestingPrompt(); }
				}

				/// <summary>
				/// <para>Returns the protocol of the connection that requests authorization.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>protocol of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingProtocol
				/// </java-name>
				protected internal string RequestingProtocol
				{
				[Dot42.DexImport("getRequestingProtocol", "()Ljava/lang/String;", AccessFlags = 20)]
						get{ return GetRequestingProtocol(); }
				}

				/// <summary>
				/// <para>Returns the scheme of the connection that requests authorization, for example HTTP Basic Authentication.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>scheme of the connection. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingScheme
				/// </java-name>
				protected internal string RequestingScheme
				{
				[Dot42.DexImport("getRequestingScheme", "()Ljava/lang/String;", AccessFlags = 20)]
						get{ return GetRequestingScheme(); }
				}

				/// <summary>
				/// <para>Returns the host name of the connection that requests authentication or <c> null </c> if unknown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>name of the requesting host or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getRequestingHost
				/// </java-name>
				protected internal string RequestingHost
				{
				[Dot42.DexImport("getRequestingHost", "()Ljava/lang/String;", AccessFlags = 20)]
						get{ return GetRequestingHost(); }
				}

				/// <summary>
				/// <para>Returns the URL of the authentication request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>authentication request url. </para>
				/// </returns>
				/// <java-name>
				/// getRequestingURL
				/// </java-name>
				protected internal global::Java.Net.URL RequestingURL
				{
				[Dot42.DexImport("getRequestingURL", "()Ljava/net/URL;", AccessFlags = 4)]
						get{ return GetRequestingURL(); }
				}

				/// <java-name>
				/// java/net/Authenticator$RequestorType
				/// </java-name>
				[Dot42.DexImport("java/net/Authenticator$RequestorType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/net/Authenticator$RequestorType;>;")]
				public sealed class RequestorType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// PROXY
						/// </java-name>
						[Dot42.DexImport("PROXY", "Ljava/net/Authenticator$RequestorType;", AccessFlags = 16409)]
						public static readonly RequestorType PROXY;
						/// <java-name>
						/// SERVER
						/// </java-name>
						[Dot42.DexImport("SERVER", "Ljava/net/Authenticator$RequestorType;", AccessFlags = 16409)]
						public static readonly RequestorType SERVER;
						private RequestorType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>A <c> BindException </c> is thrown when a process cannot bind a local address/port, either because it is already bound or reserved by the OS.</para><para>Most applications <b>should not</b> catch this exception; it is more robust to catch the superclass <c> SocketException </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/net/BindException
		/// </java-name>
		[Dot42.DexImport("java/net/BindException", AccessFlags = 33)]
		public partial class BindException : global::Java.Net.SocketException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BindException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BindException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Signals that either a connection attempt to a socket of the wrong type, the application of an unsupported operation or that a general error in the underlying protocol has occurred. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/ProtocolException
		/// </java-name>
		[Dot42.DexImport("java/net/ProtocolException", AccessFlags = 33)]
		public partial class ProtocolException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProtocolException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new instance with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ProtocolException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Provides a client-side TCP socket. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/Socket
		/// </java-name>
		[Dot42.DexImport("java/net/Socket", AccessFlags = 33)]
		public partial class Socket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new unconnected socket. When a SocketImplFactory is defined it creates the internal socket implementation, otherwise the default socket implementation will be used for this socket.</para><para><para>SocketImplFactory </para><simplesectsep></simplesectsep><para>SocketImpl </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Socket() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new unconnected socket using the given proxy type. When a <c> SocketImplFactory </c> is defined it creates the internal socket implementation, otherwise the default socket implementation will be used for this socket. </para><para>Example that will create a socket connection through a <c> SOCKS </c> proxy server: <br></br> <c> Socket sock = new Socket(new Proxy(Proxy.Type.SOCKS, new       InetSocketAddress("test.domain.org", 2130))); </c></para><para><para>SocketImplFactory </para><simplesectsep></simplesectsep><para>SocketImpl </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/Proxy;)V", AccessFlags = 1)]
				public Socket(global::Java.Net.Proxy proxy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new streaming socket connected to the target host specified by the parameters <c> dstAddress </c> and <c> dstPort </c> . The socket is bound to any available port on the local host.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public Socket(string dstAddress, int dstPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new streaming socket connected to the target host specified by the parameters <c> dstAddress </c> and <c> dstPort </c> . On the local endpoint the socket is bound to the given address <c> localAddress </c> on port <c> localPort </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/net/InetAddress;I)V", AccessFlags = 1)]
				public Socket(string dstAddress, int dstPort, global::Java.Net.InetAddress localAddress, int localPort) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;IZ)V", AccessFlags = 1)]
				public Socket(string @string, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new streaming socket connected to the target host specified by the parameters <c> dstAddress </c> and <c> dstPort </c> . The socket is bound to any available port on the local host.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;I)V", AccessFlags = 1)]
				public Socket(global::Java.Net.InetAddress dstAddress, int dstPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new streaming socket connected to the target host specified by the parameters <c> dstAddress </c> and <c> dstPort </c> . On the local endpoint the socket is bound to the given address <c> localAddress </c> on port <c> localPort </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)V", AccessFlags = 1)]
				public Socket(global::Java.Net.InetAddress dstAddress, int dstPort, global::Java.Net.InetAddress localAddress, int localPort) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;IZ)V", AccessFlags = 1)]
				public Socket(global::Java.Net.InetAddress inetAddress, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new unconnected socket using the given proxy type. When a <c> SocketImplFactory </c> is defined it creates the internal socket implementation, otherwise the default socket implementation will be used for this socket. </para><para>Example that will create a socket connection through a <c> SOCKS </c> proxy server: <br></br> <c> Socket sock = new Socket(new Proxy(Proxy.Type.SOCKS, new       InetSocketAddress("test.domain.org", 2130))); </c></para><para><para>SocketImplFactory </para><simplesectsep></simplesectsep><para>SocketImpl </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/SocketImpl;)V", AccessFlags = 4)]
				protected internal Socket(global::Java.Net.SocketImpl proxy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes the socket. It is not possible to reconnect or rebind to this socket thereafter which means a new socket instance has to be created.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the IP address of the target host this socket is connected to, or null if this socket is not yet connected. </para>        
				/// </summary>
				/// <java-name>
				/// getInetAddress
				/// </java-name>
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetInetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns an input stream to read data from this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte-oriented input stream. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Returns this socket's SocketOptions#SO_KEEPALIVE setting. </para>        
				/// </summary>
				/// <java-name>
				/// getKeepAlive
				/// </java-name>
				[Dot42.DexImport("getKeepAlive", "()Z", AccessFlags = 1)]
				public virtual bool GetKeepAlive() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the local IP address this socket is bound to, or <c> InetAddress.ANY </c> if the socket is unbound. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the local port this socket is bound to, or -1 if the socket is unbound. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
				public virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an output stream to write data into this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte-oriented output stream. </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <summary>
				/// <para>Returns the port number of the target host this socket is connected to, or 0 if this socket is not yet connected. </para>        
				/// </summary>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public virtual int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this socket's linger timeout in seconds, or -1 for no linger (i.e. <c> close </c> will return immediately). </para>        
				/// </summary>
				/// <java-name>
				/// getSoLinger
				/// </java-name>
				[Dot42.DexImport("getSoLinger", "()I", AccessFlags = 1)]
				public virtual int GetSoLinger() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 33)]
				public virtual int GetReceiveBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this socket's send buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 33)]
				public virtual int GetSendBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this socket's receive timeout. </para>        
				/// </summary>
				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
				public virtual int GetSoTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this socket's <c> SocketOptions#TCP_NODELAY </c> setting. </para>        
				/// </summary>
				/// <java-name>
				/// getTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("getTcpNoDelay", "()Z", AccessFlags = 1)]
				public virtual bool GetTcpNoDelay() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets this socket's SocketOptions#SO_KEEPALIVE option. </para>        
				/// </summary>
				/// <java-name>
				/// setKeepAlive
				/// </java-name>
				[Dot42.DexImport("setKeepAlive", "(Z)V", AccessFlags = 1)]
				public virtual void SetKeepAlive(bool keepAlive) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the internal factory for creating socket implementations. This may only be executed once during the lifetime of the application.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSocketImplFactory
				/// </java-name>
				[Dot42.DexImport("setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V", AccessFlags = 41)]
				public static void SetSocketImplFactory(global::Java.Net.ISocketImplFactory fac) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets this socket's send buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// setSendBufferSize
				/// </java-name>
				[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 33)]
				public virtual void SetSendBufferSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// setReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 33)]
				public virtual void SetReceiveBufferSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets this socket's linger timeout in seconds. If <c> on </c> is false, <c> timeout </c> is irrelevant. </para>        
				/// </summary>
				/// <java-name>
				/// setSoLinger
				/// </java-name>
				[Dot42.DexImport("setSoLinger", "(ZI)V", AccessFlags = 1)]
				public virtual void SetSoLinger(bool on, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets this socket's read timeout in milliseconds. Use 0 for no timeout. To take effect, this option must be set before the blocking method was called. </para>        
				/// </summary>
				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
				public virtual void SetSoTimeout(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets this socket's SocketOptions#TCP_NODELAY option. </para>        
				/// </summary>
				/// <java-name>
				/// setTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("setTcpNoDelay", "(Z)V", AccessFlags = 1)]
				public virtual void SetTcpNoDelay(bool on) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a <c> String </c> containing a concise, human-readable description of the socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the textual representation of this socket. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Closes the input stream of this socket. Any further data sent to this socket will be discarded. Reading from this socket after this method has been called will return the value <c> EOF </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shutdownInput
				/// </java-name>
				[Dot42.DexImport("shutdownInput", "()V", AccessFlags = 1)]
				public virtual void ShutdownInput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes the output stream of this socket. All buffered data will be sent followed by the termination sequence. Writing to the closed output stream will cause an <c> IOException </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shutdownOutput
				/// </java-name>
				[Dot42.DexImport("shutdownOutput", "()V", AccessFlags = 1)]
				public virtual void ShutdownOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the local address and port of this socket as a SocketAddress or null if the socket is unbound. This is useful on multihomed hosts. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetLocalSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <summary>
				/// <para>Returns the remote address and port of this socket as a <c>       SocketAddress </c> or null if the socket is not connected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote socket address and port. </para>
				/// </returns>
				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				[Dot42.DexImport("getRemoteSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetRemoteSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <summary>
				/// <para>Returns whether this socket is bound to a local address and port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the socket is bound to a local address, <c>               false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isBound
				/// </java-name>
				[Dot42.DexImport("isBound", "()Z", AccessFlags = 1)]
				public virtual bool IsBound() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this socket is connected to a remote host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the socket is connected, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1)]
				public virtual bool IsConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this socket is closed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the socket is closed, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Binds this socket to the given local host address and port specified by the SocketAddress <c> localAddr </c> . If <c> localAddr </c> is set to <c> null </c> , this socket will be bound to an available local address on any free port.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Bind(global::Java.Net.SocketAddress localAddr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Connects this socket to the given remote host address and port specified by the SocketAddress <c> remoteAddr </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Net.SocketAddress remoteAddr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Connects this socket to the given remote host address and port specified by the SocketAddress <c> remoteAddr </c> with the specified timeout. The connecting method will block until the connection is established or an error occurred.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;I)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Net.SocketAddress remoteAddr, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the incoming channel of the socket has already been closed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if reading from this socket is not possible anymore, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isInputShutdown
				/// </java-name>
				[Dot42.DexImport("isInputShutdown", "()Z", AccessFlags = 1)]
				public virtual bool IsInputShutdown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the outgoing channel of the socket has already been closed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if writing to this socket is not possible anymore, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isOutputShutdown
				/// </java-name>
				[Dot42.DexImport("isOutputShutdown", "()Z", AccessFlags = 1)]
				public virtual bool IsOutputShutdown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets this socket's SocketOptions#SO_REUSEADDR option. </para>        
				/// </summary>
				/// <java-name>
				/// setReuseAddress
				/// </java-name>
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
				public virtual void SetReuseAddress(bool reuse) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this socket's SocketOptions#SO_REUSEADDR setting. </para>        
				/// </summary>
				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
				public virtual bool GetReuseAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets this socket's SocketOptions#SO_OOBINLINE option. </para>        
				/// </summary>
				/// <java-name>
				/// setOOBInline
				/// </java-name>
				[Dot42.DexImport("setOOBInline", "(Z)V", AccessFlags = 1)]
				public virtual void SetOOBInline(bool oobinline) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this socket's SocketOptions#SO_OOBINLINE setting. </para>        
				/// </summary>
				/// <java-name>
				/// getOOBInline
				/// </java-name>
				[Dot42.DexImport("getOOBInline", "()Z", AccessFlags = 1)]
				public virtual bool GetOOBInline() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets this socket's SocketOptions#IP_TOS value for every packet sent by this socket. </para>        
				/// </summary>
				/// <java-name>
				/// setTrafficClass
				/// </java-name>
				[Dot42.DexImport("setTrafficClass", "(I)V", AccessFlags = 1)]
				public virtual void SetTrafficClass(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this socket's {<para>SocketOptions::IP_TOS} setting. </para></para>        
				/// </summary>
				/// <java-name>
				/// getTrafficClass
				/// </java-name>
				[Dot42.DexImport("getTrafficClass", "()I", AccessFlags = 1)]
				public virtual int GetTrafficClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sends the given single byte data which is represented by the lowest octet of <c> value </c> as "TCP urgent data".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sendUrgentData
				/// </java-name>
				[Dot42.DexImport("sendUrgentData", "(I)V", AccessFlags = 1)]
				public virtual void SendUrgentData(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this socket's <c> SocketChannel </c> , if one exists. A channel is available only if this socket wraps a channel. (That is, you can go from a channel to a socket and back again, but you can't go from an arbitrary socket to a channel.) In practice, this means that the socket must have been created by java.nio.channels.ServerSocketChannel#accept or java.nio.channels.SocketChannel#open. </para>        
				/// </summary>
				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.SocketChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.SocketChannel);
				}

				/// <summary>
				/// <para>Sets performance preferences for connectionTime, latency and bandwidth.</para><para>This method does currently nothing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPerformancePreferences
				/// </java-name>
				[Dot42.DexImport("setPerformancePreferences", "(III)V", AccessFlags = 1)]
				public virtual void SetPerformancePreferences(int connectionTime, int latency, int bandwidth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the IP address of the target host this socket is connected to, or null if this socket is not yet connected. </para>        
				/// </summary>
				/// <java-name>
				/// getInetAddress
				/// </java-name>
				public global::Java.Net.InetAddress InetAddress
				{
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetInetAddress(); }
				}

				/// <summary>
				/// <para>Returns an input stream to read data from this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte-oriented input stream. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				public global::Java.Io.InputStream InputStream
				{
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetInputStream(); }
				}

				/// <summary>
				/// <para>Returns this socket's SocketOptions#SO_KEEPALIVE setting. </para>        
				/// </summary>
				/// <java-name>
				/// getKeepAlive
				/// </java-name>
				public bool IsKeepAlive
				{
				[Dot42.DexImport("getKeepAlive", "()Z", AccessFlags = 1)]
						get{ return GetKeepAlive(); }
				[Dot42.DexImport("setKeepAlive", "(Z)V", AccessFlags = 1)]
						set{ SetKeepAlive(value); }
				}

				/// <summary>
				/// <para>Returns the local IP address this socket is bound to, or <c> InetAddress.ANY </c> if the socket is unbound. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetLocalAddress(); }
				}

				/// <summary>
				/// <para>Returns the local port this socket is bound to, or -1 if the socket is unbound. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				public int LocalPort
				{
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
						get{ return GetLocalPort(); }
				}

				/// <summary>
				/// <para>Returns an output stream to write data into this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte-oriented output stream. </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public global::Java.Io.OutputStream OutputStream
				{
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return GetOutputStream(); }
				}

				/// <summary>
				/// <para>Returns the port number of the target host this socket is connected to, or 0 if this socket is not yet connected. </para>        
				/// </summary>
				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <summary>
				/// <para>Returns this socket's linger timeout in seconds, or -1 for no linger (i.e. <c> close </c> will return immediately). </para>        
				/// </summary>
				/// <java-name>
				/// getSoLinger
				/// </java-name>
				public int SoLinger
				{
				[Dot42.DexImport("getSoLinger", "()I", AccessFlags = 1)]
						get{ return GetSoLinger(); }
				}

				/// <summary>
				/// <para>Returns this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				public int ReceiveBufferSize
				{
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 33)]
						get{ return GetReceiveBufferSize(); }
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 33)]
						set{ SetReceiveBufferSize(value); }
				}

				/// <summary>
				/// <para>Returns this socket's send buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				public int SendBufferSize
				{
				[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 33)]
						get{ return GetSendBufferSize(); }
				[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 33)]
						set{ SetSendBufferSize(value); }
				}

				/// <summary>
				/// <para>Returns this socket's receive timeout. </para>        
				/// </summary>
				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				public int SoTimeout
				{
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
						get{ return GetSoTimeout(); }
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
						set{ SetSoTimeout(value); }
				}

				/// <summary>
				/// <para>Returns this socket's <c> SocketOptions#TCP_NODELAY </c> setting. </para>        
				/// </summary>
				/// <java-name>
				/// getTcpNoDelay
				/// </java-name>
				public bool IsTcpNoDelay
				{
				[Dot42.DexImport("getTcpNoDelay", "()Z", AccessFlags = 1)]
						get{ return GetTcpNoDelay(); }
				[Dot42.DexImport("setTcpNoDelay", "(Z)V", AccessFlags = 1)]
						set{ SetTcpNoDelay(value); }
				}

				/// <summary>
				/// <para>Returns the local address and port of this socket as a SocketAddress or null if the socket is unbound. This is useful on multihomed hosts. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress LocalSocketAddress
				{
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetLocalSocketAddress(); }
				}

				/// <summary>
				/// <para>Returns the remote address and port of this socket as a <c>       SocketAddress </c> or null if the socket is not connected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote socket address and port. </para>
				/// </returns>
				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress RemoteSocketAddress
				{
				[Dot42.DexImport("getRemoteSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetRemoteSocketAddress(); }
				}

				/// <summary>
				/// <para>Returns this socket's SocketOptions#SO_REUSEADDR setting. </para>        
				/// </summary>
				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				public bool IsReuseAddress
				{
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
						get{ return GetReuseAddress(); }
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
						set{ SetReuseAddress(value); }
				}

				/// <summary>
				/// <para>Returns this socket's SocketOptions#SO_OOBINLINE setting. </para>        
				/// </summary>
				/// <java-name>
				/// getOOBInline
				/// </java-name>
				public bool IsOOBInline
				{
				[Dot42.DexImport("getOOBInline", "()Z", AccessFlags = 1)]
						get{ return GetOOBInline(); }
				[Dot42.DexImport("setOOBInline", "(Z)V", AccessFlags = 1)]
						set{ SetOOBInline(value); }
				}

				/// <summary>
				/// <para>Returns this socket's {<para>SocketOptions::IP_TOS} setting. </para></para>        
				/// </summary>
				/// <java-name>
				/// getTrafficClass
				/// </java-name>
				public int TrafficClass
				{
				[Dot42.DexImport("getTrafficClass", "()I", AccessFlags = 1)]
						get{ return GetTrafficClass(); }
				[Dot42.DexImport("setTrafficClass", "(I)V", AccessFlags = 1)]
						set{ SetTrafficClass(value); }
				}

				/// <summary>
				/// <para>Returns this socket's <c> SocketChannel </c> , if one exists. A channel is available only if this socket wraps a channel. (That is, you can go from a channel to a socket and back again, but you can't go from an arbitrary socket to a channel.) In practice, this means that the socket must have been created by java.nio.channels.ServerSocketChannel#accept or java.nio.channels.SocketChannel#open. </para>        
				/// </summary>
				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.SocketChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/SocketChannel;", AccessFlags = 1)]
						get{ return GetChannel(); }
				}

		}

		/// <summary>
		/// <para>Thrown when a hostname can not be resolved. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/UnknownHostException
		/// </java-name>
		[Dot42.DexImport("java/net/UnknownHostException", AccessFlags = 33)]
		public partial class UnknownHostException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> UnknownHostException </c> instance with no detail message. Callers should usually supply a detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnknownHostException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> UnknownHostException </c> instance with the given detail message. The detail message should generally contain the hostname and a reason for the failure, if known.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownHostException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class converts the content of a certain format (i.e. a MIME type) into a Java type object. It is created by <c> ContentHandlerFactory </c> . The data values should be accessed via <c> URL </c> or <c> URLConnection </c> .</para><para><para>ContentHandlerFactory </para><simplesectsep></simplesectsep><para>URL::getContent() </para><simplesectsep></simplesectsep><para>URLConnection::getContent() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/ContentHandler
		/// </java-name>
		[Dot42.DexImport("java/net/ContentHandler", AccessFlags = 1057)]
		public abstract partial class ContentHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContentHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the object pointed by the specified URL connection <c> uConn </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>object referred by <c> uConn </c> . </para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "(Ljava/net/URLConnection;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetContent(global::Java.Net.URLConnection uConn) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the object pointed by the specified URL connection <c> uConn </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>resource object pointed by this URL or <c> null </c> if the content doesn't match one of the specified content types. </para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "(Ljava/net/URLConnection;[Ljava/lang/Class;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetContent(global::Java.Net.URLConnection uConn, global::System.Type[] types) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <summary>
		/// <para>If a HTTP request has to be retried, this exception will be thrown if the request cannot be retried automatically. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/HttpRetryException
		/// </java-name>
		[Dot42.DexImport("java/net/HttpRetryException", AccessFlags = 33)]
		public partial class HttpRetryException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> HttpRetryException </c> instance with the specified response code and the given detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public HttpRetryException(string detail, int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> HttpRetryException </c> instance with the specified response code, the given detail message and the value of the location field from the response header.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public HttpRetryException(string detail, int code, string location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the location value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the stored location from the HTTP header. </para>
				/// </returns>
				/// <java-name>
				/// getLocation
				/// </java-name>
				[Dot42.DexImport("getLocation", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocation() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the detail message.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the detail message. </para>
				/// </returns>
				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReason() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the response code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the HTTP response code. </para>
				/// </returns>
				/// <java-name>
				/// responseCode
				/// </java-name>
				[Dot42.DexImport("responseCode", "()I", AccessFlags = 1)]
				public virtual int ResponseCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpRetryException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the location value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the stored location from the HTTP header. </para>
				/// </returns>
				/// <java-name>
				/// getLocation
				/// </java-name>
				public string Location
				{
				[Dot42.DexImport("getLocation", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocation(); }
				}

				/// <summary>
				/// <para>Gets the detail message.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the detail message. </para>
				/// </returns>
				/// <java-name>
				/// getReason
				/// </java-name>
				public string Reason
				{
				[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetReason(); }
				}

		}

		/// <summary>
		/// <para>Identifies one of a network interface's addresses. These are passed back from the JNI behind NetworkInterface.getNetworkInterfaces. Multiple addresses for the same interface are collected together on the Java side.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/InterfaceAddress
		/// </java-name>
		[Dot42.DexImport("java/net/InterfaceAddress", AccessFlags = 33)]
		public partial class InterfaceAddress
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InterfaceAddress() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tests whether this object is equal to another one. Returns true if the address, broadcast address and prefix length are all equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if 'obj' is equal to this InterfaceAddress, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a string containing this interface's address, prefix length, and broadcast address. For example: <c> "/172.18.103.112/23 [/172.18.103.255]" </c> or <c> "/0:0:0:0:0:0:0:1%1/128 [null]" </c> . </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the InetAddress for this address. </para>        
				/// </summary>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the subnet-directed broadcast address if this is an IPv4 interface, null otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// getBroadcast
				/// </java-name>
				[Dot42.DexImport("getBroadcast", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetBroadcast() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the network prefix length in bits. (In IPv4 parlance, this is known as the subnet mask, but this method applies to IPv6 addresses too.) </para>        
				/// </summary>
				/// <java-name>
				/// getNetworkPrefixLength
				/// </java-name>
				[Dot42.DexImport("getNetworkPrefixLength", "()S", AccessFlags = 1)]
				public virtual short GetNetworkPrefixLength() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Returns the InetAddress for this address. </para>        
				/// </summary>
				/// <java-name>
				/// getAddress
				/// </java-name>
				public global::Java.Net.InetAddress Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetAddress(); }
				}

				/// <summary>
				/// <para>Returns the subnet-directed broadcast address if this is an IPv4 interface, null otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// getBroadcast
				/// </java-name>
				public global::Java.Net.InetAddress Broadcast
				{
				[Dot42.DexImport("getBroadcast", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetBroadcast(); }
				}

				/// <summary>
				/// <para>Returns the network prefix length in bits. (In IPv4 parlance, this is known as the subnet mask, but this method applies to IPv6 addresses too.) </para>        
				/// </summary>
				/// <java-name>
				/// getNetworkPrefixLength
				/// </java-name>
				public short NetworkPrefixLength
				{
				[Dot42.DexImport("getNetworkPrefixLength", "()S", AccessFlags = 1)]
						get{ return GetNetworkPrefixLength(); }
				}

		}

		/// <summary>
		/// <para>This class loader is responsible for loading classes and resources from a list of URLs which can refer to either directories or JAR files. Classes loaded by this <c> URLClassLoader </c> are granted permission to access the URLs contained in the URL search list. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URLClassLoader
		/// </java-name>
		[Dot42.DexImport("java/net/URLClassLoader", AccessFlags = 33)]
		public partial class URLClassLoader : global::Java.Security.SecureClassLoader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> URLClassLoader </c> instance. The newly created instance will have the system ClassLoader as its parent. URLs that end with "/" are assumed to be directories, otherwise they are assumed to be JAR files.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/net/URL;)V", AccessFlags = 1)]
				public URLClassLoader(global::Java.Net.URL[] urls) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new URLClassLoader instance. The newly created instance will have the system ClassLoader as its parent. URLs that end with "/" are assumed to be directories, otherwise they are assumed to be JAR files.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public URLClassLoader(global::Java.Net.URL[] urls, global::Java.Lang.ClassLoader parent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> URLClassLoader </c> instance. The newly created instance will have the specified <c> ClassLoader </c> as its parent and use the specified factory to create stream handlers. URLs that end with "/" are assumed to be directories, otherwise they are assumed to be JAR files.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/net/URL;Ljava/lang/ClassLoader;Ljava/net/URLStreamHandlerFactory;)V", AccessFlags = 1)]
				public URLClassLoader(global::Java.Net.URL[] searchUrls, global::Java.Lang.ClassLoader parent, global::Java.Net.IURLStreamHandlerFactory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the specified URL to the search list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addURL
				/// </java-name>
				[Dot42.DexImport("addURL", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal virtual void AddURL(global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns all known URLs which point to the specified resource.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the enumeration of URLs which point to the specified resource. </para>
				/// </returns>
				/// <java-name>
				/// findResources
				/// </java-name>
				[Dot42.DexImport("findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				public new virtual global::Java.Util.IEnumeration<global::Java.Net.URL> FindResources(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <summary>
				/// <para>Gets all permissions for the specified <c> codesource </c> . First, this method retrieves the permissions from the system policy. If the protocol is "file:/" then a new permission, <c> FilePermission </c> , granting the read permission to the file is added to the permission collection. Otherwise, connecting to and accepting connections from the URL is granted.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of permissions according to the code source object. </para>
				/// </returns>
				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", AccessFlags = 4)]
				protected internal override global::Java.Security.PermissionCollection GetPermissions(global::Java.Security.CodeSource codesource) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <summary>
				/// <para>Returns the search list of this <c> URLClassLoader </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of all known URLs of this instance. </para>
				/// </returns>
				/// <java-name>
				/// getURLs
				/// </java-name>
				[Dot42.DexImport("getURLs", "()[Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL[] GetURLs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL[]);
				}

				/// <summary>
				/// <para>Returns a new <c> URLClassLoader </c> instance for the given URLs and the system <c> ClassLoader </c> as its parent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created <c> URLClassLoader </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([Ljava/net/URL;)Ljava/net/URLClassLoader;", AccessFlags = 9)]
				public static global::Java.Net.URLClassLoader NewInstance(global::Java.Net.URL[] urls) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLClassLoader);
				}

				/// <summary>
				/// <para>Returns a new <c> URLClassLoader </c> instance for the given URLs and the specified <c> ClassLoader </c> as its parent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created <c> URLClassLoader </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([Ljava/net/URL;Ljava/lang/ClassLoader;)Ljava/net/URLClassLoader;", AccessFlags = 9)]
				public static global::Java.Net.URLClassLoader NewInstance(global::Java.Net.URL[] urls, global::Java.Lang.ClassLoader parentCl) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URLClassLoader);
				}

				/// <summary>
				/// <para>Tries to locate and load the specified class using the known URLs. If the class could be found, a class object representing the loaded class will be returned.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// findClass
				/// </java-name>
				[Dot42.DexImport("findClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal override global::System.Type FindClass(string className) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns an URL referencing the specified resource or <c> null </c> if the resource could not be found.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL which points to the given resource. </para>
				/// </returns>
				/// <java-name>
				/// findResource
				/// </java-name>
				[Dot42.DexImport("findResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1)]
				public new virtual global::Java.Net.URL FindResource(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <summary>
				/// <para>Defines a new package using the information extracted from the specified manifest.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created package. </para>
				/// </returns>
				/// <java-name>
				/// definePackage
				/// </java-name>
				[Dot42.DexImport("definePackage", "(Ljava/lang/String;Ljava/util/jar/Manifest;Ljava/net/URL;)Ljava/lang/Package;", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.Package DefinePackage(string packageName, global::Java.Util.Jar.Manifest manifest, global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URLClassLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the search list of this <c> URLClassLoader </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of all known URLs of this instance. </para>
				/// </returns>
				/// <java-name>
				/// getURLs
				/// </java-name>
				public global::Java.Net.URL[] URLs
				{
				[Dot42.DexImport("getURLs", "()[Ljava/net/URL;", AccessFlags = 1)]
						get{ return GetURLs(); }
				}

		}

		/// <summary>
		/// <para>This class establishes a connection to a <c> jar: </c> URL using the <c>   JAR </c> protocol. A <c> JarURLConnection </c> instance can refer to either a JAR archive file or to an entry of such a file. <c> jar: </c> URLs are specified as follows: <b>jar:{archive-url}!/{entry}</b> where "!/" is called a separator. This separator is important to determine if an archive or an entry of an archive is referred. </para><para>Examples: Archive: <c> jar:http://www.example.com/applets/archive.jar!/ </c>  File Entry: <c>   jar:http://www.example.com/applets/archive.jar!/test.class </c>  Directory Entry: <c>   jar:http://www.example.com/applets/archive.jar!/applets/ </c>  </para>    
		/// </summary>
		/// <java-name>
		/// java/net/JarURLConnection
		/// </java-name>
		[Dot42.DexImport("java/net/JarURLConnection", AccessFlags = 1057)]
		public abstract partial class JarURLConnection : global::Java.Net.URLConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The location part of the represented URL. </para>        
				/// </summary>
				/// <java-name>
				/// jarFileURLConnection
				/// </java-name>
				[Dot42.DexImport("jarFileURLConnection", "Ljava/net/URLConnection;", AccessFlags = 4)]
				protected internal global::Java.Net.URLConnection JarFileURLConnection;
				/// <summary>
				/// <para>Constructs an instance of <c> JarURLConnection </c> that refers to the specified URL.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/URL;)V", AccessFlags = 4)]
				protected internal JarURLConnection(global::Java.Net.URL url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns all attributes of the <c> JarEntry </c> referenced by this <c>       JarURLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the attributes of the referenced <c> JarEntry </c> . </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				/// <summary>
				/// <para>Returns all certificates of the <c> JarEntry </c> referenced by this <c> JarURLConnection </c> instance. This method will return <c> null </c> until the <c> InputStream </c> has been completely verified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificates of the <c> JarEntry </c> as an array. </para>
				/// </returns>
				/// <java-name>
				/// getCertificates
				/// </java-name>
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.Certificate[] GetCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <summary>
				/// <para>Gets the name of the entry referenced by this <c> JarURLConnection </c> . The return value will be <c> null </c> if this instance refers to a JAR file rather than an JAR file entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> JarEntry </c> name this instance refers to. </para>
				/// </returns>
				/// <java-name>
				/// getEntryName
				/// </java-name>
				[Dot42.DexImport("getEntryName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEntryName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the <c> JarEntry </c> object of the entry referenced by this <c>       JarURLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the referenced <c> JarEntry </c> object or <c> null </c> if no entry name is specified. </para>
				/// </returns>
				/// <java-name>
				/// getJarEntry
				/// </java-name>
				[Dot42.DexImport("getJarEntry", "()Ljava/util/jar/JarEntry;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.JarEntry GetJarEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.JarEntry);
				}

				/// <summary>
				/// <para>Gets the manifest file associated with this JAR-URL.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the manifest of the referenced JAR-file. </para>
				/// </returns>
				/// <java-name>
				/// getManifest
				/// </java-name>
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Manifest GetManifest() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Manifest);
				}

				/// <summary>
				/// <para>Gets the <c> JarFile </c> object referenced by this <c>       JarURLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the referenced JarFile object. </para>
				/// </returns>
				/// <java-name>
				/// getJarFile
				/// </java-name>
				[Dot42.DexImport("getJarFile", "()Ljava/util/jar/JarFile;", AccessFlags = 1025)]
				public abstract global::Java.Util.Jar.JarFile GetJarFile() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the URL to the JAR-file referenced by this <c> JarURLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL to the JAR-file or <c> null </c> if there was an error retrieving the URL. </para>
				/// </returns>
				/// <java-name>
				/// getJarFileURL
				/// </java-name>
				[Dot42.DexImport("getJarFileURL", "()Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL GetJarFileURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <summary>
				/// <para>Gets all attributes of the manifest file referenced by this <c>       JarURLConnection </c> . If this instance refers to a JAR-file rather than a JAR-file entry, <c> null </c> will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the attributes of the manifest file or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getMainAttributes
				/// </java-name>
				[Dot42.DexImport("getMainAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
				public virtual global::Java.Util.Jar.Attributes GetMainAttributes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Jar.Attributes);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JarURLConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns all attributes of the <c> JarEntry </c> referenced by this <c>       JarURLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the attributes of the referenced <c> JarEntry </c> . </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				public global::Java.Util.Jar.Attributes Attributes
				{
				[Dot42.DexImport("getAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
						get{ return GetAttributes(); }
				}

				/// <summary>
				/// <para>Returns all certificates of the <c> JarEntry </c> referenced by this <c> JarURLConnection </c> instance. This method will return <c> null </c> until the <c> InputStream </c> has been completely verified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificates of the <c> JarEntry </c> as an array. </para>
				/// </returns>
				/// <java-name>
				/// getCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] Certificates
				{
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetCertificates(); }
				}

				/// <summary>
				/// <para>Gets the name of the entry referenced by this <c> JarURLConnection </c> . The return value will be <c> null </c> if this instance refers to a JAR file rather than an JAR file entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> JarEntry </c> name this instance refers to. </para>
				/// </returns>
				/// <java-name>
				/// getEntryName
				/// </java-name>
				public string EntryName
				{
				[Dot42.DexImport("getEntryName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEntryName(); }
				}

				/// <summary>
				/// <para>Gets the <c> JarEntry </c> object of the entry referenced by this <c>       JarURLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the referenced <c> JarEntry </c> object or <c> null </c> if no entry name is specified. </para>
				/// </returns>
				/// <java-name>
				/// getJarEntry
				/// </java-name>
				public global::Java.Util.Jar.JarEntry JarEntry
				{
				[Dot42.DexImport("getJarEntry", "()Ljava/util/jar/JarEntry;", AccessFlags = 1)]
						get{ return GetJarEntry(); }
				}

				/// <summary>
				/// <para>Gets the manifest file associated with this JAR-URL.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the manifest of the referenced JAR-file. </para>
				/// </returns>
				/// <java-name>
				/// getManifest
				/// </java-name>
				public global::Java.Util.Jar.Manifest Manifest
				{
				[Dot42.DexImport("getManifest", "()Ljava/util/jar/Manifest;", AccessFlags = 1)]
						get{ return GetManifest(); }
				}

				/// <summary>
				/// <para>Gets the <c> JarFile </c> object referenced by this <c>       JarURLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the referenced JarFile object. </para>
				/// </returns>
				/// <java-name>
				/// getJarFile
				/// </java-name>
				public global::Java.Util.Jar.JarFile JarFile
				{
				[Dot42.DexImport("getJarFile", "()Ljava/util/jar/JarFile;", AccessFlags = 1025)]
						get{ return GetJarFile(); }
				}

				/// <summary>
				/// <para>Gets the URL to the JAR-file referenced by this <c> JarURLConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL to the JAR-file or <c> null </c> if there was an error retrieving the URL. </para>
				/// </returns>
				/// <java-name>
				/// getJarFileURL
				/// </java-name>
				public global::Java.Net.URL JarFileURL
				{
				[Dot42.DexImport("getJarFileURL", "()Ljava/net/URL;", AccessFlags = 1)]
						get{ return GetJarFileURL(); }
				}

				/// <summary>
				/// <para>Gets all attributes of the manifest file referenced by this <c>       JarURLConnection </c> . If this instance refers to a JAR-file rather than a JAR-file entry, <c> null </c> will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the attributes of the manifest file or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getMainAttributes
				/// </java-name>
				public global::Java.Util.Jar.Attributes MainAttributes
				{
				[Dot42.DexImport("getMainAttributes", "()Ljava/util/jar/Attributes;", AccessFlags = 1)]
						get{ return GetMainAttributes(); }
				}

		}

		/// <summary>
		/// <para>This <c> SocketException </c> may be thrown during socket creation or setting options, and is the superclass of all other socket related exceptions. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/SocketException
		/// </java-name>
		[Dot42.DexImport("java/net/SocketException", AccessFlags = 33)]
		public partial class SocketException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SocketException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An IPv6 address. See InetAddress. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/Inet6Address
		/// </java-name>
		[Dot42.DexImport("java/net/Inet6Address", AccessFlags = 49)]
		public sealed partial class Inet6Address : global::Java.Net.InetAddress
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Inet6Address() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[BI)Ljava/net/Inet6Address;", AccessFlags = 9)]
				public static global::Java.Net.Inet6Address GetByAddress(string @string, sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Inet6Address);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[BI)Ljava/net/Inet6Address;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Net.Inet6Address GetByAddress(string @string, byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Inet6Address);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;", AccessFlags = 9)]
				public static global::Java.Net.Inet6Address GetByAddress(string @string, sbyte[] sByte, global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Inet6Address);
				}

				/// <java-name>
				/// getByAddress
				/// </java-name>
				[Dot42.DexImport("getByAddress", "(Ljava/lang/String;[BLjava/net/NetworkInterface;)Ljava/net/Inet6Address;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Net.Inet6Address GetByAddress(string @string, byte[] @byte, global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Inet6Address);
				}

				/// <summary>
				/// <para>Returns whether this address is a multicast address or not.</para><para>Valid IPv6 multicast addresses have the prefix <c> ff::/8 </c> .</para><para>Valid IPv4 multicast addresses have the prefix <c> 224/4 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMulticastAddress
				/// </java-name>
				[Dot42.DexImport("isMulticastAddress", "()Z", AccessFlags = 1)]
				public override bool IsMulticastAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this is the IPv6 unspecified wildcard address <c> :: </c> or the IPv4 "any" address, <c> 0.0.0.0 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isAnyLocalAddress
				/// </java-name>
				[Dot42.DexImport("isAnyLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsAnyLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a loopback address or not.</para><para>Valid IPv4 loopback addresses have the prefix <c> 127/8 </c> .</para><para>The only valid IPv6 loopback address is <c> ::1 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isLoopbackAddress
				/// </java-name>
				[Dot42.DexImport("isLoopbackAddress", "()Z", AccessFlags = 1)]
				public override bool IsLoopbackAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a link-local address or not.</para><para>Valid IPv6 link-local addresses have the prefix <c> fe80::/10 </c> .</para><para> "Default Address Selection for Internet Protocol Version 6 (IPv6)" states that both IPv4 auto-configuration addresses (prefix <c> 169.254/16 </c> ) and IPv4 loopback addresses (prefix <c> 127/8 </c> ) have link-local scope, but Inet4Address only considers the auto-configuration addresses to have link-local scope. That is: the IPv4 loopback address returns false. </para>        
				/// </summary>
				/// <java-name>
				/// isLinkLocalAddress
				/// </java-name>
				[Dot42.DexImport("isLinkLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsLinkLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a site-local address or not.</para><para>For the purposes of this method, valid IPv6 site-local addresses have the deprecated prefix <c> fec0::/10 </c> from , <b>not</b> the modern prefix <c> fc00::/7 </c> from .</para><para> "Default Address Selection for Internet Protocol Version 6 (IPv6)" states that IPv4 private addresses have the prefix <c> 10/8 </c> , <c> 172.16/12 </c> , or <c> 192.168/16 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this instance represents a site-local address, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSiteLocalAddress
				/// </java-name>
				[Dot42.DexImport("isSiteLocalAddress", "()Z", AccessFlags = 1)]
				public override bool IsSiteLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a global multicast address or not.</para><para>Valid IPv6 global multicast addresses have the prefix <c> ffxe::/16 </c> , where <c> x </c> is a set of flags and the additional 112 bits make up the global multicast address space.</para><para>Valid IPv4 global multicast addresses are the range of addresses from <c> 224.0.1.0 </c> to <c> 238.255.255.255 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCGlobal
				/// </java-name>
				[Dot42.DexImport("isMCGlobal", "()Z", AccessFlags = 1)]
				public override bool IsMCGlobal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a node-local multicast address or not.</para><para>Valid IPv6 node-local multicast addresses have the prefix <c> ffx1::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>There are no valid IPv4 node-local multicast addresses. </para>        
				/// </summary>
				/// <java-name>
				/// isMCNodeLocal
				/// </java-name>
				[Dot42.DexImport("isMCNodeLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCNodeLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a link-local multicast address or not.</para><para>Valid IPv6 link-local multicast addresses have the prefix <c> ffx2::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 link-local multicast addresses have the prefix <c> 224.0.0/24 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCLinkLocal
				/// </java-name>
				[Dot42.DexImport("isMCLinkLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCLinkLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a site-local multicast address or not.</para><para>Valid IPv6 site-local multicast addresses have the prefix <c> ffx5::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 site-local multicast addresses have the prefix <c> 239.255/16 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCSiteLocal
				/// </java-name>
				[Dot42.DexImport("isMCSiteLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCSiteLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this address is a organization-local multicast address or not.</para><para>Valid IPv6 organization-local multicast addresses have the prefix <c> ffx8::/16 </c> , where x is a set of flags and the additional 112 bits make up the link-local multicast address space.</para><para>Valid IPv4 organization-local multicast addresses have the prefix <c> 239.192/14 </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isMCOrgLocal
				/// </java-name>
				[Dot42.DexImport("isMCOrgLocal", "()Z", AccessFlags = 1)]
				public override bool IsMCOrgLocal() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the scope id if this address is scoped to an interface, 0 otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// getScopeId
				/// </java-name>
				[Dot42.DexImport("getScopeId", "()I", AccessFlags = 1)]
				public int GetScopeId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the network interface if this address is instanced with a scoped network interface, null otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// getScopedInterface
				/// </java-name>
				[Dot42.DexImport("getScopedInterface", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
				public global::Java.Net.NetworkInterface GetScopedInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <summary>
				/// <para>Returns whether this IPv6 address is an IPv4-compatible address or not. An IPv4-compatible address has the prefix <c> ::/96 </c> and is a deprecated and no-longer used equivalent of the modern IPv4-mapped IPv6 addresses. </para>        
				/// </summary>
				/// <java-name>
				/// isIPv4CompatibleAddress
				/// </java-name>
				[Dot42.DexImport("isIPv4CompatibleAddress", "()Z", AccessFlags = 1)]
				public bool IsIPv4CompatibleAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a string containing the host name (if available) and host address. For example: <c> "www.google.com/74.125.224.115" </c> or <c> "/127.0.0.1" </c> .</para><para>IPv6 addresses may additionally include an interface name or scope id. For example: <c> "www.google.com/2001:4860:4001:803::1013%eth0" </c> or <c> "/2001:4860:4001:803::1013%2" </c> . </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the scope id if this address is scoped to an interface, 0 otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// getScopeId
				/// </java-name>
				public int ScopeId
				{
				[Dot42.DexImport("getScopeId", "()I", AccessFlags = 1)]
						get{ return GetScopeId(); }
				}

				/// <summary>
				/// <para>Returns the network interface if this address is instanced with a scoped network interface, null otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// getScopedInterface
				/// </java-name>
				public global::Java.Net.NetworkInterface ScopedInterface
				{
				[Dot42.DexImport("getScopedInterface", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
						get{ return GetScopedInterface(); }
				}

		}

		/// <summary>
		/// <para>A CookieStore object is a repository for cookies.</para><para>CookieManager will store cookies of every incoming HTTP response into CookieStore, and retrieve cookies for every outgoing HTTP request.Expired HttpCookies should be removed from this store by themselves.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/CookieStore
		/// </java-name>
		[Dot42.DexImport("java/net/CookieStore", AccessFlags = 1537)]
		public partial interface ICookieStore
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Saves a HTTP cookie to this store. This is called for every incoming HTTP response.</para><para>A cookie may or may not has an associated URI. If not, the cookie's domain and path attribute will show cradleland. If there is an associated URI and no domain and path attribute are speicifed for the cookie, the given URI will indicate where this cookie comes from.</para><para>If a cookie corresponding to the given URI already exists, then it is replaced with the new one.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/net/URI;Ljava/net/HttpCookie;)V", AccessFlags = 1025)]
				void Add(global::System.Uri uri, global::Java.Net.HttpCookie cookie) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves cookies that match the specified URI. Return not expired cookies. For every outgoing HTTP request, this method will be called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an immutable list of HttpCookies, return empty list if no cookies match the given URI </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/net/URI;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/net/URI;)Ljava/util/List<Ljava/net/HttpCookie;>;")]
				global::Java.Util.IList<global::Java.Net.HttpCookie> Get(global::System.Uri uri) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get all cookies in cookie store which are not expired.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an empty list if there's no http cookie in store, or an immutable list of cookies </para>
				/// </returns>
				/// <java-name>
				/// getCookies
				/// </java-name>
				[Dot42.DexImport("getCookies", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/net/HttpCookie;>;")]
				global::Java.Util.IList<global::Java.Net.HttpCookie> GetCookies() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get a set of URIs, which is composed of associated URI with all the cookies in the store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>zero-length list if no cookie in the store is associated with any URIs, otherwise an immutable list of URIs. </para>
				/// </returns>
				/// <java-name>
				/// getURIs
				/// </java-name>
				[Dot42.DexImport("getURIs", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/net/URI;>;")]
				global::Java.Util.IList<global::System.Uri> GetURIs() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Remove the specified cookie from the store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the specified cookie is contained in this store and removed successfully </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/net/URI;Ljava/net/HttpCookie;)Z", AccessFlags = 1025)]
				bool Remove(global::System.Uri uri, global::Java.Net.HttpCookie cookie) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Clear this cookie store.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if any cookies were removed as a result of this call. </para>
				/// </returns>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "()Z", AccessFlags = 1025)]
				bool RemoveAll() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class implements a UDP socket for sending and receiving <c>   DatagramPacket </c> . A <c> DatagramSocket </c> object can be used for both endpoints of a connection for a packet delivery service.</para><para><para>DatagramPacket </para><simplesectsep></simplesectsep><para>DatagramSocketImplFactory </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/DatagramSocket
		/// </java-name>
		[Dot42.DexImport("java/net/DatagramSocket", AccessFlags = 33)]
		public partial class DatagramSocket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a UDP datagram socket which is bound to any available port on the localhost.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DatagramSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a UDP datagram socket which is bound to the specific port <c> aPort </c> on the localhost. Valid values for <c> aPort </c> are between 0 and 65535 inclusive.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public DatagramSocket(int aPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a UDP datagram socket which is bound to the specific local address <c> addr </c> on port <c> aPort </c> . Valid values for <c>       aPort </c> are between 0 and 65535 inclusive.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/net/InetAddress;)V", AccessFlags = 1)]
				public DatagramSocket(int aPort, global::Java.Net.InetAddress addr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a UDP datagram socket which is bound to the specific port <c> aPort </c> on the localhost. Valid values for <c> aPort </c> are between 0 and 65535 inclusive.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/DatagramSocketImpl;)V", AccessFlags = 4)]
				protected internal DatagramSocket(global::Java.Net.DatagramSocketImpl aPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a UDP datagram socket which is bound to the specific port <c> aPort </c> on the localhost. Valid values for <c> aPort </c> are between 0 and 65535 inclusive.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public DatagramSocket(global::Java.Net.SocketAddress aPort) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes this UDP datagram socket and all possibly associated channels. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Connects this datagram socket to the specific <c> address </c> and <c> port </c> . Future calls to send will use this as the default target, and receive will only accept packets from this source.</para><para>Beware: because it can't throw, this method silently ignores failures. Use connect(SocketAddress) instead. </para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/InetAddress;I)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Net.InetAddress address, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disconnects this UDP datagram socket from the remote host. This method called on an unconnected socket does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()V", AccessFlags = 1)]
				public virtual void Disconnect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the <c> InetAddress </c> instance representing the remote address to which this UDP datagram socket is connected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote address this socket is connected to or <c> null </c> if this socket is not connected. </para>
				/// </returns>
				/// <java-name>
				/// getInetAddress
				/// </java-name>
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetInetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Gets the <c> InetAddress </c> instance representing the bound local address of this UDP datagram socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address to which this socket is bound to or <c>               null </c> if this socket is closed. </para>
				/// </returns>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Gets the local port which this socket is bound to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local port of this socket or <c> -1 </c> if this socket is closed and <c> 0 </c> if it is unbound. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
				public virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the remote port which this socket is connected to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote port of this socket. The return value <c> -1 </c> indicates that this socket is not connected. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public virtual int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 33)]
				public virtual int GetReceiveBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this socket's send buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 33)]
				public virtual int GetSendBufferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the socket receive timeout.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
				public virtual int GetSoTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Receives a packet from this socket and stores it in the argument <c>       pack </c> . All fields of <c> pack </c> must be set according to the data received. If the received data is longer than the packet buffer size it is truncated. This method blocks until a packet is received or a timeout has expired.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// receive
				/// </java-name>
				[Dot42.DexImport("receive", "(Ljava/net/DatagramPacket;)V", AccessFlags = 33)]
				public virtual void Receive(global::Java.Net.DatagramPacket pack) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sends a packet over this socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/net/DatagramPacket;)V", AccessFlags = 1)]
				public virtual void Send(global::Java.Net.DatagramPacket pack) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets this socket's send buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// setSendBufferSize
				/// </java-name>
				[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 33)]
				public virtual void SetSendBufferSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// setReceiveBufferSize
				/// </java-name>
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 33)]
				public virtual void SetReceiveBufferSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the read timeout in milliseconds for this socket. This receive timeout defines the period the socket will block waiting to receive data before throwing an <c> InterruptedIOException </c> . The value <c> 0 </c> (default) is used to set an infinite timeout. To have effect this option must be set before the blocking method was called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
				public virtual void SetSoTimeout(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the socket implementation factory. This may only be invoked once over the lifetime of the application. This factory is used to create a new datagram socket implementation.</para><para><para>DatagramSocketImplFactory </para></para>        
				/// </summary>
				/// <java-name>
				/// setDatagramSocketImplFactory
				/// </java-name>
				[Dot42.DexImport("setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V", AccessFlags = 41)]
				public static void SetDatagramSocketImplFactory(global::Java.Net.IDatagramSocketImplFactory fac) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Binds this socket to the local address and port specified by <c>       localAddr </c> . If this value is <c> null </c> any free port on a valid local address is used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Bind(global::Java.Net.SocketAddress localAddr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Connects this datagram socket to the address and port specified by <c> peer </c> . Future calls to send will use this as the default target, and receive will only accept packets from this source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Net.SocketAddress peer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if this socket is bound to a local address. See bind. </para>        
				/// </summary>
				/// <java-name>
				/// isBound
				/// </java-name>
				[Dot42.DexImport("isBound", "()Z", AccessFlags = 1)]
				public virtual bool IsBound() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this datagram socket is connected to a remote address. See connect. </para>        
				/// </summary>
				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1)]
				public virtual bool IsConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the <c> SocketAddress </c> this socket is connected to, or null for an unconnected socket. </para>        
				/// </summary>
				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				[Dot42.DexImport("getRemoteSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetRemoteSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <summary>
				/// <para>Returns the <c> SocketAddress </c> this socket is bound to, or null for an unbound socket. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.SocketAddress GetLocalSocketAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.SocketAddress);
				}

				/// <summary>
				/// <para>Sets the socket option <c> SocketOptions.SO_REUSEADDR </c> . This option has to be enabled if more than one UDP socket wants to be bound to the same address. That could be needed for receiving multicast packets. </para><para>There is an undefined behavior if this option is set after the socket is already bound.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setReuseAddress
				/// </java-name>
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
				public virtual void SetReuseAddress(bool reuse) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the state of the socket option <c> SocketOptions.SO_REUSEADDR </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the option is enabled, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
				public virtual bool GetReuseAddress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the socket option <c> SocketOptions.SO_BROADCAST </c> . This option must be enabled to send broadcast messages.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBroadcast
				/// </java-name>
				[Dot42.DexImport("setBroadcast", "(Z)V", AccessFlags = 1)]
				public virtual void SetBroadcast(bool broadcast) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the state of the socket option <c> SocketOptions.SO_BROADCAST </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the option is enabled, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getBroadcast
				/// </java-name>
				[Dot42.DexImport("getBroadcast", "()Z", AccessFlags = 1)]
				public virtual bool GetBroadcast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the {<para>SocketOptions::IP_TOS} value for every packet sent by this socket.</para></para>        
				/// </summary>
				/// <java-name>
				/// setTrafficClass
				/// </java-name>
				[Dot42.DexImport("setTrafficClass", "(I)V", AccessFlags = 1)]
				public virtual void SetTrafficClass(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this socket's {<para>SocketOptions::IP_TOS} setting.</para></para>        
				/// </summary>
				/// <java-name>
				/// getTrafficClass
				/// </java-name>
				[Dot42.DexImport("getTrafficClass", "()I", AccessFlags = 1)]
				public virtual int GetTrafficClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the state of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the socket is closed, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this socket's <c> DatagramChannel </c> , if one exists. A channel is available only if this socket wraps a channel. (That is, you can go from a channel to a socket and back again, but you can't go from an arbitrary socket to a channel.) In practice, this means that the socket must have been created by java.nio.channels.DatagramChannel#open. </para>        
				/// </summary>
				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.DatagramChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.DatagramChannel);
				}

				/// <summary>
				/// <para>Gets the <c> InetAddress </c> instance representing the remote address to which this UDP datagram socket is connected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote address this socket is connected to or <c> null </c> if this socket is not connected. </para>
				/// </returns>
				/// <java-name>
				/// getInetAddress
				/// </java-name>
				public global::Java.Net.InetAddress InetAddress
				{
				[Dot42.DexImport("getInetAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetInetAddress(); }
				}

				/// <summary>
				/// <para>Gets the <c> InetAddress </c> instance representing the bound local address of this UDP datagram socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local address to which this socket is bound to or <c>               null </c> if this socket is closed. </para>
				/// </returns>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetLocalAddress(); }
				}

				/// <summary>
				/// <para>Gets the local port which this socket is bound to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the local port of this socket or <c> -1 </c> if this socket is closed and <c> 0 </c> if it is unbound. </para>
				/// </returns>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				public int LocalPort
				{
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
						get{ return GetLocalPort(); }
				}

				/// <summary>
				/// <para>Gets the remote port which this socket is connected to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the remote port of this socket. The return value <c> -1 </c> indicates that this socket is not connected. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <summary>
				/// <para>Returns this socket's receive buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				public int ReceiveBufferSize
				{
				[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 33)]
						get{ return GetReceiveBufferSize(); }
				[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 33)]
						set{ SetReceiveBufferSize(value); }
				}

				/// <summary>
				/// <para>Returns this socket's send buffer size. </para>        
				/// </summary>
				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				public int SendBufferSize
				{
				[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 33)]
						get{ return GetSendBufferSize(); }
				[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 33)]
						set{ SetSendBufferSize(value); }
				}

				/// <summary>
				/// <para>Gets the socket receive timeout.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				public int SoTimeout
				{
				[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 33)]
						get{ return GetSoTimeout(); }
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 33)]
						set{ SetSoTimeout(value); }
				}

				/// <summary>
				/// <para>Returns the <c> SocketAddress </c> this socket is connected to, or null for an unconnected socket. </para>        
				/// </summary>
				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress RemoteSocketAddress
				{
				[Dot42.DexImport("getRemoteSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetRemoteSocketAddress(); }
				}

				/// <summary>
				/// <para>Returns the <c> SocketAddress </c> this socket is bound to, or null for an unbound socket. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public global::Java.Net.SocketAddress LocalSocketAddress
				{
				[Dot42.DexImport("getLocalSocketAddress", "()Ljava/net/SocketAddress;", AccessFlags = 1)]
						get{ return GetLocalSocketAddress(); }
				}

				/// <summary>
				/// <para>Gets the state of the socket option <c> SocketOptions.SO_REUSEADDR </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the option is enabled, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getReuseAddress
				/// </java-name>
				public bool IsReuseAddress
				{
				[Dot42.DexImport("getReuseAddress", "()Z", AccessFlags = 1)]
						get{ return GetReuseAddress(); }
				[Dot42.DexImport("setReuseAddress", "(Z)V", AccessFlags = 1)]
						set{ SetReuseAddress(value); }
				}

				/// <summary>
				/// <para>Gets the state of the socket option <c> SocketOptions.SO_BROADCAST </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the option is enabled, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getBroadcast
				/// </java-name>
				public bool IsBroadcast
				{
				[Dot42.DexImport("getBroadcast", "()Z", AccessFlags = 1)]
						get{ return GetBroadcast(); }
				[Dot42.DexImport("setBroadcast", "(Z)V", AccessFlags = 1)]
						set{ SetBroadcast(value); }
				}

				/// <summary>
				/// <para>Returns this socket's {<para>SocketOptions::IP_TOS} setting.</para></para>        
				/// </summary>
				/// <java-name>
				/// getTrafficClass
				/// </java-name>
				public int TrafficClass
				{
				[Dot42.DexImport("getTrafficClass", "()I", AccessFlags = 1)]
						get{ return GetTrafficClass(); }
				[Dot42.DexImport("setTrafficClass", "(I)V", AccessFlags = 1)]
						set{ SetTrafficClass(value); }
				}

				/// <summary>
				/// <para>Returns this socket's <c> DatagramChannel </c> , if one exists. A channel is available only if this socket wraps a channel. (That is, you can go from a channel to a socket and back again, but you can't go from an arbitrary socket to a channel.) In practice, this means that the socket must have been created by java.nio.channels.DatagramChannel#open. </para>        
				/// </summary>
				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.DatagramChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/DatagramChannel;", AccessFlags = 1)]
						get{ return GetChannel(); }
				}

		}

		/// <summary>
		/// <para>Selects the proxy server to use, if any, when connecting to a given URL.</para><para><h3>System Properties</h3></para><para>The default proxy selector is configured by system properties.</para><para><table><row><entry><para>Hostname patterns </para></entry></row><row><entry><para>URL scheme</para></entry><entry><para>property name</para></entry><entry><para>description</para></entry><entry><para>default </para></entry></row><row><entry><para>ftp</para></entry><entry><para>ftp.nonProxyHosts</para></entry><entry><para>Hostname pattern for FTP servers to connect to directly (without a proxy).</para></entry><entry><para></para></entry></row><row><entry><para>http</para></entry><entry><para>http.nonProxyHosts</para></entry><entry><para>Hostname pattern for HTTP servers to connect to directly (without a proxy).</para></entry><entry><para></para></entry></row><row><entry><para>https</para></entry><entry><para>https.nonProxyHosts</para></entry><entry><para>Hostname pattern for HTTPS servers to connect to directly (without a proxy).</para></entry><entry><para></para></entry></row><row><entry><para><br></br></para><para></para></entry></row><row><entry><para>Proxy.Type::HTTP HTTP Proxies} </para></entry></row><row><entry><para>URL scheme</para></entry><entry><para>property name</para></entry><entry><para>description</para></entry><entry><para>default </para></entry></row><row><entry><para>ftp</para></entry><entry><para>ftp.proxyHost</para></entry><entry><para>Hostname of the HTTP proxy server used for FTP requests.</para></entry><entry><para></para></entry></row><row><entry><para>ftp.proxyPort</para></entry><entry><para>Port number of the HTTP proxy server used for FTP requests.</para></entry><entry><para>80 </para></entry></row><row><entry><para>http</para></entry><entry><para>http.proxyHost</para></entry><entry><para>Hostname of the HTTP proxy server used for HTTP requests.</para></entry><entry><para></para></entry></row><row><entry><para>http.proxyPort</para></entry><entry><para>Port number of the HTTP proxy server used for HTTP requests.</para></entry><entry><para>80 </para></entry></row><row><entry><para>https</para></entry><entry><para>https.proxyHost</para></entry><entry><para>Hostname of the HTTP proxy server used for HTTPS requests.</para></entry><entry><para></para></entry></row><row><entry><para>https.proxyPort</para></entry><entry><para>Port number of the HTTP proxy server used for HTTPS requests.</para></entry><entry><para>443 </para></entry></row><row><entry><para>ftp, http or https</para></entry><entry><para>proxyHost</para></entry><entry><para>Hostname of the HTTP proxy server used for FTP, HTTP and HTTPS requests.</para></entry><entry><para></para></entry></row><row><entry><para>proxyPort</para></entry><entry><para>Port number of the HTTP proxy server.</para></entry><entry><para>80 for FTP and HTTP <br></br>443 for HTTPS </para></entry></row><row><entry><para><br></br></para><para></para></entry></row><row><entry><para>Proxy.Type::SOCKS SOCKS Proxies} </para></entry></row><row><entry><para>URL scheme</para></entry><entry><para>property name</para></entry><entry><para>description</para></entry><entry><para>default </para></entry></row><row><entry><para>ftp, http, https or socket</para></entry><entry><para>socksProxyHost</para></entry><entry><para>Hostname of the SOCKS proxy server used for FTP, HTTP, HTTPS and raw sockets.<br></br>Raw socket URLs are of the form <code>socket://<b>host</b>:<b>port</b></code></para></entry><entry><para></para></entry></row><row><entry><para>socksProxyPort</para></entry><entry><para>Port number of the SOCKS proxy server.</para></entry><entry><para>1080 </para></entry></row></table></para><para>Hostname patterns specify which hosts should be connected to directly, ignoring any other proxy system properties. If the URL's host matches the corresponding hostname pattern, Proxy#NO_PROXY is returned.</para><para>The format of a hostname pattern is a list of hostnames that are separated by <c> | </c> and that use <c> * </c> as a wildcard. For example, setting the <c> http.nonProxyHosts </c> property to <c>   *.android.com|*.kernel.org </c> will cause requests to <c>   http://developer.android.com </c> to be made without a proxy.</para><para>The default proxy selector always returns exactly one proxy. If no proxy is applicable, Proxy#NO_PROXY is returned. If multiple proxies are applicable, such as when both the <c> proxyHost </c> and <c>   socksProxyHost </c> system properties are set, the result is the property listed earliest in the table above.</para><para><h3>Alternatives</h3></para><para>To request a URL without involving the system proxy selector, explicitly specify a proxy or Proxy#NO_PROXY using URL#openConnection(Proxy).</para><para>Use ProxySelector#setDefault(ProxySelector) to install a custom proxy selector. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/ProxySelector
		/// </java-name>
		[Dot42.DexImport("java/net/ProxySelector", AccessFlags = 1057)]
		public abstract partial class ProxySelector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProxySelector() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default proxy selector, or null if none exists. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Ljava/net/ProxySelector;", AccessFlags = 9)]
				public static global::Java.Net.ProxySelector GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.ProxySelector);
				}

				/// <summary>
				/// <para>Sets the default proxy selector. If <c> selector </c> is null, the current proxy selector will be removed. </para>        
				/// </summary>
				/// <java-name>
				/// setDefault
				/// </java-name>
				[Dot42.DexImport("setDefault", "(Ljava/net/ProxySelector;)V", AccessFlags = 9)]
				public static void SetDefault(global::Java.Net.ProxySelector selector) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the proxy servers to use on connections to <c> uri </c> . This list will contain Proxy#NO_PROXY if no proxy server should be used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// select
				/// </java-name>
				[Dot42.DexImport("select", "(Ljava/net/URI;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/net/URI;)Ljava/util/List<Ljava/net/Proxy;>;")]
				public abstract global::Java.Util.IList<global::Java.Net.Proxy> Select(global::System.Uri uri) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies this <c> ProxySelector </c> that a connection to the proxy server could not be established.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connectFailed
				/// </java-name>
				[Dot42.DexImport("connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V", AccessFlags = 1025)]
				public abstract void ConnectFailed(global::System.Uri uri, global::Java.Net.SocketAddress address, global::System.IO.IOException failure) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the default proxy selector, or null if none exists. </para>        
				/// </summary>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Java.Net.ProxySelector Default
				{
				[Dot42.DexImport("getDefault", "()Ljava/net/ProxySelector;", AccessFlags = 9)]
						get{ return GetDefault(); }
				[Dot42.DexImport("setDefault", "(Ljava/net/ProxySelector;)V", AccessFlags = 9)]
						set{ SetDefault(value); }
				}

		}

		/// <summary>
		/// <para>This class represents a socket endpoint described by a IP address and a port number. It is a concrete implementation of <c> SocketAddress </c> for IP. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/InetSocketAddress
		/// </java-name>
		[Dot42.DexImport("java/net/InetSocketAddress", AccessFlags = 33)]
		public partial class InetSocketAddress : global::Java.Net.SocketAddress
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a socket endpoint with the given port number <c> port </c> and no specified address. The range for valid port numbers is between 0 and 65535 inclusive.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public InetSocketAddress(int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a socket endpoint with the given port number <c> port </c> and <c> address </c> . The range for valid port numbers is between 0 and 65535 inclusive. If <c> address </c> is <c> null </c> this socket is bound to the IPv4 wildcard address.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;I)V", AccessFlags = 1)]
				public InetSocketAddress(global::Java.Net.InetAddress address, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a socket endpoint with the given port number <c> port </c> and <c> address </c> . The range for valid port numbers is between 0 and 65535 inclusive. If <c> address </c> is <c> null </c> this socket is bound to the IPv4 wildcard address.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public InetSocketAddress(string address, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an <c> InetSocketAddress </c> without trying to resolve the hostname into an <c> InetAddress </c> . The address field is marked as unresolved.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created InetSocketAddress instance. </para>
				/// </returns>
				/// <java-name>
				/// createUnresolved
				/// </java-name>
				[Dot42.DexImport("createUnresolved", "(Ljava/lang/String;I)Ljava/net/InetSocketAddress;", AccessFlags = 9)]
				public static global::Java.Net.InetSocketAddress CreateUnresolved(string host, int port) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetSocketAddress);
				}

				/// <summary>
				/// <para>Gets the port number of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket endpoint port number. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 17)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the address of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket endpoint address. </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
				public global::Java.Net.InetAddress GetAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the hostname, doing a reverse lookup on the <c> InetAddress </c> if no hostname string was provided at construction time. </para>        
				/// </summary>
				/// <java-name>
				/// getHostName
				/// </java-name>
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetHostName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns whether this socket address is unresolved or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this socket address is unresolved, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isUnresolved
				/// </java-name>
				[Dot42.DexImport("isUnresolved", "()Z", AccessFlags = 17)]
				public bool IsUnresolved() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a string containing the address (or the hostname for an unresolved <c> InetSocketAddress </c> ) and port number. For example: <c> "www.google.com/74.125.224.115:80" </c> or <c> "/127.0.0.1:80" </c> . </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Compares two socket endpoints and returns true if they are equal. Two socket endpoints are equal if the IP address or the hostname of both are equal and they are bound to the same port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this socket and the given socket object <c>               socketAddr </c> are equal, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object socketAddr) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InetSocketAddress() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the port number of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket endpoint port number. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 17)]
						get{ return GetPort(); }
				}

				/// <summary>
				/// <para>Gets the address of this socket.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the socket endpoint address. </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				public global::Java.Net.InetAddress Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/net/InetAddress;", AccessFlags = 17)]
						get{ return GetAddress(); }
				}

				/// <summary>
				/// <para>Returns the hostname, doing a reverse lookup on the <c> InetAddress </c> if no hostname string was provided at construction time. </para>        
				/// </summary>
				/// <java-name>
				/// getHostName
				/// </java-name>
				public string HostName
				{
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetHostName(); }
				}

		}

		/// <summary>
		/// <para>This class implements a multicast socket for sending and receiving IP multicast datagram packets.</para><para><para>DatagramSocket </para></para>    
		/// </summary>
		/// <java-name>
		/// java/net/MulticastSocket
		/// </java-name>
		[Dot42.DexImport("java/net/MulticastSocket", AccessFlags = 33)]
		public partial class MulticastSocket : global::Java.Net.DatagramSocket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a multicast socket, bound to any available port on the local host.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MulticastSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a multicast socket, bound to the specified <c> port </c> on the local host.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public MulticastSocket(int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a multicast socket, bound to the specified <c> port </c> on the local host.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/SocketAddress;)V", AccessFlags = 1)]
				public MulticastSocket(global::Java.Net.SocketAddress port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an address of the outgoing network interface used by this socket. To avoid inherent unpredictability, new code should use getNetworkInterface instead.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getInterface
				/// </java-name>
				[Dot42.DexImport("getInterface", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <summary>
				/// <para>Returns the outgoing network interface used by this socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getNetworkInterface
				/// </java-name>
				[Dot42.DexImport("getNetworkInterface", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
				public virtual global::Java.Net.NetworkInterface GetNetworkInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.NetworkInterface);
				}

				/// <summary>
				/// <para>Returns the time-to-live (TTL) for multicast packets sent on this socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getTimeToLive
				/// </java-name>
				[Dot42.DexImport("getTimeToLive", "()I", AccessFlags = 1)]
				public virtual int GetTimeToLive() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the time-to-live (TTL) for multicast packets sent on this socket.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by getTimeToLive </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getTTL
				/// </java-name>
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1)]
				public virtual sbyte JavaGetTTL() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Returns the time-to-live (TTL) for multicast packets sent on this socket.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by getTimeToLive </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getTTL
				/// </java-name>
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte GetTTL() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				/// <para>Adds this socket to the specified multicast group. A socket must join a group before data may be received. A socket may be a member of multiple groups but may join any group only once.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// joinGroup
				/// </java-name>
				[Dot42.DexImport("joinGroup", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void JoinGroup(global::Java.Net.InetAddress groupAddr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds this socket to the specified multicast group. A socket must join a group before data may be received. A socket may be a member of multiple groups but may join any group only once.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// joinGroup
				/// </java-name>
				[Dot42.DexImport("joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", AccessFlags = 1)]
				public virtual void JoinGroup(global::Java.Net.SocketAddress groupAddress, global::Java.Net.NetworkInterface netInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes this socket from the specified multicast group.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// leaveGroup
				/// </java-name>
				[Dot42.DexImport("leaveGroup", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void LeaveGroup(global::Java.Net.InetAddress groupAddr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes this socket from the specified multicast group.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// leaveGroup
				/// </java-name>
				[Dot42.DexImport("leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", AccessFlags = 1)]
				public virtual void LeaveGroup(global::Java.Net.SocketAddress groupAddress, global::Java.Net.NetworkInterface netInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sends the given <c> packet </c> on this socket, using the given <c> ttl </c> . This method is deprecated because it modifies the TTL socket option for this socket twice on each call.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use setTimeToLive. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/net/DatagramPacket;B)V", AccessFlags = 1)]
				public virtual void Send(global::Java.Net.DatagramPacket packet, sbyte ttl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sends the given <c> packet </c> on this socket, using the given <c> ttl </c> . This method is deprecated because it modifies the TTL socket option for this socket twice on each call.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use setTimeToLive. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Ljava/net/DatagramPacket;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Send(global::Java.Net.DatagramPacket packet, byte ttl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the outgoing network interface used by this socket. The interface used is the first interface found to have the given <c> address </c> . To avoid inherent unpredictability, new code should use getNetworkInterface instead.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterface
				/// </java-name>
				[Dot42.DexImport("setInterface", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void SetInterface(global::Java.Net.InetAddress address) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the outgoing network interface used by this socket to the given <c> networkInterface </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNetworkInterface
				/// </java-name>
				[Dot42.DexImport("setNetworkInterface", "(Ljava/net/NetworkInterface;)V", AccessFlags = 1)]
				public virtual void SetNetworkInterface(global::Java.Net.NetworkInterface networkInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the time-to-live (TTL) for multicast packets sent on this socket. Valid TTL values are between 0 and 255 inclusive.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTimeToLive
				/// </java-name>
				[Dot42.DexImport("setTimeToLive", "(I)V", AccessFlags = 1)]
				public virtual void SetTimeToLive(int ttl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the time-to-live (TTL) for multicast packets sent on this socket. Valid TTL values are between 0 and 255 inclusive.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by setTimeToLive </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setTTL
				/// </java-name>
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1)]
				public virtual void SetTTL(sbyte ttl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the time-to-live (TTL) for multicast packets sent on this socket. Valid TTL values are between 0 and 255 inclusive.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by setTimeToLive </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setTTL
				/// </java-name>
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetTTL(byte ttl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if multicast loopback is <b>disabled</b>. See SocketOptions#IP_MULTICAST_LOOP, and note that the sense of this is the opposite of the underlying Unix <c> IP_MULTICAST_LOOP </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLoopbackMode
				/// </java-name>
				[Dot42.DexImport("getLoopbackMode", "()Z", AccessFlags = 1)]
				public virtual bool GetLoopbackMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Disables multicast loopback if <c> disable == true </c> . See SocketOptions#IP_MULTICAST_LOOP, and note that the sense of this is the opposite of the underlying Unix <c> IP_MULTICAST_LOOP </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLoopbackMode
				/// </java-name>
				[Dot42.DexImport("setLoopbackMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetLoopbackMode(bool disable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an address of the outgoing network interface used by this socket. To avoid inherent unpredictability, new code should use getNetworkInterface instead.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getInterface
				/// </java-name>
				public global::Java.Net.InetAddress Interface
				{
				[Dot42.DexImport("getInterface", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetInterface(); }
				[Dot42.DexImport("setInterface", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
						set{ SetInterface(value); }
				}

				/// <summary>
				/// <para>Returns the outgoing network interface used by this socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getNetworkInterface
				/// </java-name>
				public global::Java.Net.NetworkInterface NetworkInterface
				{
				[Dot42.DexImport("getNetworkInterface", "()Ljava/net/NetworkInterface;", AccessFlags = 1)]
						get{ return GetNetworkInterface(); }
				[Dot42.DexImport("setNetworkInterface", "(Ljava/net/NetworkInterface;)V", AccessFlags = 1)]
						set{ SetNetworkInterface(value); }
				}

				/// <summary>
				/// <para>Returns the time-to-live (TTL) for multicast packets sent on this socket.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getTimeToLive
				/// </java-name>
				public int TimeToLive
				{
				[Dot42.DexImport("getTimeToLive", "()I", AccessFlags = 1)]
						get{ return GetTimeToLive(); }
				[Dot42.DexImport("setTimeToLive", "(I)V", AccessFlags = 1)]
						set{ SetTimeToLive(value); }
				}

				/// <summary>
				/// <para>Returns the time-to-live (TTL) for multicast packets sent on this socket.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Replaced by getTimeToLive </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getTTL
				/// </java-name>
				public byte TTL
				{
				[Dot42.DexImport("getTTL", "()B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetTTL(); }
				[Dot42.DexImport("setTTL", "(B)V", AccessFlags = 1, IgnoreFromJava = true)]
						set{ SetTTL(value); }
				}

				/// <summary>
				/// <para>Returns true if multicast loopback is <b>disabled</b>. See SocketOptions#IP_MULTICAST_LOOP, and note that the sense of this is the opposite of the underlying Unix <c> IP_MULTICAST_LOOP </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLoopbackMode
				/// </java-name>
				public bool IsLoopbackMode
				{
				[Dot42.DexImport("getLoopbackMode", "()Z", AccessFlags = 1)]
						get{ return GetLoopbackMode(); }
				[Dot42.DexImport("setLoopbackMode", "(Z)V", AccessFlags = 1)]
						set{ SetLoopbackMode(value); }
				}

		}

}


