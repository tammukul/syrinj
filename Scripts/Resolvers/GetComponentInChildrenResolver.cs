﻿using Syrinj.Attributes;
using Syrinj.Injection;
using UnityEngine;

namespace Syrinj.Resolvers
{
    public class GetComponentInChildrenResolver : IResolver
    {
        public object Resolve(Injectable injectable)
        {
            var attribute = (GetComponentInChildrenAttribute) injectable.Attribute;
            if (attribute.ComponentType == null)
            {
                return injectable.MonoBehaviour.GetComponentInChildren(injectable.Type);
            }
            else
            {
                return injectable.MonoBehaviour.GetComponentInChildren(attribute.ComponentType);
            }
        }
    }
}