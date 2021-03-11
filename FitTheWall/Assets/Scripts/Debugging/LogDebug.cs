using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// These are usefull added functions to better debug stuff
/// </summary>
public static class LogDebug
{
    /// <summary>
    /// Logs values with the Debug.Log after each other (debuglog.log(value1, value2, value3...))
    /// > 41234, 123445, 12345543
    /// </summary>
    /// <param name="paramArray">values...</param>
    /// <typeparam name="T">Any value type</typeparam>
    public static void Log<T>(params T[] paramArray)
    {
        string dataString = "", lineEnd = "";
        int index = 0;// Position in the array
        foreach (T value in paramArray)
        {
            // Check if this is not the last value in the array
            lineEnd = (index < paramArray.Length - 1) ? "| " : "";

            // Add the converted value to the dataSting
            dataString += value.ToString() + lineEnd;

            // Increase the position in the array
            index++;
        }

        // Log the dataString
        Debug.Log(dataString);
    }
}