using UnityEngine;
using UnityEngine.UI;
namespace ROR
{
    public class StageSelectButtonManager : MonoBehaviour
    {
        [SerializeField] private Outline[] buttonOutlineToggles;

        public void Awake() {
            disableAllOutlines();
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
    }
}
