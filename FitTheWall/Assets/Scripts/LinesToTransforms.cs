using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinesToTransforms : MonoBehaviour
{
    [SerializeField]
    private List<Transform> transforms = new List<Transform>();

    private List<LineRenderer> lines = new List<LineRenderer>();

    // Start is called before the first frame update
    void Start()
    {
        CreateLines();
    }

    /// <summary>
    /// Create an amount of lines with the amount of transforms
    /// </summary>
    void CreateLines()
    {
        LineRenderer _line;
        GameObject _obj;
        for (int _i = 0; _i < transforms.Count; _i++)
        {
            _obj = new GameObject("TransformLine");
            _line = _obj.AddComponent<LineRenderer>();
            _line.startWidth = 0.04f;
            _line.endWidth = 0.01f;

            lines.Add(_line);
        }

        print(transforms.Count);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLines();
    }

    /// <summary>
    /// Update the begin & end position of the line to the transform position
    /// </summary>
    private void UpdateLines()
    {
        if (lines.Count == 0)
        {
            Debug.LogError("No Lines Found!");
            return;
        }

        //Update all the lines in the lines list
        LineRenderer _line;
        for (int _i = 0; _i < transforms.Count - 1; _i++)
        {
            _line = lines[_i];

            _line.SetPosition(0, transforms[_i].position);
            _line.SetPosition(1, transforms[_i + 1].position);
        }
    }
}
