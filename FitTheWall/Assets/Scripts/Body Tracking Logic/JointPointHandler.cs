using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointPointHandler : MonoBehaviour
{
    [SerializeField]
    private List<JointPoint> jointPoints = new List<JointPoint>();

    public List<JointPoint> JointPoints
    {
        get { return jointPoints; }
    }

    public void Start() {

        GetAllPoints();
    }

    /// <summary>
    /// Gets all JointPoint components from the childeren
    /// print(GetJointPointByType(PointType.RightFoot).ToString());
    /// </summary>
    private void GetAllPoints() {

        JointPoint[] _jointPointsArray = gameObject.transform.GetComponentsInChildren<JointPoint>();

        // Convert the Array to a List<JointPoint>
        jointPoints = new List<JointPoint>(_jointPointsArray);
    }

    public JointPoint GetJointPointByType(PointType _type)
    {
        JointPoint _jointPoint = null;

        foreach(JointPoint _point in jointPoints)
        {
            if (_point.PointType == _type)
            {
                _jointPoint = _point;

                // Stop the foreach loop. Because we have the value
                break;
            }
        }

        // If the point with the given type is not found, then let us know
        if (_jointPoint == null)
        {
            Debug.LogError("No point with type " + _type.ToString() + ", found!");
        }

        return _jointPoint;
    }
}
