#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
colorRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class ColorRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<Color> current = new(new Color());
        public ReactiveProperty<Color> Current => current;
        public void SetValue(Color value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif