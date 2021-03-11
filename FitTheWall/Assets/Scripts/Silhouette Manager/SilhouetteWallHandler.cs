using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilhouetteWallHandler : MonoBehaviour
{

    [SerializeField]
    private SilhouettePointsHandler silhouettePointsHandler;

    [SerializeField]
    private BodyTrackingPointsHandler bodyPointsHandler;

    private float margin = 1f;

    private void Update()
    {
        IJoinPointInsideMargin _point = null;
        PointType _type = PointType.LeftFoot;
        // Check if the point is inside the margin
        _point = CheckPointTypePositionInsideMargin(silhouettePointsHandler, bodyPointsHandler, _type, margin);

        //print(_point.jointPoint.PointType);

        if (_point.jointPoint)
        {
            if (_point.inside)
            {
                print("a");
                // Change point color
                _point.jointPoint.PointColor = Color.green;
            }
            else
            {
                print("b");
                // Change point color
                _point.jointPoint.PointColor = Color.red;
            }
        }
    }

    private void CheckAllJointPoints()
    {
        Array _types = Enum.GetValues(typeof(PointType));

        PointType _type = PointType.Noone;
        IJoinPointInsideMargin _point = null;
        int _a = 0;
        for (int _i = 0; _i < 1; _i++)//bodyPointsHandler.JointPointsAmount
        {
            _a++;
            // Get a point type from the _types array. (Skip the first one "None" with "+ 1")
            _type = (PointType)_types.GetValue(_i + 1);

            // Check if the point is inside the margin
            _point = CheckPointTypePositionInsideMargin(silhouettePointsHandler, bodyPointsHandler, _type, margin);

            //print(_point.jointPoint.PointType);

            if (_point.jointPoint)
            {
                if (_point.inside)
                {
                    print("a");
                    // Change point color
                    _point.jointPoint.PointColor = Color.green;
                }
                else
                {
                    print("b");
                    // Change point color
                    _point.jointPoint.PointColor = Color.red;
                }
            }
        }

        print(_a);
    }

    /// <summary>
    /// Check if the points of a specific type are near 
    /// </summary>
    /// <param name="_silhouettePoints"></param>
    /// <param name="_bodyTrackingPoints"></param>
    /// <param name="_type"></param>
    /// <param name="_difficultyMargin"></param>
    /// <returns></returns>
    private IJoinPointInsideMargin CheckPointTypePositionInsideMargin(SilhouettePointsHandler _silhouettePoints, BodyTrackingPointsHandler _bodyTrackingPoints, PointType _type, float _difficultyMargin)
    {
        IJoinPointInsideMargin _return = new IJoinPointInsideMargin();

        JointPoint _pointBody = null;
        JointPoint _pointSilhouette = null;

        _pointBody = _bodyTrackingPoints.GetJointPointByType(_type);
        _pointSilhouette = _silhouettePoints.GetJointPointByType(_type);

        // If the points exist, check if they are near
        if (_pointBody && _pointSilhouette)
        {
            float distance = Vector2.Distance(_pointBody.Position, _pointSilhouette.Position);
            LogDebug.Log(distance, _difficultyMargin);

            if (distance < _difficultyMargin)
            {
                _return.inside = true;
                _return.jointPoint = _pointBody;
            }
        }

        return _return;
    }
}
