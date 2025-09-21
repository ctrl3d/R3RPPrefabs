#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
quaternionRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class QuaternionRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<Quaternion> current = new(new Quaternion());
        public ReactiveProperty<Quaternion> Current => current;
        public void SetValue(Quaternion value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif