﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BASEDEDATOSLUCHA.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-OHDJA7I\\SQLEXPRESS;Initial Catalog=DBLUCHA;Persist Security I" +
            "nfo=True;User ID=sa;Password=1q2w3e4r")]
        public string DBLUCHAConnectionString {
            get {
                return ((string)(this["DBLUCHAConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Carlo\\Documents\\Data" +
            ".mdf;Integrated Security=True;Connect Timeout=30")]
        public string DataConnectionString {
            get {
                return ((string)(this["DataConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-OHDJA7I\\SQLEXPRESS;Initial Catalog=DATA;Persist Security Info" +
            "=True;User ID=sa;Password=1q2w3e4r")]
        public string DATAConnectionString1 {
            get {
                return ((string)(this["DATAConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-OHDJA7I\\SQLEXPRESS;Initial Catalog=DBLUCHA;Persist Security I" +
            "nfo=True;User ID=sa;Password=1q2w3e4r")]
        public string DATAConnectionString2 {
            get {
                return ((string)(this["DATAConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-OHDJA7I\\SQLEXPRESS;Initial Catalog=DBMERMA;Persist Security I" +
            "nfo=True;User ID=sa;Password=1q2w3e4r")]
        public string DBMERMAConnectionString {
            get {
                return ((string)(this["DBMERMAConnectionString"]));
            }
        }
    }
}
