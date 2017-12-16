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
    /* Internal type: avu */
    public partial class MovingObject : WorldObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private avu _internal;
        
        #region Properties
        
        public avu MovingObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public MovingObject(avu instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MovingObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator avu(MovingObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MovingObject(avu instance)
        {
            return new MovingObject(instance);
        }
        
        public static implicit operator bool(MovingObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
