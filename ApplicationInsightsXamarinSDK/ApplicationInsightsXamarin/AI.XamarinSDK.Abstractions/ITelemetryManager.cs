using System;
using System.Collections.Generic;

namespace AI.XamarinSDK.Abstractions
{
	public interface ITelemetryManager
	{
		void TrackEvent (string eventName);

		void TrackEvent (string eventName, Dictionary<string, string> properties);

		void TrackTrace (string message);

		void TrackTrace (string message, Dictionary<string, string> properties);

		void TrackMetric (string metricName, double value);

		void TrackMetric (string metricName, double value, Dictionary<string, string> properties);

		void TrackPageView (string pageName);

		void TrackManagedException (Exception  exception, bool handled);
	}
}