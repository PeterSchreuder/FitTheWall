using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// used to assign the two-dimensional (X and Y) coordinates to this object's transform
/// </summary>
public class PositionTo : MonoBehaviour
{
    //The object which coordinates are taken
    [SerializeField] private GameObject objectToTrack;

    void Update()
    {
        AssignXYPosition();
    }
    
 /// <summary>
 /// Replaces X and Y coordinates with that of 'objectToTrack'
 /// </summary>
    void AssignXYPosition()
    {
        gameObject.transform.position = new Vector3(objectToTrack.transform.position.x, objectToTrack.transform.position.y, gameObject.transform.position.z);
    }
}
