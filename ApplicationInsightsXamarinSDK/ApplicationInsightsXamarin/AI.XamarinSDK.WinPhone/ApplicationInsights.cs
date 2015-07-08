using System;
using AI.XamarinSDK.Abstractions;
using System.Runtime.InteropServices;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

[assembly: Xamarin.Forms.Dependency (typeof (AI.XamarinSDK.WinPhone.ApplicationInsights))]

namespace AI.XamarinSDK.WinPhone
{
	public class ApplicationInsights : IApplicationInsights
	{
		private static string iKey;
		private static bool pageViewTracking = false; 
		private static bool sessionTracking = false; 
		private static bool crashReporting = false;

		public ApplicationInsights (){}

		public void Setup(string instrumentationKey)
		{
			iKey = instrumentationKey;
		}

		public void Start ()
		{
			WindowsAppInitializer.InitializeAsync (iKey);
		}

		public string GetServerUrl ()
		{
			return TelemetryConfiguration.Active.TelemetryChannel.EndpointAddress;
		}

		public void SetServerUrl (string serverUrl)
		{
			TelemetryConfiguration.Active.TelemetryChannel.EndpointAddress = serverUrl;
		}

		public void  SetCrashManagerDisabled (bool crashManagerDisabled)
		{
			crashReporting = !crashManagerDisabled;
		}

		public void SetTelemetryManagerDisabled (bool telemetryManagerDisabled)
		{
			TelemetryConfiguration.Active.DisableTelemetry = telemetryManagerDisabled;
		}

		public void SetAutoPageViewTrackingDisabled (bool autoPageViewTrackingDisabled)
		{
			pageViewTracking = !autoPageViewTrackingDisabled;
		}

		public void SetAutoSessionManagementDisabled (bool autoSessionManagementDisabled)
		{
			sessionTracking = !autoSessionManagementDisabled;
		}

		public void SetUserId (string userId)
		{
			// Maybe do this with custom ContextInitializer
		}

		public void StartNewSession (){
			// Not supported
		}

		public void SetSessionExpirationTime (int appBackgroundTime)
		{
			// Not supported
		}

		public void RenewSessionWithId (string sessionId)
		{
			// Not supported
		}

		public bool GetDebugLogEnabled() 
		{
			return TelemetryConfiguration.Active.TelemetryChannel.DeveloperMode;
		}

		public void SetDebugLogEnabled(bool debugLogEnabled) 
		{
			TelemetryConfiguration.Active.TelemetryChannel.DeveloperMode = debugLogEnabled;
		}
	}
}

