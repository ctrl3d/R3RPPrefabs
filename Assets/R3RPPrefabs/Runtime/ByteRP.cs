#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
byteRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class ByteRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<byte> current = new(0);
        public ReactiveProperty<byte> Current => current;
        public void SetValue(byte value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif