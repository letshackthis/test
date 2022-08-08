using UnityEngine;

namespace _Test_Project.Player.Scripts
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "GameData/CharacterData")]
    public class CharacterData : ScriptableObject
    {
        [SerializeField] private int initSpeed, minSpeed, maxSpeed;
        [SerializeField] private Color initColor;

        public Color InitColor => initColor;

        public int InitSpeed => initSpeed;

        public int MinSpeed => minSpeed;

        public int MaxSpeed => maxSpeed;
    }
}
