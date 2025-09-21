#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
vector2RP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class Vector2RP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<Vector2> current = new(new Vector2());
        public ReactiveProperty<Vector2> Current => current;
        public void SetValue(Vector2 value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif