// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace UICatalog
{
    [Register ("TintedToolbarViewController")]
    partial class TintedToolbarViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIToolbar toolbar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (toolbar != null) {
                toolbar.Dispose ();
                toolbar = null;
            }
        }
    }
}