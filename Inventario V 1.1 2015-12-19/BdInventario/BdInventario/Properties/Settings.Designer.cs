﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BdInventario.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LADA\\SQLEXPRESS;Initial Catalog=BdInventarioSQL;Integrated Security=T" +
            "rue")]
        public string BdInventarioSQLConnectionString {
            get {
                return ((string)(this["BdInventarioSQLConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\\BdInventarioSQL.sdf;Max Database Size=2047")]
        public string ClientBdInventarioSQLConnectionString {
            get {
                return ((string)(this["ClientBdInventarioSQLConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\\Database1.sdf")]
        public string Database1ConnectionString {
            get {
                return ((string)(this["Database1ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LADA1PORTATIL\\LADA;Initial Catalog=\"C:\\PROGRAM FILES\\MICROSOFT SQL SE" +
            "RVER\\MSSQL11.LADA1\\MSSQL\\DATA\\BDINVENTARIOSQL.MDF\";Integrated Security=True")]
        public string C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL11_LADA1_MSSQL_DATA_BDINVENTARIOSQL_MDFConnectionString {
            get {
                return ((string)(this["C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL11_LADA1_MSSQL_DATA_BDINVENTARIOSQL_MD" +
                    "FConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LADA1PORTATIL\\LADA;Initial Catalog=BdInventario;Integrated Security=T" +
            "rue")]
        public string BdInventarioConnectionString {
            get {
                return ((string)(this["BdInventarioConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=localhost;User Id=root;database=bdinventario")]
        public string mysqlbdinventario {
            get {
                return ((string)(this["mysqlbdinventario"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=localhost;user id=root;database=bdinventario")]
        public string bdinventarioConnectionString1 {
            get {
                return ((string)(this["bdinventarioConnectionString1"]));
            }
        }
    }
}
