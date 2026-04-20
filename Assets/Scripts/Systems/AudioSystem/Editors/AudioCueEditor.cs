using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Systems.AudioSystem.Editors
{
    [CustomEditor(typeof(AudioCue))]
    public class AudioCueEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            AudioCue cue = (AudioCue)target;

            // Default fields
            cue.clip = (AudioClip)EditorGUILayout.ObjectField("Clip", cue.clip, typeof(AudioClip), false);
            cue.channel = (AudioChannel)EditorGUILayout.ObjectField("Channel", cue.channel, typeof(AudioChannel), false);
            cue.volume = EditorGUILayout.Slider("Volume", cue.volume, 0f, 1f);

            // Spatial mode
            cue.spatialMode = (AudioSpatialMode)EditorGUILayout.EnumPopup("Spatial Mode", cue.spatialMode);

            // Conditional fields
            if (cue.spatialMode == AudioSpatialMode.World2D ||
                cue.spatialMode == AudioSpatialMode.World3D)
            {
                EditorGUILayout.Space();
                EditorGUILayout.LabelField("Spatial Settings", EditorStyles.boldLabel);

                cue.minDistance = EditorGUILayout.FloatField("Min Distance", cue.minDistance);
                cue.maxDistance = EditorGUILayout.FloatField("Max Distance", cue.maxDistance);
            }

            if (GUI.changed)
            {
                EditorUtility.SetDirty(cue);
            }
        }
    }
}
