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
    /* Internal type: au0 */
    public partial class GuildMember
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private au0 _internal;
        
        #region Properties
        
        public au0 GuildMember_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GuildMember(au0 instance)
        {
            _internal = instance;
        }
        
        static GuildMember()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator au0(GuildMember instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuildMember(au0 instance)
        {
            return new GuildMember(instance);
        }
        
        public static implicit operator bool(GuildMember instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
