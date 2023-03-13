using UnityEngine;
using NaughtyAttributes;

namespace ROR.Enemy.Movement
{
    public class EnemyInput : MonoBehaviour
    {
        [SerializeField, Foldout("Enemy Initializations")] private Transform enemyTargetLocation;
        [SerializeField, Foldout("Enemy Initializations")] private Animator animator;
        [SerializeField, Foldout("Enemy Initializations")] private Transform firePoint;

        [SerializeField, Foldout("Enemy Movement Specs")] private float moveSpeed = 1f;
        [SerializeField, Foldout("Enemy Movement Specs")] private EntityMovement movementController;

        void Awake() {
            if (enemyTargetLocation == null)
                enemyTargetLocation.position = new Vector3(10f, 10f, 10f);
        }

        void Update() {
            Vector3 dir = (enemyTargetLocation.position - transform.position).normalized;
            if (transform.position != enemyTargetLocation.position)
                movementController.MoveEntity(dir, moveSpeed);
        }

        public void SetTarget(Transform newTarget) { enemyTargetLocation = newTarget; }
        public GameObject GetTargetObject() { return enemyTargetLocation.gameObject; }
        public void SetMoveSpeed(float newMoveSpeed) { moveSpeed = newMoveSpeed; }
        public float GetMoveSpeed() { return moveSpeed; }
    }
}
