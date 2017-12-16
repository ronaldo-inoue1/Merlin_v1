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
    /* Internal type: avi */
    public partial class FarmableItemObject : SimpleItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private avi _internal;
        
        #region Properties
        
        public avi FarmableItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FarmableItemObject(avi instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FarmableItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator avi(FarmableItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FarmableItemObject(avi instance)
        {
            return new FarmableItemObject(instance);
        }
        
        public static implicit operator bool(FarmableItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
