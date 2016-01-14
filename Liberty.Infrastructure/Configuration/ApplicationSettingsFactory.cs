using System.Diagnostics;

namespace Liberty.Infrastructure.Configuration 
{
	/// <summary>
	/// アプリケーションの設定を提供します
	/// </summary>
	public class ApplicationSettingsFactory 
	{
		private static IApplicationSettings _applicationSettings;

		/// <summary>
		/// アプリケーションの設定をセットします
		/// </summary>
		/// <param name="applicationSettings"></param>
		public static void InitializeApplicationSettingsFactory(IApplicationSettings applicationSettings) 
		{
			_applicationSettings = applicationSettings;
		}

		/// <summary>
		/// アプリケーションの設定を取得します
		/// </summary>
		/// <returns></returns>
		public static IApplicationSettings GetApplicationSettings() 
		{
			Debug.Assert(_applicationSettings != null);
			return _applicationSettings;
		}
	}
}
