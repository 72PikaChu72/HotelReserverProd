﻿#pragma checksum "..\..\..\Pages\Rooms.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06B611DF749DD700DEDDA4A5BB090164282EC963D2B6818920EC8F7AD9B27FD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelReserver.Pages;
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


namespace HotelReserver.Pages {
    
    
    /// <summary>
    /// Rooms
    /// </summary>
    public partial class Rooms : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RoomsList;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BookingSelection;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DoneBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomNumber;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomType;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomStatus;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Guest;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Note;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NoteText;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\Rooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button KickBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelReserver;component/pages/rooms.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Rooms.xaml"
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
            
            #line 12 "..\..\..\Pages\Rooms.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBackBtn);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RoomsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 13 "..\..\..\Pages\Rooms.xaml"
            this.RoomsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RoomsList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BookingSelection = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Pages\Rooms.xaml"
            this.BookingSelection.Click += new System.Windows.RoutedEventHandler(this.BookedSelectionBtn);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DoneBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\Rooms.xaml"
            this.DoneBtn.Click += new System.Windows.RoutedEventHandler(this.DoneBtnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RoomNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.RoomType = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.RoomStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Guest = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Note = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.NoteText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.KickBtn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\Rooms.xaml"
            this.KickBtn.Click += new System.Windows.RoutedEventHandler(this.KickBtnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
