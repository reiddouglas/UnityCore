using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BaseEventListener<>), true)]
public class BaseEventListenerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var listener = target as MonoBehaviour;

        var eventChannelProp = serializedObject.FindProperty("eventChannel");

        if (eventChannelProp != null && eventChannelProp.objectReferenceValue == null)
        {
            EditorGUILayout.HelpBox(
                "Event Channel is not assigned! This listener will not receive events.",
                MessageType.Warning);
        }

        serializedObject.ApplyModifiedProperties();
    }
}