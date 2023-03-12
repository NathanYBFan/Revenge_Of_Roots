using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;
namespace ROR
{
    public class SelectButtonManager : MonoBehaviour
    {
        [SerializeField] private Outline[] buttonOutlineToggles;
        [SerializeField, Required] private GameObject confirmButton;

        public void Awake() {
            disableAllOutlines();
            DisableConfirmButton();
        }

        public void disableAllOutlines() {
            foreach (Outline o in buttonOutlineToggles)
                o.enabled = false;
        }

        // 0 Based
        public void enableOutline(int buttonOutlineToToggle) {
            disableAllOutlines();
            buttonOutlineToggles[buttonOutlineToToggle].enabled = true;
        }

        public void DisableConfirmButton() { confirmButton.SetActive(false); }
        public void EnableConfirmButton() { confirmButton.SetActive(true); }
    }
}
