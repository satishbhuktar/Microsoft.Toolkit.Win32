// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using WUX = Windows.UI.Xaml;

namespace Microsoft.Toolkit.Win32.UI.XamlHost
{
    /// <summary>
    /// Enables access to native methods on DesktopWindowXamlSourceNative
    /// </summary>
    /// <remarks>
    /// Includes the method used to set the window handle of the <see cref="WUX.Hosting.DesktopWindowXamlSource" /> instance.
    /// </remarks>
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("3cbcf1bf-2f76-4e9c-96ab-e84b37972554")]
    partial interface IDesktopWindowXamlSourceNative
    {
        /// <summary>
        /// Attaches the <see cref="WUX.Hosting.DesktopWindowXamlSource" /> to a window using a window handle.
        /// </summary>
        /// <param name="parentWnd">pointer to parent Wnd</param>
        /// <remarks>
        /// The associated window will be used to parent UWP XAML visuals, appearing
        /// as UWP XAML's logical render target.
        /// </remarks>
        void AttachToWindow(IntPtr parentWnd);

        /// <summary>
        /// Gets the handle associated with the <see cref="WUX.Hosting.DesktopWindowXamlSource" /> instance.
        /// </summary>
        IntPtr WindowHandle { get; }
    }
}
