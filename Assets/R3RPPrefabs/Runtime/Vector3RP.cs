#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
vector3RP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class Vector3RP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<Vector3> current = new(new Vector3());
        public ReactiveProperty<Vector3> Current => current;
        public void SetValue(Vector3 value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif