#if USE_R3
using System.Globalization;
using R3;
using UnityEngine;

#region CodeSnippet

/*
doubleRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class DoubleRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<double> current = new(0);
        public ReactiveProperty<double> Current => current;
        public void SetValue(double value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString(CultureInfo.InvariantCulture);
    }
}
#endif