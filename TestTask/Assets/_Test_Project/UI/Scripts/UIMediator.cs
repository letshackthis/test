using _Test_Project.Player.Scripts;
using UnityEngine;

namespace _Test_Project.UI.Scripts
{
    public class UIMediator : MonoBehaviour
    {
        [SerializeField] private TopBar topBar;
        [SerializeField] private BottomBar bottomBar;
        [SerializeField] private PlayerSpeedController playerSpeedController;
        public void SetCollectedAmount(int totalCollectables) => topBar.SetCollectedAmount(totalCollectables);
        public void UpdateCollectablesAmount() => topBar.IncreaseCurrentCollectables();
        public void UpdatePlayerSpeedValue(int speedValue) => playerSpeedController.ChangePlayerSpeed(speedValue);
        public void SetPlayerStartSpeed(int speedValue) => bottomBar.SetStartPlayerSpeed(speedValue);

    }
}
