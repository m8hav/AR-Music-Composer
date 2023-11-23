// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Events;
// using Vuforia;

// public class DrumsEventHandler : MonoBehaviour, ITrackableEventHandler
// {
//     public UnityAction OnTrackingFound;
//     public UnityAction OnTrackingLost;

//     private TrackableBehaviour mTrackableBehaviour = null;
    
//     private readonly List<TrackableBehaviour.Status> mTrackingStatus = new List<TrackableBehaviour.Status>()
//     {
//         TrackableBehaviour.Status.DETECTED,
//         TrackableBehaviour.Status.TRACKED,

//         // Device positioning
//         TrackableBehaviour.Status.EXTENDED_TRACKED
//     };

//     private readonly List<TrackableBehaviour.Status> mNotTrackingStatus = new List<TrackableBehaviour.Status>()
//     {
//         TrackableBehaviour.Status.TRACKED,
//         TrackableBehaviour.Status.NO_POSE,
//         TrackableBehaviour.Status.UNKNOWN
//     };

//     private void Awake(){
//         mTrackableBehaviour = GetComponent<TrackableBehaviour>();
//         mTrackableBehaviour.RegisterTrackableEventHandler(this);
//     }

//     private void OnDestroy(){
//         mTrackableBehaviour.UnregisterTrackableEventHandler(this);
//     }

//     public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
//     {
//         if (mTrackingStatus.Contains(newStatus))
//         {
//             OnTrackingFound?.Invoke();
//         }
//         else if (mNotTrackingStatus.Contains(newStatus))
//         {
//             OnTrackingLost?.Invoke();
//         }
//     }
// }
