﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7794D5FCB582AC1252A453641D11C347B609F2A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Picture3D;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Picture3D {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem LoadImageMenu;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SaveImageMenu;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ExitMenu;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ConvertAnaglyphMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ColorAnaglyphMenu;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem GrayAnaGlyphMenu;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem HalfColorAnaglyphMenu;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem OptimizedAnaglyphMenu;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem TrueAnaglyphMenu;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MainImage;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ConvertedImage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel filterPanel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorR;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorG;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorB;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slXaxis;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slYaxis;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MainImageTextBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConvertedImageTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Picture3D;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoadImageMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.LoadImageMenu.Click += new System.Windows.RoutedEventHandler(this.LoadImageMenu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SaveImageMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.SaveImageMenu.Click += new System.Windows.RoutedEventHandler(this.SaveImageMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.ExitMenu.Click += new System.Windows.RoutedEventHandler(this.ExitMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ConvertAnaglyphMenu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.ColorAnaglyphMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.ColorAnaglyphMenu.Click += new System.Windows.RoutedEventHandler(this.ColorAnaglyphMenu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GrayAnaGlyphMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.GrayAnaGlyphMenu.Click += new System.Windows.RoutedEventHandler(this.ColorAnaglyphMenu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.HalfColorAnaglyphMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.HalfColorAnaglyphMenu.Click += new System.Windows.RoutedEventHandler(this.ColorAnaglyphMenu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.OptimizedAnaglyphMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.OptimizedAnaglyphMenu.Click += new System.Windows.RoutedEventHandler(this.ColorAnaglyphMenu_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TrueAnaglyphMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.TrueAnaglyphMenu.Click += new System.Windows.RoutedEventHandler(this.ColorAnaglyphMenu_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MainImage = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.ConvertedImage = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            this.filterPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 13:
            this.slColorR = ((System.Windows.Controls.Slider)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.slColorR.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChangedRed);
            
            #line default
            #line hidden
            return;
            case 14:
            this.slColorG = ((System.Windows.Controls.Slider)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.slColorG.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChangedGreen);
            
            #line default
            #line hidden
            return;
            case 15:
            this.slColorB = ((System.Windows.Controls.Slider)(target));
            
            #line 62 "..\..\MainWindow.xaml"
            this.slColorB.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChangedBlue);
            
            #line default
            #line hidden
            return;
            case 16:
            this.slXaxis = ((System.Windows.Controls.Slider)(target));
            
            #line 67 "..\..\MainWindow.xaml"
            this.slXaxis.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChangedX);
            
            #line default
            #line hidden
            return;
            case 17:
            this.slYaxis = ((System.Windows.Controls.Slider)(target));
            
            #line 72 "..\..\MainWindow.xaml"
            this.slYaxis.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChangedY);
            
            #line default
            #line hidden
            return;
            case 18:
            this.MainImageTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.ConvertedImageTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
