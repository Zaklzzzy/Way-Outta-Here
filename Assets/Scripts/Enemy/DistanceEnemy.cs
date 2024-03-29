﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Distance Enemy", menuName = "Enemy/Distance", order = 51)]
public class DistanceEnemy : EnemyData
{
    private void Awake()
    {
        type = AttackType.distance;
    }
}
