using UnityEngine;
using UnityEngine.EventSystems;

namespace _Test_Project.Tools.Scripts
{
    public static class DetectUIClick
    {
        public static bool IsPointerOverGameObject()
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return true;

            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                if (EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
                    return true;
            }

            return false;
        }
    }
}