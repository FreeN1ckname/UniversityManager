﻿#pragma checksum "..\..\..\Views\SpecialtyEditorWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEF9729D1FE8F1743925D5DB900380EC42BF9C21132CB1D6B554424B287BBBB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UniversityManager.Views;


namespace UniversityManager.Views {
    
    
    /// <summary>
    /// SpecialtyEditorWindow
    /// </summary>
    public partial class SpecialtyEditorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Views\SpecialtyEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\SpecialtyEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codeBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\SpecialtyEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox infoBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\SpecialtyEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rejectButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\SpecialtyEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\SpecialtyEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button acceptButton;
        
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
            System.Uri resourceLocater = new System.Uri("/UniversityManager;component/views/specialtyeditorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SpecialtyEditorWindow.xaml"
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
            this.nameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.codeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.infoBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rejectButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Views\SpecialtyEditorWindow.xaml"
            this.rejectButton.Click += new System.Windows.RoutedEventHandler(this.rejectButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\SpecialtyEditorWindow.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.acceptButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\SpecialtyEditorWindow.xaml"
            this.acceptButton.Click += new System.Windows.RoutedEventHandler(this.acceptButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

