using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

/// <summary>
/// Logging class responsible for all debugging.
/// Compose classes with this logger to handle logging configuration.
/// Will log to the console if ANY logging options are enabled, group or individual.
/// </summary>
[System.Serializable]
public class Logger
{
    [Tooltip("Enable logging for this component.")]
    public bool loggingEnabled = false;

    [Tooltip("Enable logging for this component based on group logging configurations.")]
    public List<LoggingGroup> loggingGroups;

    /// <summary>
    /// Returns true if either the instance log is enabled or any logging group is enabled.
    /// </summary>
    private bool IsLoggingEnabled()
    {
        if (loggingEnabled)
            return true;

        if (loggingGroups == null)
            return false;

        foreach (var group in loggingGroups)
        {
            if (group != null && group.isEnabled)
                return true;
        }

        return false;
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR"), Conditional("UNITY_ASSERTIONS")]
    public void Assert(bool condition)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.Assert(condition);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR"), Conditional("UNITY_ASSERTIONS")]
    public void Assert(bool condition, object message)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.Assert(condition, message);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void Log(object message)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.Log(message);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void Log(object message, Object context)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.Log(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void LogWarning(object message)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.LogWarning(message);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void LogWarning(object message, Object context)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.LogWarning(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void LogError(object message)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.LogError(message);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void LogError(object message, Object context)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.LogError(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void Break()
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.Break();
    }

    [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
    public void ClearDeveloperConsole()
    {
        if (IsLoggingEnabled())
            UnityEngine.Debug.ClearDeveloperConsole();
    }
}