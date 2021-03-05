using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTo : MonoBehaviour
{
    public GameObject objectToTrack;
    void Update()
    {
        gameObject.transform.position = new Vector3(objectToTrack.transform.position.x, objectToTrack.transform.position.y, gameObject.transform.position.z);
    }
}
