#if USE_R3
using System.Globalization;
using R3;
using UnityEngine;

#region CodeSnippet

/*
floatRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class FloatRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<float> current = new(0);
        public ReactiveProperty<float> Current => current;
        public void SetValue(float value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString(CultureInfo.InvariantCulture);
    }
}
#endif