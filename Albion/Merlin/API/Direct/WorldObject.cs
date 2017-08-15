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
    /* Internal type: asc */
    public class WorldObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private asc _internal;
        
        #region Properties
        
        public asc Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public Point2 GetPosition() => _internal.hy();
        
        #endregion
        
        #region Constructor
        
        public WorldObject(asc instance)
        {
            _internal = instance;
        }
        
        static WorldObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator asc(WorldObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator WorldObject(asc instance)
        {
            return new WorldObject(instance);
        }
        
        #endregion
    }
}
