using UnityEngine;

namespace ROR.Player
{
    [CreateAssetMenu(fileName = "Character", menuName = "ROR/Character", order = 0)]
    public class BaseCharacter : ScriptableObject
    {
        [SerializeField] private string characterName;
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private float moveSpeed = 3;
        [SerializeField] private GameObject weapon;
        [SerializeField] private RuntimeAnimatorController characterAnimator;
        public string CharacterName => characterName;
        public Sprite CharacterSprite => characterSprite;
        public float MoveSpeed => moveSpeed = 3;
        public GameObject Weapon => weapon;
        public RuntimeAnimatorController CharacterAnimator => characterAnimator;
    }
}
