using UnityEngine;
using NaughtyAttributes;
namespace ROR.Player.Movement
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField, Foldout("Player Initializations")] private SpriteRenderer playerSprite;
        [SerializeField, Foldout("Player Initializations")] private Animator anim;
        [SerializeField, Foldout("Player Initializations")] private Transform firePoint;

        [SerializeField, Foldout("Player Movement Specs")] private float moveSpeed = 1f;
        [SerializeField, Foldout("Player Movement Specs")] private PlayerMovement movementController;
        private float horizontalMove, verticalMove;

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
        }

        private void FixedUpdate()
        {
            Vector2 playerMove = new Vector2(horizontalMove, verticalMove);
            movementController.MovePlayer(playerMove * Time.fixedDeltaTime, moveSpeed);
        }

        public void SetMoveSpeed(float newMoveSpeed) { moveSpeed = newMoveSpeed; }
        public float GetMoveSpeed() { return moveSpeed; }
        
    }
}