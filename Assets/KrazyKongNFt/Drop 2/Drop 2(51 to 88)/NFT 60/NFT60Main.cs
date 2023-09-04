using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT60Main : MonoBehaviour
{
    public static int NFt60Amount;

    private void Awake()
    {
        NFt60Amount = PlayerPrefs.GetInt("NFt60Amount", 0);
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
