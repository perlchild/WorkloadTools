﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkloadTools.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SqlTextNormalizer_TRUNCATE_TO_4000 {
            get {
                return ((bool)(this["SqlTextNormalizer_TRUNCATE_TO_4000"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SqlTextNormalizer_TRUNCATE_TO_1024K {
            get {
                return ((bool)(this["SqlTextNormalizer_TRUNCATE_TO_1024K"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int WorkloadAnalyzer_MAX_WRITE_RETRIES {
            get {
                return ((int)(this["WorkloadAnalyzer_MAX_WRITE_RETRIES"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ReplayWorker_COMPUTE_AVERAGE_STATS {
            get {
                return ((bool)(this["ReplayWorker_COMPUTE_AVERAGE_STATS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ReplayWorker_CONSUME_RESULTS {
            get {
                return ((bool)(this["ReplayWorker_CONSUME_RESULTS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int ReplayWorker_DEFAULT_QUERY_TIMEOUT_SECONDS {
            get {
                return ((int)(this["ReplayWorker_DEFAULT_QUERY_TIMEOUT_SECONDS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int ReplayWorker_WORKLOAD_INFO_COMMAND_COUNT {
            get {
                return ((int)(this["ReplayWorker_WORKLOAD_INFO_COMMAND_COUNT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("32")]
        public int ReplayConsumer_SEMAPHORE_LIMIT {
            get {
                return ((int)(this["ReplayConsumer_SEMAPHORE_LIMIT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int ReplayConsumer_WORKER_EXPIRY_TIMEOUT_MINUTES {
            get {
                return ((int)(this["ReplayConsumer_WORKER_EXPIRY_TIMEOUT_MINUTES"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int SqlTraceWorkloadListener_DEFAULT_TRACE_INTERVAL_SECONDS {
            get {
                return ((int)(this["SqlTraceWorkloadListener_DEFAULT_TRACE_INTERVAL_SECONDS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int SqlTraceWorkloadListener_DEFAULT_TRACE_ROWS_SLEEP_THRESHOLD {
            get {
                return ((int)(this["SqlTraceWorkloadListener_DEFAULT_TRACE_ROWS_SLEEP_THRESHOLD"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int SqlTraceWorkloadListener_DEFAULT_TRACE_SIZE_MB {
            get {
                return ((int)(this["SqlTraceWorkloadListener_DEFAULT_TRACE_SIZE_MB"]));
            }
        }
    }
}