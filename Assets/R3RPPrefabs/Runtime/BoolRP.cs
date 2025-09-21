#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
boolRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class BoolRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<bool> current = new(false);
        public ReactiveProperty<bool> Current => current;
        public void SetValue(bool value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif