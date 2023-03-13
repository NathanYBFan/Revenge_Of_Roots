using UnityEngine;
using NaughtyAttributes;

namespace ROR
{
    public class EnemyInput : MonoBehaviour
    {
        [SerializeField, Foldout("Player Initializations")] private Transform enemyTargetLocation;
        [SerializeField, Foldout("Player Initializations")] private Animator animator;
        [SerializeField, Foldout("Player Initializations")] private Transform firePoint;

        [SerializeField, Foldout("Player Movement Specs")] private float moveSpeed = 1f;
        [SerializeField, Foldout("Player Movement Specs")] private EntityMovement movementController;

        void Awake() {
            
        }

        public void SetEnemyTarget() {

        }

        public void SetMoveSpeed(float newMoveSpeed) { moveSpeed = newMoveSpeed; }
        public float GetMoveSpeed() { return moveSpeed; }
    }
}
