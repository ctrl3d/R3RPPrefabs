#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
stringRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class StringRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<string> current = new("");
        public ReactiveProperty<string> Current => current;
        public void SetValue(string value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value;
    }
}
#endif