// Copyright (C) 2014 dot42
//
// Original filename: Android.Bluetooth.cs
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
namespace Android.Bluetooth
{
		/// <summary>
		/// <para>This class provides the public APIs to control the Bluetooth A2DP profile.</para><para>BluetoothA2dp is a proxy object for controlling the Bluetooth A2DP Service via IPC. Use BluetoothAdapter#getProfileProxy to get the BluetoothA2dp proxy object.</para><para>Android only supports one connected Bluetooth A2dp device at a time. Each method is protected with its appropriate permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothA2dp
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothA2dp", AccessFlags = 49)]
		public sealed partial class BluetoothA2dp : global::Android.Bluetooth.IBluetoothProfile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Intent used to broadcast the change in connection state of the A2DP profile.</para><para>This intent will have 3 extras: <ul><li><para>EXTRA_STATE - The current state of the profile.  </para></li><li><para>EXTRA_PREVIOUS_STATE- The previous state of the profile. </para></li><li><para>BluetoothDevice#EXTRA_DEVICE - The remote device.  </para></li></ul></para><para>EXTRA_STATE or EXTRA_PREVIOUS_STATE can be any of STATE_DISCONNECTED, STATE_CONNECTING, STATE_CONNECTED, STATE_DISCONNECTING.</para><para>Requires android.Manifest.permission#BLUETOOTH permission to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CONNECTION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CONNECTION_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CONNECTION_STATE_CHANGED = "android.bluetooth.a2dp.profile.action.CONNECTION_STATE_CHANGED";
				/// <summary>
				/// <para>Intent used to broadcast the change in the Playing state of the A2DP profile.</para><para>This intent will have 3 extras: <ul><li><para>EXTRA_STATE - The current state of the profile.  </para></li><li><para>EXTRA_PREVIOUS_STATE- The previous state of the profile.  </para></li><li><para>BluetoothDevice#EXTRA_DEVICE - The remote device.  </para></li></ul></para><para>EXTRA_STATE or EXTRA_PREVIOUS_STATE can be any of STATE_PLAYING, STATE_NOT_PLAYING,</para><para>Requires android.Manifest.permission#BLUETOOTH permission to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PLAYING_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PLAYING_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PLAYING_STATE_CHANGED = "android.bluetooth.a2dp.profile.action.PLAYING_STATE_CHANGED";
				/// <summary>
				/// <para>A2DP sink device is streaming music. This state can be one of EXTRA_STATE or EXTRA_PREVIOUS_STATE of ACTION_PLAYING_STATE_CHANGED intent. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_PLAYING
				/// </java-name>
				[Dot42.DexImport("STATE_PLAYING", "I", AccessFlags = 25)]
				public const int STATE_PLAYING = 10;
				/// <summary>
				/// <para>A2DP sink device is NOT streaming music. This state can be one of EXTRA_STATE or EXTRA_PREVIOUS_STATE of ACTION_PLAYING_STATE_CHANGED intent. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_NOT_PLAYING
				/// </java-name>
				[Dot42.DexImport("STATE_NOT_PLAYING", "I", AccessFlags = 25)]
				public const int STATE_NOT_PLAYING = 11;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothA2dp() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Get connected devices for this specific profile.</para><para>Return the set of devices which are in state STATE_CONNECTED</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>List of devices. The list will be empty on error.</para>
				/// </returns>
				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetConnectedDevices() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>);
				}

				/// <summary>
				/// <para><para>Get a list of devices that match any of the given connection states.</para><para>If none of the devices match any of the given states, an empty list will be returned.</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>List of devices. The list will be empty on error.</para>
				/// </returns>
				/// <java-name>
				/// getDevicesMatchingConnectionStates
				/// </java-name>
				[Dot42.DexImport("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", AccessFlags = 1, Signature = "([I)Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] states) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>);
				}

				/// <summary>
				/// <para><para>Get the current connection state of the profile</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>State of the profile connection. One of STATE_CONNECTED, STATE_CONNECTING, STATE_DISCONNECTED, STATE_DISCONNECTING</para>
				/// </returns>
				/// <java-name>
				/// getConnectionState
				/// </java-name>
				[Dot42.DexImport("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", AccessFlags = 1)]
				public int GetConnectionState(global::Android.Bluetooth.BluetoothDevice device) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Check if A2DP profile is streaming music.</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// isA2dpPlaying
				/// </java-name>
				[Dot42.DexImport("isA2dpPlaying", "(Landroid/bluetooth/BluetoothDevice;)Z", AccessFlags = 1)]
				public bool IsA2dpPlaying(global::Android.Bluetooth.BluetoothDevice device) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Get connected devices for this specific profile.</para><para>Return the set of devices which are in state STATE_CONNECTED</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>List of devices. The list will be empty on error.</para>
				/// </returns>
				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> ConnectedDevices
				{
				[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
						get{ return GetConnectedDevices(); }
				}

		}

		/// <summary>
		/// <para>A connected or connecting Bluetooth socket.</para><para>The interface for Bluetooth Sockets is similar to that of TCP sockets: java.net.Socket and java.net.ServerSocket. On the server side, use a BluetoothServerSocket to create a listening server socket. When a connection is accepted by the BluetoothServerSocket, it will return a new BluetoothSocket to manage the connection. On the client side, use a single BluetoothSocket to both initiate an outgoing connection and to manage the connection.</para><para>The most common type of Bluetooth socket is RFCOMM, which is the type supported by the Android APIs. RFCOMM is a connection-oriented, streaming transport over Bluetooth. It is also known as the Serial Port Profile (SPP).</para><para>To create a BluetoothSocket for connecting to a known device, use BluetoothDevice.createRfcommSocketToServiceRecord(). Then call connect() to attempt a connection to the remote device. This call will block until a connection is established or the connection fails.</para><para>To create a BluetoothSocket as a server (or "host"), see the BluetoothServerSocket documentation.</para><para>Once the socket is connected, whether initiated as a client or accepted as a server, open the IO streams by calling getInputStream and getOutputStream in order to retrieve java.io.InputStream and java.io.OutputStream objects, respectively, which are automatically connected to the socket.</para><para>BluetoothSocket is thread safe. In particular, close will always immediately abort ongoing operations and close the socket.</para><para><b>Note:</b> Requires the android.Manifest.permission#BLUETOOTH permission.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using Bluetooth, read the  developer guide.</para><para> </para><para>{<para>BluetoothServerSocket} {</para><simplesectsep></simplesectsep><para>java.io.InputStream} {</para><simplesectsep></simplesectsep><para>java.io.OutputStream} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothSocket
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothSocket", AccessFlags = 49)]
		public sealed partial class BluetoothSocket : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempt to connect to a remote device. </para><para>This method will block until a connection is made or the connection fails. If this method returns without an exception then this socket is now connected. </para><para>Creating new connections to remote Bluetooth devices should not be attempted while device discovery is in progress. Device discovery is a heavyweight procedure on the Bluetooth adapter and will significantly slow a device connection. Use BluetoothAdapter#cancelDiscovery() to cancel an ongoing discovery. Discovery is not managed by the Activity, but is run as a system service, so an application should always call BluetoothAdapter#cancelDiscovery() even if it did not directly request a discovery, just to be sure. </para><para>close can be used to abort this call from another thread. </para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1)]
				public void Connect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes the object and release any system resources it holds.</para><para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c> AutoCloseable.close() </c> , which may be called at most once. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the remote device this socket is connecting, or connected, to. </para>        
				/// </summary>
				/// <returns>
				/// <para>remote device </para>
				/// </returns>
				/// <java-name>
				/// getRemoteDevice
				/// </java-name>
				[Dot42.DexImport("getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothDevice GetRemoteDevice() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothDevice);
				}

				/// <summary>
				/// <para>Get the input stream associated with this socket. </para><para>The input stream will be returned even if the socket is not yet connected, but operations on that stream will throw IOException until the associated socket is connected. </para>        
				/// </summary>
				/// <returns>
				/// <para>InputStream </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Get the output stream associated with this socket. </para><para>The output stream will be returned even if the socket is not yet connected, but operations on that stream will throw IOException until the associated socket is connected. </para>        
				/// </summary>
				/// <returns>
				/// <para>OutputStream </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
				public global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <summary>
				/// <para>Get the remote device this socket is connecting, or connected, to. </para>        
				/// </summary>
				/// <returns>
				/// <para>remote device </para>
				/// </returns>
				/// <java-name>
				/// getRemoteDevice
				/// </java-name>
				public global::Android.Bluetooth.BluetoothDevice RemoteDevice
				{
				[Dot42.DexImport("getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;", AccessFlags = 1)]
						get{ return GetRemoteDevice(); }
				}

				/// <summary>
				/// <para>Get the input stream associated with this socket. </para><para>The input stream will be returned even if the socket is not yet connected, but operations on that stream will throw IOException until the associated socket is connected. </para>        
				/// </summary>
				/// <returns>
				/// <para>InputStream </para>
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
				/// <para>Get the output stream associated with this socket. </para><para>The output stream will be returned even if the socket is not yet connected, but operations on that stream will throw IOException until the associated socket is connected. </para>        
				/// </summary>
				/// <returns>
				/// <para>OutputStream </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public global::Java.Io.OutputStream OutputStream
				{
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return GetOutputStream(); }
				}

		}

		/// <summary>
		/// <para>Public API for controlling the Bluetooth Headset Service. This includes both Bluetooth Headset and Handsfree (v1.5) profiles.</para><para>BluetoothHeadset is a proxy object for controlling the Bluetooth Headset Service via IPC.</para><para>Use BluetoothAdapter#getProfileProxy to get the BluetoothHeadset proxy object. Use BluetoothAdapter#closeProfileProxy to close the service connection.</para><para>Android only supports one connected Bluetooth Headset at a time. Each method is protected with its appropriate permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothHeadset
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothHeadset", AccessFlags = 49)]
		public sealed partial class BluetoothHeadset : global::Android.Bluetooth.IBluetoothProfile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Intent used to broadcast the change in connection state of the Headset profile.</para><para>This intent will have 3 extras: <ul><li><para>EXTRA_STATE - The current state of the profile.  </para></li><li><para>EXTRA_PREVIOUS_STATE- The previous state of the profile.  </para></li><li><para>BluetoothDevice#EXTRA_DEVICE - The remote device.  </para></li></ul></para><para>EXTRA_STATE or EXTRA_PREVIOUS_STATE can be any of STATE_DISCONNECTED, STATE_CONNECTING, STATE_CONNECTED, STATE_DISCONNECTING.</para><para>Requires android.Manifest.permission#BLUETOOTH permission to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CONNECTION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CONNECTION_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CONNECTION_STATE_CHANGED = "android.bluetooth.headset.profile.action.CONNECTION_STATE_CHANGED";
				/// <summary>
				/// <para>Intent used to broadcast the change in the Audio Connection state of the A2DP profile.</para><para>This intent will have 3 extras: <ul><li><para>EXTRA_STATE - The current state of the profile.  </para></li><li><para>EXTRA_PREVIOUS_STATE- The previous state of the profile.  </para></li><li><para>BluetoothDevice#EXTRA_DEVICE - The remote device.  </para></li></ul></para><para>EXTRA_STATE or EXTRA_PREVIOUS_STATE can be any of STATE_AUDIO_CONNECTED, STATE_AUDIO_DISCONNECTED,</para><para>Requires android.Manifest.permission#BLUETOOTH permission to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_AUDIO_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_AUDIO_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AUDIO_STATE_CHANGED = "android.bluetooth.headset.profile.action.AUDIO_STATE_CHANGED";
				/// <summary>
				/// <para>Intent used to broadcast that the headset has posted a vendor-specific event.</para><para>This intent will have 4 extras and 1 category. <ul><li><para>BluetoothDevice#EXTRA_DEVICE - The remote Bluetooth Device  </para></li><li><para>EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD - The vendor specific command  </para></li><li><para>EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE - The AT command type which can be one of AT_CMD_TYPE_READ, AT_CMD_TYPE_TEST, or AT_CMD_TYPE_SET, AT_CMD_TYPE_BASIC,AT_CMD_TYPE_ACTION.  </para></li><li><para>EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS - Command arguments.  </para></li></ul></para><para>The category is the Company ID of the vendor defining the vendor-specific command. BluetoothAssignedNumbers</para><para>For example, for Plantronics specific events Category will be VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY.55</para><para>For example, an AT+XEVENT=foo,3 will get translated into <ul><li><para>EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD = +XEVENT  </para></li><li><para>EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE = AT_CMD_TYPE_SET  </para></li><li><para>EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS = foo, 3  </para></li></ul></para><para>Requires android.Manifest.permission#BLUETOOTH permission to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_VENDOR_SPECIFIC_HEADSET_EVENT
				/// </java-name>
				[Dot42.DexImport("ACTION_VENDOR_SPECIFIC_HEADSET_EVENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VENDOR_SPECIFIC_HEADSET_EVENT = "android.bluetooth.headset.action.VENDOR_SPECIFIC_HEADSET_EVENT";
				/// <summary>
				/// <para>A String extra field in ACTION_VENDOR_SPECIFIC_HEADSET_EVENT intents that contains the name of the vendor-specific command. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD
				/// </java-name>
				[Dot42.DexImport("EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD = "android.bluetooth.headset.extra.VENDOR_SPECIFIC_HEADSET_EVENT_CMD";
				/// <summary>
				/// <para>An int extra field in ACTION_VENDOR_SPECIFIC_HEADSET_EVENT intents that contains the AT command type of the vendor-specific command. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE
				/// </java-name>
				[Dot42.DexImport("EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE = "android.bluetooth.headset.extra.VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE";
				/// <summary>
				/// <para>AT command type READ used with EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE For example, AT+VGM?. There are no arguments for this command type. </para>        
				/// </summary>
				/// <java-name>
				/// AT_CMD_TYPE_READ
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_READ", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_READ = 0;
				/// <summary>
				/// <para>AT command type TEST used with EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE For example, AT+VGM=?. There are no arguments for this command type. </para>        
				/// </summary>
				/// <java-name>
				/// AT_CMD_TYPE_TEST
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_TEST", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_TEST = 1;
				/// <summary>
				/// <para>AT command type SET used with EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE For example, AT+VGM=&lt;args&gt;. </para>        
				/// </summary>
				/// <java-name>
				/// AT_CMD_TYPE_SET
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_SET", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_SET = 2;
				/// <summary>
				/// <para>AT command type BASIC used with EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE For example, ATD. Single character commands and everything following the character are arguments. </para>        
				/// </summary>
				/// <java-name>
				/// AT_CMD_TYPE_BASIC
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_BASIC", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_BASIC = 3;
				/// <summary>
				/// <para>AT command type ACTION used with EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE For example, AT+CHUP. There are no arguments for action commands. </para>        
				/// </summary>
				/// <java-name>
				/// AT_CMD_TYPE_ACTION
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_ACTION", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_ACTION = 4;
				/// <summary>
				/// <para>A Parcelable String array extra field in ACTION_VENDOR_SPECIFIC_HEADSET_EVENT intents that contains the arguments to the vendor-specific command. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS = "android.bluetooth.headset.extra.VENDOR_SPECIFIC_HEADSET_EVENT_ARGS";
				/// <summary>
				/// <para>The intent category to be used with ACTION_VENDOR_SPECIFIC_HEADSET_EVENT for the companyId </para>        
				/// </summary>
				/// <java-name>
				/// VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY
				/// </java-name>
				[Dot42.DexImport("VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY = "android.bluetooth.headset.intent.category.companyid";
				/// <summary>
				/// <para>Headset state when SCO audio is not connected. This state can be one of EXTRA_STATE or EXTRA_PREVIOUS_STATE of ACTION_AUDIO_STATE_CHANGED intent. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_AUDIO_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_AUDIO_DISCONNECTED", "I", AccessFlags = 25)]
				public const int STATE_AUDIO_DISCONNECTED = 10;
				/// <summary>
				/// <para>Headset state when SCO audio is connecting. This state can be one of EXTRA_STATE or EXTRA_PREVIOUS_STATE of ACTION_AUDIO_STATE_CHANGED intent. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_AUDIO_CONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_AUDIO_CONNECTING", "I", AccessFlags = 25)]
				public const int STATE_AUDIO_CONNECTING = 11;
				/// <summary>
				/// <para>Headset state when SCO audio is connected. This state can be one of EXTRA_STATE or EXTRA_PREVIOUS_STATE of ACTION_AUDIO_STATE_CHANGED intent. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_AUDIO_CONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_AUDIO_CONNECTED", "I", AccessFlags = 25)]
				public const int STATE_AUDIO_CONNECTED = 12;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothHeadset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Get connected devices for this specific profile.</para><para>Return the set of devices which are in state STATE_CONNECTED</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>List of devices. The list will be empty on error.</para>
				/// </returns>
				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetConnectedDevices() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>);
				}

				/// <summary>
				/// <para><para>Get a list of devices that match any of the given connection states.</para><para>If none of the devices match any of the given states, an empty list will be returned.</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>List of devices. The list will be empty on error.</para>
				/// </returns>
				/// <java-name>
				/// getDevicesMatchingConnectionStates
				/// </java-name>
				[Dot42.DexImport("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", AccessFlags = 1, Signature = "([I)Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] states) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>);
				}

				/// <summary>
				/// <para><para>Get the current connection state of the profile</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>State of the profile connection. One of STATE_CONNECTED, STATE_CONNECTING, STATE_DISCONNECTED, STATE_DISCONNECTING</para>
				/// </returns>
				/// <java-name>
				/// getConnectionState
				/// </java-name>
				[Dot42.DexImport("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", AccessFlags = 1)]
				public int GetConnectionState(global::Android.Bluetooth.BluetoothDevice device) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Start Bluetooth voice recognition. This methods sends the voice recognition AT command to the headset and establishes the audio connection.</para><para>Users can listen to ACTION_AUDIO_STATE_CHANGED. If this function returns true, this intent will be broadcasted with EXTRA_STATE set to STATE_AUDIO_CONNECTING.</para><para>EXTRA_STATE will transition from STATE_AUDIO_CONNECTING to STATE_AUDIO_CONNECTED when audio connection is established and to STATE_AUDIO_DISCONNECTED in case of failure to establish the audio connection.</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>false if there is no headset connected of if the connected headset doesn't support voice recognition or on error, true otherwise </para>
				/// </returns>
				/// <java-name>
				/// startVoiceRecognition
				/// </java-name>
				[Dot42.DexImport("startVoiceRecognition", "(Landroid/bluetooth/BluetoothDevice;)Z", AccessFlags = 1)]
				public bool StartVoiceRecognition(global::Android.Bluetooth.BluetoothDevice device) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Stop Bluetooth Voice Recognition mode, and shut down the Bluetooth audio path.</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>false if there is no headset connected or on error, true otherwise </para>
				/// </returns>
				/// <java-name>
				/// stopVoiceRecognition
				/// </java-name>
				[Dot42.DexImport("stopVoiceRecognition", "(Landroid/bluetooth/BluetoothDevice;)Z", AccessFlags = 1)]
				public bool StopVoiceRecognition(global::Android.Bluetooth.BluetoothDevice device) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Check if Bluetooth SCO audio is connected.</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if SCO is connected, false otherwise or on error </para>
				/// </returns>
				/// <java-name>
				/// isAudioConnected
				/// </java-name>
				[Dot42.DexImport("isAudioConnected", "(Landroid/bluetooth/BluetoothDevice;)Z", AccessFlags = 1)]
				public bool IsAudioConnected(global::Android.Bluetooth.BluetoothDevice device) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Get connected devices for this specific profile.</para><para>Return the set of devices which are in state STATE_CONNECTED</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>List of devices. The list will be empty on error.</para>
				/// </returns>
				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> ConnectedDevices
				{
				[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
						get{ return GetConnectedDevices(); }
				}

		}

		/// <summary>
		/// <para>Represents a remote Bluetooth device. A BluetoothDevice lets you create a connection with the respective device or query information about it, such as the name, address, class, and bonding state.</para><para>This class is really just a thin wrapper for a Bluetooth hardware address. Objects of this class are immutable. Operations on this class are performed on the remote Bluetooth hardware address, using the BluetoothAdapter that was used to create this BluetoothDevice.</para><para>To get a BluetoothDevice, use BluetoothAdapter.getRemoteDevice(String) to create one representing a device of a known MAC address (which you can get through device discovery with BluetoothAdapter) or get one from the set of bonded devices returned by BluetoothAdapter.getBondedDevices(). You can then open a BluetoothSocket for communication with the remote device, using createRfcommSocketToServiceRecord(UUID).</para><para><b>Note:</b> Requires the android.Manifest.permission#BLUETOOTH permission.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using Bluetooth, read the  developer guide.</para><para> </para><para>{<para>BluetoothAdapter} {</para><simplesectsep></simplesectsep><para>BluetoothSocket} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothDevice
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothDevice", AccessFlags = 49)]
		public sealed partial class BluetoothDevice : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Sentinel error value for this class. Guaranteed to not equal any other integer constant in this class. Provided as a convenience for functions that require a sentinel error value, for example: </para><para><code>Intent.getIntExtra(BluetoothDevice.EXTRA_BOND_STATE, BluetoothDevice.ERROR)</code> </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -2147483648;
				/// <summary>
				/// <para>Broadcast Action: Remote device discovered. </para><para>Sent when a remote device is found during discovery. </para><para>Always contains the extra fields EXTRA_DEVICE and EXTRA_CLASS. Can contain the extra fields EXTRA_NAME and/or EXTRA_RSSI if they are available. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_FOUND
				/// </java-name>
				[Dot42.DexImport("ACTION_FOUND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_FOUND = "android.bluetooth.device.action.FOUND";
				/// <summary>
				/// <para>Broadcast Action: Bluetooth class of a remote device has changed. </para><para>Always contains the extra fields EXTRA_DEVICE and EXTRA_CLASS. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. {<para>BluetoothClass} </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CLASS_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CLASS_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CLASS_CHANGED = "android.bluetooth.device.action.CLASS_CHANGED";
				/// <summary>
				/// <para>Broadcast Action: Indicates a low level (ACL) connection has been established with a remote device. </para><para>Always contains the extra field EXTRA_DEVICE. </para><para>ACL connections are managed automatically by the Android Bluetooth stack. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ACL_CONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_ACL_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ACL_CONNECTED = "android.bluetooth.device.action.ACL_CONNECTED";
				/// <summary>
				/// <para>Broadcast Action: Indicates that a low level (ACL) disconnection has been requested for a remote device, and it will soon be disconnected. </para><para>This is useful for graceful disconnection. Applications should use this intent as a hint to immediately terminate higher level connections (RFCOMM, L2CAP, or profile connections) to the remote device. </para><para>Always contains the extra field EXTRA_DEVICE. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ACL_DISCONNECT_REQUESTED
				/// </java-name>
				[Dot42.DexImport("ACTION_ACL_DISCONNECT_REQUESTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ACL_DISCONNECT_REQUESTED = "android.bluetooth.device.action.ACL_DISCONNECT_REQUESTED";
				/// <summary>
				/// <para>Broadcast Action: Indicates a low level (ACL) disconnection from a remote device. </para><para>Always contains the extra field EXTRA_DEVICE. </para><para>ACL connections are managed automatically by the Android Bluetooth stack. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ACL_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_ACL_DISCONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ACL_DISCONNECTED = "android.bluetooth.device.action.ACL_DISCONNECTED";
				/// <summary>
				/// <para>Broadcast Action: Indicates the friendly name of a remote device has been retrieved for the first time, or changed since the last retrieval. </para><para>Always contains the extra fields EXTRA_DEVICE and EXTRA_NAME. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NAME_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_NAME_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NAME_CHANGED = "android.bluetooth.device.action.NAME_CHANGED";
				/// <summary>
				/// <para>Broadcast Action: Indicates a change in the bond state of a remote device. For example, if a device is bonded (paired). </para><para>Always contains the extra fields EXTRA_DEVICE, EXTRA_BOND_STATE and EXTRA_PREVIOUS_BOND_STATE. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_BOND_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_BOND_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BOND_STATE_CHANGED = "android.bluetooth.device.action.BOND_STATE_CHANGED";
				/// <summary>
				/// <para>Used as a Parcelable BluetoothDevice extra field in every intent broadcast by this class. It contains the BluetoothDevice that the intent applies to. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DEVICE
				/// </java-name>
				[Dot42.DexImport("EXTRA_DEVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DEVICE = "android.bluetooth.device.extra.DEVICE";
				/// <summary>
				/// <para>Used as a String extra field in ACTION_NAME_CHANGED and ACTION_FOUND intents. It contains the friendly Bluetooth name. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NAME = "android.bluetooth.device.extra.NAME";
				/// <summary>
				/// <para>Used as an optional short extra field in ACTION_FOUND intents. Contains the RSSI value of the remote device as reported by the Bluetooth hardware. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RSSI
				/// </java-name>
				[Dot42.DexImport("EXTRA_RSSI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RSSI = "android.bluetooth.device.extra.RSSI";
				/// <summary>
				/// <para>Used as a Parcelable BluetoothClass extra field in ACTION_FOUND and ACTION_CLASS_CHANGED intents. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CLASS
				/// </java-name>
				[Dot42.DexImport("EXTRA_CLASS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CLASS = "android.bluetooth.device.extra.CLASS";
				/// <summary>
				/// <para>Used as an int extra field in ACTION_BOND_STATE_CHANGED intents. Contains the bond state of the remote device. </para><para>Possible values are: BOND_NONE, BOND_BONDING, BOND_BONDED. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_BOND_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_BOND_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_BOND_STATE = "android.bluetooth.device.extra.BOND_STATE";
				/// <summary>
				/// <para>Used as an int extra field in ACTION_BOND_STATE_CHANGED intents. Contains the previous bond state of the remote device. </para><para>Possible values are: BOND_NONE, BOND_BONDING, BOND_BONDED. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PREVIOUS_BOND_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_BOND_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_BOND_STATE = "android.bluetooth.device.extra.PREVIOUS_BOND_STATE";
				/// <summary>
				/// <para>Indicates the remote device is not bonded (paired). </para><para>There is no shared link key with the remote device, so communication (if it is allowed at all) will be unauthenticated and unencrypted. </para>        
				/// </summary>
				/// <java-name>
				/// BOND_NONE
				/// </java-name>
				[Dot42.DexImport("BOND_NONE", "I", AccessFlags = 25)]
				public const int BOND_NONE = 10;
				/// <summary>
				/// <para>Indicates bonding (pairing) is in progress with the remote device. </para>        
				/// </summary>
				/// <java-name>
				/// BOND_BONDING
				/// </java-name>
				[Dot42.DexImport("BOND_BONDING", "I", AccessFlags = 25)]
				public const int BOND_BONDING = 11;
				/// <summary>
				/// <para>Indicates the remote device is bonded (paired). </para><para>A shared link keys exists locally for the remote device, so communication can be authenticated and encrypted. </para><para><b>Being bonded (paired) with a remote device does not necessarily mean the device is currently connected. It just means that the pending procedure was completed at some earlier time, and the link key is still stored locally, ready to use on the next connection. </b> </para>        
				/// </summary>
				/// <java-name>
				/// BOND_BONDED
				/// </java-name>
				[Dot42.DexImport("BOND_BONDED", "I", AccessFlags = 25)]
				public const int BOND_BONDED = 12;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Bluetooth.BluetoothDevice> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothDevice() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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
				/// <para>Returns a string representation of this BluetoothDevice. </para><para>Currently this is the Bluetooth hardware address, for example "00:11:22:AA:BB:CC". However, you should always use getAddress if you explicitly require the Bluetooth hardware address in case the toString representation changes in the future. </para>        
				/// </summary>
				/// <returns>
				/// <para>string representation of this BluetoothDevice </para>
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
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Flatten this object in to a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the hardware address of this BluetoothDevice. </para><para>For example, "00:11:22:AA:BB:CC". </para>        
				/// </summary>
				/// <returns>
				/// <para>Bluetooth hardware address as string </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the friendly Bluetooth name of the remote device.</para><para>The local adapter will automatically retrieve remote names when performing a device scan, and will cache them. This method just returns the name for this device from the cache. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Bluetooth name, or null if there was a problem. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the bond state of the remote device. </para><para>Possible values for the bond state are: BOND_NONE, BOND_BONDING, BOND_BONDED. </para><para>Requires android.Manifest.permission#BLUETOOTH.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the bond state </para>
				/// </returns>
				/// <java-name>
				/// getBondState
				/// </java-name>
				[Dot42.DexImport("getBondState", "()I", AccessFlags = 1)]
				public int GetBondState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Get the Bluetooth class of the remote device. </para><para>Requires android.Manifest.permission#BLUETOOTH.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Bluetooth class object, or null on error </para>
				/// </returns>
				/// <java-name>
				/// getBluetoothClass
				/// </java-name>
				[Dot42.DexImport("getBluetoothClass", "()Landroid/bluetooth/BluetoothClass;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothClass GetBluetoothClass() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothClass);
				}

				/// <summary>
				/// <para>Create an RFCOMM BluetoothSocket ready to start a secure outgoing connection to this remote device using SDP lookup of uuid. </para><para>This is designed to be used with BluetoothAdapter#listenUsingRfcommWithServiceRecord for peer-peer Bluetooth applications. </para><para>Use BluetoothSocket#connect to initiate the outgoing connection. This will also perform an SDP lookup of the given uuid to determine which channel to connect to. </para><para>The remote device will be authenticated and communication on this socket will be encrypted. </para><para>Use this socket only if an authenticated socket link is possible. Authentication refers to the authentication of the link key to prevent man-in-the-middle type of attacks. For example, for Bluetooth 2.1 devices, if any of the devices does not have an input and output capability or just has the ability to display a numeric key, a secure socket connection is not possible. In such a case, use {#link createInsecureRfcommSocketToServiceRecord}. For more details, refer to the Security Model section 5.2 (vol 3) of Bluetooth Core Specification version 2.1 + EDR. </para><para>Hint: If you are connecting to a Bluetooth serial board then try using the well-known SPP UUID 00001101-0000-1000-8000-00805F9B34FB. However if you are connecting to an Android peer then please generate your own unique UUID. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a RFCOMM BluetoothServerSocket ready for an outgoing connection </para>
				/// </returns>
				/// <java-name>
				/// createRfcommSocketToServiceRecord
				/// </java-name>
				[Dot42.DexImport("createRfcommSocketToServiceRecord", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothSocket CreateRfcommSocketToServiceRecord(global::Java.Util.UUID uuid) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothSocket);
				}

				/// <summary>
				/// <para>Create an RFCOMM BluetoothSocket socket ready to start an insecure outgoing connection to this remote device using SDP lookup of uuid. </para><para>The communication channel will not have an authenticated link key i.e it will be subject to man-in-the-middle attacks. For Bluetooth 2.1 devices, the link key will be encrypted, as encryption is mandatory. For legacy devices (pre Bluetooth 2.1 devices) the link key will be not be encrypted. Use createRfcommSocketToServiceRecord if an encrypted and authenticated communication channel is desired. </para><para>This is designed to be used with BluetoothAdapter#listenUsingInsecureRfcommWithServiceRecord for peer-peer Bluetooth applications. </para><para>Use BluetoothSocket#connect to initiate the outgoing connection. This will also perform an SDP lookup of the given uuid to determine which channel to connect to. </para><para>The remote device will be authenticated and communication on this socket will be encrypted. </para><para>Hint: If you are connecting to a Bluetooth serial board then try using the well-known SPP UUID 00001101-0000-1000-8000-00805F9B34FB. However if you are connecting to an Android peer then please generate your own unique UUID. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a RFCOMM BluetoothServerSocket ready for an outgoing connection </para>
				/// </returns>
				/// <java-name>
				/// createInsecureRfcommSocketToServiceRecord
				/// </java-name>
				[Dot42.DexImport("createInsecureRfcommSocketToServiceRecord", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothSocket CreateInsecureRfcommSocketToServiceRecord(global::Java.Util.UUID uuid) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothSocket);
				}

				/// <summary>
				/// <para>Returns the hardware address of this BluetoothDevice. </para><para>For example, "00:11:22:AA:BB:CC". </para>        
				/// </summary>
				/// <returns>
				/// <para>Bluetooth hardware address as string </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				public string Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAddress(); }
				}

				/// <summary>
				/// <para>Get the friendly Bluetooth name of the remote device.</para><para>The local adapter will automatically retrieve remote names when performing a device scan, and will cache them. This method just returns the name for this device from the cache. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Bluetooth name, or null if there was a problem. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Get the bond state of the remote device. </para><para>Possible values for the bond state are: BOND_NONE, BOND_BONDING, BOND_BONDED. </para><para>Requires android.Manifest.permission#BLUETOOTH.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the bond state </para>
				/// </returns>
				/// <java-name>
				/// getBondState
				/// </java-name>
				public int BondState
				{
				[Dot42.DexImport("getBondState", "()I", AccessFlags = 1)]
						get{ return GetBondState(); }
				}

				/// <summary>
				/// <para>Get the Bluetooth class of the remote device. </para><para>Requires android.Manifest.permission#BLUETOOTH.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Bluetooth class object, or null on error </para>
				/// </returns>
				/// <java-name>
				/// getBluetoothClass
				/// </java-name>
				public global::Android.Bluetooth.BluetoothClass BluetoothClass
				{
				[Dot42.DexImport("getBluetoothClass", "()Landroid/bluetooth/BluetoothClass;", AccessFlags = 1)]
						get{ return GetBluetoothClass(); }
				}

		}

		/// <summary>
		/// <para>A listening Bluetooth socket.</para><para>The interface for Bluetooth Sockets is similar to that of TCP sockets: java.net.Socket and java.net.ServerSocket. On the server side, use a BluetoothServerSocket to create a listening server socket. When a connection is accepted by the BluetoothServerSocket, it will return a new BluetoothSocket to manage the connection. On the client side, use a single BluetoothSocket to both initiate an outgoing connection and to manage the connection.</para><para>The most common type of Bluetooth socket is RFCOMM, which is the type supported by the Android APIs. RFCOMM is a connection-oriented, streaming transport over Bluetooth. It is also known as the Serial Port Profile (SPP).</para><para>To create a listening BluetoothServerSocket that's ready for incoming connections, use BluetoothAdapter.listenUsingRfcommWithServiceRecord(). Then call accept() to listen for incoming connection requests. This call will block until a connection is established, at which point, it will return a BluetoothSocket to manage the connection. Once the BluetoothSocket is acquired, it's a good idea to call close() on the BluetoothServerSocket when it's no longer needed for accepting connections. Closing the BluetoothServerSocket will <b>not</b> close the returned BluetoothSocket.</para><para>BluetoothServerSocket is thread safe. In particular, close will always immediately abort ongoing operations and close the server socket.</para><para><b>Note:</b> Requires the android.Manifest.permission#BLUETOOTH permission.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using Bluetooth, read the  developer guide.</para><para> </para><para>{<para>BluetoothSocket} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothServerSocket
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothServerSocket", AccessFlags = 49)]
		public sealed partial class BluetoothServerSocket : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothServerSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Block until a connection is established. </para><para>Returns a connected BluetoothSocket on successful connection. </para><para>Once this call returns, it can be called again to accept subsequent incoming connections. </para><para>close can be used to abort this call from another thread. </para>        
				/// </summary>
				/// <returns>
				/// <para>a connected BluetoothSocket </para>
				/// </returns>
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "()Landroid/bluetooth/BluetoothSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothSocket Accept() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothSocket);
				}

				/// <summary>
				/// <para>Block until a connection is established, with timeout. </para><para>Returns a connected BluetoothSocket on successful connection. </para><para>Once this call returns, it can be called again to accept subsequent incoming connections. </para><para>close can be used to abort this call from another thread. </para>        
				/// </summary>
				/// <returns>
				/// <para>a connected BluetoothSocket </para>
				/// </returns>
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "(I)Landroid/bluetooth/BluetoothSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothSocket Accept(int timeout) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothSocket);
				}

				/// <summary>
				/// <para>Immediately close this socket, and release all associated resources. </para><para>Causes blocked calls on this socket in other threads to immediately throw an IOException. </para><para>Closing the BluetoothServerSocket will <b>not</b> close any BluetoothSocket received from accept(). </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Represents the local device Bluetooth adapter. The BluetoothAdapter lets you perform fundamental Bluetooth tasks, such as initiate device discovery, query a list of bonded (paired) devices, instantiate a BluetoothDevice using a known MAC address, and create a BluetoothServerSocket to listen for connection requests from other devices, and start a scan for Bluetooth LE devices.</para><para>To get a BluetoothAdapter representing the local Bluetooth adapter, when running on JELLY_BEAN_MR1 and below, call the static getDefaultAdapter method; when running on JELLY_BEAN_MR2 and higher, retrieve it through android.content.Context#getSystemService with android.content.Context#BLUETOOTH_SERVICE. Fundamentally, this is your starting point for all Bluetooth actions. Once you have the local adapter, you can get a set of BluetoothDevice objects representing all paired devices with getBondedDevices(); start device discovery with startDiscovery(); or create a BluetoothServerSocket to listen for incoming connection requests with listenUsingRfcommWithServiceRecord(String,UUID); or start a scan for Bluetooth LE devices with startLeScan(LeScanCallback callback).</para><para><b>Note:</b> Most methods require the android.Manifest.permission#BLUETOOTH permission and some also require the android.Manifest.permission#BLUETOOTH_ADMIN permission.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using Bluetooth, read the  developer guide.</para><para> </para><para>{<para>BluetoothDevice} {</para><simplesectsep></simplesectsep><para>BluetoothServerSocket} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothAdapter
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothAdapter", AccessFlags = 49)]
		public sealed partial class BluetoothAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Sentinel error value for this class. Guaranteed to not equal any other integer constant in this class. Provided as a convenience for functions that require a sentinel error value, for example: </para><para><code>Intent.getIntExtra(BluetoothAdapter.EXTRA_STATE, BluetoothAdapter.ERROR)</code> </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -2147483648;
				/// <summary>
				/// <para>Broadcast Action: The state of the local Bluetooth adapter has been changed. </para><para>For example, Bluetooth has been turned on or off. </para><para>Always contains the extra fields EXTRA_STATE and EXTRA_PREVIOUS_STATE containing the new and old states respectively. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_STATE_CHANGED = "android.bluetooth.adapter.action.STATE_CHANGED";
				/// <summary>
				/// <para>Used as an int extra field in ACTION_STATE_CHANGED intents to request the current power state. Possible values are: STATE_OFF, STATE_TURNING_ON, STATE_ON, STATE_TURNING_OFF, </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STATE = "android.bluetooth.adapter.extra.STATE";
				/// <summary>
				/// <para>Used as an int extra field in ACTION_STATE_CHANGED intents to request the previous power state. Possible values are: STATE_OFF, STATE_TURNING_ON, STATE_ON, STATE_TURNING_OFF, </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PREVIOUS_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_STATE = "android.bluetooth.adapter.extra.PREVIOUS_STATE";
				/// <summary>
				/// <para>Indicates the local Bluetooth adapter is off. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_OFF
				/// </java-name>
				[Dot42.DexImport("STATE_OFF", "I", AccessFlags = 25)]
				public const int STATE_OFF = 10;
				/// <summary>
				/// <para>Indicates the local Bluetooth adapter is turning on. However local clients should wait for STATE_ON before attempting to use the adapter. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_TURNING_ON
				/// </java-name>
				[Dot42.DexImport("STATE_TURNING_ON", "I", AccessFlags = 25)]
				public const int STATE_TURNING_ON = 11;
				/// <summary>
				/// <para>Indicates the local Bluetooth adapter is on, and ready for use. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_ON
				/// </java-name>
				[Dot42.DexImport("STATE_ON", "I", AccessFlags = 25)]
				public const int STATE_ON = 12;
				/// <summary>
				/// <para>Indicates the local Bluetooth adapter is turning off. Local clients should immediately attempt graceful disconnection of any remote links. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_TURNING_OFF
				/// </java-name>
				[Dot42.DexImport("STATE_TURNING_OFF", "I", AccessFlags = 25)]
				public const int STATE_TURNING_OFF = 13;
				/// <summary>
				/// <para>Activity Action: Show a system activity that requests discoverable mode. This activity will also request the user to turn on Bluetooth if it is not currently enabled. </para><para>Discoverable mode is equivalent to SCAN_MODE_CONNECTABLE_DISCOVERABLE. It allows remote devices to see this Bluetooth adapter when they perform a discovery. </para><para>For privacy, Android is not discoverable by default. </para><para>The sender of this Intent can optionally use extra field EXTRA_DISCOVERABLE_DURATION to request the duration of discoverability. Currently the default duration is 120 seconds, and maximum duration is capped at 300 seconds for each request. </para><para>Notification of the result of this activity is posted using the android.app.Activity#onActivityResult callback. The <code>resultCode</code> will be the duration (in seconds) of discoverability or android.app.Activity#RESULT_CANCELED if the user rejected discoverability or an error has occurred. </para><para>Applications can also listen for ACTION_SCAN_MODE_CHANGED for global notification whenever the scan mode changes. For example, an application can be notified when the device has ended discoverability. </para><para>Requires android.Manifest.permission#BLUETOOTH </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_REQUEST_DISCOVERABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_REQUEST_DISCOVERABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_REQUEST_DISCOVERABLE = "android.bluetooth.adapter.action.REQUEST_DISCOVERABLE";
				/// <summary>
				/// <para>Used as an optional int extra field in ACTION_REQUEST_DISCOVERABLE intents to request a specific duration for discoverability in seconds. The current default is 120 seconds, and requests over 300 seconds will be capped. These values could change. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DISCOVERABLE_DURATION
				/// </java-name>
				[Dot42.DexImport("EXTRA_DISCOVERABLE_DURATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DISCOVERABLE_DURATION = "android.bluetooth.adapter.extra.DISCOVERABLE_DURATION";
				/// <summary>
				/// <para>Activity Action: Show a system activity that allows the user to turn on Bluetooth. </para><para>This system activity will return once Bluetooth has completed turning on, or the user has decided not to turn Bluetooth on. </para><para>Notification of the result of this activity is posted using the android.app.Activity#onActivityResult callback. The <code>resultCode</code> will be android.app.Activity#RESULT_OK if Bluetooth has been turned on or android.app.Activity#RESULT_CANCELED if the user has rejected the request or an error has occurred. </para><para>Applications can also listen for ACTION_STATE_CHANGED for global notification whenever Bluetooth is turned on or off. </para><para>Requires android.Manifest.permission#BLUETOOTH </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_REQUEST_ENABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_REQUEST_ENABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_REQUEST_ENABLE = "android.bluetooth.adapter.action.REQUEST_ENABLE";
				/// <summary>
				/// <para>Broadcast Action: Indicates the Bluetooth scan mode of the local Adapter has changed. </para><para>Always contains the extra fields EXTRA_SCAN_MODE and EXTRA_PREVIOUS_SCAN_MODE containing the new and old scan modes respectively. </para><para>Requires android.Manifest.permission#BLUETOOTH </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SCAN_MODE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_SCAN_MODE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCAN_MODE_CHANGED = "android.bluetooth.adapter.action.SCAN_MODE_CHANGED";
				/// <summary>
				/// <para>Used as an int extra field in ACTION_SCAN_MODE_CHANGED intents to request the current scan mode. Possible values are: SCAN_MODE_NONE, SCAN_MODE_CONNECTABLE, SCAN_MODE_CONNECTABLE_DISCOVERABLE, </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SCAN_MODE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCAN_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCAN_MODE = "android.bluetooth.adapter.extra.SCAN_MODE";
				/// <summary>
				/// <para>Used as an int extra field in ACTION_SCAN_MODE_CHANGED intents to request the previous scan mode. Possible values are: SCAN_MODE_NONE, SCAN_MODE_CONNECTABLE, SCAN_MODE_CONNECTABLE_DISCOVERABLE, </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PREVIOUS_SCAN_MODE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_SCAN_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_SCAN_MODE = "android.bluetooth.adapter.extra.PREVIOUS_SCAN_MODE";
				/// <summary>
				/// <para>Indicates that both inquiry scan and page scan are disabled on the local Bluetooth adapter. Therefore this device is neither discoverable nor connectable from remote Bluetooth devices. </para>        
				/// </summary>
				/// <java-name>
				/// SCAN_MODE_NONE
				/// </java-name>
				[Dot42.DexImport("SCAN_MODE_NONE", "I", AccessFlags = 25)]
				public const int SCAN_MODE_NONE = 20;
				/// <summary>
				/// <para>Indicates that inquiry scan is disabled, but page scan is enabled on the local Bluetooth adapter. Therefore this device is not discoverable from remote Bluetooth devices, but is connectable from remote devices that have previously discovered this device. </para>        
				/// </summary>
				/// <java-name>
				/// SCAN_MODE_CONNECTABLE
				/// </java-name>
				[Dot42.DexImport("SCAN_MODE_CONNECTABLE", "I", AccessFlags = 25)]
				public const int SCAN_MODE_CONNECTABLE = 21;
				/// <summary>
				/// <para>Indicates that both inquiry scan and page scan are enabled on the local Bluetooth adapter. Therefore this device is both discoverable and connectable from remote Bluetooth devices. </para>        
				/// </summary>
				/// <java-name>
				/// SCAN_MODE_CONNECTABLE_DISCOVERABLE
				/// </java-name>
				[Dot42.DexImport("SCAN_MODE_CONNECTABLE_DISCOVERABLE", "I", AccessFlags = 25)]
				public const int SCAN_MODE_CONNECTABLE_DISCOVERABLE = 23;
				/// <summary>
				/// <para>Broadcast Action: The local Bluetooth adapter has started the remote device discovery process. </para><para>This usually involves an inquiry scan of about 12 seconds, followed by a page scan of each new device to retrieve its Bluetooth name. </para><para>Register for BluetoothDevice#ACTION_FOUND to be notified as remote Bluetooth devices are found. </para><para>Device discovery is a heavyweight procedure. New connections to remote Bluetooth devices should not be attempted while discovery is in progress, and existing connections will experience limited bandwidth and high latency. Use cancelDiscovery() to cancel an ongoing discovery. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DISCOVERY_STARTED
				/// </java-name>
				[Dot42.DexImport("ACTION_DISCOVERY_STARTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DISCOVERY_STARTED = "android.bluetooth.adapter.action.DISCOVERY_STARTED";
				/// <summary>
				/// <para>Broadcast Action: The local Bluetooth adapter has finished the device discovery process. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DISCOVERY_FINISHED
				/// </java-name>
				[Dot42.DexImport("ACTION_DISCOVERY_FINISHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DISCOVERY_FINISHED = "android.bluetooth.adapter.action.DISCOVERY_FINISHED";
				/// <summary>
				/// <para>Broadcast Action: The local Bluetooth adapter has changed its friendly Bluetooth name. </para><para>This name is visible to remote Bluetooth devices. </para><para>Always contains the extra field EXTRA_LOCAL_NAME containing the name. </para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_LOCAL_NAME_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_LOCAL_NAME_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LOCAL_NAME_CHANGED = "android.bluetooth.adapter.action.LOCAL_NAME_CHANGED";
				/// <summary>
				/// <para>Used as a String extra field in ACTION_LOCAL_NAME_CHANGED intents to request the local Bluetooth name. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LOCAL_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_LOCAL_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LOCAL_NAME = "android.bluetooth.adapter.extra.LOCAL_NAME";
				/// <summary>
				/// <para>Intent used to broadcast the change in connection state of the local Bluetooth adapter to a profile of the remote device. When the adapter is not connected to any profiles of any remote devices and it attempts a connection to a profile this intent will sent. Once connected, this intent will not be sent for any more connection attempts to any profiles of any remote device. When the adapter disconnects from the last profile its connected to of any remote device, this intent will be sent.</para><para>This intent is useful for applications that are only concerned about whether the local adapter is connected to any profile of any device and are not really concerned about which profile. For example, an application which displays an icon to display whether Bluetooth is connected or not can use this intent.</para><para>This intent will have 3 extras: EXTRA_CONNECTION_STATE - The current connection state. EXTRA_PREVIOUS_CONNECTION_STATE- The previous connection state. BluetoothDevice#EXTRA_DEVICE - The remote device.</para><para>EXTRA_CONNECTION_STATE or EXTRA_PREVIOUS_CONNECTION_STATE can be any of STATE_DISCONNECTED, STATE_CONNECTING, STATE_CONNECTED, STATE_DISCONNECTING.</para><para>Requires android.Manifest.permission#BLUETOOTH to receive. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CONNECTION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CONNECTION_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CONNECTION_STATE_CHANGED = "android.bluetooth.adapter.action.CONNECTION_STATE_CHANGED";
				/// <summary>
				/// <para>Extra used by ACTION_CONNECTION_STATE_CHANGED</para><para>This extra represents the current connection state. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CONNECTION_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CONNECTION_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CONNECTION_STATE = "android.bluetooth.adapter.extra.CONNECTION_STATE";
				/// <summary>
				/// <para>Extra used by ACTION_CONNECTION_STATE_CHANGED</para><para>This extra represents the previous connection state. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PREVIOUS_CONNECTION_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_CONNECTION_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_CONNECTION_STATE = "android.bluetooth.adapter.extra.PREVIOUS_CONNECTION_STATE";
				/// <summary>
				/// <para>The profile is in disconnected state </para>        
				/// </summary>
				/// <java-name>
				/// STATE_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_DISCONNECTED", "I", AccessFlags = 25)]
				public const int STATE_DISCONNECTED = 0;
				/// <summary>
				/// <para>The profile is in connecting state </para>        
				/// </summary>
				/// <java-name>
				/// STATE_CONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_CONNECTING", "I", AccessFlags = 25)]
				public const int STATE_CONNECTING = 1;
				/// <summary>
				/// <para>The profile is in connected state </para>        
				/// </summary>
				/// <java-name>
				/// STATE_CONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_CONNECTED", "I", AccessFlags = 25)]
				public const int STATE_CONNECTED = 2;
				/// <summary>
				/// <para>The profile is in disconnecting state </para>        
				/// </summary>
				/// <java-name>
				/// STATE_DISCONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_DISCONNECTING", "I", AccessFlags = 25)]
				public const int STATE_DISCONNECTING = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a handle to the default local Bluetooth adapter. </para><para>Currently Android only supports one Bluetooth adapter, but the API could be extended to support more. This will always return the default adapter. </para>        
				/// </summary>
				/// <returns>
				/// <para>the default local adapter, or null if Bluetooth is not supported on this hardware platform </para>
				/// </returns>
				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				[Dot42.DexImport("getDefaultAdapter", "()Landroid/bluetooth/BluetoothAdapter;", AccessFlags = 41)]
				public static global::Android.Bluetooth.BluetoothAdapter GetDefaultAdapter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothAdapter);
				}

				/// <java-name>
				/// getRemoteDevice
				/// </java-name>
				[Dot42.DexImport("getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothDevice GetRemoteDevice(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothDevice);
				}

				/// <summary>
				/// <para>Return true if Bluetooth is currently enabled and ready for use. </para><para>Equivalent to: <code>getBluetoothState() == STATE_ON</code> </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the local adapter is turned on </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Get the current state of the local Bluetooth adapter. </para><para>Possible return values are STATE_OFF, STATE_TURNING_ON, STATE_ON, STATE_TURNING_OFF. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>current state of Bluetooth adapter </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
				public int GetState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Turn on the local Bluetooth adapterdo not use without explicit user action to turn on Bluetooth. </para><para>This powers on the underlying Bluetooth hardware, and starts all Bluetooth system services. </para><para><b>Bluetooth should never be enabled without direct user consent</b>. If you want to turn on Bluetooth in order to create a wireless connection, you should use the ACTION_REQUEST_ENABLE Intent, which will raise a dialog that requests user permission to turn on Bluetooth. The enable() method is provided only for applications that include a user interface for changing system settings, such as a "power manager" app.</para><para>This is an asynchronous call: it will return immediately, and clients should listen for ACTION_STATE_CHANGED to be notified of subsequent adapter state changes. If this call returns true, then the adapter state will immediately transition from STATE_OFF to STATE_TURNING_ON, and some time later transition to either STATE_OFF or STATE_ON. If this call returns false then there was an immediate problem that will prevent the adapter from being turned on - such as Airplane mode, or the adapter is already turned on. </para><para>Requires the android.Manifest.permission#BLUETOOTH_ADMIN permission</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true to indicate adapter startup has begun, or false on immediate error </para>
				/// </returns>
				/// <java-name>
				/// enable
				/// </java-name>
				[Dot42.DexImport("enable", "()Z", AccessFlags = 1)]
				public bool Enable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Turn off the local Bluetooth adapterdo not use without explicit user action to turn off Bluetooth. </para><para>This gracefully shuts down all Bluetooth connections, stops Bluetooth system services, and powers down the underlying Bluetooth hardware. </para><para><b>Bluetooth should never be disabled without direct user consent</b>. The disable() method is provided only for applications that include a user interface for changing system settings, such as a "power manager" app.</para><para>This is an asynchronous call: it will return immediately, and clients should listen for ACTION_STATE_CHANGED to be notified of subsequent adapter state changes. If this call returns true, then the adapter state will immediately transition from STATE_ON to STATE_TURNING_OFF, and some time later transition to either STATE_OFF or STATE_ON. If this call returns false then there was an immediate problem that will prevent the adapter from being turned off - such as the adapter already being turned off. </para><para>Requires the android.Manifest.permission#BLUETOOTH_ADMIN permission</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true to indicate adapter shutdown has begun, or false on immediate error </para>
				/// </returns>
				/// <java-name>
				/// disable
				/// </java-name>
				[Dot42.DexImport("disable", "()Z", AccessFlags = 1)]
				public bool Disable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hardware address of the local Bluetooth adapter. </para><para>For example, "00:11:22:AA:BB:CC". </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Bluetooth hardware address as string </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the friendly Bluetooth name of the local Bluetooth adapter. </para><para>This name is visible to remote Bluetooth devices. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Bluetooth name, or null on error </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Set the friendly Bluetooth name of the local Bluetooth adapter. </para><para>This name is visible to remote Bluetooth devices. </para><para>Valid Bluetooth names are a maximum of 248 bytes using UTF-8 encoding, although many remote devices can only display the first 40 characters, and some may be limited to just 20. </para><para>If Bluetooth state is not STATE_ON, this API will return false. After turning on Bluetooth, wait for ACTION_STATE_CHANGED with STATE_ON to get the updated value. </para><para>Requires android.Manifest.permission#BLUETOOTH_ADMIN</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the name was set, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool SetName(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Get the current Bluetooth scan mode of the local Bluetooth adapter. </para><para>The Bluetooth scan mode determines if the local adapter is connectable and/or discoverable from remote Bluetooth devices. </para><para>Possible values are: SCAN_MODE_NONE, SCAN_MODE_CONNECTABLE, SCAN_MODE_CONNECTABLE_DISCOVERABLE. </para><para>If Bluetooth state is not STATE_ON, this API will return SCAN_MODE_NONE. After turning on Bluetooth, wait for ACTION_STATE_CHANGED with STATE_ON to get the updated value. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>scan mode </para>
				/// </returns>
				/// <java-name>
				/// getScanMode
				/// </java-name>
				[Dot42.DexImport("getScanMode", "()I", AccessFlags = 1)]
				public int GetScanMode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Start the remote device discovery process. </para><para>The discovery process usually involves an inquiry scan of about 12 seconds, followed by a page scan of each new device to retrieve its Bluetooth name. </para><para>This is an asynchronous call, it will return immediately. Register for ACTION_DISCOVERY_STARTED and ACTION_DISCOVERY_FINISHED intents to determine exactly when the discovery starts and completes. Register for BluetoothDevice#ACTION_FOUND to be notified as remote Bluetooth devices are found. </para><para>Device discovery is a heavyweight procedure. New connections to remote Bluetooth devices should not be attempted while discovery is in progress, and existing connections will experience limited bandwidth and high latency. Use cancelDiscovery() to cancel an ongoing discovery. Discovery is not managed by the Activity, but is run as a system service, so an application should always call BluetoothAdapter#cancelDiscovery() even if it did not directly request a discovery, just to be sure. </para><para>Device discovery will only find remote devices that are currently <b>discoverable</b> (inquiry scan enabled). Many Bluetooth devices are not discoverable by default, and need to be entered into a special mode. </para><para>If Bluetooth state is not STATE_ON, this API will return false. After turning on Bluetooth, wait for ACTION_STATE_CHANGED with STATE_ON to get the updated value. </para><para>Requires android.Manifest.permission#BLUETOOTH_ADMIN.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false on error </para>
				/// </returns>
				/// <java-name>
				/// startDiscovery
				/// </java-name>
				[Dot42.DexImport("startDiscovery", "()Z", AccessFlags = 1)]
				public bool StartDiscovery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Cancel the current device discovery process. </para><para>Requires android.Manifest.permission#BLUETOOTH_ADMIN. </para><para>Because discovery is a heavyweight procedure for the Bluetooth adapter, this method should always be called before attempting to connect to a remote device with android.bluetooth.BluetoothSocket#connect(). Discovery is not managed by the Activity, but is run as a system service, so an application should always call cancel discovery even if it did not directly request a discovery, just to be sure. </para><para>If Bluetooth state is not STATE_ON, this API will return false. After turning on Bluetooth, wait for ACTION_STATE_CHANGED with STATE_ON to get the updated value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false on error </para>
				/// </returns>
				/// <java-name>
				/// cancelDiscovery
				/// </java-name>
				[Dot42.DexImport("cancelDiscovery", "()Z", AccessFlags = 1)]
				public bool CancelDiscovery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return true if the local Bluetooth adapter is currently in the device discovery process. </para><para>Device discovery is a heavyweight procedure. New connections to remote Bluetooth devices should not be attempted while discovery is in progress, and existing connections will experience limited bandwidth and high latency. Use cancelDiscovery() to cancel an ongoing discovery. </para><para>Applications can also register for ACTION_DISCOVERY_STARTED or ACTION_DISCOVERY_FINISHED to be notified when discovery starts or completes. </para><para>If Bluetooth state is not STATE_ON, this API will return false. After turning on Bluetooth, wait for ACTION_STATE_CHANGED with STATE_ON to get the updated value. </para><para>Requires android.Manifest.permission#BLUETOOTH.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if discovering </para>
				/// </returns>
				/// <java-name>
				/// isDiscovering
				/// </java-name>
				[Dot42.DexImport("isDiscovering", "()Z", AccessFlags = 1)]
				public bool IsDiscovering() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the set of BluetoothDevice objects that are bonded (paired) to the local adapter. </para><para>If Bluetooth state is not STATE_ON, this API will return an empty set. After turning on Bluetooth, wait for ACTION_STATE_CHANGED with STATE_ON to get the updated value. </para><para>Requires android.Manifest.permission#BLUETOOTH.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>unmodifiable set of BluetoothDevice, or null on error </para>
				/// </returns>
				/// <java-name>
				/// getBondedDevices
				/// </java-name>
				[Dot42.DexImport("getBondedDevices", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Landroid/bluetooth/BluetoothDevice;>;")]
				public global::Java.Util.ISet<global::Android.Bluetooth.BluetoothDevice> GetBondedDevices() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Android.Bluetooth.BluetoothDevice>);
				}

				/// <summary>
				/// <para>Create a listening, secure RFCOMM Bluetooth socket with Service Record. </para><para>A remote device connecting to this socket will be authenticated and communication on this socket will be encrypted. </para><para>Use BluetoothServerSocket#accept to retrieve incoming connections from a listening BluetoothServerSocket. </para><para>The system will assign an unused RFCOMM channel to listen on. </para><para>The system will also register a Service Discovery Protocol (SDP) record with the local SDP server containing the specified UUID, service name, and auto-assigned channel. Remote Bluetooth devices can use the same UUID to query our SDP server and discover which channel to connect to. This SDP record will be removed when this socket is closed, or if this application closes unexpectedly. </para><para>Use BluetoothDevice#createRfcommSocketToServiceRecord to connect to this socket from another device using the same UUID. </para><para>Requires android.Manifest.permission#BLUETOOTH </para>        
				/// </summary>
				/// <returns>
				/// <para>a listening RFCOMM BluetoothServerSocket </para>
				/// </returns>
				/// <java-name>
				/// listenUsingRfcommWithServiceRecord
				/// </java-name>
				[Dot42.DexImport("listenUsingRfcommWithServiceRecord", "(Ljava/lang/String;Ljava/util/UUID;)Landroid/bluetooth/BluetoothServerSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothServerSocket ListenUsingRfcommWithServiceRecord(string name, global::Java.Util.UUID uuid) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothServerSocket);
				}

				/// <summary>
				/// <para>Create a listening, insecure RFCOMM Bluetooth socket with Service Record. </para><para>The link key is not required to be authenticated, i.e the communication may be vulnerable to Man In the Middle attacks. For Bluetooth 2.1 devices, the link will be encrypted, as encryption is mandartory. For legacy devices (pre Bluetooth 2.1 devices) the link will not be encrypted. Use listenUsingRfcommWithServiceRecord, if an encrypted and authenticated communication channel is desired. </para><para>Use BluetoothServerSocket#accept to retrieve incoming connections from a listening BluetoothServerSocket. </para><para>The system will assign an unused RFCOMM channel to listen on. </para><para>The system will also register a Service Discovery Protocol (SDP) record with the local SDP server containing the specified UUID, service name, and auto-assigned channel. Remote Bluetooth devices can use the same UUID to query our SDP server and discover which channel to connect to. This SDP record will be removed when this socket is closed, or if this application closes unexpectedly. </para><para>Use BluetoothDevice#createRfcommSocketToServiceRecord to connect to this socket from another device using the same UUID. </para><para>Requires android.Manifest.permission#BLUETOOTH </para>        
				/// </summary>
				/// <returns>
				/// <para>a listening RFCOMM BluetoothServerSocket </para>
				/// </returns>
				/// <java-name>
				/// listenUsingInsecureRfcommWithServiceRecord
				/// </java-name>
				[Dot42.DexImport("listenUsingInsecureRfcommWithServiceRecord", "(Ljava/lang/String;Ljava/util/UUID;)Landroid/bluetooth/BluetoothServerSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothServerSocket ListenUsingInsecureRfcommWithServiceRecord(string name, global::Java.Util.UUID uuid) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothServerSocket);
				}

				/// <summary>
				/// <para>Get the profile proxy object associated with the profile.</para><para>Profile can be one of BluetoothProfile#HEALTH, BluetoothProfile#HEADSET, BluetoothProfile#A2DP, BluetoothProfile#GATT, or BluetoothProfile#GATT_SERVER. Clients must implement BluetoothProfile.ServiceListener to get notified of the connection status and to get the proxy object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false on error </para>
				/// </returns>
				/// <java-name>
				/// getProfileProxy
				/// </java-name>
				[Dot42.DexImport("getProfileProxy", "(Landroid/content/Context;Landroid/bluetooth/BluetoothProfile$ServiceListener;I)Z" +
    "", AccessFlags = 1)]
				public bool GetProfileProxy(global::Android.Content.Context context, global::Android.Bluetooth.IBluetoothProfile_IServiceListener listener, int profile) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Close the connection of the profile proxy to the Service.</para><para>Clients should call this when they are no longer using the proxy obtained from getProfileProxy. Profile can be one of BluetoothProfile#HEALTH, BluetoothProfile#HEADSET or BluetoothProfile#A2DP</para><para></para>        
				/// </summary>
				/// <java-name>
				/// closeProfileProxy
				/// </java-name>
				[Dot42.DexImport("closeProfileProxy", "(ILandroid/bluetooth/BluetoothProfile;)V", AccessFlags = 1)]
				public void CloseProfileProxy(int profile, global::Android.Bluetooth.IBluetoothProfile proxy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Validate a String Bluetooth address, such as "00:43:A8:23:10:F0" </para><para>Alphabetic characters must be uppercase to be valid.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the address is valid, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// checkBluetoothAddress
				/// </java-name>
				[Dot42.DexImport("checkBluetoothAddress", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool CheckBluetoothAddress(string address) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Get a handle to the default local Bluetooth adapter. </para><para>Currently Android only supports one Bluetooth adapter, but the API could be extended to support more. This will always return the default adapter. </para>        
				/// </summary>
				/// <returns>
				/// <para>the default local adapter, or null if Bluetooth is not supported on this hardware platform </para>
				/// </returns>
				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				public static global::Android.Bluetooth.BluetoothAdapter DefaultAdapter
				{
				[Dot42.DexImport("getDefaultAdapter", "()Landroid/bluetooth/BluetoothAdapter;", AccessFlags = 41)]
						get{ return GetDefaultAdapter(); }
				}

				/// <summary>
				/// <para>Get the current state of the local Bluetooth adapter. </para><para>Possible return values are STATE_OFF, STATE_TURNING_ON, STATE_ON, STATE_TURNING_OFF. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>current state of Bluetooth adapter </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				public int State
				{
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return GetState(); }
				}

				/// <summary>
				/// <para>Returns the hardware address of the local Bluetooth adapter. </para><para>For example, "00:11:22:AA:BB:CC". </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Bluetooth hardware address as string </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				public string Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAddress(); }
				}

				/// <summary>
				/// <para>Get the friendly Bluetooth name of the local Bluetooth adapter. </para><para>This name is visible to remote Bluetooth devices. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Bluetooth name, or null on error </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Get the current Bluetooth scan mode of the local Bluetooth adapter. </para><para>The Bluetooth scan mode determines if the local adapter is connectable and/or discoverable from remote Bluetooth devices. </para><para>Possible values are: SCAN_MODE_NONE, SCAN_MODE_CONNECTABLE, SCAN_MODE_CONNECTABLE_DISCOVERABLE. </para><para>If Bluetooth state is not STATE_ON, this API will return SCAN_MODE_NONE. After turning on Bluetooth, wait for ACTION_STATE_CHANGED with STATE_ON to get the updated value. </para><para>Requires android.Manifest.permission#BLUETOOTH</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>scan mode </para>
				/// </returns>
				/// <java-name>
				/// getScanMode
				/// </java-name>
				public int ScanMode
				{
				[Dot42.DexImport("getScanMode", "()I", AccessFlags = 1)]
						get{ return GetScanMode(); }
				}

				/// <summary>
				/// <para>Return the set of BluetoothDevice objects that are bonded (paired) to the local adapter. </para><para>If Bluetooth state is not STATE_ON, this API will return an empty set. After turning on Bluetooth, wait for ACTION_STATE_CHANGED with STATE_ON to get the updated value. </para><para>Requires android.Manifest.permission#BLUETOOTH.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>unmodifiable set of BluetoothDevice, or null on error </para>
				/// </returns>
				/// <java-name>
				/// getBondedDevices
				/// </java-name>
				public global::Java.Util.ISet<global::Android.Bluetooth.BluetoothDevice> BondedDevices
				{
				[Dot42.DexImport("getBondedDevices", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Landroid/bluetooth/BluetoothDevice;>;")]
						get{ return GetBondedDevices(); }
				}

		}

		/// <summary>
		/// <para>Public APIs for the Bluetooth Profiles.</para><para>Clients should call BluetoothAdapter#getProfileProxy, to get the Profile Proxy. Each public profile implements this interface. </para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothProfile
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothProfile", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IBluetoothProfileConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Extra for the connection state intents of the individual profiles.</para><para>This extra represents the current connection state of the profile of the Bluetooth device. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STATE = "android.bluetooth.profile.extra.STATE";
				/// <summary>
				/// <para>Extra for the connection state intents of the individual profiles.</para><para>This extra represents the previous connection state of the profile of the Bluetooth device. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PREVIOUS_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_STATE = "android.bluetooth.profile.extra.PREVIOUS_STATE";
				/// <summary>
				/// <para>The profile is in disconnected state </para>        
				/// </summary>
				/// <java-name>
				/// STATE_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_DISCONNECTED", "I", AccessFlags = 25)]
				public const int STATE_DISCONNECTED = 0;
				/// <summary>
				/// <para>The profile is in connecting state </para>        
				/// </summary>
				/// <java-name>
				/// STATE_CONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_CONNECTING", "I", AccessFlags = 25)]
				public const int STATE_CONNECTING = 1;
				/// <summary>
				/// <para>The profile is in connected state </para>        
				/// </summary>
				/// <java-name>
				/// STATE_CONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_CONNECTED", "I", AccessFlags = 25)]
				public const int STATE_CONNECTED = 2;
				/// <summary>
				/// <para>The profile is in disconnecting state </para>        
				/// </summary>
				/// <java-name>
				/// STATE_DISCONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_DISCONNECTING", "I", AccessFlags = 25)]
				public const int STATE_DISCONNECTING = 3;
				/// <summary>
				/// <para>Headset and Handsfree profile </para>        
				/// </summary>
				/// <java-name>
				/// HEADSET
				/// </java-name>
				[Dot42.DexImport("HEADSET", "I", AccessFlags = 25)]
				public const int HEADSET = 1;
				/// <summary>
				/// <para>A2DP profile. </para>        
				/// </summary>
				/// <java-name>
				/// A2DP
				/// </java-name>
				[Dot42.DexImport("A2DP", "I", AccessFlags = 25)]
				public const int A2DP = 2;
		}

		/// <summary>
		/// <para>Public APIs for the Bluetooth Profiles.</para><para>Clients should call BluetoothAdapter#getProfileProxy, to get the Profile Proxy. Each public profile implements this interface. </para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothProfile
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothProfile", AccessFlags = 1537)]
		public partial interface IBluetoothProfile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Get connected devices for this specific profile.</para><para>Return the set of devices which are in state STATE_CONNECTED</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>List of devices. The list will be empty on error. </para>
				/// </returns>
				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetConnectedDevices() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get a list of devices that match any of the given connection states.</para><para>If none of the devices match any of the given states, an empty list will be returned.</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>List of devices. The list will be empty on error. </para>
				/// </returns>
				/// <java-name>
				/// getDevicesMatchingConnectionStates
				/// </java-name>
				[Dot42.DexImport("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", AccessFlags = 1025, Signature = "([I)Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] states) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the current connection state of the profile</para><para>Requires android.Manifest.permission#BLUETOOTH permission.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>State of the profile connection. One of STATE_CONNECTED, STATE_CONNECTING, STATE_DISCONNECTED, STATE_DISCONNECTING </para>
				/// </returns>
				/// <java-name>
				/// getConnectionState
				/// </java-name>
				[Dot42.DexImport("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", AccessFlags = 1025)]
				int GetConnectionState(global::Android.Bluetooth.BluetoothDevice device) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An interface for notifying BluetoothProfile IPC clients when they have been connected or disconnected to the service. </para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothProfile$ServiceListener
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothProfile$ServiceListener", AccessFlags = 1545)]
		public partial interface IBluetoothProfile_IServiceListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called to notify the client when the proxy object has been connected to the service. </para>        
				/// </summary>
				/// <java-name>
				/// onServiceConnected
				/// </java-name>
				[Dot42.DexImport("onServiceConnected", "(ILandroid/bluetooth/BluetoothProfile;)V", AccessFlags = 1025)]
				void OnServiceConnected(int profile, global::Android.Bluetooth.IBluetoothProfile proxy) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called to notify the client that this proxy object has been disconnected from the service. </para>        
				/// </summary>
				/// <java-name>
				/// onServiceDisconnected
				/// </java-name>
				[Dot42.DexImport("onServiceDisconnected", "(I)V", AccessFlags = 1025)]
				void OnServiceDisconnected(int profile) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Represents a Bluetooth class, which describes general characteristics and capabilities of a device. For example, a Bluetooth class will specify the general device type such as a phone, a computer, or headset, and whether it's capable of services such as audio or telephony.</para><para>Every Bluetooth class is composed of zero or more service classes, and exactly one device class. The device class is further broken down into major and minor device class components.</para><para>BluetoothClass is useful as a hint to roughly describe a device (for example to show an icon in the UI), but does not reliably describe which Bluetooth profiles or services are actually supported by a device. Accurate service discovery is done through SDP requests, which are automatically performed when creating an RFCOMM socket with BluetoothDevice#createRfcommSocketToServiceRecord and BluetoothAdapter#listenUsingRfcommWithServiceRecord</para><para>Use BluetoothDevice#getBluetoothClass to retrieve the class for a remote device. </para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothClass
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothClass", AccessFlags = 49)]
		public sealed partial class BluetoothClass : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Bluetooth.BluetoothClass> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothClass() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Flatten this object in to a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return true if the specified service class is supported by this BluetoothClass. </para><para>Valid service classes are the public constants in BluetoothClass.Service. For example, BluetoothClass.Service#AUDIO.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the service class is supported </para>
				/// </returns>
				/// <java-name>
				/// hasService
				/// </java-name>
				[Dot42.DexImport("hasService", "(I)Z", AccessFlags = 1)]
				public bool HasService(int service) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the major device class component of this BluetoothClass. </para><para>Values returned from this function can be compared with the public constants in BluetoothClass.Device.Major to determine which major class is encoded in this Bluetooth class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>major device class component </para>
				/// </returns>
				/// <java-name>
				/// getMajorDeviceClass
				/// </java-name>
				[Dot42.DexImport("getMajorDeviceClass", "()I", AccessFlags = 1)]
				public int GetMajorDeviceClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the (major and minor) device class component of this BluetoothClass. </para><para>Values returned from this function can be compared with the public constants in BluetoothClass.Device to determine which device class is encoded in this Bluetooth class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>device class component </para>
				/// </returns>
				/// <java-name>
				/// getDeviceClass
				/// </java-name>
				[Dot42.DexImport("getDeviceClass", "()I", AccessFlags = 1)]
				public int GetDeviceClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the major device class component of this BluetoothClass. </para><para>Values returned from this function can be compared with the public constants in BluetoothClass.Device.Major to determine which major class is encoded in this Bluetooth class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>major device class component </para>
				/// </returns>
				/// <java-name>
				/// getMajorDeviceClass
				/// </java-name>
				public int MajorDeviceClass
				{
				[Dot42.DexImport("getMajorDeviceClass", "()I", AccessFlags = 1)]
						get{ return GetMajorDeviceClass(); }
				}

				/// <summary>
				/// <para>Return the (major and minor) device class component of this BluetoothClass. </para><para>Values returned from this function can be compared with the public constants in BluetoothClass.Device to determine which device class is encoded in this Bluetooth class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>device class component </para>
				/// </returns>
				/// <java-name>
				/// getDeviceClass
				/// </java-name>
				public int DeviceClass
				{
				[Dot42.DexImport("getDeviceClass", "()I", AccessFlags = 1)]
						get{ return GetDeviceClass(); }
				}

				/// <summary>
				/// <para>Defines all device class constants. </para><para>Each BluetoothClass encodes exactly one device class, with major and minor components. </para><para>The constants in BluetoothClass.Device represent a combination of major and minor device components (the complete device class). The constants in BluetoothClass.Device.Major represent only major device classes. </para><para>See BluetoothClass.Service for service class constants. </para>    
				/// </summary>
				/// <java-name>
				/// android/bluetooth/BluetoothClass$Device
				/// </java-name>
				[Dot42.DexImport("android/bluetooth/BluetoothClass$Device", AccessFlags = 9)]
				public partial class Device
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// COMPUTER_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("COMPUTER_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int COMPUTER_UNCATEGORIZED = 256;
						/// <java-name>
						/// COMPUTER_DESKTOP
						/// </java-name>
						[Dot42.DexImport("COMPUTER_DESKTOP", "I", AccessFlags = 25)]
						public const int COMPUTER_DESKTOP = 260;
						/// <java-name>
						/// COMPUTER_SERVER
						/// </java-name>
						[Dot42.DexImport("COMPUTER_SERVER", "I", AccessFlags = 25)]
						public const int COMPUTER_SERVER = 264;
						/// <java-name>
						/// COMPUTER_LAPTOP
						/// </java-name>
						[Dot42.DexImport("COMPUTER_LAPTOP", "I", AccessFlags = 25)]
						public const int COMPUTER_LAPTOP = 268;
						/// <java-name>
						/// COMPUTER_HANDHELD_PC_PDA
						/// </java-name>
						[Dot42.DexImport("COMPUTER_HANDHELD_PC_PDA", "I", AccessFlags = 25)]
						public const int COMPUTER_HANDHELD_PC_PDA = 272;
						/// <java-name>
						/// COMPUTER_PALM_SIZE_PC_PDA
						/// </java-name>
						[Dot42.DexImport("COMPUTER_PALM_SIZE_PC_PDA", "I", AccessFlags = 25)]
						public const int COMPUTER_PALM_SIZE_PC_PDA = 276;
						/// <java-name>
						/// COMPUTER_WEARABLE
						/// </java-name>
						[Dot42.DexImport("COMPUTER_WEARABLE", "I", AccessFlags = 25)]
						public const int COMPUTER_WEARABLE = 280;
						/// <java-name>
						/// PHONE_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("PHONE_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int PHONE_UNCATEGORIZED = 512;
						/// <java-name>
						/// PHONE_CELLULAR
						/// </java-name>
						[Dot42.DexImport("PHONE_CELLULAR", "I", AccessFlags = 25)]
						public const int PHONE_CELLULAR = 516;
						/// <java-name>
						/// PHONE_CORDLESS
						/// </java-name>
						[Dot42.DexImport("PHONE_CORDLESS", "I", AccessFlags = 25)]
						public const int PHONE_CORDLESS = 520;
						/// <java-name>
						/// PHONE_SMART
						/// </java-name>
						[Dot42.DexImport("PHONE_SMART", "I", AccessFlags = 25)]
						public const int PHONE_SMART = 524;
						/// <java-name>
						/// PHONE_MODEM_OR_GATEWAY
						/// </java-name>
						[Dot42.DexImport("PHONE_MODEM_OR_GATEWAY", "I", AccessFlags = 25)]
						public const int PHONE_MODEM_OR_GATEWAY = 528;
						/// <java-name>
						/// PHONE_ISDN
						/// </java-name>
						[Dot42.DexImport("PHONE_ISDN", "I", AccessFlags = 25)]
						public const int PHONE_ISDN = 532;
						/// <java-name>
						/// AUDIO_VIDEO_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_UNCATEGORIZED = 1024;
						/// <java-name>
						/// AUDIO_VIDEO_WEARABLE_HEADSET
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_WEARABLE_HEADSET", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_WEARABLE_HEADSET = 1028;
						/// <java-name>
						/// AUDIO_VIDEO_HANDSFREE
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_HANDSFREE", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_HANDSFREE = 1032;
						/// <java-name>
						/// AUDIO_VIDEO_MICROPHONE
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_MICROPHONE", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_MICROPHONE = 1040;
						/// <java-name>
						/// AUDIO_VIDEO_LOUDSPEAKER
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_LOUDSPEAKER", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_LOUDSPEAKER = 1044;
						/// <java-name>
						/// AUDIO_VIDEO_HEADPHONES
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_HEADPHONES", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_HEADPHONES = 1048;
						/// <java-name>
						/// AUDIO_VIDEO_PORTABLE_AUDIO
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_PORTABLE_AUDIO", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_PORTABLE_AUDIO = 1052;
						/// <java-name>
						/// AUDIO_VIDEO_CAR_AUDIO
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_CAR_AUDIO", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_CAR_AUDIO = 1056;
						/// <java-name>
						/// AUDIO_VIDEO_SET_TOP_BOX
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_SET_TOP_BOX", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_SET_TOP_BOX = 1060;
						/// <java-name>
						/// AUDIO_VIDEO_HIFI_AUDIO
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_HIFI_AUDIO", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_HIFI_AUDIO = 1064;
						/// <java-name>
						/// AUDIO_VIDEO_VCR
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VCR", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VCR = 1068;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_CAMERA
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_CAMERA", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_CAMERA = 1072;
						/// <java-name>
						/// AUDIO_VIDEO_CAMCORDER
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_CAMCORDER", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_CAMCORDER = 1076;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_MONITOR
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_MONITOR", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_MONITOR = 1080;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_DISPLAY_AND_LOUDSPEAKER
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_DISPLAY_AND_LOUDSPEAKER", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_DISPLAY_AND_LOUDSPEAKER = 1084;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_CONFERENCING
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_CONFERENCING", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_CONFERENCING = 1088;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_GAMING_TOY
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_GAMING_TOY", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_GAMING_TOY = 1096;
						/// <java-name>
						/// WEARABLE_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("WEARABLE_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int WEARABLE_UNCATEGORIZED = 1792;
						/// <java-name>
						/// WEARABLE_WRIST_WATCH
						/// </java-name>
						[Dot42.DexImport("WEARABLE_WRIST_WATCH", "I", AccessFlags = 25)]
						public const int WEARABLE_WRIST_WATCH = 1796;
						/// <java-name>
						/// WEARABLE_PAGER
						/// </java-name>
						[Dot42.DexImport("WEARABLE_PAGER", "I", AccessFlags = 25)]
						public const int WEARABLE_PAGER = 1800;
						/// <java-name>
						/// WEARABLE_JACKET
						/// </java-name>
						[Dot42.DexImport("WEARABLE_JACKET", "I", AccessFlags = 25)]
						public const int WEARABLE_JACKET = 1804;
						/// <java-name>
						/// WEARABLE_HELMET
						/// </java-name>
						[Dot42.DexImport("WEARABLE_HELMET", "I", AccessFlags = 25)]
						public const int WEARABLE_HELMET = 1808;
						/// <java-name>
						/// WEARABLE_GLASSES
						/// </java-name>
						[Dot42.DexImport("WEARABLE_GLASSES", "I", AccessFlags = 25)]
						public const int WEARABLE_GLASSES = 1812;
						/// <java-name>
						/// TOY_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("TOY_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int TOY_UNCATEGORIZED = 2048;
						/// <java-name>
						/// TOY_ROBOT
						/// </java-name>
						[Dot42.DexImport("TOY_ROBOT", "I", AccessFlags = 25)]
						public const int TOY_ROBOT = 2052;
						/// <java-name>
						/// TOY_VEHICLE
						/// </java-name>
						[Dot42.DexImport("TOY_VEHICLE", "I", AccessFlags = 25)]
						public const int TOY_VEHICLE = 2056;
						/// <java-name>
						/// TOY_DOLL_ACTION_FIGURE
						/// </java-name>
						[Dot42.DexImport("TOY_DOLL_ACTION_FIGURE", "I", AccessFlags = 25)]
						public const int TOY_DOLL_ACTION_FIGURE = 2060;
						/// <java-name>
						/// TOY_CONTROLLER
						/// </java-name>
						[Dot42.DexImport("TOY_CONTROLLER", "I", AccessFlags = 25)]
						public const int TOY_CONTROLLER = 2064;
						/// <java-name>
						/// TOY_GAME
						/// </java-name>
						[Dot42.DexImport("TOY_GAME", "I", AccessFlags = 25)]
						public const int TOY_GAME = 2068;
						/// <java-name>
						/// HEALTH_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("HEALTH_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int HEALTH_UNCATEGORIZED = 2304;
						/// <java-name>
						/// HEALTH_BLOOD_PRESSURE
						/// </java-name>
						[Dot42.DexImport("HEALTH_BLOOD_PRESSURE", "I", AccessFlags = 25)]
						public const int HEALTH_BLOOD_PRESSURE = 2308;
						/// <java-name>
						/// HEALTH_THERMOMETER
						/// </java-name>
						[Dot42.DexImport("HEALTH_THERMOMETER", "I", AccessFlags = 25)]
						public const int HEALTH_THERMOMETER = 2312;
						/// <java-name>
						/// HEALTH_WEIGHING
						/// </java-name>
						[Dot42.DexImport("HEALTH_WEIGHING", "I", AccessFlags = 25)]
						public const int HEALTH_WEIGHING = 2316;
						/// <java-name>
						/// HEALTH_GLUCOSE
						/// </java-name>
						[Dot42.DexImport("HEALTH_GLUCOSE", "I", AccessFlags = 25)]
						public const int HEALTH_GLUCOSE = 2320;
						/// <java-name>
						/// HEALTH_PULSE_OXIMETER
						/// </java-name>
						[Dot42.DexImport("HEALTH_PULSE_OXIMETER", "I", AccessFlags = 25)]
						public const int HEALTH_PULSE_OXIMETER = 2324;
						/// <java-name>
						/// HEALTH_PULSE_RATE
						/// </java-name>
						[Dot42.DexImport("HEALTH_PULSE_RATE", "I", AccessFlags = 25)]
						public const int HEALTH_PULSE_RATE = 2328;
						/// <java-name>
						/// HEALTH_DATA_DISPLAY
						/// </java-name>
						[Dot42.DexImport("HEALTH_DATA_DISPLAY", "I", AccessFlags = 25)]
						public const int HEALTH_DATA_DISPLAY = 2332;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Device() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Defines all major device class constants. </para><para>See BluetoothClass.Device for minor classes. </para>    
						/// </summary>
						/// <java-name>
						/// android/bluetooth/BluetoothClass$Device$Major
						/// </java-name>
						[Dot42.DexImport("android/bluetooth/BluetoothClass$Device$Major", AccessFlags = 9)]
						public partial class Major
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// MISC
								/// </java-name>
								[Dot42.DexImport("MISC", "I", AccessFlags = 25)]
								public const int MISC = 0;
								/// <java-name>
								/// COMPUTER
								/// </java-name>
								[Dot42.DexImport("COMPUTER", "I", AccessFlags = 25)]
								public const int COMPUTER = 256;
								/// <java-name>
								/// PHONE
								/// </java-name>
								[Dot42.DexImport("PHONE", "I", AccessFlags = 25)]
								public const int PHONE = 512;
								/// <java-name>
								/// NETWORKING
								/// </java-name>
								[Dot42.DexImport("NETWORKING", "I", AccessFlags = 25)]
								public const int NETWORKING = 768;
								/// <java-name>
								/// AUDIO_VIDEO
								/// </java-name>
								[Dot42.DexImport("AUDIO_VIDEO", "I", AccessFlags = 25)]
								public const int AUDIO_VIDEO = 1024;
								/// <java-name>
								/// PERIPHERAL
								/// </java-name>
								[Dot42.DexImport("PERIPHERAL", "I", AccessFlags = 25)]
								public const int PERIPHERAL = 1280;
								/// <java-name>
								/// IMAGING
								/// </java-name>
								[Dot42.DexImport("IMAGING", "I", AccessFlags = 25)]
								public const int IMAGING = 1536;
								/// <java-name>
								/// WEARABLE
								/// </java-name>
								[Dot42.DexImport("WEARABLE", "I", AccessFlags = 25)]
								public const int WEARABLE = 1792;
								/// <java-name>
								/// TOY
								/// </java-name>
								[Dot42.DexImport("TOY", "I", AccessFlags = 25)]
								public const int TOY = 2048;
								/// <java-name>
								/// HEALTH
								/// </java-name>
								[Dot42.DexImport("HEALTH", "I", AccessFlags = 25)]
								public const int HEALTH = 2304;
								/// <java-name>
								/// UNCATEGORIZED
								/// </java-name>
								[Dot42.DexImport("UNCATEGORIZED", "I", AccessFlags = 25)]
								public const int UNCATEGORIZED = 7936;
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Major() /* MethodBuilder.Create */ 
								{
								}

						}

				}

				/// <summary>
				/// <para>Defines all service class constants. </para><para>Each BluetoothClass encodes zero or more service classes. </para>    
				/// </summary>
				/// <java-name>
				/// android/bluetooth/BluetoothClass$Service
				/// </java-name>
				[Dot42.DexImport("android/bluetooth/BluetoothClass$Service", AccessFlags = 25)]
				public sealed partial class Service
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// LIMITED_DISCOVERABILITY
						/// </java-name>
						[Dot42.DexImport("LIMITED_DISCOVERABILITY", "I", AccessFlags = 25)]
						public const int LIMITED_DISCOVERABILITY = 8192;
						/// <java-name>
						/// POSITIONING
						/// </java-name>
						[Dot42.DexImport("POSITIONING", "I", AccessFlags = 25)]
						public const int POSITIONING = 65536;
						/// <java-name>
						/// NETWORKING
						/// </java-name>
						[Dot42.DexImport("NETWORKING", "I", AccessFlags = 25)]
						public const int NETWORKING = 131072;
						/// <java-name>
						/// RENDER
						/// </java-name>
						[Dot42.DexImport("RENDER", "I", AccessFlags = 25)]
						public const int RENDER = 262144;
						/// <java-name>
						/// CAPTURE
						/// </java-name>
						[Dot42.DexImport("CAPTURE", "I", AccessFlags = 25)]
						public const int CAPTURE = 524288;
						/// <java-name>
						/// OBJECT_TRANSFER
						/// </java-name>
						[Dot42.DexImport("OBJECT_TRANSFER", "I", AccessFlags = 25)]
						public const int OBJECT_TRANSFER = 1048576;
						/// <java-name>
						/// AUDIO
						/// </java-name>
						[Dot42.DexImport("AUDIO", "I", AccessFlags = 25)]
						public const int AUDIO = 2097152;
						/// <java-name>
						/// TELEPHONY
						/// </java-name>
						[Dot42.DexImport("TELEPHONY", "I", AccessFlags = 25)]
						public const int TELEPHONY = 4194304;
						/// <java-name>
						/// INFORMATION
						/// </java-name>
						[Dot42.DexImport("INFORMATION", "I", AccessFlags = 25)]
						public const int INFORMATION = 8388608;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Service() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Bluetooth Assigned Numbers. </para><para>For now we only include Company ID values. <para> </para></para>    
		/// </summary>
		/// <java-name>
		/// android/bluetooth/BluetoothAssignedNumbers
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothAssignedNumbers", AccessFlags = 33)]
		public partial class BluetoothAssignedNumbers
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ERICSSON_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("ERICSSON_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int ERICSSON_TECHNOLOGY = 0;
				/// <java-name>
				/// NOKIA_MOBILE_PHONES
				/// </java-name>
				[Dot42.DexImport("NOKIA_MOBILE_PHONES", "I", AccessFlags = 25)]
				public const int NOKIA_MOBILE_PHONES = 1;
				/// <java-name>
				/// INTEL
				/// </java-name>
				[Dot42.DexImport("INTEL", "I", AccessFlags = 25)]
				public const int INTEL = 2;
				/// <java-name>
				/// IBM
				/// </java-name>
				[Dot42.DexImport("IBM", "I", AccessFlags = 25)]
				public const int IBM = 3;
				/// <java-name>
				/// TOSHIBA
				/// </java-name>
				[Dot42.DexImport("TOSHIBA", "I", AccessFlags = 25)]
				public const int TOSHIBA = 4;
				/// <java-name>
				/// THREECOM
				/// </java-name>
				[Dot42.DexImport("THREECOM", "I", AccessFlags = 25)]
				public const int THREECOM = 5;
				/// <java-name>
				/// MICROSOFT
				/// </java-name>
				[Dot42.DexImport("MICROSOFT", "I", AccessFlags = 25)]
				public const int MICROSOFT = 6;
				/// <java-name>
				/// LUCENT
				/// </java-name>
				[Dot42.DexImport("LUCENT", "I", AccessFlags = 25)]
				public const int LUCENT = 7;
				/// <java-name>
				/// MOTOROLA
				/// </java-name>
				[Dot42.DexImport("MOTOROLA", "I", AccessFlags = 25)]
				public const int MOTOROLA = 8;
				/// <java-name>
				/// INFINEON_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("INFINEON_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int INFINEON_TECHNOLOGIES = 9;
				/// <java-name>
				/// CAMBRIDGE_SILICON_RADIO
				/// </java-name>
				[Dot42.DexImport("CAMBRIDGE_SILICON_RADIO", "I", AccessFlags = 25)]
				public const int CAMBRIDGE_SILICON_RADIO = 10;
				/// <java-name>
				/// SILICON_WAVE
				/// </java-name>
				[Dot42.DexImport("SILICON_WAVE", "I", AccessFlags = 25)]
				public const int SILICON_WAVE = 11;
				/// <java-name>
				/// DIGIANSWER
				/// </java-name>
				[Dot42.DexImport("DIGIANSWER", "I", AccessFlags = 25)]
				public const int DIGIANSWER = 12;
				/// <java-name>
				/// TEXAS_INSTRUMENTS
				/// </java-name>
				[Dot42.DexImport("TEXAS_INSTRUMENTS", "I", AccessFlags = 25)]
				public const int TEXAS_INSTRUMENTS = 13;
				/// <java-name>
				/// PARTHUS_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("PARTHUS_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int PARTHUS_TECHNOLOGIES = 14;
				/// <java-name>
				/// BROADCOM
				/// </java-name>
				[Dot42.DexImport("BROADCOM", "I", AccessFlags = 25)]
				public const int BROADCOM = 15;
				/// <java-name>
				/// MITEL_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("MITEL_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int MITEL_SEMICONDUCTOR = 16;
				/// <java-name>
				/// WIDCOMM
				/// </java-name>
				[Dot42.DexImport("WIDCOMM", "I", AccessFlags = 25)]
				public const int WIDCOMM = 17;
				/// <java-name>
				/// ZEEVO
				/// </java-name>
				[Dot42.DexImport("ZEEVO", "I", AccessFlags = 25)]
				public const int ZEEVO = 18;
				/// <java-name>
				/// ATMEL
				/// </java-name>
				[Dot42.DexImport("ATMEL", "I", AccessFlags = 25)]
				public const int ATMEL = 19;
				/// <java-name>
				/// MITSUBISHI_ELECTRIC
				/// </java-name>
				[Dot42.DexImport("MITSUBISHI_ELECTRIC", "I", AccessFlags = 25)]
				public const int MITSUBISHI_ELECTRIC = 20;
				/// <java-name>
				/// RTX_TELECOM
				/// </java-name>
				[Dot42.DexImport("RTX_TELECOM", "I", AccessFlags = 25)]
				public const int RTX_TELECOM = 21;
				/// <java-name>
				/// KC_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("KC_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int KC_TECHNOLOGY = 22;
				/// <java-name>
				/// NEWLOGIC
				/// </java-name>
				[Dot42.DexImport("NEWLOGIC", "I", AccessFlags = 25)]
				public const int NEWLOGIC = 23;
				/// <java-name>
				/// TRANSILICA
				/// </java-name>
				[Dot42.DexImport("TRANSILICA", "I", AccessFlags = 25)]
				public const int TRANSILICA = 24;
				/// <java-name>
				/// ROHDE_AND_SCHWARZ
				/// </java-name>
				[Dot42.DexImport("ROHDE_AND_SCHWARZ", "I", AccessFlags = 25)]
				public const int ROHDE_AND_SCHWARZ = 25;
				/// <java-name>
				/// TTPCOM
				/// </java-name>
				[Dot42.DexImport("TTPCOM", "I", AccessFlags = 25)]
				public const int TTPCOM = 26;
				/// <java-name>
				/// SIGNIA_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("SIGNIA_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int SIGNIA_TECHNOLOGIES = 27;
				/// <java-name>
				/// CONEXANT_SYSTEMS
				/// </java-name>
				[Dot42.DexImport("CONEXANT_SYSTEMS", "I", AccessFlags = 25)]
				public const int CONEXANT_SYSTEMS = 28;
				/// <java-name>
				/// QUALCOMM
				/// </java-name>
				[Dot42.DexImport("QUALCOMM", "I", AccessFlags = 25)]
				public const int QUALCOMM = 29;
				/// <java-name>
				/// INVENTEL
				/// </java-name>
				[Dot42.DexImport("INVENTEL", "I", AccessFlags = 25)]
				public const int INVENTEL = 30;
				/// <java-name>
				/// AVM_BERLIN
				/// </java-name>
				[Dot42.DexImport("AVM_BERLIN", "I", AccessFlags = 25)]
				public const int AVM_BERLIN = 31;
				/// <java-name>
				/// BANDSPEED
				/// </java-name>
				[Dot42.DexImport("BANDSPEED", "I", AccessFlags = 25)]
				public const int BANDSPEED = 32;
				/// <java-name>
				/// MANSELLA
				/// </java-name>
				[Dot42.DexImport("MANSELLA", "I", AccessFlags = 25)]
				public const int MANSELLA = 33;
				/// <java-name>
				/// NEC
				/// </java-name>
				[Dot42.DexImport("NEC", "I", AccessFlags = 25)]
				public const int NEC = 34;
				/// <java-name>
				/// WAVEPLUS_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("WAVEPLUS_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int WAVEPLUS_TECHNOLOGY = 35;
				/// <java-name>
				/// ALCATEL
				/// </java-name>
				[Dot42.DexImport("ALCATEL", "I", AccessFlags = 25)]
				public const int ALCATEL = 36;
				/// <java-name>
				/// PHILIPS_SEMICONDUCTORS
				/// </java-name>
				[Dot42.DexImport("PHILIPS_SEMICONDUCTORS", "I", AccessFlags = 25)]
				public const int PHILIPS_SEMICONDUCTORS = 37;
				/// <java-name>
				/// C_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("C_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int C_TECHNOLOGIES = 38;
				/// <java-name>
				/// OPEN_INTERFACE
				/// </java-name>
				[Dot42.DexImport("OPEN_INTERFACE", "I", AccessFlags = 25)]
				public const int OPEN_INTERFACE = 39;
				/// <java-name>
				/// RF_MICRO_DEVICES
				/// </java-name>
				[Dot42.DexImport("RF_MICRO_DEVICES", "I", AccessFlags = 25)]
				public const int RF_MICRO_DEVICES = 40;
				/// <java-name>
				/// HITACHI
				/// </java-name>
				[Dot42.DexImport("HITACHI", "I", AccessFlags = 25)]
				public const int HITACHI = 41;
				/// <java-name>
				/// SYMBOL_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("SYMBOL_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int SYMBOL_TECHNOLOGIES = 42;
				/// <java-name>
				/// TENOVIS
				/// </java-name>
				[Dot42.DexImport("TENOVIS", "I", AccessFlags = 25)]
				public const int TENOVIS = 43;
				/// <java-name>
				/// MACRONIX
				/// </java-name>
				[Dot42.DexImport("MACRONIX", "I", AccessFlags = 25)]
				public const int MACRONIX = 44;
				/// <java-name>
				/// GCT_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("GCT_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int GCT_SEMICONDUCTOR = 45;
				/// <java-name>
				/// NORWOOD_SYSTEMS
				/// </java-name>
				[Dot42.DexImport("NORWOOD_SYSTEMS", "I", AccessFlags = 25)]
				public const int NORWOOD_SYSTEMS = 46;
				/// <java-name>
				/// MEWTEL_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("MEWTEL_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int MEWTEL_TECHNOLOGY = 47;
				/// <java-name>
				/// ST_MICROELECTRONICS
				/// </java-name>
				[Dot42.DexImport("ST_MICROELECTRONICS", "I", AccessFlags = 25)]
				public const int ST_MICROELECTRONICS = 48;
				/// <java-name>
				/// SYNOPSYS
				/// </java-name>
				[Dot42.DexImport("SYNOPSYS", "I", AccessFlags = 25)]
				public const int SYNOPSYS = 49;
				/// <java-name>
				/// RED_M
				/// </java-name>
				[Dot42.DexImport("RED_M", "I", AccessFlags = 25)]
				public const int RED_M = 50;
				/// <java-name>
				/// COMMIL
				/// </java-name>
				[Dot42.DexImport("COMMIL", "I", AccessFlags = 25)]
				public const int COMMIL = 51;
				/// <java-name>
				/// CATC
				/// </java-name>
				[Dot42.DexImport("CATC", "I", AccessFlags = 25)]
				public const int CATC = 52;
				/// <java-name>
				/// ECLIPSE
				/// </java-name>
				[Dot42.DexImport("ECLIPSE", "I", AccessFlags = 25)]
				public const int ECLIPSE = 53;
				/// <java-name>
				/// RENESAS_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("RENESAS_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int RENESAS_TECHNOLOGY = 54;
				/// <java-name>
				/// MOBILIAN_CORPORATION
				/// </java-name>
				[Dot42.DexImport("MOBILIAN_CORPORATION", "I", AccessFlags = 25)]
				public const int MOBILIAN_CORPORATION = 55;
				/// <java-name>
				/// TERAX
				/// </java-name>
				[Dot42.DexImport("TERAX", "I", AccessFlags = 25)]
				public const int TERAX = 56;
				/// <java-name>
				/// INTEGRATED_SYSTEM_SOLUTION
				/// </java-name>
				[Dot42.DexImport("INTEGRATED_SYSTEM_SOLUTION", "I", AccessFlags = 25)]
				public const int INTEGRATED_SYSTEM_SOLUTION = 57;
				/// <java-name>
				/// MATSUSHITA_ELECTRIC
				/// </java-name>
				[Dot42.DexImport("MATSUSHITA_ELECTRIC", "I", AccessFlags = 25)]
				public const int MATSUSHITA_ELECTRIC = 58;
				/// <java-name>
				/// GENNUM
				/// </java-name>
				[Dot42.DexImport("GENNUM", "I", AccessFlags = 25)]
				public const int GENNUM = 59;
				/// <java-name>
				/// RESEARCH_IN_MOTION
				/// </java-name>
				[Dot42.DexImport("RESEARCH_IN_MOTION", "I", AccessFlags = 25)]
				public const int RESEARCH_IN_MOTION = 60;
				/// <java-name>
				/// IPEXTREME
				/// </java-name>
				[Dot42.DexImport("IPEXTREME", "I", AccessFlags = 25)]
				public const int IPEXTREME = 61;
				/// <java-name>
				/// SYSTEMS_AND_CHIPS
				/// </java-name>
				[Dot42.DexImport("SYSTEMS_AND_CHIPS", "I", AccessFlags = 25)]
				public const int SYSTEMS_AND_CHIPS = 62;
				/// <java-name>
				/// BLUETOOTH_SIG
				/// </java-name>
				[Dot42.DexImport("BLUETOOTH_SIG", "I", AccessFlags = 25)]
				public const int BLUETOOTH_SIG = 63;
				/// <java-name>
				/// SEIKO_EPSON
				/// </java-name>
				[Dot42.DexImport("SEIKO_EPSON", "I", AccessFlags = 25)]
				public const int SEIKO_EPSON = 64;
				/// <java-name>
				/// INTEGRATED_SILICON_SOLUTION
				/// </java-name>
				[Dot42.DexImport("INTEGRATED_SILICON_SOLUTION", "I", AccessFlags = 25)]
				public const int INTEGRATED_SILICON_SOLUTION = 65;
				/// <java-name>
				/// CONWISE_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("CONWISE_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int CONWISE_TECHNOLOGY = 66;
				/// <java-name>
				/// PARROT
				/// </java-name>
				[Dot42.DexImport("PARROT", "I", AccessFlags = 25)]
				public const int PARROT = 67;
				/// <java-name>
				/// SOCKET_MOBILE
				/// </java-name>
				[Dot42.DexImport("SOCKET_MOBILE", "I", AccessFlags = 25)]
				public const int SOCKET_MOBILE = 68;
				/// <java-name>
				/// ATHEROS_COMMUNICATIONS
				/// </java-name>
				[Dot42.DexImport("ATHEROS_COMMUNICATIONS", "I", AccessFlags = 25)]
				public const int ATHEROS_COMMUNICATIONS = 69;
				/// <java-name>
				/// MEDIATEK
				/// </java-name>
				[Dot42.DexImport("MEDIATEK", "I", AccessFlags = 25)]
				public const int MEDIATEK = 70;
				/// <java-name>
				/// BLUEGIGA
				/// </java-name>
				[Dot42.DexImport("BLUEGIGA", "I", AccessFlags = 25)]
				public const int BLUEGIGA = 71;
				/// <java-name>
				/// MARVELL
				/// </java-name>
				[Dot42.DexImport("MARVELL", "I", AccessFlags = 25)]
				public const int MARVELL = 72;
				/// <java-name>
				/// THREE_DSP
				/// </java-name>
				[Dot42.DexImport("THREE_DSP", "I", AccessFlags = 25)]
				public const int THREE_DSP = 73;
				/// <java-name>
				/// ACCEL_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("ACCEL_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int ACCEL_SEMICONDUCTOR = 74;
				/// <java-name>
				/// CONTINENTAL_AUTOMOTIVE
				/// </java-name>
				[Dot42.DexImport("CONTINENTAL_AUTOMOTIVE", "I", AccessFlags = 25)]
				public const int CONTINENTAL_AUTOMOTIVE = 75;
				/// <java-name>
				/// APPLE
				/// </java-name>
				[Dot42.DexImport("APPLE", "I", AccessFlags = 25)]
				public const int APPLE = 76;
				/// <java-name>
				/// STACCATO_COMMUNICATIONS
				/// </java-name>
				[Dot42.DexImport("STACCATO_COMMUNICATIONS", "I", AccessFlags = 25)]
				public const int STACCATO_COMMUNICATIONS = 77;
				/// <java-name>
				/// AVAGO
				/// </java-name>
				[Dot42.DexImport("AVAGO", "I", AccessFlags = 25)]
				public const int AVAGO = 78;
				/// <java-name>
				/// APT_LICENSING
				/// </java-name>
				[Dot42.DexImport("APT_LICENSING", "I", AccessFlags = 25)]
				public const int APT_LICENSING = 79;
				/// <java-name>
				/// SIRF_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("SIRF_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int SIRF_TECHNOLOGY = 80;
				/// <java-name>
				/// TZERO_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("TZERO_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int TZERO_TECHNOLOGIES = 81;
				/// <java-name>
				/// J_AND_M
				/// </java-name>
				[Dot42.DexImport("J_AND_M", "I", AccessFlags = 25)]
				public const int J_AND_M = 82;
				/// <java-name>
				/// FREE2MOVE
				/// </java-name>
				[Dot42.DexImport("FREE2MOVE", "I", AccessFlags = 25)]
				public const int FREE2MOVE = 83;
				/// <java-name>
				/// THREE_DIJOY
				/// </java-name>
				[Dot42.DexImport("THREE_DIJOY", "I", AccessFlags = 25)]
				public const int THREE_DIJOY = 84;
				/// <java-name>
				/// PLANTRONICS
				/// </java-name>
				[Dot42.DexImport("PLANTRONICS", "I", AccessFlags = 25)]
				public const int PLANTRONICS = 85;
				/// <java-name>
				/// SONY_ERICSSON
				/// </java-name>
				[Dot42.DexImport("SONY_ERICSSON", "I", AccessFlags = 25)]
				public const int SONY_ERICSSON = 86;
				/// <java-name>
				/// HARMAN_INTERNATIONAL
				/// </java-name>
				[Dot42.DexImport("HARMAN_INTERNATIONAL", "I", AccessFlags = 25)]
				public const int HARMAN_INTERNATIONAL = 87;
				/// <java-name>
				/// VIZIO
				/// </java-name>
				[Dot42.DexImport("VIZIO", "I", AccessFlags = 25)]
				public const int VIZIO = 88;
				/// <java-name>
				/// NORDIC_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("NORDIC_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int NORDIC_SEMICONDUCTOR = 89;
				/// <java-name>
				/// EM_MICROELECTRONIC_MARIN
				/// </java-name>
				[Dot42.DexImport("EM_MICROELECTRONIC_MARIN", "I", AccessFlags = 25)]
				public const int EM_MICROELECTRONIC_MARIN = 90;
				/// <java-name>
				/// RALINK_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("RALINK_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int RALINK_TECHNOLOGY = 91;
				/// <java-name>
				/// BELKIN_INTERNATIONAL
				/// </java-name>
				[Dot42.DexImport("BELKIN_INTERNATIONAL", "I", AccessFlags = 25)]
				public const int BELKIN_INTERNATIONAL = 92;
				/// <java-name>
				/// REALTEK_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("REALTEK_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int REALTEK_SEMICONDUCTOR = 93;
				/// <java-name>
				/// STONESTREET_ONE
				/// </java-name>
				[Dot42.DexImport("STONESTREET_ONE", "I", AccessFlags = 25)]
				public const int STONESTREET_ONE = 94;
				/// <java-name>
				/// WICENTRIC
				/// </java-name>
				[Dot42.DexImport("WICENTRIC", "I", AccessFlags = 25)]
				public const int WICENTRIC = 95;
				/// <java-name>
				/// RIVIERAWAVES
				/// </java-name>
				[Dot42.DexImport("RIVIERAWAVES", "I", AccessFlags = 25)]
				public const int RIVIERAWAVES = 96;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothAssignedNumbers() /* MethodBuilder.Create */ 
				{
				}

		}

}


