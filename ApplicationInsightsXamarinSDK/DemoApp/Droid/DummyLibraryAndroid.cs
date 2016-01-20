using Android.App;


namespace XamarinTest.Droid
{
	public class DummyLibraryAndroid : Java.Lang.Object, IDummyLibrary
	{
		public DummyLibraryAndroid ()
		{
		}

		public void TriggerExceptionCrash(){
			ExampleClass library = new ExampleClass();
			library.ForceAppCrash ((Activity) Forms.Context);
		}
	}
}

