using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT26Main : MonoBehaviour
{
    public static int NFt26Amount;

    private void Awake()
    {
        NFt26Amount = PlayerPrefs.GetInt("NFt26Amount", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
