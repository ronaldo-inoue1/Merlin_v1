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
    /* Internal type: a3v */
    public partial class FurnitureObject : BuildingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a3v _internal;
        
        #region Properties
        
        public a3v FurnitureObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FurnitureObject(a3v instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FurnitureObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a3v(FurnitureObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FurnitureObject(a3v instance)
        {
            return new FurnitureObject(instance);
        }
        
        public static implicit operator bool(FurnitureObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
