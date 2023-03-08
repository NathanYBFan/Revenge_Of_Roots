using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

namespace ROR.Player
{
    public class PlayerUnitObject : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer renderer2D;
        [SerializeField] private Animator animator;
        public Animator GetAnimator => animator;

        [SerializeField] GameObject model;

        private BaseCharacter character;
        public BaseCharacter Character => character;

        [ShowNonSerializedField]
        private int currentHitPoints;
        public int HitPoints => currentHitPoints;

        public Vector2Int currentPosition;
        public Vector2Int CurrentPosition => CurrentPosition;

        public void Setup(BaseCharacter character)
        {
            this.character = character;
            currentHitPoints = character.CharacterHP;
        }
    }
}
