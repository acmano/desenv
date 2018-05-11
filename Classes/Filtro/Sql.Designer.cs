﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lor0138.Classes.Filtro {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Sql {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Sql() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lor0138.Classes.Filtro.Sql", typeof(Sql).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND item.cod_cla_uso = {0}.
        /// </summary>
        internal static string FiltroCodigoClasseUso {
            get {
                return ResourceManager.GetString("FiltroCodigoClasseUso", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  WHERE UPPER ( item.cod_empresa ) = &quot;{0}&quot;.
        /// </summary>
        internal static string FiltroCodigoEmpresa {
            get {
                return ResourceManager.GetString("FiltroCodigoEmpresa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND UPPER ( item.cod_familia) LIKE &quot;%{0}%&quot;.
        /// </summary>
        internal static string FiltroCodigoFamilia {
            get {
                return ResourceManager.GetString("FiltroCodigoFamilia", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND UPPER ( item.cod_item) LIKE &quot;%{0}%&quot;.
        /// </summary>
        internal static string FiltroCodigoItem {
            get {
                return ResourceManager.GetString("FiltroCodigoItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND item.cod_lin_prod = {0}.
        /// </summary>
        internal static string FiltroCodigoLinhaProduto {
            get {
                return ResourceManager.GetString("FiltroCodigoLinhaProduto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND item.cod_lin_recei = {0}.
        /// </summary>
        internal static string FiltroCodigoLinhaReceita {
            get {
                return ResourceManager.GetString("FiltroCodigoLinhaReceita", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND item.cod_seg_merc = {0}.
        /// </summary>
        internal static string FiltroCodigoSegmentoMercado {
            get {
                return ResourceManager.GetString("FiltroCodigoSegmentoMercado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND UPPER ( item.ies_tip_item) LIKE &quot;%{0}%&quot;.
        /// </summary>
        internal static string FiltroCodigoTipoItem {
            get {
                return ResourceManager.GetString("FiltroCodigoTipoItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND UPPER ( item.den_item) LIKE &quot;%{0}%&quot;.
        /// </summary>
        internal static string FiltroDescricaoItem {
            get {
                return ResourceManager.GetString("FiltroDescricaoItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  AND item.gru_ctr_estoq = {0}.
        /// </summary>
        internal static string FiltroGrupoControleEstoque {
            get {
                return ResourceManager.GetString("FiltroGrupoControleEstoque", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.CodigoEmpresa
        ///     ,  tabela.CodigoItem
        ///     ,  tabela.DescricaoItem
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  ,  &apos;SELECT  item.cod_empresa  as CodigoEmpresa
        ///           ,  item.cod_item     as CodigoItem
        ///           ,  item.den_item     as DescricaoItem
        ///        FROM  item
        ///        {1}
        ///        ORDER BY item.cod_empresa
        ///               , item.cod_item
        ///	&apos; 
        ///  ) AS tabela.
        /// </summary>
        internal static string QueryItem {
            get {
                return ResourceManager.GetString("QueryItem", resourceCulture);
            }
        }
    }
}
