using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointPoint : MonoBehaviour
{
    [SerializeField]
    private PointType pointType;

    private Vector2 position;
    private float xPosition;
    private float yPosition;

    /// <summary>
    /// Type
    /// </summary>

    public PointType PointType
    {
        get
        {
            return pointType;
        }
    }

    /// <summary>
    /// Position
    /// </summary>

    public Vector2 Position
    {
        get { 
            Vector3 _position3 = gameObject.transform.position;
            Vector2 _position2;

            _position2.x = _position3.x;
            _position2.y = _position3.y;

            position = _position2;
            return position; 
        }
    }

    public float XPosition
    {
        get { 
            xPosition = gameObject.transform.position.x;
            return xPosition;
        }
    }

    public float YPosition
    {
        get { 
            yPosition = gameObject.transform.position.y;
            return yPosition; 
        }
    }
}
