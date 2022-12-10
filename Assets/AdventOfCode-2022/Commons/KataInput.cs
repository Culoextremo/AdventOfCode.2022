using UnityEngine;

namespace AdventOfCode_2022
{
    [CreateAssetMenu(menuName = "AdventOfCode/KataInput")]
    public class KataInput : ScriptableObject
    {
        [field: SerializeField, TextArea] public string Text { get; private set; }
    }
}