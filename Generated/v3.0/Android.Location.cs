// Copyright (C) 2014 dot42
//
// Original filename: Android.Location.cs
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
namespace Android.Location
{
		/// <summary>
		/// <para>This class represents the current state of the GPS engine. This class is used in conjunction with the Listener interface. </para>    
		/// </summary>
		/// <java-name>
		/// android/location/GpsStatus
		/// </java-name>
		[Dot42.DexImport("android/location/GpsStatus", AccessFlags = 49)]
		public sealed partial class GpsStatus
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Event sent when the GPS system has started. </para>        
				/// </summary>
				/// <java-name>
				/// GPS_EVENT_STARTED
				/// </java-name>
				[Dot42.DexImport("GPS_EVENT_STARTED", "I", AccessFlags = 25)]
				public const int GPS_EVENT_STARTED = 1;
				/// <summary>
				/// <para>Event sent when the GPS system has stopped. </para>        
				/// </summary>
				/// <java-name>
				/// GPS_EVENT_STOPPED
				/// </java-name>
				[Dot42.DexImport("GPS_EVENT_STOPPED", "I", AccessFlags = 25)]
				public const int GPS_EVENT_STOPPED = 2;
				/// <summary>
				/// <para>Event sent when the GPS system has received its first fix since starting. Call getTimeToFirstFix() to find the time from start to first fix. </para>        
				/// </summary>
				/// <java-name>
				/// GPS_EVENT_FIRST_FIX
				/// </java-name>
				[Dot42.DexImport("GPS_EVENT_FIRST_FIX", "I", AccessFlags = 25)]
				public const int GPS_EVENT_FIRST_FIX = 3;
				/// <summary>
				/// <para>Event sent periodically to report GPS satellite status. Call getSatellites() to retrieve the status for each satellite. </para>        
				/// </summary>
				/// <java-name>
				/// GPS_EVENT_SATELLITE_STATUS
				/// </java-name>
				[Dot42.DexImport("GPS_EVENT_SATELLITE_STATUS", "I", AccessFlags = 25)]
				public const int GPS_EVENT_SATELLITE_STATUS = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal GpsStatus() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the time required to receive the first fix since the most recent restart of the GPS engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>time to first fix in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getTimeToFirstFix
				/// </java-name>
				[Dot42.DexImport("getTimeToFirstFix", "()I", AccessFlags = 1)]
				public int GetTimeToFirstFix() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an array of GpsSatellite objects, which represent the current state of the GPS engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of satellites </para>
				/// </returns>
				/// <java-name>
				/// getSatellites
				/// </java-name>
				[Dot42.DexImport("getSatellites", "()Ljava/lang/Iterable;", AccessFlags = 1, Signature = "()Ljava/lang/Iterable<Landroid/location/GpsSatellite;>;")]
				public global::Java.Lang.IIterable<global::Android.Location.GpsSatellite> GetSatellites() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.IIterable<global::Android.Location.GpsSatellite>);
				}

				/// <summary>
				/// <para>Returns the maximum number of satellites that can be in the satellite list that can be returned by getSatellites().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of satellites </para>
				/// </returns>
				/// <java-name>
				/// getMaxSatellites
				/// </java-name>
				[Dot42.DexImport("getMaxSatellites", "()I", AccessFlags = 1)]
				public int GetMaxSatellites() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the time required to receive the first fix since the most recent restart of the GPS engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>time to first fix in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getTimeToFirstFix
				/// </java-name>
				public int TimeToFirstFix
				{
				[Dot42.DexImport("getTimeToFirstFix", "()I", AccessFlags = 1)]
						get{ return GetTimeToFirstFix(); }
				}

				/// <summary>
				/// <para>Returns an array of GpsSatellite objects, which represent the current state of the GPS engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of satellites </para>
				/// </returns>
				/// <java-name>
				/// getSatellites
				/// </java-name>
				public global::Java.Lang.IIterable<global::Android.Location.GpsSatellite> Satellites
				{
				[Dot42.DexImport("getSatellites", "()Ljava/lang/Iterable;", AccessFlags = 1, Signature = "()Ljava/lang/Iterable<Landroid/location/GpsSatellite;>;")]
						get{ return GetSatellites(); }
				}

				/// <summary>
				/// <para>Returns the maximum number of satellites that can be in the satellite list that can be returned by getSatellites().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of satellites </para>
				/// </returns>
				/// <java-name>
				/// getMaxSatellites
				/// </java-name>
				public int MaxSatellites
				{
				[Dot42.DexImport("getMaxSatellites", "()I", AccessFlags = 1)]
						get{ return GetMaxSatellites(); }
				}

				/// <summary>
				/// <para>Used for receiving NMEA sentences from the GPS. NMEA 0183 is a standard for communicating with marine electronic devices and is a common method for receiving data from a GPS, typically over a serial port. See  for more details. You can implement this interface and call LocationManager#addNmeaListener to receive NMEA data from the GPS engine. </para>    
				/// </summary>
				/// <java-name>
				/// android/location/GpsStatus$NmeaListener
				/// </java-name>
				[Dot42.DexImport("android/location/GpsStatus$NmeaListener", AccessFlags = 1545)]
				public partial interface INmeaListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onNmeaReceived
						/// </java-name>
						[Dot42.DexImport("onNmeaReceived", "(JLjava/lang/String;)V", AccessFlags = 1025)]
						void OnNmeaReceived(long timestamp, string nmea) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Used for receiving notifications when GPS status has changed. </para>    
				/// </summary>
				/// <java-name>
				/// android/location/GpsStatus$Listener
				/// </java-name>
				[Dot42.DexImport("android/location/GpsStatus$Listener", AccessFlags = 1545)]
				public partial interface IListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called to report changes in the GPS status. The event number is one of: <ul><li><para>GpsStatus#GPS_EVENT_STARTED </para></li><li><para>GpsStatus#GPS_EVENT_STOPPED </para></li><li><para>GpsStatus#GPS_EVENT_FIRST_FIX </para></li><li><para>GpsStatus#GPS_EVENT_SATELLITE_STATUS </para></li></ul></para><para>When this method is called, the client should call LocationManager#getGpsStatus to get additional status information.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onGpsStatusChanged
						/// </java-name>
						[Dot42.DexImport("onGpsStatusChanged", "(I)V", AccessFlags = 1025)]
						void OnGpsStatusChanged(int @event) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>A class representing an Address, i.e, a set of Strings describing a location.</para><para>The addres format is a simplified version of xAL (eXtensible Address Language)  </para>    
		/// </summary>
		/// <java-name>
		/// android/location/Address
		/// </java-name>
		[Dot42.DexImport("android/location/Address", AccessFlags = 33)]
		public partial class Address : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Location.Address> CREATOR;
				/// <summary>
				/// <para>Constructs a new Address object set to the given Locale and with all other fields initialized to null or false. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public Address(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the Locale associated with this address. </para>        
				/// </summary>
				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public virtual global::Java.Util.Locale GetLocale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <summary>
				/// <para>Returns the largest index currently in use to specify an address line. If no address lines are specified, -1 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getMaxAddressLineIndex
				/// </java-name>
				[Dot42.DexImport("getMaxAddressLineIndex", "()I", AccessFlags = 1)]
				public virtual int GetMaxAddressLineIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a line of the address numbered by the given index (starting at 0), or null if no such line is present.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getAddressLine
				/// </java-name>
				[Dot42.DexImport("getAddressLine", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAddressLine(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the line of the address numbered by index (starting at 0) to the given String, which may be null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAddressLine
				/// </java-name>
				[Dot42.DexImport("setAddressLine", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAddressLine(int index, string line) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the feature name of the address, for example, "Golden Gate Bridge", or null if it is unknown </para>        
				/// </summary>
				/// <java-name>
				/// getFeatureName
				/// </java-name>
				[Dot42.DexImport("getFeatureName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFeatureName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the feature name of the address to the given String, which may be null </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureName
				/// </java-name>
				[Dot42.DexImport("setFeatureName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetFeatureName(string featureName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the administrative area name of the address, for example, "CA", or null if it is unknown </para>        
				/// </summary>
				/// <java-name>
				/// getAdminArea
				/// </java-name>
				[Dot42.DexImport("getAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAdminArea() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the administrative area name of the address to the given String, which may be null </para>        
				/// </summary>
				/// <java-name>
				/// setAdminArea
				/// </java-name>
				[Dot42.DexImport("setAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAdminArea(string adminArea) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the sub-administrative area name of the address, for example, "Santa Clara County", or null if it is unknown </para>        
				/// </summary>
				/// <java-name>
				/// getSubAdminArea
				/// </java-name>
				[Dot42.DexImport("getSubAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSubAdminArea() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the sub-administrative area name of the address to the given String, which may be null </para>        
				/// </summary>
				/// <java-name>
				/// setSubAdminArea
				/// </java-name>
				[Dot42.DexImport("setSubAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSubAdminArea(string subAdminArea) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the locality of the address, for example "Mountain View", or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getLocality
				/// </java-name>
				[Dot42.DexImport("getLocality", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocality() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the locality of the address to the given String, which may be null. </para>        
				/// </summary>
				/// <java-name>
				/// setLocality
				/// </java-name>
				[Dot42.DexImport("setLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetLocality(string locality) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the sub-locality of the address, or null if it is unknown. For example, this may correspond to the neighborhood of the locality. </para>        
				/// </summary>
				/// <java-name>
				/// getSubLocality
				/// </java-name>
				[Dot42.DexImport("getSubLocality", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSubLocality() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the sub-locality of the address to the given String, which may be null. </para>        
				/// </summary>
				/// <java-name>
				/// setSubLocality
				/// </java-name>
				[Dot42.DexImport("setSubLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSubLocality(string sublocality) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the thoroughfare name of the address, for example, "1600 Ampitheater Parkway", which may be null </para>        
				/// </summary>
				/// <java-name>
				/// getThoroughfare
				/// </java-name>
				[Dot42.DexImport("getThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetThoroughfare() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the thoroughfare name of the address, which may be null. </para>        
				/// </summary>
				/// <java-name>
				/// setThoroughfare
				/// </java-name>
				[Dot42.DexImport("setThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetThoroughfare(string thoroughfare) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the sub-thoroughfare name of the address, which may be null. This may correspond to the street number of the address. </para>        
				/// </summary>
				/// <java-name>
				/// getSubThoroughfare
				/// </java-name>
				[Dot42.DexImport("getSubThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSubThoroughfare() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the sub-thoroughfare name of the address, which may be null. </para>        
				/// </summary>
				/// <java-name>
				/// setSubThoroughfare
				/// </java-name>
				[Dot42.DexImport("setSubThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSubThoroughfare(string subthoroughfare) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the premises of the address, or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getPremises
				/// </java-name>
				[Dot42.DexImport("getPremises", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPremises() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the premises of the address to the given String, which may be null. </para>        
				/// </summary>
				/// <java-name>
				/// setPremises
				/// </java-name>
				[Dot42.DexImport("setPremises", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPremises(string premises) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the postal code of the address, for example "94110", or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getPostalCode
				/// </java-name>
				[Dot42.DexImport("getPostalCode", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPostalCode() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the postal code of the address to the given String, which may be null. </para>        
				/// </summary>
				/// <java-name>
				/// setPostalCode
				/// </java-name>
				[Dot42.DexImport("setPostalCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPostalCode(string postalCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the country code of the address, for example "US", or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getCountryCode
				/// </java-name>
				[Dot42.DexImport("getCountryCode", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCountryCode() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the country code of the address to the given String, which may be null. </para>        
				/// </summary>
				/// <java-name>
				/// setCountryCode
				/// </java-name>
				[Dot42.DexImport("setCountryCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCountryCode(string countryCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the localized country name of the address, for example "Iceland", or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getCountryName
				/// </java-name>
				[Dot42.DexImport("getCountryName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCountryName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the country name of the address to the given String, which may be null. </para>        
				/// </summary>
				/// <java-name>
				/// setCountryName
				/// </java-name>
				[Dot42.DexImport("setCountryName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCountryName(string countryName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if a latitude has been assigned to this Address, false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// hasLatitude
				/// </java-name>
				[Dot42.DexImport("hasLatitude", "()Z", AccessFlags = 1)]
				public virtual bool HasLatitude() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the latitude of the address if known.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLatitude
				/// </java-name>
				[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
				public virtual double GetLatitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Sets the latitude associated with this address. </para>        
				/// </summary>
				/// <java-name>
				/// setLatitude
				/// </java-name>
				[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
				public virtual void SetLatitude(double latitude) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes any latitude associated with this address. </para>        
				/// </summary>
				/// <java-name>
				/// clearLatitude
				/// </java-name>
				[Dot42.DexImport("clearLatitude", "()V", AccessFlags = 1)]
				public virtual void ClearLatitude() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if a longitude has been assigned to this Address, false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// hasLongitude
				/// </java-name>
				[Dot42.DexImport("hasLongitude", "()Z", AccessFlags = 1)]
				public virtual bool HasLongitude() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the longitude of the address if known.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLongitude
				/// </java-name>
				[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
				public virtual double GetLongitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Sets the longitude associated with this address. </para>        
				/// </summary>
				/// <java-name>
				/// setLongitude
				/// </java-name>
				[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
				public virtual void SetLongitude(double longitude) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes any longitude associated with this address. </para>        
				/// </summary>
				/// <java-name>
				/// clearLongitude
				/// </java-name>
				[Dot42.DexImport("clearLongitude", "()V", AccessFlags = 1)]
				public virtual void ClearLongitude() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the phone number of the address if known, or null if it is unknown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getPhone
				/// </java-name>
				[Dot42.DexImport("getPhone", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPhone() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the phone number associated with this address. </para>        
				/// </summary>
				/// <java-name>
				/// setPhone
				/// </java-name>
				[Dot42.DexImport("setPhone", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPhone(string phone) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the public URL for the address if known, or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getUrl
				/// </java-name>
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the public URL associated with this address. </para>        
				/// </summary>
				/// <java-name>
				/// setUrl
				/// </java-name>
				[Dot42.DexImport("setUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetUrl(string Url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns additional provider-specific information about the address as a Bundle. The keys and values are determined by the provider. If no additional information is available, null is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <summary>
				/// <para>Sets the extra information associated with this fix to the given Bundle. </para>        
				/// </summary>
				/// <java-name>
				/// setExtras
				/// </java-name>
				[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SetExtras(global::Android.Os.Bundle extras) /* MethodBuilder.Create */ 
				{
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Address() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the Locale associated with this address. </para>        
				/// </summary>
				/// <java-name>
				/// getLocale
				/// </java-name>
				public global::Java.Util.Locale Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return GetLocale(); }
				}

				/// <summary>
				/// <para>Returns the largest index currently in use to specify an address line. If no address lines are specified, -1 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getMaxAddressLineIndex
				/// </java-name>
				public int MaxAddressLineIndex
				{
				[Dot42.DexImport("getMaxAddressLineIndex", "()I", AccessFlags = 1)]
						get{ return GetMaxAddressLineIndex(); }
				}

				/// <summary>
				/// <para>Returns the feature name of the address, for example, "Golden Gate Bridge", or null if it is unknown </para>        
				/// </summary>
				/// <java-name>
				/// getFeatureName
				/// </java-name>
				public string FeatureName
				{
				[Dot42.DexImport("getFeatureName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFeatureName(); }
				[Dot42.DexImport("setFeatureName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetFeatureName(value); }
				}

				/// <summary>
				/// <para>Returns the administrative area name of the address, for example, "CA", or null if it is unknown </para>        
				/// </summary>
				/// <java-name>
				/// getAdminArea
				/// </java-name>
				public string AdminArea
				{
				[Dot42.DexImport("getAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAdminArea(); }
				[Dot42.DexImport("setAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetAdminArea(value); }
				}

				/// <summary>
				/// <para>Returns the sub-administrative area name of the address, for example, "Santa Clara County", or null if it is unknown </para>        
				/// </summary>
				/// <java-name>
				/// getSubAdminArea
				/// </java-name>
				public string SubAdminArea
				{
				[Dot42.DexImport("getSubAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSubAdminArea(); }
				[Dot42.DexImport("setSubAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSubAdminArea(value); }
				}

				/// <summary>
				/// <para>Returns the locality of the address, for example "Mountain View", or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getLocality
				/// </java-name>
				public string Locality
				{
				[Dot42.DexImport("getLocality", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocality(); }
				[Dot42.DexImport("setLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetLocality(value); }
				}

				/// <summary>
				/// <para>Returns the sub-locality of the address, or null if it is unknown. For example, this may correspond to the neighborhood of the locality. </para>        
				/// </summary>
				/// <java-name>
				/// getSubLocality
				/// </java-name>
				public string SubLocality
				{
				[Dot42.DexImport("getSubLocality", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSubLocality(); }
				[Dot42.DexImport("setSubLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSubLocality(value); }
				}

				/// <summary>
				/// <para>Returns the thoroughfare name of the address, for example, "1600 Ampitheater Parkway", which may be null </para>        
				/// </summary>
				/// <java-name>
				/// getThoroughfare
				/// </java-name>
				public string Thoroughfare
				{
				[Dot42.DexImport("getThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetThoroughfare(); }
				[Dot42.DexImport("setThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetThoroughfare(value); }
				}

				/// <summary>
				/// <para>Returns the sub-thoroughfare name of the address, which may be null. This may correspond to the street number of the address. </para>        
				/// </summary>
				/// <java-name>
				/// getSubThoroughfare
				/// </java-name>
				public string SubThoroughfare
				{
				[Dot42.DexImport("getSubThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSubThoroughfare(); }
				[Dot42.DexImport("setSubThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSubThoroughfare(value); }
				}

				/// <summary>
				/// <para>Returns the premises of the address, or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getPremises
				/// </java-name>
				public string Premises
				{
				[Dot42.DexImport("getPremises", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPremises(); }
				[Dot42.DexImport("setPremises", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPremises(value); }
				}

				/// <summary>
				/// <para>Returns the postal code of the address, for example "94110", or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getPostalCode
				/// </java-name>
				public string PostalCode
				{
				[Dot42.DexImport("getPostalCode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPostalCode(); }
				[Dot42.DexImport("setPostalCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPostalCode(value); }
				}

				/// <summary>
				/// <para>Returns the country code of the address, for example "US", or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getCountryCode
				/// </java-name>
				public string CountryCode
				{
				[Dot42.DexImport("getCountryCode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCountryCode(); }
				[Dot42.DexImport("setCountryCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCountryCode(value); }
				}

				/// <summary>
				/// <para>Returns the localized country name of the address, for example "Iceland", or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getCountryName
				/// </java-name>
				public string CountryName
				{
				[Dot42.DexImport("getCountryName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCountryName(); }
				[Dot42.DexImport("setCountryName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCountryName(value); }
				}

				/// <summary>
				/// <para>Returns the latitude of the address if known.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLatitude
				/// </java-name>
				public double Latitude
				{
				[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
						get{ return GetLatitude(); }
				[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
						set{ SetLatitude(value); }
				}

				/// <summary>
				/// <para>Returns the longitude of the address if known.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLongitude
				/// </java-name>
				public double Longitude
				{
				[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
						get{ return GetLongitude(); }
				[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
						set{ SetLongitude(value); }
				}

				/// <summary>
				/// <para>Returns the phone number of the address if known, or null if it is unknown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getPhone
				/// </java-name>
				public string Phone
				{
				[Dot42.DexImport("getPhone", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPhone(); }
				[Dot42.DexImport("setPhone", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPhone(value); }
				}

				/// <summary>
				/// <para>Returns the public URL for the address if known, or null if it is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getUrl
				/// </java-name>
				public string Url
				{
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUrl(); }
				[Dot42.DexImport("setUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetUrl(value); }
				}

				/// <summary>
				/// <para>Returns additional provider-specific information about the address as a Bundle. The keys and values are determined by the provider. If no additional information is available, null is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.Os.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						set{ SetExtras(value); }
				}

		}

		/// <summary>
		/// <para>A data class representing a geographic location.</para><para>A location can consist of a latitude, longitude, timestamp, and other information such as bearing, altitude and velocity.</para><para>All locations generated by the LocationManager are guaranteed to have a valid latitude, longitude, and timestamp (both UTC time and elapsed real-time since boot), all other parameters are optional. </para>    
		/// </summary>
		/// <java-name>
		/// android/location/Location
		/// </java-name>
		[Dot42.DexImport("android/location/Location", AccessFlags = 33)]
		public partial class Location : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant used to specify formatting of a latitude or longitude in the form "[+-]DDD.DDDDD where D indicates degrees. </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_DEGREES
				/// </java-name>
				[Dot42.DexImport("FORMAT_DEGREES", "I", AccessFlags = 25)]
				public const int FORMAT_DEGREES = 0;
				/// <summary>
				/// <para>Constant used to specify formatting of a latitude or longitude in the form "[+-]DDD:MM.MMMMM" where D indicates degrees and M indicates minutes of arc (1 minute = 1/60th of a degree). </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MINUTES
				/// </java-name>
				[Dot42.DexImport("FORMAT_MINUTES", "I", AccessFlags = 25)]
				public const int FORMAT_MINUTES = 1;
				/// <summary>
				/// <para>Constant used to specify formatting of a latitude or longitude in the form "DDD:MM:SS.SSSSS" where D indicates degrees, M indicates minutes of arc, and S indicates seconds of arc (1 minute = 1/60th of a degree, 1 second = 1/3600th of a degree). </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_SECONDS
				/// </java-name>
				[Dot42.DexImport("FORMAT_SECONDS", "I", AccessFlags = 25)]
				public const int FORMAT_SECONDS = 2;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Location.Location> CREATOR;
				/// <summary>
				/// <para>Construct a new Location object that is copied from an existing one. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Location(string l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a new Location object that is copied from an existing one. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/location/Location;)V", AccessFlags = 1)]
				public Location(global::Android.Location.Location l) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the contents of the location to the values from the given location. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/location/Location;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Location.Location l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the contents of the location. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts a coordinate to a String representation. The outputType may be one of FORMAT_DEGREES, FORMAT_MINUTES, or FORMAT_SECONDS. The coordinate must be a valid double between -180.0 and 180.0.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// convert
				/// </java-name>
				[Dot42.DexImport("convert", "(DI)Ljava/lang/String;", AccessFlags = 9)]
				public static string Convert(double coordinate, int outputType) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts a String in one of the formats described by FORMAT_DEGREES, FORMAT_MINUTES, or FORMAT_SECONDS into a double.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// convert
				/// </java-name>
				[Dot42.DexImport("convert", "(Ljava/lang/String;)D", AccessFlags = 9)]
				public static double Convert(string coordinate) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Computes the approximate distance in meters between two locations, and optionally the initial and final bearings of the shortest path between them. Distance and bearing are defined using the WGS84 ellipsoid.</para><para>The computed distance is stored in results[0]. If results has length 2 or greater, the initial bearing is stored in results[1]. If results has length 3 or greater, the final bearing is stored in results[2].</para><para></para>        
				/// </summary>
				/// <java-name>
				/// distanceBetween
				/// </java-name>
				[Dot42.DexImport("distanceBetween", "(DDDD[F)V", AccessFlags = 9)]
				public static void DistanceBetween(double startLatitude, double startLongitude, double endLatitude, double endLongitude, float[] results) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the approximate distance in meters between this location and the given location. Distance is defined using the WGS84 ellipsoid.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the approximate distance in meters </para>
				/// </returns>
				/// <java-name>
				/// distanceTo
				/// </java-name>
				[Dot42.DexImport("distanceTo", "(Landroid/location/Location;)F", AccessFlags = 1)]
				public virtual float DistanceTo(global::Android.Location.Location dest) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the approximate initial bearing in degrees East of true North when traveling along the shortest path between this location and the given location. The shortest path is defined using the WGS84 ellipsoid. Locations that are (nearly) antipodal may produce meaningless results.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the initial bearing in degrees </para>
				/// </returns>
				/// <java-name>
				/// bearingTo
				/// </java-name>
				[Dot42.DexImport("bearingTo", "(Landroid/location/Location;)F", AccessFlags = 1)]
				public virtual float BearingTo(global::Android.Location.Location dest) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the name of the provider that generated this fix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider, or null if it has not been set </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProvider() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the name of the provider that generated this fix. </para>        
				/// </summary>
				/// <java-name>
				/// setProvider
				/// </java-name>
				[Dot42.DexImport("setProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetProvider(string provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the UTC time of this fix, in milliseconds since January 1, 1970.</para><para>Note that the UTC time on a device is not monotonic: it can jump forwards or backwards unpredictably. So always use getElapsedRealtimeNanos when calculating time deltas.</para><para>On the other hand, getTime is useful for presenting a human readable time to the user, or for carefully comparing location fixes across reboot or across devices.</para><para>All locations generated by the LocationManager are guaranteed to have a valid UTC time, however remember that the system time may have changed since the location was generated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>time of fix, in milliseconds since January 1, 1970. </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
				public virtual long GetTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Set the UTC time of this fix, in milliseconds since January 1, 1970.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
				public virtual void SetTime(long time) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the latitude, in degrees.</para><para>All locations generated by the LocationManager will have a valid latitude. </para>        
				/// </summary>
				/// <java-name>
				/// getLatitude
				/// </java-name>
				[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
				public virtual double GetLatitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Set the latitude, in degrees. </para>        
				/// </summary>
				/// <java-name>
				/// setLatitude
				/// </java-name>
				[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
				public virtual void SetLatitude(double latitude) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the longitude, in degrees.</para><para>All locations generated by the LocationManager will have a valid longitude. </para>        
				/// </summary>
				/// <java-name>
				/// getLongitude
				/// </java-name>
				[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
				public virtual double GetLongitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Set the longitude, in degrees. </para>        
				/// </summary>
				/// <java-name>
				/// setLongitude
				/// </java-name>
				[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
				public virtual void SetLongitude(double longitude) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>True if this location has an altitude. </para>        
				/// </summary>
				/// <java-name>
				/// hasAltitude
				/// </java-name>
				[Dot42.DexImport("hasAltitude", "()Z", AccessFlags = 1)]
				public virtual bool HasAltitude() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Get the altitude if available, in meters above sea level.</para><para>If this location does not have an altitude then 0.0 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getAltitude
				/// </java-name>
				[Dot42.DexImport("getAltitude", "()D", AccessFlags = 1)]
				public virtual double GetAltitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Set the altitude, in meters above sea level.</para><para>Following this call hasAltitude will return true. </para>        
				/// </summary>
				/// <java-name>
				/// setAltitude
				/// </java-name>
				[Dot42.DexImport("setAltitude", "(D)V", AccessFlags = 1)]
				public virtual void SetAltitude(double altitude) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove the altitude from this location.</para><para>Following this call hasAltitude will return false, and getAltitude will return 0.0. </para>        
				/// </summary>
				/// <java-name>
				/// removeAltitude
				/// </java-name>
				[Dot42.DexImport("removeAltitude", "()V", AccessFlags = 1)]
				public virtual void RemoveAltitude() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>True if this location has a speed. </para>        
				/// </summary>
				/// <java-name>
				/// hasSpeed
				/// </java-name>
				[Dot42.DexImport("hasSpeed", "()Z", AccessFlags = 1)]
				public virtual bool HasSpeed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Get the speed if it is available, in meters/second over ground.</para><para>If this location does not have a speed then 0.0 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getSpeed
				/// </java-name>
				[Dot42.DexImport("getSpeed", "()F", AccessFlags = 1)]
				public virtual float GetSpeed() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Set the speed, in meters/second over ground.</para><para>Following this call hasSpeed will return true. </para>        
				/// </summary>
				/// <java-name>
				/// setSpeed
				/// </java-name>
				[Dot42.DexImport("setSpeed", "(F)V", AccessFlags = 1)]
				public virtual void SetSpeed(float speed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove the speed from this location.</para><para>Following this call hasSpeed will return false, and getSpeed will return 0.0. </para>        
				/// </summary>
				/// <java-name>
				/// removeSpeed
				/// </java-name>
				[Dot42.DexImport("removeSpeed", "()V", AccessFlags = 1)]
				public virtual void RemoveSpeed() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>True if this location has a bearing. </para>        
				/// </summary>
				/// <java-name>
				/// hasBearing
				/// </java-name>
				[Dot42.DexImport("hasBearing", "()Z", AccessFlags = 1)]
				public virtual bool HasBearing() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Get the bearing, in degrees.</para><para>Bearing is the horizontal direction of travel of this device, and is not related to the device orientation. It is guaranteed to be in the range (0.0, 360.0] if the device has a bearing.</para><para>If this location does not have a bearing then 0.0 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getBearing
				/// </java-name>
				[Dot42.DexImport("getBearing", "()F", AccessFlags = 1)]
				public virtual float GetBearing() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Set the bearing, in degrees.</para><para>Bearing is the horizontal direction of travel of this device, and is not related to the device orientation.</para><para>The input will be wrapped into the range (0.0, 360.0]. </para>        
				/// </summary>
				/// <java-name>
				/// setBearing
				/// </java-name>
				[Dot42.DexImport("setBearing", "(F)V", AccessFlags = 1)]
				public virtual void SetBearing(float bearing) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove the bearing from this location.</para><para>Following this call hasBearing will return false, and getBearing will return 0.0. </para>        
				/// </summary>
				/// <java-name>
				/// removeBearing
				/// </java-name>
				[Dot42.DexImport("removeBearing", "()V", AccessFlags = 1)]
				public virtual void RemoveBearing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>True if this location has an accuracy.</para><para>All locations generated by the LocationManager have an accuracy. </para>        
				/// </summary>
				/// <java-name>
				/// hasAccuracy
				/// </java-name>
				[Dot42.DexImport("hasAccuracy", "()Z", AccessFlags = 1)]
				public virtual bool HasAccuracy() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Get the estimated accuracy of this location, in meters.</para><para>We define accuracy as the radius of 68% confidence. In other words, if you draw a circle centered at this location's latitude and longitude, and with a radius equal to the accuracy, then there is a 68% probability that the true location is inside the circle.</para><para>In statistical terms, it is assumed that location errors are random with a normal distribution, so the 68% confidence circle represents one standard deviation. Note that in practice, location errors do not always follow such a simple distribution.</para><para>This accuracy estimation is only concerned with horizontal accuracy, and does not indicate the accuracy of bearing, velocity or altitude if those are included in this Location.</para><para>If this location does not have an accuracy, then 0.0 is returned. All locations generated by the LocationManager include an accuracy. </para>        
				/// </summary>
				/// <java-name>
				/// getAccuracy
				/// </java-name>
				[Dot42.DexImport("getAccuracy", "()F", AccessFlags = 1)]
				public virtual float GetAccuracy() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Set the estimated accuracy of this location, meters.</para><para>See getAccuracy for the definition of accuracy.</para><para>Following this call hasAccuracy will return true. </para>        
				/// </summary>
				/// <java-name>
				/// setAccuracy
				/// </java-name>
				[Dot42.DexImport("setAccuracy", "(F)V", AccessFlags = 1)]
				public virtual void SetAccuracy(float accuracy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove the accuracy from this location.</para><para>Following this call hasAccuracy will return false, and getAccuracy will return 0.0. </para>        
				/// </summary>
				/// <java-name>
				/// removeAccuracy
				/// </java-name>
				[Dot42.DexImport("removeAccuracy", "()V", AccessFlags = 1)]
				public virtual void RemoveAccuracy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns additional provider-specific information about the location fix as a Bundle. The keys and values are determined by the provider. If no additional information is available, null is returned.</para><para>A number of common key/value pairs are listed below. Providers that use any of the keys on this list must provide the corresponding value as described below.</para><para><ul><li><para>satellites - the number of satellites used to derive the fix </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <summary>
				/// <para>Sets the extra information associated with this fix to the given Bundle. </para>        
				/// </summary>
				/// <java-name>
				/// setExtras
				/// </java-name>
				[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SetExtras(global::Android.Os.Bundle extras) /* MethodBuilder.Create */ 
				{
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Location() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the provider that generated this fix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider, or null if it has not been set </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public string Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProvider(); }
				[Dot42.DexImport("setProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetProvider(value); }
				}

				/// <summary>
				/// <para>Return the UTC time of this fix, in milliseconds since January 1, 1970.</para><para>Note that the UTC time on a device is not monotonic: it can jump forwards or backwards unpredictably. So always use getElapsedRealtimeNanos when calculating time deltas.</para><para>On the other hand, getTime is useful for presenting a human readable time to the user, or for carefully comparing location fixes across reboot or across devices.</para><para>All locations generated by the LocationManager are guaranteed to have a valid UTC time, however remember that the system time may have changed since the location was generated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>time of fix, in milliseconds since January 1, 1970. </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				public long Time
				{
				[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
						get{ return GetTime(); }
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ SetTime(value); }
				}

				/// <summary>
				/// <para>Get the latitude, in degrees.</para><para>All locations generated by the LocationManager will have a valid latitude. </para>        
				/// </summary>
				/// <java-name>
				/// getLatitude
				/// </java-name>
				public double Latitude
				{
				[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
						get{ return GetLatitude(); }
				[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
						set{ SetLatitude(value); }
				}

				/// <summary>
				/// <para>Get the longitude, in degrees.</para><para>All locations generated by the LocationManager will have a valid longitude. </para>        
				/// </summary>
				/// <java-name>
				/// getLongitude
				/// </java-name>
				public double Longitude
				{
				[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
						get{ return GetLongitude(); }
				[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
						set{ SetLongitude(value); }
				}

				/// <summary>
				/// <para>Get the altitude if available, in meters above sea level.</para><para>If this location does not have an altitude then 0.0 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getAltitude
				/// </java-name>
				public double Altitude
				{
				[Dot42.DexImport("getAltitude", "()D", AccessFlags = 1)]
						get{ return GetAltitude(); }
				[Dot42.DexImport("setAltitude", "(D)V", AccessFlags = 1)]
						set{ SetAltitude(value); }
				}

				/// <summary>
				/// <para>Get the speed if it is available, in meters/second over ground.</para><para>If this location does not have a speed then 0.0 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getSpeed
				/// </java-name>
				public float Speed
				{
				[Dot42.DexImport("getSpeed", "()F", AccessFlags = 1)]
						get{ return GetSpeed(); }
				[Dot42.DexImport("setSpeed", "(F)V", AccessFlags = 1)]
						set{ SetSpeed(value); }
				}

				/// <summary>
				/// <para>Get the bearing, in degrees.</para><para>Bearing is the horizontal direction of travel of this device, and is not related to the device orientation. It is guaranteed to be in the range (0.0, 360.0] if the device has a bearing.</para><para>If this location does not have a bearing then 0.0 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getBearing
				/// </java-name>
				public float Bearing
				{
				[Dot42.DexImport("getBearing", "()F", AccessFlags = 1)]
						get{ return GetBearing(); }
				[Dot42.DexImport("setBearing", "(F)V", AccessFlags = 1)]
						set{ SetBearing(value); }
				}

				/// <summary>
				/// <para>Get the estimated accuracy of this location, in meters.</para><para>We define accuracy as the radius of 68% confidence. In other words, if you draw a circle centered at this location's latitude and longitude, and with a radius equal to the accuracy, then there is a 68% probability that the true location is inside the circle.</para><para>In statistical terms, it is assumed that location errors are random with a normal distribution, so the 68% confidence circle represents one standard deviation. Note that in practice, location errors do not always follow such a simple distribution.</para><para>This accuracy estimation is only concerned with horizontal accuracy, and does not indicate the accuracy of bearing, velocity or altitude if those are included in this Location.</para><para>If this location does not have an accuracy, then 0.0 is returned. All locations generated by the LocationManager include an accuracy. </para>        
				/// </summary>
				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public float Accuracy
				{
				[Dot42.DexImport("getAccuracy", "()F", AccessFlags = 1)]
						get{ return GetAccuracy(); }
				[Dot42.DexImport("setAccuracy", "(F)V", AccessFlags = 1)]
						set{ SetAccuracy(value); }
				}

				/// <summary>
				/// <para>Returns additional provider-specific information about the location fix as a Bundle. The keys and values are determined by the provider. If no additional information is available, null is returned.</para><para>A number of common key/value pairs are listed below. Providers that use any of the keys on this list must provide the corresponding value as described below.</para><para><ul><li><para>satellites - the number of satellites used to derive the fix </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.Os.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						set{ SetExtras(value); }
				}

		}

		/// <summary>
		/// <para>A class for handling geocoding and reverse geocoding. Geocoding is the process of transforming a street address or other description of a location into a (latitude, longitude) coordinate. Reverse geocoding is the process of transforming a (latitude, longitude) coordinate into a (partial) address. The amount of detail in a reverse geocoded location description may vary, for example one might contain the full street address of the closest building, while another might contain only a city name and postal code.</para><para>The Geocoder class requires a backend service that is not included in the core android framework. The Geocoder query methods will return an empty list if there no backend service in the platform. Use the isPresent() method to determine whether a Geocoder implementation exists. </para>    
		/// </summary>
		/// <java-name>
		/// android/location/Geocoder
		/// </java-name>
		[Dot42.DexImport("android/location/Geocoder", AccessFlags = 49)]
		public sealed partial class Geocoder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a Geocoder whose responses will be localized for the given Locale.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/Locale;)V", AccessFlags = 1)]
				public Geocoder(global::Android.Content.Context context, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a Geocoder whose responses will be localized for the default system Locale.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Geocoder(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if the Geocoder methods getFromLocation and getFromLocationName are implemented. Lack of network connectivity may still cause these methods to return null or empty lists. </para>        
				/// </summary>
				/// <java-name>
				/// isPresent
				/// </java-name>
				[Dot42.DexImport("isPresent", "()Z", AccessFlags = 9)]
				public static bool IsPresent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an array of Addresses that are known to describe the area immediately surrounding the given latitude and longitude. The returned addresses will be localized for the locale provided to this class's constructor.</para><para>The returned values may be obtained by means of a network lookup. The results are a best guess and are not guaranteed to be meaningful or correct. It may be useful to call this method from a thread separate from your primary UI thread.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of Address objects. Returns null or empty list if no matches were found or there is no backend service available.</para>
				/// </returns>
				/// <java-name>
				/// getFromLocation
				/// </java-name>
				[Dot42.DexImport("getFromLocation", "(DDI)Ljava/util/List;", AccessFlags = 1, Signature = "(DDI)Ljava/util/List<Landroid/location/Address;>;")]
				public global::Java.Util.IList<global::Android.Location.Address> GetFromLocation(double latitude, double longitude, int maxResults) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Location.Address>);
				}

				/// <summary>
				/// <para>Returns an array of Addresses that are known to describe the named location, which may be a place name such as "Dalvik,       Iceland", an address such as "1600 Amphitheatre Parkway,       Mountain View, CA", an airport code such as "SFO", etc.. The returned addresses will be localized for the locale provided to this class's constructor.</para><para>The query will block and returned values will be obtained by means of a network lookup. The results are a best guess and are not guaranteed to be meaningful or correct. It may be useful to call this method from a thread separate from your primary UI thread.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of Address objects. Returns null or empty list if no matches were found or there is no backend service available.</para>
				/// </returns>
				/// <java-name>
				/// getFromLocationName
				/// </java-name>
				[Dot42.DexImport("getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/location/Address;>;")]
				public global::Java.Util.IList<global::Android.Location.Address> GetFromLocationName(string locationName, int maxResults) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Location.Address>);
				}

				/// <summary>
				/// <para>Returns an array of Addresses that are known to describe the named location, which may be a place name such as "Dalvik,       Iceland", an address such as "1600 Amphitheatre Parkway,       Mountain View, CA", an airport code such as "SFO", etc.. The returned addresses will be localized for the locale provided to this class's constructor.</para><para>You may specify a bounding box for the search results by including the Latitude and Longitude of the Lower Left point and Upper Right point of the box.</para><para>The query will block and returned values will be obtained by means of a network lookup. The results are a best guess and are not guaranteed to be meaningful or correct. It may be useful to call this method from a thread separate from your primary UI thread.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of Address objects. Returns null or empty list if no matches were found or there is no backend service available.</para>
				/// </returns>
				/// <java-name>
				/// getFromLocationName
				/// </java-name>
				[Dot42.DexImport("getFromLocationName", "(Ljava/lang/String;IDDDD)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;IDDDD)Ljava/util/List<Landroid/location/Address;>;")]
				public global::Java.Util.IList<global::Android.Location.Address> GetFromLocationName(string locationName, int maxResults, double lowerLeftLatitude, double lowerLeftLongitude, double upperRightLatitude, double upperRightLongitude) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Location.Address>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Geocoder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides access to the system location services. These services allow applications to obtain periodic updates of the device's geographical location, or to fire an application-specified Intent when the device enters the proximity of a given geographical location.</para><para>You do not instantiate this class directly; instead, retrieve it through Context.getSystemService(Context.LOCATION_SERVICE).</para><para>Unless noted, all Location API methods require the android.Manifest.permission#ACCESS_COARSE_LOCATION or android.Manifest.permission#ACCESS_FINE_LOCATION permissions. If your application only has the coarse permission then it will not have access to the GPS or passive location providers. Other providers will still return location results, but the update rate will be throttled and the exact location will be obfuscated to a coarse level of accuracy. </para>    
		/// </summary>
		/// <java-name>
		/// android/location/LocationManager
		/// </java-name>
		[Dot42.DexImport("android/location/LocationManager", AccessFlags = 33)]
		public partial class LocationManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Name of the network location provider. </para><para>This provider determines location based on availability of cell tower and WiFi access points. Results are retrieved by means of a network lookup. </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_PROVIDER
				/// </java-name>
				[Dot42.DexImport("NETWORK_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NETWORK_PROVIDER = "network";
				/// <summary>
				/// <para>Name of the GPS location provider.</para><para>This provider determines location using satellites. Depending on conditions, this provider may take a while to return a location fix. Requires the permission android.Manifest.permission#ACCESS_FINE_LOCATION.</para><para>The extras Bundle for the GPS location provider can contain the following key/value pairs: <ul><li><para>satellites - the number of satellites used to derive the fix </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// GPS_PROVIDER
				/// </java-name>
				[Dot42.DexImport("GPS_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string GPS_PROVIDER = "gps";
				/// <summary>
				/// <para>A special location provider for receiving locations without actually initiating a location fix.</para><para>This provider can be used to passively receive location updates when other applications or services request them without actually requesting the locations yourself. This provider will return locations generated by other providers. You can query the Location#getProvider() method to determine the origin of the location update. Requires the permission android.Manifest.permission#ACCESS_FINE_LOCATION, although if the GPS is not enabled this provider might only return coarse fixes. </para>        
				/// </summary>
				/// <java-name>
				/// PASSIVE_PROVIDER
				/// </java-name>
				[Dot42.DexImport("PASSIVE_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PASSIVE_PROVIDER = "passive";
				/// <summary>
				/// <para>Key used for the Bundle extra holding a boolean indicating whether a proximity alert is entering (true) or exiting (false).. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_PROXIMITY_ENTERING
				/// </java-name>
				[Dot42.DexImport("KEY_PROXIMITY_ENTERING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_PROXIMITY_ENTERING = "entering";
				/// <summary>
				/// <para>Key used for a Bundle extra holding an Integer status value when a status change is broadcast using a PendingIntent. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_STATUS_CHANGED
				/// </java-name>
				[Dot42.DexImport("KEY_STATUS_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_STATUS_CHANGED = "status";
				/// <summary>
				/// <para>Key used for a Bundle extra holding an Boolean status value when a provider enabled/disabled event is broadcast using a PendingIntent. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_PROVIDER_ENABLED
				/// </java-name>
				[Dot42.DexImport("KEY_PROVIDER_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_PROVIDER_ENABLED = "providerEnabled";
				/// <summary>
				/// <para>Key used for a Bundle extra holding a Location value when a location change is broadcast using a PendingIntent. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_LOCATION_CHANGED
				/// </java-name>
				[Dot42.DexImport("KEY_LOCATION_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_LOCATION_CHANGED = "location";
				/// <summary>
				/// <para>Broadcast intent action when the configured location providers change. </para>        
				/// </summary>
				/// <java-name>
				/// PROVIDERS_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("PROVIDERS_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROVIDERS_CHANGED_ACTION = "android.location.PROVIDERS_CHANGED";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LocationManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a list of the names of all known location providers. </para><para>All providers are returned, including ones that are not permitted to be accessed by the calling activity or are currently disabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of Strings containing names of the provider </para>
				/// </returns>
				/// <java-name>
				/// getAllProviders
				/// </java-name>
				[Dot42.DexImport("getAllProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IList<string> GetAllProviders() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <summary>
				/// <para>Returns a list of the names of location providers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of Strings containing names of the providers </para>
				/// </returns>
				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "(Z)Ljava/util/List;", AccessFlags = 1, Signature = "(Z)Ljava/util/List<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IList<string> GetProviders(bool enabledOnly) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <summary>
				/// <para>Returns the information associated with the location provider of the given name, or null if no provider exists by that name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a LocationProvider, or null</para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "(Ljava/lang/String;)Landroid/location/LocationProvider;", AccessFlags = 1)]
				public virtual global::Android.Location.LocationProvider GetProvider(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Location.LocationProvider);
				}

				/// <summary>
				/// <para>Returns a list of the names of LocationProviders that satisfy the given criteria, or null if none do. Only providers that are permitted to be accessed by the calling activity will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of Strings containing names of the providers </para>
				/// </returns>
				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "(Landroid/location/Criteria;Z)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/location/Criteria;Z)Ljava/util/List<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IList<string> GetProviders(global::Android.Location.Criteria criteria, bool enabledOnly) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <summary>
				/// <para>Returns the name of the provider that best meets the given criteria. Only providers that are permitted to be accessed by the calling activity will be returned. If several providers meet the criteria, the one with the best accuracy is returned. If no provider meets the criteria, the criteria are loosened in the following sequence:</para><para><ul><li><para>power requirement </para></li><li><para>accuracy </para></li><li><para>bearing </para></li><li><para>speed </para></li><li><para>altitude </para></li></ul></para><para>Note that the requirement on monetary cost is not removed in this process.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>name of the provider that best matches the requirements </para>
				/// </returns>
				/// <java-name>
				/// getBestProvider
				/// </java-name>
				[Dot42.DexImport("getBestProvider", "(Landroid/location/Criteria;Z)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetBestProvider(global::Android.Location.Criteria criteria, bool enabledOnly) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(string request, long listener, float looper, global::Android.Location.ILocationListener intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;Landroid/os/Looper;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(string @string, long int64, float single, global::Android.Location.ILocationListener locationListener, global::Android.Os.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(JFLandroid/location/Criteria;Landroid/location/LocationListener;Landroid/os/Loop" +
    "er;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(long int64, float single, global::Android.Location.Criteria criteria, global::Android.Location.ILocationListener locationListener, global::Android.Os.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(Ljava/lang/String;JFLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(string request, long listener, float looper, global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(JFLandroid/location/Criteria;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(long request, float listener, global::Android.Location.Criteria looper, global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register for a single location update using a Criteria and a callback.</para><para>See requestLocationUpdates(long, float, Criteria, PendingIntent) for more detail on how to use this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// requestSingleUpdate
				/// </java-name>
				[Dot42.DexImport("requestSingleUpdate", "(Ljava/lang/String;Landroid/location/LocationListener;Landroid/os/Looper;)V", AccessFlags = 1)]
				public virtual void RequestSingleUpdate(string criteria, global::Android.Location.ILocationListener listener, global::Android.Os.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register for a single location update using a Criteria and a callback.</para><para>See requestLocationUpdates(long, float, Criteria, PendingIntent) for more detail on how to use this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// requestSingleUpdate
				/// </java-name>
				[Dot42.DexImport("requestSingleUpdate", "(Landroid/location/Criteria;Landroid/location/LocationListener;Landroid/os/Looper" +
    ";)V", AccessFlags = 1)]
				public virtual void RequestSingleUpdate(global::Android.Location.Criteria criteria, global::Android.Location.ILocationListener listener, global::Android.Os.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register for a single location update using a Criteria and pending intent.</para><para>See requestLocationUpdates(long, float, Criteria, PendingIntent) for more detail on how to use this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// requestSingleUpdate
				/// </java-name>
				[Dot42.DexImport("requestSingleUpdate", "(Ljava/lang/String;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestSingleUpdate(string criteria, global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register for a single location update using a Criteria and pending intent.</para><para>See requestLocationUpdates(long, float, Criteria, PendingIntent) for more detail on how to use this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// requestSingleUpdate
				/// </java-name>
				[Dot42.DexImport("requestSingleUpdate", "(Landroid/location/Criteria;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestSingleUpdate(global::Android.Location.Criteria criteria, global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all location updates for the specified LocationListener.</para><para>Following this call, updates will no longer occur for this listener.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeUpdates
				/// </java-name>
				[Dot42.DexImport("removeUpdates", "(Landroid/location/LocationListener;)V", AccessFlags = 1)]
				public virtual void RemoveUpdates(global::Android.Location.ILocationListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all location updates for the specified LocationListener.</para><para>Following this call, updates will no longer occur for this listener.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeUpdates
				/// </java-name>
				[Dot42.DexImport("removeUpdates", "(Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RemoveUpdates(global::Android.App.PendingIntent listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set a proximity alert for the location given by the position (latitude, longitude) and the given radius.</para><para>When the device detects that it has entered or exited the area surrounding the location, the given PendingIntent will be used to create an Intent to be fired.</para><para>The fired Intent will have a boolean extra added with key KEY_PROXIMITY_ENTERING. If the value is true, the device is entering the proximity region; if false, it is exiting.</para><para>Due to the approximate nature of position estimation, if the device passes through the given area briefly, it is possible that no Intent will be fired. Similarly, an Intent could be fired if the device passes very close to the given area but does not actually enter it.</para><para>After the number of milliseconds given by the expiration parameter, the location manager will delete this proximity alert and no longer monitor it. A value of -1 indicates that there should be no expiration time.</para><para>Internally, this method uses both NETWORK_PROVIDER and GPS_PROVIDER.</para><para>Before API version 17, this method could be used with android.Manifest.permission#ACCESS_FINE_LOCATION or android.Manifest.permission#ACCESS_COARSE_LOCATION. From API version 17 and onwards, this method requires android.Manifest.permission#ACCESS_FINE_LOCATION permission.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addProximityAlert
				/// </java-name>
				[Dot42.DexImport("addProximityAlert", "(DDFJLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void AddProximityAlert(double latitude, double longitude, float radius, long expiration, global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the proximity alert with the given PendingIntent.</para><para>Before API version 17, this method could be used with android.Manifest.permission#ACCESS_FINE_LOCATION or android.Manifest.permission#ACCESS_COARSE_LOCATION. From API version 17 and onwards, this method requires android.Manifest.permission#ACCESS_FINE_LOCATION permission.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeProximityAlert
				/// </java-name>
				[Dot42.DexImport("removeProximityAlert", "(Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RemoveProximityAlert(global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current enabled/disabled status of the given provider.</para><para>If the user has enabled this provider in the Settings menu, true is returned otherwise false is returned</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the provider is enabled</para>
				/// </returns>
				/// <java-name>
				/// isProviderEnabled
				/// </java-name>
				[Dot42.DexImport("isProviderEnabled", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsProviderEnabled(string provider) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a Location indicating the data from the last known location fix obtained from the given provider.</para><para>This can be done without starting the provider. Note that this location could be out-of-date, for example if the device was turned off and moved to another location.</para><para>If the provider is currently disabled, null is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last known location for the provider, or null</para>
				/// </returns>
				/// <java-name>
				/// getLastKnownLocation
				/// </java-name>
				[Dot42.DexImport("getLastKnownLocation", "(Ljava/lang/String;)Landroid/location/Location;", AccessFlags = 1)]
				public virtual global::Android.Location.Location GetLastKnownLocation(string provider) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Location.Location);
				}

				/// <summary>
				/// <para>Creates a mock location provider and adds it to the set of active providers.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addTestProvider
				/// </java-name>
				[Dot42.DexImport("addTestProvider", "(Ljava/lang/String;ZZZZZZZII)V", AccessFlags = 1)]
				public virtual void AddTestProvider(string name, bool requiresNetwork, bool requiresSatellite, bool requiresCell, bool hasMonetaryCost, bool supportsAltitude, bool supportsSpeed, bool supportsBearing, int powerRequirement, int accuracy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the mock location provider with the given name.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeTestProvider
				/// </java-name>
				[Dot42.DexImport("removeTestProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveTestProvider(string provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a mock location for the given provider. </para><para>This location will be used in place of any actual location from the provider. The location object must have a minimum number of fields set to be considered a valid LocationProvider Location, as per documentation on Location class.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTestProviderLocation
				/// </java-name>
				[Dot42.DexImport("setTestProviderLocation", "(Ljava/lang/String;Landroid/location/Location;)V", AccessFlags = 1)]
				public virtual void SetTestProviderLocation(string provider, global::Android.Location.Location loc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes any mock location associated with the given provider.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clearTestProviderLocation
				/// </java-name>
				[Dot42.DexImport("clearTestProviderLocation", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ClearTestProviderLocation(string provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a mock enabled value for the given provider. This value will be used in place of any actual value from the provider.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTestProviderEnabled
				/// </java-name>
				[Dot42.DexImport("setTestProviderEnabled", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetTestProviderEnabled(string provider, bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes any mock enabled value associated with the given provider.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clearTestProviderEnabled
				/// </java-name>
				[Dot42.DexImport("clearTestProviderEnabled", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ClearTestProviderEnabled(string provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets mock status values for the given provider. These values will be used in place of any actual values from the provider.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTestProviderStatus
				/// </java-name>
				[Dot42.DexImport("setTestProviderStatus", "(Ljava/lang/String;ILandroid/os/Bundle;J)V", AccessFlags = 1)]
				public virtual void SetTestProviderStatus(string provider, int status, global::Android.Os.Bundle extras, long updateTime) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes any mock status values associated with the given provider.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clearTestProviderStatus
				/// </java-name>
				[Dot42.DexImport("clearTestProviderStatus", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ClearTestProviderStatus(string provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a GPS status listener.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the listener was successfully added</para>
				/// </returns>
				/// <java-name>
				/// addGpsStatusListener
				/// </java-name>
				[Dot42.DexImport("addGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)Z", AccessFlags = 1)]
				public virtual bool AddGpsStatusListener(global::Android.Location.GpsStatus.IListener listener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes a GPS status listener.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeGpsStatusListener
				/// </java-name>
				[Dot42.DexImport("removeGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)V", AccessFlags = 1)]
				public virtual void RemoveGpsStatusListener(global::Android.Location.GpsStatus.IListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds an NMEA listener.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the listener was successfully added</para>
				/// </returns>
				/// <java-name>
				/// addNmeaListener
				/// </java-name>
				[Dot42.DexImport("addNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)Z", AccessFlags = 1)]
				public virtual bool AddNmeaListener(global::Android.Location.GpsStatus.INmeaListener listener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes an NMEA listener.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeNmeaListener
				/// </java-name>
				[Dot42.DexImport("removeNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)V", AccessFlags = 1)]
				public virtual void RemoveNmeaListener(global::Android.Location.GpsStatus.INmeaListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retrieves information about the current status of the GPS engine. This should only be called from the GpsStatus.Listener#onGpsStatusChanged callback to ensure that the data is copied atomically.</para><para>The caller may either pass in a GpsStatus object to set with the latest status information, or pass null to create a new GpsStatus object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>status object containing updated GPS status. </para>
				/// </returns>
				/// <java-name>
				/// getGpsStatus
				/// </java-name>
				[Dot42.DexImport("getGpsStatus", "(Landroid/location/GpsStatus;)Landroid/location/GpsStatus;", AccessFlags = 1)]
				public virtual global::Android.Location.GpsStatus GetGpsStatus(global::Android.Location.GpsStatus status) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Location.GpsStatus);
				}

				/// <summary>
				/// <para>Sends additional commands to a location provider. Can be used to support provider specific extensions to the Location Manager API</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the command succeeds. </para>
				/// </returns>
				/// <java-name>
				/// sendExtraCommand
				/// </java-name>
				[Dot42.DexImport("sendExtraCommand", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool SendExtraCommand(string provider, string command, global::Android.Os.Bundle extras) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a list of the names of all known location providers. </para><para>All providers are returned, including ones that are not permitted to be accessed by the calling activity or are currently disabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of Strings containing names of the provider </para>
				/// </returns>
				/// <java-name>
				/// getAllProviders
				/// </java-name>
				public global::Java.Util.IList<string> AllProviders
				{
				[Dot42.DexImport("getAllProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return GetAllProviders(); }
				}

		}

		/// <summary>
		/// <para>This class represents the current state of a GPS satellite. This class is used in conjunction with the GpsStatus class. </para>    
		/// </summary>
		/// <java-name>
		/// android/location/GpsSatellite
		/// </java-name>
		[Dot42.DexImport("android/location/GpsSatellite", AccessFlags = 49)]
		public sealed partial class GpsSatellite
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal GpsSatellite() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the PRN (pseudo-random number) for the satellite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>PRN number </para>
				/// </returns>
				/// <java-name>
				/// getPrn
				/// </java-name>
				[Dot42.DexImport("getPrn", "()I", AccessFlags = 1)]
				public int GetPrn() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the signal to noise ratio for the satellite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the signal to noise ratio </para>
				/// </returns>
				/// <java-name>
				/// getSnr
				/// </java-name>
				[Dot42.DexImport("getSnr", "()F", AccessFlags = 1)]
				public float GetSnr() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the elevation of the satellite in degrees. The elevation can vary between 0 and 90.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the elevation in degrees </para>
				/// </returns>
				/// <java-name>
				/// getElevation
				/// </java-name>
				[Dot42.DexImport("getElevation", "()F", AccessFlags = 1)]
				public float GetElevation() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the azimuth of the satellite in degrees. The azimuth can vary between 0 and 360.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the azimuth in degrees </para>
				/// </returns>
				/// <java-name>
				/// getAzimuth
				/// </java-name>
				[Dot42.DexImport("getAzimuth", "()F", AccessFlags = 1)]
				public float GetAzimuth() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns true if the GPS engine has ephemeris data for the satellite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the satellite has ephemeris data </para>
				/// </returns>
				/// <java-name>
				/// hasEphemeris
				/// </java-name>
				[Dot42.DexImport("hasEphemeris", "()Z", AccessFlags = 1)]
				public bool HasEphemeris() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if the GPS engine has almanac data for the satellite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the satellite has almanac data </para>
				/// </returns>
				/// <java-name>
				/// hasAlmanac
				/// </java-name>
				[Dot42.DexImport("hasAlmanac", "()Z", AccessFlags = 1)]
				public bool HasAlmanac() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if the satellite was used by the GPS engine when calculating the most recent GPS fix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the satellite was used to compute the most recent fix. </para>
				/// </returns>
				/// <java-name>
				/// usedInFix
				/// </java-name>
				[Dot42.DexImport("usedInFix", "()Z", AccessFlags = 1)]
				public bool UsedInFix() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the PRN (pseudo-random number) for the satellite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>PRN number </para>
				/// </returns>
				/// <java-name>
				/// getPrn
				/// </java-name>
				public int Prn
				{
				[Dot42.DexImport("getPrn", "()I", AccessFlags = 1)]
						get{ return GetPrn(); }
				}

				/// <summary>
				/// <para>Returns the signal to noise ratio for the satellite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the signal to noise ratio </para>
				/// </returns>
				/// <java-name>
				/// getSnr
				/// </java-name>
				public float Snr
				{
				[Dot42.DexImport("getSnr", "()F", AccessFlags = 1)]
						get{ return GetSnr(); }
				}

				/// <summary>
				/// <para>Returns the elevation of the satellite in degrees. The elevation can vary between 0 and 90.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the elevation in degrees </para>
				/// </returns>
				/// <java-name>
				/// getElevation
				/// </java-name>
				public float Elevation
				{
				[Dot42.DexImport("getElevation", "()F", AccessFlags = 1)]
						get{ return GetElevation(); }
				}

				/// <summary>
				/// <para>Returns the azimuth of the satellite in degrees. The azimuth can vary between 0 and 360.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the azimuth in degrees </para>
				/// </returns>
				/// <java-name>
				/// getAzimuth
				/// </java-name>
				public float Azimuth
				{
				[Dot42.DexImport("getAzimuth", "()F", AccessFlags = 1)]
						get{ return GetAzimuth(); }
				}

		}

		/// <summary>
		/// <para>Used for receiving notifications from the LocationManager when the location has changed. These methods are called if the LocationListener has been registered with the location manager service using the LocationManager#requestLocationUpdates(String, long, float, LocationListener) method.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about identifying user location, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/location/LocationListener
		/// </java-name>
		[Dot42.DexImport("android/location/LocationListener", AccessFlags = 1537)]
		public partial interface ILocationListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called when the location has changed.</para><para>There are no restrictions on the use of the supplied Location object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onLocationChanged
				/// </java-name>
				[Dot42.DexImport("onLocationChanged", "(Landroid/location/Location;)V", AccessFlags = 1025)]
				void OnLocationChanged(global::Android.Location.Location location) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the provider status changes. This method is called when a provider is unable to fetch a location or if the provider has recently become available after a period of unavailability.</para><para></para><para>A number of common key/value pairs for the extras Bundle are listed below. Providers that use any of the keys on this list must provide the corresponding value as described below.</para><para><ul><li><para>satellites - the number of satellites used to derive the fix </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// onStatusChanged
				/// </java-name>
				[Dot42.DexImport("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnStatusChanged(string provider, int status, global::Android.Os.Bundle extras) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the provider is enabled by the user.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onProviderEnabled
				/// </java-name>
				[Dot42.DexImport("onProviderEnabled", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void OnProviderEnabled(string provider) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the provider is disabled by the user. If requestLocationUpdates is called on an already disabled provider, this method is called immediately.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onProviderDisabled
				/// </java-name>
				[Dot42.DexImport("onProviderDisabled", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void OnProviderDisabled(string provider) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An abstract superclass for location providers. A location provider provides periodic reports on the geographical location of the device.</para><para>Each provider has a set of criteria under which it may be used; for example, some providers require GPS hardware and visibility to a number of satellites; others require the use of the cellular radio, or access to a specific carrier's network, or to the internet. They may also have different battery consumption characteristics or monetary costs to the user. The Criteria class allows providers to be selected based on user-specified criteria. </para>    
		/// </summary>
		/// <java-name>
		/// android/location/LocationProvider
		/// </java-name>
		[Dot42.DexImport("android/location/LocationProvider", AccessFlags = 1057)]
		public abstract partial class LocationProvider
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OUT_OF_SERVICE
				/// </java-name>
				[Dot42.DexImport("OUT_OF_SERVICE", "I", AccessFlags = 25)]
				public const int OUT_OF_SERVICE = 0;
				/// <java-name>
				/// TEMPORARILY_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("TEMPORARILY_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int TEMPORARILY_UNAVAILABLE = 1;
				/// <java-name>
				/// AVAILABLE
				/// </java-name>
				[Dot42.DexImport("AVAILABLE", "I", AccessFlags = 25)]
				public const int AVAILABLE = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LocationProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this provider. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns true if this provider meets the given criteria, false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// meetsCriteria
				/// </java-name>
				[Dot42.DexImport("meetsCriteria", "(Landroid/location/Criteria;)Z", AccessFlags = 1)]
				public virtual bool MeetsCriteria(global::Android.Location.Criteria criteria) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if the provider requires access to a data network (e.g., the Internet), false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// requiresNetwork
				/// </java-name>
				[Dot42.DexImport("requiresNetwork", "()Z", AccessFlags = 1025)]
				public abstract bool RequiresNetwork() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the provider requires access to a satellite-based positioning system (e.g., GPS), false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// requiresSatellite
				/// </java-name>
				[Dot42.DexImport("requiresSatellite", "()Z", AccessFlags = 1025)]
				public abstract bool RequiresSatellite() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the provider requires access to an appropriate cellular network (e.g., to make use of cell tower IDs), false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// requiresCell
				/// </java-name>
				[Dot42.DexImport("requiresCell", "()Z", AccessFlags = 1025)]
				public abstract bool RequiresCell() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the use of this provider may result in a monetary charge to the user, false if use is free. It is up to each provider to give accurate information. </para>        
				/// </summary>
				/// <java-name>
				/// hasMonetaryCost
				/// </java-name>
				[Dot42.DexImport("hasMonetaryCost", "()Z", AccessFlags = 1025)]
				public abstract bool HasMonetaryCost() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the provider is able to provide altitude information, false otherwise. A provider that reports altitude under most circumstances but may occassionally not report it should return true. </para>        
				/// </summary>
				/// <java-name>
				/// supportsAltitude
				/// </java-name>
				[Dot42.DexImport("supportsAltitude", "()Z", AccessFlags = 1025)]
				public abstract bool SupportsAltitude() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the provider is able to provide speed information, false otherwise. A provider that reports speed under most circumstances but may occassionally not report it should return true. </para>        
				/// </summary>
				/// <java-name>
				/// supportsSpeed
				/// </java-name>
				[Dot42.DexImport("supportsSpeed", "()Z", AccessFlags = 1025)]
				public abstract bool SupportsSpeed() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the provider is able to provide bearing information, false otherwise. A provider that reports bearing under most circumstances but may occassionally not report it should return true. </para>        
				/// </summary>
				/// <java-name>
				/// supportsBearing
				/// </java-name>
				[Dot42.DexImport("supportsBearing", "()Z", AccessFlags = 1025)]
				public abstract bool SupportsBearing() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the power requirement for this provider.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the power requirement for this provider, as one of the constants Criteria.POWER_REQUIREMENT_*. </para>
				/// </returns>
				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1025)]
				public abstract int GetPowerRequirement() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a constant describing horizontal accuracy of this provider. If the provider returns finer grain or exact location, Criteria#ACCURACY_FINE is returned, otherwise if the location is only approximate then Criteria#ACCURACY_COARSE is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getAccuracy
				/// </java-name>
				[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1025)]
				public abstract int GetAccuracy() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of this provider. </para>        
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
				/// <para>Returns the power requirement for this provider.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the power requirement for this provider, as one of the constants Criteria.POWER_REQUIREMENT_*. </para>
				/// </returns>
				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				public int PowerRequirement
				{
				[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1025)]
						get{ return GetPowerRequirement(); }
				}

				/// <summary>
				/// <para>Returns a constant describing horizontal accuracy of this provider. If the provider returns finer grain or exact location, Criteria#ACCURACY_FINE is returned, otherwise if the location is only approximate then Criteria#ACCURACY_COARSE is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public int Accuracy
				{
				[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1025)]
						get{ return GetAccuracy(); }
				}

		}

		/// <summary>
		/// <para>A class indicating the application criteria for selecting a location provider. Providers maybe ordered according to accuracy, power usage, ability to report altitude, speed, and bearing, and monetary cost. </para>    
		/// </summary>
		/// <java-name>
		/// android/location/Criteria
		/// </java-name>
		[Dot42.DexImport("android/location/Criteria", AccessFlags = 33)]
		public partial class Criteria : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A constant indicating that the application does not choose to place requirement on a particular feature. </para>        
				/// </summary>
				/// <java-name>
				/// NO_REQUIREMENT
				/// </java-name>
				[Dot42.DexImport("NO_REQUIREMENT", "I", AccessFlags = 25)]
				public const int NO_REQUIREMENT = 0;
				/// <summary>
				/// <para>A constant indicating a low power requirement. </para>        
				/// </summary>
				/// <java-name>
				/// POWER_LOW
				/// </java-name>
				[Dot42.DexImport("POWER_LOW", "I", AccessFlags = 25)]
				public const int POWER_LOW = 1;
				/// <summary>
				/// <para>A constant indicating a medium power requirement. </para>        
				/// </summary>
				/// <java-name>
				/// POWER_MEDIUM
				/// </java-name>
				[Dot42.DexImport("POWER_MEDIUM", "I", AccessFlags = 25)]
				public const int POWER_MEDIUM = 2;
				/// <summary>
				/// <para>A constant indicating a high power requirement. </para>        
				/// </summary>
				/// <java-name>
				/// POWER_HIGH
				/// </java-name>
				[Dot42.DexImport("POWER_HIGH", "I", AccessFlags = 25)]
				public const int POWER_HIGH = 3;
				/// <summary>
				/// <para>A constant indicating a finer location accuracy requirement </para>        
				/// </summary>
				/// <java-name>
				/// ACCURACY_FINE
				/// </java-name>
				[Dot42.DexImport("ACCURACY_FINE", "I", AccessFlags = 25)]
				public const int ACCURACY_FINE = 1;
				/// <summary>
				/// <para>A constant indicating an approximate accuracy requirement </para>        
				/// </summary>
				/// <java-name>
				/// ACCURACY_COARSE
				/// </java-name>
				[Dot42.DexImport("ACCURACY_COARSE", "I", AccessFlags = 25)]
				public const int ACCURACY_COARSE = 2;
				/// <summary>
				/// <para>A constant indicating a low location accuracy requirement<ul><li><para>may be used for horizontal, altitude, speed or bearing accuracy. For horizontal and vertical position this corresponds roughly to an accuracy of greater than 500 meters. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACCURACY_LOW
				/// </java-name>
				[Dot42.DexImport("ACCURACY_LOW", "I", AccessFlags = 25)]
				public const int ACCURACY_LOW = 1;
				/// <summary>
				/// <para>A constant indicating a medium accuracy requirement<ul><li><para>currently used only for horizontal accuracy. For horizontal position this corresponds roughly to to an accuracy of between 100 and 500 meters. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACCURACY_MEDIUM
				/// </java-name>
				[Dot42.DexImport("ACCURACY_MEDIUM", "I", AccessFlags = 25)]
				public const int ACCURACY_MEDIUM = 2;
				/// <summary>
				/// <para>a constant indicating a high accuracy requirement<ul><li><para>may be used for horizontal, altitude, speed or bearing accuracy. For horizontal and vertical position this corresponds roughly to an accuracy of less than 100 meters. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACCURACY_HIGH
				/// </java-name>
				[Dot42.DexImport("ACCURACY_HIGH", "I", AccessFlags = 25)]
				public const int ACCURACY_HIGH = 3;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Location.Criteria> CREATOR;
				/// <summary>
				/// <para>Constructs a new Criteria object. The new object will have no requirements on accuracy, power, or response time; will not require altitude, speed, or bearing; and will not allow monetary cost. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Criteria() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new Criteria object that is a copy of the given criteria. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/location/Criteria;)V", AccessFlags = 1)]
				public Criteria(global::Android.Location.Criteria criteria) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates the desired horizontal accuracy (latitude and longitude). Accuracy may be ACCURACY_LOW, ACCURACY_MEDIUM, ACCURACY_HIGH or NO_REQUIREMENT. More accurate location may consume more power and may take longer.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHorizontalAccuracy
				/// </java-name>
				[Dot42.DexImport("setHorizontalAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetHorizontalAccuracy(int accuracy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired horizontal accuracy (latitude and longitude). Accuracy may be ACCURACY_LOW, ACCURACY_MEDIUM, ACCURACY_HIGH or NO_REQUIREMENT. </para>        
				/// </summary>
				/// <java-name>
				/// getHorizontalAccuracy
				/// </java-name>
				[Dot42.DexImport("getHorizontalAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetHorizontalAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates the desired vertical accuracy (altitude). Accuracy may be ACCURACY_LOW, ACCURACY_MEDIUM, ACCURACY_HIGH or NO_REQUIREMENT. More accurate location may consume more power and may take longer.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setVerticalAccuracy
				/// </java-name>
				[Dot42.DexImport("setVerticalAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalAccuracy(int accuracy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired vertical accuracy (altitude). Accuracy may be ACCURACY_LOW, ACCURACY_HIGH, or NO_REQUIREMENT. </para>        
				/// </summary>
				/// <java-name>
				/// getVerticalAccuracy
				/// </java-name>
				[Dot42.DexImport("getVerticalAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetVerticalAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates the desired speed accuracy. Accuracy may be ACCURACY_LOW, ACCURACY_HIGH, or NO_REQUIREMENT. More accurate location may consume more power and may take longer.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSpeedAccuracy
				/// </java-name>
				[Dot42.DexImport("setSpeedAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetSpeedAccuracy(int accuracy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired speed accuracy Accuracy may be ACCURACY_LOW, ACCURACY_HIGH, or NO_REQUIREMENT. </para>        
				/// </summary>
				/// <java-name>
				/// getSpeedAccuracy
				/// </java-name>
				[Dot42.DexImport("getSpeedAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetSpeedAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates the desired bearing accuracy. Accuracy may be ACCURACY_LOW, ACCURACY_HIGH, or NO_REQUIREMENT. More accurate location may consume more power and may take longer.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBearingAccuracy
				/// </java-name>
				[Dot42.DexImport("setBearingAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetBearingAccuracy(int accuracy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired bearing accuracy. Accuracy may be ACCURACY_LOW, ACCURACY_HIGH, or NO_REQUIREMENT. </para>        
				/// </summary>
				/// <java-name>
				/// getBearingAccuracy
				/// </java-name>
				[Dot42.DexImport("getBearingAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetBearingAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates the desired accuracy for latitude and longitude. Accuracy may be ACCURACY_FINE if desired location is fine, else it can be ACCURACY_COARSE. More accurate location may consume more power and may take longer.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAccuracy
				/// </java-name>
				[Dot42.DexImport("setAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetAccuracy(int accuracy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a constant indicating desired accuracy of location Accuracy may be ACCURACY_FINE if desired location is fine, else it can be ACCURACY_COARSE. </para>        
				/// </summary>
				/// <java-name>
				/// getAccuracy
				/// </java-name>
				[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates the desired maximum power level. The level parameter must be one of NO_REQUIREMENT, POWER_LOW, POWER_MEDIUM, or POWER_HIGH. </para>        
				/// </summary>
				/// <java-name>
				/// setPowerRequirement
				/// </java-name>
				[Dot42.DexImport("setPowerRequirement", "(I)V", AccessFlags = 1)]
				public virtual void SetPowerRequirement(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired power requirement. The returned </para>        
				/// </summary>
				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1)]
				public virtual int GetPowerRequirement() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether the provider is allowed to incur monetary cost. </para>        
				/// </summary>
				/// <java-name>
				/// setCostAllowed
				/// </java-name>
				[Dot42.DexImport("setCostAllowed", "(Z)V", AccessFlags = 1)]
				public virtual void SetCostAllowed(bool costAllowed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the provider is allowed to incur monetary cost. </para>        
				/// </summary>
				/// <java-name>
				/// isCostAllowed
				/// </java-name>
				[Dot42.DexImport("isCostAllowed", "()Z", AccessFlags = 1)]
				public virtual bool IsCostAllowed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the provider must provide altitude information. Not all fixes are guaranteed to contain such information. </para>        
				/// </summary>
				/// <java-name>
				/// setAltitudeRequired
				/// </java-name>
				[Dot42.DexImport("setAltitudeRequired", "(Z)V", AccessFlags = 1)]
				public virtual void SetAltitudeRequired(bool altitudeRequired) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the provider must provide altitude information. Not all fixes are guaranteed to contain such information. </para>        
				/// </summary>
				/// <java-name>
				/// isAltitudeRequired
				/// </java-name>
				[Dot42.DexImport("isAltitudeRequired", "()Z", AccessFlags = 1)]
				public virtual bool IsAltitudeRequired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the provider must provide speed information. Not all fixes are guaranteed to contain such information. </para>        
				/// </summary>
				/// <java-name>
				/// setSpeedRequired
				/// </java-name>
				[Dot42.DexImport("setSpeedRequired", "(Z)V", AccessFlags = 1)]
				public virtual void SetSpeedRequired(bool speedRequired) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the provider must provide speed information. Not all fixes are guaranteed to contain such information. </para>        
				/// </summary>
				/// <java-name>
				/// isSpeedRequired
				/// </java-name>
				[Dot42.DexImport("isSpeedRequired", "()Z", AccessFlags = 1)]
				public virtual bool IsSpeedRequired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the provider must provide bearing information. Not all fixes are guaranteed to contain such information. </para>        
				/// </summary>
				/// <java-name>
				/// setBearingRequired
				/// </java-name>
				[Dot42.DexImport("setBearingRequired", "(Z)V", AccessFlags = 1)]
				public virtual void SetBearingRequired(bool bearingRequired) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the provider must provide bearing information. Not all fixes are guaranteed to contain such information. </para>        
				/// </summary>
				/// <java-name>
				/// isBearingRequired
				/// </java-name>
				[Dot42.DexImport("isBearingRequired", "()Z", AccessFlags = 1)]
				public virtual bool IsBearingRequired() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired horizontal accuracy (latitude and longitude). Accuracy may be ACCURACY_LOW, ACCURACY_MEDIUM, ACCURACY_HIGH or NO_REQUIREMENT. </para>        
				/// </summary>
				/// <java-name>
				/// getHorizontalAccuracy
				/// </java-name>
				public int HorizontalAccuracy
				{
				[Dot42.DexImport("getHorizontalAccuracy", "()I", AccessFlags = 1)]
						get{ return GetHorizontalAccuracy(); }
				[Dot42.DexImport("setHorizontalAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetHorizontalAccuracy(value); }
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired vertical accuracy (altitude). Accuracy may be ACCURACY_LOW, ACCURACY_HIGH, or NO_REQUIREMENT. </para>        
				/// </summary>
				/// <java-name>
				/// getVerticalAccuracy
				/// </java-name>
				public int VerticalAccuracy
				{
				[Dot42.DexImport("getVerticalAccuracy", "()I", AccessFlags = 1)]
						get{ return GetVerticalAccuracy(); }
				[Dot42.DexImport("setVerticalAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetVerticalAccuracy(value); }
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired speed accuracy Accuracy may be ACCURACY_LOW, ACCURACY_HIGH, or NO_REQUIREMENT. </para>        
				/// </summary>
				/// <java-name>
				/// getSpeedAccuracy
				/// </java-name>
				public int SpeedAccuracy
				{
				[Dot42.DexImport("getSpeedAccuracy", "()I", AccessFlags = 1)]
						get{ return GetSpeedAccuracy(); }
				[Dot42.DexImport("setSpeedAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetSpeedAccuracy(value); }
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired bearing accuracy. Accuracy may be ACCURACY_LOW, ACCURACY_HIGH, or NO_REQUIREMENT. </para>        
				/// </summary>
				/// <java-name>
				/// getBearingAccuracy
				/// </java-name>
				public int BearingAccuracy
				{
				[Dot42.DexImport("getBearingAccuracy", "()I", AccessFlags = 1)]
						get{ return GetBearingAccuracy(); }
				[Dot42.DexImport("setBearingAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetBearingAccuracy(value); }
				}

				/// <summary>
				/// <para>Returns a constant indicating desired accuracy of location Accuracy may be ACCURACY_FINE if desired location is fine, else it can be ACCURACY_COARSE. </para>        
				/// </summary>
				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public int Accuracy
				{
				[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1)]
						get{ return GetAccuracy(); }
				[Dot42.DexImport("setAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetAccuracy(value); }
				}

				/// <summary>
				/// <para>Returns a constant indicating the desired power requirement. The returned </para>        
				/// </summary>
				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				public int PowerRequirement
				{
				[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1)]
						get{ return GetPowerRequirement(); }
				[Dot42.DexImport("setPowerRequirement", "(I)V", AccessFlags = 1)]
						set{ SetPowerRequirement(value); }
				}

		}

}


