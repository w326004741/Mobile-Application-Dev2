﻿#pragma checksum "C:\Users\Damien\Documents\Visual Studio 2015\Projects\UWP GeoLocation\UWP GeoLocation\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AAEEBAC718D047C1441421EEB2EC84C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP_GeoLocation
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.spLocations = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.tblStatus = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.elInit = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)this.elInit).Tapped += this.elInit_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.elSavePosition = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    #line 24 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)this.elSavePosition).Tapped += this.elSavePosition_Tapped;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

