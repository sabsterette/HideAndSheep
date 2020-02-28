﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Rendering;
using Components;
using EntityComponents;

public struct GlobalObjects
{
    [SerializeField] public static ProjectileBehaviour projectile;
    [SerializeField] public static Mesh mesh;
    [SerializeField] public static Material material;
}
