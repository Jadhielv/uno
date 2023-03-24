#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class CommandBarFlyoutCommandBarAutomationProperties 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ControlTypeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"ControlType", typeof(global::Windows.UI.Xaml.Automation.Peers.AutomationControlType), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.CommandBarFlyoutCommandBarAutomationProperties), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Automation.Peers.AutomationControlType)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.CommandBarFlyoutCommandBarAutomationProperties.ControlTypeProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.Automation.Peers.AutomationControlType GetControlType( global::Windows.UI.Xaml.UIElement element)
		{
			return (global::Windows.UI.Xaml.Automation.Peers.AutomationControlType)element.GetValue(ControlTypeProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetControlType( global::Windows.UI.Xaml.UIElement element,  global::Windows.UI.Xaml.Automation.Peers.AutomationControlType value)
		{
			element.SetValue(ControlTypeProperty, value);
		}
		#endif
	}
}