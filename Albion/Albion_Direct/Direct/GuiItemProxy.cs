////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: a9k */
    public partial class GuiItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a9k _internal;
        
        #region Properties
        
        public a9k GuiItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GuiItemProxy(a9k instance)
        {
            _internal = instance;
        }
        
        static GuiItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a9k(GuiItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuiItemProxy(a9k instance)
        {
            return new GuiItemProxy(instance);
        }
        
        public static implicit operator bool(GuiItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
