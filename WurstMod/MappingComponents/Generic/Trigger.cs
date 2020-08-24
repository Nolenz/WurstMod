﻿using UnityEngine;
using UnityEngine.Events;

namespace WurstMod.MappingComponents.Generic
{
    public enum TriggeredBy { Player, Sosig, Bullet, AnyRigidbody }
    public enum TriggerType { Any, Each }

    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("")] // TODO Disabled for now, need to figure out how to handle layer wonkiness... Force require box collider only and use bounds overlap?
    public class Trigger : MonoBehaviour
    {
        // Inspectables
        [Tooltip("What is this triggered by?")]
        public TriggeredBy triggeredBy = TriggeredBy.Player;
        [Tooltip("Any: Trigger Enter when number of valid objects in trigger goes from 0 to 1, and trigger Exit on 1 to 0\nEach: Trigger Enter when number of valid objects in trigger increases, and trigger Exit when it decreases.")]
        public TriggerType triggerType = TriggerType.Any;

        [Tooltip("Actions to run when trigger is entered.")]
        public UnityEvent enterEvent;
        [Tooltip("Actions to run when trigger is exited.")]
        public UnityEvent exitEvent;

        
        private int numInside = 0;
       
        // TODO Rigidbody is the only trigger currently working.
        void OnTriggerEnter(Collider other)
        {
            Debug.Log("SOMETHING entered trigger: " + other.gameObject.name);
            if (IsCorrectType(other))
            {
                numInside++;
                if (triggerType == TriggerType.Each || numInside == 1)
                {
                    Debug.Log("Enter: " + other.gameObject.name);
                    if (enterEvent != null) enterEvent.Invoke();
                }
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (IsCorrectType(other))
            {
                numInside--;
                if (triggerType == TriggerType.Each || numInside == 0)
                {
                    Debug.Log("Exit: " + other.gameObject.name);
                    if (exitEvent != null) exitEvent.Invoke();
                }
            }
        }

        //TODO This will bug out "Each", need to cache valid parents, not objects this returns true on. Modify extension to return the parent object.
        private bool IsCorrectType(Collider other)
        {
            bool triggerPlayer = triggeredBy == TriggeredBy.Player &&    other.GetComponentBidirectional<FistVR.FVRPlayerHitbox>() != null; // Does not work, collision bug
            bool triggerSosig = triggeredBy == TriggeredBy.Sosig &&      other.GetComponentBidirectional<FistVR.Sosig>() != null; // Does not work, unknown
            bool triggerBullet = triggeredBy == TriggeredBy.Bullet &&    other.GetComponentBidirectional<FistVR.FVRProjectile>() != null; // Does not work, collision bug
            bool triggerAny = triggeredBy == TriggeredBy.AnyRigidbody && other.GetComponentBidirectional<Rigidbody>() != null;
            return triggerPlayer || triggerSosig || triggerBullet || triggerAny;
        }
    }
}
