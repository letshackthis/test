using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

namespace _Test_Project.Player.Scripts
{
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private MeshRenderer meshRenderer;

        private Camera _mainCamera;
        private Vector3 _target = Vector3.zero;
        private Vector3 _mousePosition = Vector3.zero;

        public NavMeshAgent MeshAgent => navMeshAgent;

        public MeshRenderer MeshRenderer1 => meshRenderer;

        void Start()
        {
            _mainCamera = Camera.main;
        }

        void Update()
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (Input.GetMouseButtonDown(0) && CheckTargetPosition() || transform.position != _target)
                {
                    navMeshAgent.destination = _target;
                }
            }
        }

        private bool CheckTargetPosition()
        {
            _mousePosition = Input.mousePosition;

            if (!Physics.Raycast(_mainCamera.ScreenPointToRay(_mousePosition), out var hit, 100))
                return false;

            _target = hit.point;
            return true;
        }
    }
}