﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace WurstMod.TNH
{
    public class AttackVector : MonoBehaviour
    {
        [Tooltip("During Holds, when this AttackVector is chosen, enemy sosigs will spawn at these points. Use 3 or more points to be safe.")]
        public List<Transform> SpawnPoints_Sosigs_Attack;

        [Tooltip("Usually placed at this AttackVector's entrance to the hold point. Like, where the red barrier appears.")]
        public Transform GrenadeVector;

        [Tooltip("Usually 30.")]
        public float GrenadeRandAngle;

        [Tooltip("Usually {3,8}.")]
        public Vector2 GrenadeVelRange;


        private void OnDrawGizmos()
        {
            Extensions.GenericGizmoSphere(new Color(0.8f, 0f, 0f, 0.5f), Vector3.zero, 0.25f, SpawnPoints_Sosigs_Attack.ToArray());
            Extensions.GenericGizmoCube(new Color(0.1f, 0.5f, 0.1f, 0.5f), Vector3.zero, 0.5f * Vector3.one, true, false, GrenadeVector);
        }
    }
}
