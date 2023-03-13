using UnityEngine;
using ROR.Entity;

namespace ROR.Enemy.Movement
{
    public class EnemyInitializer : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer EnemyImage;
        [SerializeField] private EnemyInput enemyInput;
        [SerializeField] private EntityHealth enemyHealth;
        [SerializeField] private GameObject weaponParent;
        [SerializeField] private Animator animator;

        void Awake()
        {
            // Initialize everything above
            Destroy(GetComponent<EnemyInitializer>());
        }
    }
}
