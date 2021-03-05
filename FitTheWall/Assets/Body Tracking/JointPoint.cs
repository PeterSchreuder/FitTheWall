using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JointTypes { ShoulderLeft, ShoulderRight }

public class JointPoint : MonoBehaviour
{

    [SerializeField]
    JointTypes _pointType;

    public JointTypes PointType
    {
        get { return _pointType; }
    }

    float _xPosition;

    public float xPosition
    {
        get { return _xPosition; }
    }

    float _yPosition;

    public float yPosition
    {
        get { return _yPosition; }
    }

    public void Update() {

        _xPosition = gameObject.transform.position.x;
        _yPosition = gameObject.transform.position.y;
    }
}
