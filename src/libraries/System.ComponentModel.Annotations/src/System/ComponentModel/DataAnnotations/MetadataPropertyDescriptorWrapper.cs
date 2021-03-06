// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.ComponentModel.DataAnnotations
{
    internal sealed class MetadataPropertyDescriptorWrapper : PropertyDescriptor
    {
        private readonly PropertyDescriptor _descriptor;
        private readonly bool _isReadOnly;

        public MetadataPropertyDescriptorWrapper(PropertyDescriptor descriptor, Attribute[] newAttributes)
            : base(descriptor, newAttributes)
        {
            _descriptor = descriptor;

            foreach (Attribute attribute in newAttributes)
            {
                if (attribute is ReadOnlyAttribute readOnlyAttribute)
                {
                    _isReadOnly = readOnlyAttribute.IsReadOnly;
                    break;
                }
            }
        }

        public override void AddValueChanged(object component, EventHandler handler) { _descriptor.AddValueChanged(component, handler); }

        public override bool CanResetValue(object component) { return _descriptor.CanResetValue(component); }

        public override Type ComponentType { get { return _descriptor.ComponentType; } }

        public override object? GetValue(object? component) { return _descriptor.GetValue(component); }

        public override bool IsReadOnly
        {
            get
            {
                // Dev10 Bug 594083
                // It's not enough to call the wrapped _descriptor because it does not know anything about
                // new attributes passed into the constructor of this class.
                return _isReadOnly || _descriptor.IsReadOnly;
            }
        }

        public override Type PropertyType { get { return _descriptor.PropertyType; } }

        public override void RemoveValueChanged(object component, EventHandler handler) { _descriptor.RemoveValueChanged(component, handler); }

        public override void ResetValue(object component) { _descriptor.ResetValue(component); }

        public override void SetValue(object? component, object? value) { _descriptor.SetValue(component, value); }

        public override bool ShouldSerializeValue(object component) { return _descriptor.ShouldSerializeValue(component); }

        public override bool SupportsChangeEvents { get { return _descriptor.SupportsChangeEvents; } }
    }
}
