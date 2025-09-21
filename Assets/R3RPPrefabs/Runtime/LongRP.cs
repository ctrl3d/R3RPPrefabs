#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
longRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class LongRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<long> current = new(0);
        public ReactiveProperty<long> Current => current;
        public void SetValue(long value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif