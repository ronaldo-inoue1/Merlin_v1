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
    /* Internal type: c8 */
    public partial class JournalItemDescriptor : DurableItemDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private c8 _internal;
        
        #region Properties
        
        public c8 JournalItemDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public JournalItemDescriptor(c8 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static JournalItemDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator c8(JournalItemDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator JournalItemDescriptor(c8 instance)
        {
            return new JournalItemDescriptor(instance);
        }
        
        public static implicit operator bool(JournalItemDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
