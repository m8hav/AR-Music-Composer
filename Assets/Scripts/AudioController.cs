// using System.Collections.Generic;
// using UnityEngine;
// using Vuforia;

// public class AudioController : MonoBehaviour, ITrackableEventHandler
// {
//     private readonly List<AudioSource> audioSources = new List<AudioSource>();

//     private void Awake()
//     {
//         var imageTargets = FindObjectsOfType<ImageTargetBehaviour>();
//         foreach (var imageTarget in imageTargets)
//         {
//             var audioSource = imageTarget.GetComponent<AudioSource>();
//             if (audioSource != null)
//             {
//                 audioSources.Add(audioSource);
//             }
//         }

//         var trackableBehaviour = GetComponent<TrackableBehaviour>();
//         if (trackableBehaviour != null)
//         {
//             trackableBehaviour.RegisterTrackableEventHandler(this);
//         }
//     }

//     public void OnTrackableStateChanged(
//         TrackableBehaviour.Status previousStatus,
//         TrackableBehaviour.Status newStatus)
//     {
//         if (newStatus == TrackableBehaviour.Status.DETECTED ||
//             newStatus == TrackableBehaviour.Status.TRACKED ||
//             newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
//         {
//             foreach (var audioSource in audioSources)
//             {
//                 if (audioSource.isPlaying == false)
//                 {
//                     audioSource.Play();
//                 }
//             }
//         }
//         else
//         {
//             foreach (var audioSource in audioSources)
//             {
//                 if (audioSource.isPlaying)
//                 {
//                     audioSource.Pause();
//                 }
//             }
//         }
//     }
// }
