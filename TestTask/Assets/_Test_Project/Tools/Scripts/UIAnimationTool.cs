using DG.Tweening;
using UnityEngine;

namespace _Test_Project.Tools.Scripts
{
    public static class UIAnimationTool
    {
        public static void ScaleAnimation(this Transform target, float scaleMultiplier = 1.2f, float duration = 0.2f)
        {
            target.DOScale(Vector3.one * scaleMultiplier, duration).OnComplete(() =>
            {
                target.DOScale(Vector3.one, duration);
            });
        }
    }
}