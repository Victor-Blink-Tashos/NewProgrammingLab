using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyController : MonoBehaviour
{
    // Start is called before the first frame update
    public DifficultySelectorEnum difficultySelector;

    Button btn;
    public enum DifficultySelectorEnum
    {
        Easy = 1,

        Normal = 2,

        Hard = 3

    }

}
