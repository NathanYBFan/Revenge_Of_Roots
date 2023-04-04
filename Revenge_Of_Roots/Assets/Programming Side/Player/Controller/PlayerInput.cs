using UnityEngine;
using NaughtyAttributes;
using ROR.Entity;

namespace ROR.Player.Movement
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField, Foldout("Player Initializations")] private SpriteRenderer playerSprite;
        [SerializeField, Foldout("Player Initializations")] private Animator animator;
        [SerializeField, Foldout("Player Initializations")] private Transform firePoint;

        [SerializeField, Foldout("Player Movement Specs")] private float moveSpeed = 1f;
        [SerializeField, Foldout("Player Movement Specs")] private EntityMovement movementController;
        
        [SerializeField, Foldout("Player Attack Specs")] private float attackSpeed = 1f;
        [SerializeField, Foldout("Player Attack Specs")] private EntityAttack attackController;
        
        private float horizontalMove, verticalMove;
        private bool isDead;
        
        public void SlowPlayerMoveSpeed()
        {
            moveSpeed /= 1.5f;
            playerSprite.color = Color.green;
        }

        // Update is called once per frame
        void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");
            verticalMove = Input.GetAxisRaw("Vertical");

            if (Input.GetKeyDown(KeyCode.Mouse1))
                attackController.Attack();
        }

        private void FixedUpdate()
        {
            Vector2 playerMove = new Vector2(horizontalMove, verticalMove);
            movementController.MoveEntity(playerMove * Time.fixedDeltaTime, moveSpeed);
        }

        public void SetMoveSpeed(float newMoveSpeed) { moveSpeed = newMoveSpeed; }
        public float GetMoveSpeed() { return moveSpeed; }

        public void SetAttackSpeed(float newAttackSpeed) { attackSpeed = newAttackSpeed;}
        public float GetAttackSpeed() { return attackSpeed; }
        public void SetIsDead(bool newIsDead) { isDead = newIsDead; }
        public bool GetIsDead() { return isDead; }
    }
}