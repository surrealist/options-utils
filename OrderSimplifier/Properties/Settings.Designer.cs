﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderSimplifier.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("@. BTF 1175\r\n\r\nLC 1200 @0.6 x 1\r\nLC 1200 @0.6 x 1\r\n\r\nLC 1150 @2.3 x 1\r\nLC 1150 @2" +
            ".4 x 1\r\n\r\nSC 1175 @0.7 x 1\r\nSC 1175 @0.8 x 1\r\n")]
        public string SourceText {
            get {
                return ((string)(this["SourceText"]));
            }
            set {
                this["SourceText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal SimplifyMultiplier {
            get {
                return ((decimal)(this["SimplifyMultiplier"]));
            }
            set {
                this["SimplifyMultiplier"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SimulationLF {
            get {
                return ((bool)(this["SimulationLF"]));
            }
            set {
                this["SimulationLF"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SimulationSF {
            get {
                return ((bool)(this["SimulationSF"]));
            }
            set {
                this["SimulationSF"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1100")]
        public decimal SimulationStartIndex {
            get {
                return ((decimal)(this["SimulationStartIndex"]));
            }
            set {
                this["SimulationStartIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal SimulationContracts {
            get {
                return ((decimal)(this["SimulationContracts"]));
            }
            set {
                this["SimulationContracts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public decimal SimulationSteps {
            get {
                return ((decimal)(this["SimulationSteps"]));
            }
            set {
                this["SimulationSteps"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public decimal SimulationCount {
            get {
                return ((decimal)(this["SimulationCount"]));
            }
            set {
                this["SimulationCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SimplifyAutoSelectText {
            get {
                return ((bool)(this["SimplifyAutoSelectText"]));
            }
            set {
                this["SimplifyAutoSelectText"] = value;
            }
        }
    }
}
