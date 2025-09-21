#if USE_R3
using R3;
using TMPro;
using UnityEngine;

namespace work.ctrl3d
{
    public class IntRPDropdownBinder : MonoBehaviour
    {
        [SerializeField] private IntRP intRP;
        [SerializeField] private TMP_Dropdown dropdown;
        
        private void Start()
        {
            intRP.Current.Subscribe(value =>
            {
                dropdown.value = value;
            });
            
            dropdown.onValueChanged.AddListener(value =>
            {
                intRP.SetValue(value);
            });
        }
    }
}
#endif