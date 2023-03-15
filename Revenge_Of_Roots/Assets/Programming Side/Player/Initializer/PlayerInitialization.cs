using UnityEngine;
using ROR.Entity;

namespace ROR.Player.Movement
{
    public class PlayerInitialization : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer playerImage;
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private EntityHealth playerHealth;
        [SerializeField] private GameObject weaponParent;
        [SerializeField] private Animator animator;
        private BaseCharacter character;
        
        void SetupPlayer()
        {
            character = GameManager._gameManager.getCharacterSelected();
            playerImage.sprite = character.CharacterSprite;
            playerInput.SetMoveSpeed(character.MoveSpeed);
            playerHealth.SetEntityMaxHP(character.CharacterHP);
            playerHealth.ResetEntityHP();
            // Instantiate weapon
            animator.runtimeAnimatorController = character.CharacterAnimator;

            // End of method runs
            Destroy(this.gameObject);
        }
    }
}
