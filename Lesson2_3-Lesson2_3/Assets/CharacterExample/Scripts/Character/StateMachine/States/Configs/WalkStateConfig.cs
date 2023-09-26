using System;
using UnityEngine;

[Serializable]
public class WalkStateConfig 
{
    [SerializeField, Range(0, 10)] private float _speedWalk;
    public float SpeedWalk => _speedWalk;
}
