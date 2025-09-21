#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
intRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class IntRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<int> current = new(0);
        public ReactiveProperty<int> Current => current;
        public void SetValue(int value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif