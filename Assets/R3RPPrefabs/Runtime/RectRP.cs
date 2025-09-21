#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
rectRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class RectRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<Rect> current = new(new Rect());
        public ReactiveProperty<Rect> Current => current;
        public void SetValue(Rect value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif