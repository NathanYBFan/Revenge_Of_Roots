using UnityEngine;

namespace ROR.Player
{
    [CreateAssetMenu(fileName = "Character", menuName = "ROR/Character", order = 0)]
    public class BaseCharacter : ScriptableObject
    {
        [SerializeField] private string characterName = "Test01";
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private float moveSpeed = 5;
        [SerializeField] private int characterHP = 100;
        [SerializeField] private GameObject weaponPrefab;
        [SerializeField] private RuntimeAnimatorController characterAnimator;
        public string CharacterName => characterName;
        public Sprite CharacterSprite => characterSprite;
        public float MoveSpeed => moveSpeed;
        public int CharacterHP => characterHP;
        public GameObject WeaponPrefab => weaponPrefab;
        public RuntimeAnimatorController CharacterAnimator => characterAnimator;
    }
}
