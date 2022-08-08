using _Test_Project.UI.Scripts;
using UnityEngine;
using CharacterController = _Test_Project.Player.Scripts.CharacterController;

public abstract class Collectable : MonoBehaviour, ICollectable
{
    protected UIMediator _mediator;
    protected CharacterController _characterController;
    [SerializeField] protected ParticleSystem collectParticles;

    public virtual void Initialize(CharacterController controller, UIMediator mediator)
    {
        _characterController = controller;
        _mediator = mediator;
    }

    public virtual void Collect()
    {
        collectParticles.transform.SetParent(null);
        collectParticles.Play();
    }
}
