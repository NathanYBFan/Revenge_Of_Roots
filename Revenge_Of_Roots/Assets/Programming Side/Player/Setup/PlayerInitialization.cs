using UnityEngine;

namespace ROR.Player.Movement
{
    public class PlayerInitialization : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer playerImage;
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private PlayerHealth playerHealth;
        [SerializeField] private GameObject weaponParent;
        [SerializeField] private Animator animator;
        private BaseCharacter character;
        
        void Start()
        {
            character = GameManager._gameManager.getCharacterSelected();
            playerImage.sprite = character.CharacterSprite;
            playerInput.SetMoveSpeed(character.MoveSpeed);
            playerHealth.SetPlayerMaxHP(character.CharacterHP);
            playerHealth.ResetPlayerHP();
            // Instantiate weapon
            animator.runtimeAnimatorController = character.CharacterAnimator;

            // End of method runs
            Destroy(this.gameObject);
        }
    }
}
