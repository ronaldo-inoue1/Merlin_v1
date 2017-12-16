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
    /* Internal type: au1 */
    public partial class SimulationObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private au1 _internal;
        
        #region Properties
        
        public au1 SimulationObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public long GetId() => _internal.az();
        
        #endregion
        
        #region Constructor
        
        public SimulationObject(au1 instance)
        {
            _internal = instance;
        }
        
        static SimulationObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator au1(SimulationObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimulationObject(au1 instance)
        {
            return new SimulationObject(instance);
        }
        
        public static implicit operator bool(SimulationObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
