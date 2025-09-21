#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
boundsRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class BoundsRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<Bounds> current = new(new Bounds());
        public ReactiveProperty<Bounds> Current => current;
        public void SetValue(Bounds value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif