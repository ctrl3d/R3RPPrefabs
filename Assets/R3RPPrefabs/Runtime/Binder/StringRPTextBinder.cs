#if USE_R3
using R3;
using TMPro;
using UnityEngine;

namespace work.ctrl3d
{
    public class StringRPTextBinder : MonoBehaviour
    {
        [SerializeField] private StringRP stringRP;
        [SerializeField] private TMP_Text tmpText;

        private void Start()
        {
            stringRP.Current.Subscribe(value => { tmpText.text = value; }).AddTo(this);
        }
    }
}
#endif