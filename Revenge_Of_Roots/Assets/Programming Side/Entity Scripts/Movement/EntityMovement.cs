using UnityEngine;
using NaughtyAttributes;
using ROR.Enums;

namespace ROR
{
    public class EntityMovement : MonoBehaviour
    {
        [SerializeField, Required, Foldout("Entity Initializations")] private GameObject spriteHolder;
        [SerializeField, Required, Foldout("Entity Initializations")] private Rigidbody2D player_RB;
        private FACING_DIRECTION player_FacingRight;
        
        public void MoveEntity(Vector2 move, float moveSpeed)
        {
            // Move the character by finding the target velocity
            Vector3 targetVelocity = move * 100f;
            // And then smoothing it out and applying it to the character
            player_RB.velocity = targetVelocity.normalized * moveSpeed;

            // TODO: If facing wrong direction flip sprite
        }

        private void FlipSprite()
        {
            Vector3 theScale = spriteHolder.transform.localScale;
            theScale.x *= -1;
            spriteHolder.transform.localScale = theScale;
        }
    }
}
