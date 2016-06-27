﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Syrinj.Attributes;
using UnityEngine;

namespace Syrinj.Injection
{
    public class InjectableFactory
    {

        public static Injectable Create(MemberInfo info, MonoBehaviour monoBehaviour, string tag, UnityDependencyAttribute attribute)
        {
            if (info.MemberType == MemberTypes.Property)
            {
                var pInfo = (PropertyInfo)info;
                return new InjectableProperty(pInfo, pInfo.PropertyType, monoBehaviour, tag, attribute);
            }
            else if (info.MemberType == MemberTypes.Field)
            {
                var fInfo = (FieldInfo)info;
                return new InjectableField(fInfo, fInfo.FieldType, monoBehaviour, tag, attribute);
            }
            return null;
        }
    }
}
