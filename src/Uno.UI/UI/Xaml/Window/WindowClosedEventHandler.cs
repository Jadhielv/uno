#if !HAS_UNO_WINUI
using Windows.UI.Core;

namespace Microsoft.UI.Xaml;

public delegate void WindowClosedEventHandler(object sender, CoreWindowEventArgs e);
#endif
