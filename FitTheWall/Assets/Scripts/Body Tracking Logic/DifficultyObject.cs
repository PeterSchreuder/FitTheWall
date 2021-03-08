using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DifficultyObject : ScriptableObject
{
    public new string name;
    public float jointPointDistanceMargin = 10;
    public float wallSpeed = 2;
}
