﻿#pragma checksum "..\..\..\..\Windows\AddRecipeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82F1F32A6138044BE008D46C3949EC0B8CC051EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Yellow_Carrot.Windows;


namespace Yellow_Carrot.Windows {
    
    
    /// <summary>
    /// AddRecipeWindow
    /// </summary>
    public partial class AddRecipeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRecipeName;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbIngredient;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbQuantity;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTag;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvIngredients;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvTag;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddIngredient;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteIngredient;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTag;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteTag;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveRecipe;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Yellow Carrot;component/windows/addrecipewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbRecipeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbIngredient = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.tbIngredient.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbIngredient_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbQuantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 89 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.tbQuantity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbTag = ((System.Windows.Controls.TextBox)(target));
            
            #line 97 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.tbTag.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbTag_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvIngredients = ((System.Windows.Controls.ListView)(target));
            
            #line 105 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.lvIngredients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvIngredients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvTag = ((System.Windows.Controls.ListView)(target));
            
            #line 113 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.lvTag.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvTag_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnAddIngredient.Click += new System.Windows.RoutedEventHandler(this.btnAddIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnDeleteIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnDeleteIngredient.Click += new System.Windows.RoutedEventHandler(this.btnDeleteIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAddTag = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnAddTag.Click += new System.Windows.RoutedEventHandler(this.btnAddTag_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnDeleteTag = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnDeleteTag.Click += new System.Windows.RoutedEventHandler(this.btnDeleteTag_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnSaveRecipe = ((System.Windows.Controls.Button)(target));
            
            #line 172 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnSaveRecipe.Click += new System.Windows.RoutedEventHandler(this.btnSaveRecipe_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 182 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

