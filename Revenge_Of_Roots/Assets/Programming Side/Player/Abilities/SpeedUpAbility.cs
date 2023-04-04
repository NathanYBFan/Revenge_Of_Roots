using System.Collections;
using UnityEngine;
using ROR.Player.Movement;
using NaughtyAttributes;

namespace ROR
{
    public class SpeedUpAbility : AbilityInterface
    {
        [SerializeField] private PlayerInput playerInput;
        [SerializeField, ReadOnly] private IEnumerator abilityCoroutine;
        [SerializeField, Range(1, 15)] private float effectLast;
        [SerializeField, Range(1, 15)] private float cooldown;
        void OnEnable() {
            abilityCoroutine = Activate();
            StartCoroutine(abilityCoroutine);
        }

        public override IEnumerator Activate() {
            while (!playerInput.GetIsDead()) {
                Debug.Log("Set");
                yield return StartCoroutine(PlayerSpeedUp());
            }
        }

        private IEnumerator PlayerSpeedUp() {
            float moveSpeedToAdd = playerInput.GetMoveSpeed() * 2f;
            playerInput.SetMoveSpeed(playerInput.GetMoveSpeed() + moveSpeedToAdd);
            yield return new WaitForSeconds(effectLast);
            playerInput.SetMoveSpeed(playerInput.GetMoveSpeed() - moveSpeedToAdd);
            yield return new WaitForSeconds(cooldown);
        }
        
        private IEnumerator playerAttackSpeedUp() {
            float attackSpeedToAdd = playerInput.GetAttackSpeed() * 0.2f;
            playerInput.SetAttackSpeed(playerInput.GetAttackSpeed() + attackSpeedToAdd);
            yield return new WaitForSeconds(1f);
            playerInput.SetAttackSpeed(playerInput.GetAttackSpeed() - attackSpeedToAdd);
        }
    }
}
