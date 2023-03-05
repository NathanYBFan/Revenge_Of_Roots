using UnityEngine;
namespace ROR.Player
{
    [CreateAssetMenu(fileName = "Effects", menuName = "ROR/Effects", order = 1)]
    public class Effects : ScriptableObject
    {
        [SerializeField] private float effectRange;
        [SerializeField] private float effectDamageSpeed;
        [SerializeField] private float effectDamageCoolDown;
        [SerializeField] private float effectLifeSpan;
        [SerializeField] private RuntimeAnimatorController effectAnimationController;
        public float EffectRange => effectRange;
        public float EffectDamageSpeed => effectDamageSpeed;
        public float EffectDamageCoolDown => effectDamageCoolDown;
        public float EffectLifeSpan => effectLifeSpan;
        public RuntimeAnimatorController EffectAnimationController => effectAnimationController;
    }
}
