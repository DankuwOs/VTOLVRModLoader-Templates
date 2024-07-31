using UnityEngine;

namespace VtolModTemplate;

public class Logger
{
    private static readonly string ModName = "VtolModTemplate";
    
    public static void Log(object message)
    {
        Debug.Log($"[{ModName}] [INFO]: {message.ToString()}");
    }

    public static void LogWarn(object obj)
    {
        Debug.LogWarning($"[{ModName}] [WARN]: {obj}");
    }
    
    public static void LogError(object message)
    {
        Debug.LogError($"[{ModName}] [ERROR]: {message.ToString()}");
    }
    
    // Add the #if yourself ierdna! Add the if(debuggydetailer) yourself ierdna! /ᐠ｡ꞈ｡ᐟ\ mieowdna
    public static void LogDetail(object message)
    {
        Debug.Log($"[{ModName}] [DETAIL]: {message.ToString()}");
    }
}