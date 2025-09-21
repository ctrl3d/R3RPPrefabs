#if USE_R3
using R3;
using UnityEngine;

#region CodeSnippet

/*
animationCurveRP.Current.Subscribe(value =>
{

}).AddTo(this);
*/

#endregion

namespace work.ctrl3d
{
    public class AnimationCurveRP : MonoBehaviour
    {
        [SerializeField] private SerializableReactiveProperty<AnimationCurve> current = new(new AnimationCurve());

        public ReactiveProperty<AnimationCurve> Current => current;
        public void SetValue(AnimationCurve value) => Current.Value = value;
        private void OnValidate() => SetValue(Current.Value);
        public override string ToString() => Current.Value.ToString();
    }
}
#endif