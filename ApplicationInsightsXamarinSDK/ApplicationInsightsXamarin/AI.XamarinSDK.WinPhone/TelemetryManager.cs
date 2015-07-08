using System;
using System.Collections.Generic;
using AI.XamarinSDK.Abstractions;
using Microsoft.ApplicationInsights;

[assembly: Xamarin.Forms.Dependency (typeof (AI.XamarinSDK.WinPhone.TelemetryManager))]

namespace AI.XamarinSDK.WinPhone
{
	public class TelemetryManager : ITelemetryManager
	{
		private static readonly TelemetryClient sharedClient = new TelemetryClient();

		public TelemetryManager(){}

		public void TrackEvent (string eventName)
		{
			sharedClient.TrackEvent (eventName);
		}

		public void TrackEvent (string eventName, Dictionary<string, string> properties)
		{
			sharedClient.TrackEvent (eventName, properties, null);
		}

		public void TrackTrace (string message)
		{
			sharedClient.TrackTrace (message);
		}

		public void TrackTrace (string message, Dictionary<string, string> properties)
		{
			sharedClient.TrackTrace (message, properties);
		}

		public void TrackMetric (string metricName, double value)
		{
			sharedClient.TrackMetric (metricName, value);
		}

		public void TrackMetric (string metricName, double value, Dictionary<string, string> properties)
		{
			sharedClient.TrackMetric (metricName, value, properties);
		}

		public void TrackPageView (string pageName)
		{
			sharedClient.TrackPageView (pageName);
		}

		public void TrackManagedException (Exception  exception, bool handled)
		{
			sharedClient.TrackException (exception);
		}
	}
}

