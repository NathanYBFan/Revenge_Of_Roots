using UnityEngine;

namespace ROR.Player
{
    [CreateAssetMenu(fileName = "BaseAttacks", menuName = "ROR/BaseAttacks", order = 2)]
    public class PlayerBaseAttack : ScriptableObject
    {
        // Required Base Attack Stats
        [SerializeField] private float attackRange;
        [SerializeField] private float attackSpeed;
        [SerializeField] private float attackCoolDown;
        [SerializeField] private int attackDamage;
        [SerializeField] private float attackAccuracy;
        // int attackAmmo { get; set; }
        [SerializeField] private GameObject weaponPrefab;
        [SerializeField] private GameObject projectilePrefab;
        [SerializeField] private RuntimeAnimatorController weaponAnimator;

    }
}
