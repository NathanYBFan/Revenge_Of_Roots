using UnityEngine;
using NaughtyAttributes;
using ROR.Entity;

namespace ROR
{
    public class CollisionDamage : MonoBehaviour
    {
        [SerializeField, Tag] private string TagToDamage;
        [SerializeField] private int damage = 12;
        void OnTriggerEnter2D(Collider2D collision) {
            if (collision.CompareTag(TagToDamage))
                collision.GetComponent<EntityHealth>().DamageEntityCurrentHp(damage);
        }
    }
}
