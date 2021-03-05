using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// used to assign the two-dimensional (X and Y) coordinates to this object's transform
public class PositionTo : MonoBehaviour
{
    //The object which coordinates are taken
    [SerializeField] private GameObject objectToTrack;

    void Update()
    {
        AssignXYPosition();
    }

    /// Replaces X and Y coordinates with that of 'objectToTrack'
    void AssignXYPosition()
    {
        gameObject.transform.position = new Vector3(objectToTrack.transform.position.x, objectToTrack.transform.position.y, gameObject.transform.position.z);
    }
}
