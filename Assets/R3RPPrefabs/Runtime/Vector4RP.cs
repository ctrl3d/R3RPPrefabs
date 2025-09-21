#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
vector4RP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class Vector4RP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<Vector4> current = new(new Vector4());
        public ReactiveProperty<Vector4> Current => current;
        public void SetValue(Vector4 value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif