#if USE_R3
using R3;
using TMPro;
using UnityEngine;

namespace work.ctrl3d
{
    public class StringRPInputFieldBinder : MonoBehaviour
    {
        [SerializeField] private StringRP stringRP;
        [SerializeField] private TMP_InputField inputField;

        private void Start()
        {
            stringRP.Current.Subscribe(value => { inputField.text = value; }).AddTo(this);
            inputField.onValueChanged.AddListener(value => { stringRP.Current.Value = value; });
        }
    }
}
#endif