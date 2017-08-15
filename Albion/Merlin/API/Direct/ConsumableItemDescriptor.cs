////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: dh */
    public class ConsumableItemDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private dh _internal;
        
        #region Properties
        
        public dh Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ConsumableItemDescriptor(dh instance)
        {
            _internal = instance;
        }
        
        static ConsumableItemDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator dh(ConsumableItemDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ConsumableItemDescriptor(dh instance)
        {
            return new ConsumableItemDescriptor(instance);
        }
        
        #endregion
    }
}
