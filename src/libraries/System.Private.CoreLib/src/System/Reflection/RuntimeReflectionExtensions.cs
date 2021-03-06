// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Reflection
{
    public static partial class RuntimeReflectionExtensions
    {
        private const BindingFlags Everything = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance;

        public static IEnumerable<FieldInfo> GetRuntimeFields(
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)]
            this Type type!!)
        {
            return type.GetFields(Everything);
        }

        public static IEnumerable<MethodInfo> GetRuntimeMethods(
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)]
            this Type type!!)
        {
            return type.GetMethods(Everything);
        }

        public static IEnumerable<PropertyInfo> GetRuntimeProperties(
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
            this Type type!!)
        {
            return type.GetProperties(Everything);
        }

        public static IEnumerable<EventInfo> GetRuntimeEvents(
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.NonPublicEvents)]
            this Type type!!)
        {
            return type.GetEvents(Everything);
        }

        public static FieldInfo? GetRuntimeField(
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)]
            this Type type!!, string name)
        {
            return type.GetField(name);
        }

        public static MethodInfo? GetRuntimeMethod(
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
            this Type type!!, string name, Type[] parameters)
        {
            return type.GetMethod(name, parameters);
        }

        public static PropertyInfo? GetRuntimeProperty(
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
            this Type type!!, string name)
        {
            return type.GetProperty(name);
        }

        public static EventInfo? GetRuntimeEvent(
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicEvents)]
            this Type type!!, string name)
        {
            return type.GetEvent(name);
        }

        public static MethodInfo? GetRuntimeBaseDefinition(this MethodInfo method!!)
        {
            return method.GetBaseDefinition();
        }

        public static InterfaceMapping GetRuntimeInterfaceMap(this TypeInfo typeInfo!!, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type interfaceType)
        {
            return typeInfo.GetInterfaceMap(interfaceType);
        }

        public static MethodInfo GetMethodInfo(this Delegate del!!)
        {
            return del.Method;
        }
    }
}
